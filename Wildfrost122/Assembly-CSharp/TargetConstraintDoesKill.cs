// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Does Kill", menuName = "Target Constraints/Does Kill")]
public class TargetConstraintDoesKill : TargetConstraint
{
  public override bool Check(Entity target)
  {
    return (!(bool) (UnityEngine.Object) target.data || !target.HasAttackIcon()) && !target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.doesDamage)) && !target.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => a.data.doesDamage)) ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return (!(bool) (UnityEngine.Object) targetData || !targetData.hasAttack) && !((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => a.data.doesDamage)) && !((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => a.data.doesDamage)) ? this.not : !this.not;
  }
}
