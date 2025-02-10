// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.Extensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public static class Extensions
  {
    public static CardData[] GetCategoryCardData(string category, bool mustBeFinal = true) => AddressableLoader.GetGroup<CardData>("CardData").FindAll((Predicate<CardData>) (a =>
    {
      if (!(a.cardType.name == category))
        return false;
      if (!mustBeFinal)
        return true;
      LocalizedString titleKey = a.titleKey;
      return titleKey != null && !titleKey.IsEmpty;
    })).ToArray();

    public static ClassData GetClassData(string name) => AddressableLoader.GetGroup<ClassData>("ClassData").Find((Predicate<ClassData>) (a => a.name == name));

    public static EyeData GetEyeData(string name) => AddressableLoader.GetGroup<EyeData>("EyeData").Find((Predicate<EyeData>) (a => a.name == name));

    public static EyeData GetEyeDataForCard(string cardName) => AddressableLoader.GetGroup<EyeData>("EyeData").Find((Predicate<EyeData>) (a => a.cardData == cardName));

    public static EyeData GetEyeDataForCard(CardData cardData) => AddressableLoader.GetGroup<EyeData>("EyeData").Find((Predicate<EyeData>) (a => a.cardData == cardData.name));

    public static CardData GetCardData(string name) => AddressableLoader.GetGroup<CardData>("CardData").Find((Predicate<CardData>) (a => a.name == name));

    public static CardUpgradeData GetCardUpgradeData(string name) => AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Find((Predicate<CardUpgradeData>) (a => a.name == name));

    public static ChallengeListener GetChallengeListener(string name) => AddressableLoader.GetGroup<ChallengeListener>("ChallengeListener").Find((Predicate<ChallengeListener>) (a => a.name == name));

    public static ChallengeData GetChallengeData(string name) => AddressableLoader.GetGroup<ChallengeData>("ChallengeData").Find((Predicate<ChallengeData>) (a => a.name == name));

    public static Sprite GetAddressableSprite(string name) => Addressables.LoadAssetAsync<Sprite>((object) name).WaitForCompletion();

    public static BuildingType GetBuildingType(string name) => AddressableLoader.GetGroup<BuildingType>("BuildingType").Find((Predicate<BuildingType>) (a => a.name == name));

    public static UnlockData GetUnlockData(string name) => AddressableLoader.GetGroup<UnlockData>("UnlockData").Find((Predicate<UnlockData>) (a => a.name == name));

    public static Sprite GetCardSprite(string name) => AddressableLoader.GetGroup<CardData>("CardData").Find((Predicate<CardData>) (a => a.name == name)).mainSprite;

    public static Sprite GetCardBackground(string name) => AddressableLoader.GetGroup<CardData>("CardData").Find((Predicate<CardData>) (a => a.name == name)).backgroundSprite;

    public static BloodProfile GetBloodProfile(string name) => Addressables.LoadAssetAsync<BloodProfile>((object) name).WaitForCompletion();

    public static StatusEffectData GetStatusEffectData(string name) => AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Find((Predicate<StatusEffectData>) (a => a.name == name));

    public static TraitData GetTraitData(string name) => AddressableLoader.GetGroup<TraitData>("TraitData").Find((Predicate<TraitData>) (a => a.name == name));

    public static CardType GetCardType(string name) => AddressableLoader.GetGroup<CardType>("CardType").Find((Predicate<CardType>) (a => a.name == name));

    public static CardData.StatusEffectStacks GetStatusEffectStacks(string name, int count) => new CardData.StatusEffectStacks(Extensions.GetStatusEffectData(name), count);

    public static T As<T>(this StatusEffectData effect) where T : StatusEffectData => (T) effect;

    public static StatusEffectDataBuilder SetSummonPrefabRef(
      this StatusEffectDataBuilder inst,
      string name = "SummonCreateCard")
    {
      inst.FreeModify<StatusEffectSummon>((Action<StatusEffectSummon>) (summon => summon.effectPrefabRef = (AssetReference) new AssetReferenceGameObject(name)));
      return inst;
    }

    public static bool IsCharm(this CardUpgradeData inst) => MetaprogressionSystem.Get<List<string>>("charms").Contains(inst.name);

    public static void AddToCharms(this CardUpgradeData inst, UnlockData data) => MetaprogressionSystem.Add<string, string>("charms", data.name, inst.name);

    public static bool RemoveFromCharms(this CardUpgradeData inst, UnlockData data) => MetaprogressionSystem.Remove<string, string>("charms", data.name, inst.name);

    public static bool IsCompanion(this CardData inst) => MetaprogressionSystem.Get<List<string>>("companions").Contains(inst.name);

    public static void AddToCompanions(this CardData inst) => MetaprogressionSystem.Add<string>("companions", inst.name);

    public static bool RemoveFromCompanions(this CardData inst) => MetaprogressionSystem.Remove<string>("companions", inst.name);

    public static bool IsItem(this CardData inst) => MetaprogressionSystem.Get<List<string>>("items").Contains(inst.name);

    public static void AddToItems(this CardData inst) => MetaprogressionSystem.Add<string>("items", inst.name);

    public static bool RemoveFromItems(this CardData inst) => MetaprogressionSystem.Remove<string>("items", inst.name);

    public static bool IsPet(this CardData inst) => MetaprogressionSystem.Get<List<string>>("pets").Contains(inst.name);

    public static void AddToPets(this CardData inst) => MetaprogressionSystem.Add<string>("pets", inst.name);

    public static bool RemoveFromPets(this CardData inst) => MetaprogressionSystem.Remove<string>("pets", inst.name);

    public static T[] RemoveFromArray<T>(this T[] sequence, T item) => ((IEnumerable<T>) sequence).Where<T>((Func<T, bool>) (a => !a.Equals((object) (T) item))).ToArray<T>();

    public static T[] RemoveFromArray<T>(this T[] sequence, Func<T, bool> item) => ((IEnumerable<T>) sequence).Where<T>(item).ToArray<T>();

    public static string PrefixGUID(string name, WildfrostMod mod) => mod.GUID + "." + name;

    public static string GetGUID(string name)
    {
      string str = name;
      int num1 = 0;
      int num2 = name.LastIndexOf('.') - num1;
      int startIndex = num1;
      int length = num2;
      return str.Substring(startIndex, length);
    }

    public static WildfrostMod GetModFromGuid(string guid) => Bootstrap.Mods.ToList<WildfrostMod>().Find((Predicate<WildfrostMod>) (a => a.GUID == guid));

    public static CardData.TraitStacks GetTraitStack(string name, int count) => new CardData.TraitStacks(Extensions.GetTraitData(name), count);

    public static CardAnimationProfile GetCardAnimationProfile(string name) => Addressables.LoadAssetAsync<CardAnimationProfile>((object) name).WaitForCompletion();

    public static TargetMode GetTargetMode(string name) => Addressables.LoadAssetAsync<TargetMode>((object) name).WaitForCompletion();

    public static void WithPools(this CardData data, params RewardPool[] pools)
    {
      foreach (RewardPool pool in pools)
        pool.list.Add((DataFile) data);
    }

    public static void AddPool(this CardData data, RewardPool pool) => pool.list.Add((DataFile) data);

    public static void WithPools(this CardUpgradeData data, params RewardPool[] pools)
    {
      foreach (RewardPool pool in pools)
        pool.list.Add((DataFile) data);
    }

    public static void AddPool(this CardUpgradeData data, RewardPool pool) => pool.list.Add((DataFile) data);

    public static LocalizedString GetLocalizedString(string table, string key) => LocalizationHelper.GetCollection(table, new LocaleIdentifier(SystemLanguage.English)).GetString(key);

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
      y.Mod = (WildfrostMod) null;
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
