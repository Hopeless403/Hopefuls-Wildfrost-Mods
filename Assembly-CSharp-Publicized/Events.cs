// Decompiled with JetBrains decompiler
// Type: Events
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public static class Events
{
  public static event UnityAction<Scene> OnSceneLoaded;

  public static void InvokeSceneLoaded(Scene scene)
  {
    UnityAction<Scene> onSceneLoaded = global::Events.OnSceneLoaded;
    if (onSceneLoaded == null)
      return;
    onSceneLoaded(scene);
  }

  public static event UnityAction<Scene> OnSceneChanged;

  public static void InvokeSceneChanged(Scene scene)
  {
    UnityAction<Scene> onSceneChanged = global::Events.OnSceneChanged;
    if (onSceneChanged == null)
      return;
    onSceneChanged(scene);
  }

  public static event UnityAction<Scene> OnSceneUnload;

  public static void InvokeSceneUnload(Scene scene)
  {
    UnityAction<Scene> onSceneUnload = global::Events.OnSceneUnload;
    if (onSceneUnload == null)
      return;
    onSceneUnload(scene);
  }

  public static event UnityAction OnBackToMainMenu;

  public static void InvokeBackToMainMenu()
  {
    UnityAction onBackToMainMenu = global::Events.OnBackToMainMenu;
    if (onBackToMainMenu == null)
      return;
    onBackToMainMenu();
  }

  public static event UnityAction<Entity> OnEntityCreated;

  public static void InvokeEntityCreated(Entity entity)
  {
    UnityAction<Entity> onEntityCreated = global::Events.OnEntityCreated;
    if (onEntityCreated == null)
      return;
    onEntityCreated(entity);
  }

  public static event UnityAction<Entity> OnEntityDataUpdated;

  public static void InvokeEntityDataUpdated(Entity entity)
  {
    UnityAction<Entity> entityDataUpdated = global::Events.OnEntityDataUpdated;
    if (entityDataUpdated == null)
      return;
    entityDataUpdated(entity);
  }

  public static event UnityAction<Entity> OnEntityDestroyed;

  public static void InvokeEntityDestroyed(Entity entity)
  {
    UnityAction<Entity> onEntityDestroyed = global::Events.OnEntityDestroyed;
    if (onEntityDestroyed == null)
      return;
    onEntityDestroyed(entity);
  }

  public static event UnityAction<Card> OnCardPooled;

  public static void InvokeCardPooled(Card card)
  {
    UnityAction<Card> onCardPooled = global::Events.OnCardPooled;
    if (onCardPooled == null)
      return;
    onCardPooled(card);
  }

  public static event UnityAction<Entity> OnEntityEnabled;

  public static void InvokeEntityEnabled(Entity entity)
  {
    UnityAction<Entity> onEntityEnabled = global::Events.OnEntityEnabled;
    if (onEntityEnabled == null)
      return;
    onEntityEnabled(entity);
  }

  public static event UnityAction<Entity> OnEntityDisabled;

  public static void InvokeEntityDisabled(Entity entity)
  {
    UnityAction<Entity> onEntityDisabled = global::Events.OnEntityDisabled;
    if (onEntityDisabled == null)
      return;
    onEntityDisabled(entity);
  }

  public static event UnityAction<Entity, DeathType> OnEntityKilled;

  public static void InvokeEntityKilled(Entity entity, DeathType deathType)
  {
    UnityAction<Entity, DeathType> onEntityKilled = global::Events.OnEntityKilled;
    if (onEntityKilled == null)
      return;
    onEntityKilled(entity, deathType);
  }

  public static event UnityAction<Entity> OnEntityFlee;

  public static void InvokeEntityFlee(Entity entity)
  {
    UnityAction<Entity> onEntityFlee = global::Events.OnEntityFlee;
    if (onEntityFlee == null)
      return;
    onEntityFlee(entity);
  }

  public static event UnityAction<Entity> OnEntityHover;

  public static void InvokeEntityHover(Entity entity)
  {
    UnityAction<Entity> onEntityHover = global::Events.OnEntityHover;
    if (onEntityHover == null)
      return;
    onEntityHover(entity);
  }

  public static event UnityAction<Entity> OnEntityUnHover;

  public static void InvokeEntityUnHover(Entity entity)
  {
    UnityAction<Entity> onEntityUnHover = global::Events.OnEntityUnHover;
    if (onEntityUnHover == null)
      return;
    onEntityUnHover(entity);
  }

  public static event UnityAction<Entity> OnEntitySelect;

  public static void InvokeEntitySelect(Entity entity)
  {
    UnityAction<Entity> onEntitySelect = global::Events.OnEntitySelect;
    if (onEntitySelect == null)
      return;
    onEntitySelect(entity);
  }

  public static event global::Events.UnityActionRef<Entity, bool> OnCheckEntityDrag;

  public static bool CheckEntityDrag(Entity entity)
  {
    bool flag = true;
    global::Events.UnityActionRef<Entity, bool> onCheckEntityDrag = global::Events.OnCheckEntityDrag;
    if (onCheckEntityDrag != null)
      onCheckEntityDrag(ref entity, ref flag);
    return flag;
  }

  public static event UnityAction<Entity> OnEntityDrag;

  public static void InvokeEntityDrag(Entity entity)
  {
    UnityAction<Entity> onEntityDrag = global::Events.OnEntityDrag;
    if (onEntityDrag == null)
      return;
    onEntityDrag(entity);
  }

  public static event UnityAction<Entity> OnEntityRelease;

  public static void InvokeEntityRelease(Entity entity)
  {
    UnityAction<Entity> onEntityRelease = global::Events.OnEntityRelease;
    if (onEntityRelease == null)
      return;
    onEntityRelease(entity);
  }

  public static event UnityAction<Entity> OnEntityOffered;

  public static void InvokeEntityOffered(Entity entity)
  {
    UnityAction<Entity> onEntityOffered = global::Events.OnEntityOffered;
    if (onEntityOffered == null)
      return;
    onEntityOffered(entity);
  }

  public static event UnityAction<Entity> OnEntityChosen;

  public static void InvokeEntityChosen(Entity entity)
  {
    UnityAction<Entity> onEntityChosen = global::Events.OnEntityChosen;
    if (onEntityChosen == null)
      return;
    onEntityChosen(entity);
  }

  public static event UnityAction<Entity> OnEntityShowUnlocked;

  public static void InvokeEntityShowUnlocked(Entity entity)
  {
    UnityAction<Entity> entityShowUnlocked = global::Events.OnEntityShowUnlocked;
    if (entityShowUnlocked == null)
      return;
    entityShowUnlocked(entity);
  }

  public static event global::Events.UnityActionRef<Entity, bool> OnCheckEntityShove;

  public static bool CheckEntityShove(Entity entity)
  {
    bool flag = true;
    global::Events.UnityActionRef<Entity, bool> checkEntityShove = global::Events.OnCheckEntityShove;
    if (checkEntityShove != null)
      checkEntityShove(ref entity, ref flag);
    return flag;
  }

  public static event UnityAction<Entity> OnPreProcessTrigger;

  public static void InvokePreProcessTrigger(Entity entity)
  {
    UnityAction<Entity> preProcessTrigger = global::Events.OnPreProcessTrigger;
    if (preProcessTrigger == null)
      return;
    preProcessTrigger(entity);
  }

  public static event global::Events.UnityActionRef<Trigger> OnEntityPreTrigger;

  public static void InvokeEntityPreTrigger(ref Trigger trigger)
  {
    global::Events.UnityActionRef<Trigger> entityPreTrigger = global::Events.OnEntityPreTrigger;
    if (entityPreTrigger == null)
      return;
    entityPreTrigger(ref trigger);
  }

  public static event global::Events.UnityActionRef<Trigger> OnEntityTrigger;

  public static void InvokeEntityTrigger(ref Trigger trigger)
  {
    global::Events.UnityActionRef<Trigger> onEntityTrigger = global::Events.OnEntityTrigger;
    if (onEntityTrigger == null)
      return;
    onEntityTrigger(ref trigger);
  }

  public static event global::Events.UnityActionRef<Trigger> OnEntityTriggered;

  public static void InvokeEntityTriggered(ref Trigger trigger)
  {
    global::Events.UnityActionRef<Trigger> onEntityTriggered = global::Events.OnEntityTriggered;
    if (onEntityTriggered == null)
      return;
    onEntityTriggered(ref trigger);
  }

  public static event UnityAction<Entity> OnEntityMove;

  public static void InvokeEntityMove(Entity entity)
  {
    UnityAction<Entity> onEntityMove = global::Events.OnEntityMove;
    if (onEntityMove == null)
      return;
    onEntityMove(entity);
  }

  public static event UnityAction<Entity, CardContainer[], bool> OnEntityPlace;

  public static void InvokeEntityPlace(Entity entity, CardContainer[] containers, bool freeMove)
  {
    UnityAction<Entity, CardContainer[], bool> onEntityPlace = global::Events.OnEntityPlace;
    if (onEntityPlace == null)
      return;
    onEntityPlace(entity, containers, freeMove);
  }

  public static event UnityAction<Entity> OnDiscard;

  public static void InvokeDiscard(Entity entity)
  {
    UnityAction<Entity> onDiscard = global::Events.OnDiscard;
    if (onDiscard == null)
      return;
    onDiscard(entity);
  }

  public static event UnityAction<Hit> OnEntityHit;

  public static void InvokeEntityHit(Hit hit)
  {
    UnityAction<Hit> onEntityHit = global::Events.OnEntityHit;
    if (onEntityHit == null)
      return;
    onEntityHit(hit);
  }

  public static event UnityAction<Hit> OnEntityPostHit;

  public static void InvokeEntityPostHit(Hit hit)
  {
    UnityAction<Hit> onEntityPostHit = global::Events.OnEntityPostHit;
    if (onEntityPostHit == null)
      return;
    onEntityPostHit(hit);
  }

  public static event UnityAction<Hit> OnEntityDodge;

  public static void InvokeEntityDodge(Hit hit)
  {
    UnityAction<Hit> onEntityDodge = global::Events.OnEntityDodge;
    if (onEntityDodge == null)
      return;
    onEntityDodge(hit);
  }

  public static event UnityAction<Entity> OnEntityFlipUp;

  public static void InvokeEntityFlipUp(Entity entity)
  {
    UnityAction<Entity> onEntityFlipUp = global::Events.OnEntityFlipUp;
    if (onEntityFlipUp == null)
      return;
    onEntityFlipUp(entity);
  }

  public static event UnityAction<Entity> OnEntityFlipDown;

  public static void InvokeEntityFlipDown(Entity entity)
  {
    UnityAction<Entity> onEntityFlipDown = global::Events.OnEntityFlipDown;
    if (onEntityFlipDown == null)
      return;
    onEntityFlipDown(entity);
  }

  public static event UnityAction<StatusIcon> OnStatusIconCreated;

  public static void InvokeStatusIconCreated(StatusIcon icon)
  {
    UnityAction<StatusIcon> statusIconCreated = global::Events.OnStatusIconCreated;
    if (statusIconCreated == null)
      return;
    statusIconCreated(icon);
  }

  public static event UnityAction<StatusIcon, Stat, Stat> OnStatusIconChanged;

  public static void InvokeStatusIconChanged(StatusIcon icon, Stat previousValue, Stat newValue)
  {
    UnityAction<StatusIcon, Stat, Stat> statusIconChanged = global::Events.OnStatusIconChanged;
    if (statusIconChanged == null)
      return;
    statusIconChanged(icon, previousValue, newValue);
  }

  public static event UnityAction<Entity> OnEntityDisplayUpdated;

  public static void InvokeEntityDisplayUpdated(Entity entity)
  {
    UnityAction<Entity> entityDisplayUpdated = global::Events.OnEntityDisplayUpdated;
    if (entityDisplayUpdated == null)
      return;
    entityDisplayUpdated(entity);
  }

  public static event UnityAction<Entity> OnEntityFocus;

  public static void InvokeEntityFocus(Entity entity)
  {
    UnityAction<Entity> onEntityFocus = global::Events.OnEntityFocus;
    if (onEntityFocus == null)
      return;
    onEntityFocus(entity);
  }

  public static event UnityAction<Entity, CardPocket> OnEntityEnterPocket;

  public static void InvokeEntityEnterPocket(Entity card, CardPocket pocket)
  {
    UnityAction<Entity, CardPocket> entityEnterPocket = global::Events.OnEntityEnterPocket;
    if (entityEnterPocket == null)
      return;
    entityEnterPocket(card, pocket);
  }

  public static event UnityAction<Entity> OnEntityEnterBackpack;

  public static void InvokeEntityEnterBackpack(Entity entity)
  {
    UnityAction<Entity> entityEnterBackpack = global::Events.OnEntityEnterBackpack;
    if (entityEnterBackpack == null)
      return;
    entityEnterBackpack(entity);
  }

  public static event UnityAction<Entity> OnEntityChangePhase;

  public static void InvokeEntityChangePhase(Entity entity)
  {
    UnityAction<Entity> entityChangePhase = global::Events.OnEntityChangePhase;
    if (entityChangePhase == null)
      return;
    entityChangePhase(entity);
  }

  public static event UnityAction<Entity> OnNoomlinShow;

  public static void InvokeNoomlinShow(Entity entity)
  {
    UnityAction<Entity> onNoomlinShow = global::Events.OnNoomlinShow;
    if (onNoomlinShow == null)
      return;
    onNoomlinShow(entity);
  }

  public static event UnityAction<Entity> OnNoomlinUsed;

  public static void InvokeNoomlinUsed(Entity entity)
  {
    UnityAction<Entity> onNoomlinUsed = global::Events.OnNoomlinUsed;
    if (onNoomlinUsed == null)
      return;
    onNoomlinUsed(entity);
  }

  public static event UnityAction<Entity> OnEntityFlipComplete;

  public static void InvokeEntityFlipComplete(Entity entity)
  {
    UnityAction<Entity> entityFlipComplete = global::Events.OnEntityFlipComplete;
    if (entityFlipComplete == null)
      return;
    entityFlipComplete(entity);
  }

  public static event UnityAction<Entity, Entity> OnEntitySummoned;

  public static void InvokeEntitySummoned(Entity entity, Entity summonedBy)
  {
    UnityAction<Entity, Entity> onEntitySummoned = global::Events.OnEntitySummoned;
    if (onEntitySummoned == null)
      return;
    onEntitySummoned(entity, summonedBy);
  }

  public static event UnityAction<GameObject> OnEntityPing;

  public static void InvokeEntityPing(GameObject obj)
  {
    UnityAction<GameObject> onEntityPing = global::Events.OnEntityPing;
    if (onEntityPing == null)
      return;
    onEntityPing(obj);
  }

  public static event global::Events.UnityActionRef<Entity, int> OnCheckRecycleAmount;

  public static void CheckRecycleAmount(Entity entity, ref int amount)
  {
    global::Events.UnityActionRef<Entity, int> checkRecycleAmount = global::Events.OnCheckRecycleAmount;
    if (checkRecycleAmount == null)
      return;
    checkRecycleAmount(ref entity, ref amount);
  }

  public static event UnityAction<CardContainer> OnContainerHover;

  public static void InvokeContainerHover(CardContainer container)
  {
    UnityAction<CardContainer> onContainerHover = global::Events.OnContainerHover;
    if (onContainerHover == null)
      return;
    onContainerHover(container);
  }

  public static event UnityAction<CardContainer> OnContainerUnHover;

  public static void InvokeContainerUnHover(CardContainer container)
  {
    UnityAction<CardContainer> containerUnHover = global::Events.OnContainerUnHover;
    if (containerUnHover == null)
      return;
    containerUnHover(container);
  }

  public static event UnityAction<CardSlot> OnSlotHover;

  public static void InvokeSlotHover(CardSlot slot)
  {
    UnityAction<CardSlot> onSlotHover = global::Events.OnSlotHover;
    if (onSlotHover == null)
      return;
    onSlotHover(slot);
  }

  public static event UnityAction<CardSlot> OnSlotUnHover;

  public static void InvokeSlotUnHover(CardSlot slot)
  {
    UnityAction<CardSlot> onSlotUnHover = global::Events.OnSlotUnHover;
    if (onSlotUnHover == null)
      return;
    onSlotUnHover(slot);
  }

  public static event UnityAction<PlayAction> OnActionQueued;

  public static void InvokeActionQueued(PlayAction action)
  {
    UnityAction<PlayAction> onActionQueued = global::Events.OnActionQueued;
    if (onActionQueued == null)
      return;
    onActionQueued(action);
  }

  public static event UnityAction<PlayAction> OnActionPerform;

  public static void InvokeActionPerform(PlayAction action)
  {
    UnityAction<PlayAction> onActionPerform = global::Events.OnActionPerform;
    if (onActionPerform == null)
      return;
    onActionPerform(action);
  }

  public static event UnityAction<PlayAction> OnActionFinished;

  public static void InvokeActionFinished(PlayAction action)
  {
    UnityAction<PlayAction> onActionFinished = global::Events.OnActionFinished;
    if (onActionFinished == null)
      return;
    onActionFinished(action);
  }

  public static event global::Events.UnityActionRef<PlayAction, bool> OnCheckAction;

  public static bool CheckAction(PlayAction action)
  {
    bool flag = true;
    global::Events.UnityActionRef<PlayAction, bool> onCheckAction = global::Events.OnCheckAction;
    if (onCheckAction != null)
      onCheckAction(ref action, ref flag);
    return flag;
  }

  public static event UnityAction<CardContainer> OnAbilityTargetAdd;

  public static void InvokeAbilityTargetAdd(CardContainer container)
  {
    UnityAction<CardContainer> abilityTargetAdd = global::Events.OnAbilityTargetAdd;
    if (abilityTargetAdd == null)
      return;
    abilityTargetAdd(container);
  }

  public static event UnityAction<CardContainer> OnAbilityTargetRemove;

  public static void InvokeAbilityTargetRemove(CardContainer container)
  {
    UnityAction<CardContainer> abilityTargetRemove = global::Events.OnAbilityTargetRemove;
    if (abilityTargetRemove == null)
      return;
    abilityTargetRemove(container);
  }

  public static event UnityAction<int> OnCardDraw;

  public static void InvokeCardDraw(int count)
  {
    UnityAction<int> onCardDraw = global::Events.OnCardDraw;
    if (onCardDraw == null)
      return;
    onCardDraw(count);
  }

  public static event UnityAction OnCardDrawEnd;

  public static void InvokeCardDrawEnd()
  {
    UnityAction onCardDrawEnd = global::Events.OnCardDrawEnd;
    if (onCardDrawEnd == null)
      return;
    onCardDrawEnd();
  }

  public static event UnityAction<CampaignNode> PreBattleSetUp;

  public static void InvokePreBattleSetUp(CampaignNode node)
  {
    UnityAction<CampaignNode> preBattleSetUp = global::Events.PreBattleSetUp;
    if (preBattleSetUp == null)
      return;
    preBattleSetUp(node);
  }

  public static event UnityAction<CampaignNode> PostBattleSetUp;

  public static void InvokePostBattleSetUp(CampaignNode node)
  {
    UnityAction<CampaignNode> postBattleSetUp = global::Events.PostBattleSetUp;
    if (postBattleSetUp == null)
      return;
    postBattleSetUp(node);
  }

  public static event UnityAction<Battle.Phase> OnBattlePhaseStart;

  public static void InvokeBattlePhaseStart(Battle.Phase phase)
  {
    UnityAction<Battle.Phase> battlePhaseStart = global::Events.OnBattlePhaseStart;
    if (battlePhaseStart == null)
      return;
    battlePhaseStart(phase);
  }

  public static event UnityAction OnBattleStart;

  public static void InvokeBattleStart()
  {
    UnityAction onBattleStart = global::Events.OnBattleStart;
    if (onBattleStart == null)
      return;
    onBattleStart();
  }

  public static event global::Events.AsyncAction PreBattleEnd;

  public static IEnumerator InvokePreBattleEnd()
  {
    if (global::Events.PreBattleEnd != null)
    {
      Task task = global::Events.PreBattleEnd();
      yield return (object) new WaitUntil((Func<bool>) (() => task.IsCompleted));
    }
  }

  public static event UnityAction OnBattleEnd;

  public static void InvokeBattleEnd()
  {
    UnityAction onBattleEnd = global::Events.OnBattleEnd;
    if (onBattleEnd == null)
      return;
    onBattleEnd();
  }

  public static event UnityAction OnBattleWinPreRewards;

  public static void InvokeBattleWinPreRewards()
  {
    UnityAction battleWinPreRewards = global::Events.OnBattleWinPreRewards;
    if (battleWinPreRewards == null)
      return;
    battleWinPreRewards();
  }

  public static event UnityAction OnBattleWin;

  public static void InvokeBattleWin()
  {
    UnityAction onBattleWin = global::Events.OnBattleWin;
    if (onBattleWin == null)
      return;
    onBattleWin();
  }

  public static event UnityAction<CampaignNode> PostBattle;

  public static void InvokePostBattle(CampaignNode campaignNode)
  {
    UnityAction<CampaignNode> postBattle = global::Events.PostBattle;
    if (postBattle == null)
      return;
    postBattle(campaignNode);
  }

  public static event global::Events.UnityActionCheck<StatusEffectData, int> OnStatusEffectCountDown;

  public static void InvokeStatusEffectCountDown(StatusEffectData status, ref int amount)
  {
    global::Events.UnityActionCheck<StatusEffectData, int> statusEffectCountDown = global::Events.OnStatusEffectCountDown;
    if (statusEffectCountDown == null)
      return;
    statusEffectCountDown(status, ref amount);
  }

  public static event UnityAction<StatusEffectApply> OnStatusEffectApplied;

  public static void InvokeStatusEffectApplied(StatusEffectApply apply)
  {
    UnityAction<StatusEffectApply> statusEffectApplied = global::Events.OnStatusEffectApplied;
    if (statusEffectApplied == null)
      return;
    statusEffectApplied(apply);
  }

  public static event UnityAction<Character> OnPreProcessUnits;

  public static void InvokePreProcessUnits(Character character)
  {
    UnityAction<Character> onPreProcessUnits = global::Events.OnPreProcessUnits;
    if (onPreProcessUnits == null)
      return;
    onPreProcessUnits(character);
  }

  public static event UnityAction<Character> OnPostProcessUnits;

  public static void InvokePostProcessUnits(Character character)
  {
    UnityAction<Character> postProcessUnits = global::Events.OnPostProcessUnits;
    if (postProcessUnits == null)
      return;
    postProcessUnits(character);
  }

  public static event global::Events.UnityActionCheck<Entity, int> OnEntityCountDown;

  public static void InvokeEntityCountDown(Entity entity, ref int amount)
  {
    global::Events.UnityActionCheck<Entity, int> onEntityCountDown = global::Events.OnEntityCountDown;
    if (onEntityCountDown == null)
      return;
    onEntityCountDown(entity, ref amount);
  }

  public static event UnityAction<int> OnBattlePreTurnStart;

  public static void InvokeBattlePreTurnStart(int turnNumber)
  {
    UnityAction<int> battlePreTurnStart = global::Events.OnBattlePreTurnStart;
    if (battlePreTurnStart == null)
      return;
    battlePreTurnStart(turnNumber);
  }

  public static event UnityAction<int> OnBattleTurnStart;

  public static void InvokeBattleTurnStart(int turnNumber)
  {
    UnityAction<int> onBattleTurnStart = global::Events.OnBattleTurnStart;
    if (onBattleTurnStart == null)
      return;
    onBattleTurnStart(turnNumber);
  }

  public static event UnityAction<int> OnBattleTurnEnd;

  public static void InvokeBattleTurnEnd(int turnNumber)
  {
    UnityAction<int> onBattleTurnEnd = global::Events.OnBattleTurnEnd;
    if (onBattleTurnEnd == null)
      return;
    onBattleTurnEnd(turnNumber);
  }

  public static event UnityAction<Entity> OnMinibossIntro;

  public static void InvokeMinibossIntro(Entity entity)
  {
    UnityAction<Entity> onMinibossIntro = global::Events.OnMinibossIntro;
    if (onMinibossIntro == null)
      return;
    onMinibossIntro(entity);
  }

  public static event UnityAction<Entity> OnMinibossIntroDone;

  public static void InvokeMinibossIntroDone(Entity entity)
  {
    UnityAction<Entity> minibossIntroDone = global::Events.OnMinibossIntroDone;
    if (minibossIntroDone == null)
      return;
    minibossIntroDone(entity);
  }

  public static event UnityAction<int> OnKillCombo;

  public static void InvokeKillCombo(int combo)
  {
    UnityAction<int> onKillCombo = global::Events.OnKillCombo;
    if (onKillCombo == null)
      return;
    onKillCombo(combo);
  }

  public static event UnityAction<RedrawBellSystem> OnRedrawBellHit;

  public static void InvokeRedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    UnityAction<RedrawBellSystem> onRedrawBellHit = global::Events.OnRedrawBellHit;
    if (onRedrawBellHit == null)
      return;
    onRedrawBellHit(redrawBellSystem);
  }

  public static event UnityAction<RedrawBellSystem> OnRedrawBellRevealed;

  public static void InvokeRedrawBellRevealed(RedrawBellSystem redrawBellSystem)
  {
    UnityAction<RedrawBellSystem> redrawBellRevealed = global::Events.OnRedrawBellRevealed;
    if (redrawBellRevealed == null)
      return;
    redrawBellRevealed(redrawBellSystem);
  }

  public static event UnityAction<CardData> OnCardInjured;

  public static void InvokeCardInjured(CardData cardData)
  {
    UnityAction<CardData> onCardInjured = global::Events.OnCardInjured;
    if (onCardInjured == null)
      return;
    onCardInjured(cardData);
  }

  public static event UnityAction OnBattleStateBuild;

  public static void InvokeBattleStateBuild()
  {
    UnityAction battleStateBuild = global::Events.OnBattleStateBuild;
    if (battleStateBuild == null)
      return;
    battleStateBuild();
  }

  public static event UnityAction<BattleSaveData> OnBattleStateBuilt;

  public static void InvokeBattleStateBuilt(BattleSaveData battleState)
  {
    UnityAction<BattleSaveData> battleStateBuilt = global::Events.OnBattleStateBuilt;
    if (battleStateBuilt == null)
      return;
    battleStateBuilt(battleState);
  }

  public static event UnityAction<Character> OnCharacterActionPerformed;

  public static void InvokeCharacterActionPerformed(Character character)
  {
    UnityAction<Character> characterActionPerformed = global::Events.OnCharacterActionPerformed;
    if (characterActionPerformed == null)
      return;
    characterActionPerformed(character);
  }

  public static event UnityAction<int> OnWaveDeployerPreCountDown;

  public static void InvokeWaveDeployerPreCountDown(int counter)
  {
    UnityAction<int> deployerPreCountDown = global::Events.OnWaveDeployerPreCountDown;
    if (deployerPreCountDown == null)
      return;
    deployerPreCountDown(counter);
  }

  public static event UnityAction<int> OnWaveDeployerPostCountDown;

  public static void InvokeWaveDeployerPostCountDown(int counter)
  {
    UnityAction<int> deployerPostCountDown = global::Events.OnWaveDeployerPostCountDown;
    if (deployerPostCountDown == null)
      return;
    deployerPostCountDown(counter);
  }

  public static event UnityAction<float> OnMapPathReveal;

  public static void InvokeMapPathReveal(float totalTime)
  {
    UnityAction<float> onMapPathReveal = global::Events.OnMapPathReveal;
    if (onMapPathReveal == null)
      return;
    onMapPathReveal(totalTime);
  }

  public static event UnityAction<MapNode> OnMapNodeReveal;

  public static void InvokeMapNodeReveal(MapNode node)
  {
    UnityAction<MapNode> onMapNodeReveal = global::Events.OnMapNodeReveal;
    if (onMapNodeReveal == null)
      return;
    onMapNodeReveal(node);
  }

  public static event UnityAction<MapNode> OnMapNodeSelect;

  public static void InvokeMapNodeSelect(MapNode node)
  {
    UnityAction<MapNode> onMapNodeSelect = global::Events.OnMapNodeSelect;
    if (onMapNodeSelect == null)
      return;
    onMapNodeSelect(node);
  }

  public static event UnityAction<MapNode> OnMapNodeHover;

  public static void InvokeMapNodeHover(MapNode node)
  {
    UnityAction<MapNode> onMapNodeHover = global::Events.OnMapNodeHover;
    if (onMapNodeHover == null)
      return;
    onMapNodeHover(node);
  }

  public static event UnityAction<MapNode> OnMapNodeUnHover;

  public static void InvokeMapNodeUnHover(MapNode node)
  {
    UnityAction<MapNode> onMapNodeUnHover = global::Events.OnMapNodeUnHover;
    if (onMapNodeUnHover == null)
      return;
    onMapNodeUnHover(node);
  }

  public static event UnityAction<UnlockData> OnTownUnlock;

  public static void InvokeTownUnlock(UnlockData unlockData)
  {
    UnityAction<UnlockData> onTownUnlock = global::Events.OnTownUnlock;
    if (onTownUnlock == null)
      return;
    onTownUnlock(unlockData);
  }

  public static event UnityAction<ShopItem> OnShopItemHover;

  public static void InvokeShopItemHover(ShopItem item)
  {
    UnityAction<ShopItem> onShopItemHover = global::Events.OnShopItemHover;
    if (onShopItemHover == null)
      return;
    onShopItemHover(item);
  }

  public static event UnityAction<ShopItem> OnShopItemUnHover;

  public static void InvokeShopItemUnHover(ShopItem item)
  {
    UnityAction<ShopItem> onShopItemUnHover = global::Events.OnShopItemUnHover;
    if (onShopItemUnHover == null)
      return;
    onShopItemUnHover(item);
  }

  public static event UnityAction<ShopItem> OnShopItemPurchase;

  public static void InvokeShopItemPurchase(ShopItem item)
  {
    UnityAction<ShopItem> shopItemPurchase = global::Events.OnShopItemPurchase;
    if (shopItemPurchase == null)
      return;
    shopItemPurchase(item);
  }

  public static event UnityAction<KeywordData, CardPopUpPanel> OnPopupCreated;

  public static void InvokePopupPanelCreated(KeywordData keyword, CardPopUpPanel panel)
  {
    UnityAction<KeywordData, CardPopUpPanel> onPopupCreated = global::Events.OnPopupCreated;
    if (onPopupCreated == null)
      return;
    onPopupCreated(keyword, panel);
  }

  public static event UnityAction<ButtonType> OnButtonHover;

  public static void InvokeButtonHover(ButtonType buttonType)
  {
    UnityAction<ButtonType> onButtonHover = global::Events.OnButtonHover;
    if (onButtonHover == null)
      return;
    onButtonHover(buttonType);
  }

  public static event UnityAction<ButtonType> OnButtonPress;

  public static void InvokeButtonPress(ButtonType buttonType)
  {
    UnityAction<ButtonType> onButtonPress = global::Events.OnButtonPress;
    if (onButtonPress == null)
      return;
    onButtonPress(buttonType);
  }

  public static event UnityAction<string, float> OnAudioVolumeChange;

  public static void InvokeAudioVolumeChange(string busName, float value)
  {
    UnityAction<string, float> audioVolumeChange = global::Events.OnAudioVolumeChange;
    if (audioVolumeChange == null)
      return;
    audioVolumeChange(busName, value);
  }

  public static event UnityAction<string, float> OnAudioPitchChange;

  public static void InvokeAudioPitchChange(string busName, float value)
  {
    UnityAction<string, float> audioPitchChange = global::Events.OnAudioPitchChange;
    if (audioPitchChange == null)
      return;
    audioPitchChange(busName, value);
  }

  public static event UnityAction<Entity> OnBombardShoot;

  public static void InvokeBombardShoot(Entity entity)
  {
    UnityAction<Entity> onBombardShoot = global::Events.OnBombardShoot;
    if (onBombardShoot == null)
      return;
    onBombardShoot(entity);
  }

  public static event UnityAction<BombardRocket> OnBombardRocketFall;

  public static void InvokeBombardRocketFall(BombardRocket rocket)
  {
    UnityAction<BombardRocket> bombardRocketFall = global::Events.OnBombardRocketFall;
    if (bombardRocketFall == null)
      return;
    bombardRocketFall(rocket);
  }

  public static event UnityAction<BombardRocket> OnBombardRocketExplode;

  public static void InvokeBombardRocketExplode(BombardRocket rocket)
  {
    UnityAction<BombardRocket> bombardRocketExplode = global::Events.OnBombardRocketExplode;
    if (bombardRocketExplode == null)
      return;
    bombardRocketExplode(rocket);
  }

  public static event UnityAction<float> OnProgressStart;

  public static void InvokeProgressStart(float fill)
  {
    UnityAction<float> onProgressStart = global::Events.OnProgressStart;
    if (onProgressStart == null)
      return;
    onProgressStart(fill);
  }

  public static event UnityAction<float> OnProgressUpdate;

  public static void InvokeProgressUpdate(float fill)
  {
    UnityAction<float> onProgressUpdate = global::Events.OnProgressUpdate;
    if (onProgressUpdate == null)
      return;
    onProgressUpdate(fill);
  }

  public static event UnityAction OnProgressStop;

  public static void InvokeProgressStop()
  {
    UnityAction onProgressStop = global::Events.OnProgressStop;
    if (onProgressStop == null)
      return;
    onProgressStop();
  }

  public static event UnityAction OnProgressDing;

  public static void InvokeProgressDing()
  {
    UnityAction onProgressDing = global::Events.OnProgressDing;
    if (onProgressDing == null)
      return;
    onProgressDing();
  }

  public static event UnityAction OnProgressBlip;

  public static void InvokeProgressBlip()
  {
    UnityAction onProgressBlip = global::Events.OnProgressBlip;
    if (onProgressBlip == null)
      return;
    onProgressBlip();
  }

  public static event UnityAction OnSaveSystemEnabled;

  public static void InvokeSaveSystemEnabled()
  {
    UnityAction saveSystemEnabled = global::Events.OnSaveSystemEnabled;
    if (saveSystemEnabled == null)
      return;
    saveSystemEnabled();
  }

  public static event UnityAction OnSaveSystemDisabled;

  public static void InvokeSaveSystemDisabled()
  {
    UnityAction saveSystemDisabled = global::Events.OnSaveSystemDisabled;
    if (saveSystemDisabled == null)
      return;
    saveSystemDisabled();
  }

  public static event UnityAction OnSaveSystemProfileChanged;

  public static void InvokeSaveSystemProfileChanged()
  {
    UnityAction systemProfileChanged = global::Events.OnSaveSystemProfileChanged;
    if (systemProfileChanged == null)
      return;
    systemProfileChanged();
  }

  public static event UnityAction OnCampaignSaved;

  public static void InvokeCampaignSaved()
  {
    UnityAction onCampaignSaved = global::Events.OnCampaignSaved;
    if (onCampaignSaved == null)
      return;
    onCampaignSaved();
  }

  public static event UnityAction OnCampaignLoaded;

  public static void InvokeCampaignLoaded()
  {
    UnityAction onCampaignLoaded = global::Events.OnCampaignLoaded;
    if (onCampaignLoaded == null)
      return;
    onCampaignLoaded();
  }

  public static event UnityAction OnCampaignDeleted;

  public static void InvokeCampaignDeleted()
  {
    UnityAction onCampaignDeleted = global::Events.OnCampaignDeleted;
    if (onCampaignDeleted == null)
      return;
    onCampaignDeleted();
  }

  public static event UnityAction OnBattleSaved;

  public static void InvokeBattleSaved()
  {
    UnityAction onBattleSaved = global::Events.OnBattleSaved;
    if (onBattleSaved == null)
      return;
    onBattleSaved();
  }

  public static event UnityAction OnBattleLoaded;

  public static void InvokeBattleLoaded()
  {
    UnityAction onBattleLoaded = global::Events.OnBattleLoaded;
    if (onBattleLoaded == null)
      return;
    onBattleLoaded();
  }

  public static event UnityAction OnGameStart;

  public static void InvokeGameStart()
  {
    UnityAction onGameStart = global::Events.OnGameStart;
    if (onGameStart == null)
      return;
    onGameStart();
  }

  public static event UnityAction OnGameEnd;

  public static void InvokeGameEnd()
  {
    UnityAction onGameEnd = global::Events.OnGameEnd;
    if (onGameEnd == null)
      return;
    onGameEnd();
  }

  public static event UnityAction OnCampaignStart;

  public static void InvokeCampaignStart()
  {
    UnityAction onCampaignStart = global::Events.OnCampaignStart;
    if (onCampaignStart == null)
      return;
    onCampaignStart();
  }

  public static event UnityAction OnCampaignFinal;

  public static void InvokeCampaignFinal()
  {
    UnityAction onCampaignFinal = global::Events.OnCampaignFinal;
    if (onCampaignFinal == null)
      return;
    onCampaignFinal();
  }

  public static event UnityAction<Campaign.Result, CampaignStats, PlayerData> OnCampaignEnd;

  public static void InvokeCampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    UnityAction<Campaign.Result, CampaignStats, PlayerData> onCampaignEnd = global::Events.OnCampaignEnd;
    if (onCampaignEnd == null)
      return;
    onCampaignEnd(result, stats, playerData);
  }

  public static event UnityAction<CampaignStats> OnOverallStatsSaved;

  public static void InvokeOverallStatsSaved(CampaignStats stats)
  {
    UnityAction<CampaignStats> overallStatsSaved = global::Events.OnOverallStatsSaved;
    if (overallStatsSaved == null)
      return;
    overallStatsSaved(stats);
  }

  public static event UnityAction<CampaignData> OnCampaignDataCreated;

  public static void InvokeCampaignDataCreated(CampaignData data)
  {
    UnityAction<CampaignData> campaignDataCreated = global::Events.OnCampaignDataCreated;
    if (campaignDataCreated == null)
      return;
    campaignDataCreated(data);
  }

  public static event global::Events.RoutineAction OnCampaignPreInit;

  public static IEnumerator InvokeCampaignPreInit()
  {
    if (global::Events.OnCampaignPreInit != null)
      yield return (object) global::Events.OnCampaignPreInit();
  }

  public static event global::Events.RoutineAction OnCampaignInit;

  public static IEnumerator InvokeCampaignInit()
  {
    if (global::Events.OnCampaignInit != null)
      yield return (object) global::Events.OnCampaignInit();
  }

  public static event UnityAction OnPreCampaignPopulate;

  public static void InvokePreCampaignPopulate()
  {
    UnityAction campaignPopulate = global::Events.OnPreCampaignPopulate;
    if (campaignPopulate == null)
      return;
    campaignPopulate();
  }

  public static event global::Events.UnityActionRef1<List<CampaignGenerator.Node>, Vector2> OnCampaignNodesCreated;

  public static void InvokeCampaignNodesCreated(
    ref List<CampaignGenerator.Node> nodes,
    Vector2 nodeSpacing)
  {
    global::Events.UnityActionRef1<List<CampaignGenerator.Node>, Vector2> campaignNodesCreated = global::Events.OnCampaignNodesCreated;
    if (campaignNodesCreated == null)
      return;
    campaignNodesCreated(ref nodes, nodeSpacing);
  }

  public static event global::Events.UnityActionRef<string[]> OnCampaignLoadPreset;

  public static void InvokeCampaignLoadPreset(ref string[] lines)
  {
    global::Events.UnityActionRef<string[]> campaignLoadPreset = global::Events.OnCampaignLoadPreset;
    if (campaignLoadPreset == null)
      return;
    campaignLoadPreset(ref lines);
  }

  public static event global::Events.AsyncAction OnCampaignGenerated;

  public static IEnumerator InvokeCampaignGenerated()
  {
    if (global::Events.OnCampaignGenerated != null)
    {
      Delegate[] delegateArray = global::Events.OnCampaignGenerated.GetInvocationList();
      for (int index = 0; index < delegateArray.Length; ++index)
      {
        if (delegateArray[index] is global::Events.AsyncAction asyncAction)
        {
          Task task = asyncAction();
          yield return (object) new WaitUntil((Func<bool>) (() => task.IsCompleted));
        }
      }
      delegateArray = (Delegate[]) null;
    }
  }

  public static event UnityAction<string, string, int, int> OnStatChanged;

  public static void InvokeStatChanged(string stat, string key, int oldValue, int newValue)
  {
    UnityAction<string, string, int, int> onStatChanged = global::Events.OnStatChanged;
    if (onStatChanged == null)
      return;
    onStatChanged(stat, key, oldValue, newValue);
  }

  public static event UnityAction<CardUpgradeData> OnUpgradeGained;

  public static void InvokeUpgradeGained(CardUpgradeData upgradeData)
  {
    UnityAction<CardUpgradeData> onUpgradeGained = global::Events.OnUpgradeGained;
    if (onUpgradeGained == null)
      return;
    onUpgradeGained(upgradeData);
  }

  public static event UnityAction<Entity, CardUpgradeData> OnUpgradeAssign;

  public static void InvokeUpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    UnityAction<Entity, CardUpgradeData> onUpgradeAssign = global::Events.OnUpgradeAssign;
    if (onUpgradeAssign == null)
      return;
    onUpgradeAssign(entity, upgradeData);
  }

  public static event UnityAction<UpgradeDisplay> OnUpgradeHover;

  public static void InvokeUpgradeHover(UpgradeDisplay upgradeDisplay)
  {
    UnityAction<UpgradeDisplay> onUpgradeHover = global::Events.OnUpgradeHover;
    if (onUpgradeHover == null)
      return;
    onUpgradeHover(upgradeDisplay);
  }

  public static event UnityAction<UpgradeDisplay> OnUpgradePickup;

  public static void InvokeUpgradePickup(UpgradeDisplay upgradeDisplay)
  {
    UnityAction<UpgradeDisplay> onUpgradePickup = global::Events.OnUpgradePickup;
    if (onUpgradePickup == null)
      return;
    onUpgradePickup(upgradeDisplay);
  }

  public static event UnityAction<UpgradeDisplay> OnUpgradeDrop;

  public static void InvokeUpgradeDrop(UpgradeDisplay upgradeDisplay)
  {
    UnityAction<UpgradeDisplay> onUpgradeDrop = global::Events.OnUpgradeDrop;
    if (onUpgradeDrop == null)
      return;
    onUpgradeDrop(upgradeDisplay);
  }

  public static event UnityAction<bool> OnUpdateInputSystem;

  public static void InvokeUpdateInputSystem(bool forceTouch)
  {
    UnityAction<bool> updateInputSystem = global::Events.OnUpdateInputSystem;
    if (updateInputSystem == null)
      return;
    updateInputSystem(forceTouch);
  }

  public static event UnityAction<float, float?> OnScreenShake;

  public static void InvokeScreenShake(float magnitude = 1f, float? direction = 0.0f)
  {
    UnityAction<float, float?> onScreenShake = global::Events.OnScreenShake;
    if (onScreenShake == null)
      return;
    onScreenShake(magnitude, direction);
  }

  public static event global::Events.UnityAction<float, float, float, float, float, float> OnScreenRumble;

  public static void InvokeScreenRumble(
    float startStrength,
    float endStrength,
    float delay,
    float fadeInTime,
    float holdTime,
    float fadeOutTime)
  {
    global::Events.UnityAction<float, float, float, float, float, float> onScreenRumble = global::Events.OnScreenRumble;
    if (onScreenRumble == null)
      return;
    onScreenRumble(startStrength, endStrength, delay, fadeInTime, holdTime, fadeOutTime);
  }

  public static event UnityAction<string> OnCameraAnimation;

  public static void InvokeCameraAnimation(string name)
  {
    UnityAction<string> onCameraAnimation = global::Events.OnCameraAnimation;
    if (onCameraAnimation == null)
      return;
    onCameraAnimation(name);
  }

  public static event UnityAction<int, string, Character, Vector3> OnDropGold;

  public static void InvokeDropGold(int amount, string source, Character owner, Vector3 position)
  {
    UnityAction<int, string, Character, Vector3> onDropGold = global::Events.OnDropGold;
    if (onDropGold == null)
      return;
    onDropGold(amount, source, owner, position);
  }

  public static event UnityAction<int, Character, Vector3> OnGoldFlyToBag;

  public static void InvokeGoldFlyToBag(int amount, Character owner, Vector3 position)
  {
    UnityAction<int, Character, Vector3> onGoldFlyToBag = global::Events.OnGoldFlyToBag;
    if (onGoldFlyToBag == null)
      return;
    onGoldFlyToBag(amount, owner, position);
  }

  public static event UnityAction<int> OnCollectGold;

  public static void InvokeCollectGold(int amount)
  {
    UnityAction<int> onCollectGold = global::Events.OnCollectGold;
    if (onCollectGold == null)
      return;
    onCollectGold(amount);
  }

  public static event UnityAction<int> OnSpendGold;

  public static void InvokeSpendGold(int amount)
  {
    UnityAction<int> onSpendGold = global::Events.OnSpendGold;
    if (onSpendGold == null)
      return;
    onSpendGold(amount);
  }

  public static event UnityAction<float> OnTimeScaleChange;

  public static void InvokeTimeScaleChange(float value)
  {
    UnityAction<float> onTimeScaleChange = global::Events.OnTimeScaleChange;
    if (onTimeScaleChange == null)
      return;
    onTimeScaleChange(value);
  }

  public static event UnityAction<Entity> OnInspect;

  public static void InvokeInspect(Entity entity)
  {
    UnityAction<Entity> onInspect = global::Events.OnInspect;
    if (onInspect == null)
      return;
    onInspect(entity);
  }

  public static event UnityAction<Entity> OnInspectEnd;

  public static void InvokeInspectEnd(Entity entity)
  {
    UnityAction<Entity> onInspectEnd = global::Events.OnInspectEnd;
    if (onInspectEnd == null)
      return;
    onInspectEnd(entity);
  }

  public static event UnityAction<Entity> OnInspectNewCard;

  public static void InvokeInspectNewCard(Entity entity)
  {
    UnityAction<Entity> onInspectNewCard = global::Events.OnInspectNewCard;
    if (onInspectNewCard == null)
      return;
    onInspectNewCard(entity);
  }

  public static event UnityAction<CardController> OnCardControllerEnabled;

  public static void InvokeCardControllerEnabled(CardController controller)
  {
    UnityAction<CardController> controllerEnabled = global::Events.OnCardControllerEnabled;
    if (controllerEnabled == null)
      return;
    controllerEnabled(controller);
  }

  public static event UnityAction<CardController> OnCardControllerDisabled;

  public static void InvokeCardControllerDisabled(CardController controller)
  {
    UnityAction<CardController> controllerDisabled = global::Events.OnCardControllerDisabled;
    if (controllerDisabled == null)
      return;
    controllerDisabled(controller);
  }

  public static event UnityAction OnDeckpackOpen;

  public static void InvokeDeckpackOpen()
  {
    UnityAction onDeckpackOpen = global::Events.OnDeckpackOpen;
    if (onDeckpackOpen == null)
      return;
    onDeckpackOpen();
  }

  public static event UnityAction OnDeckpackClose;

  public static void InvokeDeckpackClose()
  {
    UnityAction onDeckpackClose = global::Events.OnDeckpackClose;
    if (onDeckpackClose == null)
      return;
    onDeckpackClose();
  }

  public static event UnityAction<TransitionType> OnTransitionStart;

  public static void InvokeTransitionStart(TransitionType transition)
  {
    UnityAction<TransitionType> onTransitionStart = global::Events.OnTransitionStart;
    if (onTransitionStart == null)
      return;
    onTransitionStart(transition);
  }

  public static event UnityAction<TransitionType> OnTransitionEnd;

  public static void InvokeTransitionEnd(TransitionType transition)
  {
    UnityAction<TransitionType> onTransitionEnd = global::Events.OnTransitionEnd;
    if (onTransitionEnd == null)
      return;
    onTransitionEnd(transition);
  }

  public static event UnityAction<float, float> OnSetWeatherIntensity;

  public static void InvokeSetWeatherIntensity(float amount, float updateDuration)
  {
    UnityAction<float, float> weatherIntensity = global::Events.OnSetWeatherIntensity;
    if (weatherIntensity == null)
      return;
    weatherIntensity(amount, updateDuration);
  }

  public static event UnityAction<GoldDisplay, float> OnGoldCounterStart;

  public static void InvokeGoldCounterStart(GoldDisplay goldDisplay, float addAmount)
  {
    UnityAction<GoldDisplay, float> goldCounterStart = global::Events.OnGoldCounterStart;
    if (goldCounterStart == null)
      return;
    goldCounterStart(goldDisplay, addAmount);
  }

  public static event UnityAction<CampaignNode, EventRoutine> OnEventStart;

  public static void InvokeEventStart(CampaignNode node, EventRoutine @event)
  {
    UnityAction<CampaignNode, EventRoutine> onEventStart = global::Events.OnEventStart;
    if (onEventStart == null)
      return;
    onEventStart(node, @event);
  }

  public static event UnityAction<EventRoutine> OnEventPopulated;

  public static void InvokeEventPopulated(EventRoutine @event)
  {
    UnityAction<EventRoutine> onEventPopulated = global::Events.OnEventPopulated;
    if (onEventPopulated == null)
      return;
    onEventPopulated(@event);
  }

  public static event UnityAction OnMuncherDrag;

  public static void InvokeMuncherDrag()
  {
    UnityAction onMuncherDrag = global::Events.OnMuncherDrag;
    if (onMuncherDrag == null)
      return;
    onMuncherDrag();
  }

  public static event UnityAction OnMuncherDragCancel;

  public static void InvokeMuncherDragCancel()
  {
    UnityAction muncherDragCancel = global::Events.OnMuncherDragCancel;
    if (muncherDragCancel == null)
      return;
    muncherDragCancel();
  }

  public static event UnityAction<Entity> OnMuncherFeed;

  public static void InvokeMuncherFeed(Entity entity)
  {
    UnityAction<Entity> onMuncherFeed = global::Events.OnMuncherFeed;
    if (onMuncherFeed == null)
      return;
    onMuncherFeed(entity);
  }

  public static event UnityAction<string, object> OnSettingChanged;

  public static void InvokeSettingChanged(string key, object value)
  {
    UnityAction<string, object> onSettingChanged = global::Events.OnSettingChanged;
    if (onSettingChanged == null)
      return;
    onSettingChanged(key, value);
  }

  public static event UnityAction OnUINavigationReset;

  public static void InvokeUINavigationReset()
  {
    UnityAction uiNavigationReset = global::Events.OnUINavigationReset;
    if (uiNavigationReset == null)
      return;
    uiNavigationReset();
  }

  public static event UnityAction OnUINavigation;

  public static void InvokeUINavigation()
  {
    UnityAction onUiNavigation = global::Events.OnUINavigation;
    if (onUiNavigation == null)
      return;
    onUiNavigation();
  }

  public static event UnityAction OnButtonStyleChanged;

  public static void InvokeButtonStyleChanged()
  {
    UnityAction buttonStyleChanged = global::Events.OnButtonStyleChanged;
    if (buttonStyleChanged == null)
      return;
    buttonStyleChanged();
  }

  public static event UnityAction OnControllerSwitched;

  public static void InvokeControllerSwitched()
  {
    UnityAction controllerSwitched = global::Events.OnControllerSwitched;
    if (controllerSwitched == null)
      return;
    controllerSwitched();
  }

  public static event global::Events.UnityActionRef<Entity, string, bool> OnCheckRename;

  public static bool CheckRename(ref Entity entity, ref string newName)
  {
    bool flag = true;
    global::Events.UnityActionRef<Entity, string, bool> onCheckRename = global::Events.OnCheckRename;
    if (onCheckRename != null)
      onCheckRename(ref entity, ref newName, ref flag);
    return flag;
  }

  public static event UnityAction<Entity, string> OnRename;

  public static void InvokeRename(Entity entity, string newName)
  {
    UnityAction<Entity, string> onRename = global::Events.OnRename;
    if (onRename == null)
      return;
    onRename(entity, newName);
  }

  public static event global::Events.UnityActionRef<object, string, int, List<DataFile>> OnPullRewards;

  public static List<DataFile> PullRewards(object pulledBy, string poolName, ref int count)
  {
    List<DataFile> dataFileList = new List<DataFile>();
    global::Events.UnityActionRef<object, string, int, List<DataFile>> onPullRewards = global::Events.OnPullRewards;
    if (onPullRewards != null)
      onPullRewards(pulledBy, ref poolName, ref count, ref dataFileList);
    return dataFileList;
  }

  public static event UnityAction<CardData> OnCardDataCreated;

  public static void InvokeCardDataCreated(CardData cardData)
  {
    UnityAction<CardData> onCardDataCreated = global::Events.OnCardDataCreated;
    if (onCardDataCreated == null)
      return;
    onCardDataCreated(cardData);
  }

  public static event UnityAction<int> OnTutorialProgress;

  public static void InvokeTutorialProgress(int value)
  {
    UnityAction<int> tutorialProgress = global::Events.OnTutorialProgress;
    if (tutorialProgress == null)
      return;
    tutorialProgress(value);
  }

  public static event UnityAction OnTutorialSkip;

  public static void InvokeTutorialSkip()
  {
    UnityAction onTutorialSkip = global::Events.OnTutorialSkip;
    if (onTutorialSkip == null)
      return;
    onTutorialSkip();
  }

  public static event UnityAction<ChallengeData> OnChallengeCompletedSaved;

  public static void InvokeChallengeCompletedSaved(ChallengeData challengeData)
  {
    UnityAction<ChallengeData> challengeCompletedSaved = global::Events.OnChallengeCompletedSaved;
    if (challengeCompletedSaved == null)
      return;
    challengeCompletedSaved(challengeData);
  }

  public static event global::Events.UnityActionRef<int> OnGetHandSize;

  public static int GetHandSize(int baseHandSize)
  {
    int handSize = baseHandSize;
    global::Events.UnityActionRef<int> onGetHandSize = global::Events.OnGetHandSize;
    if (onGetHandSize != null)
      onGetHandSize(ref handSize);
    return handSize;
  }

  public static event UnityAction<WildfrostMod> OnModLoaded;

  public static void InvokeModLoaded(WildfrostMod mod)
  {
    UnityAction<WildfrostMod> onModLoaded = global::Events.OnModLoaded;
    if (onModLoaded == null)
      return;
    onModLoaded(mod);
  }

  public static event UnityAction<WildfrostMod> OnModUnloaded;

  public static void InvokeModUnloaded(WildfrostMod mod)
  {
    UnityAction<WildfrostMod> onModUnloaded = global::Events.OnModUnloaded;
    if (onModUnloaded == null)
      return;
    onModUnloaded(mod);
  }

  public delegate void UnityActionRef<T>(ref T arg0);

  public delegate void UnityActionRef<T0, T1>(ref T0 arg0, ref T1 arg1);

  public delegate void UnityActionRef1<T0, T1>(ref T0 arg0, T1 arg1);

  public delegate void UnityActionRef<T0, T1, T2>(ref T0 arg0, ref T1 arg1, ref T2 arg2);

  public delegate void UnityActionRef<T0, T1, T2, T3>(
    T0 arg0,
    ref T1 arg1,
    ref T2 arg2,
    ref T3 arg3);

  public delegate void UnityActionCheck<T0, T1>(T0 arg0, ref T1 arg1);

  public delegate void UnityActionCheck<T0, T1, T2>(T0 arg0, T1 arg1, ref T2 arg2);

  public delegate void UnityAction<T0, T1, T2, T3, T4>(
    T0 arg0,
    T1 arg1,
    T2 arg2,
    T3 arg3,
    T4 arg4);

  public delegate void UnityAction<T0, T1, T2, T3, T4, T5>(
    T0 arg0,
    T1 arg1,
    T2 arg2,
    T3 arg3,
    T4 arg4,
    T5 arg5);

  public delegate IEnumerator RoutineAction();

  public delegate Task AsyncAction();

  public delegate IEnumerator RoutineAction<T>(T arg);
}
