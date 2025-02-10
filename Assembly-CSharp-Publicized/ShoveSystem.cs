// Decompiled with JetBrains decompiler
// Type: ShoveSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ShoveSystem : GameSystem
{
  [CompilerGenerated]
  public static bool \u003CActive\u003Ek__BackingField;
  [CompilerGenerated]
  public static CardSlot \u003CSlot\u003Ek__BackingField;
  [CompilerGenerated]
  public static bool \u003CFix\u003Ek__BackingField;
  public static readonly List<Entity> shovedFrom = new List<Entity>();
  public static Entity dragging;
  public static readonly int[] shoveDirs = new int[2]
  {
    -1,
    1
  };

  public static bool Active
  {
    get => ShoveSystem.\u003CActive\u003Ek__BackingField;
    set => ShoveSystem.\u003CActive\u003Ek__BackingField = value;
  }

  public static CardSlot Slot
  {
    get => ShoveSystem.\u003CSlot\u003Ek__BackingField;
    set => ShoveSystem.\u003CSlot\u003Ek__BackingField = value;
  }

  public static Vector3 Position => ShoveSystem.Slot.transform.position - Vector3.Scale(ShoveSystem.dragging.offset.localPosition, ShoveSystem.dragging.transform.localScale);

  public static bool Fix
  {
    get => ShoveSystem.\u003CFix\u003Ek__BackingField;
    set => ShoveSystem.\u003CFix\u003Ek__BackingField = value;
  }

  public void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(ShoveSystem.DragStart);
    global::Events.OnEntityRelease += new UnityAction<Entity>(ShoveSystem.DragEnd);
    global::Events.OnSlotHover += new UnityAction<CardSlot>(ShoveSystem.SlotHover);
    global::Events.OnSlotUnHover += new UnityAction<CardSlot>(ShoveSystem.SlotUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(ShoveSystem.DragStart);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(ShoveSystem.DragEnd);
    global::Events.OnSlotHover -= new UnityAction<CardSlot>(ShoveSystem.SlotHover);
    global::Events.OnSlotUnHover -= new UnityAction<CardSlot>(ShoveSystem.SlotUnHover);
  }

  public static void DragStart(Entity entity) => ShoveSystem.dragging = entity;

  public static void DragEnd(Entity entity)
  {
    ShoveSystem.dragging = (Entity) null;
    if (!ShoveSystem.Active || ShoveSystem.Fix)
      return;
    ShoveSystem.ClearShove();
  }

  public static void SlotHover(CardSlot slot)
  {
    if (!((UnityEngine.Object) ShoveSystem.Slot != (UnityEngine.Object) null) || !((UnityEngine.Object) ShoveSystem.Slot != (UnityEngine.Object) slot))
      return;
    ShoveSystem.ClearShove();
  }

  public static void SlotUnHover(CardSlot slot)
  {
    if (!ShoveSystem.Active || !((UnityEngine.Object) ShoveSystem.Slot != (UnityEngine.Object) null) || !((UnityEngine.Object) ShoveSystem.Slot == (UnityEngine.Object) slot) || ShoveSystem.Fix)
      return;
    ShoveSystem.ClearShove();
  }

  public static bool CanShove(
    Entity shovee,
    Entity shover,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    shoveData = new Dictionary<Entity, List<CardSlot>>();
    if (!global::Events.CheckEntityShove(shovee))
      return false;
    List<int> list = ShoveSystem.shoveDirs.ToList<int>();
    if (shover.positionPriority > shovee.positionPriority)
      list.Remove(-1);
    if (shovee.positionPriority > shover.positionPriority)
      list.Remove(1);
    bool flag = false;
    foreach (int dir in list)
    {
      CardSlot[] slots = ShoveSystem.FindSlots(shovee, dir);
      if (slots != null && slots.Length != 0)
      {
        flag = ShoveSystem.CanShoveTo(shovee, shover, dir, slots, out shoveData);
        if (flag)
          break;
      }
    }
    if (!flag && ((UnityEngine.Object) shover == (UnityEngine.Object) null || (UnityEngine.Object) shover.data == (UnityEngine.Object) null || shover.data.canShoveToOtherRow))
      flag = ShoveSystem.CanShoveToOtherRow(shovee, shover, out shoveData);
    return flag;
  }

  public static CardSlot[] FindSlots(Entity shovee, int dir)
  {
    bool flag = false;
    List<CardSlot> cardSlotList = new List<CardSlot>();
    foreach (CardContainer container in shovee.containers)
    {
      if (!(container is CardSlotLane cardSlotLane))
      {
        flag = true;
        break;
      }
      int index = cardSlotLane.IndexOf(shovee) + dir;
      if (index < 0 || index >= cardSlotLane.max)
      {
        flag = true;
        break;
      }
      cardSlotList.Add(cardSlotLane.slots[index]);
    }
    return !flag ? cardSlotList.ToArray() : (CardSlot[]) null;
  }

  public static bool CanShoveTo(
    Entity shovee,
    Entity shover,
    int dir,
    CardSlot[] slots,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    shoveData = new Dictionary<Entity, List<CardSlot>>();
    int num = 1;
    Queue<KeyValuePair<Entity, CardSlot[]>> source = new Queue<KeyValuePair<Entity, CardSlot[]>>();
    source.Enqueue(new KeyValuePair<Entity, CardSlot[]>(shovee, slots));
    List<Entity> entityList = new List<Entity>();
    bool flag = false;
    while (source.Count > 0)
    {
      KeyValuePair<Entity, CardSlot[]> keyValuePair = source.Dequeue();
      Entity key = keyValuePair.Key;
      entityList.Add(key);
      CardSlot[] cardSlotArray = keyValuePair.Value;
      if (cardSlotArray != null && cardSlotArray.Length != 0)
      {
        List<CardSlot> cardSlotList = new List<CardSlot>();
        foreach (CardSlot cardSlot in cardSlotArray)
        {
          if (shoveData.ContainsKey(key))
            shoveData[key].Add(cardSlot);
          else
            shoveData[key] = new List<CardSlot>()
            {
              cardSlot
            };
          Entity top = cardSlot.GetTop();
          if ((UnityEngine.Object) top != (UnityEngine.Object) null && (UnityEngine.Object) top != (UnityEngine.Object) shover)
            cardSlotList.Add(cardSlot);
        }
        --num;
        foreach (CardSlot cardSlot in cardSlotList)
        {
          Entity blockingEntity = cardSlot.GetTop();
          if (!entityList.Contains(blockingEntity) && !source.Any<KeyValuePair<Entity, CardSlot[]>>((Func<KeyValuePair<Entity, CardSlot[]>, bool>) (p => (UnityEngine.Object) p.Key == (UnityEngine.Object) blockingEntity)))
          {
            CardSlot[] slots1 = ShoveSystem.FindSlots(blockingEntity, dir);
            source.Enqueue(new KeyValuePair<Entity, CardSlot[]>(blockingEntity, slots1));
            ++num;
          }
        }
      }
      else
        break;
    }
    if (num <= 0)
      flag = true;
    return flag;
  }

  public static bool CanShoveToOtherRow(
    Entity shovee,
    Entity shover,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    shoveData = new Dictionary<Entity, List<CardSlot>>();
    if (shovee.containers.Length != 1 || !(shovee.containers[0] is CardSlotLane container))
      return false;
    int a = container.IndexOf(shovee);
    bool otherRow = false;
    foreach (CardContainer cardContainer in container.shoveTo)
    {
      if (cardContainer is CardSlotLane cardSlotLane)
      {
        int num = cardSlotLane.max - cardSlotLane.Count;
        if (cardSlotLane.Contains(shover))
          ++num;
        if (num > 0)
        {
          int index = Mathf.Min(a, cardSlotLane.max - 1);
          CardSlot slot = cardSlotLane.slots[index];
          foreach (int shoveDir in ShoveSystem.shoveDirs)
          {
            otherRow = ShoveSystem.CanShoveTo(shovee, shover, shoveDir, new CardSlot[1]
            {
              slot
            }, out shoveData);
            if (otherRow)
              break;
          }
          if (otherRow)
            break;
        }
      }
    }
    return otherRow;
  }

  public static void ShowShove(CardSlot fromContainer, Dictionary<Entity, List<CardSlot>> shoveData)
  {
    ShoveSystem.Active = true;
    ShoveSystem.Slot = fromContainer;
    float time = 0.3f;
    LeanTweenType easeType = LeanTweenType.easeOutQuart;
    foreach (KeyValuePair<Entity, List<CardSlot>> keyValuePair in shoveData)
    {
      Entity key = keyValuePair.Key;
      List<CardSlot> cardSlotList = keyValuePair.Value;
      GameObject gameObject = key.gameObject;
      LeanTween.cancel(gameObject);
      Vector3 zero = Vector3.zero;
      foreach (CardSlot cardSlot in cardSlotList)
        zero += cardSlot.transform.position;
      Vector3 to = zero / (float) cardSlotList.Count;
      LeanTween.move(gameObject, to, time).setEase(easeType);
      ShoveSystem.shovedFrom.Add(key);
    }
  }

  public static IEnumerator DoShove(
    Dictionary<Entity, List<CardSlot>> shoveData,
    bool updatePositions = false)
  {
    foreach (KeyValuePair<Entity, List<CardSlot>> keyValuePair in shoveData)
      keyValuePair.Key.RemoveFromContainers();
    HashSet<CardContainer> cardContainerSet = new HashSet<CardContainer>();
    foreach (KeyValuePair<Entity, List<CardSlot>> keyValuePair in shoveData)
    {
      Entity key = keyValuePair.Key;
      foreach (CardSlot cardSlot in keyValuePair.Value)
      {
        cardSlot.Add(key);
        cardContainerSet.Add((CardContainer) cardSlot);
      }
    }
    if (updatePositions)
    {
      foreach (CardContainer cardContainer in cardContainerSet)
        cardContainer.TweenChildPositions();
    }
    Routine.Clump clump = new Routine.Clump();
    foreach (KeyValuePair<Entity, List<CardSlot>> keyValuePair in shoveData)
    {
      global::Events.InvokeEntityMove(keyValuePair.Key);
      clump.Add(StatusEffectSystem.CardMoveEvent(keyValuePair.Key));
    }
    yield return (object) clump.WaitForEnd();
    ShoveSystem.Deactivate();
  }

  public static void ClearShove()
  {
    foreach (Entity child in ShoveSystem.shovedFrom)
    {
      foreach (CardContainer actualContainer in child.actualContainers)
        actualContainer.TweenChildPosition(child);
    }
    ShoveSystem.Deactivate();
  }

  public static void Deactivate()
  {
    ShoveSystem.shovedFrom.Clear();
    ShoveSystem.Slot = (CardSlot) null;
    ShoveSystem.Fix = false;
    ShoveSystem.Active = false;
  }
}
