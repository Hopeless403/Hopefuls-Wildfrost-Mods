// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Effects", fileName = "Increase Effects")]
public class StatusEffectInstantIncreaseEffects : StatusEffectInstant
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
    StatusEffectInstantIncreaseEffects instantIncreaseEffects = this;
    int amount = instantIncreaseEffects.GetAmount();
    if ((bool) (Object) instantIncreaseEffects.target.curveAnimator)
    {
      double num = (double) instantIncreaseEffects.target.curveAnimator.Ping();
    }
    if (instantIncreaseEffects.allEffects)
    {
      instantIncreaseEffects.target.effectBonus += amount;
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
    yield return (object) instantIncreaseEffects.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
