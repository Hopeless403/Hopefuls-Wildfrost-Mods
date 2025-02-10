// Decompiled with JetBrains decompiler
// Type: CardSlotLane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CardSlotLane : CardContainer
{
  public List<CardSlot> slots;
  [Required(null)]
  public CardSlot slotPrefab;
  [Required(null)]
  public HorizontalLayoutGroup layout;
  public bool autoMoveForwards = true;

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    Routine routine = new Routine(this.SetSizeRoutine(size, cardScale));
  }

  private IEnumerator SetSizeRoutine(int size, float cardScale)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    CardSlotLane cardSlotLane = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      cardSlotLane.holder.sizeDelta = ((RectTransform) cardSlotLane.layout.transform).sizeDelta;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    cardSlotLane.CreateSlots(size);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) null;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override void MoveChildrenForward()
  {
    for (int index1 = 1; index1 < this.max; ++index1)
    {
      CardSlot slot1 = this.slots[index1];
      Entity top = slot1.GetTop();
      if ((bool) (UnityEngine.Object) top && top.positionPriority > 0)
      {
        int num = 0;
        List<CardSlot> cardSlotList = new List<CardSlot>()
        {
          slot1
        };
        if (top.height > 1)
        {
          foreach (CardContainer secondaryContainer in slot1.GetSecondaryContainers(top))
          {
            if (secondaryContainer is CardSlot cardSlot && secondaryContainer.Group is CardSlotLane)
              cardSlotList.Add(cardSlot);
          }
        }
        for (int index2 = index1 - 1; index2 >= 0; --index2)
        {
          bool flag = true;
          foreach (CardContainer cardContainer in cardSlotList)
          {
            if (!(cardContainer.Group as CardSlotLane).slots[index2].Empty)
            {
              flag = false;
              break;
            }
          }
          if (flag)
            ++num;
          else
            break;
        }
        if (num > 0)
        {
          if (cardSlotList.Count > 1)
          {
            foreach (CardSlot cardSlot in cardSlotList)
            {
              if (cardSlot.IsPrimaryContainer(top))
              {
                cardSlotList.Remove(cardSlot);
                cardSlotList.Insert(0, cardSlot);
                break;
              }
            }
          }
          for (int index3 = cardSlotList.Count - 1; index3 >= 0; --index3)
          {
            CardSlot cardSlot = cardSlotList[index3];
            CardSlotLane group = cardSlot.Group as CardSlotLane;
            CardSlot slot2 = group.slots[group.slots.IndexOf(cardSlot) - num];
            cardSlot.Remove(top);
            Entity entity = top;
            slot2.Add(entity);
          }
        }
      }
    }
    for (int index4 = this.max - 2; index4 >= 0; --index4)
    {
      CardSlot slot3 = this.slots[index4];
      Entity top = slot3.GetTop();
      if ((bool) (UnityEngine.Object) top && top.positionPriority < 0)
      {
        int num = 0;
        List<CardSlot> cardSlotList = new List<CardSlot>()
        {
          slot3
        };
        if (top.height > 1)
        {
          foreach (CardContainer secondaryContainer in slot3.GetSecondaryContainers(top))
          {
            if (secondaryContainer is CardSlot cardSlot && secondaryContainer.Group is CardSlotLane)
              cardSlotList.Add(cardSlot);
          }
        }
        for (int index5 = index4 + 1; index5 < this.max; ++index5)
        {
          bool flag = true;
          foreach (CardContainer cardContainer in cardSlotList)
          {
            if (!(cardContainer.Group as CardSlotLane).slots[index5].Empty)
            {
              flag = false;
              break;
            }
          }
          if (flag)
            ++num;
          else
            break;
        }
        if (num > 0)
        {
          if (cardSlotList.Count > 1)
          {
            foreach (CardSlot cardSlot in cardSlotList)
            {
              if (cardSlot.IsPrimaryContainer(top))
              {
                cardSlotList.Remove(cardSlot);
                cardSlotList.Insert(0, cardSlot);
                break;
              }
            }
          }
          for (int index6 = cardSlotList.Count - 1; index6 >= 0; --index6)
          {
            CardSlot cardSlot = cardSlotList[index6];
            CardSlotLane group = cardSlot.Group as CardSlotLane;
            CardSlot slot4 = group.slots[group.slots.IndexOf(cardSlot) + num];
            cardSlot.Remove(top);
            Entity entity = top;
            slot4.Add(entity);
          }
        }
      }
    }
  }

  public override int Count
  {
    get
    {
      int count = 0;
      foreach (CardSlot slot in this.slots)
        count += slot.Count;
      return count;
    }
    protected set => base.Count = value;
  }

  public void SetDirection(int direction) => this.layout.reverseArrangement = direction == 1;

  private void CreateSlots(int count)
  {
    this.layout.transform.DestroyAllChildren();
    this.slots.Clear();
    CardSlot cardSlot1 = (CardSlot) null;
    for (int index = 0; index < count; ++index)
    {
      CardSlot cardSlot2 = UnityEngine.Object.Instantiate<CardSlot>(this.slotPrefab, this.layout.transform);
      cardSlot2.name = string.Format("{0} [Slot {1}]", (object) this.name, (object) (index + 1));
      cardSlot2.owner = this.owner;
      cardSlot2.Group = (CardContainer) this;
      this.slots.Add(cardSlot2);
      if ((bool) (UnityEngine.Object) cardSlot1)
      {
        cardSlot1.shoveTo.Add((CardContainer) cardSlot2);
        cardSlot2.shoveTo.Add((CardContainer) cardSlot1);
      }
      cardSlot1 = cardSlot2;
    }
  }

  public override void Add(Entity entity)
  {
    if (this.Count >= this.max)
      return;
    if (entity.positionPriority >= 0)
    {
      for (int index1 = 0; index1 < this.max; ++index1)
      {
        CardSlot slot = this.slots[index1];
        Entity top1 = slot.GetTop();
        if (!(bool) (UnityEngine.Object) top1)
        {
          slot.Add(entity);
          break;
        }
        if (top1.positionPriority < entity.positionPriority)
        {
          bool flag = true;
          for (int index2 = index1 + 1; index2 < this.max; ++index2)
          {
            Entity top2 = this.slots[index2].GetTop();
            if ((bool) (UnityEngine.Object) top2 && top2.positionPriority >= entity.positionPriority)
            {
              flag = false;
              break;
            }
          }
          if (flag)
          {
            this.Insert(index1, entity);
            break;
          }
        }
      }
    }
    else
    {
      for (int index = this.max - 1; index >= 0; --index)
      {
        CardSlot slot = this.slots[index];
        Entity top = slot.GetTop();
        if (!(bool) (UnityEngine.Object) top)
        {
          slot.Add(entity);
          break;
        }
        if (top.positionPriority <= entity.positionPriority)
        {
          this.Insert(index, entity);
          break;
        }
      }
    }
  }

  public override void Insert(int index, Entity entity)
  {
    if (this.Count >= this.max)
      return;
    CardSlot slot = this.slots[index];
    if ((bool) (UnityEngine.Object) slot && slot.Empty)
    {
      slot.Add(entity);
    }
    else
    {
      bool flag = this.PushForwards(index);
      if (!flag)
        flag = this.PushBackwards(index);
      if (!flag)
        return;
      slot.Add(entity);
    }
  }

  public override bool PushForwards(int fromIndex)
  {
    int num = this.CanPush(fromIndex) ? 1 : 0;
    if (num == 0)
      return num != 0;
    this.GetPushData(fromIndex).Execute();
    return num != 0;
  }

  public override bool PushBackwards(int fromIndex)
  {
    int num = this.CanPush(fromIndex, 1) ? 1 : 0;
    if (num == 0)
      return num != 0;
    this.GetPushData(fromIndex, 1).Execute();
    return num != 0;
  }

  public bool CanPush(int fromIndex, int direction = -1)
  {
    bool flag = true;
    Entity top = this.slots[fromIndex].GetTop();
    if ((bool) (UnityEngine.Object) top)
    {
      foreach (CardContainer container in top.containers)
      {
        if (container is CardSlotLane cardSlotLane)
        {
          int fromIndex1 = cardSlotLane.IndexOf(top) + direction;
          if (fromIndex1 >= 0 && fromIndex1 < cardSlotLane.max)
          {
            if (!cardSlotLane.CanPush(fromIndex1, direction))
            {
              flag = false;
              break;
            }
          }
          else
          {
            flag = false;
            break;
          }
        }
        else
        {
          flag = false;
          break;
        }
      }
    }
    return flag;
  }

  public CardSlotLane.PushData GetPushData(int fromIndex, int direction = -1)
  {
    CardSlotLane.PushData pushData = new CardSlotLane.PushData();
    Entity top = this.slots[fromIndex].GetTop();
    if ((bool) (UnityEngine.Object) top)
    {
      foreach (CardContainer container in top.containers)
      {
        if (container is CardSlotLane cardSlotLane)
        {
          int num = cardSlotLane.IndexOf(top) + direction;
          if (num >= 0 && num < cardSlotLane.max)
          {
            CardSlot slot = cardSlotLane.slots[num];
            pushData.Add(top, (CardContainer) slot);
            pushData.Add(cardSlotLane.GetPushData(num, direction));
          }
        }
      }
    }
    return pushData;
  }

  public override void Remove(Entity entity)
  {
    foreach (CardSlot slot in this.slots)
    {
      if (slot.Count > 0 && (UnityEngine.Object) slot[0] == (UnityEngine.Object) entity)
        slot.Remove(entity);
    }
  }

  public override void RemoveAt(int index)
  {
    CardSlot slot = this.slots[index];
    if (!(bool) (UnityEngine.Object) slot || slot.Empty)
      return;
    slot.RemoveAt(0);
  }

  public override Entity this[int index]
  {
    get
    {
      int skips = this.GetSkips(index);
      for (int index1 = index + skips; index1 < this.max; ++index1)
      {
        CardSlot slot = this.slots[index1];
        if ((UnityEngine.Object) slot != (UnityEngine.Object) null && !slot.Empty)
          return slot[0];
      }
      return (Entity) null;
    }
    set => throw new NotImplementedException();
  }

  private int GetSkips(int upToIndex)
  {
    int skips = 0;
    for (int index = 0; index <= upToIndex; ++index)
    {
      CardSlot slot = this.slots[index];
      if ((UnityEngine.Object) slot == (UnityEngine.Object) null || slot.Empty)
        ++skips;
    }
    return skips;
  }

  public override Entity GetTop()
  {
    if (this.max <= 0)
      return (Entity) null;
    return this.slots[0].Empty ? (Entity) null : this.slots[0][0];
  }

  public override int IndexOf(Entity item)
  {
    for (int index = 0; index < this.max; ++index)
    {
      if (this.slots[index].Contains(item))
        return index;
    }
    return -1;
  }

  public override bool Contains(Entity item) => this.slots.Any<CardSlot>((Func<CardSlot, bool>) (slot => slot.Contains(item)));

  public override Entity[] ToArray()
  {
    List<Entity> entityList = new List<Entity>();
    foreach (CardSlot slot in this.slots)
    {
      if (slot.Count > 0)
        entityList.Add(slot[0]);
    }
    return entityList.ToArray();
  }

  public override IEnumerator<Entity> GetEnumerator()
  {
    foreach (CardContainer slot in this.slots)
    {
      foreach (Entity entity in slot)
        yield return entity;
    }
  }

  public class PushData
  {
    public readonly Dictionary<Entity, List<CardContainer>> dict = new Dictionary<Entity, List<CardContainer>>();

    public void Add(CardSlotLane.PushData other)
    {
      foreach (KeyValuePair<Entity, List<CardContainer>> keyValuePair in other.dict)
        this.Add(keyValuePair.Key, keyValuePair.Value);
    }

    public void Add(Entity entity, CardContainer container)
    {
      if (this.dict.ContainsKey(entity))
        this.dict[entity].Add(container);
      else
        this.dict[entity] = new List<CardContainer>()
        {
          container
        };
    }

    public void Add(Entity entity, List<CardContainer> containers)
    {
      if (this.dict.ContainsKey(entity))
        this.dict[entity].AddRange((IEnumerable<CardContainer>) containers);
      else
        this.dict[entity] = containers;
    }

    public void Execute()
    {
      foreach (KeyValuePair<Entity, List<CardContainer>> keyValuePair in this.dict)
        keyValuePair.Key.RemoveFromContainers();
      foreach (KeyValuePair<Entity, List<CardContainer>> keyValuePair in this.dict)
      {
        foreach (CardContainer cardContainer in keyValuePair.Value)
          cardContainer.Add(keyValuePair.Key);
      }
    }
  }
}
