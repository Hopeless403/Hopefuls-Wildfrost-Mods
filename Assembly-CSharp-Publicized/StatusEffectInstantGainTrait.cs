// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Trait", fileName = "Gain Trait")]
public class StatusEffectInstantGainTrait : StatusEffectInstant
{
  public TraitData traitToGain;

  public override IEnumerator Process()
  {
    StatusEffectInstantGainTrait instantGainTrait = this;
    int a = instantGainTrait.GetAmount();
    TraitData traitData = Object.Instantiate<TraitData>(instantGainTrait.traitToGain);
    traitData.name = instantGainTrait.traitToGain.name;
    instantGainTrait.target.data.traits.Add(new CardData.TraitStacks()
    {
      data = traitData,
      count = a
    });
    StatusEffectData[] statusEffectDataArray = traitData.effects;
    for (int index = 0; index < statusEffectDataArray.Length; ++index)
    {
      StatusEffectData effectData = statusEffectDataArray[index];
      yield return (object) StatusEffectSystem.Apply(instantGainTrait.target, instantGainTrait.applier, effectData, a);
    }
    statusEffectDataArray = (StatusEffectData[]) null;
    instantGainTrait.target.display.promptUpdateDescription = true;
    instantGainTrait.target.PromptUpdate();
    yield return (object) instantGainTrait.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
