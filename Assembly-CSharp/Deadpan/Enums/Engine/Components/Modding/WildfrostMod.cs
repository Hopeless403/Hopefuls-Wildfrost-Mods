// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.WildfrostMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using HarmonyLib;
using HarmonyLib.Tools;
using JetBrains.Annotations;
using Steamworks;
using Steamworks.Ugc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public abstract class WildfrostMod : IComparable<WildfrostMod>
  {
    public string ModDirectory;
    protected Sprite _iconSprite;
    protected Harmony HarmonyInstance;
    public static List<System.Type> AllBuiledrs = typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a =>
    {
      System.Type baseType = a.BaseType;
      return (object) baseType != null && baseType.IsGenericType && a.BaseType.GetGenericTypeDefinition() == typeof (DataFileBuilder<,>);
    }));
    public static List<System.Type> AllDataTypes = typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a => a.BaseType == typeof (DataFile)));

    internal static WildfrostMod[] GetLastMods()
    {
      string[] source = SaveSystem.LoadProgressData<string[]>("lastSavedMods");
      return source != null ? ((IEnumerable<string>) source).Select<string, WildfrostMod>(new Func<string, WildfrostMod>(Extensions.GetModFromGuid)).ToArray<WildfrostMod>() : new WildfrostMod[0];
    }

    internal static void SetLastMods(WildfrostMod[] enabled) => SaveSystem.SaveProgressData<string[]>("lastSavedMods", ((IEnumerable<WildfrostMod>) enabled).Select<WildfrostMod, string>((Func<WildfrostMod, string>) (a => a.GUID)).ToArray<string>());

    private WildfrostMod.ConfigStorage FromConfigs()
    {
      (WildfrostMod.ConfigItemAttribute, FieldInfo)[] configs = this.GetConfigs();
      return new WildfrostMod.ConfigStorage()
      {
        Store = configs,
        Mod = this
      };
    }

    public (WildfrostMod.ConfigItemAttribute atr, FieldInfo field)[] GetConfigs()
    {
      List<(WildfrostMod.ConfigItemAttribute, FieldInfo)> valueTupleList = new List<(WildfrostMod.ConfigItemAttribute, FieldInfo)>();
      foreach (FieldInfo field in this.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public))
      {
        WildfrostMod.ConfigItemAttribute customAttribute = field.GetCustomAttribute<WildfrostMod.ConfigItemAttribute>();
        if (customAttribute != null)
          valueTupleList.Add((customAttribute, field));
      }
      return valueTupleList.ToArray();
    }

    public WildfrostMod(string modDirectory)
      : this()
    {
      this.ModDirectory = modDirectory;
    }

    public virtual string IconPath => Path.Combine(this.ModDirectory, "icon.png");

    public virtual Sprite IconSprite => this._iconSprite ?? (this._iconSprite = this.IconPath.ToSprite());

    public abstract string GUID { get; }

    public abstract string[] Depends { get; }

    public abstract string Title { get; }

    public abstract string Description { get; }

    public bool HasLoaded { get; private set; }

    public string ImagesDirectory => Path.Combine(this.ModDirectory, "images");

    public string ImagePath(string fileName) => Path.Combine(this.ImagesDirectory, fileName);

    public WildfrostMod[] GetDependancies(bool throwIfNotFound = true)
    {
      ILookup<string, WildfrostMod> look = Bootstrap.Mods.ToLookup<WildfrostMod, string>((Func<WildfrostMod, string>) (a => a.GUID));
      List<(string, WildfrostMod)> list = ((IEnumerable<string>) this.Depends).Select<string, (string, WildfrostMod)>((Func<string, (string, WildfrostMod)>) (a => (a, look[a].FirstOrDefault<WildfrostMod>()))).ToList<(string, WildfrostMod)>();
      if (throwIfNotFound)
      {
        (string, WildfrostMod) tuple = list.Find((Predicate<(string, WildfrostMod)>) (a => a.Item2 == null));
        if (tuple.Item2 == null && !string.IsNullOrEmpty(tuple.Item1))
          throw new Exception("Mod " + tuple.Item1 + " not found! While it is a dependency for " + this.GUID);
      }
      return list.Select<(string, WildfrostMod), WildfrostMod>((Func<(string, WildfrostMod), WildfrostMod>) (a => a.Item2)).ToArray<WildfrostMod>();
    }

    public void LoadDependancies()
    {
      foreach (WildfrostMod dependancy in this.GetDependancies())
        dependancy.ModLoad();
    }

    public void ModLoad()
    {
      if (this.HasLoaded)
        return;
      this.LoadDependancies();
      WildfrostMod.ConfigStorage configStorage = this.FromConfigs();
      string str = Path.Combine(this.ModDirectory, "config.cfg");
      if (!File.Exists(str))
        configStorage.WriteToFile(str);
      configStorage.ReadFromFile(str);
      this.Load();
      this.UpdateSave();
    }

    private void UpdateSave() => WildfrostMod.SetLastMods(Bootstrap.Mods.ToList<WildfrostMod>().FindAll((Predicate<WildfrostMod>) (a => a.HasLoaded)).ToArray());

    public void ModToggle()
    {
      if (this.HasLoaded)
      {
        this.ModUnload();
      }
      else
      {
        if (this.HasLoaded)
          return;
        this.ModLoad();
      }
    }

    protected virtual void Load()
    {
      this.HarmonyInstance.PatchAll(this.GetType().Assembly);
      List<System.Type> allBuiledrs = WildfrostMod.AllBuiledrs;
      List<System.Type> allDataTypes = WildfrostMod.AllDataTypes;
      Dictionary<System.Type, object> dictionary = new Dictionary<System.Type, object>();
      foreach (System.Type type1 in allDataTypes)
      {
        System.Type dataType = type1;
        System.Type type2 = allBuiledrs.Find((Predicate<System.Type>) (a => a.BaseType.GetGenericArguments()[0] == dataType));
        if (!(type2 == (System.Type) null))
        {
          object obj = typeof (WildfrostMod).GetMethod("AddAllTAssetsToGroup", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(dataType, type2).Invoke((object) this, new object[0]);
          dictionary.Add(dataType, obj);
        }
      }
      foreach (System.Type type3 in allDataTypes)
      {
        System.Type dataType = type3;
        System.Type type4 = allBuiledrs.Find((Predicate<System.Type>) (a => a.BaseType.GetGenericArguments()[0] == dataType));
        if (!(type4 == (System.Type) null))
        {
          object obj = dictionary[dataType];
          typeof (WildfrostMod.BuilderToBuilt<,>).MakeGenericType(dataType, type4).GetMethod("OnAfterAllModBuildsEvent", BindingFlags.Instance | BindingFlags.Public).Invoke(obj, new object[0]);
        }
      }
      this.HasLoaded = true;
    }

    private WildfrostMod.BuilderToBuilt<T, Y> AddAllTAssetsToGroup<T, Y>()
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      List<Y> yList = this.AddAssets<Y, T>();
      if (yList == null)
        return new WildfrostMod.BuilderToBuilt<T, Y>()
        {
          builder = new List<Y>(),
          built = new List<T>()
        };
      List<T> list = yList.Select<Y, T>((Func<Y, T>) (a => a.Build())).ToList<T>();
      if (list != null)
      {
        foreach (T obj in list)
        {
          obj.ModAdded = this;
          if (obj is CardData cardData && !(bool) (UnityEngine.Object) cardData.targetMode)
            throw new Exception("Card must have a target mode " + cardData.name);
        }
        AddressableLoader.AddRangeToGroup<T>(typeof (T).Name, (IEnumerable<T>) list);
      }
      return new WildfrostMod.BuilderToBuilt<T, Y>(list, yList);
    }

    [CanBeNull]
    public virtual List<T> AddAssets<T, Y>()
      where T : DataFileBuilder<Y, T>, new()
      where Y : DataFile
    {
      return (List<T>) null;
    }

    public void ModUnload()
    {
      if (!this.HasLoaded)
        return;
      this.Unload();
      this.UpdateSave();
    }

    protected virtual void Unload()
    {
      if (!this.HasLoaded)
        return;
      this.HarmonyInstance.UnpatchAll(this.HarmonyInstance.Id);
      this.HasLoaded = false;
      foreach (System.Type type in typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a => a.BaseType == typeof (DataFile))))
        typeof (WildfrostMod).GetMethod("RemoveeAllTAssetsFromGroup", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(type).Invoke((object) this, new object[0]);
    }

    private void RemoveeAllTAssetsFromGroup<T>() where T : DataFile
    {
      foreach (T obj in UnityEngine.Object.FindObjectsOfType<T>())
      {
        if (obj.ModAdded == this)
        {
          if (obj is CardData inst)
            inst.RemoveFromPets();
          AddressableLoader.RemoveFromGroup<T>(typeof (T).Name, obj);
          obj.Destroy();
        }
      }
    }

    private WildfrostMod()
    {
      this.HarmonyInstance = new Harmony(this.GUID);
      Harmony.DEBUG = true;
      HarmonyFileLog.Enabled = true;
      HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.All;
      HarmonyFileLog.Writer = (TextWriter) new WildfrostMod.DebugLoggerTextWriter();
    }

    public int CompareTo(WildfrostMod other)
    {
      if (this == other)
        return 0;
      return other == null ? 1 : string.Compare(this.GUID, other.GUID, StringComparison.Ordinal);
    }

    public async void UpdateOrPublishWorkshop()
    {
      WildfrostMod wildfrostMod = this;
      List<Steamworks.Ugc.Item> entries = (await new Query(UgcType.Items, user: SteamClient.SteamId).WithMetadata(true).WithTag("Mod").GetPageAsync(1)).Value.Entries.ToList<Steamworks.Ugc.Item>().FindAll((Predicate<Steamworks.Ugc.Item>) (a => a.Result != Steamworks.Result.FileNotFound));
      // ISSUE: reference to a compiler-generated method
      Steamworks.Ugc.Item curItem = entries.Find(new Predicate<Steamworks.Ugc.Item>(wildfrostMod.\u003CUpdateOrPublishWorkshop\u003Eb__46_1));
      PublishResult result;
      if (entries.Count == 0 || curItem.Equals((object) new Steamworks.Ugc.Item()))
      {
        Editor editor = Editor.NewCommunityFile;
        editor = editor.WithTitle(wildfrostMod.Title);
        editor = editor.WithDescription(wildfrostMod.Description);
        editor = editor.WithTag("Mod");
        editor = editor.ForAppId(SteamClient.AppId);
        editor = editor.WithPublicVisibility();
        editor = editor.WithPreviewFile(wildfrostMod.IconPath);
        editor = editor.WithContent(wildfrostMod.ModDirectory);
        editor = editor.WithMetaData(wildfrostMod.GUID);
        result = await editor.SubmitAsync();
        Steamworks.Ugc.Item? async = await Steamworks.Ugc.Item.GetAsync(result.FileId);
        foreach (string depend1 in wildfrostMod.Depends)
        {
          string depend = depend1;
          Steamworks.Ugc.Item obj = entries.Find((Predicate<Steamworks.Ugc.Item>) (a => a.Metadata == depend));
          if (!curItem.Equals((object) new Steamworks.Ugc.Item()) && async.HasValue)
            async.GetValueOrDefault().AddDependency(obj.Id);
        }
        Debug.Log((object) ("Upload result " + result.ToString()));
        result = new PublishResult();
        entries = (List<Steamworks.Ugc.Item>) null;
        curItem = new Steamworks.Ugc.Item();
      }
      else
      {
        Editor editor = new Editor(curItem.Id);
        editor = editor.WithTitle(wildfrostMod.Title);
        editor = editor.WithDescription(wildfrostMod.Description);
        editor = editor.WithTag("Mod");
        editor = editor.ForAppId(SteamClient.AppId);
        editor = editor.WithPublicVisibility();
        editor = editor.WithPreviewFile(wildfrostMod.IconPath);
        editor = editor.WithContent(wildfrostMod.ModDirectory);
        editor = editor.WithMetaData(wildfrostMod.GUID);
        result = await editor.SubmitAsync();
        Steamworks.Ugc.Item? async = await Steamworks.Ugc.Item.GetAsync(result.FileId);
        foreach (string depend2 in wildfrostMod.Depends)
        {
          string depend = depend2;
          Steamworks.Ugc.Item obj = entries.Find((Predicate<Steamworks.Ugc.Item>) (a => a.Metadata == depend));
          if (!curItem.Equals((object) new Steamworks.Ugc.Item()) && async.HasValue)
            async.GetValueOrDefault().AddDependency(obj.Id);
        }
        Debug.Log((object) ("Update result " + result.ToString()));
        result = new PublishResult();
        entries = (List<Steamworks.Ugc.Item>) null;
        curItem = new Steamworks.Ugc.Item();
      }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class ConfigItemAttribute : Attribute
    {
      public string forceTitle;
      public string fieldName;
      public string defaultValue;

      public string Title => !string.IsNullOrEmpty(this.forceTitle) ? this.forceTitle : this.fieldName;

      public ConfigItemAttribute(object defaultValue, string forceTitle = null)
      {
        this.forceTitle = forceTitle;
        this.defaultValue = TypeDescriptor.GetConverter(defaultValue.GetType()).ConvertToString(defaultValue);
      }
    }

    private struct ConfigStorage
    {
      public (WildfrostMod.ConfigItemAttribute atr, FieldInfo field)[] Store;
      public (string title, string value)[] Read;
      public WildfrostMod Mod;

      public void WriteToFile(string name)
      {
        StringBuilder stringBuilder = new StringBuilder();
        foreach ((WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple in this.Store)
        {
          tuple.atr.fieldName = tuple.field.Name;
          stringBuilder.AppendLine(tuple.field.FieldType.FullName + " : " + tuple.atr.Title + " = " + tuple.atr.defaultValue);
        }
        File.WriteAllText(name, stringBuilder.ToString());
      }

      public void ReadFromFile(string name)
      {
        IEnumerable<string> strings = File.ReadLines(name);
        foreach ((WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple in this.Store)
          tuple.atr.fieldName = tuple.field.Name;
        List<(WildfrostMod.ConfigItemAttribute atr, FieldInfo field)> list = this.Store.ToList<(WildfrostMod.ConfigItemAttribute, FieldInfo)>();
        foreach (string str in strings)
        {
          char[] separator = new char[3]{ ':', '=', ' ' };
          string[] strArray = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
          string typeName = strArray[0];
          string title = strArray[1];
          string text = strArray[2];
          (WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple = list.Find((Predicate<(WildfrostMod.ConfigItemAttribute, FieldInfo)>) (a => a.atr.Title == title));
          if (tuple.field == (FieldInfo) null)
            throw new Exception("Config value not found " + tuple.atr.Title);
          System.Type type = System.Type.GetType(typeName);
          object obj = !(type == (System.Type) null) ? TypeDescriptor.GetConverter(type).ConvertFromInvariantString(text) : throw new Exception("Unknown value type " + typeName);
          tuple.field.SetValue((object) this.Mod, obj);
        }
      }
    }

    internal struct BuilderToBuilt<T, Y>
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      internal List<T> built;
      internal List<Y> builder;

      public BuilderToBuilt(List<T> dataFiles, List<Y> builders)
      {
        this.built = dataFiles;
        this.builder = builders;
      }

      public void OnAfterAllModBuildsEvent()
      {
        for (int index = 0; index < this.builder.Count; ++index)
          this.builder[index].OnAfterAllModBuildsEvent(this.built[index]);
      }
    }

    public class DebugLoggerTextWriter : TextWriter
    {
      public override Encoding Encoding => Encoding.UTF8;

      public override void Write(string value)
      {
        base.Write(value);
        Debug.Log((object) value);
      }

      public override void WriteLine(string value)
      {
        base.Write(value);
        Debug.Log((object) (value + "\n"));
      }
    }
  }
}
