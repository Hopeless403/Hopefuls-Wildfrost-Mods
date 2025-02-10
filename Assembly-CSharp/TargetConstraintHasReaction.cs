// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Has Reaction", menuName = "Target Constraints/Has Reaction")]
public class TargetConstraintHasReaction : TargetConstraint
{
  public override bool Check(Entity target) => target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (effect => effect.isReaction)) ? !this.not : this.not;

  public override bool Check(CardData targetData) => ((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (effectStacks => effectStacks.data.isReaction)) ? !this.not : this.not;
}
