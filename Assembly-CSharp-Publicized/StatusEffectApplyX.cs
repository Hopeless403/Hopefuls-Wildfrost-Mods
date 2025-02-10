// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class StatusEffectApplyX : StatusEffectData
{
  [Header("Status Effect To Apply")]
  public bool dealDamage;
  [HideIf("dealDamage")]
  public StatusEffectData effectToApply;
  public TargetConstraint[] applyConstraints;
  public bool applyEqualAmount;
  [ShowIf("applyEqualAmount")]
  [SerializeField]
  public ScriptableAmount contextEqualAmount;
  [ShowIf("applyEqualAmount")]
  [SerializeField]
  public float equalAmountBonusMult;
  [HideIf("applyEqualAmount")]
  [SerializeField]
  public ScriptableAmount scriptableAmount;
  [Header("Who/What To Apply To")]
  public StatusEffectApplyX.ApplyToFlags applyToFlags;
  public bool applyInReverseOrder;
  public bool canRetaliate;
  public bool countsAsHit;
  public bool waitForAnimationEnd;
  public bool waitForApplyToAnimationEnd;
  public bool queue;
  public bool separateActions;
  public bool doPing = true;
  public bool targetMustBeAlive = true;
  public float pauseAfter;
  [SerializeField]
  public NoTargetType noTargetType;
  [SerializeField]
  public string[] noTargetTypeArgs;
  public ActionEffectApply action;

  public override bool CanTrigger() => base.CanTrigger() && this.dealDamage || (bool) (UnityEngine.Object) this.effectToApply;

  public virtual int GetAmount(Entity entity, bool equalAmount = false, int equalTo = 0)
  {
    if (!(bool) (UnityEngine.Object) this.target || this.TargetSilenced())
      return 0;
    if ((bool) (UnityEngine.Object) this.scriptableAmount)
      return this.scriptableAmount.Get(entity);
    return !equalAmount ? this.GetAmount() : equalTo;
  }

  public virtual bool TargetSilenced() => this.target.silenced;

  public bool AppliesTo(StatusEffectApplyX.ApplyToFlags applyTo) => (this.applyToFlags & applyTo) != 0;

  public IEnumerator Run(List<Entity> targets, int amount = 0)
  {
    StatusEffectApplyX effect = this;
    if ((bool) (UnityEngine.Object) effect.target && effect.CanTrigger())
    {
      for (int index = targets.Count - 1; index >= 0; --index)
      {
        Entity target = targets[index];
        if (!effect.CanAffect(target))
          targets.RemoveAt(index);
      }
      foreach (TargetConstraint applyConstraint in effect.applyConstraints)
      {
        for (int index = targets.Count - 1; index >= 0; --index)
        {
          Entity target = targets[index];
          if (!applyConstraint.Check(target))
            targets.RemoveAt(index);
        }
      }
      if (targets.Count > 0)
      {
        int amount1 = effect.GetAmount(effect.target, effect.applyEqualAmount, Mathf.RoundToInt((float) amount * (1f + effect.equalAmountBonusMult)));
        if (!effect.TargetSilenced() && (amount1 > 0 || effect.CheckMultipleEffectsForUnboostable()))
        {
          if (effect.queue && effect.target.IsAliveAndExists())
          {
            bool flag = false;
            if (effect.effectToApply.CanStackActions)
            {
              ActionEffectApply action = effect.action;
              if (action != null && !action.running)
              {
                effect.action.Stack(targets, amount1);
                flag = true;
              }
            }
            if (!flag)
            {
              StatusEffectApplyX statusEffectApplyX = effect;
              ActionEffectApply actionEffectApply = new ActionEffectApply(effect, targets, amount1);
              actionEffectApply.note = effect.name;
              statusEffectApplyX.action = actionEffectApply;
              ActionQueue.Stack((PlayAction) effect.action, true);
            }
          }
          else
            yield return (object) effect.Sequence(targets, amount1);
        }
      }
      else if (effect.noTargetType != NoTargetType.None && NoTargetTextSystem.Exists())
        yield return (object) NoTargetTextSystem.Run(effect.target, effect.noTargetType, (object[]) effect.noTargetTypeArgs);
    }
  }

  public bool CheckMultipleEffectsForUnboostable()
  {
    if (this.effectToApply is StatusEffectInstantMultiple effectToApply)
    {
      foreach (StatusEffectData effect in effectToApply.effects)
      {
        if (!effect.canBeBoosted)
          return true;
      }
    }
    return false;
  }

  public IEnumerator Sequence(List<Entity> targets, int amount)
  {
    StatusEffectApplyX statusEffectApplyX = this;
    if ((bool) (UnityEngine.Object) statusEffectApplyX.target && (statusEffectApplyX.target.alive || !statusEffectApplyX.targetMustBeAlive))
    {
      if (statusEffectApplyX.waitForAnimationEnd)
        yield return (object) Sequences.WaitForAnimationEnd(statusEffectApplyX.target);
      if (statusEffectApplyX.waitForApplyToAnimationEnd)
      {
        foreach (Entity target in targets)
          yield return (object) Sequences.WaitForAnimationEnd(target);
      }
      if (statusEffectApplyX.separateActions)
      {
        if (statusEffectApplyX.queue)
        {
          foreach (Entity t in targets.AsEnumerable<Entity>().Reverse<Entity>())
          {
            ActionSequence action = new ActionSequence(statusEffectApplyX.SequenceSingle(t, amount));
            action.note = statusEffectApplyX.name + " - " + t.name;
            ActionQueue.Stack((PlayAction) action);
          }
        }
        else
        {
          foreach (Entity t in targets.AsEnumerable<Entity>())
            yield return (object) statusEffectApplyX.SequenceSingle(t, amount);
        }
      }
      else
      {
        Routine.Clump clump = new Routine.Clump();
        if (statusEffectApplyX.doPing && (bool) (UnityEngine.Object) statusEffectApplyX.target && (bool) (UnityEngine.Object) statusEffectApplyX.target.curveAnimator)
        {
          double num = (double) statusEffectApplyX.target.curveAnimator.Ping();
          clump.Add(Sequences.Wait(0.13f));
        }
        foreach (Entity target in targets.Where<Entity>((Func<Entity, bool>) (t => (bool) (UnityEngine.Object) t)))
        {
          int damage = statusEffectApplyX.dealDamage ? amount : 0;
          Hit hit = new Hit(statusEffectApplyX.target, target, damage)
          {
            canRetaliate = statusEffectApplyX.canRetaliate,
            countsAsHit = statusEffectApplyX.countsAsHit
          };
          if (!statusEffectApplyX.dealDamage)
            hit.AddStatusEffect(statusEffectApplyX.effectToApply, amount);
          clump.Add(hit.Process());
        }
        yield return (object) clump.WaitForEnd();
      }
      if ((double) statusEffectApplyX.pauseAfter > 0.0)
        yield return (object) Sequences.Wait(statusEffectApplyX.pauseAfter);
    }
  }

  public IEnumerator SequenceSingle(Entity t, int amount)
  {
    StatusEffectApplyX statusEffectApplyX = this;
    if ((bool) (UnityEngine.Object) t && statusEffectApplyX.CheckConstraints(t))
    {
      Routine.Clump clump = new Routine.Clump();
      if (statusEffectApplyX.doPing && (bool) (UnityEngine.Object) statusEffectApplyX.target && (bool) (UnityEngine.Object) statusEffectApplyX.target.curveAnimator)
      {
        double num = (double) statusEffectApplyX.target.curveAnimator.Ping();
        clump.Add(Sequences.Wait(0.13f));
      }
      Hit hit = new Hit(statusEffectApplyX.target, t, 0)
      {
        canRetaliate = statusEffectApplyX.canRetaliate,
        countsAsHit = statusEffectApplyX.countsAsHit
      };
      hit.AddStatusEffect(statusEffectApplyX.effectToApply, amount);
      clump.Add(hit.Process());
      yield return (object) clump.WaitForEnd();
      if (statusEffectApplyX.waitForAnimationEnd)
        yield return (object) Sequences.WaitForAnimationEnd(statusEffectApplyX.target);
    }
  }

  public List<Entity> GetTargets(
    Hit hit = null,
    CardContainer[] wasInRows = null,
    CardContainer[] wasInSlots = null,
    Entity[] targets = null)
  {
    List<Entity> targets1 = new List<Entity>();
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Self) && this.CanAffect(this.target))
      targets1.Add(this.target);
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Hand))
    {
      CardContainer handContainer = References.Player.handContainer;
      if (handContainer != null && handContainer.Count > 0)
      {
        targets1.AddRange(References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (card => (UnityEngine.Object) card != (UnityEngine.Object) this.target && this.CheckConstraints(card))));
        goto label_18;
      }
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RightCardInHand))
    {
      CardContainer handContainer = References.Player.handContainer;
      if (handContainer != null && handContainer.Count > 0)
        targets1.Add(References.Player.handContainer[0]);
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RandomCardInHand))
    {
      CardContainer handContainer = References.Player.handContainer;
      if (handContainer != null && handContainer.Count > 0)
      {
        foreach (Entity entity in (IEnumerable<Entity>) References.Player.handContainer.InRandomOrder<Entity>())
        {
          if ((UnityEngine.Object) entity != (UnityEngine.Object) this.target && this.CheckConstraints(entity))
          {
            targets1.Add(entity);
            break;
          }
        }
      }
    }
label_18:
    this.AppliesTo(StatusEffectApplyX.ApplyToFlags.EnemyHand);
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Allies))
      targets1.AddRange((IEnumerable<Entity>) this.target.GetAllAllies());
    else if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.AlliesInRow))
    {
      if (Battle.IsOnBoard(this.target))
        targets1.AddRange((IEnumerable<Entity>) this.target.GetAlliesInRow());
      else if (wasInRows != null)
      {
        foreach (CardContainer wasInRow in wasInRows)
        {
          foreach (Entity entity in this.target.GetAlliesInRow(References.Battle.GetRowIndex(wasInRow)))
          {
            if (!targets1.Contains(entity))
              targets1.Add(entity);
          }
        }
      }
    }
    else
    {
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.FrontAlly))
      {
        List<int> source = new List<int>();
        if (wasInRows != null)
        {
          source.AddRange((IEnumerable<int>) References.Battle.GetRowIndices((IEnumerable<CardContainer>) wasInRows));
        }
        else
        {
          Entity entity = hit != null ? hit.target : this.target;
          List<int> intList = source;
          CardContainer[] containers = entity.containers;
          int[] collection = containers == null || containers.Length <= 0 ? References.Battle.GetRowIndices((IEnumerable<CardContainer>) entity.preContainers) : References.Battle.GetRowIndices((IEnumerable<CardContainer>) entity.containers);
          intList.AddRange((IEnumerable<int>) collection);
        }
        foreach (CardContainer cardContainer in source.Select<int, CardContainer>((Func<int, CardContainer>) (i => References.Battle.GetRow(this.target.owner, i))))
        {
          foreach (Entity entity in cardContainer)
          {
            if ((bool) (UnityEngine.Object) entity)
            {
              targets1.Add(entity);
              break;
            }
          }
        }
      }
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.BackAlly))
      {
        List<int> source = new List<int>();
        if (wasInRows != null)
          source.AddRange((IEnumerable<int>) References.Battle.GetRowIndices((IEnumerable<CardContainer>) wasInRows));
        else if (hit != null)
          source.AddRange((IEnumerable<int>) References.Battle.GetRowIndices(hit.target));
        else
          source.AddRange((IEnumerable<int>) References.Battle.GetRowIndices((IEnumerable<CardContainer>) this.target.containers));
        foreach (CardContainer cardContainer in source.Select<int, CardContainer>((Func<int, CardContainer>) (i => References.Battle.GetRow(this.target.owner, i))))
        {
          for (int index = cardContainer.Count - 1; index >= 0; --index)
          {
            Entity entity = cardContainer[index];
            if ((bool) (UnityEngine.Object) entity)
            {
              targets1.Add(entity);
              break;
            }
          }
        }
      }
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.AllyInFrontOf))
      {
        foreach (CardContainer cardContainer in wasInSlots ?? this.target.actualContainers.ToArray())
        {
          Entity entity = (Entity) null;
          if (cardContainer is CardSlot cardSlot && cardContainer.Group is CardSlotLane group)
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
            targets1.Add(entity);
            break;
          }
        }
      }
      if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.AllyBehind))
      {
        foreach (CardContainer cardContainer in wasInSlots ?? this.target.actualContainers.ToArray())
        {
          Entity entity = (Entity) null;
          if (cardContainer is CardSlot cardSlot && cardContainer.Group is CardSlotLane group)
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
            targets1.Add(entity);
            break;
          }
        }
      }
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Enemies))
      targets1.AddRange((IEnumerable<Entity>) this.target.GetAllEnemies());
    else if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.EnemiesInRow))
    {
      foreach (CardContainer rowContainer in wasInRows ?? this.target.containers)
      {
        List<Entity> enemiesInRow = this.target.GetEnemiesInRow(References.Battle.GetRowIndex(rowContainer));
        if (enemiesInRow != null && enemiesInRow.Count > 0)
          targets1.AddRange((IEnumerable<Entity>) enemiesInRow);
      }
    }
    else if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.FrontEnemy))
    {
      foreach (CardContainer rowContainer in wasInRows ?? this.target.containers)
      {
        List<Entity> enemiesInRow = this.target.GetEnemiesInRow(References.Battle.GetRowIndex(rowContainer));
        if (enemiesInRow != null && enemiesInRow.Count > 0)
          targets1.Add(enemiesInRow[0]);
      }
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Applier) && (bool) (UnityEngine.Object) this.applier && this.CanAffect(this.applier))
      targets1.Add(this.applier);
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Attacker))
    {
      if (hit == null)
        hit = this.target.lastHit;
      if ((bool) (UnityEngine.Object) hit?.attacker && this.CanAffect(hit.attacker))
        targets1.Add(hit.attacker);
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.Target))
    {
      if (targets != null)
      {
        targets1.AddRange(((IEnumerable<Entity>) targets).Where<Entity>(new Func<Entity, bool>(this.CanAffect)));
      }
      else
      {
        if (hit == null)
          hit = this.target.lastHit;
        if ((bool) (UnityEngine.Object) hit?.target && this.CanAffect(hit.target))
          targets1.Add(hit.target);
      }
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RandomUnit))
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(this.target.owner);
      cardsOnBoard.AddRange((IEnumerable<Entity>) Battle.GetCardsOnBoard(Battle.GetOpponent(this.target.owner)));
      cardsOnBoard.Remove(this.target);
      this.RemoveIneligible((IList<Entity>) cardsOnBoard);
      if (cardsOnBoard.Count > 0)
        targets1.Add(cardsOnBoard.RandomItem<Entity>());
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RandomAlly))
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(this.target.owner);
      cardsOnBoard.Remove(this.target);
      this.RemoveIneligible((IList<Entity>) cardsOnBoard);
      if (cardsOnBoard.Count > 0)
        targets1.Add(cardsOnBoard.RandomItem<Entity>());
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RandomEnemy))
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(Battle.GetOpponent(this.target.owner));
      this.RemoveIneligible((IList<Entity>) cardsOnBoard);
      if (cardsOnBoard.Count > 0)
        targets1.Add(cardsOnBoard.RandomItem<Entity>());
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RandomAllyInRow))
    {
      List<Entity> list = new List<Entity>();
      foreach (CardContainer cardContainer in wasInRows ?? this.target.containers)
      {
        foreach (Entity entity in cardContainer)
        {
          if (!list.Contains(entity))
            list.Add(entity);
        }
      }
      this.RemoveIneligible((IList<Entity>) list);
      if (list.Count > 0)
        targets1.Add(list.RandomItem<Entity>());
    }
    if (this.AppliesTo(StatusEffectApplyX.ApplyToFlags.RandomEnemyInRow))
    {
      List<Entity> list = new List<Entity>();
      foreach (CardContainer rowContainer in wasInRows ?? this.target.containers)
      {
        foreach (Entity entity in this.target.GetEnemiesInRow(References.Battle.GetRowIndex(rowContainer)))
        {
          if (!list.Contains(entity))
            list.Add(entity);
        }
      }
      this.RemoveIneligible((IList<Entity>) list);
      if (list.Count > 0)
        targets1.Add(list.RandomItem<Entity>());
    }
    if (this.applyInReverseOrder)
      targets1.Reverse();
    return targets1;
  }

  public void RemoveIneligible(IList<Entity> list)
  {
    for (int index = list.Count - 1; index >= 0; --index)
    {
      if (!this.CheckConstraints(list[index]))
        list.RemoveAt(index);
    }
  }

  public bool CanAffect(Entity entity) => !this.dealDamage ? this.effectToApply.CanPlayOn(entity) : entity.canBeHit;

  public bool CheckConstraints(Entity entity) => this.CanAffect(entity) && ((IEnumerable<TargetConstraint>) this.applyConstraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(entity)));

  [CompilerGenerated]
  public bool \u003CGetTargets\u003Eb__30_0(Entity card) => (UnityEngine.Object) card != (UnityEngine.Object) this.target && this.CheckConstraints(card);

  [CompilerGenerated]
  public CardContainer \u003CGetTargets\u003Eb__30_1(int i) => References.Battle.GetRow(this.target.owner, i);

  [CompilerGenerated]
  public CardContainer \u003CGetTargets\u003Eb__30_2(int i) => References.Battle.GetRow(this.target.owner, i);

  [Flags]
  public enum ApplyToFlags
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
    Applier = 131072, // 0x00020000
    RightCardInHand = 262144, // 0x00040000
    RandomCardInHand = 524288, // 0x00080000
    RandomAllyInRow = 1048576, // 0x00100000
    RandomEnemyInRow = 2097152, // 0x00200000
  }
}
