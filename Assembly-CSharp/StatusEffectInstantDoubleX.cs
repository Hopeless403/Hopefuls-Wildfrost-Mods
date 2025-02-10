// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDoubleX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Double X", fileName = "Double X")]
public class StatusEffectInstantDoubleX : StatusEffectInstant
{
  public StatusEffectData statusToDouble;
  [SerializeField]
  private bool countsAsHit = true;

  protected override IEnumerator Process()
  {
    StatusEffectInstantDoubleX effectInstantDoubleX = this;
    // ISSUE: reference to a compiler-generated method
    StatusEffectData statusEffectData = effectInstantDoubleX.target.statusEffects.Find(new Predicate<StatusEffectData>(effectInstantDoubleX.\u003CProcess\u003Eb__2_0));
    if ((bool) (UnityEngine.Object) statusEffectData)
    {
      double num = (double) effectInstantDoubleX.target.curveAnimator.Ping();
      Hit hit = new Hit(effectInstantDoubleX.applier, effectInstantDoubleX.target, 0)
      {
        countsAsHit = effectInstantDoubleX.countsAsHit
      };
      hit.AddStatusEffect(effectInstantDoubleX.statusToDouble, statusEffectData.count);
      yield return (object) hit.Process();
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantDoubleX.\u003C\u003En__0();
  }
}
