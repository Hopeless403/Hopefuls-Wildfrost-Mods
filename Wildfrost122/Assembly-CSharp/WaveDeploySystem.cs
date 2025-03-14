﻿// Decompiled with JetBrains decompiler
// Type: WaveDeploySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class WaveDeploySystem : GameSystem
{
  public bool visible = true;
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private WaveDeployerDots dotManager;
  [SerializeField]
  private TMP_Text counterText;
  [SerializeField]
  private GameObject group;
  [SerializeField]
  private UINavigationItem navigationItem;
  [Header("Settings")]
  [SerializeField]
  private int counterStart = -1;
  [SerializeField]
  private bool recallWhenUnsuccessful;
  [SerializeField]
  private int damageToOpponent;
  [SerializeField]
  private int damageIncreasePerTurn;
  [SerializeField]
  private float pauseAfterDeploy = 0.2f;
  private bool inBattle;
  private int damageToOpponentCurrent;
  private int currentWave;
  private BattleWaveManager waveManager;
  private int counter;
  private int counterMax;
  private bool reset;
  private bool deploySuccessful;
  private List<Entity> deployed;
  public static UINavigationItem nav;

  private void Awake()
  {
    this.group.SetActive(false);
    WaveDeploySystem.nav = this.navigationItem;
  }

  private void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  private void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
  }

  private void BattlePhaseStart(Battle.Phase phase)
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

  private void SceneChanged(Scene scene)
  {
    if (!this.inBattle)
      return;
    this.Hide();
    this.inBattle = false;
  }

  private void BattleStart()
  {
    this.inBattle = true;
    this.damageToOpponentCurrent = this.damageToOpponent;
    this.currentWave = 0;
    this.waveManager = References.Battle.enemy.GetComponent<BattleWaveManager>();
    this.counter = this.counterStart;
    this.reset = false;
    if (this.visible)
      this.Show();
    this.dotManager.Init(this.waveManager, this.currentWave);
    ActionSequence action = new ActionSequence(this.CountDown());
    action.parallel = true;
    ActionQueue.Add((PlayAction) action);
  }

  public void Close() => this.animator.SetBool(nameof (Close), true);

  public void Open() => this.animator.SetBool("Close", false);

  public void Show()
  {
    this.visible = true;
    this.group.SetActive(true);
    this.animator.SetTrigger("Reveal");
    SfxSystem.OneShot("event:/sfx/inventory/wave_counter_showup");
  }

  public void Hide() => this.group.SetActive(false);

  private IEnumerator CountDown()
  {
    if (this.currentWave < this.waveManager.list.Count)
    {
      bool earlyDeploy = this.CheckEarlyDeploy();
      if (this.visible)
      {
        this.Close();
        if (this.counter <= 1 | earlyDeploy)
          SfxSystem.OneShot("event:/sfx/inventory/wave_counter_decrease_last");
        else
          SfxSystem.OneShot("event:/sfx/inventory/wave_counter_decrease");
        yield return (object) Sequences.Wait(0.1f);
      }
      if (earlyDeploy)
        this.counter = 1;
      if (this.reset)
      {
        this.reset = false;
      }
      else
      {
        this.SetCounter(Mathf.Clamp(this.counter - 1, 0, this.counterMax));
        if (this.counter <= 0)
          yield return (object) this.Activate();
      }
      if (this.visible && this.counter > 0)
      {
        this.Open();
        if (this.counter == this.counterMax)
          SfxSystem.OneShot("event:/sfx/inventory/wave_counter_refresh");
      }
    }
  }

  private void SetCounter(int value)
  {
    this.counter = value;
    this.counterText.text = value.ToString();
  }

  private void SetCounterMax(int value)
  {
    this.counterMax = value;
    this.SetCounter(value);
  }

  private bool CheckEarlyDeploy() => Battle.GetCardsOnBoard(References.Battle.enemy).Count <= 0;

  private IEnumerator Activate()
  {
    WaveDeploySystem waveDeploySystem1 = this;
    int thisWaveIndex = waveDeploySystem1.currentWave;
    int targetRow = Random.Range(0, Battle.instance.rowCount);
    yield return (object) Sequences.Wait(0.2f);
    yield return (object) waveDeploySystem1.TryDeploy(targetRow);
    if (waveDeploySystem1.deploySuccessful)
    {
      yield return (object) waveDeploySystem1.RevealBoard();
      WaveDeploySystem waveDeploySystem2 = waveDeploySystem1;
      int num1 = waveDeploySystem1.currentWave + 1;
      int num2 = num1;
      waveDeploySystem2.currentWave = num2;
      if (num1 < waveDeploySystem1.waveManager.list.Count)
      {
        BattleWaveManager.Wave wave = waveDeploySystem1.waveManager.list[waveDeploySystem1.currentWave];
        waveDeploySystem1.SetCounterMax(wave.counter);
      }
      waveDeploySystem1.damageToOpponentCurrent = waveDeploySystem1.damageToOpponent;
    }
    else
    {
      Routine.Clump clump = new Routine.Clump();
      if (waveDeploySystem1.recallWhenUnsuccessful)
      {
        yield return (object) Sequences.Wait(0.33f);
        foreach (Entity entity in waveDeploySystem1.deployed)
          clump.Add(Sequences.CardMove(entity, new CardContainer[1]
          {
            References.Battle.enemy.reserveContainer
          }));
        yield return (object) clump.WaitForEnd();
      }
      else
        yield return (object) waveDeploySystem1.RevealBoard();
      if (waveDeploySystem1.damageToOpponentCurrent > 0)
      {
        Entity entity = References.Player.entity;
        if ((Object) entity != (Object) null && entity.canBeHit)
        {
          clump.Add(new Hit(References.Battle.enemy.entity, entity, waveDeploySystem1.damageToOpponentCurrent).Process());
          clump.Add(Sequences.Wait(0.2f));
        }
      }
      yield return (object) clump.WaitForEnd();
      waveDeploySystem1.damageToOpponentCurrent += waveDeploySystem1.damageIncreasePerTurn;
      waveDeploySystem1.SetCounter(1);
      clump = (Routine.Clump) null;
    }
    waveDeploySystem1.waveManager.list[thisWaveIndex].spawned = true;
    if ((Object) waveDeploySystem1.dotManager != (Object) null)
      waveDeploySystem1.dotManager.UpdateDots(waveDeploySystem1.waveManager, thisWaveIndex);
  }

  private IEnumerator TryDeploy(int rowIndex)
  {
    if (this.deployed == null)
      this.deployed = new List<Entity>();
    this.deployed.Clear();
    this.deploySuccessful = true;
    Entity[] entityArray = this.waveManager.Peek();
    for (int index = 0; index < entityArray.Length; ++index)
    {
      Entity e = entityArray[index];
      if ((Object) e != (Object) null && e.containers.Contains<CardContainer>(e.owner.reserveContainer))
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

  private void Deploy(Entity entity, int targetRow, int targetColumn)
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

  private IEnumerator RevealBoard()
  {
    ActionQueue.Add((PlayAction) new ActionRevealAll(References.Battle.GetRows(References.Battle.enemy).ToArray()));
    yield return (object) ActionQueue.Wait(false);
  }
}
