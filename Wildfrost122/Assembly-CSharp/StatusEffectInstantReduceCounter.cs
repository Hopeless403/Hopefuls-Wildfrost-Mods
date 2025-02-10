// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantReduceCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Reduce Counter", fileName = "Reduce Counter")]
public class StatusEffectInstantReduceCounter : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    StatusEffectInstantReduceCounter instantReduceCounter = this;
    yield return (object) new Hit(instantReduceCounter.applier, instantReduceCounter.target, 0)
    {
      countsAsHit = false,
      counterReduction = instantReduceCounter.GetAmount()
    }.Process();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantReduceCounter.\u003C\u003En__0();
  }
}
