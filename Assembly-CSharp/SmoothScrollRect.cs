// Decompiled with JetBrains decompiler
// Type: SmoothScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SmoothScrollRect : ScrollRect
{
  [SerializeField]
  private float speed = 1f;
  private const float smoothScrollTime = 0.1f;
  private const LeanTweenType smoothScrollEase = LeanTweenType.easeOutQuart;
  private LTDescr tween;

  public override void OnScroll(PointerEventData data)
  {
    if (!this.isActiveAndEnabled)
      return;
    Vector2 normalizedPosition = this.normalizedPosition;
    if (this.tween != null)
      LeanTween.cancel(this.tween.uniqueId);
    base.OnScroll(data);
    Vector2 to = this.normalizedPosition.Clamp(Vector2.zero, Vector2.one);
    this.normalizedPosition = normalizedPosition;
    this.tween = LeanTween.value(this.gameObject, normalizedPosition, to, this.scrollSensitivity * 0.1f).setEase(LeanTweenType.easeOutQuart).setOnUpdateVector2((Action<Vector2>) (a => this.normalizedPosition = a));
    this.tween.setIgnoreTimeScale(true);
  }

  public void ScrollTo(Vector2 targetPosition)
  {
    Vector2 normalizedPosition = this.normalizedPosition;
    if (this.tween != null)
      LeanTween.cancel(this.tween.uniqueId);
    this.content.anchoredPosition = targetPosition;
    Vector2 to = this.normalizedPosition.Clamp(Vector2.zero, Vector2.one);
    this.normalizedPosition = normalizedPosition;
    this.tween = LeanTween.value(this.gameObject, normalizedPosition, to, this.scrollSensitivity * 0.1f / this.speed).setEase(LeanTweenType.easeOutQuart).setOnUpdateVector2((Action<Vector2>) (a => this.normalizedPosition = a));
    this.tween.setIgnoreTimeScale(true);
  }

  public void SetContent(GameObject comp)
  {
    RectTransform component = comp.GetComponent<RectTransform>();
    if (component == null)
      return;
    this.content = component;
  }

  public void SetContent(RectTransform rectTransform) => this.content = rectTransform;

  public void ScrollToTop() => this.verticalNormalizedPosition = 1f;

  public void ScrollToTopAfterFrame() => this.StartCoroutine(this.ScrollToTopAfterFrameRoutine());

  private IEnumerator ScrollToTopAfterFrameRoutine()
  {
    yield return (object) new WaitForEndOfFrame();
    this.ScrollToTop();
  }
}
