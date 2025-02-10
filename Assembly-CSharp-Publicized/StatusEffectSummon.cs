// Decompiled with JetBrains decompiler
// Type: StatusEffectSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

[CreateAssetMenu(menuName = "Status Effects/Summon", fileName = "Summon")]
public class StatusEffectSummon : StatusEffectData
{
  public CardData summonCard;
  [SerializeField]
  public StatusEffectData gainTrait;
  [SerializeField]
  public CardType setCardType;
  [SerializeField]
  public AssetReference effectPrefabRef;
  public bool unsubRequired;
  public CardSlot[] toSummon;

  public override void Init()
  {
    if (this.target.data.playOnSlot)
    {
      global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
      this.unsubRequired = true;
    }
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CardPlayed);
  }

  public void OnDestroy()
  {
    if (!this.unsubRequired)
      return;
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
  }

  public void ActionPerform(PlayAction action)
  {
    if (!(action is ActionTriggerAgainst actionTriggerAgainst) || !((UnityEngine.Object) actionTriggerAgainst.targetContainer != (UnityEngine.Object) null) || !((UnityEngine.Object) actionTriggerAgainst.entity == (UnityEngine.Object) this.target))
      return;
    switch (actionTriggerAgainst.targetContainer)
    {
      case CardSlot cardSlot:
        this.toSummon = new CardSlot[1]{ cardSlot };
        break;
      case CardSlotLane row:
        this.toSummon = this.target.targetMode.GetTargetSlots(row);
        break;
    }
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target;

  public IEnumerator CardPlayed(Entity entity, Entity[] targets)
  {
    StatusEffectSummon statusEffectSummon = this;
    if (statusEffectSummon.toSummon == null)
    {
      HashSet<CardContainer> list = new HashSet<CardContainer>();
      list.AddRange<CardContainer>((IEnumerable<CardContainer>) entity.actualContainers);
      if (list.Count > 0 && list.ToArray<CardContainer>().RandomItem<CardContainer>() is CardSlot cardSlot)
        statusEffectSummon.toSummon = new CardSlot[1]
        {
          cardSlot
        };
    }
    if (statusEffectSummon.toSummon != null && statusEffectSummon.toSummon.Length != 0)
    {
      CardController controller = statusEffectSummon.target.display.hover.controller;
      double num = (double) statusEffectSummon.target.curveAnimator.Ping();
      CardSlot[] cardSlotArray = statusEffectSummon.toSummon;
      for (int index = 0; index < cardSlotArray.Length; ++index)
      {
        CardSlot container = cardSlotArray[index];
        yield return (object) statusEffectSummon.TrySummon((CardContainer) container, controller, statusEffectSummon.target);
      }
      cardSlotArray = (CardSlot[]) null;
      controller = (CardController) null;
    }
    statusEffectSummon.toSummon = (CardSlot[]) null;
    yield return (object) null;
  }

  public IEnumerator Summon(
    CardContainer container,
    CardController controller,
    Entity summonedBy,
    StatusEffectData[] withEffects = null,
    int withEffectsAmount = 0,
    UnityAction<Entity> onComplete = null)
  {
    StatusEffectSummon statusEffectSummon = this;
    if ((bool) (UnityEngine.Object) container)
    {
      Entity entity = (Entity) null;
      yield return (object) statusEffectSummon.CreateCard(statusEffectSummon.summonCard, container, controller, (UnityAction<Entity>) (e => entity = e));
      if (withEffectsAmount > 0 && withEffects != null)
      {
        StatusEffectData[] statusEffectDataArray = withEffects;
        for (int index = 0; index < statusEffectDataArray.Length; ++index)
          yield return (object) StatusEffectSystem.Apply(entity, (Entity) null, statusEffectDataArray[index], withEffectsAmount);
        statusEffectDataArray = (StatusEffectData[]) null;
      }
      if ((bool) (UnityEngine.Object) statusEffectSummon.gainTrait)
        ActionQueue.Stack((PlayAction) new ActionSequence(statusEffectSummon.Animate(entity, new CardData.StatusEffectStacks(statusEffectSummon.gainTrait, 1))), true);
      else
        ActionQueue.Stack((PlayAction) new ActionSequence(statusEffectSummon.Animate(entity)), true);
      ActionRunEnableEvent action1 = new ActionRunEnableEvent(entity);
      action1.fixedPosition = true;
      ActionQueue.Stack((PlayAction) action1);
      ActionMove action2 = new ActionMove(entity, new CardContainer[1]
      {
        container
      });
      action2.fixedPosition = true;
      ActionQueue.Stack((PlayAction) action2);
      global::Events.InvokeEntitySummoned(entity, summonedBy);
      UnityAction<Entity> unityAction = onComplete;
      if (unityAction != null)
        unityAction(entity);
    }
  }

  public IEnumerator SummonCopy(
    Entity toCopy,
    CardContainer container,
    CardController controller,
    Entity summonedBy,
    StatusEffectData[] withEffects = null,
    int withEffectsAmount = 0,
    UnityAction<Entity> onComplete = null)
  {
    StatusEffectSummon statusEffectSummon = this;
    Entity entity = (Entity) null;
    yield return (object) statusEffectSummon.CreateCard(toCopy.data, container, controller, (UnityAction<Entity>) (e =>
    {
      entity = e;
      e.startingEffectsApplied = true;
    }));
    ulong num;
    toCopy.data.TryGetCustomData<ulong>("splitOriginalId", out num, toCopy.data.id);
    entity.data.SetCustomData("splitOriginalId", (object) num);
    List<StatusEffectData> list = toCopy.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e =>
    {
      if (e.count <= e.temporary)
        return false;
      return e.HasDescOrIsKeyword || e.isStatus;
    })).ToList<StatusEffectData>();
    foreach (Entity.TraitStacks trait in toCopy.traits)
    {
      foreach (StatusEffectData passiveEffect in trait.passiveEffects)
        list.Remove(passiveEffect);
      int count = trait.count - trait.tempCount;
      if (count > 0)
        entity.GainTrait(trait.data, count);
    }
    foreach (StatusEffectData effectData in list)
      yield return (object) StatusEffectSystem.Apply(entity, effectData.applier, effectData, effectData.count - effectData.temporary);
    entity.attackEffects = ((IEnumerable<CardData.StatusEffectStacks>) CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) entity.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) toCopy.attackEffects)).Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToList<CardData.StatusEffectStacks>();
    entity.damage = toCopy.damage;
    entity.hp = toCopy.hp;
    entity.counter = toCopy.counter;
    entity.counter.current = entity.counter.max;
    entity.uses = toCopy.uses;
    entity.display.promptUpdateDescription = true;
    entity.PromptUpdate();
    yield return (object) entity.UpdateTraits();
    if (withEffectsAmount > 0 && withEffects != null)
    {
      StatusEffectData[] statusEffectDataArray = withEffects;
      for (int index = 0; index < statusEffectDataArray.Length; ++index)
        yield return (object) StatusEffectSystem.Apply(entity, (Entity) null, statusEffectDataArray[index], withEffectsAmount);
      statusEffectDataArray = (StatusEffectData[]) null;
    }
    if ((bool) (UnityEngine.Object) statusEffectSummon.gainTrait)
      yield return (object) statusEffectSummon.Animate(entity, new CardData.StatusEffectStacks(statusEffectSummon.gainTrait, 1));
    else
      yield return (object) statusEffectSummon.Animate(entity);
    global::Events.InvokeEntitySummoned(entity, summonedBy);
    UnityAction<Entity> unityAction = onComplete;
    if (unityAction != null)
      unityAction(entity);
    yield return (object) new ActionRunEnableEvent(entity).Run();
    yield return (object) new ActionMove(entity, new CardContainer[1]
    {
      container
    }).Run();
  }

  public IEnumerator Animate(Entity entity, params CardData.StatusEffectStacks[] withEffects)
  {
    AsyncOperationHandle<GameObject> handle = this.effectPrefabRef.InstantiateAsync(entity.transform);
    yield return (object) handle;
    CreateCardAnimation component = handle.Result.GetComponent<CreateCardAnimation>();
    if (component != null)
      yield return (object) component.Run(entity, withEffects);
  }

  public IEnumerator CreateCard(
    CardData cardData,
    CardContainer container,
    CardController controller,
    UnityAction<Entity> onComplete = null)
  {
    CardData data = cardData.Clone(false);
    if ((bool) (UnityEngine.Object) this.setCardType)
      data.cardType = this.setCardType;
    data.upgrades.RemoveAll((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown));
    Card card = CardManager.Get(data, controller, container.owner, true, container.owner.team == References.Player.team);
    card.entity.flipper.FlipUpInstant();
    card.canvasGroup.alpha = 0.0f;
    container.Add(card.entity);
    Transform transform = card.transform;
    transform.localPosition = card.entity.GetContainerLocalPosition();
    transform.localEulerAngles = card.entity.GetContainerLocalRotation();
    transform.localScale = card.entity.GetContainerScale();
    container.Remove(card.entity);
    card.entity.owner.reserveContainer.Add(card.entity);
    UnityAction<Entity> unityAction = onComplete;
    if (unityAction != null)
      unityAction(card.entity);
    yield return (object) card.UpdateData(false);
  }

  public static IEnumerator UpdateData(Entity entity, Entity toCopy = null)
  {
    yield return (object) entity.display.UpdateData();
    if ((UnityEngine.Object) toCopy != (UnityEngine.Object) null)
    {
      entity.hp = toCopy.hp;
      entity.damage = toCopy.damage;
      entity.counter.current = entity.counter.max;
      entity.PromptUpdate();
    }
  }

  public IEnumerator TrySummon(
    CardContainer container,
    CardController controller,
    Entity summonedBy)
  {
    StatusEffectSummon statusEffectSummon = this;
    if (container.Count < container.max)
    {
      yield return (object) statusEffectSummon.Summon(container, controller, summonedBy);
    }
    else
    {
      Dictionary<Entity, List<CardSlot>> shoveData;
      if (ShoveSystem.CanShove(container.GetTop(), statusEffectSummon.target, out shoveData))
      {
        yield return (object) ShoveSystem.DoShove(shoveData, true);
        yield return (object) statusEffectSummon.Summon(container, controller, summonedBy);
      }
      else if (NoTargetTextSystem.Exists())
        yield return (object) NoTargetTextSystem.Run(statusEffectSummon.target, NoTargetType.NoSpaceToSummon);
    }
  }
}
