// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantEatSomething
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Eat Something", fileName = "Eat Something")]
public class StatusEffectInstantEatSomething : StatusEffectInstant
{
  [SerializeField]
  public float delayAfter = 0.25f;
  [SerializeField]
  public StatusEffectData eatEffect;
  [SerializeField]
  public Targets.Flag targetFlags;

  public override IEnumerator Process()
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
    yield return (object) instantEatSomething.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
