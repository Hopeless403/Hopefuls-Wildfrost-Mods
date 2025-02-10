// Decompiled with JetBrains decompiler
// Type: ActionEffectApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ActionEffectApply : PlayAction
{
  private readonly StatusEffectApplyX effect;
  private readonly List<Entity> targets = new List<Entity>();
  private readonly List<int> amounts = new List<int>();
  private readonly List<ActionEffectApply.Sequence> sequences = new List<ActionEffectApply.Sequence>();
  public bool running;

  public ActionEffectApply(StatusEffectApplyX effect, List<Entity> targets, int amount)
  {
    this.effect = effect;
    this.sequences.Add(new ActionEffectApply.Sequence(targets, amount));
  }

  public void Stack(List<Entity> newTargets, int amount)
  {
    bool flag = false;
    foreach (ActionEffectApply.Sequence sequence in this.sequences)
    {
      if (sequence.targets.Count == newTargets.Count && sequence.targets.ContainsAll<Entity>((IEnumerable<Entity>) newTargets))
      {
        sequence.amount += amount;
        Debug.Log((object) string.Format("Stacking [{0}] {1} → {2}", (object) this.effect.name, (object) (sequence.amount - amount), (object) sequence.amount));
        flag = true;
        break;
      }
      if (amount == sequence.amount && !sequence.targets.ContainsAny<Entity>((IEnumerable<Entity>) newTargets))
      {
        sequence.targets.AddRange((IEnumerable<Entity>) newTargets);
        Debug.Log((object) ("Stacking [" + this.effect.name + "] adding " + string.Join<Entity>(", ", (IEnumerable<Entity>) newTargets)));
        flag = true;
        break;
      }
    }
    if (flag)
      return;
    this.sequences.Add(new ActionEffectApply.Sequence(newTargets, amount));
    Debug.Log((object) ("Stacking [" + this.effect.name + "] ↓\n" + string.Join<ActionEffectApply.Sequence>("\n", (IEnumerable<ActionEffectApply.Sequence>) this.sequences)));
  }

  public override IEnumerator Run()
  {
    this.running = true;
    foreach (ActionEffectApply.Sequence sequence in this.sequences)
    {
      if ((bool) (Object) this.effect)
        yield return (object) this.effect.Sequence(sequence.targets, sequence.amount);
      else
        break;
    }
  }

  public void TryRemoveEntity(Entity entity)
  {
    foreach (ActionEffectApply.Sequence sequence in this.sequences)
    {
      if (sequence.targets.Contains(entity))
        sequence.targets.Remove(entity);
    }
  }

  private class Sequence
  {
    public readonly List<Entity> targets;
    public int amount;

    public Sequence(List<Entity> targets, int amount)
    {
      this.targets = targets;
      this.amount = amount;
    }

    public override string ToString()
    {
      return string.Format("Sequence: [{0}] → {1}", (object) string.Join<Entity>(", ", (IEnumerable<Entity>) this.targets), (object) this.amount);
    }
  }
}
