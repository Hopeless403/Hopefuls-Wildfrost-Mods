// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Effects", fileName = "Increase Effects")]
public class StatusEffectInstantIncreaseEffects : StatusEffectInstant
{
  [SerializeField]
  private bool allEffects = true;
  [SerializeField]
  private bool allAttackEffects;
  [SerializeField]
  private bool allPassiveEffects;
  [SerializeField]
  [HideIf("allEffects")]
  private int attackEffectIndex = -1;
  [SerializeField]
  [HideIf("allEffects")]
  private int passiveEffectIndex = -1;

  protected override IEnumerator Process()
  {
    StatusEffectInstantIncreaseEffects instantIncreaseEffects = this;
    int amount = instantIncreaseEffects.GetAmount();
    if ((bool) (Object) instantIncreaseEffects.target.curveAnimator)
    {
      double num = (double) instantIncreaseEffects.target.curveAnimator.Ping();
    }
    if (instantIncreaseEffects.allEffects || instantIncreaseEffects.allAttackEffects && instantIncreaseEffects.allPassiveEffects)
    {
      instantIncreaseEffects.target.effectBonus += amount;
      instantIncreaseEffects.target.PromptUpdate();
    }
    else if (instantIncreaseEffects.allAttackEffects)
    {
      foreach (CardData.StatusEffectStacks attackEffect in instantIncreaseEffects.target.attackEffects)
        attackEffect.count += amount;
      if (instantIncreaseEffects.target.display is Card display)
        display.promptUpdateDescription = true;
      instantIncreaseEffects.target.PromptUpdate();
    }
    else if (instantIncreaseEffects.allPassiveEffects)
    {
      foreach (StatusEffectData statusEffect in instantIncreaseEffects.target.statusEffects)
        statusEffect.count += amount;
      if (instantIncreaseEffects.target.display is Card display)
        display.promptUpdateDescription = true;
      instantIncreaseEffects.target.PromptUpdate();
    }
    else
    {
      if (instantIncreaseEffects.attackEffectIndex >= 0)
      {
        instantIncreaseEffects.target.attackEffects[instantIncreaseEffects.attackEffectIndex].count += amount;
        if (instantIncreaseEffects.target.display is Card display)
          display.promptUpdateDescription = true;
        instantIncreaseEffects.target.PromptUpdate();
      }
      if (instantIncreaseEffects.passiveEffectIndex >= 0)
      {
        instantIncreaseEffects.target.statusEffects[instantIncreaseEffects.passiveEffectIndex].count += amount;
        if (instantIncreaseEffects.target.display is Card display)
          display.promptUpdateDescription = true;
        instantIncreaseEffects.target.PromptUpdate();
      }
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantIncreaseEffects.\u003C\u003En__0();
  }
}
