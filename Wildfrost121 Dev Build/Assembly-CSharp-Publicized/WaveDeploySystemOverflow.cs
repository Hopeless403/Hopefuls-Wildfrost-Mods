// Decompiled with JetBrains decompiler
// Type: WaveDeploySystemOverflow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
public class WaveDeploySystemOverflow : GameSystem, ISaveable<BattleWaveData>
{
  public bool visible = true;
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public TMP_Text counterText;
  [SerializeField]
  public GameObject group;
  public UINavigationItem navigationItem;
  [SerializeField]
  public CanvasGroup canvasGroup;
  [SerializeField]
  public Button button;
  [Header("Glow")]
  [SerializeField]
  public Image glow;
  [SerializeField]
  public Color glowColor = Color.black;
  [SerializeField]
  public Color glowImminentColor = Color.red;
  [Header("Deploy Early")]
  [SerializeField]
  public int deployEarlyReward;
  [SerializeField]
  public int deployEarlyRewardPerTurn = 5;
  [SerializeField]
  public bool autoEarlyDeploy = true;
  [SerializeField]
  public bool canCallEarly;
  [Header("Popup")]
  [SerializeField]
  public LocalizedString popupDesc;
  [SerializeField]
  public LocalizedString popupHitDesc;
  [SerializeField]
  public LocalizedString popupOverflowDesc;
  [SerializeField]
  public LocalizedString popupRewardDesc;
  [Header("Settings")]
  [SerializeField]
  public KeywordData popup;
  [SerializeField]
  public int counterStart = -1;
  [SerializeField]
  public float pauseAfterDeploy = 0.2f;
  public bool inBattle;
  public int currentWave;
  public int counter;
  public bool reset;
  public float fade = 1f;
  public float fadeTo;
  public float fadeAdd = 5f;
  public bool popped;
  public List<BattleWaveManager.Wave> waves;
  public List<Entity> deployedThisTurn;
  public List<ulong> deployed;
  public int overflowWaveIndex = -1;

  public void Awake()
  {
    this.group.SetActive(false);
    WaveDeploySystem.nav = this.navigationItem;
  }

  public void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    this.StopAllCoroutines();
  }

  public void Update()
  {
    float f = this.fadeTo - this.fade;
    float max = this.fadeAdd * Time.deltaTime;
    if ((double) Mathf.Abs(f) < (double) max)
      return;
    this.fade += Mathf.Clamp(f, -max, max);
    if ((double) Mathf.Abs(this.fadeTo - this.fade) <= (double) max)
      this.fade = this.fadeTo;
    this.canvasGroup.alpha = this.fade;
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (this.inBattle)
    {
      if (phase != Battle.Phase.Play)
        return;
      if (References.Battle.turnCount == 0)
      {
        if (!this.visible)
          return;
        this.Show();
      }
      else
      {
        ActionSequence action = new ActionSequence(this.CountDown());
        action.parallel = true;
        ActionQueue.Add((PlayAction) action);
      }
    }
    else if (phase == Battle.Phase.Init)
    {
      this.BattleStart();
    }
    else
    {
      if (phase != Battle.Phase.Play)
        return;
      this.inBattle = true;
    }
  }

  public void SceneChanged(Scene scene)
  {
    if (scene.name == "Battle")
    {
      this.Hide();
    }
    else
    {
      if (!this.inBattle)
        return;
      this.Hide();
      this.BattleEnd();
    }
  }

  public void BattleStart()
  {
    this.inBattle = true;
    this.currentWave = 0;
    this.overflowWaveIndex = -1;
    this.waves = new List<BattleWaveManager.Wave>((IEnumerable<BattleWaveManager.Wave>) References.Battle.enemy.GetComponent<BattleWaveManager>().list);
    this.deployedThisTurn = new List<Entity>();
    this.deployed = new List<ulong>();
    this.counter = this.counterStart;
    this.reset = false;
    ActionSequence action = new ActionSequence(this.CountDown());
    action.parallel = true;
    ActionQueue.Add((PlayAction) action);
  }

  public void BattleEnd()
  {
    this.inBattle = false;
    this.currentWave = 0;
    this.overflowWaveIndex = -1;
    this.waves = (List<BattleWaveManager.Wave>) null;
    this.deployedThisTurn = (List<Entity>) null;
    this.deployed = (List<ulong>) null;
    this.counter = 0;
    this.reset = false;
  }

  public void AssignCardController(CardController controller)
  {
    this.GetComponentInChildren<ToggleBasedOnCardController>(true)?.AssignCardController(controller);
  }

  public void Close() => this.animator.SetBool(nameof (Close), true);

  public void Open() => this.animator.SetBool("Close", false);

  public void Show()
  {
    if (this.visible && this.currentWave < this.waves.Count)
    {
      this.group.SetActive(true);
      this.FadeIn();
      SfxSystem.OneShot("event:/sfx/inventory/wave_counter_showup");
      this.button.interactable = this.canCallEarly;
    }
    this.AssignCardController(References.Battle.playerCardController);
  }

  public void Hide()
  {
    this.group.SetActive(false);
    this.FadeOut();
  }

  public void FadeIn()
  {
    this.fade = 0.0f;
    this.fadeTo = 1f;
    this.canvasGroup.blocksRaycasts = true;
  }

  public void FadeOut()
  {
    this.fadeTo = 0.0f;
    this.canvasGroup.blocksRaycasts = false;
  }

  public IEnumerator CountDown()
  {
    WaveDeploySystemOverflow deploySystemOverflow = this;
    if (deploySystemOverflow.currentWave < deploySystemOverflow.waves.Count)
    {
      global::Events.InvokeWaveDeployerPreCountDown(deploySystemOverflow.counter);
      bool earlyDeploy = WaveDeploySystemOverflow.CheckEarlyDeploy();
      if (deploySystemOverflow.visible)
      {
        deploySystemOverflow.Close();
        if (deploySystemOverflow.counter <= 1 | earlyDeploy)
          SfxSystem.OneShot("event:/sfx/inventory/wave_counter_decrease_last");
        else
          SfxSystem.OneShot("event:/sfx/inventory/wave_counter_decrease");
        yield return (object) Sequences.Wait(0.1f);
        if (!(bool) (UnityEngine.Object) deploySystemOverflow)
          yield break;
      }
      if (earlyDeploy && (References.Battle.turnCount == 0 || deploySystemOverflow.autoEarlyDeploy))
        deploySystemOverflow.counter = 1;
      if (deploySystemOverflow.reset)
      {
        deploySystemOverflow.reset = false;
      }
      else
      {
        deploySystemOverflow.SetCounter(Mathf.Max(deploySystemOverflow.counter - 1, 0));
        if (deploySystemOverflow.counter <= 0)
        {
          yield return (object) deploySystemOverflow.Activate();
          if (!(bool) (UnityEngine.Object) deploySystemOverflow)
            yield break;
        }
      }
      if (deploySystemOverflow.visible && deploySystemOverflow.counter > 0)
      {
        deploySystemOverflow.Open();
        if (deploySystemOverflow.counter == deploySystemOverflow.waves[deploySystemOverflow.currentWave].counter)
          SfxSystem.OneShot("event:/sfx/inventory/wave_counter_refresh");
      }
      global::Events.InvokeWaveDeployerPostCountDown(deploySystemOverflow.counter);
    }
  }

  public void SetCounter(int value)
  {
    this.counter = value;
    this.counterText.text = value.ToString();
    if (this.counter <= 1)
      this.glow.color = this.glowImminentColor;
    else
      this.glow.color = this.glowColor;
  }

  public static bool CheckEarlyDeploy()
  {
    return Battle.GetCardsOnBoard(References.Battle.enemy).Count <= 0;
  }

  public IEnumerator Activate()
  {
    WaveDeploySystemOverflow deploySystemOverflow1 = this;
    int targetRow = UnityEngine.Random.Range(0, Battle.instance.rowCount);
    deploySystemOverflow1.FadeOut();
    yield return (object) Sequences.Wait(0.2f);
    if ((bool) (UnityEngine.Object) deploySystemOverflow1)
    {
      yield return (object) deploySystemOverflow1.TryDeploy(targetRow);
      if ((bool) (UnityEngine.Object) deploySystemOverflow1)
      {
        if (deploySystemOverflow1.deployedThisTurn.Count > 0)
        {
          yield return (object) WaveDeploySystemOverflow.RevealBoard();
          if (!(bool) (UnityEngine.Object) deploySystemOverflow1)
            yield break;
        }
        WaveDeploySystemOverflow deploySystemOverflow2 = deploySystemOverflow1;
        int num1 = deploySystemOverflow1.currentWave + 1;
        int num2 = num1;
        deploySystemOverflow2.currentWave = num2;
        if (num1 < deploySystemOverflow1.waves.Count)
        {
          deploySystemOverflow1.SetCounter(deploySystemOverflow1.waves[deploySystemOverflow1.currentWave].counter);
          deploySystemOverflow1.FadeIn();
        }
        else
          deploySystemOverflow1.Hide();
      }
    }
  }

  public IEnumerator TryDeploy(int rowIndex)
  {
    WaveDeploySystemOverflow deploySystemOverflow = this;
    deploySystemOverflow.deployedThisTurn.Clear();
    List<Entity> failedToDeploy = new List<Entity>();
    foreach (CardData cardData1 in deploySystemOverflow.waves[deploySystemOverflow.currentWave].units.Where<CardData>(new Func<CardData, bool>(deploySystemOverflow.\u003CTryDeploy\u003Eb__52_0)))
    {
      CardData cardData = cardData1;
      Entity entity = References.Battle.cards.FirstOrDefault<Entity>((Func<Entity, bool>) (e => (long) e.data.id == (long) cardData.id));
      if ((bool) (UnityEngine.Object) entity && entity.containers.Contains<CardContainer>(entity.owner.reserveContainer))
      {
        bool thisDeployed = false;
        for (int index = 0; index < References.Battle.rowCount; ++index)
        {
          rowIndex = (rowIndex + 1) % References.Battle.rowCount;
          int targetColumn;
          if (References.Battle.CanDeploy(entity, rowIndex, out targetColumn))
          {
            thisDeployed = true;
            deploySystemOverflow.Deploy(entity, rowIndex, targetColumn);
            deploySystemOverflow.deployedThisTurn.Add(entity);
            deploySystemOverflow.deployed.Add(cardData.id);
            yield return (object) ActionQueue.Wait(false);
            if (!(bool) (UnityEngine.Object) deploySystemOverflow)
              yield break;
            else
              break;
          }
        }
        if (!thisDeployed)
          failedToDeploy.Add(entity);
      }
      entity = (Entity) null;
    }
    if (failedToDeploy.Count > 0)
      deploySystemOverflow.Overflow((IEnumerable<Entity>) failedToDeploy);
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

  public void Overflow(IEnumerable<Entity> entities)
  {
    Debug.Log((object) ("WaveSpawner → Overflowing [" + string.Join<Entity>(", ", entities) + "]"));
    if (this.overflowWaveIndex <= this.currentWave)
      this.CreateOverflowWave();
    foreach (Entity entity in entities)
    {
      if (!this.TryToAddToOverflow(entity))
      {
        this.CreateOverflowWave();
        this.TryToAddToOverflow(entity);
      }
    }
  }

  public void CreateOverflowWave()
  {
    List<BattleWaveManager.Wave> waves = this.waves;
    BattleWaveManager.Wave wave = waves[waves.Count - 1];
    this.waves.Add(new BattleWaveManager.Wave()
    {
      units = new List<CardData>(),
      counter = wave.counter
    });
    this.overflowWaveIndex = this.waves.Count - 1;
    Debug.Log((object) string.Format("WaveSpawner → New Overflow Wave Created [index: {0}]", (object) this.overflowWaveIndex));
  }

  public bool TryToAddToOverflow(Entity entity)
  {
    BattleWaveManager.Wave wave = this.waves[this.overflowWaveIndex];
    if (wave.units.Count >= 6)
      return false;
    wave.units.Add(entity.data);
    Debug.Log((object) string.Format("WaveSpawner → [{0}] Added to Overflow Wave [index: {1}]", (object) entity.name, (object) this.overflowWaveIndex));
    return true;
  }

  public void TryEarlyDeploy()
  {
    int num = WaveDeploySystemOverflow.CountEmptySpacesOnBoard();
    BattleWaveManager.Wave wave = this.waves[this.currentWave];
    if (!this.canCallEarly)
      return;
    if (wave.units.Count <= num)
    {
      ActionEarlyDeploy actionEarlyDeploy = new ActionEarlyDeploy(this.transform, this.EarlyDeploy());
      actionEarlyDeploy.parallel = true;
      ActionEarlyDeploy action = actionEarlyDeploy;
      if (!global::Events.CheckAction((PlayAction) action))
        return;
      ActionQueue.Add((PlayAction) action);
    }
    else
    {
      SfxSystem.OneShot("event:/sfx/inventory/wave_counter_deny");
      if (!(this.transform is RectTransform transform))
        return;
      transform.anchoredPosition = new Vector2(0.25f.WithRandomSign() - 1f, 2.5f);
      LeanTween.cancel(transform);
      LeanTween.move(transform, new Vector3(-1f, 2.5f, 0.0f), 1f).setEaseOutElastic();
    }
  }

  public IEnumerator EarlyDeploy()
  {
    InputSystem.Disable();
    global::Events.InvokeWaveDeployerEarlyDeploy();
    References.Battle.playerCardController.Disable();
    this.DropGold();
    this.counter = 1;
    yield return (object) this.CountDown();
    References.Battle.playerCardController.Enable();
    InputSystem.Enable();
  }

  public void DropGold()
  {
    int amount = this.deployEarlyReward + this.deployEarlyRewardPerTurn * this.counter;
    if (amount <= 0)
      return;
    global::Events.InvokeDropGold(amount, "Wave Bell", References.Player, this.transform.position);
  }

  public static int CountEmptySpacesOnBoard()
  {
    return References.Battle.GetRows(References.Battle.enemy).Sum<CardContainer>((Func<CardContainer, int>) (a => !a.canBePlacedOn ? 0 : a.max - a.Count));
  }

  public void Pop()
  {
    if (this.popped || !(bool) (UnityEngine.Object) this.popup || this.currentWave >= this.waves.Count)
      return;
    BattleWaveManager.Wave wave = this.waves[this.currentWave];
    int num1 = this.deployEarlyReward + this.deployEarlyRewardPerTurn * this.counter;
    string forceBody = this.popupDesc.GetLocalizedString().Format((object) wave.units.Count, (object) this.counter);
    int num2 = wave.units.Count - WaveDeploySystemOverflow.CountEmptySpacesOnBoard();
    if (num2 <= 0)
    {
      if (this.canCallEarly)
      {
        forceBody = forceBody + "\n\n" + this.popupHitDesc.GetLocalizedString();
        if (num1 > 0)
          forceBody = forceBody + "\n\n" + this.popupRewardDesc.GetLocalizedString((object) num1);
      }
    }
    else
      forceBody = forceBody + "\n\n" + this.popupOverflowDesc.GetLocalizedString((object) num2);
    CardPopUp.AssignTo((RectTransform) this.transform, -1f, -0.25f);
    CardPopUp.AddPanel(this.popup, forceBody);
    this.popped = true;
  }

  public void UnPop()
  {
    if (!this.popped)
      return;
    CardPopUp.RemovePanel(this.popup.name);
    this.popped = false;
  }

  public BattleWaveData Save()
  {
    return new BattleWaveData()
    {
      deployed = this.deployed,
      counter = this.counter,
      currentWave = this.currentWave,
      overflowWaveIndex = this.overflowWaveIndex,
      waves = this.waves.Select<BattleWaveManager.Wave, BattleWaveData.Wave>((Func<BattleWaveManager.Wave, BattleWaveData.Wave>) (a => new BattleWaveData.Wave(a))).ToArray<BattleWaveData.Wave>()
    };
  }

  public void Load(BattleWaveData data, IReadOnlyCollection<CardData> cards)
  {
    this.deployed = data.deployed;
    foreach (Entity entity in References.Battle.enemy.reserveContainer)
    {
      int index = this.deployed.IndexOf(entity.data.id);
      if (index >= 0)
        this.deployed.RemoveAt(index);
    }
    this.SetCounter(data.counter);
    this.currentWave = data.currentWave;
    this.overflowWaveIndex = data.overflowWaveIndex;
    this.waves = new List<BattleWaveManager.Wave>();
    foreach (BattleWaveData.Wave wave in data.waves)
      this.waves.Add(new BattleWaveManager.Wave()
      {
        counter = wave.counter,
        isBossWave = wave.isBossWave,
        spawned = wave.spawned,
        units = ((IEnumerable<ulong>) wave.unitIds).Select<ulong, CardData>((Func<ulong, CardData>) (a => cards.FirstOrDefault<CardData>((Func<CardData, bool>) (b => (long) b.id == (long) a)))).ToList<CardData>()
      });
    if (this.currentWave < this.waves.Count)
      this.Show();
    this.deployedThisTurn = new List<Entity>();
  }

  [CompilerGenerated]
  public bool \u003CTryDeploy\u003Eb__52_0(CardData cardData)
  {
    return (bool) (UnityEngine.Object) cardData && !this.deployed.Contains(cardData.id);
  }
}
