// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantHealFullGainEqualX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
