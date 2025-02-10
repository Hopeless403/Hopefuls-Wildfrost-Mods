// Decompiled with JetBrains decompiler
// Type: InspectSystem
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
using UnityEngine.UI;

#nullable disable
public class InspectSystem : GameSystem
{
  [SerializeField]
  public GameObject container;
  [SerializeField]
  public Transform cardHolder;
  [SerializeField]
  public string openInput = "Inspect";
  [SerializeField]
  public string[] closeInputs = new string[3]
  {
    "Select",
    "Back",
    "Inspect"
  };
  [SerializeField]
  public string inspectCharmsInput = "Options";
  [SerializeField]
  public float cardScale = 1f;
  [SerializeField]
  public Vector2 cardRandomAngle = new Vector2(0.0f, 2f);
  [SerializeField]
  public List<Entity> hover = new List<Entity>();
  [SerializeField]
  public bool idleAnimation = true;
  [SerializeField]
  public float idleAnimationFactor = 1f;
  [SerializeField]
  public float canInspectDelay = 0.1f;
  [SerializeField]
  public float canEndDelay = 0.1f;
  [SerializeField]
  public KeywordData injuredKeyword;
  public float wait;
  [Header("Inspect Charms")]
  [SerializeField]
  public GameObject inspectCharmsLayout;
  [SerializeField]
  public InspectCharmsSystem inspectCharmsSystem;
  [Header("Pop up panels")]
  [SerializeField]
  public RectTransform leftPopGroup;
  [SerializeField]
  public RectTransform leftOverflowPopGroup;
  [SerializeField]
  public RectTransform rightPopGroup;
  [SerializeField]
  public RectTransform rightOverflowPopGroup;
  [SerializeField]
  public RectTransform bottomPopGroup;
  [SerializeField]
  public RectTransform notePopGroup;
  [SerializeField]
  public RectTransform[] overflowOrder;
  [SerializeField]
  public CardPopUpPanel popUpPrefab;
  [SerializeField]
  public CardTooltip cardTooltipPrefab;
  [SerializeField]
  public LayoutGroup[] layoutsToFix;
  [Header("Fading")]
  [SerializeField]
  public CanvasGroup backgroundFade;
  [SerializeField]
  public CanvasGroup cardInfoFade;
  [SerializeField]
  public float fadeInDur = 0.2f;
  [SerializeField]
  public float fadeOutDur = 0.1f;
  public float fade;
  [Header("Card Info Elements")]
  [SerializeField]
  public TMP_Text nameText;
  [SerializeField]
  public ImageSprite typeIcon;
  [SerializeField]
  public TMP_Text typeText;
  [Header("Tribe Flag")]
  [SerializeField]
  public Image flagImage;
  public Entity drag;
  public Entity press;
  [CompilerGenerated]
  public Entity \u003Cinspect\u003Ek__BackingField;
  public Transform previousParent;
  public int previousChildIndex;
  public const float enableAnimationDelay = 0.1f;
  public float enableAnimationTimer;
  public float currentIdleAnimationFactor;
  public bool hasAnyCharms;
  public readonly List<Tooltip> popups = new List<Tooltip>();
  public readonly List<KeywordData> currentPoppedKeywords = new List<KeywordData>();

  public Entity inspect
  {
    get => this.\u003Cinspect\u003Ek__BackingField;
    set => this.\u003Cinspect\u003Ek__BackingField = value;
  }

  public static bool IsActive()
  {
    InspectSystem objectOfType = UnityEngine.Object.FindObjectOfType<InspectSystem>();
    return (bool) (UnityEngine.Object) objectOfType && (bool) (UnityEngine.Object) objectOfType.inspect;
  }

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityUnHover);
  }

  public void Update()
  {
    if ((bool) (UnityEngine.Object) this.inspect)
    {
      if ((double) this.wait <= 0.0 && !MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      {
        if (this.hasAnyCharms && !this.inspectCharmsSystem.gameObject.activeSelf && InputSystem.IsButtonPressed(this.inspectCharmsInput))
          this.inspectCharmsSystem.Show();
        if (!this.inspectCharmsSystem.gameObject.activeSelf && ((IEnumerable<string>) this.closeInputs).Any<string>((Func<string, bool>) (i => InputSystem.IsButtonPressed(i))))
          this.InspectEnd();
      }
    }
    else if (!(bool) (UnityEngine.Object) this.press)
    {
      if (!GameManager.paused && (double) this.wait <= 0.0 && !(bool) (UnityEngine.Object) this.drag && this.hover.Count == 1 && InputSystem.IsButtonPressed(this.openInput))
        this.press = this.hover[0];
    }
    else if (!GameManager.paused && !InputSystem.IsButtonHeld(this.openInput))
    {
      if (this.hover.Count == 1 && (UnityEngine.Object) this.hover[0] == (UnityEngine.Object) this.press)
      {
        ActionInspect action = new ActionInspect(this.press, this);
        if (global::Events.CheckAction((PlayAction) action))
          action.Process();
      }
      this.press = (Entity) null;
    }
    if ((double) this.enableAnimationTimer > 0.0)
    {
      this.enableAnimationTimer -= Time.deltaTime;
      if ((double) this.enableAnimationTimer <= 0.0)
        this.EnableIdleAnimation();
    }
    if ((double) this.wait <= 0.0)
      return;
    this.wait -= Time.deltaTime;
  }

  public void Inspect(Entity entity)
  {
    this.inspect = entity;
    this.SetFlag();
    this.hasAnyCharms = entity.HasAnyCharms();
    this.inspectCharmsLayout.SetActive(this.hasAnyCharms);
    this.container.SetActive(true);
    this.StopAllCoroutines();
    this.StartCoroutine(this.FadeIn());
    this.nameText.text = entity.data.title;
    this.typeIcon.SetSprite(entity.data.cardType.icon);
    this.typeText.text = entity.data.cardType.title;
    this.CreatePopups();
    entity.ForceUnHover();
    this.previousParent = entity.transform.parent;
    this.previousChildIndex = entity.transform.GetSiblingIndex();
    entity.transform.SetParent(this.cardHolder, true);
    LeanTween.moveLocal(entity.gameObject, Vector3.zero, 0.5f).setEase(LeanTweenType.easeOutQuart);
    entity.wobbler?.WobbleRandom();
    LeanTween.scale(entity.gameObject, Vector3.one * this.cardScale, 0.67f).setEase(LeanTweenType.easeOutBack);
    float z = this.cardRandomAngle.PettyRandom().WithRandomSign();
    LeanTween.rotateLocal(entity.gameObject, new Vector3(0.0f, 0.0f, z), 1f).setEase(LeanTweenType.easeOutBack);
    if (this.idleAnimation)
      this.enableAnimationTimer = 0.1f;
    global::Events.InvokeInspect(entity);
    global::Events.InvokeEntityFocus(entity);
    this.wait = this.canEndDelay;
  }

  public void SetFlag()
  {
    ClassData classData = InspectSystem.GetClass(this.inspect.data);
    if ((bool) (UnityEngine.Object) classData)
    {
      this.flagImage.gameObject.SetActive(true);
      this.flagImage.sprite = classData.flag;
    }
    else
      this.flagImage.gameObject.SetActive(false);
  }

  public static ClassData GetClass(CardData cardData)
  {
    if (cardData.cardType.tag == "Enemy")
      return (ClassData) null;
    if (cardData.cardType.name == "Leader")
    {
      foreach (ClassData classData in References.Classes)
      {
        foreach (UnityEngine.Object leader in classData.leaders)
        {
          if (leader.name == cardData.name)
            return classData;
        }
      }
    }
    else
    {
      foreach (ClassData classData in References.Classes)
      {
        foreach (UnityEngine.Object @object in classData.startingInventory.deck)
        {
          if (@object.name == cardData.name)
            return classData;
        }
        foreach (RewardPool rewardPool in classData.rewardPools)
        {
          if (!rewardPool.isGeneralPool)
          {
            foreach (UnityEngine.Object @object in rewardPool.list)
            {
              if (@object.name == cardData.name)
                return classData;
            }
          }
        }
      }
    }
    return (ClassData) null;
  }

  public void TryInspectEnd()
  {
    if ((double) this.wait > 0.0)
      return;
    this.InspectEnd();
  }

  public void InspectEnd()
  {
    this.inspect.transform.parent = this.previousParent;
    this.inspect.transform.SetSiblingIndex(this.previousChildIndex);
    this.inspect.TweenToContainer();
    this.inspect.wobbler?.WobbleRandom();
    this.DisableIdleAnimation();
    this.StopAllCoroutines();
    this.StartCoroutine(this.FadeOut());
    global::Events.InvokeInspectEnd(this.inspect);
    this.inspect = (Entity) null;
    this.wait = this.canInspectDelay;
  }

  public IEnumerator FadeIn()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    InspectSystem inspectSystem = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    inspectSystem.UpdateFade(0.0f);
    LeanTween.cancel(inspectSystem.gameObject);
    LeanTween.value(inspectSystem.gameObject, inspectSystem.fade, 1f, inspectSystem.fadeInDur).setEase(LeanTweenType.easeOutQuad).setOnUpdate(new Action<float>(inspectSystem.UpdateFade));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) null;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public IEnumerator FadeOut()
  {
    InspectSystem inspectSystem = this;
    LeanTween.cancel(inspectSystem.gameObject);
    LeanTween.value(inspectSystem.gameObject, inspectSystem.fade, 0.0f, inspectSystem.fadeOutDur).setEase(LeanTweenType.easeOutQuad).setOnUpdate(new Action<float>(inspectSystem.UpdateFade));
    yield return (object) inspectSystem.fadeOutDur;
    yield return (object) null;
    inspectSystem.ClearPopups();
    inspectSystem.container.SetActive(false);
  }

  public void UpdateFade(float value)
  {
    this.fade = value;
    this.backgroundFade.alpha = this.fade;
    this.cardInfoFade.alpha = this.fade;
  }

  public void CreatePopups()
  {
    this.CreateIconPopups(this.inspect.display.healthLayoutGroup, (Transform) this.leftPopGroup);
    this.CreateIconPopups(this.inspect.display.damageLayoutGroup, (Transform) this.rightPopGroup);
    this.CreateIconPopups(this.inspect.display.counterLayoutGroup, (Transform) this.bottomPopGroup);
    if (this.inspect.display is Card display)
    {
      foreach (CardData mentionedCard in display.mentionedCards)
        this.Popup(mentionedCard, (Transform) this.rightPopGroup);
      foreach (KeywordData keyword in display.keywords)
        this.Popup(keyword, (Transform) this.rightPopGroup);
    }
    foreach (KeywordData hiddenKeyword in this.inspect.GetHiddenKeywords())
      this.Popup(hiddenKeyword, (Transform) this.rightPopGroup);
    List<CardData.StatusEffectStacks> injuries = this.inspect.data.injuries;
    if (injuries != null && injuries.Count > 0)
      this.Popup(this.injuredKeyword, (Transform) this.rightPopGroup);
    CoroutineManager.Start(this.FixLayoutsAfterFrame());
  }

  public void CreateIconPopups(RectTransform iconLayoutGroup, Transform popGroup)
  {
    foreach (CardPopUpTarget componentsInChild in iconLayoutGroup.GetComponentsInChildren<CardPopUpTarget>())
    {
      foreach (KeywordData keyword in componentsInChild.keywords)
        this.Popup(keyword, popGroup);
    }
  }

  public void ClearPopups()
  {
    foreach (Component popup in this.popups)
      popup.gameObject.Destroy();
    this.popups.Clear();
    this.currentPoppedKeywords.Clear();
  }

  public IEnumerator FixLayoutsAfterFrame()
  {
    yield return (object) null;
    yield return (object) this.FixLayouts();
  }

  public IEnumerator FixLayouts()
  {
    InspectSystem inspectSystem = this;
    yield return (object) null;
    foreach (LayoutGroup layoutGroup in inspectSystem.layoutsToFix)
    {
      switch (layoutGroup)
      {
        case VerticalLayoutGroup layout1:
          layout1.FitToChildren();
          break;
        case HorizontalLayoutGroup layout2:
          layout2.FitToChildren();
          break;
      }
    }
    if (inspectSystem.CheckOverflow(inspectSystem.bottomPopGroup))
      yield return (object) inspectSystem.FixLayouts();
  }

  public bool CheckOverflow(params RectTransform[] checkCollide)
  {
    for (int index = 0; index < this.overflowOrder.Length - 1; ++index)
    {
      RectTransform target = this.overflowOrder[index];
      if (target.childCount > 0 && InspectSystem.CheckCollide(target, (IEnumerable<RectTransform>) checkCollide))
      {
        Transform child = target.GetChild(target.childCount - 1);
        child.SetParent((Transform) this.overflowOrder[index + 1]);
        child.SetSiblingIndex(0);
        return true;
      }
    }
    return false;
  }

  public static bool CheckCollide(RectTransform target, IEnumerable<RectTransform> checks)
  {
    foreach (RectTransform check in checks)
    {
      if (InspectSystem.RectOverlap(target, check))
      {
        Debug.Log((object) string.Format("[{0}] Overlaps [{1}]", (object) target.rect, (object) check.rect));
        return true;
      }
    }
    return false;
  }

  public static bool RectOverlap(RectTransform a, RectTransform b)
  {
    Vector3 position1 = a.position;
    Vector2 size1 = a.rect.size;
    Vector2 pivot1 = a.pivot;
    Rect rect = new Rect(position1.x - pivot1.x * size1.x, position1.y - pivot1.y * size1.y, size1.x, size1.y);
    Vector3 position2 = b.position;
    Vector2 size2 = b.rect.size;
    Vector2 pivot2 = b.pivot;
    Rect other = new Rect(position2.x - pivot2.x * size2.x, position2.y - pivot2.y * size2.y, size2.x, size2.y);
    return rect.Overlaps(other);
  }

  public CardPopUpPanel Popup(KeywordData keyword, Transform group)
  {
    if (this.currentPoppedKeywords.Contains(keyword))
      return (CardPopUpPanel) null;
    CardPopUpPanel panel = UnityEngine.Object.Instantiate<CardPopUpPanel>(this.popUpPrefab, group);
    panel.gameObject.name = keyword.name;
    panel.Set(keyword);
    global::Events.InvokePopupPanelCreated(keyword, panel);
    this.currentPoppedKeywords.Add(keyword);
    this.popups.Add((Tooltip) panel);
    foreach (KeywordData keyword1 in Text.GetKeywords(keyword.body))
    {
      CardPopUpPanel cardPopUpPanel = this.Popup(keyword1, group);
      panel.children.AddIfNotNull<Tooltip>((Tooltip) cardPopUpPanel);
    }
    return panel;
  }

  public CardTooltip Popup(CardData cardData, Transform group)
  {
    CardTooltip cardTooltip = UnityEngine.Object.Instantiate<CardTooltip>(this.cardTooltipPrefab, group);
    cardTooltip.gameObject.name = cardData.name;
    cardTooltip.Set(cardData);
    this.popups.Add((Tooltip) cardTooltip);
    foreach (KeywordData keyword in cardTooltip.keywords)
    {
      CardPopUpPanel cardPopUpPanel = this.Popup(keyword, group);
      cardTooltip.children.AddIfNotNull<Tooltip>((Tooltip) cardPopUpPanel);
    }
    return cardTooltip;
  }

  public void EnableIdleAnimation()
  {
    if (!(bool) (UnityEngine.Object) this.inspect?.data?.idleAnimationProfile || !(this.inspect.display is Card display) || (double) this.idleAnimationFactor == 0.0)
      return;
    if ((bool) (UnityEngine.Object) display.imageIdleAnimator)
    {
      display.imageIdleAnimator.FadeIn();
      display.imageIdleAnimator.strength *= this.idleAnimationFactor;
    }
    if ((bool) (UnityEngine.Object) display.backgroundIdleAnimator)
    {
      display.backgroundIdleAnimator.FadeIn();
      display.backgroundIdleAnimator.strength *= this.idleAnimationFactor;
    }
    this.currentIdleAnimationFactor = this.idleAnimationFactor;
  }

  public void DisableIdleAnimation()
  {
    if (!(this.inspect?.display is Card display))
      return;
    if ((bool) (UnityEngine.Object) display.imageIdleAnimator)
    {
      display.imageIdleAnimator.FadeOut();
      display.imageIdleAnimator.strength /= this.currentIdleAnimationFactor;
    }
    if (!(bool) (UnityEngine.Object) display.backgroundIdleAnimator)
      return;
    display.backgroundIdleAnimator.FadeOut();
    display.backgroundIdleAnimator.strength /= this.currentIdleAnimationFactor;
  }

  public void EntityHover(Entity entity)
  {
    if (this.hover.Contains(entity))
      return;
    this.hover.Add(entity);
  }

  public void EntityUnHover(Entity entity) => this.hover.Remove(entity);

  public void EntityDrag(Entity entity) => this.drag = entity;

  public void EntityRelease(Entity entity)
  {
    if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.drag))
      return;
    this.drag = (Entity) null;
  }
}
