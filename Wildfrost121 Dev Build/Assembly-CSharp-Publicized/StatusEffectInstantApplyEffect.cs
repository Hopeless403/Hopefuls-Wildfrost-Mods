// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantApplyEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Apply Status Effect", fileName = "Apply Status Effect")]
public class StatusEffectInstantApplyEffect : StatusEffectInstant
{
  [SerializeField]
  public StatusEffectData effectToApply;
  [SerializeField]
  public ScriptableAmount scriptableAmount;

  public override IEnumerator Process()
  {
    StatusEffectInstantApplyEffect instantApplyEffect = this;
    int count = (bool) (Object) instantApplyEffect.scriptableAmount ? instantApplyEffect.scriptableAmount.Get(instantApplyEffect.target) : instantApplyEffect.GetAmount();
    yield return (object) StatusEffectSystem.Apply(instantApplyEffect.target, instantApplyEffect.applier, instantApplyEffect.effectToApply, count);
    yield return (object) instantApplyEffect.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
