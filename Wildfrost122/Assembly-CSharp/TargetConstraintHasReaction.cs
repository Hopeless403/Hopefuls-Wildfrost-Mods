// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Reaction", menuName = "Target Constraints/Has Reaction")]
public class TargetConstraintHasReaction : TargetConstraint
{
  public override bool Check(Entity target)
  {
    return target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (effect => effect.isReaction)) ? !this.not : this.not;
  }

  public override bool Check(CardData targetData)
  {
    return ((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (effectStacks => effectStacks.data.isReaction)) ? !this.not : this.not;
  }
}
