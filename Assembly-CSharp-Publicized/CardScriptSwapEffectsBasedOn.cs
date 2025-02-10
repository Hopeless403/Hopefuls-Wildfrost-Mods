// Decompiled with JetBrains decompiler
// Type: CardScriptSwapEffectsBasedOn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Swap Effects Based On", menuName = "Card Scripts/Swap Effects Based On")]
public class CardScriptSwapEffectsBasedOn : CardScript
{
  [SerializeField]
  public StatusEffectData statusA;
  [SerializeField]
  public StatusEffectData statusB;

  public override void Run(CardData target)
  {
    foreach (CardData.StatusEffectStacks attackEffect in target.attackEffects)
    {
      if (attackEffect.data.type == this.statusA.type)
        attackEffect.data = this.statusB;
      else if (attackEffect.data.type == this.statusB.type)
        attackEffect.data = this.statusA;
      else if (attackEffect.data is StatusEffectInstantDoubleX data)
        CardScriptSwapEffectsBasedOn.TrySwap(data, attackEffect, this.statusA, this.statusB);
    }
    foreach (CardData.StatusEffectStacks startWithEffect in target.startWithEffects)
    {
      switch (startWithEffect.data)
      {
        case StatusEffectApplyXWhenYAppliedTo effect1:
          CardScriptSwapEffectsBasedOn.TrySwap(effect1, startWithEffect, this.statusA, this.statusB);
          break;
        case StatusEffectApplyXWhenYAppliedToAlly effect2:
          CardScriptSwapEffectsBasedOn.TrySwap(effect2, startWithEffect, this.statusA, this.statusB);
          break;
        case StatusEffectApplyXWhenYAppliedToSelf effect3:
          CardScriptSwapEffectsBasedOn.TrySwap(effect3, startWithEffect, this.statusA, this.statusB);
          break;
        case StatusEffectApplyX effect4:
          CardScriptSwapEffectsBasedOn.TrySwap(effect4, startWithEffect, this.statusA, this.statusB);
          break;
        case StatusEffectBonusDamageEqualToX effect5:
          CardScriptSwapEffectsBasedOn.TrySwap(effect5, startWithEffect, this.statusA, this.statusB);
          break;
      }
    }
  }

  public static bool Swap(
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    string assetName = stacks.data.name.Replace(a.name, b.name);
    StatusEffectData statusEffectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", assetName);
    if ((bool) (Object) statusEffectData)
    {
      stacks.data = statusEffectData;
      return true;
    }
    Debug.LogError((object) ("[" + assetName + "] effect does not exist! Cannot swap effect [" + stacks.data.name + "] :("));
    return false;
  }

  public static void TrySwap(
    StatusEffectInstantDoubleX effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (!(bool) (Object) effect.statusToDouble)
      return;
    if (effect.statusToDouble.type == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!(effect.statusToDouble.type == b.type))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }

  public static void TrySwap(
    StatusEffectApplyX effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (!(bool) (Object) effect.effectToApply)
      return;
    if (effect.effectToApply.type == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!(effect.effectToApply.type == b.type))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }

  public static void TrySwap(
    StatusEffectApplyXWhenYAppliedTo effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (effect.whenAppliedType == a.type || (bool) (Object) effect.effectToApply && effect.effectToApply.type == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!(effect.whenAppliedType == b.type) && (!(bool) (Object) effect.effectToApply || !(effect.effectToApply.type == b.type)))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }

  public static void TrySwap(
    StatusEffectApplyXWhenYAppliedToAlly effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (effect.whenAppliedType == a.type || (bool) (Object) effect.effectToApply && effect.effectToApply.type == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!(effect.whenAppliedType == b.type) && (!(bool) (Object) effect.effectToApply || !(effect.effectToApply.type == b.type)))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }

  public static void TrySwap(
    StatusEffectApplyXWhenYAppliedToSelf effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (effect.whenAppliedType == a.type || (bool) (Object) effect.effectToApply && effect.effectToApply.type == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!(effect.whenAppliedType == b.type) && (!(bool) (Object) effect.effectToApply || !(effect.effectToApply.type == b.type)))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }

  public static void TrySwap(
    StatusEffectBonusDamageEqualToX effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (effect.effectType == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!(effect.effectType == b.type))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }
}
