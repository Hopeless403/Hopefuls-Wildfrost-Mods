// Decompiled with JetBrains decompiler
// Type: StatusEffectTemporaryTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific Effects/Temporary Trait", fileName = "Temporary Trait")]
public class StatusEffectTemporaryTrait : StatusEffectData
{
  [SerializeField]
  private TraitData trait;
  private List<Entity.TraitStacks> silenced;
  private Entity.TraitStacks added;
  private int addedAmount;

  public override bool HasStackRoutine => true;

  public override IEnumerator StackRoutine(int stacks)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectTemporaryTrait effectTemporaryTrait = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      effectTemporaryTrait.addedAmount += stacks;
      effectTemporaryTrait.target.display.promptUpdateDescription = true;
      effectTemporaryTrait.target.PromptUpdate();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    effectTemporaryTrait.added = effectTemporaryTrait.target.GainTrait(effectTemporaryTrait.trait, stacks, true);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) effectTemporaryTrait.target.UpdateTraits();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override bool HasEndRoutine => true;

  public override IEnumerator EndRoutine()
  {
    StatusEffectTemporaryTrait effectTemporaryTrait = this;
    if ((bool) (Object) effectTemporaryTrait.target)
    {
      if (effectTemporaryTrait.added != null)
      {
        effectTemporaryTrait.added.count -= effectTemporaryTrait.addedAmount;
        effectTemporaryTrait.added.tempCount -= effectTemporaryTrait.addedAmount;
      }
      effectTemporaryTrait.addedAmount = 0;
      yield return (object) effectTemporaryTrait.target.UpdateTraits(effectTemporaryTrait.added);
      effectTemporaryTrait.target.display.promptUpdateDescription = true;
      effectTemporaryTrait.target.PromptUpdate();
    }
  }
}
