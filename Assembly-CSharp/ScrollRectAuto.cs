// Decompiled with JetBrains decompiler
// Type: ScrollRectAuto
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof (ScrollRect))]
public class ScrollRectAuto : MonoBehaviour, IDragHandler, IEventSystemHandler, IScrollHandler
{
  private ScrollRect _scrollRect;
  [SerializeField]
  private float activateTime = 1f;
  [SerializeField]
  private float scrollSpeed = 1f;
  [SerializeField]
  private float acceleration = 1f;
  [SerializeField]
  private bool disableAtBottom = true;
  [SerializeField]
  private bool disableOnDrag = true;
  [SerializeField]
  private bool disableOnMouseScroll = true;
  [SerializeField]
  private bool reactivate = true;
  [SerializeField]
  [ShowIf("reactivate")]
  private float reactivateTime = 1f;
  [SerializeField]
  private UnityEvent onReachBottom;
  private float scrollSpeedCurrent;
  private static readonly Vector2 scroll = new Vector2(0.0f, 1f);
  private bool active = true;
  private float reactivateTimer;

  private ScrollRect scrollRect => this._scrollRect ?? (this._scrollRect = this.GetComponent<ScrollRect>());

  private void Update()
  {
    if (!(bool) (Object) this.scrollRect.content)
      return;
    if ((double) this.activateTime > 0.0)
      this.activateTime -= Time.deltaTime;
    else if (!this.active)
    {
      if ((double) this.reactivateTimer <= 0.0)
        return;
      this.reactivateTimer -= Time.deltaTime;
      if ((double) this.reactivateTimer > 0.0)
        return;
      this.active = true;
    }
    else
    {
      this.scrollSpeedCurrent = Delta.Lerp(this.scrollSpeedCurrent, this.scrollSpeed, this.acceleration, Time.deltaTime);
      this.scrollRect.content.anchoredPosition += ScrollRectAuto.scroll * (this.scrollSpeedCurrent * Time.deltaTime);
      if ((double) this.scrollRect.normalizedPosition.y > 0.0)
        return;
      this.onReachBottom?.Invoke();
      if (!this.disableAtBottom)
        return;
      this.Stop();
      this.reactivateTimer = 0.0f;
    }
  }

  public void OnDrag(PointerEventData eventData)
  {
    if (!this.disableOnDrag)
      return;
    this.Stop();
  }

  public void OnScroll(PointerEventData eventData)
  {
    if (!this.disableOnMouseScroll)
      return;
    this.Stop();
  }

  private void Stop()
  {
    this.active = false;
    if (this.reactivate)
      this.reactivateTimer = this.reactivateTime;
    this.scrollSpeedCurrent = 0.0f;
  }
}
