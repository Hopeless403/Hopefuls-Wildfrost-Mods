// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDoubleX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Double X", fileName = "Double X")]
public class StatusEffectInstantDoubleX : StatusEffectInstant
{
  public StatusEffectData statusToDouble;
  [SerializeField]
  public bool countsAsHit = true;

  public override IEnumerator Process()
  {
    StatusEffectInstantDoubleX effectInstantDoubleX = this;
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
    yield return (object) effectInstantDoubleX.\u003C\u003En__0();
  }

  [CompilerGenerated]
  public bool \u003CProcess\u003Eb__2_0(StatusEffectData a) => a.name == this.statusToDouble.name;

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
