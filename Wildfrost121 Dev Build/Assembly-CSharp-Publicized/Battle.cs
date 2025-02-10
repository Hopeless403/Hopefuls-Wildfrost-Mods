// Decompiled with JetBrains decompiler
// Type: Battle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;

#nullable disable
public class Battle : SceneRoutine
{
  public static Battle instance;
  public Character player;
  public Character enemy;
  public Character winner;
  public readonly List<Entity> minibosses = new List<Entity>();
  public Battle.Phase _phase;
  public Transform outOfUseCardsGroup;
  public CardController playerCardController;
  public readonly Dictionary<Character, List<CardContainer>> rows = new Dictionary<Character, List<CardContainer>>();
  public readonly Dictionary<CardContainer, int> rowIndices = new Dictionary<CardContainer, int>();
  public List<Entity> cards = new List<Entity>();
  public float startDelay = 1f;
  public bool canEnd = true;
  public int rowCount;
  public int turnCount;
  public bool cancelTurn;
  public bool auto;
  public bool loadMidBattle;

  public void Awake()
  {
    Battle.instance = this;
    References.Battle = this;
  }

  public int playerMinibossCount
  {
    get
    {
      return this.minibosses.Count<Entity>((Func<Entity, bool>) (a => (bool) (UnityEngine.Object) a && (UnityEngine.Object) a.owner == (UnityEngine.Object) this.player));
    }
  }

  public int enemyMinibossCount
  {
    get
    {
      return this.minibosses.Count<Entity>((Func<Entity, bool>) (a => (bool) (UnityEngine.Object) a && (UnityEngine.Object) a.owner == (UnityEngine.Object) this.enemy));
    }
  }

  public Battle.Phase phase
  {
    get => this._phase;
    set
    {
      if (this._phase == value || this.ended)
        return;
      Debug.Log((object) string.Format("Battle Phase: {0}", (object) value));
      global::Events.InvokeBattlePhaseStart(value);
      this._phase = value;
    }
  }

  public IEnumerable<CardSlotLane> allRows
  {
    get
    {
      return this.rows.Values.SelectMany<List<CardContainer>, CardContainer>((Func<List<CardContainer>, IEnumerable<CardContainer>>) (a => (IEnumerable<CardContainer>) a)).Cast<CardSlotLane>();
    }
  }

  public IEnumerable<CardSlot> allSlots
  {
    get
    {
      return this.allRows.SelectMany<CardSlotLane, CardSlot>((Func<CardSlotLane, IEnumerable<CardSlot>>) (a => (IEnumerable<CardSlot>) a.slots));
    }
  }

  public bool ended => this.phase == Battle.Phase.End;

  [Button("Win", EButtonEnableMode.Always)]
  public void PlayerWin()
  {
    this.winner = this.player;
    this.phase = Battle.Phase.End;
  }

  [Button("Lose", EButtonEnableMode.Always)]
  public void EnemyWin()
  {
    this.winner = this.enemy;
    this.phase = Battle.Phase.End;
  }

  public void Start()
  {
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityDestroyed);
  }

  public void OnDestroy()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityDestroyed);
  }

  public void EntityCreated(Entity entity)
  {
    if (entity.data.cardType.miniboss)
      this.minibosses.Add(entity);
    this.cards.Add(entity);
  }

  public void CancelTurn() => this.cancelTurn = true;

  public void EntityDestroyed(Entity entity) => this.EntityKilled(entity, DeathType.Normal);

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (this.minibosses.Remove(entity) && this.phase != Battle.Phase.LastStand)
      this.CheckEnd();
    this.cards.Remove(entity);
  }

  public bool CheckEnd()
  {
    if (!this.canEnd)
      return false;
    if (this.playerMinibossCount <= 0)
    {
      this.winner = this.enemy;
      this.phase = Battle.Phase.End;
      return true;
    }
    if (this.enemyMinibossCount > 0)
      return false;
    this.winner = this.player;
    this.phase = Battle.Phase.End;
    return true;
  }

  public static Character GetOpponent(Character character)
  {
    if ((UnityEngine.Object) character == (UnityEngine.Object) Battle.instance.enemy)
      return Battle.instance.player;
    return !((UnityEngine.Object) character == (UnityEngine.Object) Battle.instance.player) ? (Character) null : Battle.instance.enemy;
  }

  public int GetRowIndex(CardContainer rowContainer)
  {
    return !(bool) (UnityEngine.Object) rowContainer || !(bool) (UnityEngine.Object) rowContainer.owner ? -1 : this.rows[rowContainer.owner].IndexOf(rowContainer);
  }

  public int[] GetRowIndices(Entity entity)
  {
    List<int> toRelease = GenericPool<List<int>>.Get();
    toRelease.Clear();
    if ((bool) (UnityEngine.Object) entity.owner)
    {
      List<CardContainer> row = this.rows[entity.owner];
      for (int index = 0; index < this.rowCount; ++index)
      {
        if (row[index].Contains(entity))
          toRelease.Add(index);
      }
    }
    int[] array = toRelease.ToArray();
    GenericPool<List<int>>.Release(toRelease);
    return array;
  }

  public int[] GetRowIndices(IEnumerable<CardContainer> containers)
  {
    HashSet<int> intSet = GenericPool<HashSet<int>>.Get();
    intSet.Clear();
    foreach (CardContainer container in containers)
    {
      int num;
      if (this.rowIndices.TryGetValue(container, out num))
        intSet.Add(num);
    }
    int[] array = intSet.ToArray<int>();
    GenericPool<HashSet<int>>.Release(intSet);
    return array;
  }

  public CardContainer GetRow(Character owner, int rowIndex) => this.rows[owner][rowIndex];

  public List<CardContainer> GetRows(Character owner)
  {
    List<CardContainer> row = this.rows[owner];
    List<CardContainer> rows = new List<CardContainer>();
    foreach (CardContainer cardContainer in row)
      rows.Add(cardContainer);
    return rows;
  }

  public CardSlotLane GetOppositeRow(CardSlotLane row)
  {
    int rowIndex = this.GetRowIndex((CardContainer) row);
    if (rowIndex >= 0)
    {
      Character opponent = Battle.GetOpponent(row.owner);
      if ((bool) (UnityEngine.Object) opponent && this.GetRow(opponent, rowIndex) is CardSlotLane row1)
        return row1;
    }
    return (CardSlotLane) null;
  }

  public CardContainer[] GetOppositeRows(CardContainer[] rows)
  {
    CardContainer[] oppositeRows = new CardContainer[rows.Length];
    int num = 0;
    Character owner = (Character) null;
    foreach (CardContainer row1 in rows)
    {
      int rowIndex = this.GetRowIndex(row1);
      if (rowIndex >= 0)
      {
        if (owner == null)
          owner = Battle.GetOpponent(row1.owner);
        if ((bool) (UnityEngine.Object) owner)
        {
          CardContainer row2 = this.GetRow(owner, rowIndex);
          if (row2 != null)
            oppositeRows[num++] = row2;
        }
      }
    }
    return oppositeRows;
  }

  public List<CardSlot> GetSlots()
  {
    List<CardSlot> slots = new List<CardSlot>();
    foreach (CardContainer cardContainer in this.rows.Values.SelectMany<List<CardContainer>, CardContainer>((Func<List<CardContainer>, IEnumerable<CardContainer>>) (a => (IEnumerable<CardContainer>) a)))
    {
      if (cardContainer is CardSlotLane cardSlotLane)
        slots.AddRange((IEnumerable<CardSlot>) cardSlotLane.slots);
    }
    return slots;
  }

  public List<CardSlot> GetSlots(Character owner)
  {
    List<CardContainer> row = this.rows[owner];
    List<CardSlot> slots = new List<CardSlot>();
    foreach (CardContainer cardContainer in row)
    {
      if (cardContainer is CardSlotLane cardSlotLane)
        slots.AddRange((IEnumerable<CardSlot>) cardSlotLane.slots);
    }
    return slots;
  }

  public static List<Entity> GetCards(Character character)
  {
    List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(character);
    List<CardContainer> list = new List<CardContainer>();
    list.AddIfNotNull<CardContainer>(character.reserveContainer);
    list.AddIfNotNull<CardContainer>(character.handContainer);
    list.AddIfNotNull<CardContainer>(character.drawContainer);
    list.AddIfNotNull<CardContainer>(character.discardContainer);
    foreach (CardContainer cardContainer in list)
    {
      foreach (Entity entity in cardContainer)
        cardsOnBoard.Add(entity);
    }
    return cardsOnBoard;
  }

  public static List<Entity> GetAllCards()
  {
    List<Entity> allCards = new List<Entity>();
    allCards.AddRange((IEnumerable<Entity>) Battle.GetCards(Battle.instance.player));
    allCards.AddRange((IEnumerable<Entity>) Battle.GetCards(Battle.instance.enemy));
    return allCards;
  }

  public static List<Entity> GetCardsOnBoard()
  {
    List<Entity> cardsOnBoard = new List<Entity>();
    cardsOnBoard.AddRange((IEnumerable<Entity>) Battle.GetCardsOnBoard(Battle.instance.player));
    cardsOnBoard.AddRange((IEnumerable<Entity>) Battle.GetCardsOnBoard(Battle.instance.enemy));
    return cardsOnBoard;
  }

  public static List<Entity> GetCardsOnBoard(Character character)
  {
    List<Entity> cardsOnBoard = new List<Entity>();
    int num1 = 2;
    int num2 = 3;
    for (int index = 0; index < num2; ++index)
    {
      for (int rowIndex = 0; rowIndex < num1; ++rowIndex)
      {
        if (Battle.instance.GetRow(character, rowIndex) is CardSlotLane row)
        {
          Entity top = row.slots[index].GetTop();
          if (top != null && !cardsOnBoard.Contains(top))
            cardsOnBoard.Add(top);
        }
      }
    }
    return cardsOnBoard;
  }

  public static bool IsOnBoard(Entity entity)
  {
    if (entity.containers.Length != 0)
      return Battle.IsOnBoard(entity.containers);
    return !entity.alive && entity.preContainers != null && Battle.IsOnBoard(entity.preContainers);
  }

  public static bool IsOnBoard(CardContainer[] containers)
  {
    foreach (CardContainer container in containers)
    {
      if (Battle.instance.GetRowIndex(container.Group) >= 0)
        return true;
    }
    return false;
  }

  public static bool IsOnBoard(CardContainer container)
  {
    return Battle.instance.GetRowIndex(container) >= 0;
  }

  public override IEnumerator Run()
  {
    CampaignNode node = Campaign.FindCharacterNode(this.player);
    NavigationState.Start((INavigationState) new NavigationStateBattle());
    NavigationState.Start((INavigationState) new NavigationStateWait());
    if (!this.loadMidBattle)
    {
      this.phase = Battle.Phase.Init;
      yield return (object) Sequences.Wait(this.startDelay);
      yield return (object) ActionQueue.Wait();
      Debug.Log((object) "BATTLE START!");
      global::Events.InvokeBattleStart();
      yield return (object) this.DrawChampions(this.player, this.player.drawContainer, this.player.handContainer);
      Battle.SetSeed(node.seed - 9999, 0);
      NavigationState.BackToPreviousState();
      yield return (object) this.WaitForChampionsToDeploy(this.player, this.playerCardController, this.player.handContainer);
      NavigationState.Start((INavigationState) new NavigationStateWait());
      global::Events.InvokeBattleTurnEnd(this.turnCount);
      ActionQueue.Add((PlayAction) new ActionDraw(this.player, this.player.handContainer.max));
      yield return (object) ActionQueue.Wait();
    }
    yield return (object) this.BattleLoop(node);
    Debug.Log((object) "BATTLE END!");
    global::Events.InvokeBattleEnd();
    NavigationState.Reset();
    if ((bool) (UnityEngine.Object) this.playerCardController)
      this.playerCardController.Disable();
    List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(Battle.GetOpponent(this.winner));
    if (cardsOnBoard.Count > 0)
    {
      Debug.Log((object) string.Format("[{0}] Cards To Flee!", (object) cardsOnBoard.Count));
      foreach (Entity entity in cardsOnBoard)
        ActionQueue.Stack((PlayAction) new ActionFlee(entity));
      yield return (object) ActionQueue.Wait();
    }
    yield return (object) global::Events.InvokePreBattleEnd();
    if (Campaign.CheckVictory() || (UnityEngine.Object) this.winner != (UnityEngine.Object) this.player)
    {
      if ((UnityEngine.Object) this.winner != (UnityEngine.Object) this.player)
      {
        if (Settings.Load<bool>("showJournalNameOnEnd", false))
          yield return (object) JournalVoidNameSequence.LoadAndRun(true);
        else
          JournalNameHistory.MostRecentNameKilled();
      }
      yield return (object) SceneManager.Load("CampaignEnd", SceneType.Temporary);
      yield return (object) SceneManager.WaitUntilUnloaded("CampaignEnd");
    }
    else if ((UnityEngine.Object) this.winner == (UnityEngine.Object) this.player)
    {
      global::Events.InvokeBattleWinPreRewards();
      yield return (object) ActionQueue.Wait();
      if (node.data.ContainsKey("rewards"))
      {
        yield return (object) SceneManager.Load("BossReward", SceneType.Temporary);
        yield return (object) SceneManager.WaitUntilUnloaded("BossReward");
      }
      global::Events.InvokeBattleWin();
      yield return (object) ActionQueue.Wait();
      yield return (object) SceneManager.Load("BattleWin", SceneType.Temporary);
      yield return (object) UnityEngine.Object.FindObjectOfType<BattleVictorySequence>().Run();
    }
  }

  public IEnumerator BattleLoop(CampaignNode node)
  {
    while (!this.ended)
    {
      if (Deckpack.IsOpen)
        yield return (object) Battle.WaitForDeckpack();
      yield return (object) this.UpdateBoard(this.enemy);
      if (Deckpack.IsOpen)
        yield return (object) Battle.WaitForDeckpack();
      yield return (object) this.UpdateBoard(this.player);
      if (Deckpack.IsOpen)
        yield return (object) Battle.WaitForDeckpack();
      yield return (object) this.UpdateContainer(this.player.handContainer);
      if (!this.ended)
      {
        Battle.SetSeed(node.seed, this.turnCount);
        if (!this.auto)
        {
          this.cancelTurn = false;
          this.phase = Battle.Phase.Play;
        }
        yield return (object) ActionQueue.Wait();
        global::Events.InvokeBattlePreTurnStart(this.turnCount);
        ++this.turnCount;
        NavigationState.BackToPreviousState();
        if (!this.auto)
        {
          this.playerCardController.Enable();
          yield return (object) this.WaitForTurnEnd(this.player, this.playerCardController);
        }
        NavigationState.Start((INavigationState) new NavigationStateWait());
        global::Events.InvokeBattleTurnStart(this.turnCount);
        if (Deckpack.IsOpen)
          yield return (object) Battle.WaitForDeckpack();
        this.phase = Battle.Phase.Battle;
        if (!this.auto)
          yield return (object) Sequences.Wait(0.5f);
        yield return (object) this.CheckUnitsTakeTurns();
        yield return (object) ActionQueue.Wait();
        yield return (object) this.ProcessHandStart(this.player);
        if (!this.ended)
        {
          yield return (object) this.CheckUnitsTakeTurns();
          yield return (object) this.ProcessUnits(this.enemy);
          yield return (object) this.ProcessUnits(this.player);
          yield return (object) this.CheckUnitsTakeTurns();
          yield return (object) this.ProcessUnitTurnEnd();
          yield return (object) this.CheckUnitsTakeTurns();
          yield return (object) this.ProcessHandEnd(this.player);
          yield return (object) this.CheckUnitsTakeTurns();
        }
        yield return (object) this.CheckUnitsTakeTurns();
        global::Events.InvokeBattleTurnEnd(this.turnCount);
      }
    }
  }

  public static void SetSeed(int baseSeed, int offset)
  {
    Debug.Log((object) string.Format("Battle Setting Seed: {0} Offset: {1}", (object) baseSeed, (object) offset));
    UnityEngine.Random.InitState(baseSeed);
    for (int index = 0; index < offset; ++index)
    {
      double num = (double) UnityEngine.Random.Range(0.0f, 1f);
    }
  }

  public static IEnumerator WaitForDeckpack()
  {
    yield return (object) new WaitUntil((Func<bool>) (() => !Deckpack.IsOpen));
    yield return (object) new WaitForSeconds(0.5f);
  }

  public IEnumerator WaitForTurnEnd(Character character, CardController cardController)
  {
    while (!this.ended && !this.auto)
    {
      yield return (object) ActionQueue.Wait();
      if (character.endTurn)
      {
        if (!character.freeAction)
          this.phase = Battle.Phase.Battle;
        yield return (object) this.CheckUnitsTakeTurns(this.enemy);
        yield return (object) this.CheckUnitsTakeTurns(this.player);
        yield return (object) this.UpdateBoard(this.enemy);
        yield return (object) this.UpdateBoard(this.player);
        global::Events.InvokeCharacterActionPerformed(character);
        if (character.freeAction)
        {
          character.freeAction = false;
          character.endTurn = false;
          cardController.Enable();
          character.handContainer.TweenChildPositions();
          this.phase = Battle.Phase.Play;
        }
        else
        {
          character.endTurn = false;
          break;
        }
      }
      yield return (object) ActionQueue.Wait();
    }
    cardController.Disable();
  }

  public IEnumerator DrawChampions(
    Character character,
    CardContainer fromContainer,
    CardContainer toContainer)
  {
    Battle battle = this;
    float pauseBetween = 0.1f;
    for (int i = fromContainer.Count - 1; i >= 0; --i)
    {
      Entity entity = fromContainer[i];
      if (entity.data.HasCrown)
      {
        if ((bool) (UnityEngine.Object) entity)
        {
          battle.StartCoroutine(Sequences.CardMove(entity, new CardContainer[1]
          {
            toContainer
          }));
          toContainer.TweenChildPositions();
        }
        yield return (object) Sequences.Wait(pauseBetween);
      }
    }
    ActionQueue.Stack((PlayAction) new ActionRevealAll(new CardContainer[1]
    {
      toContainer
    }));
    yield return (object) ActionQueue.Wait();
  }

  public IEnumerator WaitForChampionsToDeploy(
    Character character,
    CardController cardController,
    CardContainer handContainer)
  {
    if (Battle.CrownCardsInContainer(handContainer) > 0)
    {
      cardController.Enable();
      while (!this.ended)
      {
        if (character.endTurn)
        {
          yield return (object) null;
          character.endTurn = false;
          Routine.Clump clump = new Routine.Clump();
          clump.Add(this.UpdateBoard(this.enemy));
          clump.Add(this.UpdateBoard(this.player));
          clump.Add(this.UpdateContainer(this.player.handContainer));
          yield return (object) clump.WaitForEnd();
          if (Battle.CrownCardsInContainer(handContainer) > 0)
            cardController.Enable();
          else
            break;
        }
        yield return (object) null;
      }
      character.freeAction = false;
    }
  }

  public static int CrownCardsInContainer(CardContainer container)
  {
    return container.Count<Entity>((Func<Entity, bool>) (a => a.data.HasCrown));
  }

  public IEnumerator UpdateBoard(Character character)
  {
    float seconds = 0.0f;
    foreach (CardContainer row in this.GetRows(character))
    {
      row.MoveChildrenForward();
      row.TweenChildPositions();
    }
    yield return (object) Sequences.Wait(seconds);
  }

  public bool CanDeploy(Entity entity, int targetRow, out int targetColumn)
  {
    targetColumn = 0;
    bool flag1 = false;
    List<CardContainer> rows = this.GetRows(entity.owner);
    int a = int.MaxValue;
    foreach (CardContainer cardContainer in rows)
      a = Mathf.Min(a, cardContainer.max);
    if (entity.positionPriority >= 0)
    {
      for (int index1 = 0; index1 < a; ++index1)
      {
        bool flag2 = false;
        for (int index2 = 0; index2 < entity.height; ++index2)
        {
          CardContainer cardContainer = rows[(targetRow + index2) % rows.Count];
          if (cardContainer is CardSlotLane cardSlotLane && cardContainer.canBePlacedOn)
          {
            CardSlot slot = cardSlotLane.slots[index1];
            if (slot.canBePlacedOn)
            {
              Entity top1 = slot.GetTop();
              if ((UnityEngine.Object) top1 == (UnityEngine.Object) null)
                flag2 = true;
              else if ((top1.positionPriority < entity.positionPriority || entity.positionPriority > 1 && top1.positionPriority <= entity.positionPriority) && Battle.CanPushBack(top1))
              {
                bool flag3 = true;
                for (int index3 = index1 + 1; index3 < cardSlotLane.max; ++index3)
                {
                  Entity top2 = cardSlotLane.slots[index3].GetTop();
                  if ((bool) (UnityEngine.Object) top2 && top2.positionPriority >= entity.positionPriority)
                  {
                    flag3 = false;
                    break;
                  }
                }
                if (flag3)
                  flag2 = true;
              }
            }
          }
        }
        if (flag2)
        {
          flag1 = true;
          targetColumn = index1;
          break;
        }
      }
    }
    else
    {
      for (int index4 = a - 1; index4 >= 0; --index4)
      {
        bool flag4 = true;
        for (int index5 = 0; index5 < entity.height; ++index5)
        {
          if (rows[(targetRow + index5) % rows.Count] is CardSlotLane cardSlotLane)
          {
            Entity top = cardSlotLane.slots[index4].GetTop();
            if ((bool) (UnityEngine.Object) top && (top.positionPriority > entity.positionPriority || !Battle.CanPushForwards(top)))
              flag4 = false;
          }
        }
        if (flag4)
        {
          flag1 = true;
          targetColumn = index4;
          break;
        }
      }
    }
    return flag1;
  }

  public static bool CanPushBack(Entity entity)
  {
    bool flag = true;
    foreach (CardContainer container in entity.containers)
    {
      if (container is CardSlotLane cardSlotLane)
      {
        int index = cardSlotLane.IndexOf(entity) + 1;
        CardSlot slot = index < cardSlotLane.max ? cardSlotLane.slots[index] : (CardSlot) null;
        if ((UnityEngine.Object) slot == (UnityEngine.Object) null)
        {
          flag = false;
          break;
        }
        Entity top = slot.GetTop();
        if ((bool) (UnityEngine.Object) top && !Battle.CanPushBack(top))
        {
          flag = false;
          break;
        }
      }
    }
    return flag;
  }

  public static bool CanPushForwards(Entity entity)
  {
    bool flag = true;
    foreach (CardContainer container in entity.containers)
    {
      if (container is CardSlotLane cardSlotLane)
      {
        int index = cardSlotLane.IndexOf(entity) - 1;
        CardSlot slot = index >= 0 ? cardSlotLane.slots[index] : (CardSlot) null;
        if ((UnityEngine.Object) slot == (UnityEngine.Object) null || !slot.Empty)
        {
          flag = false;
          break;
        }
      }
    }
    return flag;
  }

  public IEnumerator UpdateContainer(CardContainer container)
  {
    float seconds = 0.0f;
    container.TweenChildPositions();
    yield return (object) Sequences.Wait(seconds);
  }

  public IEnumerator CheckUnitsTakeTurns()
  {
    if (!this.cancelTurn)
    {
      yield return (object) this.CheckUnitsTakeTurns(this.enemy);
      if (!this.cancelTurn)
        yield return (object) this.CheckUnitsTakeTurns(this.player);
    }
  }

  public IEnumerator CheckUnitsTakeTurns(Character character)
  {
    float pauseAfter = 0.167f;
    List<CardContainer> rows = this.GetRows(character);
    List<Entity> entityList = new List<Entity>();
    foreach (CardContainer cardContainer in rows)
    {
      for (int index = 0; index < cardContainer.Count; ++index)
        entityList.Add(cardContainer[index]);
    }
    foreach (Entity entity in entityList)
    {
      Entity unit = entity;
      if (!this.cancelTurn)
      {
        if (unit.counter.current <= 0 && unit.counter.max > 0 && !unit.IsSnowed && unit.alive && unit.owner.autoTriggerUnits)
        {
          ActionTriggerByCounter triggerAction = new ActionTriggerByCounter(unit, unit);
          if (Deckpack.IsOpen)
            yield return (object) Battle.WaitForDeckpack();
          if (global::Events.CheckAction((PlayAction) triggerAction))
          {
            ActionQueue.Add((PlayAction) triggerAction);
            yield return (object) ActionQueue.Wait();
            yield return (object) Sequences.Wait(pauseAfter);
          }
          unit.counter.current = unit.counter.max;
          unit.PromptUpdate();
          triggerAction = (ActionTriggerByCounter) null;
        }
        unit = (Entity) null;
      }
      else
        break;
    }
  }

  public IEnumerator ProcessUnits(Character character)
  {
    List<Entity> processed = new List<Entity>();
    global::Events.InvokePreProcessUnits(character);
label_1:
    bool dirty = false;
    List<Entity> list = Battle.GetAllUnits(character).ToList<Entity>();
    list.RemoveMany<Entity>((ICollection<Entity>) processed);
    Dictionary<Entity, CardContainer[]> positions = list.ToDictionary<Entity, Entity, CardContainer[]>((Func<Entity, Entity>) (e => e), (Func<Entity, CardContainer[]>) (e => e.actualContainers.ToArray()));
    foreach (Entity entity1 in list)
    {
      Entity entity = entity1;
      if (!entity.IsAliveAndExists())
      {
        dirty = true;
        Debug.Log((object) "BATTLE PROCESS LIST DIRTIED! An entity in the list no longer exists");
        break;
      }
      CardContainer[] array = entity.actualContainers.ToArray();
      if (!positions.ContainsKey(entity) || !((IList<CardContainer>) positions[entity]).ContainsAll<CardContainer>((IEnumerable<CardContainer>) array))
      {
        dirty = true;
        Debug.Log((object) string.Format("BATTLE PROCESS LIST DIRTIED! [{0}] was expected at [{1}], but was actually at [{2}]", (object) entity.name, (object) positions[entity], (object) array));
        break;
      }
      if (this.minibosses.Count<Entity>((Func<Entity, bool>) (a => a.owner.team == entity.owner.team)) <= 0)
      {
        Debug.Log((object) (entity.name + "'s Leader No Longer Exists! Skipping Processing..."));
      }
      else
      {
        yield return (object) this.ProcessUnit(entity);
        processed.Add(entity);
        if (!this.cancelTurn)
          ;
        else
          break;
      }
    }
    positions = (Dictionary<Entity, CardContainer[]>) null;
    if (!dirty || this.cancelTurn)
      global::Events.InvokePostProcessUnits(character);
    else
      goto label_1;
  }

  public static HashSet<Entity> GetAllUnits(Character character)
  {
    HashSet<Entity> list = new HashSet<Entity>();
    list.AddRange<Entity>((IEnumerable<Entity>) Battle.GetCardsOnBoard(character));
    if ((bool) (UnityEngine.Object) character.entity && character.entity.alive && character.entity.canBeHit)
      list.Add(character.entity);
    return list;
  }

  public static HashSet<Entity> GetAllUnits()
  {
    HashSet<Entity> list = new HashSet<Entity>();
    Character[] characterArray = new Character[2]
    {
      Battle.instance.enemy,
      Battle.instance.player
    };
    foreach (Character character in characterArray)
      list.AddRange<Entity>((IEnumerable<Entity>) Battle.GetAllUnits(character));
    return list;
  }

  public IEnumerator ProcessUnit(Entity unit)
  {
    float pauseAfter = 0.133f;
    if (Deckpack.IsOpen)
      yield return (object) Battle.WaitForDeckpack();
    bool snowed = unit.IsSnowed;
    yield return (object) StatusEffectSystem.TurnStartEvent(unit);
    if (unit.counter.max > 0 | snowed && unit.alive)
    {
      yield return (object) Battle.CardCountDown(unit);
      if (unit.counter.current <= 0 && unit.counter.max > 0 && !snowed && unit.owner.autoTriggerUnits)
      {
        ActionTriggerByCounter action = new ActionTriggerByCounter(unit, unit);
        if (global::Events.CheckAction((PlayAction) action))
        {
          ActionQueue.Add((PlayAction) action);
          yield return (object) ActionQueue.Wait();
          if (this.cancelTurn)
            yield break;
        }
        unit.counter.current = unit.counter.max;
        unit.PromptUpdate();
      }
      Routine.Clump clump = new Routine.Clump();
      clump.Add(StatusEffectSystem.TurnEvent(unit));
      clump.Add(Sequences.Wait(pauseAfter));
      yield return (object) clump.WaitForEnd();
    }
    else
      yield return (object) StatusEffectSystem.TurnEvent(unit);
    if (StatusEffectSystem.EventsRunning)
      yield return (object) Sequences.WaitForStatusEffectEvents();
  }

  public IEnumerator ProcessHandStart(Character character)
  {
    if (!this.cancelTurn)
    {
      Entity entity;
      foreach (Entity entity1 in character.handContainer)
      {
        entity = entity1;
        if (Deckpack.IsOpen)
          yield return (object) Battle.WaitForDeckpack();
        yield return (object) StatusEffectSystem.TurnStartEvent(entity);
        if (!this.cancelTurn)
          entity = (Entity) null;
        else
          break;
      }
      foreach (Entity entity2 in character.handContainer)
      {
        entity = entity2;
        if (Deckpack.IsOpen)
          yield return (object) Battle.WaitForDeckpack();
        yield return (object) StatusEffectSystem.TurnEvent(entity);
        if (!this.cancelTurn)
          entity = (Entity) null;
        else
          break;
      }
    }
  }

  public IEnumerator ProcessHandEnd(Character character)
  {
    if (!this.cancelTurn)
    {
      foreach (Entity entity1 in character.handContainer)
      {
        Entity entity = entity1;
        if (Deckpack.IsOpen)
          yield return (object) Battle.WaitForDeckpack();
        yield return (object) StatusEffectSystem.TurnEndEvent(entity);
        if (!this.cancelTurn)
          entity = (Entity) null;
        else
          break;
      }
    }
  }

  public IEnumerator ProcessUnitTurnEnd()
  {
    if (!this.cancelTurn)
    {
      HashSet<Entity> list = new HashSet<Entity>();
      Character[] characterArray = new Character[2]
      {
        this.enemy,
        this.player
      };
      foreach (Character character in characterArray)
      {
        list.AddRange<Entity>((IEnumerable<Entity>) Battle.GetCardsOnBoard(character));
        if ((bool) (UnityEngine.Object) character.entity && character.entity.alive)
          list.Add(character.entity);
      }
      foreach (Entity entity in list)
      {
        Entity unit = entity;
        if (Deckpack.IsOpen)
          yield return (object) Battle.WaitForDeckpack();
        ActionQueue.Stack((PlayAction) new ActionSequence(StatusEffectSystem.TurnEndEvent(unit)), true);
        yield return (object) ActionQueue.Wait();
        if (!this.cancelTurn)
          unit = (Entity) null;
        else
          break;
      }
    }
  }

  public static IEnumerator CardCountDown(Entity entity)
  {
    if (Deckpack.IsOpen)
      yield return (object) Battle.WaitForDeckpack();
    int amount = 1;
    global::Events.InvokeEntityCountDown(entity, ref amount);
    yield return (object) new Hit((Entity) null, entity)
    {
      counterReduction = amount,
      screenShake = 0.0f
    }.Process();
  }

  [CompilerGenerated]
  public bool \u003Cget_playerMinibossCount\u003Eb__8_0(Entity a)
  {
    return (bool) (UnityEngine.Object) a && (UnityEngine.Object) a.owner == (UnityEngine.Object) this.player;
  }

  [CompilerGenerated]
  public bool \u003Cget_enemyMinibossCount\u003Eb__10_0(Entity a)
  {
    return (bool) (UnityEngine.Object) a && (UnityEngine.Object) a.owner == (UnityEngine.Object) this.enemy;
  }

  public enum Phase
  {
    None,
    Init,
    Play,
    Battle,
    End,
    LastStand,
  }
}
