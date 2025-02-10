// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantReduceEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Reduce Effects", fileName = "Reduce Effects")]
public class StatusEffectInstantReduceEffects : StatusEffectInstant
{
  [SerializeField]
  public bool allEffects = true;
  [SerializeField]
  [HideIf("allEffects")]
  public int attackEffectIndex = -1;
  [SerializeField]
  [HideIf("allEffects")]
  public int passiveEffectIndex = -1;

  public override IEnumerator Process()
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
    yield return (object) instantReduceEffects.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
