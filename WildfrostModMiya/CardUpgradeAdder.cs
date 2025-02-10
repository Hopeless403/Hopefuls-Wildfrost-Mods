// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.CardUpgradeAdder
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace WildfrostModMiya
{
  public static class CardUpgradeAdder
  {
    public static event Action<int> OnAskForAddingCardUpgrades;

    public static CardUpgradeData ModifyFields(
      this CardUpgradeData t,
      Func<CardUpgradeData, CardUpgradeData> modifyFields)
    {
      t = modifyFields(t);
      return t;
    }

    public static CardUpgradeData SetText(this CardUpgradeData t, string text)
    {
      t.textKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object) t).name + ".Text", text));
      return t;
    }

    public static CardUpgradeData SetTitle(this CardUpgradeData t, string title)
    {
      t.titleKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object) t).name + ".Title", title));
      return t;
    }

    public static CardUpgradeData SetUpgradeType(this CardUpgradeData t, CardUpgradeData.Type type)
    {
      t.type = type;
      return t;
    }

    public static CardUpgradeData SetImage(this CardUpgradeData t, string sprite)
    {
      t.image = CardAdder.LoadSpriteFromCardPortraits(sprite);
      return t;
    }

    public static CardUpgradeData SetAttackEffects(
      this CardUpgradeData t,
      params CardData.StatusEffectStacks[] effect)
    {
      t.attackEffects = Il2CppReferenceArray<CardData.StatusEffectStacks>.op_Implicit(effect);
      return t;
    }

    public static CardUpgradeData SetStartWithEffects(
      this CardUpgradeData t,
      params CardData.StatusEffectStacks[] effect)
    {
      t.startWithEffectsApplied = new List<CardData.StatusEffectStacks>();
      foreach (CardData.StatusEffectStacks statusEffectStacks in effect)
        t.startWithEffectsApplied.Add(statusEffectStacks);
      return t;
    }

    public static CardUpgradeData SetTraits(
      this CardUpgradeData t,
      params CardData.TraitStacks[] traits)
    {
      List<CardData.TraitStacks> list = new List<CardData.TraitStacks>();
      foreach (CardData.TraitStacks trait in traits)
        list.Add(trait);
      t.traitsAffected = list;
      return t;
    }

    public static CardUpgradeData RegisterCardUpgradeData(this CardUpgradeData t)
    {
      WildFrostAPIMod.CardUpgradeDataAdditions.Add(t);
      return t;
    }

    public static CardUpgradeData AddToPool(
      this CardUpgradeData t,
      params CardAdder.VanillaRewardPools[] rewardPools)
    {
      List<string> stringList = new List<string>();
      foreach (CardAdder.VanillaRewardPools rewardPool in rewardPools)
        stringList.Add(rewardPool.ToString().Replace("VanillaRewardPools.", ""));
      t = t.AddToPool(stringList.ToArray());
      return t;
    }

    public static CardUpgradeData AddToPool(this CardUpgradeData t, params string[] rewardPools)
    {
      Il2CppReferenceArray<Object> typeIncludingAssets = Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<RewardPool>());
      foreach (string rewardPool in rewardPools)
      {
        string poolName = rewardPool;
        ((Il2CppObjectBase) IArrayExt.ToList<Object>((Il2CppArrayBase<Object>) typeIncludingAssets).Find<Object>((Predicate<Object>) (a => a.name == poolName))).Cast<RewardPool>()?.list?.Add((DataFile) t);
      }
      return t;
    }

    public static CardUpgradeData CreateCardUpgradeData(string modName, string cardName)
    {
      CardUpgradeData instance = ScriptableObject.CreateInstance<CardUpgradeData>();
      instance.textKey = new LocalizedString();
      ((Object) instance).name = cardName.StartsWith(modName) ? cardName : modName + "." + cardName;
      if (modName == "")
        ((Object) instance).name = cardName;
      return instance;
    }

    internal static void LaunchEvent()
    {
      Action<int> addingCardUpgrades = CardUpgradeAdder.OnAskForAddingCardUpgrades;
      if (addingCardUpgrades == null)
        return;
      addingCardUpgrades(0);
    }
  }
}
