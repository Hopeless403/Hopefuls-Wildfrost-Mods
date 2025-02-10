// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantApplyEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Apply Status Effect", fileName = "Apply Status Effect")]
public class StatusEffectInstantApplyEffect : StatusEffectInstant
{
  [SerializeField]
  private StatusEffectData effectToApply;
  [SerializeField]
  private ScriptableAmount scriptableAmount;

  protected override IEnumerator Process()
  {
    StatusEffectInstantApplyEffect instantApplyEffect = this;
    int count = (bool) (Object) instantApplyEffect.scriptableAmount ? instantApplyEffect.scriptableAmount.Get(instantApplyEffect.target) : instantApplyEffect.GetAmount();
    yield return (object) StatusEffectSystem.Apply(instantApplyEffect.target, instantApplyEffect.applier, instantApplyEffect.effectToApply, count);
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantApplyEffect.\u003C\u003En__0();
  }
}
