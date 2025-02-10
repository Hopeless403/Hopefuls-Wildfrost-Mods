// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileActiveX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Specific/While Active X", fileName = "While Active X")]
public class StatusEffectWhileActiveX : StatusEffectApplyX
{
  [SerializeField]
  public bool ifCloneAffectOriginal = true;
  [SerializeField]
  public bool affectOthersWithSameEffect = true;
  public bool active;
  public int currentAmount;
  public readonly List<Entity> affected = new List<Entity>();
  public bool pingDone;
  public readonly List<CardContainer> containersToAffect = new List<CardContainer>();
  public bool affectsSelf;
  public bool targetIsClone;
  public ulong cloneOriginalId;

  public bool AffectsRow() => this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.AlliesInRow) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.EnemiesInRow) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.FrontAlly) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.BackAlly) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.FrontEnemy);

  public bool AffectsSlot() => this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.AllyInFrontOf) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.AllyBehind) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.FrontAlly) || this.applyToFlags.HasFlag((Enum) StatusEffectApplyX.ApplyToFlags.BackAlly);

  public override void Init()
  {
    this.OnBegin += new StatusEffectData.EffectEventHandler(this.Begin);
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Enable);
    this.OnDisable += new StatusEffectData.EffectEntityEventHandler(this.Disable);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CardMove);
    this.OnEffectBonusChanged += new StatusEffectData.EffectEventHandler(this.EffectBonusChanged);
    global::Events.OnEntityDataUpdated += new UnityAction<Entity>(this.EntityDataUpdated);
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
    this.pingDone = !this.doPing;
    this.targetIsClone = this.target.data.TryGetCustomData<ulong>("splitOriginalId", out this.cloneOriginalId, 0UL);
  }

  public virtual void OnDestroy()
  {
    global::Events.OnEntityDataUpdated -= new UnityAction<Entity>(this.EntityDataUpdated);
    global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    int index = this.affected.IndexOf(entity);
    if (index >= 0)
      this.affected.RemoveAt(index);
    return false;
  }

  public void EntityDataUpdated(Entity entity)
  {
    if (!this.active || !this.affected.Contains(entity))
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.ReAffect(entity)));
  }

  public void EntityDisplayUpdated(Entity entity)
  {
    if (!this.active || !((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || this.GetAmount(this.target) == this.currentAmount)
      return;
    ActionQueue.Add((PlayAction) new ActionRefreshWhileActiveEffect(this));
  }

  public virtual bool CanActivate() => Battle.IsOnBoard(this.target);

  public virtual bool CheckActivateOnMove(
    CardContainer[] fromContainers,
    CardContainer[] toContainers)
  {
    return Battle.IsOnBoard(toContainers) && !Battle.IsOnBoard(fromContainers);
  }

  public virtual bool CheckDeactivateOnMove(
    CardContainer[] fromContainers,
    CardContainer[] toContainers)
  {
    return !Battle.IsOnBoard(toContainers) && Battle.IsOnBoard(fromContainers);
  }

  public static bool CompareContainerArrays(
    IReadOnlyList<CardContainer> a,
    IReadOnlyList<CardContainer> b)
  {
    if (a.Count != b.Count)
      return false;
    for (int index = 0; index < a.Count; ++index)
    {
      if ((UnityEngine.Object) a[index] != (UnityEngine.Object) b[index])
        return false;
    }
    return true;
  }

  public override bool RunBeginEvent() => this.target.enabled && this.CanActivate();

  public IEnumerator Begin() => this.Activate();

  public override bool RunEnableEvent(Entity entity) => !this.active && (UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.CanActivate();

  public IEnumerator Enable(Entity entity) => this.Activate();

  public override bool RunDisableEvent(Entity entity) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target;

  public virtual IEnumerator Disable(Entity entity) => this.Deactivate();

  public override bool RunCardMoveEvent(Entity entity)
  {
    if (!this.target.enabled)
      return false;
    return (UnityEngine.Object) this.target == (UnityEngine.Object) entity || this.active;
  }

  public virtual IEnumerator CardMove(Entity entity)
  {
    StatusEffectWhileActiveX effectWhileActiveX = this;
    if ((UnityEngine.Object) effectWhileActiveX.target == (UnityEngine.Object) entity)
    {
      CardContainer[] preContainers = entity.preContainers;
      if (effectWhileActiveX.active)
      {
        if (effectWhileActiveX.CheckDeactivateOnMove(preContainers, entity.containers))
          yield return (object) effectWhileActiveX.Deactivate();
        else if (effectWhileActiveX.AffectsRow())
        {
          if (!StatusEffectWhileActiveX.CompareContainerArrays((IReadOnlyList<CardContainer>) preContainers, (IReadOnlyList<CardContainer>) entity.containers))
          {
            yield return (object) effectWhileActiveX.Deactivate();
            yield return (object) effectWhileActiveX.Activate();
          }
        }
        else if (effectWhileActiveX.AffectsSlot())
        {
          yield return (object) effectWhileActiveX.Deactivate();
          yield return (object) effectWhileActiveX.Activate();
        }
      }
      else if (effectWhileActiveX.CheckActivateOnMove(preContainers, entity.containers))
        yield return (object) effectWhileActiveX.Activate();
    }
    else if (effectWhileActiveX.active)
    {
      if (effectWhileActiveX.AffectsSlot())
      {
        CardContainer[] array = effectWhileActiveX.containersToAffect.Select<CardContainer, CardContainer>((Func<CardContainer, CardContainer>) (a => a.Group)).ToArray<CardContainer>();
        if (((IList<CardContainer>) entity.containers).ContainsAny<CardContainer>((IEnumerable<CardContainer>) array) || ((IList<CardContainer>) entity.preContainers).ContainsAny<CardContainer>((IEnumerable<CardContainer>) array))
        {
          yield return (object) effectWhileActiveX.Deactivate();
          yield return (object) effectWhileActiveX.Activate();
        }
      }
      else if (effectWhileActiveX.affected.Contains(entity))
      {
        if (!effectWhileActiveX.containersToAffect.ContainsAny<CardContainer>((IEnumerable<CardContainer>) entity.containers))
          yield return (object) effectWhileActiveX.UnAffect(entity);
      }
      else if (effectWhileActiveX.containersToAffect.ContainsAny<CardContainer>((IEnumerable<CardContainer>) entity.containers))
        yield return (object) effectWhileActiveX.Affect(entity);
    }
  }

  public override bool RunEffectBonusChangedEvent() => this.target.enabled && this.active;

  public IEnumerator EffectBonusChanged()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectWhileActiveX effect = this;
    if (num != 0)
      return false;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    ActionQueue.Add((PlayAction) new ActionRefreshWhileActiveEffect(effect));
    return false;
  }

  public IEnumerator Activate()
  {
    StatusEffectWhileActiveX effectWhileActiveX = this;
    effectWhileActiveX.active = true;
    if (!effectWhileActiveX.pingDone)
    {
      CurveAnimator curveAnimator = effectWhileActiveX.target.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Ping();
      }
      effectWhileActiveX.pingDone = true;
    }
    effectWhileActiveX.currentAmount = effectWhileActiveX.GetAmount(effectWhileActiveX.target);
    effectWhileActiveX.FindContainers();
    List<Entity> entityList = new List<Entity>();
    if (effectWhileActiveX.affectsSelf)
      entityList.Add(effectWhileActiveX.target);
    foreach (CardContainer cardContainer in effectWhileActiveX.containersToAffect)
    {
      foreach (Entity entity in cardContainer)
      {
        if (!entityList.Contains(entity) && (UnityEngine.Object) entity != (UnityEngine.Object) effectWhileActiveX.target)
          entityList.Add(entity);
      }
    }
    Routine.Clump clump = new Routine.Clump();
    foreach (Entity entity in entityList)
      clump.Add(effectWhileActiveX.Affect(entity));
    yield return (object) clump.WaitForEnd();
  }

  public IEnumerator Deactivate()
  {
    this.active = false;
    Routine.Clump clump = new Routine.Clump();
    foreach (Entity entity in this.affected)
      clump.Add(this.UnAffect(entity));
    yield return (object) clump.WaitForEnd();
    this.affected.Clear();
  }

  public void FindContainers()
  {
    this.containersToAffect.Clear();
    Character opponent = Battle.GetOpponent(this.target.owner);
    int[] rowIndices = Battle.instance.GetRowIndices(this.target);
    this.affectsSelf = this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Self);
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Allies))
      this.containersToAffect.AddRange((IEnumerable<CardContainer>) Battle.instance.GetRows(this.target.owner));
    else if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.AlliesInRow))
    {
      foreach (int rowIndex in rowIndices)
        this.containersToAffect.Add(Battle.instance.GetRow(this.target.owner, rowIndex));
    }
    else
    {
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.FrontAlly))
      {
        foreach (int rowIndex in rowIndices)
        {
          if (Battle.instance.GetRow(this.target.owner, rowIndex) is CardSlotLane row)
            this.containersToAffect.AddIfNotNull<CardContainer>((CardContainer) row.slots.FirstOrDefault<CardSlot>((Func<CardSlot, bool>) (a => !a.Empty)));
        }
      }
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.BackAlly))
      {
        foreach (int rowIndex in rowIndices)
        {
          if (Battle.instance.GetRow(this.target.owner, rowIndex) is CardSlotLane row)
            this.containersToAffect.AddIfNotNull<CardContainer>((CardContainer) row.slots.LastOrDefault<CardSlot>((Func<CardSlot, bool>) (a => !a.Empty)));
        }
      }
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.AllyInFrontOf))
      {
        foreach (int rowIndex in rowIndices)
        {
          if (Battle.instance.GetRow(this.target.owner, rowIndex) is CardSlotLane row)
          {
            for (int index = row.IndexOf(this.target) - 1; index >= 0; --index)
            {
              CardSlot slot = row.slots[index];
              if (!slot.Empty)
              {
                this.containersToAffect.Add((CardContainer) slot);
                break;
              }
            }
          }
        }
      }
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.AllyBehind))
      {
        foreach (int rowIndex in rowIndices)
        {
          if (Battle.instance.GetRow(this.target.owner, rowIndex) is CardSlotLane row)
          {
            for (int index = row.IndexOf(this.target) + 1; index < row.slots.Count; ++index)
            {
              CardSlot slot = row.slots[index];
              if (!slot.Empty)
              {
                this.containersToAffect.Add((CardContainer) slot);
                break;
              }
            }
          }
        }
      }
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Enemies))
      this.containersToAffect.AddRange((IEnumerable<CardContainer>) Battle.instance.GetRows(opponent));
    else if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.EnemiesInRow))
    {
      foreach (int rowIndex in rowIndices)
        this.containersToAffect.Add(Battle.instance.GetRow(opponent, rowIndex));
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Hand) && (bool) (UnityEngine.Object) References.Player)
      this.containersToAffect.AddIfNotNull<CardContainer>(References.Player.handContainer);
    if (!this.AppliesTo(StatusEffectApplyX.ApplyToFlags.EnemyHand) || !(bool) (UnityEngine.Object) opponent)
      return;
    this.containersToAffect.AddIfNotNull<CardContainer>(opponent.handContainer);
  }

  public IEnumerator Affect(Entity entity)
  {
    StatusEffectWhileActiveX effectWhileActiveX = this;
    if (!effectWhileActiveX.affected.Contains(entity) && effectWhileActiveX.effectToApply.CanPlayOn(entity))
    {
      bool flag = false;
      if (effectWhileActiveX.targetIsClone && !effectWhileActiveX.ifCloneAffectOriginal)
      {
        ulong num;
        if (entity.data.TryGetCustomData<ulong>("splitOriginalId", out num, 0UL) && (long) effectWhileActiveX.cloneOriginalId == (long) num)
          flag = true;
        else if ((long) entity.data.id == (long) effectWhileActiveX.cloneOriginalId)
          flag = true;
      }
      if (!flag && !effectWhileActiveX.affectOthersWithSameEffect)
      {
        foreach (UnityEngine.Object statusEffect in entity.statusEffects)
        {
          if (statusEffect.name == effectWhileActiveX.name)
          {
            flag = true;
            break;
          }
        }
      }
      if (!flag && ((IEnumerable<TargetConstraint>) effectWhileActiveX.applyConstraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(entity))))
      {
        effectWhileActiveX.affected.Add(entity);
        if (effectWhileActiveX.currentAmount > 0)
        {
          yield return (object) StatusEffectSystem.Apply(entity, effectWhileActiveX.target, effectWhileActiveX.effectToApply, effectWhileActiveX.currentAmount, true);
          entity.PromptUpdate();
        }
      }
    }
  }

  public IEnumerator UnAffect(Entity entity)
  {
    StatusEffectWhileActiveX effectWhileActiveX = this;
    if (effectWhileActiveX.affected.Contains(entity))
    {
      for (int index = entity.statusEffects.Count - 1; index >= 0; --index)
      {
        StatusEffectData statusEffect = entity.statusEffects[index];
        if ((bool) (UnityEngine.Object) statusEffect && statusEffect.name == effectWhileActiveX.effectToApply.name)
        {
          yield return (object) statusEffect.RemoveStacks(effectWhileActiveX.currentAmount, true);
          break;
        }
      }
      effectWhileActiveX.affected.Remove(entity);
    }
  }

  public IEnumerator ReAffect(Entity entity)
  {
    if (this.affected.Contains(entity))
    {
      yield return (object) this.UnAffect(entity);
      yield return (object) this.Affect(entity);
    }
  }
}
