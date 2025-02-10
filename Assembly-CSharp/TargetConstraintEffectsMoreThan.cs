// Decompiled with JetBrains decompiler
// Type: TargetConstraintEffectsMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Effects More Than", menuName = "Target Constraints/Effects More Than")]
public class TargetConstraintEffectsMoreThan : TargetConstraint
{
  [SerializeField]
  private int amount;

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

  private bool CheckAttackEffects(Entity target) => this.CheckAttackEffects((IEnumerable<CardData.StatusEffectStacks>) target.attackEffects);

  private bool CheckAttackEffects(CardData targetData) => this.CheckAttackEffects((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects);

  private bool CheckAttackEffects(IEnumerable<CardData.StatusEffectStacks> effects) => effects != null && effects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.data.stackable && e.count > this.amount));

  private bool CheckPassiveEffects(Entity target) => this.CheckPassiveEffects((IEnumerable<StatusEffectData>) target.statusEffects);

  private bool CheckPassiveEffects(CardData targetData)
  {
    if (targetData.startWithEffects == null)
      return false;
    CardData.StatusEffectStacks[] array = ((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.data.canBeBoosted)).ToArray<CardData.StatusEffectStacks>();
    return array.Length != 0 && ((IEnumerable<CardData.StatusEffectStacks>) array).All<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.count > this.amount));
  }

  private bool CheckPassiveEffects(IEnumerable<StatusEffectData> effects)
  {
    if (effects == null)
      return false;
    StatusEffectData[] array = effects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.canBeBoosted)).ToArray<StatusEffectData>();
    return array.Length != 0 && ((IEnumerable<StatusEffectData>) array).All<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.count > this.amount));
  }

  private bool CheckTraits(Entity target)
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

  private bool CheckTraits(CardData targetData)
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
}
