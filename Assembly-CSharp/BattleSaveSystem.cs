// Decompiled with JetBrains decompiler
// Type: BattleSaveSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class BattleSaveSystem : GameSystem
{
  private static BattleSaveSystem instance;
  private bool loading;
  public bool justLoaded;
  private BattleSaveData state;
  private bool saveRequired;
  private bool campaignNodeIdSet;
  private int campaignNodeId;

  private void OnEnable()
  {
    BattleSaveSystem.instance = this;
    global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.BattleTurnEnd);
    global::Events.OnCampaignFinal += new UnityAction(this.CampaignFinal);
  }

  private void OnDisable()
  {
    global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.BattleTurnEnd);
    global::Events.OnCampaignFinal -= new UnityAction(this.CampaignFinal);
  }

  private void OnApplicationQuit() => this.CheckSave();

  public static BattleSaveData GetBattleState() => BattleSaveSystem.instance.state;

  private void BattleTurnEnd(int turnCount)
  {
    if (this.justLoaded)
    {
      this.justLoaded = false;
    }
    else
    {
      this.BuildBattleState();
      this.saveRequired = true;
    }
  }

  private void CampaignFinal() => this.CheckSave();

  private void CheckSave()
  {
    if (!this.saveRequired || this.loading)
      return;
    if (Campaign.Data.GameMode.doSave)
      this.Save();
    global::Events.InvokeBattleSaved();
    global::Events.InvokeCampaignSaved();
    this.saveRequired = false;
  }

  [Button(null, EButtonEnableMode.Always)]
  private void Save()
  {
    if (this.state == null)
    {
      Debug.LogWarning((object) "Cannot save Battle State right now!");
    }
    else
    {
      Debug.Log((object) "> Saving Battle State...");
      SaveSystem.SaveCampaignData<BattleSaveData>(Campaign.Data.GameMode, "battleState", this.state);
    }
  }

  private void BuildBattleState()
  {
    global::Events.InvokeBattleStateBuild();
    StopWatch.Start();
    if (!this.campaignNodeIdSet)
      this.campaignNodeId = Campaign.FindCharacterNode(References.Battle.player).id;
    this.state = new BattleSaveData()
    {
      gold = References.PlayerData.inventory.gold.Value + References.PlayerData.inventory.goldOwed,
      campaignNodeId = this.campaignNodeId,
      turnCount = References.Battle.turnCount + 1,
      statuses = StatusEffectSystem.activeEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => (bool) (UnityEngine.Object) e && e.count > e.temporary && (bool) (UnityEngine.Object) e.target && e.target.alive)).Select<StatusEffectData, BattleSaveData.Status>((Func<StatusEffectData, BattleSaveData.Status>) (e => new BattleSaveData.Status(e))).ToArray<BattleSaveData.Status>()
    };
    foreach (StatusEffectData activeEffect in StatusEffectSystem.activeEffects)
    {
      object midBattleData = activeEffect.GetMidBattleData();
      if (midBattleData != null)
        this.state.storeStatusData[string.Format("{0}{1}", (object) activeEffect.target.data.id, (object) activeEffect.name)] = midBattleData;
    }
    RedrawBellSystem objectOfType1 = UnityEngine.Object.FindObjectOfType<RedrawBellSystem>();
    if (objectOfType1 != null)
      this.state.redrawBellCount = objectOfType1.counter.current;
    WaveDeploySystemOverflow objectOfType2 = UnityEngine.Object.FindObjectOfType<WaveDeploySystemOverflow>();
    if (objectOfType2 != null)
      this.state.enemyWaves = objectOfType2.Save();
    BattleMusicSystem objectOfType3 = UnityEngine.Object.FindObjectOfType<BattleMusicSystem>();
    if (objectOfType3 != null)
      this.state.battleMusicState = objectOfType3.Save();
    this.state.playerRows = new BattleSaveData.ContainerGroup((IEnumerable<CardContainer>) References.Battle.GetRows(References.Battle.player));
    this.state.enemyRows = new BattleSaveData.ContainerGroup((IEnumerable<CardContainer>) References.Battle.GetRows(References.Battle.enemy));
    this.state.playerHand = new BattleSaveData.Container(References.Battle.player.handContainer);
    this.state.playerDraw = new BattleSaveData.Container(References.Battle.player.drawContainer);
    this.state.playerDiscard = new BattleSaveData.Container(References.Battle.player.discardContainer);
    this.state.playerReserve = new BattleSaveData.Container(References.Battle.player.reserveContainer);
    this.state.enemyReserve = new BattleSaveData.Container(References.Battle.enemy.reserveContainer);
    Debug.Log((object) string.Format("> Battle State Built ({0}ms)", (object) StopWatch.Stop()));
    global::Events.InvokeBattleStateBuilt(this.state);
  }

  public bool TryLoadBattleState(CampaignNode campaignNode)
  {
    this.state = SaveSystem.LoadCampaignData<BattleSaveData>(Campaign.Data.GameMode, "battleState", (BattleSaveData) null);
    bool flag = this.state != null;
    if (flag && this.state.campaignNodeId != campaignNode.id)
    {
      this.state = (BattleSaveData) null;
      flag = false;
    }
    return flag;
  }

  public bool TryLoadBattleState(BattleSaveData state)
  {
    this.state = state;
    return state != null;
  }

  public IEnumerator LoadRoutine()
  {
    this.loading = true;
    References.Battle.loadMidBattle = true;
    References.Battle.turnCount = this.state.turnCount;
    References.PlayerData.inventory.gold.Value = this.state.gold;
    References.Player.entity.PromptUpdate();
    UnityEngine.Object.FindObjectOfType<BattleMusicSystem>()?.Load(this.state.battleMusicState);
    Routine.Clump clump = new Routine.Clump();
    CardSlotLane[] array1 = References.Battle.GetRows(References.Battle.player).Cast<CardSlotLane>().ToArray<CardSlotLane>();
    clump.Add(BattleSaveSystem.CreateCardsInRows((IReadOnlyList<CardSlotLane>) array1, (IReadOnlyList<BattleSaveData.Container>) this.state.playerRows.containers));
    CardSlotLane[] array2 = References.Battle.GetRows(References.Battle.enemy).Cast<CardSlotLane>().ToArray<CardSlotLane>();
    clump.Add(BattleSaveSystem.CreateCardsInRows((IReadOnlyList<CardSlotLane>) array2, (IReadOnlyList<BattleSaveData.Container>) this.state.enemyRows.containers));
    clump.Add(BattleSaveSystem.CreateCards(References.Battle.player.handContainer, (IReadOnlyList<BattleEntityData>) this.state.playerHand.cards));
    clump.Add(BattleSaveSystem.CreateCards(References.Battle.player.drawContainer, (IReadOnlyList<BattleEntityData>) this.state.playerDraw.cards));
    clump.Add(BattleSaveSystem.CreateCards(References.Battle.player.discardContainer, (IReadOnlyList<BattleEntityData>) this.state.playerDiscard.cards));
    clump.Add(BattleSaveSystem.CreateCards(References.Battle.player.reserveContainer, (IReadOnlyList<BattleEntityData>) this.state.playerReserve.cards));
    clump.Add(BattleSaveSystem.CreateCards(References.Battle.enemy.reserveContainer, (IReadOnlyList<BattleEntityData>) this.state.enemyReserve.cards));
    yield return (object) clump.WaitForEnd();
    BattleSaveData.Status[] statusArray = this.state.statuses;
    for (int index = 0; index < statusArray.Length; ++index)
    {
      BattleSaveData.Status status = statusArray[index];
      Entity target = References.Battle.cards.FirstOrDefault<Entity>((Func<Entity, bool>) (a => (long) a.data.id == (long) status.targetId));
      if (!(bool) (UnityEngine.Object) target)
      {
        Debug.LogError((object) string.Format("No Entity[{0}] found for Status ({1} {2})", (object) status.targetId, (object) status.name, (object) status.count));
      }
      else
      {
        target.display.promptUpdateDescription = true;
        Entity applier = References.Battle.cards.FirstOrDefault<Entity>((Func<Entity, bool>) (a => (long) a.data.id == (long) status.applierId));
        StatusEffectData effectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", status.name);
        yield return (object) StatusEffectSystem.Apply(target, applier, effectData, status.count, fireEvents: false);
      }
    }
    statusArray = (BattleSaveData.Status[]) null;
    foreach (Entity card in References.Battle.cards.ToList<Entity>())
      yield return (object) BattleSaveSystem.UpdateCard(card, (IReadOnlyDictionary<string, object>) this.state.storeStatusData);
    UnityEngine.Object.FindObjectOfType<WaveDeploySystemOverflow>()?.Load(this.state.enemyWaves, (IReadOnlyCollection<CardData>) References.Battle.cards.Select<Entity, CardData>((Func<Entity, CardData>) (a => a.data)).ToArray<CardData>());
    RedrawBellSystem objectOfType = UnityEngine.Object.FindObjectOfType<RedrawBellSystem>();
    if (objectOfType != null)
    {
      objectOfType.BecomeInteractable();
      objectOfType.SetCounter(this.state.redrawBellCount);
    }
    global::Events.InvokeBattleLoaded();
    this.justLoaded = true;
    this.loading = false;
  }

  private static IEnumerator CreateCardsInRows(
    IReadOnlyList<CardSlotLane> rows,
    IReadOnlyList<BattleSaveData.Container> rowSaveDatas)
  {
    Dictionary<ulong, Entity> entities = new Dictionary<ulong, Entity>();
    CardController cardController = References.Battle.playerCardController;
    Routine.Clump clump = new Routine.Clump();
    for (int rowI = 0; rowI < rows.Count; ++rowI)
    {
      CardSlotLane row = rows[rowI];
      BattleEntityData[] cards = rowSaveDatas[rowI].cards;
      for (int index = 0; index < cards.Length; ++index)
      {
        BattleEntityData d = cards[index];
        if (d != null)
        {
          if (!entities.ContainsKey(d.cardSaveData.id))
          {
            entities.Add(d.cardSaveData.id, (Entity) null);
            int entityIndex = index;
            clump.Add(BattleSaveSystem.CreateCard(d, cardController, row.owner, (UnityAction<Card>) (a =>
            {
              entities[d.cardSaveData.id] = a.entity;
              row.slots[entityIndex].Add(a.entity);
            })));
          }
          else
            row.slots[index].Add(entities[d.cardSaveData.id]);
        }
      }
      yield return (object) clump.WaitForEnd();
    }
    foreach (Entity child in entities.Values)
      child.containers[0].TweenChildPosition(child);
  }

  private static IEnumerator CreateCards(
    CardContainer container,
    IReadOnlyList<BattleEntityData> entitySaveData)
  {
    Character owner = container.owner;
    CardController playerCardController = References.Battle.playerCardController;
    Routine.Clump clump = new Routine.Clump();
    Entity[] entities = new Entity[entitySaveData.Count];
    for (int index = 0; index < entitySaveData.Count; ++index)
    {
      BattleEntityData entityData = entitySaveData[index];
      if (entityData != null)
      {
        int arrayIndex = index;
        clump.Add(BattleSaveSystem.CreateCard(entityData, playerCardController, owner, (UnityAction<Card>) (a => entities[arrayIndex] = a.entity)));
      }
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity entity in entities)
      container.Add(entity);
    container.SetChildPositions();
  }

  private static IEnumerator CreateCard(
    BattleEntityData entityData,
    CardController cardController,
    Character owner,
    UnityAction<Card> onComplete)
  {
    Card card = CardManager.Get(entityData.cardSaveData.Load(), cardController, owner, true, owner.team == References.Player.team);
    Entity entity = card.entity;
    entity.startingEffectsApplied = true;
    entity.alive = false;
    if (entityData.flipped)
      entity.flipper.FlipDownInstant();
    entity.attackEffects = ((IEnumerable<StatusEffectSaveData>) entityData.attackEffects).Select<StatusEffectSaveData, CardData.StatusEffectStacks>((Func<StatusEffectSaveData, CardData.StatusEffectStacks>) (e => e.Load())).ToList<CardData.StatusEffectStacks>();
    entity.traits.Clear();
    foreach (CardData.TraitStacks trait in entity.data.traits)
      entity.traits.Add(new Entity.TraitStacks(trait.data, trait.count));
    UnityAction<Card> unityAction = onComplete;
    if (unityAction != null)
      unityAction(card);
    if (!entityData.flipped)
      entity.enabled = true;
    yield return (object) card.UpdateData(false);
    entity.height = entityData.height;
    entity.damage.current = entityData.damage;
    entity.damage.max = entityData.damageMax;
    entity.hp.current = entityData.hp;
    entity.hp.max = entityData.hpMax;
    entity.counter.current = entityData.counter;
    entity.counter.max = entityData.counterMax;
    entity.uses.current = entityData.uses;
    entity.uses.max = entityData.usesMax;
  }

  private static IEnumerator UpdateCard(
    Entity card,
    IReadOnlyDictionary<string, object> customDatas)
  {
    card.alive = true;
    yield return (object) card.UpdateTraits();
    if (customDatas != null)
    {
      foreach (StatusEffectData statusEffect in card.statusEffects)
      {
        object data;
        if (customDatas.TryGetValue(string.Format("{0}{1}", (object) card.data.id, (object) statusEffect.name), out data))
          statusEffect.RestoreMidBattleData(data);
      }
    }
    if (card.enabled)
    {
      global::Events.InvokeEntityEnabled(card);
      yield return (object) StatusEffectSystem.EntityEnableEvent(card);
    }
    else
      CoroutineManager.Start(card.display.UpdateDisplay());
    card.PromptUpdate();
  }
}
