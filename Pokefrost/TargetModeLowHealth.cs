// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetModeLowHealth
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class TargetModeLowHealth : TargetMode
  {
    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      HashSet<Entity> entitySet = new HashSet<Entity>();
      if ((bool) (Object) targetContainer)
      {
        if (targetContainer.Count > 0)
          entitySet.Add(this.GetTarget((IList<Entity>) targetContainer));
      }
      else if ((bool) (Object) target)
      {
        if (target.containers.Length != 0)
        {
          CardContainer targets = target.containers.RandomItem<CardContainer>();
          if (targets.Count > 0)
            entitySet.Add(this.GetTarget((IList<Entity>) targets));
        }
      }
      else
      {
        int[] rowIndices = Battle.instance.GetRowIndices(entity);
        foreach (int rowIndex in rowIndices)
          this.AddTargets(entity, entitySet, rowIndex);
        if (entitySet.Count == 0)
        {
          int rowCount = Battle.instance.rowCount;
          for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
          {
            if (!rowIndices.Contains<int>(rowIndex))
              this.AddTargets(entity, entitySet, rowIndex);
          }
        }
      }
      return entitySet.Count <= 0 ? (Entity[]) null : entitySet.ToArray<Entity>();
    }

    public override CardSlot[] GetTargetSlots(CardSlotLane row)
    {
      return new CardSlot[1]{ row.slots[row.max - 1] };
    }

    public override bool CanTarget(Entity entity)
    {
      bool flag = true;
      foreach (CardContainer container in entity.containers)
      {
        for (int index = 0; index < container.Count; ++index)
        {
          Entity entity1 = container[index];
          if ((bool) (Object) entity1 && entity1.enabled && entity1.alive && entity1.canBeHit)
          {
            if (entity.hp.current > entity1.hp.current)
            {
              flag = false;
              break;
            }
            if (entity.hp.current == entity1.hp.current && index < container.IndexOf(entity))
            {
              flag = false;
              break;
            }
          }
        }
      }
      return flag;
    }

    public void AddTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
    {
      Entity target = this.GetTarget((IList<Entity>) entity.GetEnemiesInRow(rowIndex));
      if ((bool) (Object) target)
      {
        targets.Add(target);
      }
      else
      {
        Entity enemyCharacter = this.GetEnemyCharacter(entity);
        if (!(bool) (Object) enemyCharacter)
          return;
        targets.Add(enemyCharacter);
      }
    }

    public Entity GetTarget(IList<Entity> targets)
    {
      int num = 1000000000;
      Entity target1 = (Entity) null;
      for (int index = 0; index < targets.Count; ++index)
      {
        Entity target2 = targets[index];
        if ((bool) (Object) target2 && target2.enabled && target2.alive && target2.canBeHit && num > target2.hp.current)
        {
          num = target2.hp.current;
          target1 = target2;
        }
      }
      return target1;
    }
  }
}
