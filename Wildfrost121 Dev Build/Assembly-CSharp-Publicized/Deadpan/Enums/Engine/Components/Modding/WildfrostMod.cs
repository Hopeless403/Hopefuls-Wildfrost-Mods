// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.WildfrostMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public abstract class WildfrostMod : IComparable<WildfrostMod>
  {
    public string ModDirectory;
    public Sprite _iconSprite;
    public Harmony HarmonyInstance;
    [CompilerGenerated]
    public bool \u003CHasLoaded\u003Ek__BackingField;
    [CompilerGenerated]
    public readonly TMP_SpriteAsset \u003CSpriteAsset\u003Ek__BackingField;
    public static List<System.Type> AllBuiledrs = typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a =>
    {
      System.Type baseType = a.BaseType;
      return (object) baseType != null && baseType.IsGenericType && a.BaseType.GetGenericTypeDefinition() == typeof (DataFileBuilder<,>);
    }));
    public static List<System.Type> AllDataTypes = typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a => a.BaseType == typeof (DataFile)));

    public T GetAsset<T>(string name)
    {
      return Addressables.LoadAssetAsync<T>((object) name).WaitForCompletion();
    }

    public Sprite GetImageSprite(string relPath) => this.RelToAbsPath(relPath).ToSprite();

    public string RelToAbsPath(params string[] relPath)
    {
      string[] strArray = new string[relPath.Length + 1];
      strArray[0] = this.ModDirectory;
      for (int index = 1; index < strArray.Length; ++index)
        strArray[index] = relPath[index - 1];
      return Path.Combine(strArray);
    }

    public CardData.TraitStacks CreateTraitStack(string name, int amount)
    {
      return new CardData.TraitStacks(this.Get<TraitData>(name), amount);
    }

    public CardData.StatusEffectStacks CreateEffectStack(string name, int amount)
    {
      return new CardData.StatusEffectStacks(this.Get<StatusEffectData>(name), amount);
    }

    [Obsolete("Use one without type parameters", true)]
    public CardData.StatusEffectStacks CreateEffectStack<T>(string name, int amount) where T : StatusEffectData
    {
      return new CardData.StatusEffectStacks(this.Get<StatusEffectData>(name), amount);
    }

    public T Get<T>(string name) where T : DataFile
    {
      T obj = AddressableLoader.Get<T>(typeof (T).Name, Extensions.PrefixGUID(name, this));
      return (bool) (UnityEngine.Object) obj ? obj : AddressableLoader.Get<T>(typeof (T).Name, name);
    }

    public T GetStatusEffect<T>(string name) where T : StatusEffectData
    {
      StatusEffectData statusEffectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", Extensions.PrefixGUID(name, this));
      return (bool) (UnityEngine.Object) statusEffectData ? (T) statusEffectData : (T) AddressableLoader.Get<StatusEffectData>("StatusEffectData", name);
    }

    public static WildfrostMod[] GetLastMods()
    {
      string[] source = SaveSystem.LoadProgressData<string[]>("lastSavedMods");
      return source != null ? ((IEnumerable<string>) source).Select<string, WildfrostMod>(new Func<string, WildfrostMod>(Extensions.GetModFromGuid)).ToArray<WildfrostMod>() : new WildfrostMod[0];
    }

    public static void SetLastMods(WildfrostMod[] enabled)
    {
      SaveSystem.SaveProgressData<string[]>("lastSavedMods", ((IEnumerable<WildfrostMod>) enabled).Select<WildfrostMod, string>((Func<WildfrostMod, string>) (a => a.GUID)).ToArray<string>());
    }

    public WildfrostMod.ConfigStorage FromConfigs()
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

    public virtual Sprite IconSprite
    {
      get => this._iconSprite ?? (this._iconSprite = this.IconPath.ToSprite());
    }

    public abstract string GUID { get; }

    public abstract string[] Depends { get; }

    public abstract string Title { get; }

    public abstract string Description { get; }

    public bool HasLoaded
    {
      get => this.\u003CHasLoaded\u003Ek__BackingField;
      set => this.\u003CHasLoaded\u003Ek__BackingField = value;
    }

    public virtual string ImagesDirectory => Path.Combine(this.ModDirectory, "images");

    public virtual TMP_SpriteAsset SpriteAsset => this.\u003CSpriteAsset\u003Ek__BackingField;

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

    public void UnloadModsDependantOnThis()
    {
      foreach (WildfrostMod wildfrostMod in Bootstrap.Mods.Where<WildfrostMod>((Func<WildfrostMod, bool>) (a => a.HasLoaded && a.Depends.Contains<string>(this.GUID))))
        wildfrostMod.ModUnload();
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
      Events.InvokeModLoaded(this);
    }

    public void UpdateSave()
    {
      WildfrostMod.SetLastMods(Bootstrap.Mods.ToList<WildfrostMod>().FindAll((Predicate<WildfrostMod>) (a => a.HasLoaded)).ToArray());
    }

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

    public virtual void Load()
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

    public WildfrostMod.BuilderToBuilt<T, Y> AddAllTAssetsToGroup<T, Y>()
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
      this.UnloadModsDependantOnThis();
      this.UpdateSave();
      Events.InvokeModUnloaded(this);
    }

    public virtual void Unload()
    {
      if (!this.HasLoaded)
        return;
      this.HarmonyInstance.UnpatchAll(this.HarmonyInstance.Id);
      this.HasLoaded = false;
      foreach (System.Type type in typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a => a.BaseType == typeof (DataFile))))
        typeof (WildfrostMod).GetMethod("RemoveeAllTAssetsFromGroup", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(type).Invoke((object) this, new object[0]);
    }

    public void RemoveeAllTAssetsFromGroup<T>() where T : DataFile
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

    public WildfrostMod() => this.HarmonyInstance = new Harmony(this.GUID);

    static WildfrostMod()
    {
      Harmony.DEBUG = true;
      HarmonyFileLog.Enabled = true;
      HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Info | HarmonyLib.Tools.Logger.LogChannel.Debug;
      HarmonyFileLog.Writer = (TextWriter) new WildfrostMod.DebugLoggerTextWriter();
    }

    public void WriteLine(string text) => Debug.Log((object) ("[" + this.GUID + "] " + text));

    public void WriteWarn(string text)
    {
      Debug.LogWarning((object) ("[" + this.GUID + "] " + text));
    }

    public void WriteError(string text) => Debug.LogError((object) ("[" + this.GUID + "] " + text));

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
      Steamworks.Ugc.Item curItem = entries.Find(new Predicate<Steamworks.Ugc.Item>(wildfrostMod.\u003CUpdateOrPublishWorkshop\u003Eb__62_1));
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

    [CompilerGenerated]
    public bool \u003CUnloadModsDependantOnThis\u003Eb__42_0(WildfrostMod a)
    {
      return a.HasLoaded && a.Depends.Contains<string>(this.GUID);
    }

    [CompilerGenerated]
    public bool \u003CUpdateOrPublishWorkshop\u003Eb__62_1(Steamworks.Ugc.Item a)
    {
      return a.Metadata == this.GUID;
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class ConfigItemAttribute : Attribute
    {
      public string comment;
      public string forceTitle;
      public string fieldName;
      public string defaultValue;

      public string Title
      {
        get => !string.IsNullOrEmpty(this.forceTitle) ? this.forceTitle : this.fieldName;
      }

      [Obsolete("Use new constructor", true)]
      public ConfigItemAttribute(object defaultValue, string forceTitle = null)
      {
        this.comment = "";
        this.forceTitle = forceTitle;
        this.defaultValue = TypeDescriptor.GetConverter(defaultValue.GetType()).ConvertToString(defaultValue);
      }

      public ConfigItemAttribute(object defaultValue, string comment = "", string forceTitle = null)
      {
        this.comment = comment;
        this.forceTitle = forceTitle;
        this.defaultValue = TypeDescriptor.GetConverter(defaultValue.GetType()).ConvertToString(defaultValue);
      }
    }

    public struct ConfigStorage
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
          stringBuilder.AppendLine("//" + tuple.atr.comment);
          stringBuilder.AppendLine(tuple.field.FieldType.FullName + " : " + tuple.atr.Title + " = " + tuple.atr.defaultValue);
        }
        File.WriteAllText(name, stringBuilder.ToString());
      }

      public void ReadFromFile(string name)
      {
        int num1 = 0;
        while (true)
        {
          try
          {
            IEnumerable<string> strings = File.ReadLines(name);
            foreach ((WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple in this.Store)
              tuple.atr.fieldName = tuple.field.Name;
            List<(WildfrostMod.ConfigItemAttribute atr, FieldInfo field)> list = this.Store.ToList<(WildfrostMod.ConfigItemAttribute, FieldInfo)>();
            using (IEnumerator<string> enumerator = strings.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                string current = enumerator.Current;
                if (!current.StartsWith("//"))
                {
                  int num2 = current.IndexOf(':');
                  int num3 = current.IndexOf('=');
                  string name1 = current.Substring(0, num2 - 1 - 0);
                  string str1 = current;
                  int num4 = num2 + 2;
                  int num5 = num3 - 1 - num4;
                  int startIndex1 = num4;
                  int length1 = num5;
                  string title = str1.Substring(startIndex1, length1);
                  string str2 = current;
                  int length2 = str2.Length;
                  int startIndex2 = num3 + 2;
                  int num6 = startIndex2;
                  int length3 = length2 - num6;
                  string text = str2.Substring(startIndex2, length3);
                  (WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple = list.Find((Predicate<(WildfrostMod.ConfigItemAttribute, FieldInfo)>) (a => a.atr.Title == title));
                  (WildfrostMod.ConfigItemAttribute atr, FieldInfo field) = tuple;
                  if (atr == null && field == (FieldInfo) null)
                    throw new WildfrostMod.ConfigStorage.FileIsCorrupted("Config error, no store");
                  if (tuple.field == (FieldInfo) null)
                    throw new Exception("Config value not found " + tuple.atr.Title);
                  System.Type type1 = (System.Type) null;
                  foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                  {
                    System.Type type2 = assembly.GetType(name1);
                    if (type2 != (System.Type) null)
                    {
                      type1 = type2;
                      break;
                    }
                  }
                  object obj = !(type1 == (System.Type) null) ? TypeDescriptor.GetConverter(type1).ConvertFromInvariantString(text) : throw new Exception("Unknown value type " + name1);
                  tuple.field.SetValue((object) this.Mod, obj);
                }
              }
              break;
            }
          }
          catch (WildfrostMod.ConfigStorage.FileIsCorrupted ex)
          {
            ++num1;
            if (num1 > 1)
            {
              throw;
            }
            else
            {
              File.Delete(name);
              this.WriteToFile(name);
            }
          }
        }
      }

      public class FileIsCorrupted : Exception
      {
        public FileIsCorrupted(string s)
          : base(s)
        {
        }
      }
    }

    public struct BuilderToBuilt<T, Y>
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      public List<T> built;
      public List<Y> builder;

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
        value = "[HARMONY] " + value;
        Debug.Log((object) value);
      }

      public override void WriteLine(string value)
      {
        value = "[HARMONY] " + value;
        Debug.Log((object) (value + "\n"));
      }
    }
  }
}
