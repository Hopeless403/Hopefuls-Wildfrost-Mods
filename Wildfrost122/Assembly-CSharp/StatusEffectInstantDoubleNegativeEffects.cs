// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDoubleNegativeEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Double Negative Effects", fileName = "Double Negative Effects")]
public class StatusEffectInstantDoubleNegativeEffects : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    StatusEffectInstantDoubleNegativeEffects doubleNegativeEffects = this;
    Hit hit = new Hit(doubleNegativeEffects.applier, doubleNegativeEffects.target, 0);
    for (int index = doubleNegativeEffects.target.statusEffects.Count - 1; index >= 0; --index)
    {
      StatusEffectData statusEffect = doubleNegativeEffects.target.statusEffects[index];
      if (statusEffect.IsNegativeStatusEffect())
        hit.AddStatusEffect(statusEffect, statusEffect.count);
    }
    if (hit.Offensive)
      yield return (object) hit.Process();
    // ISSUE: reference to a compiler-generated method
    yield return (object) doubleNegativeEffects.\u003C\u003En__0();
  }
}
