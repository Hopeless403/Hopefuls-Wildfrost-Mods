// Decompiled with JetBrains decompiler
// Type: StatusEffectMultEffects
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class StatusEffectMultEffects : StatusEffectData
{
  [SerializeField]
  public List<StatusEffectData> effects = new List<StatusEffectData>();
  public List<Entity.TraitStacks> silenced;
  public Entity.TraitStacks added;
  public List<int> addedAmount;

  public override bool HasStackRoutine => true;

  public override bool Instant => true;

  public override IEnumerator StackRoutine(int stacks)
  {
    foreach (StatusEffectData item in this.effects)
    {
      item.count = stacks;
      yield return (object) StatusEffectSystem.Apply(this.target, this.applier, item, stacks);
    }
    yield return (object) this.target.UpdateTraits();
    this.target.display.promptUpdateDescription = true;
    this.target.PromptUpdate();
  }
}
