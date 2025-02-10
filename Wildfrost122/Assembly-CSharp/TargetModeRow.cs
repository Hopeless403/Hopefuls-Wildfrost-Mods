// Decompiled with JetBrains decompiler
// Type: TargetModeRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "TargetModeRow", menuName = "Target Modes/Row")]
public class TargetModeRow : TargetMode
{
  public override bool TargetRow => true;

  public override Entity[] GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> entitySet = new HashSet<Entity>();
    if ((bool) (Object) targetContainer)
      TargetModeRow.AddEligible(entity, (ISet<Entity>) entitySet, (IEnumerable<Entity>) targetContainer);
    else if ((bool) (Object) target)
    {
      switch (target.containers.Length)
      {
        case 1:
          CardContainer container = target.containers[0];
          TargetModeRow.AddEligible(entity, (ISet<Entity>) entitySet, (IEnumerable<Entity>) container);
          break;
        case 2:
          using (IEnumerator<int> enumerator = ((IEnumerable<int>) References.Battle.GetRowIndices(entity)).Intersect<int>((IEnumerable<int>) References.Battle.GetRowIndices(target)).GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              int current = enumerator.Current;
              List<Entity> enemiesInRow = entity.GetEnemiesInRow(current);
              TargetModeRow.AddEligible(entity, (ISet<Entity>) entitySet, (IEnumerable<Entity>) enemiesInRow);
            }
            break;
          }
      }
    }
    else
    {
      int[] rowIndices = Battle.instance.GetRowIndices(entity);
      foreach (int rowIndex in rowIndices)
      {
        List<Entity> enemiesInRow = entity.GetEnemiesInRow(rowIndex);
        TargetModeRow.AddEligible(entity, (ISet<Entity>) entitySet, (IEnumerable<Entity>) enemiesInRow);
      }
      if (entitySet.Count == 0)
      {
        int rowCount = Battle.instance.rowCount;
        for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
        {
          if (!rowIndices.Contains<int>(rowIndex))
          {
            List<Entity> enemiesInRow = entity.GetEnemiesInRow(rowIndex);
            TargetModeRow.AddEligible(entity, (ISet<Entity>) entitySet, (IEnumerable<Entity>) enemiesInRow);
          }
        }
      }
    }
    return entitySet.Count <= 0 ? (Entity[]) null : entitySet.ToArray<Entity>();
  }

  public override Entity[] GetSubsequentTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    return this.GetTargets(entity, target, targetContainer);
  }

  private static void AddEligible(
    Entity entity,
    ISet<Entity> targets,
    IEnumerable<Entity> fromCollection)
  {
    foreach (Entity from in fromCollection)
    {
      if (entity.CanPlayOn(from, true))
        targets.Add(from);
    }
  }
}
