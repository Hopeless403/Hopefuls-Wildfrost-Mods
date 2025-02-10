// Decompiled with JetBrains decompiler
// Type: TargetModeBack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TargetModeBack", menuName = "Target Modes/Back")]
public class TargetModeBack : TargetMode
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

  public override CardSlot[] GetTargetSlots(CardSlotLane row) => new CardSlot[1]
  {
    row.slots[row.max - 1]
  };

  public override bool CanTarget(Entity entity)
  {
    bool flag = false;
    foreach (CardContainer container in entity.containers)
    {
      flag = true;
      for (int index = container.IndexOf(entity) + 1; index < container.max; ++index)
      {
        if ((bool) (Object) container[index] && container[index].canBeHit)
        {
          flag = false;
          break;
        }
      }
      if (flag)
        break;
    }
    return flag;
  }

  private void AddTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
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

  private Entity GetTarget(IList<Entity> targets)
  {
    for (int index = targets.Count - 1; index >= 0; --index)
    {
      Entity target = targets[index];
      if ((bool) (Object) target && target.enabled && target.alive && target.canBeHit)
        return target;
    }
    return (Entity) null;
  }
}
