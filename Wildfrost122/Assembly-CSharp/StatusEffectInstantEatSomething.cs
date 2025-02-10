// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantEatSomething
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Eat Something", fileName = "Eat Something")]
public class StatusEffectInstantEatSomething : StatusEffectInstant
{
  [SerializeField]
  private float delayAfter = 0.25f;
  [SerializeField]
  private StatusEffectData eatEffect;
  [SerializeField]
  private Targets.Flag targetFlags;

  protected override IEnumerator Process()
  {
    StatusEffectInstantEatSomething instantEatSomething = this;
    List<Entity> entityList = Targets.Get(instantEatSomething.target, instantEatSomething.targetFlags, instantEatSomething.eatEffect, instantEatSomething.targetConstraints);
    if (entityList != null && entityList.Count > 0)
    {
      foreach (Entity entity in entityList)
      {
        if (entity.IsAliveAndExists() && instantEatSomething.eatEffect.CanPlayOn(entity))
        {
          Trigger trigger = new Trigger(instantEatSomething.target, instantEatSomething.target, "eat", new Entity[1]
          {
            entity
          })
          {
            countsAsTrigger = false
          };
          Hit hit = new Hit(instantEatSomething.target, entity, 0)
          {
            canBeNullified = false,
            canRetaliate = false,
            damageType = "eat",
            trigger = trigger
          };
          hit.AddStatusEffect(instantEatSomething.eatEffect, 1);
          trigger.hits = new Hit[1]{ hit };
          yield return (object) trigger.Process();
        }
      }
      yield return (object) Sequences.Wait(instantEatSomething.delayAfter);
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantEatSomething.\u003C\u003En__0();
  }
}
