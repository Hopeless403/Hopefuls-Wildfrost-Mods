// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Trait", fileName = "Gain Trait")]
public class StatusEffectInstantGainTrait : StatusEffectInstant
{
  public TraitData traitToGain;

  public override IEnumerator Process()
  {
    StatusEffectInstantGainTrait instantGainTrait = this;
    int amount = instantGainTrait.GetAmount();
    instantGainTrait.target.GainTrait(instantGainTrait.traitToGain, amount);
    yield return (object) instantGainTrait.target.UpdateTraits();
    instantGainTrait.target.display.promptUpdateDescription = true;
    instantGainTrait.target.PromptUpdate();
    yield return (object) instantGainTrait.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
