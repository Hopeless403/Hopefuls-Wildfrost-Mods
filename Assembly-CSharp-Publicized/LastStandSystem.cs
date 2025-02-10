// Decompiled with JetBrains decompiler
// Type: LastStandSystem
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
using UnityEngine.Events;

public class LastStandSystem : GameSystem
{
  [SerializeField]
  public StatusEffectData effect;
  [SerializeField]
  public StatusEffectData killEffect;
  [SerializeField]
  public Transform entityGroup;
  [SerializeField]
  public GameObject background;
  [SerializeField]
  public GameObject button;
  [SerializeField]
  public Dice playerDicePrefab;
  [SerializeField]
  public Dice enemyDicePrefab;
  [SerializeField]
  public Dice bossDicePrefab;
  [SerializeField]
  public Transform playerDiceGroup;
  [SerializeField]
  public Transform enemyDiceGroup;
  [SerializeField]
  public CardType[] legalCardTypes;
  [SerializeField]
  [ReadOnly]
  public int lastStandCount;
  public static Battle.Phase previousPhase;
  public static StatusEffectLastStand target;
  public static Entity subject;
  public static Entity attacker;
  public List<Entity> entities;
  public readonly Dictionary<Entity, Transform> previousParents = new Dictionary<Entity, Transform>();
  public readonly List<Dice> dice = new List<Dice>();
  public int result = -1;
  public bool diceRolled;
  public bool _active;

  public bool active
  {
    get => this._active;
    set
    {
      this._active = value;
      this.background.SetActive(value);
      this.button.SetActive(value);
    }
  }

  public void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
  }

  public void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
  }

  public void BattleStart()
  {
    Entity target = References.Battle.cards.FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.cardType.miniboss && (UnityEngine.Object) a.owner == (UnityEngine.Object) References.Player));
    if (!((UnityEngine.Object) target != (UnityEngine.Object) null))
      return;
    Routine routine = new Routine(StatusEffectSystem.Apply(target, (Entity) null, this.effect, 1));
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.LastStand)
      return;
    ActionSequence action = new ActionSequence(this.Process());
    action.note = "Last Stand";
    ActionQueue.Stack((PlayAction) action, true);
  }

  public IEnumerator Process()
  {
    LastStandSystem lastStandSystem = this;
    BattleMusicSystem musicSystem = UnityEngine.Object.FindObjectOfType<BattleMusicSystem>();
    if ((UnityEngine.Object) musicSystem != (UnityEngine.Object) null)
      musicSystem.FadePitchTo(0.3333f);
    lastStandSystem.entities = Battle.GetCardsOnBoard();
    foreach (Entity entity in lastStandSystem.entities)
    {
      lastStandSystem.previousParents[entity] = entity.transform.parent;
      entity.transform.parent = lastStandSystem.entityGroup;
      ++entity.silenceCount;
    }
    lastStandSystem.active = true;
    yield return (object) new WaitUntil(new Func<bool>(lastStandSystem.\u003CProcess\u003Eb__29_0));
    yield return (object) lastStandSystem.RollSequence();
    lastStandSystem.Clear();
    foreach (KeyValuePair<Entity, Transform> keyValuePair in lastStandSystem.previousParents.Where<KeyValuePair<Entity, Transform>>((Func<KeyValuePair<Entity, Transform>, bool>) (pair => (UnityEngine.Object) pair.Key != (UnityEngine.Object) null && (UnityEngine.Object) pair.Value != (UnityEngine.Object) null)))
      keyValuePair.Key.transform.parent = keyValuePair.Value;
    lastStandSystem.previousParents.Clear();
    lastStandSystem.active = false;
    if ((UnityEngine.Object) musicSystem != (UnityEngine.Object) null)
      musicSystem.FadePitchTo(1f);
    LastStandSystem.target.preventDeath = false;
    switch (lastStandSystem.result)
    {
      case 0:
        Debug.Log((object) "Player Wins!");
        if (Battle.IsOnBoard(LastStandSystem.attacker) && LastStandSystem.attacker.owner.team != LastStandSystem.subject.owner.team)
        {
          yield return (object) lastStandSystem.AttackAndKill(References.Battle.player, LastStandSystem.attacker);
          break;
        }
        break;
      case 1:
        Debug.Log((object) "Enemy Wins!");
        yield return (object) lastStandSystem.AttackAndKill(References.Battle.enemy, LastStandSystem.subject);
        break;
    }
    lastStandSystem.result = -1;
    References.Battle.CancelTurn();
    foreach (Entity entity in lastStandSystem.entities.Where<Entity>((Func<Entity, bool>) (e => (UnityEngine.Object) e != (UnityEngine.Object) null)))
      --entity.silenceCount;
    lastStandSystem.entities = (List<Entity>) null;
    if ((UnityEngine.Object) LastStandSystem.target != (UnityEngine.Object) null)
      LastStandSystem.target.ReEnable();
    if (!References.Battle.CheckEnd())
      References.Battle.phase = LastStandSystem.previousPhase;
  }

  public void Roll()
  {
    this.button.SetActive(false);
    this.diceRolled = true;
  }

  public IEnumerator RollSequence()
  {
    LastStandSystem lastStandSystem = this;
    Debug.Log((object) "Last Stand: Rolling Dice...");
    float delayBetween = 1f;
    Entity[] legalEntities = lastStandSystem.entities.Where<Entity>(new Func<Entity, bool>(lastStandSystem.\u003CRollSequence\u003Eb__31_0)).ToArray<Entity>();
    int count1 = ((IEnumerable<Entity>) legalEntities).Count<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) References.Battle.player));
    lastStandSystem.CreateDice(count1, lastStandSystem.playerDicePrefab, lastStandSystem.playerDiceGroup);
    int playerTotal = LastStandSystem.ThrowDice(lastStandSystem.playerDiceGroup);
    yield return (object) new WaitForSeconds(delayBetween);
    int count2 = ((IEnumerable<Entity>) legalEntities).Count<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) References.Battle.enemy && !a.data.cardType.miniboss)) + lastStandSystem.lastStandCount;
    lastStandSystem.CreateDice(count2, lastStandSystem.enemyDicePrefab, lastStandSystem.enemyDiceGroup);
    int count3 = ((IEnumerable<Entity>) legalEntities).Count<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) References.Battle.enemy && a.data.cardType.miniboss));
    lastStandSystem.CreateDice(count3, lastStandSystem.bossDicePrefab, lastStandSystem.enemyDiceGroup);
    int enemyTotal = LastStandSystem.ThrowDice(lastStandSystem.enemyDiceGroup);
    yield return (object) new WaitForSeconds(delayBetween);
    do
    {
      lastStandSystem.result = playerTotal > enemyTotal ? 0 : (enemyTotal > playerTotal ? 1 : -1);
      if (lastStandSystem.result == -1)
      {
        Debug.Log((object) "It's a draw!");
        playerTotal = LastStandSystem.ThrowDice(lastStandSystem.playerDiceGroup);
        yield return (object) new WaitForSeconds(delayBetween);
        enemyTotal = LastStandSystem.ThrowDice(lastStandSystem.enemyDiceGroup);
        yield return (object) new WaitForSeconds(delayBetween);
      }
    }
    while (lastStandSystem.result == -1);
    ++lastStandSystem.lastStandCount;
  }

  public void Clear()
  {
    foreach (Component die in this.dice)
      die.gameObject.Destroy();
    this.dice.Clear();
    this.diceRolled = false;
  }

  public void CreateDice(int count, Dice prefab, Transform group)
  {
    for (int index = 0; index < count; ++index)
    {
      Dice dice = UnityEngine.Object.Instantiate<Dice>(prefab, group);
      dice.gameObject.SetActive(true);
      this.dice.Add(dice);
    }
  }

  public static int ThrowDice(Transform group)
  {
    int num1 = 0;
    float num2 = 0.5f;
    Dice[] componentsInChildren = group.GetComponentsInChildren<Dice>();
    for (int index = 0; index < componentsInChildren.Length; ++index)
    {
      Dice dice = componentsInChildren[index];
      dice.transform.localPosition = new Vector3(num2 * (float) index, 0.0f);
      dice.Throw(new Vector2(Dead.Random.Range(-1f, 1f), 1f).normalized);
      num1 += dice.value;
    }
    return num1;
  }

  public IEnumerator AttackAndKillAll(Character attackingTeam, Character defendingTeam)
  {
    List<Entity> attackers = ((IEnumerable<Entity>) this.entities.Where<Entity>((Func<Entity, bool>) (a => this.legalCardTypes.Contains<CardType>(a.data.cardType))).ToArray<Entity>()).Where<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) attackingTeam)).ToList<Entity>();
    List<Entity> defenders = this.entities.Where<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) defendingTeam)).ToList<Entity>();
    while (defenders.Count > 0)
    {
      Entity entity = attackers.RandomItem<Entity>();
      Entity target = defenders.RandomItem<Entity>();
      defenders.Remove(target);
      Hit hit = new Hit(entity, target, 99)
      {
        canRetaliate = false,
        canBeNullified = false
      };
      hit.AddStatusEffect(this.killEffect, 1);
      yield return (object) new Trigger(entity, entity, "laststand", new Entity[1]
      {
        target
      })
      {
        countsAsTrigger = false,
        hits = new Hit[1]{ hit }
      }.Process();
      yield return (object) new WaitForSeconds(Dead.Random.Range(0.0f, 0.1f));
    }
    yield return (object) new WaitForSeconds(1f);
  }

  public IEnumerator AttackOnce(Character attackingTeam)
  {
    List<Entity> list = ((IEnumerable<Entity>) this.entities.Where<Entity>((Func<Entity, bool>) (a => this.legalCardTypes.Contains<CardType>(a.data.cardType))).ToArray<Entity>()).Where<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) attackingTeam)).ToList<Entity>();
    list.Shuffle<Entity>();
    foreach (Entity entity in list)
    {
      Entity attacker = entity;
      if (attacker.data.hasAttack)
      {
        Entity[] targets = (UnityEngine.Object) attacker.targetMode != (UnityEngine.Object) null ? attacker.targetMode.GetTargets(attacker, (Entity) null, (CardContainer) null) : (Entity[]) null;
        if (targets != null && targets.Length != 0)
        {
          Hit[] array = ((IEnumerable<Entity>) targets).Select<Entity, Hit>((Func<Entity, Hit>) (a => new Hit(attacker, a)
          {
            canRetaliate = false,
            canBeNullified = false
          })).ToArray<Hit>();
          yield return (object) new Trigger(attacker, attacker, "laststand", targets)
          {
            countsAsTrigger = false,
            hits = array
          }.Process();
          yield return (object) new WaitForSeconds(Dead.Random.Range(0.1f, 0.1f));
        }
      }
    }
    yield return (object) new WaitForSeconds(1f);
  }

  public IEnumerator AttackAndKill(Character attackingTeam, Entity target)
  {
    target.alive = false;
    List<Entity> attackers = ((IEnumerable<Entity>) this.entities.Where<Entity>((Func<Entity, bool>) (a => this.legalCardTypes.Contains<CardType>(a.data.cardType))).ToArray<Entity>()).Where<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a.owner == (UnityEngine.Object) attackingTeam)).ToList<Entity>();
    attackers.Shuffle<Entity>();
    int attackersCount = attackers.Count;
    for (int i = 0; i < attackersCount; ++i)
    {
      int num = i == attackersCount - 1 ? 1 : 0;
      Entity attacker = attackers[i];
      Hit hit = new Hit(attacker, target, 0)
      {
        canRetaliate = false,
        canBeNullified = false,
        extraOffensiveness = 5
      };
      hit.FlagAsOffensive();
      if (num != 0)
      {
        target.alive = true;
        hit.AddStatusEffect(this.killEffect, 1);
        hit.extraOffensiveness = 10;
        yield return (object) new WaitForSeconds(0.25f);
      }
      yield return (object) new Trigger(attacker, attacker, "laststand", new Entity[1]
      {
        target
      })
      {
        countsAsTrigger = false,
        hits = new Hit[1]{ hit }
      }.Process();
      yield return (object) new WaitForSeconds(Dead.Random.Range(0.0f, 0.01f));
      attacker = (Entity) null;
      hit = (Hit) null;
    }
    yield return (object) new WaitForSeconds(1f);
  }

  [CompilerGenerated]
  public bool \u003CProcess\u003Eb__29_0() => this.diceRolled;

  [CompilerGenerated]
  public bool \u003CRollSequence\u003Eb__31_0(Entity a) => this.legalCardTypes.Contains<CardType>(a.data.cardType);
}
