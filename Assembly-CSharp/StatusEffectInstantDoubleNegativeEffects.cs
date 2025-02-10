// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDoubleNegativeEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
      if (statusEffect.offensive && statusEffect.visible)
        hit.AddStatusEffect(statusEffect, statusEffect.count);
    }
    if (hit.Offensive)
      yield return (object) hit.Process();
    // ISSUE: reference to a compiler-generated method
    yield return (object) doubleNegativeEffects.\u003C\u003En__0();
  }
}
