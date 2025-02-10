// Decompiled with JetBrains decompiler
// Type: StatusEffectFreeTrait
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific Effects/Temporary Trait", fileName = "Temporary Trait")]
public class StatusEffectFreeTrait : StatusEffectData
{
  [SerializeField]
  public TraitData trait;
  public List<Entity.TraitStacks> silenced;
  public Entity.TraitStacks added;
  public int addedAmount;

  public override bool HasStackRoutine => true;

  public override bool HasEndRoutine => true;

  public override bool Instant => true;

  public override IEnumerator StackRoutine(int stacks)
  {
    this.added = this.target.GainTrait(this.trait, stacks, true);
    yield return (object) this.target.UpdateTraits();
    this.addedAmount += stacks;
    this.target.display.promptUpdateDescription = true;
    this.target.PromptUpdate();
  }

  public override IEnumerator EndRoutine()
  {
    if ((bool) (Object) this.target)
    {
      if (this.added != null)
      {
        this.added.count -= this.addedAmount;
        this.added.tempCount -= this.addedAmount;
      }
      this.addedAmount = 0;
      yield return (object) this.target.UpdateTraits(this.added);
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
    }
  }
}
