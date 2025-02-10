// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantHeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Heal", fileName = "Heal")]
public class StatusEffectInstantHeal : StatusEffectInstant
{
  [SerializeField]
  private bool doPing = true;

  protected override IEnumerator Process()
  {
    StatusEffectInstantHeal effectInstantHeal = this;
    if (effectInstantHeal.target.alive)
    {
      if (effectInstantHeal.doPing)
      {
        CurveAnimator curveAnimator = effectInstantHeal.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num = (double) curveAnimator.Ping();
        }
      }
      yield return (object) new Hit(effectInstantHeal.applier, effectInstantHeal.target, -effectInstantHeal.GetAmount()).Process();
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantHeal.\u003C\u003En__0();
  }
}
