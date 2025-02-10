// Decompiled with JetBrains decompiler
// Type: DeckSelectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class DeckSelectSequence : UISequence
{
  [SerializeField]
  public UnityEvent onEnable;
  [SerializeField]
  public UnityEvent onDisable;
  [Header("Custom Values")]
  [SerializeField]
  public Transform cardHolder;
  [SerializeField]
  public CanvasGroup fade;
  [SerializeField]
  public float fadeInTime = 0.1f;
  [SerializeField]
  public float fadeOutTime = 0.1f;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public RenameCompanionSequence renameSequence;
  [SerializeField]
  public CrownHolder crownHolder;
  [Header("Buttons")]
  [SerializeField]
  public GameObject buttonGroup;
  [SerializeField]
  public TweenUI buttonShowTween;
  [SerializeField]
  public TweenUI buttonHideTween;
  [SerializeField]
  public GameObject renameButton;
  [SerializeField]
  public GameObject takeCrownButton;
  [SerializeField]
  public GameObject moveDownButton;
  [SerializeField]
  public Button moveDownButtonButton;
  [SerializeField]
  public GameObject moveUpButton;
  [SerializeField]
  public Button moveUpButtonButton;
  [Header("Movement")]
  [SerializeField]
  public float entityScale = 0.75f;
  [SerializeField]
  public float moveWobble = 1.5f;
  [SerializeField]
  public AnimationCurve moveCurve;
  [SerializeField]
  public float moveDur = 0.5f;
  public Entity entity;
  public Transform entityPreParent;
  public bool promptRename;

  public void SetEntity(Entity entity, bool canRename = true)
  {
    this.entity = entity;
    this.renameButton.SetActive((bool) (Object) entity & canRename);
    this.takeCrownButton.SetActive((bool) (Object) entity && DeckSelectSequence.EntityHasRemovableCrown(entity.data) && entity.data.cardType.canTakeCrown && (!(bool) (Object) References.Battle || References.Battle.ended));
    this.moveDownButton.SetActive(false);
    this.moveUpButton.SetActive(false);
  }

  public static bool EntityHasRemovableCrown(CardData cardData)
  {
    CardUpgradeData crown = cardData.GetCrown();
    return (bool) (Object) crown && crown.canBeRemoved;
  }

  public void AddMoveDown(UnityAction callback)
  {
    this.moveDownButton.SetActive(true);
    this.moveDownButtonButton.onClick.RemoveAllListeners();
    this.moveDownButtonButton.onClick.AddListener(callback);
    this.moveDownButtonButton.onClick.AddListener((UnityAction) (() =>
    {
      this.End();
      this.entity = (Entity) null;
    }));
  }

  public void AddMoveUp(UnityAction callback)
  {
    this.moveUpButton.SetActive(true);
    this.moveUpButtonButton.onClick.RemoveAllListeners();
    this.moveUpButtonButton.onClick.AddListener(callback);
    this.moveUpButtonButton.onClick.AddListener((UnityAction) (() =>
    {
      this.End();
      this.entity = (Entity) null;
    }));
  }

  public void Rename() => this.promptRename = true;

  public void TakeCrown()
  {
    CardUpgradeData crown = this.entity.data.GetCrown();
    if (crown == null)
      return;
    this.entity.data.RemoveCrown();
    if (this.entity.display is Card display && display.crownHolder is CrownHolder crownHolder)
      crownHolder.Remove(crown);
    References.PlayerData.inventory.upgrades.Add(crown);
    this.crownHolder.Create(crown);
    this.crownHolder.SetPositions();
  }

  public override void End() => this.promptEnd = true;

  public override IEnumerator Run()
  {
    DeckSelectSequence deckSelectSequence = this;
    deckSelectSequence.onEnable?.Invoke();
    deckSelectSequence.buttonGroup.SetActive(false);
    yield return (object) Sequences.Wait(deckSelectSequence.startDelay);
    deckSelectSequence.gameObject.SetActive(true);
    if ((double) deckSelectSequence.moveWobble != 0.0)
      deckSelectSequence.entity.wobbler?.WobbleRandom(deckSelectSequence.moveWobble);
    deckSelectSequence.entityPreParent = deckSelectSequence.entity.transform.parent;
    deckSelectSequence.entity.transform.SetParent(deckSelectSequence.cardHolder, true);
    LeanTween.cancel(deckSelectSequence.entity.gameObject);
    LeanTween.moveLocal(deckSelectSequence.entity.gameObject, Vector3.zero, deckSelectSequence.moveDur).setEase(deckSelectSequence.moveCurve);
    LeanTween.rotateLocal(deckSelectSequence.entity.gameObject, Vector3.zero, deckSelectSequence.moveDur).setEase(deckSelectSequence.moveCurve);
    LeanTween.scale(deckSelectSequence.entity.gameObject, Vector3.one * deckSelectSequence.entityScale, deckSelectSequence.moveDur).setEase(deckSelectSequence.moveCurve);
    global::Events.InvokeEntityFocus(deckSelectSequence.entity);
    deckSelectSequence.fade.gameObject.SetActive(true);
    deckSelectSequence.fade.alpha = 0.0f;
    deckSelectSequence.fade.LeanAlpha(1f, deckSelectSequence.fadeInTime);
    deckSelectSequence.fade.blocksRaycasts = true;
    deckSelectSequence.buttonGroup.SetActive(true);
    deckSelectSequence.buttonShowTween?.Fire();
    bool protectEnd = true;
    int protectEndCount = 5;
    while (!deckSelectSequence.promptEnd | protectEnd)
    {
      if (deckSelectSequence.promptRename)
      {
        deckSelectSequence.renameSequence.SetUnit(deckSelectSequence.entity);
        yield return (object) deckSelectSequence.renameSequence.Run();
        deckSelectSequence.promptRename = false;
      }
      yield return (object) null;
      if (protectEnd)
      {
        deckSelectSequence.promptEnd = false;
        --protectEndCount;
        if (protectEndCount <= 0)
          protectEnd = false;
      }
    }
    deckSelectSequence.promptEnd = false;
    if ((Object) deckSelectSequence.entity != (Object) null)
    {
      deckSelectSequence.entity.transform.SetParent(deckSelectSequence.entityPreParent, true);
      foreach (CardContainer container in deckSelectSequence.entity.containers)
        container.TweenChildPositions();
      if ((double) deckSelectSequence.moveWobble != 0.0)
        deckSelectSequence.entity.wobbler?.WobbleRandom(deckSelectSequence.moveWobble);
    }
    deckSelectSequence.fade.LeanAlpha(0.0f, deckSelectSequence.fadeOutTime);
    deckSelectSequence.fade.blocksRaycasts = false;
    deckSelectSequence.onDisable?.Invoke();
    deckSelectSequence.gameObject.SetActive(false);
  }

  [CompilerGenerated]
  public void \u003CAddMoveDown\u003Eb__27_0()
  {
    this.End();
    this.entity = (Entity) null;
  }

  [CompilerGenerated]
  public void \u003CAddMoveUp\u003Eb__28_0()
  {
    this.End();
    this.entity = (Entity) null;
  }
}
