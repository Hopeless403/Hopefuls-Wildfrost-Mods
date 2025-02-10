// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "Has Attack Effect", menuName = "Target Constraints/Has Attack Effect")]
public class TargetConstraintHasAttackEffect : TargetConstraint
{
  [SerializeField]
  public StatusEffectData effect;

  public override bool Check(Entity target) => !target.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;

  public override bool Check(CardData targetData) => !((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect)) ? this.not : !this.not;

  [CompilerGenerated]
  public bool \u003CCheck\u003Eb__1_0(CardData.StatusEffectStacks a) => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect;

  [CompilerGenerated]
  public bool \u003CCheck\u003Eb__2_0(CardData.StatusEffectStacks a) => (UnityEngine.Object) a.data == (UnityEngine.Object) this.effect;
}
