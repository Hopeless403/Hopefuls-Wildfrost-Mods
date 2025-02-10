// Decompiled with JetBrains decompiler
// Type: TargetModeBasic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "TargetModeBasic", menuName = "Target Modes/Basic")]
public class TargetModeBasic : TargetMode
{
  public override Entity[] GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> entitySet = new HashSet<Entity>();
    if ((bool) (Object) target)
    {
      entitySet.Add(target);
    }
    else
    {
      int[] rowIndices = Battle.instance.GetRowIndices(entity);
      if (rowIndices.Length != 0)
      {
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
    }
    return entitySet.Count <= 0 ? (Entity[]) null : entitySet.ToArray<Entity>();
  }

  private void AddTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
  {
    List<Entity> enemiesInRow = entity.GetEnemiesInRow(rowIndex);
    Entity entity1 = (Entity) null;
    foreach (Entity entity2 in enemiesInRow)
    {
      if ((bool) (Object) entity2 && entity2.enabled && entity2.alive && entity2.canBeHit)
      {
        entity1 = entity2;
        break;
      }
    }
    if ((bool) (Object) entity1)
    {
      targets.Add(entity1);
    }
    else
    {
      Entity enemyCharacter = this.GetEnemyCharacter(entity);
      if (!(bool) (Object) enemyCharacter)
        return;
      targets.Add(enemyCharacter);
    }
  }
}
