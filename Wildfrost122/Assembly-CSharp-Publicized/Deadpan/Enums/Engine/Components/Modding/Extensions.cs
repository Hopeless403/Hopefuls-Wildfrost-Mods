// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.Extensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public static class Extensions
  {
    public static CardData[] GetCategoryCardData(string category, bool mustBeFinal = true)
    {
      return AddressableLoader.GetGroup<CardData>("CardData").FindAll((Predicate<CardData>) (a =>
      {
        if ((!(a.cardType.name == category) || a.isEnemyClunker) && (!(a.cardType.name == "Clunker") || !a.isEnemyClunker || !(category == "Enemy")))
          return false;
        if (!mustBeFinal)
          return true;
        LocalizedString titleKey = a.titleKey;
        return titleKey != null && !titleKey.IsEmpty;
      })).ToArray();
    }

    public static StatusEffectDataBuilder SetSummonPrefabRef(
      this StatusEffectDataBuilder inst,
      string name = "SummonCreateCard")
    {
      inst.FreeModify<StatusEffectSummon>((Action<StatusEffectSummon>) (summon => summon.effectPrefabRef = (AssetReference) new AssetReferenceGameObject(name)));
      return inst;
    }

    public static bool IsCharm(this CardUpgradeData inst)
    {
      return MetaprogressionSystem.Get<List<string>>("charms").Contains(inst.name);
    }

    public static void AddToCharms(this CardUpgradeData inst, UnlockData data)
    {
      MetaprogressionSystem.Add<string, string>("charms", data.name, inst.name);
    }

    public static bool RemoveFromCharms(this CardUpgradeData inst, UnlockData data)
    {
      return MetaprogressionSystem.Remove<string, string>("charms", data.name, inst.name);
    }

    public static bool IsCompanion(this CardData inst)
    {
      return MetaprogressionSystem.Get<List<string>>("companions").Contains(inst.name);
    }

    public static void AddToCompanions(this CardData inst)
    {
      MetaprogressionSystem.Add<string>("companions", inst.name);
    }

    public static bool RemoveFromCompanions(this CardData inst)
    {
      return MetaprogressionSystem.Remove<string>("companions", inst.name);
    }

    public static bool IsItem(this CardData inst)
    {
      return MetaprogressionSystem.Get<List<string>>("items").Contains(inst.name);
    }

    public static void AddToItems(this CardData inst)
    {
      MetaprogressionSystem.Add<string>("items", inst.name);
    }

    public static bool RemoveFromItems(this CardData inst)
    {
      return MetaprogressionSystem.Remove<string>("items", inst.name);
    }

    public static bool IsPet(this CardData inst)
    {
      return MetaprogressionSystem.Get<Dictionary<string, string>>("pets").ContainsKey(inst.name);
    }

    public static void AddToPets(this CardData inst, string requiredUnlock = null)
    {
      MetaprogressionSystem.Add<string, string>("pets", inst.name, requiredUnlock);
    }

    public static bool RemoveFromPets(this CardData inst)
    {
      return MetaprogressionSystem.Remove<string, string>("pets", inst.name, (string) null);
    }

    public static T[] RemoveFromArray<T>(this T[] sequence, T item)
    {
      return ((IEnumerable<T>) sequence).Where<T>((Func<T, bool>) (a => !a.Equals((object) (T) item))).ToArray<T>();
    }

    public static T[] RemoveFromArray<T>(this T[] sequence, Func<T, bool> item)
    {
      return ((IEnumerable<T>) sequence).Where<T>(item).ToArray<T>();
    }

    public static string PrefixGUID(string name, WildfrostMod mod)
    {
      return mod == null ? name : mod.GUID + "." + name;
    }

    public static string GetGUID(string name)
    {
      string str = name;
      int num1 = 0;
      int num2 = name.LastIndexOf('.') - num1;
      int startIndex = num1;
      int length = num2;
      return str.Substring(startIndex, length);
    }

    public static WildfrostMod GetModFromGuid(string guid)
    {
      return Bootstrap.Mods.ToList<WildfrostMod>().Find((Predicate<WildfrostMod>) (a => a.GUID == guid));
    }

    public static CardAnimationProfile GetCardAnimationProfile(string name)
    {
      return Addressables.LoadAssetAsync<CardAnimationProfile>((object) name).WaitForCompletion();
    }

    public static TargetMode GetTargetMode(string name)
    {
      return Addressables.LoadAssetAsync<TargetMode>((object) name).WaitForCompletion();
    }

    public static void WithPools(this CardData data, params RewardPool[] pools)
    {
      foreach (RewardPool pool in pools)
        pool.list.Add((DataFile) data);
    }

    public static void AddPool(this CardData data, RewardPool pool)
    {
      pool.list.Add((DataFile) data);
    }

    public static void WithPools(this CardUpgradeData data, params RewardPool[] pools)
    {
      foreach (RewardPool pool in pools)
        pool.list.Add((DataFile) data);
    }

    public static void AddPool(this CardUpgradeData data, RewardPool pool)
    {
      pool.list.Add((DataFile) data);
    }

    public static LocalizedString GetLocalizedString(string table, string key)
    {
      return LocalizationHelper.GetCollection(table, new LocaleIdentifier(SystemLanguage.English)).GetString(key);
    }

    public static HashSet<RewardPool> GetAllRewardPools()
    {
      HashSet<RewardPool> list = new HashSet<RewardPool>();
      foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
        list.AddRange<RewardPool>((IEnumerable<RewardPool>) classData.rewardPools);
      return list;
    }

    public static Y Edit<T, Y>(this T data)
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      Y y = new Y();
      y.Mod = data.ModAdded ?? (WildfrostMod) new InternalMod((string) null);
      y._data = data;
      return y;
    }

    public static RewardPool GetRewardPool(string name)
    {
      foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
      {
        foreach (RewardPool rewardPool in classData.rewardPools)
        {
          if (rewardPool.name == name)
            return rewardPool;
        }
      }
      return (RewardPool) null;
    }

    public static Texture2D ToTex(this string path)
    {
      Texture2D tex = new Texture2D(0, 0, TextureFormat.RGBA32, false);
      if (!File.Exists(path))
        return tex;
      tex.LoadImage(File.ReadAllBytes(path));
      return tex;
    }

    public static Sprite ToSprite(this string path) => path.ToTex().ToSprite();

    public static Sprite ToSprite(this Texture2D t, Vector2? v = null)
    {
      Vector2 pivot = v ?? new Vector2(0.5f, 0.5f);
      return Sprite.Create(t, new Rect(0.0f, 0.0f, (float) t.width, (float) t.height), pivot);
    }
  }
}
