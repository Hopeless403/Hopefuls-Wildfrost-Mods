// Decompiled with JetBrains decompiler
// Type: Trigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Trigger
{
  public Entity entity;
  public Entity triggeredBy;
  public Entity[] targets;
  public bool nullified;
  public Hit[] hits;
  public bool countsAsTrigger = true;
  public string type = "basic";
  public bool triggerAgainst;
  public Entity triggerAgainstTarget;
  public CardContainer triggerAgainstContainer;

  public Trigger(Entity entity, Entity triggeredBy, string type, Entity[] targets)
  {
    this.entity = entity;
    this.triggeredBy = triggeredBy;
    this.type = type;
    this.targets = targets;
  }

  public IEnumerator Process()
  {
    string attackerString = this.entity.name;
    string targetsString = this.targets == null || this.targets.Length == 0 ? "null" : "";
    if (this.targets != null)
    {
      for (int index = 0; index < this.targets.Length; ++index)
      {
        if (index > 0)
          targetsString += ", ";
        Entity target = this.targets[index];
        targetsString += (bool) (UnityEngine.Object) target ? target.name : "null";
      }
    }
    Debug.Log((object) ("CardPlayAgainst [" + attackerString + " vs " + targetsString + "]"));
    yield return (object) this.PreProcess();
    if (this.entity.IsAliveAndExists())
    {
      if (this.hits.Length != 0)
        yield return (object) this.Animate();
      yield return (object) this.ProcessHits();
      yield return (object) this.PostProcess();
    }
    Debug.Log((object) ("CardPlayAgainst [" + attackerString + " vs " + targetsString + "] DONE"));
  }

  public virtual IEnumerator PreProcess()
  {
    Trigger trigger1 = this;
    yield return (object) StatusEffectSystem.PreCardPlayedEvent(trigger1.entity, trigger1.targets);
    if (trigger1.entity.IsAliveAndExists())
    {
      if (trigger1.hits == null)
      {
        Trigger trigger2 = trigger1;
        Entity[] targets = trigger1.targets;
        Hit[] hitArray1 = new Hit[targets != null ? targets.Length : 0];
        trigger2.hits = hitArray1;
        if (trigger1.targets != null)
        {
          for (int index = 0; index < trigger1.targets.Length; ++index)
          {
            Hit hit = new Hit(trigger1.entity, trigger1.targets[index]);
            hit.AddAttackerStatuses();
            hit.trigger = trigger1;
            trigger1.hits[index] = hit;
          }
        }
      }
      Hit[] hitArray = trigger1.hits;
      for (int index = 0; index < hitArray.Length; ++index)
        yield return (object) StatusEffectSystem.PreAttackEvent(hitArray[index]);
      hitArray = (Hit[]) null;
    }
  }

  public virtual IEnumerator Animate()
  {
    Trigger data = this;
    if (data.entity.data.hasAttack)
      yield return (object) AssetLoader.Lookup<CardAnimation>("CardAnimations", "Punch").Routine((object) data);
    else
      yield return (object) AssetLoader.Lookup<CardAnimation>("CardAnimations", "Supportive").Routine((object) data);
  }

  public virtual IEnumerator ProcessHits()
  {
    List<Entity> entityList = new List<Entity>();
    Routine.Clump clump = new Routine.Clump();
    foreach (Hit hit in this.hits)
    {
      clump.Add(Trigger.ProcessHit(hit));
      entityList.Add(hit.target);
    }
    yield return (object) clump.WaitForEnd();
  }

  public virtual IEnumerator PostProcess()
  {
    if (this.countsAsTrigger)
      yield return (object) StatusEffectSystem.CardPlayedEvent(this.entity, ((IEnumerable<Hit>) this.hits).Select<Hit, Entity>((Func<Hit, Entity>) (hit => hit.target)).ToArray<Entity>());
  }

  public static IEnumerator ProcessHit(Hit hit)
  {
    yield return (object) hit.Process();
    yield return (object) StatusEffectSystem.PostAttackEvent(hit);
  }

  public static CardContainer GetTargetRow(Entity attacker, Entity target)
  {
    CardContainer targetRow = (CardContainer) null;
    int[] rowIndices1 = Trigger.GetRowIndices(attacker);
    int[] rowIndices2 = Trigger.GetRowIndices(target);
    if (rowIndices1 == null || rowIndices2 == null)
      return (CardContainer) null;
    foreach (int rowIndex in ((IEnumerable<int>) rowIndices1).Intersect<int>((IEnumerable<int>) rowIndices2))
      targetRow = References.Battle.GetRow(target.owner, rowIndex);
    if (!(bool) (UnityEngine.Object) targetRow)
      targetRow = target.containers.Length != 0 ? target.containers[0] : (target.preContainers.Length != 0 ? target.preContainers[0] : (CardContainer) null);
    return targetRow;
  }

  public static int[] GetRowIndices(Entity entity)
  {
    if (entity.alive && Battle.IsOnBoard(entity.containers))
      return References.Battle.GetRowIndices(entity);
    return !Battle.IsOnBoard(entity.preContainers) ? (int[]) null : References.Battle.GetRowIndices((IEnumerable<CardContainer>) entity.preContainers);
  }
}
