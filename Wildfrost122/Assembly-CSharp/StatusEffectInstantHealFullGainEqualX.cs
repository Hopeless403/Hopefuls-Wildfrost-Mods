// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantHealFullGainEqualX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Heal Full, Gain Equal X", fileName = "Heal Full, Gain Equal X")]
public class StatusEffectInstantHealFullGainEqualX : StatusEffectInstant
{
  [SerializeField]
  private StatusEffectData effectToGain;

  protected override IEnumerator Process()
  {
    StatusEffectInstantHealFullGainEqualX healFullGainEqualX = this;
    int num1 = healFullGainEqualX.target.hp.max - healFullGainEqualX.target.hp.current;
    double num2 = (double) healFullGainEqualX.target.curveAnimator.Ping();
    healFullGainEqualX.target.hp.current = healFullGainEqualX.target.hp.max;
    Hit hit = new Hit(healFullGainEqualX.target, healFullGainEqualX.target, 0);
    hit.AddStatusEffect(healFullGainEqualX.effectToGain, healFullGainEqualX.GetAmount() * num1);
    yield return (object) hit.Process();
    // ISSUE: reference to a compiler-generated method
    yield return (object) healFullGainEqualX.\u003C\u003En__0();
  }
}
