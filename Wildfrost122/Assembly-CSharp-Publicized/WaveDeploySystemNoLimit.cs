// Decompiled with JetBrains decompiler
// Type: WaveDeploySystemNoLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class WaveDeploySystemNoLimit : GameSystem
{
  [SerializeField]
  public GameObject blocker;
  [SerializeField]
  public GameObject icon;
  [SerializeField]
  public CanvasGroup group;
  [SerializeField]
  public TMP_Text numberElement;
  [Header("Settings")]
  [SerializeField]
  public int counterStart = -1;
  [SerializeField]
  public int counterMax = 3;
  [SerializeField]
  public int popUpCounterAt = 5;
  [SerializeField]
  public int bigIconAt = 3;
  [SerializeField]
  public Vector3 smallIconPos = new Vector3(0.0f, 3.4f, 0.0f);
  [SerializeField]
  public Vector3 smallIconScale = new Vector3(0.5f, 0.5f, 1f);
  [SerializeField]
  public float pauseAfterDeploy = 0.2f;
  [SerializeField]
  public bool countWhenXEnemies;
  [SerializeField]
  [ShowIf("countWhenXEnemies")]
  public int countWhenEnemiesRemaining = 1;
  [SerializeField]
  public bool needSpace = true;
  public bool inBattle;
  public int currentWave;
  public BattleWaveManager waveManager;
  public int counter;
  public bool reset;
  public bool deploySuccessful;
  public List<Entity> deployed;

  public void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (this.inBattle)
    {
      if (phase != Battle.Phase.Play || References.Battle.turnCount <= 0)
        return;
      ActionSequence action = new ActionSequence(this.CountDown());
      action.parallel = true;
      ActionQueue.Add((PlayAction) action);
    }
    else
    {
      if (phase != Battle.Phase.Init)
        return;
      this.BattleStart();
    }
  }

  public void SceneChanged(Scene scene)
  {
    if (!this.inBattle)
      return;
    this.inBattle = false;
  }

  public void BattleStart()
  {
    this.inBattle = true;
    this.currentWave = 0;
    this.waveManager = References.Battle.enemy.GetComponent<BattleWaveManager>();
    this.counter = this.counterStart;
    this.reset = false;
    ActionSequence action = new ActionSequence(this.CountDown());
    action.parallel = true;
    ActionQueue.Add((PlayAction) action);
  }

  public IEnumerator CountDown()
  {
    int enemyCount = WaveDeploySystemNoLimit.GetEnemyCount();
    if ((!this.countWhenXEnemies || enemyCount <= this.countWhenEnemiesRemaining) && this.currentWave < this.waveManager.list.Count && References.Battle.GetRows(References.Battle.enemy).Cast<CardSlotLane>().SelectMany<CardSlotLane, CardSlot>((Func<CardSlotLane, IEnumerable<CardSlot>>) (a => (IEnumerable<CardSlot>) a.slots)).Count<CardSlot>((Func<CardSlot, bool>) (a => a.Empty)) >= this.waveManager.list[this.currentWave].units.Count)
    {
      if (enemyCount <= 0)
        this.counter = 0;
      --this.counter;
      if (this.counter <= 0)
        yield return (object) this.Activate();
      else if (this.counter <= this.popUpCounterAt)
      {
        Routine routine = new Routine(this.Pop());
      }
    }
  }

  public IEnumerator Pop()
  {
    WaveDeploySystemNoLimit deploySystemNoLimit = this;
    deploySystemNoLimit.numberElement.text = deploySystemNoLimit.counter.ToString();
    deploySystemNoLimit.group.gameObject.SetActive(true);
    deploySystemNoLimit.blocker.SetActive(true);
    deploySystemNoLimit.group.alpha = 0.0f;
    deploySystemNoLimit.icon.transform.localPosition = deploySystemNoLimit.counter <= deploySystemNoLimit.bigIconAt ? Vector3.zero : deploySystemNoLimit.smallIconPos;
    Vector3 to = deploySystemNoLimit.counter <= deploySystemNoLimit.bigIconAt ? Vector3.one : deploySystemNoLimit.smallIconScale;
    deploySystemNoLimit.icon.transform.localScale = to * 1.5f;
    LeanTween.scale(deploySystemNoLimit.icon, to, 1.5f).setEaseOutElastic();
    LeanTween.value(deploySystemNoLimit.gameObject, 0.0f, 1f, 0.25f).setEaseLinear().setOnUpdate(new Action<float>(deploySystemNoLimit.\u003CPop\u003Eb__27_0));
    deploySystemNoLimit.blocker.SetActive(false);
    yield return (object) new WaitForSeconds(1f);
    LeanTween.value(deploySystemNoLimit.gameObject, 1f, 0.0f, 0.15f).setEaseLinear().setOnUpdate(new Action<float>(deploySystemNoLimit.\u003CPop\u003Eb__27_1)).setOnComplete(new System.Action(deploySystemNoLimit.\u003CPop\u003Eb__27_2));
  }

  public IEnumerator Activate()
  {
    WaveDeploySystemNoLimit deploySystemNoLimit1 = this;
    int thisWaveIndex = deploySystemNoLimit1.currentWave;
    int targetRow = UnityEngine.Random.Range(0, Battle.instance.rowCount);
    yield return (object) Sequences.Wait(0.2f);
    yield return (object) deploySystemNoLimit1.TryDeploy(targetRow);
    if (deploySystemNoLimit1.deploySuccessful)
    {
      yield return (object) WaveDeploySystemNoLimit.RevealBoard();
      WaveDeploySystemNoLimit deploySystemNoLimit2 = deploySystemNoLimit1;
      int num1 = deploySystemNoLimit1.currentWave + 1;
      int num2 = num1;
      deploySystemNoLimit2.currentWave = num2;
      if (num1 < deploySystemNoLimit1.waveManager.list.Count)
        deploySystemNoLimit1.counter = deploySystemNoLimit1.counterMax + 1;
    }
    else
    {
      yield return (object) WaveDeploySystemNoLimit.RevealBoard();
      deploySystemNoLimit1.counter = 1;
    }
    deploySystemNoLimit1.waveManager.list[thisWaveIndex].spawned = true;
  }

  public IEnumerator TryDeploy(int rowIndex)
  {
    if (this.deployed == null)
      this.deployed = new List<Entity>();
    this.deployed.Clear();
    this.deploySuccessful = true;
    Entity[] entityArray = this.waveManager.Peek();
    for (int index = 0; index < entityArray.Length; ++index)
    {
      Entity e = entityArray[index];
      if ((UnityEngine.Object) e != (UnityEngine.Object) null && e.containers.Contains<CardContainer>(e.owner.reserveContainer))
      {
        for (int index1 = 0; index1 < References.Battle.rowCount; ++index1)
        {
          rowIndex = (rowIndex + 1) % References.Battle.rowCount;
          int targetColumn;
          if (References.Battle.CanDeploy(e, rowIndex, out targetColumn))
          {
            this.Deploy(e, rowIndex, targetColumn);
            this.deployed.Add(e);
            yield return (object) ActionQueue.Wait(false);
            break;
          }
        }
        if (!this.deployed.Contains(e))
          this.deploySuccessful = false;
      }
      e = (Entity) null;
    }
    entityArray = (Entity[]) null;
    if (this.deploySuccessful)
      this.waveManager.Pull();
  }

  public void Deploy(Entity entity, int targetRow, int targetColumn)
  {
    List<CardContainer> rows = Battle.instance.GetRows(entity.owner);
    List<CardContainer> cardContainerList = new List<CardContainer>();
    for (int index = 0; index < entity.height; ++index)
    {
      CardContainer cardContainer = rows[(targetRow + index) % rows.Count];
      cardContainerList.Add(cardContainer);
    }
    entity.flipper.FlipUpInstant();
    ActionMove action = new ActionMove(entity, cardContainerList.ToArray());
    action.insertPos = targetColumn;
    action.pauseAfter = this.pauseAfterDeploy;
    ActionQueue.Add((PlayAction) action);
  }

  public static IEnumerator RevealBoard()
  {
    ActionQueue.Add((PlayAction) new ActionRevealAll(References.Battle.GetRows(References.Battle.enemy).ToArray()));
    yield return (object) ActionQueue.Wait(false);
  }

  public static int GetEnemyCount()
  {
    return Battle.GetCardsOnBoard(References.Battle.enemy).Count<Entity>((Func<Entity, bool>) (a => !a.data.cardType.miniboss));
  }

  [CompilerGenerated]
  public void \u003CPop\u003Eb__27_0(float a) => this.group.alpha = a;

  [CompilerGenerated]
  public void \u003CPop\u003Eb__27_1(float a) => this.group.alpha = a;

  [CompilerGenerated]
  public void \u003CPop\u003Eb__27_2() => this.group.gameObject.SetActive(false);
}
