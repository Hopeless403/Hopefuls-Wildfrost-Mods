// Decompiled with JetBrains decompiler
// Type: TargetMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class TargetMode : ScriptableObject
{
  public virtual bool TargetRow => false;

  public virtual bool NeedsTarget => true;

  public virtual bool Random => false;

  public virtual Entity[] GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    throw new NotImplementedException();
  }

  public virtual Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer) => this.GetPotentialTargets(entity, target, targetContainer);

  public virtual Entity[] GetSubsequentTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> list = new HashSet<Entity>();
    if ((bool) (UnityEngine.Object) target)
      list.Add(target);
    else if ((bool) (UnityEngine.Object) targetContainer)
      list.AddRange<Entity>((IEnumerable<Entity>) targetContainer);
    return list.ToArray<Entity>();
  }

  public virtual CardSlot[] GetTargetSlots(CardSlotLane row) => row.slots.Where<CardSlot>((Func<CardSlot, bool>) (a => a.Empty)).ToArray<CardSlot>();

  public virtual bool CanTarget(Entity entity) => true;

  protected virtual Entity GetEnemyCharacter(Entity entity)
  {
    Entity enemyCharacter = (Entity) null;
    Character character = (UnityEngine.Object) entity.owner == (UnityEngine.Object) Battle.instance.player ? Battle.instance.enemy : Battle.instance.player;
    if ((bool) (UnityEngine.Object) character && (bool) (UnityEngine.Object) character.entity && character.entity.canBeHit)
      enemyCharacter = character.entity;
    return enemyCharacter;
  }
}
