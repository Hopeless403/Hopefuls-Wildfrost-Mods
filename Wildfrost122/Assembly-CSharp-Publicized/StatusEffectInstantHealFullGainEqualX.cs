// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantHealFullGainEqualX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Heal Full, Gain Equal X", fileName = "Heal Full, Gain Equal X")]
public class StatusEffectInstantHealFullGainEqualX : StatusEffectInstant
{
  [SerializeField]
  public StatusEffectData effectToGain;

  public override IEnumerator Process()
  {
    StatusEffectInstantHealFullGainEqualX healFullGainEqualX = this;
    int num1 = healFullGainEqualX.target.hp.max - healFullGainEqualX.target.hp.current;
    double num2 = (double) healFullGainEqualX.target.curveAnimator.Ping();
    healFullGainEqualX.target.hp.current = healFullGainEqualX.target.hp.max;
    Hit hit = new Hit(healFullGainEqualX.target, healFullGainEqualX.target, 0);
    hit.AddStatusEffect(healFullGainEqualX.effectToGain, healFullGainEqualX.GetAmount() * num1);
    yield return (object) hit.Process();
    yield return (object) healFullGainEqualX.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
