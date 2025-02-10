// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Trait", fileName = "Gain Trait")]
public class StatusEffectInstantGainTrait : StatusEffectInstant
{
  public TraitData traitToGain;

  protected override IEnumerator Process()
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
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantGainTrait.\u003C\u003En__0();
  }
}
