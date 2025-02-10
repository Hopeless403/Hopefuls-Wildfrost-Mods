// Decompiled with JetBrains decompiler
// Type: TargetConstraintEffectsMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Effects More Than", menuName = "Target Constraints/Effects More Than")]
public class TargetConstraintEffectsMoreThan : TargetConstraint
{
  [SerializeField]
  public int amount;

  public override bool Check(Entity target)
  {
    if (this.CheckAttackEffects(target))
      return !this.not;
    return this.CheckPassiveEffects(target) ? !this.not : this.not;
  }

  public override bool Check(CardData targetData)
  {
    if (this.CheckAttackEffects(targetData))
      return !this.not;
    if (this.CheckPassiveEffects(targetData))
      return !this.not;
    return this.CheckTraits(targetData) ? !this.not : this.not;
  }

  public bool CheckAttackEffects(Entity target)
  {
    return this.CheckAttackEffects((IEnumerable<CardData.StatusEffectStacks>) target.attackEffects);
  }

  public bool CheckAttackEffects(CardData targetData)
  {
    return this.CheckAttackEffects((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects);
  }

  public bool CheckAttackEffects(IEnumerable<CardData.StatusEffectStacks> effects)
  {
    return effects != null && effects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.data.stackable && e.count > this.amount));
  }

  public bool CheckPassiveEffects(Entity target)
  {
    return this.CheckPassiveEffects((IEnumerable<StatusEffectData>) target.statusEffects);
  }

  public bool CheckPassiveEffects(CardData targetData)
  {
    if (targetData.startWithEffects == null)
      return false;
    CardData.StatusEffectStacks[] array = ((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.data.canBeBoosted)).ToArray<CardData.StatusEffectStacks>();
    return array.Length != 0 && ((IEnumerable<CardData.StatusEffectStacks>) array).All<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.count > this.amount));
  }

  public bool CheckPassiveEffects(IEnumerable<StatusEffectData> effects)
  {
    if (effects == null)
      return false;
    StatusEffectData[] array = effects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.canBeBoosted)).ToArray<StatusEffectData>();
    return array.Length != 0 && ((IEnumerable<StatusEffectData>) array).All<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.count > this.amount));
  }

  public bool CheckTraits(Entity target)
  {
    if (target.traits == null)
      return false;
    foreach (Entity.TraitStacks trait in target.traits)
    {
      if (this.CheckPassiveEffects((IEnumerable<StatusEffectData>) trait.data.effects))
        return true;
    }
    return false;
  }

  public bool CheckTraits(CardData targetData)
  {
    if (targetData.traits == null)
      return false;
    foreach (CardData.TraitStacks trait in targetData.traits)
    {
      if (this.CheckPassiveEffects((IEnumerable<StatusEffectData>) trait.data.effects))
        return true;
    }
    return false;
  }

  [CompilerGenerated]
  public bool \u003CCheckAttackEffects\u003Eb__5_0(CardData.StatusEffectStacks e)
  {
    return e.data.stackable && e.count > this.amount;
  }

  [CompilerGenerated]
  public bool \u003CCheckPassiveEffects\u003Eb__7_1(CardData.StatusEffectStacks e)
  {
    return e.count > this.amount;
  }

  [CompilerGenerated]
  public bool \u003CCheckPassiveEffects\u003Eb__8_1(StatusEffectData e) => e.count > this.amount;
}
