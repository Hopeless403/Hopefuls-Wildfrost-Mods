// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantLoseX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Lose X", fileName = "Lose X")]
public class StatusEffectInstantLoseX : StatusEffectInstant
{
  [SerializeField]
  public StatusEffectData statusToLose;
  [SerializeField]
  public bool doPing;

  public override IEnumerator Process()
  {
    StatusEffectInstantLoseX effectInstantLoseX = this;
    StatusEffectData statusEffectData = effectInstantLoseX.target.statusEffects.Find(new Predicate<StatusEffectData>(effectInstantLoseX.\u003CProcess\u003Eb__2_0));
    if ((bool) (UnityEngine.Object) statusEffectData)
    {
      if (effectInstantLoseX.doPing)
      {
        double num = (double) effectInstantLoseX.target.curveAnimator.Ping();
      }
      yield return (object) statusEffectData.RemoveStacks(effectInstantLoseX.count, false);
    }
    yield return (object) effectInstantLoseX.\u003C\u003En__0();
  }

  [CompilerGenerated]
  public bool \u003CProcess\u003Eb__2_0(StatusEffectData a) => a.name == this.statusToLose.name;

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
