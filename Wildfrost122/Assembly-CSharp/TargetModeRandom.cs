// Decompiled with JetBrains decompiler
// Type: TargetModeRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "TargetModeRandom", menuName = "Target Modes/Random")]
public class TargetModeRandom : TargetMode
{
  public override bool TargetRow => true;

  public override bool Random => true;

  public override Entity[] GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> entitySet = new HashSet<Entity>();
    if ((bool) (Object) targetContainer)
    {
      if (targetContainer.Count > 0)
        TargetModeRandom.AddPotentialTargets(entity, entitySet, (IEnumerable<Entity>) targetContainer);
    }
    else if ((bool) (Object) target)
    {
      switch (target.containers.Length)
      {
        case 1:
          CardContainer container = target.containers[0];
          TargetModeRandom.AddPotentialTargets(entity, entitySet, (IEnumerable<Entity>) container);
          break;
        case 2:
          using (IEnumerator<int> enumerator = ((IEnumerable<int>) References.Battle.GetRowIndices(entity)).Intersect<int>((IEnumerable<int>) References.Battle.GetRowIndices(target)).GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              int current = enumerator.Current;
              TargetModeRandom.AddPotentialTargets(entity, entitySet, current);
            }
            break;
          }
      }
    }
    else
    {
      int[] rowIndices = Battle.instance.GetRowIndices(entity);
      foreach (int rowIndex in rowIndices)
        TargetModeRandom.AddPotentialTargets(entity, entitySet, rowIndex);
      if (entitySet.Count == 0)
      {
        int rowCount = Battle.instance.rowCount;
        for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
        {
          if (!rowIndices.Contains<int>(rowIndex))
            TargetModeRandom.AddPotentialTargets(entity, entitySet, rowIndex);
        }
      }
    }
    return entitySet.Count <= 0 ? (Entity[]) null : entitySet.ToArray<Entity>();
  }

  public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
  {
    Entity[] potentialTargets = this.GetPotentialTargets(entity, target, targetContainer);
    if (potentialTargets == null)
      return (Entity[]) null;
    HashSet<Entity> list1 = new HashSet<Entity>();
    if (entity.containers.Length == 1)
      list1.Add(potentialTargets.RandomItem<Entity>());
    else if (entity.containers.Length > 1)
    {
      Dictionary<CardContainer, List<Entity>> dictionary = new Dictionary<CardContainer, List<Entity>>();
      foreach (CardContainer oppositeRow in References.Battle.GetOppositeRows(entity.containers))
        dictionary.Add(oppositeRow, new List<Entity>());
      foreach (Entity entity1 in potentialTargets)
      {
        foreach (CardContainer container in entity1.containers)
        {
          List<Entity> entityList;
          if (dictionary.TryGetValue(container, out entityList))
            entityList.Add(entity1);
        }
      }
      foreach (List<Entity> list2 in dictionary.Values)
      {
        if (list2.Count > 0)
          list1.Add(list2.RandomItem<Entity>());
      }
    }
    return list1.Count <= 0 ? (Entity[]) null : list1.ToArray<Entity>();
  }

  public override Entity[] GetSubsequentTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    return this.GetTargets(entity, target, targetContainer);
  }

  public override CardSlot[] GetTargetSlots(CardSlotLane row)
  {
    return new CardSlot[1]
    {
      row.slots.RandomItem<CardSlot>()
    };
  }

  private static void AddPotentialTargets(
    Entity entity,
    HashSet<Entity> targets,
    IEnumerable<Entity> collection)
  {
    foreach (Entity target in collection)
    {
      if (entity.CanPlayOn(target, true))
        targets.Add(target);
    }
  }

  private static void AddPotentialTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
  {
    List<Entity> enemiesInRow = entity.GetEnemiesInRow(rowIndex);
    TargetModeRandom.AddPotentialTargets(entity, targets, (IEnumerable<Entity>) enemiesInRow);
  }
}
