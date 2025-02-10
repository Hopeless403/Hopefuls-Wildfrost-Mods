// Decompiled with JetBrains decompiler
// Type: CardScriptSwapEffectsBasedOn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Swap Effects Based On", menuName = "Card Scripts/Swap Effects Based On")]
public class CardScriptSwapEffectsBasedOn : CardScript
{
  [SerializeField]
  private StatusEffectData statusA;
  [SerializeField]
  private StatusEffectData statusB;

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

  private static bool Swap(
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

  private static void TrySwap(
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

  private static void TrySwap(
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

  private static void TrySwap(
    StatusEffectApplyXWhenYAppliedTo effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    if (effect.whenAppliedTypes.Contains<string>(a.type) || (bool) (Object) effect.effectToApply && effect.effectToApply.type == a.type)
    {
      CardScriptSwapEffectsBasedOn.Swap(stacks, a, b);
    }
    else
    {
      if (!effect.whenAppliedTypes.Contains<string>(b.type) && (!(bool) (Object) effect.effectToApply || !(effect.effectToApply.type == b.type)))
        return;
      CardScriptSwapEffectsBasedOn.Swap(stacks, b, a);
    }
  }

  private static void TrySwap(
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

  private static void TrySwap(
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

  private static void TrySwap(
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
