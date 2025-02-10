// Decompiled with JetBrains decompiler
// Type: TriggerBombard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class TriggerBombard : Trigger
{
  public CardContainer[] slots;

  public TriggerBombard(
    Entity entity,
    Entity triggeredBy,
    string type,
    Entity[] targets,
    CardContainer[] slots)
    : base(entity, triggeredBy, type, targets)
  {
    this.slots = slots;
  }

  protected override IEnumerator PreProcess()
  {
    TriggerBombard triggerBombard1 = this;
    List<Entity> entityList = new List<Entity>();
    foreach (CardContainer slot in triggerBombard1.slots)
    {
      Entity top = slot.GetTop();
      entityList.Add(top);
    }
    triggerBombard1.targets = entityList.ToArray();
    yield return (object) StatusEffectSystem.PreCardPlayedEvent(triggerBombard1.entity, triggerBombard1.targets);
    TriggerBombard triggerBombard2 = triggerBombard1;
    Entity[] targets = triggerBombard1.targets;
    Hit[] hitArray1 = new Hit[targets != null ? targets.Length : 0];
    triggerBombard2.hits = hitArray1;
    if (triggerBombard1.targets != null)
    {
      for (int index = 0; index < triggerBombard1.targets.Length; ++index)
      {
        Hit hit = new Hit(triggerBombard1.entity, triggerBombard1.targets[index]);
        hit.AddAttackerStatuses();
        hit.trigger = (Trigger) triggerBombard1;
        triggerBombard1.hits[index] = hit;
      }
    }
    Hit[] hitArray = triggerBombard1.hits;
    for (int index = 0; index < hitArray.Length; ++index)
    {
      Hit hit = hitArray[index];
      if ((bool) (Object) hit.target)
        yield return (object) StatusEffectSystem.PreAttackEvent(hit);
    }
    hitArray = (Hit[]) null;
  }

  protected override IEnumerator Animate()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TriggerBombard triggerBombard = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    Routine routine = new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "BombardRocketShoot").Routine((object) triggerBombard.entity));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Wait(0.2f);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  protected override IEnumerator ProcessHits()
  {
    yield return (object) this.RainRockets();
  }

  private IEnumerator RainRockets()
  {
    TriggerBombard triggerBombard = this;
    CardAnimation rocketAnimation = AssetLoader.Lookup<CardAnimation>("CardAnimations", "BombardRocket");
    Routine.Clump clump = new Routine.Clump();
    for (int i = 0; i < triggerBombard.hits.Length; ++i)
    {
      clump.Add(TriggerBombard.Fire(rocketAnimation, triggerBombard.hits[i], triggerBombard.slots[i]));
      yield return (object) Sequences.Wait(0.3f);
    }
    yield return (object) clump.WaitForEnd();
  }

  private static IEnumerator Fire(CardAnimation rocketAnimation, Hit hit, CardContainer slot)
  {
    yield return (object) rocketAnimation.Routine((object) slot.transform.position);
    if ((bool) (Object) hit.target)
      yield return (object) Trigger.ProcessHit(hit);
  }
}
