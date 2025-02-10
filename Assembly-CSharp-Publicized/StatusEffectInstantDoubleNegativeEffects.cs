// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDoubleNegativeEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Double Negative Effects", fileName = "Double Negative Effects")]
public class StatusEffectInstantDoubleNegativeEffects : StatusEffectInstant
{
  public override IEnumerator Process()
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
    yield return (object) doubleNegativeEffects.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
