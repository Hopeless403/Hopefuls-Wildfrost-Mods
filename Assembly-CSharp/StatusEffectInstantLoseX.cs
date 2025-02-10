// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantLoseX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Lose X", fileName = "Lose X")]
public class StatusEffectInstantLoseX : StatusEffectInstant
{
  [SerializeField]
  private StatusEffectData statusToLose;
  [SerializeField]
  private bool doPing;

  protected override IEnumerator Process()
  {
    StatusEffectInstantLoseX effectInstantLoseX = this;
    // ISSUE: reference to a compiler-generated method
    StatusEffectData statusEffectData = effectInstantLoseX.target.statusEffects.Find(new Predicate<StatusEffectData>(effectInstantLoseX.\u003CProcess\u003Eb__2_0));
    if ((bool) (UnityEngine.Object) statusEffectData)
    {
      if (effectInstantLoseX.doPing)
      {
        double num = (double) effectInstantLoseX.target.curveAnimator.Ping();
      }
      yield return (object) statusEffectData.RemoveStacks(effectInstantLoseX.count, false);
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantLoseX.\u003C\u003En__0();
  }
}
