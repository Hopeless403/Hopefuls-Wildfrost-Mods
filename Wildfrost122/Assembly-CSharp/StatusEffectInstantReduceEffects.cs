// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantReduceEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Reduce Effects", fileName = "Reduce Effects")]
public class StatusEffectInstantReduceEffects : StatusEffectInstant
{
  [SerializeField]
  private bool allEffects = true;
  [SerializeField]
  [HideIf("allEffects")]
  private int attackEffectIndex = -1;
  [SerializeField]
  [HideIf("allEffects")]
  private int passiveEffectIndex = -1;

  protected override IEnumerator Process()
  {
    StatusEffectInstantReduceEffects instantReduceEffects = this;
    int amount = instantReduceEffects.GetAmount();
    if ((bool) (Object) instantReduceEffects.target.curveAnimator)
    {
      double num = (double) instantReduceEffects.target.curveAnimator.Ping();
    }
    if (instantReduceEffects.allEffects)
    {
      instantReduceEffects.target.effectBonus -= amount;
      instantReduceEffects.target.PromptUpdate();
    }
    else
    {
      if (instantReduceEffects.attackEffectIndex >= 0)
      {
        instantReduceEffects.target.attackEffects[instantReduceEffects.attackEffectIndex].count -= amount;
        if (instantReduceEffects.target.display is Card display)
          display.promptUpdateDescription = true;
        instantReduceEffects.target.PromptUpdate();
      }
      if (instantReduceEffects.passiveEffectIndex >= 0)
      {
        instantReduceEffects.target.statusEffects[instantReduceEffects.passiveEffectIndex].count -= amount;
        if (instantReduceEffects.target.display is Card display)
          display.promptUpdateDescription = true;
        instantReduceEffects.target.PromptUpdate();
      }
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantReduceEffects.\u003C\u003En__0();
  }
}
