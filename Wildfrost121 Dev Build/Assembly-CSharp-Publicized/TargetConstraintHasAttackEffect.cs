// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Attack Effect", menuName = "Target Constraints/Has Attack Effect")]
public class TargetConstraintHasAttackEffect : TargetConstraint
{
  [SerializeField]
  public StatusEffectData effect;

  public override bool Check(Entity target)
  {
    return !target.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return !((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;
  }

  [CompilerGenerated]
  public bool \u003CCheck\u003Eb__1_0(CardData.StatusEffectStacks a)
  {
    return (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect;
  }

  [CompilerGenerated]
  public bool \u003CCheck\u003Eb__2_0(CardData.StatusEffectStacks a)
  {
    return (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect;
  }
}
