// Decompiled with JetBrains decompiler
// Type: TargetConstraintCanBeBoosted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Can Be Boosted", menuName = "Target Constraints/Can Be Boosted")]
public class TargetConstraintCanBeBoosted : TargetConstraint
{
  public override bool Check(Entity target)
  {
    if (TargetConstraintCanBeBoosted.CheckAttackEffects(target))
      return !this.not;
    return TargetConstraintCanBeBoosted.CheckPassiveEffects(target) ? !this.not : this.not;
  }

  public override bool Check(CardData targetData)
  {
    if (TargetConstraintCanBeBoosted.CheckAttackEffects(targetData))
      return !this.not;
    if (TargetConstraintCanBeBoosted.CheckPassiveEffects(targetData))
      return !this.not;
    return TargetConstraintCanBeBoosted.CheckTraits(targetData) ? !this.not : this.not;
  }

  private static bool CheckAttackEffects(Entity target)
  {
    return TargetConstraintCanBeBoosted.CheckAttackEffects(target.attackEffects.Select<CardData.StatusEffectStacks, StatusEffectData>((Func<CardData.StatusEffectStacks, StatusEffectData>) (a => a.data)));
  }

  private static bool CheckAttackEffects(CardData targetData)
  {
    return TargetConstraintCanBeBoosted.CheckAttackEffects(((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Select<CardData.StatusEffectStacks, StatusEffectData>((Func<CardData.StatusEffectStacks, StatusEffectData>) (a => a.data)));
  }

  private static bool CheckAttackEffects(IEnumerable<StatusEffectData> effects)
  {
    return effects != null && effects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.stackable));
  }

  private static bool CheckPassiveEffects(Entity target)
  {
    return TargetConstraintCanBeBoosted.CheckPassiveEffects((IEnumerable<StatusEffectData>) target.statusEffects);
  }

  private static bool CheckPassiveEffects(CardData targetData)
  {
    return TargetConstraintCanBeBoosted.CheckPassiveEffects(((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Select<CardData.StatusEffectStacks, StatusEffectData>((Func<CardData.StatusEffectStacks, StatusEffectData>) (a => a.data)));
  }

  private static bool CheckPassiveEffects(IEnumerable<StatusEffectData> effects)
  {
    return effects != null && effects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.canBeBoosted));
  }

  private static bool CheckTraits(Entity target)
  {
    if (target.traits == null)
      return false;
    foreach (Entity.TraitStacks trait in target.traits)
    {
      if (TargetConstraintCanBeBoosted.CheckPassiveEffects((IEnumerable<StatusEffectData>) trait.data.effects))
        return true;
    }
    return false;
  }

  private static bool CheckTraits(CardData targetData)
  {
    if (targetData.traits == null)
      return false;
    foreach (CardData.TraitStacks trait in targetData.traits)
    {
      if (TargetConstraintCanBeBoosted.CheckPassiveEffects((IEnumerable<StatusEffectData>) trait.data.effects))
        return true;
    }
    return false;
  }
}
