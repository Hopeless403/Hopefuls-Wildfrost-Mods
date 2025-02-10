// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Trait", fileName = "Gain Trait")]
public class StatusEffectInstantGainTrait : StatusEffectInstant
{
  public TraitData traitToGain;

  protected override IEnumerator Process()
  {
    StatusEffectInstantGainTrait instantGainTrait = this;
    int amount = instantGainTrait.GetAmount();
    instantGainTrait.target.GainTrait(instantGainTrait.traitToGain, amount);
    yield return (object) instantGainTrait.target.UpdateTraits();
    instantGainTrait.target.display.promptUpdateDescription = true;
    instantGainTrait.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantGainTrait.\u003C\u003En__0();
  }
}
