// Decompiled with JetBrains decompiler
// Type: CardInspector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CardInspector : MonoBehaviour
{
  [SerializeField]
  public bool animatePopUps = true;
  [SerializeField]
  public bool ignoreTimeScale;
  [SerializeField]
  public bool showHiddenKeywords = true;
  [SerializeField]
  [ShowIf("showHiddenKeywords")]
  public KeywordData injuredKeyword;
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
  public RectTransform[] overflowOrder;
  [SerializeField]
  public CardPopUpPanel popUpPrefab;
  [SerializeField]
  public CardTooltip cardTooltipPrefab;
  [SerializeField]
  public LayoutGroup[] layoutsToFix;
  public readonly List<Tooltip> popups = new List<Tooltip>();
  public readonly List<KeywordData> currentPoppedKeywords = new List<KeywordData>();

  public void CreatePopups(Entity inspect)
  {
    Events.InvokeEntityHover(inspect);
    this.CreateIconPopups(inspect.display.healthLayoutGroup, (Transform) this.leftPopGroup);
    this.CreateIconPopups(inspect.display.damageLayoutGroup, (Transform) this.rightPopGroup);
    this.CreateIconPopups(inspect.display.counterLayoutGroup, (Transform) this.bottomPopGroup);
    if (inspect.display is Card display)
    {
      foreach (CardData mentionedCard in display.mentionedCards)
        this.Popup(mentionedCard, (Transform) this.rightPopGroup);
      foreach (KeywordData keyword in display.keywords)
        this.Popup(keyword, (Transform) this.rightPopGroup);
    }
    if (this.showHiddenKeywords)
    {
      foreach (KeywordData hiddenKeyword in inspect.GetHiddenKeywords())
        this.Popup(hiddenKeyword, (Transform) this.rightPopGroup);
      List<CardData.StatusEffectStacks> injuries = inspect.data.injuries;
      if (injuries != null && injuries.Count > 0)
        this.Popup(this.injuredKeyword, (Transform) this.rightPopGroup);
    }
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
    CardInspector cardInspector = this;
    yield return (object) null;
    foreach (LayoutGroup layoutGroup in cardInspector.layoutsToFix)
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
    if (cardInspector.CheckOverflow(cardInspector.bottomPopGroup))
      yield return (object) cardInspector.FixLayouts();
  }

  public bool CheckOverflow(params RectTransform[] checkCollide)
  {
    for (int index = 0; index < this.overflowOrder.Length - 1; ++index)
    {
      RectTransform target = this.overflowOrder[index];
      if (target.childCount > 0 && CardInspector.CheckCollide(target, (IEnumerable<RectTransform>) checkCollide))
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
      if (CardInspector.RectOverlap(target, check))
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
    CardPopUpPanel panel = Object.Instantiate<CardPopUpPanel>(this.popUpPrefab, group);
    panel.gameObject.name = keyword.name;
    panel.animate = this.animatePopUps;
    panel.ignoreTimeScale = this.ignoreTimeScale;
    panel.Set(keyword);
    Events.InvokePopupPanelCreated(keyword, panel);
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
    CardTooltip cardTooltip = Object.Instantiate<CardTooltip>(this.cardTooltipPrefab, group);
    cardTooltip.gameObject.name = cardData.name;
    cardTooltip.animate = this.animatePopUps;
    cardTooltip.ignoreTimeScale = this.ignoreTimeScale;
    cardTooltip.Set(cardData);
    this.popups.Add((Tooltip) cardTooltip);
    foreach (KeywordData keyword in cardTooltip.keywords)
    {
      CardPopUpPanel cardPopUpPanel = this.Popup(keyword, group);
      cardTooltip.children.AddIfNotNull<Tooltip>((Tooltip) cardPopUpPanel);
    }
    return cardTooltip;
  }
}
