// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Has Attack Effect", menuName = "Target Constraints/Has Attack Effect")]
public class TargetConstraintHasAttackEffect : TargetConstraint
{
  [SerializeField]
  private StatusEffectData effect;

  public override bool Check(Entity target) => !target.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;

  public override bool Check(CardData targetData) => !((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;
}
