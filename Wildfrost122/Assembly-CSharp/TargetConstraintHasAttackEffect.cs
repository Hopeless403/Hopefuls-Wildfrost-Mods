// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Attack Effect", menuName = "Target Constraints/Has Attack Effect")]
public class TargetConstraintHasAttackEffect : TargetConstraint
{
  [SerializeField]
  private StatusEffectData effect;

  public override bool Check(Entity target)
  {
    return !target.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return !((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;
  }
}
