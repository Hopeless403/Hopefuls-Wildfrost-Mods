// Decompiled with JetBrains decompiler
// Type: RedrawBellSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

public class RedrawBellSystem : GameSystem
{
  public RectTransform _rectTransform;
  [SerializeField]
  public GameObject bell;
  [SerializeField]
  public GameObject bellActive;
  [SerializeField]
  public ParticleSystem chargeParticleSystem;
  [SerializeField]
  public ParticleSystem hitParticleSystem;
  [SerializeField]
  public UINavigationItem navigationItem;
  [Header("Counter")]
  [SerializeField]
  public int counterChange = -1;
  [SerializeField]
  public StatusIcon counterIcon;
  [Header("Keyword Popup")]
  [SerializeField]
  public KeywordData popUpKeyword;
  [SerializeField]
  public Vector2 popUpOffset = new Vector2(-1f, -1f);
  [SerializeField]
  public LocalizedString textNotCharged;
  [SerializeField]
  public LocalizedString textCharged;
  public UnityEngine.Animator _animator;
  public Character owner;
  public CardController controller;
  public Stat counter;
  public bool reset;
  [HideInInspector]
  public bool interactable;
  public bool poppedUp;
  public static UINavigationItem nav;

  public RectTransform rectTransform => this._rectTransform ?? (this._rectTransform = (RectTransform) this.transform);

  public UnityEngine.Animator animator => this._animator ?? (this._animator = this.GetComponent<UnityEngine.Animator>());

  public bool IsCharged => this.counter.current <= 0;

  public void OnEnable()
  {
    RedrawBellSystem.nav = this.navigationItem;
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.CounterIncrement);
  }

  public void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.CounterIncrement);
  }

  public void BecomeInteractable()
  {
    if (this.interactable)
      return;
    this.interactable = true;
    this.Assign(Battle.instance.player, Battle.instance.playerCardController);
    this.Show();
  }

  public void Show()
  {
    this.bell.SetActive(true);
    this.interactable = true;
    this.reset = false;
    this.counter.max = this.owner.data.redrawBell;
    this.SetCounter(this.counter.max);
    global::Events.InvokeRedrawBellRevealed(this);
    this.AnimatorTrigger("Enter");
    SfxSystem.OneShot("event:/sfx/inventory/redraw_bell_showup");
  }

  public void Hide()
  {
    this.bell.SetActive(false);
    this.interactable = false;
    if (this.poppedUp)
      this.UnPop();
    this.bellActive.SetActive(false);
  }

  public void SceneChanged(Scene scene)
  {
    if (!this.interactable || !(scene.name != "Battle"))
      return;
    this.Hide();
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.Play)
    {
      if (phase != Battle.Phase.End)
        return;
      this.Hide();
    }
    else
      this.BecomeInteractable();
  }

  public void CounterIncrement(int turnNumber)
  {
    if (Battle.instance.phase == Battle.Phase.End)
      return;
    this.Counter();
  }

  public void Assign(Character owner, CardController controller)
  {
    this.owner = owner;
    this.controller = controller;
    this.GetComponentInChildren<ToggleBasedOnCardController>(true)?.AssignCardController(controller);
  }

  public void Activate()
  {
    if (!this.interactable)
      return;
    ActionRedraw action = new ActionRedraw(this.owner, global::Events.GetHandSize(References.PlayerData.handSize));
    if (!global::Events.CheckAction((PlayAction) action))
      return;
    ActionQueue.Add((PlayAction) action);
    ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
    this.controller.Disable();
    if (this.IsCharged)
    {
      this.owner.freeAction = true;
      this.reset = false;
    }
    else
      this.reset = true;
    global::Events.InvokeRedrawBellHit(this);
    SfxSystem.OneShot("event:/sfx/inventory/redraw_bell_use");
    this.SetCounter(this.counter.max);
    this.AnimatorTrigger("Ring");
    global::Events.InvokeScreenShake();
    global::Events.InvokeUINavigationReset();
    this.hitParticleSystem.Play();
  }

  public void Counter()
  {
    if (this.reset)
    {
      this.reset = false;
    }
    else
    {
      int num = Mathf.Clamp(this.counter.current + this.counterChange, 0, this.counter.max);
      if (num == this.counter.current)
        return;
      this.SetCounter(num);
      this.AnimatorTrigger("Shake");
      SfxSystem.OneShot("event:/sfx/inventory/redraw_bell_countdown");
    }
  }

  public void SetCounter(int value)
  {
    int num = this.IsCharged ? 1 : 0;
    this.counter.current = value;
    if ((bool) (Object) this.counterIcon)
      this.counterIcon.SetValue(this.counter);
    this.animator.SetBool("Charged", this.IsCharged);
    if (num != 0 || !this.IsCharged)
      return;
    SfxSystem.OneShot("event:/sfx/inventory/redraw_bell_charged");
  }

  public void Pop()
  {
    if (this.poppedUp || !(bool) (Object) this.popUpKeyword)
      return;
    string forceBody = this.popUpKeyword.body.Format((object) global::Events.GetHandSize(References.PlayerData.handSize)) + (this.IsCharged ? "\n\n" + this.textCharged.GetLocalizedString() : "\n\n" + this.textNotCharged.GetLocalizedString());
    CardPopUp.AssignTo(this.rectTransform, this.popUpOffset.x, this.popUpOffset.y);
    CardPopUp.AddPanel(this.popUpKeyword, forceBody);
    this.poppedUp = true;
  }

  public void UnPop()
  {
    if (!this.poppedUp)
      return;
    CardPopUp.RemovePanel(this.popUpKeyword.name);
    this.poppedUp = false;
  }

  public void AnimatorTrigger(string name) => this.animator.SetTrigger(name);

  public void AnimatorSetHover(bool value) => this.animator.SetBool("Hover", value);

  public void AnimatorSetPress(bool value) => this.animator.SetBool("Press", value);

  public void PlayChargeParticleSystem() => this.chargeParticleSystem.Play();
}
