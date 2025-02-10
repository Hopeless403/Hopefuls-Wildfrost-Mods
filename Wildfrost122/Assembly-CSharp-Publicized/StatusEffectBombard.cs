// Decompiled with JetBrains decompiler
// Type: StatusEffectBombard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Bombard", fileName = "Bombard")]
public class StatusEffectBombard : StatusEffectData
{
  [SerializeField]
  public Vector2Int targetCountRange = new Vector2Int(2, 2);
  [SerializeField]
  [Range(0.0f, 1f)]
  public float hitFriendlyChance = 0.1f;
  [SerializeField]
  public float delayBetweenTargets = 0.1f;
  [SerializeField]
  public float delayAfter = 0.1f;
  [SerializeField]
  public int maxFrontTargets;
  public List<CardContainer> targetList = new List<CardContainer>();
  public bool triggered;
  public int[] storedTargetList;

  public override object GetMidBattleData()
  {
    List<CardContainer> targetList = this.targetList;
    if (targetList == null || targetList.Count <= 0)
      return (object) null;
    List<int> intList = new List<int>();
    List<CardSlot> slots = References.Battle.GetSlots();
    foreach (CardContainer target in this.targetList)
    {
      if (target is CardSlot cardSlot)
      {
        int num = slots.IndexOf(cardSlot);
        if (num >= 0)
          intList.Add(num);
      }
    }
    return (object) new StatusEffectBombard.SlotList()
    {
      list = intList.ToArray()
    };
  }

  public override void RestoreMidBattleData(object data)
  {
    if (!(data is StatusEffectBombard.SlotList slotList))
      return;
    this.storedTargetList = slotList.list;
  }

  public override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Enable);
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CardPlayed);
    this.OnActionPerformed += new StatusEffectData.EffectActionPerformedHandler(this.ActionPerformed);
    Events.OnEntityTrigger += new Events.UnityActionRef<Trigger>(this.EntityTrigger);
  }

  public void OnDestroy()
  {
    Events.OnEntityTrigger -= new Events.UnityActionRef<Trigger>(this.EntityTrigger);
  }

  public void EntityTrigger(ref Trigger trigger)
  {
    if (!((UnityEngine.Object) trigger.entity == (UnityEngine.Object) this.target) || !this.CanTrigger() || !(trigger.type == "basic"))
      return;
    trigger = (Trigger) new TriggerBombard(trigger.entity, trigger.triggeredBy, "bombard", trigger.targets, this.targetList.ToArray());
  }

  public override bool RunEnableEvent(Entity entity) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target;

  public IEnumerator Enable(Entity entity)
  {
    yield return (object) this.SetTargets();
  }

  public override bool RunDisableEvent(Entity entity)
  {
    if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target)
    {
      foreach (CardContainer target in this.targetList)
        Events.InvokeAbilityTargetRemove(target);
    }
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (UnityEngine.Object) entity == (UnityEngine.Object) this.target;
  }

  public IEnumerator CardPlayed(Entity entity, Entity[] targets)
  {
    StatusEffectBombard statusEffectBombard = this;
    if (statusEffectBombard.CanTrigger())
    {
      statusEffectBombard.triggered = true;
      yield return (object) Sequences.WaitForAnimationEnd(statusEffectBombard.target);
      yield return (object) Sequences.Wait(statusEffectBombard.delayAfter);
    }
  }

  public override bool RunActionPerformedEvent(PlayAction action)
  {
    return this.triggered && ActionQueue.Empty;
  }

  public IEnumerator ActionPerformed(PlayAction action)
  {
    this.triggered = false;
    yield return (object) this.SetTargets();
  }

  public override bool RunEndEvent()
  {
    foreach (CardContainer target in this.targetList)
      Events.InvokeAbilityTargetRemove(target);
    return false;
  }

  public IEnumerator SetTargets()
  {
    StatusEffectBombard statusEffectBombard = this;
    foreach (CardContainer target in statusEffectBombard.targetList)
      Events.InvokeAbilityTargetRemove(target);
    if (statusEffectBombard.storedTargetList != null)
    {
      List<CardSlot> slots = References.Battle.GetSlots();
      foreach (int storedTarget in statusEffectBombard.storedTargetList)
      {
        CardSlot cardSlot = slots[storedTarget];
        statusEffectBombard.targetList.Add((CardContainer) cardSlot);
      }
      statusEffectBombard.storedTargetList = (int[]) null;
    }
    else
    {
      List<StatusEffectBombard.Slot> list = new List<StatusEffectBombard.Slot>();
      List<CardContainer> rows1 = Battle.instance.GetRows(statusEffectBombard.target.owner);
      List<CardContainer> rows2 = Battle.instance.GetRows(Battle.GetOpponent(statusEffectBombard.target.owner));
      for (int index = 0; index < Battle.instance.rowCount; ++index)
      {
        if (rows1[index] is CardSlotLane cardSlotLane1)
          list.AddRange(cardSlotLane1.slots.Select<CardSlot, StatusEffectBombard.Slot>((Func<CardSlot, int, StatusEffectBombard.Slot>) ((t, i) => new StatusEffectBombard.Slot(t, true, i == 0))));
        if (rows2[index] is CardSlotLane cardSlotLane2)
          list.AddRange(cardSlotLane2.slots.Select<CardSlot, StatusEffectBombard.Slot>((Func<CardSlot, int, StatusEffectBombard.Slot>) ((t, i) => new StatusEffectBombard.Slot(t, false, i == 0))));
      }
      list.Shuffle<StatusEffectBombard.Slot>();
      if (statusEffectBombard.maxFrontTargets <= 0)
        list.RemoveAll((Predicate<StatusEffectBombard.Slot>) (a => a.front));
      (statusEffectBombard.targetList ?? (statusEffectBombard.targetList = new List<CardContainer>())).Clear();
      int num1 = 0;
      int num2 = statusEffectBombard.targetCountRange.Random();
      while (num2 > 0 && list.Count > 0)
      {
        bool friendly = (double) UnityEngine.Random.Range(0.0f, 1f) < (double) statusEffectBombard.hitFriendlyChance;
        StatusEffectBombard.Slot slot = list.Find((Predicate<StatusEffectBombard.Slot>) (a => a.friendly == friendly)) ?? list[0];
        statusEffectBombard.targetList.Add((CardContainer) slot.slot);
        --num2;
        list.Remove(slot);
        if (slot.front && ++num1 >= statusEffectBombard.maxFrontTargets)
          list.RemoveAll((Predicate<StatusEffectBombard.Slot>) (a => a.front));
      }
    }
    if ((bool) (UnityEngine.Object) statusEffectBombard.target)
      statusEffectBombard.targetList.Sort(new Comparison<CardContainer>(statusEffectBombard.\u003CSetTargets\u003Eb__21_0));
    foreach (CardContainer target in statusEffectBombard.targetList)
    {
      Events.InvokeAbilityTargetAdd(target);
      yield return (object) Sequences.Wait(statusEffectBombard.delayBetweenTargets);
    }
  }

  [CompilerGenerated]
  public int \u003CSetTargets\u003Eb__21_0(CardContainer a, CardContainer b)
  {
    int num = Mathf.RoundToInt(Mathf.Sign(this.target.transform.position.x));
    float x1 = a.holder.position.x;
    float x2 = b.holder.position.x;
    return num != 1 ? x2.CompareTo(x1) : x1.CompareTo(x2);
  }

  public class Slot
  {
    public readonly CardSlot slot;
    public readonly bool friendly;
    public readonly bool front;

    public Slot(CardSlot slot, bool friendly, bool front)
    {
      this.slot = slot;
      this.friendly = friendly;
      this.front = front;
    }
  }

  [Serializable]
  public class SlotList
  {
    public int[] list;
  }
}
