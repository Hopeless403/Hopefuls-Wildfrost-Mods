// Decompiled with JetBrains decompiler
// Type: Targets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;

#nullable disable
public static class Targets
{
  public static bool CheckFlag(Targets.Flag flags, Targets.Flag target) => (flags & target) != 0;

  public static List<Entity> Get(
    Entity self,
    Targets.Flag canTarget,
    StatusEffectData effectToApply,
    TargetConstraint[] applyConstraints,
    Hit hit = null)
  {
    List<Entity> entityList = new List<Entity>();
    if (Targets.CheckFlag(canTarget, Targets.Flag.Self))
      entityList.Add(self);
    Targets.CheckFlag(canTarget, Targets.Flag.Hand);
    Targets.CheckFlag(canTarget, Targets.Flag.EnemyHand);
    if (Targets.CheckFlag(canTarget, Targets.Flag.Allies))
      entityList.AddRange((IEnumerable<Entity>) self.GetAllAllies());
    else if (Targets.CheckFlag(canTarget, Targets.Flag.AlliesInRow))
    {
      entityList.AddRange((IEnumerable<Entity>) self.GetAlliesInRow());
    }
    else
    {
      if (Targets.CheckFlag(canTarget, Targets.Flag.FrontAlly))
      {
        foreach (CardContainer container in self.containers)
        {
          foreach (Entity entity in container)
          {
            if ((bool) (UnityEngine.Object) entity)
            {
              entityList.Add(entity);
              break;
            }
          }
        }
      }
      if (Targets.CheckFlag(canTarget, Targets.Flag.BackAlly))
      {
        foreach (CardContainer container in self.containers)
        {
          for (int index = container.Count - 1; index >= 0; --index)
          {
            Entity entity = container[index];
            if ((bool) (UnityEngine.Object) entity)
            {
              entityList.Add(entity);
              break;
            }
          }
        }
      }
      if (Targets.CheckFlag(canTarget, Targets.Flag.AllyInFrontOf))
      {
        foreach (CardContainer actualContainer in self.actualContainers)
        {
          Entity entity = (Entity) null;
          if (actualContainer is CardSlot cardSlot && actualContainer.Group is CardSlotLane group)
          {
            for (int index = group.slots.IndexOf(cardSlot) - 1; index >= 0; --index)
            {
              entity = group.slots[index].GetTop();
              if ((bool) (UnityEngine.Object) entity)
                break;
            }
          }
          if ((bool) (UnityEngine.Object) entity)
          {
            entityList.Add(entity);
            break;
          }
        }
      }
      if (Targets.CheckFlag(canTarget, Targets.Flag.AllyBehind))
      {
        foreach (CardContainer actualContainer in self.actualContainers)
        {
          Entity entity = (Entity) null;
          if (actualContainer is CardSlot cardSlot && actualContainer.Group is CardSlotLane group)
          {
            for (int index = group.slots.IndexOf(cardSlot) + 1; index < group.slots.Count; ++index)
            {
              entity = group.slots[index].GetTop();
              if ((bool) (UnityEngine.Object) entity)
                break;
            }
          }
          if ((bool) (UnityEngine.Object) entity)
          {
            entityList.Add(entity);
            break;
          }
        }
      }
    }
    if (Targets.CheckFlag(canTarget, Targets.Flag.Enemies))
      entityList.AddRange((IEnumerable<Entity>) self.GetAllEnemies());
    else if (Targets.CheckFlag(canTarget, Targets.Flag.EnemiesInRow))
    {
      foreach (int rowIndex in Battle.instance.GetRowIndices(self))
      {
        List<Entity> enemiesInRow = self.GetEnemiesInRow(rowIndex);
        if (enemiesInRow != null && enemiesInRow.Count > 0)
          entityList.AddRange((IEnumerable<Entity>) enemiesInRow);
      }
    }
    else if (Targets.CheckFlag(canTarget, Targets.Flag.FrontEnemy))
    {
      foreach (int rowIndex in Battle.instance.GetRowIndices(self))
      {
        List<Entity> enemiesInRow = self.GetEnemiesInRow(rowIndex);
        if (enemiesInRow != null && enemiesInRow.Count > 0)
          entityList.Add(enemiesInRow[0]);
      }
    }
    if (Targets.CheckFlag(canTarget, Targets.Flag.Attacker))
    {
      if (hit == null)
        hit = self.lastHit;
      if ((bool) (UnityEngine.Object) hit?.attacker)
      {
        Entity target = hit.attacker;
        if (!effectToApply.CanPlayOn(target))
          target = effectToApply.CanPlayOn(target.owner.entity) ? target.owner.entity : (Entity) null;
        if ((bool) (UnityEngine.Object) target)
          entityList.Add(target);
      }
    }
    if (Targets.CheckFlag(canTarget, Targets.Flag.Target))
    {
      if (hit == null)
        hit = self.lastHit;
      if ((bool) (UnityEngine.Object) hit?.target)
        entityList.Add(hit.target);
    }
    if (Targets.CheckFlag(canTarget, Targets.Flag.RandomUnit))
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(self.owner);
      cardsOnBoard.AddRange((IEnumerable<Entity>) Battle.GetCardsOnBoard(Battle.GetOpponent(self.owner)));
      cardsOnBoard.Remove(self);
      Targets.RemoveIneligible((IList<Entity>) cardsOnBoard, effectToApply, applyConstraints);
      if (cardsOnBoard.Count > 0)
        entityList.Add(cardsOnBoard.RandomItem<Entity>());
    }
    if (Targets.CheckFlag(canTarget, Targets.Flag.RandomAlly))
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(self.owner);
      cardsOnBoard.Remove(self);
      Targets.RemoveIneligible((IList<Entity>) cardsOnBoard, effectToApply, applyConstraints);
      if (cardsOnBoard.Count > 0)
        entityList.Add(cardsOnBoard.RandomItem<Entity>());
    }
    if (Targets.CheckFlag(canTarget, Targets.Flag.RandomEnemy))
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(Battle.GetOpponent(self.owner));
      Targets.RemoveIneligible((IList<Entity>) cardsOnBoard, effectToApply, applyConstraints);
      if (cardsOnBoard.Count > 0)
        entityList.Add(cardsOnBoard.RandomItem<Entity>());
    }
    return entityList;
  }

  public static void RemoveIneligible(
    IList<Entity> list,
    StatusEffectData effectToApply,
    TargetConstraint[] applyConstraints)
  {
    for (int index = list.Count - 1; index >= 0; --index)
    {
      Entity target = list[index];
      if (!effectToApply.CanPlayOn(target))
      {
        list.RemoveAt(index);
      }
      else
      {
        foreach (TargetConstraint applyConstraint in applyConstraints)
        {
          if (!applyConstraint.Check(target))
          {
            list.RemoveAt(index);
            break;
          }
        }
      }
    }
  }

  [Flags]
  public enum Flag
  {
    None = 0,
    Self = 1,
    Hand = 2,
    EnemyHand = 4,
    Allies = 8,
    AlliesInRow = 16, // 0x00000010
    FrontAlly = 32, // 0x00000020
    BackAlly = 64, // 0x00000040
    AllyInFrontOf = 128, // 0x00000080
    AllyBehind = 256, // 0x00000100
    Enemies = 512, // 0x00000200
    EnemiesInRow = 1024, // 0x00000400
    FrontEnemy = 2048, // 0x00000800
    Attacker = 4096, // 0x00001000
    Target = 8192, // 0x00002000
    RandomAlly = 16384, // 0x00004000
    RandomEnemy = 32768, // 0x00008000
    RandomUnit = 65536, // 0x00010000
  }
}
