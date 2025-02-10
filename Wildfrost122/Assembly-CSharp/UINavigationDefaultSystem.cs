// Decompiled with JetBrains decompiler
// Type: UINavigationDefaultSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public static class UINavigationDefaultSystem
{
  public static void SetStartingItem(bool useClosest = true, bool ignoreHistory = false)
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return;
    Debug.Log((object) "UINavigationDefaultSystem → Finding Default Item");
    if (!MonoBehaviourSingleton<UINavigationSystem>.instance.AvailableNavigationItems.Any<UINavigationItem>())
    {
      Debug.Log((object) "UINavigationDefaultSystem → no available navigation items");
    }
    else
    {
      List<UINavigationItem> list = MonoBehaviourSingleton<UINavigationSystem>.instance.AvailableNavigationItems.Where<UINavigationItem>((Func<UINavigationItem, bool>) (item => (UnityEngine.Object) item != (UnityEngine.Object) null && item.CheckLayer())).ToList<UINavigationItem>();
      if (list.Count <= 0)
      {
        Debug.Log((object) "UINavigationDefaultSystem → no possible items on current navigation layer");
      }
      else
      {
        if (list.Count == 1)
          MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem(list[0]);
        else
          MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem((!useClosest ? (!ignoreHistory ? (IEnumerable<UINavigationItem>) list.OrderByDescending<UINavigationItem, int>((Func<UINavigationItem, int>) (a => !UINavigationHistory.items.Contains(a) ? (int) a.selectionPriority : (int) (UINavigationHistory.items.IndexOf(a) + a.selectionPriority))).ThenBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(MonoBehaviourSingleton<Cursor3d>.instance.transform.position, a.Position))).ToList<UINavigationItem>() : (IEnumerable<UINavigationItem>) list.OrderByDescending<UINavigationItem, int>((Func<UINavigationItem, int>) (a => (int) a.selectionPriority)).ThenBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(MonoBehaviourSingleton<Cursor3d>.instance.transform.position, a.Position))).ToList<UINavigationItem>()) : (!ignoreHistory ? (IEnumerable<UINavigationItem>) list.OrderBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(MonoBehaviourSingleton<Cursor3d>.instance.transform.position, a.Position) - (float) a.selectionPriority)).ThenByDescending<UINavigationItem, int>((Func<UINavigationItem, int>) (a => !UINavigationHistory.items.Contains(a) ? (int) a.selectionPriority : (int) (UINavigationHistory.items.IndexOf(a) + a.selectionPriority))).ToList<UINavigationItem>() : (IEnumerable<UINavigationItem>) list.OrderBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(MonoBehaviourSingleton<Cursor3d>.instance.transform.position, a.Position) - (float) a.selectionPriority)).ThenByDescending<UINavigationItem, int>((Func<UINavigationItem, int>) (a => (int) a.selectionPriority)).ToList<UINavigationItem>())).First<UINavigationItem>());
        Debug.Log((object) string.Format("UINavigationDefaultSystem → Default Item Set: {0}", (object) MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem));
      }
    }
  }

  public static void SetDefaultTarget(Entity entity)
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse || !MonoBehaviourSingleton<UINavigationSystem>.instance.AvailableNavigationItems.Any<UINavigationItem>())
      return;
    CardData.PlayPosition playPosition = UINavigationDefaultSystem.GetPlayPosition(entity);
    List<UINavigationItem> list = UINavigationDefaultSystem.GetDefaultTargets(entity, playPosition).Intersect<UINavigationItem>((IEnumerable<UINavigationItem>) MonoBehaviourSingleton<UINavigationSystem>.instance.AvailableNavigationItems).Where<UINavigationItem>((Func<UINavigationItem, bool>) (item => (UnityEngine.Object) item != (UnityEngine.Object) null && item.CheckLayer())).ToList<UINavigationItem>();
    if (list.Count <= 0)
      UINavigationDefaultSystem.SetStartingItem();
    else if (list.Count == 1)
      MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem(list[0]);
    else
      MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem(list.OrderBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(MonoBehaviourSingleton<Cursor3d>.instance.transform.position, a.Position) - (float) a.selectionPriority - (float) UINavigationHistory.GetItemIndex(a))).ToList<UINavigationItem>().First<UINavigationItem>());
  }

  private static CardData.PlayPosition GetPlayPosition(Entity entity)
  {
    if (entity.data.playType == Card.PlayType.Place)
      return CardData.PlayPosition.FriendlySlot;
    if (entity.data.defaultPlayPosition != CardData.PlayPosition.None)
      return entity.data.defaultPlayPosition;
    if (!entity.NeedsTarget)
      return CardData.PlayPosition.None;
    if (entity.data.playOnSlot)
    {
      if (entity.data.canPlayOnFriendly)
        return CardData.PlayPosition.FriendlySlot;
      return !entity.data.canPlayOnEnemy ? CardData.PlayPosition.None : CardData.PlayPosition.EnemySlot;
    }
    return entity.IsOffensive() ? (!entity.targetMode.TargetRow ? CardData.PlayPosition.Enemy : CardData.PlayPosition.EnemyRow) : (!entity.targetMode.TargetRow ? CardData.PlayPosition.Friendly : CardData.PlayPosition.FriendlyRow);
  }

  private static IEnumerable<UINavigationItem> GetDefaultTargets(
    Entity entity,
    CardData.PlayPosition playPosition)
  {
    List<UINavigationItem> defaultTargets;
    switch (playPosition)
    {
      case CardData.PlayPosition.Friendly:
        defaultTargets = Battle.GetCardsOnBoard(entity.owner).Select<Entity, UINavigationItem>((Func<Entity, UINavigationItem>) (a => a.uINavigationItem)).ToList<UINavigationItem>();
        break;
      case CardData.PlayPosition.Enemy:
        defaultTargets = Battle.GetCardsOnBoard(Battle.GetOpponent(entity.owner)).Select<Entity, UINavigationItem>((Func<Entity, UINavigationItem>) (a => a.uINavigationItem)).ToList<UINavigationItem>();
        break;
      case CardData.PlayPosition.FriendlyRow:
        defaultTargets = References.Battle.GetRows(entity.owner).Select<CardContainer, UINavigationItem>((Func<CardContainer, UINavigationItem>) (a => a.nav)).ToList<UINavigationItem>();
        break;
      case CardData.PlayPosition.EnemyRow:
        defaultTargets = References.Battle.GetRows(Battle.GetOpponent(entity.owner)).Select<CardContainer, UINavigationItem>((Func<CardContainer, UINavigationItem>) (a => a.nav)).ToList<UINavigationItem>();
        break;
      case CardData.PlayPosition.FriendlySlot:
        defaultTargets = Battle.IsOnBoard(entity) ? entity.actualContainers.Select<CardContainer, UINavigationItem>((Func<CardContainer, UINavigationItem>) (a => a.nav)).ToList<UINavigationItem>() : References.Battle.GetSlots(entity.owner).Select<CardSlot, UINavigationItem>((Func<CardSlot, UINavigationItem>) (a => a.nav)).ToList<UINavigationItem>();
        break;
      case CardData.PlayPosition.EnemySlot:
        defaultTargets = References.Battle.GetSlots(Battle.GetOpponent(entity.owner)).Select<CardSlot, UINavigationItem>((Func<CardSlot, UINavigationItem>) (a => a.nav)).ToList<UINavigationItem>();
        break;
      default:
        defaultTargets = new List<UINavigationItem>();
        break;
    }
    return (IEnumerable<UINavigationItem>) defaultTargets;
  }
}
