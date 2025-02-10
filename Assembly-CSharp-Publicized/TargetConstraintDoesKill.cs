// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Does Kill", menuName = "Target Constraints/Does Kill")]
public class TargetConstraintDoesKill : TargetConstraint
{
  public override bool Check(Entity target) => (!(bool) (UnityEngine.Object) target.data || !target.data.hasAttack) && !target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.doesDamage)) && !target.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => a.data.doesDamage)) ? this.not : !this.not;

  public override bool Check(CardData targetData) => (!(bool) (UnityEngine.Object) targetData || !targetData.hasAttack) && !((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => a.data.doesDamage)) && !((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => a.data.doesDamage)) ? this.not : !this.not;
}
