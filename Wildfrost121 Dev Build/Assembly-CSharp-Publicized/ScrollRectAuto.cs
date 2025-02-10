// Decompiled with JetBrains decompiler
// Type: ScrollRectAuto
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (ScrollRect))]
public class ScrollRectAuto : MonoBehaviour, IDragHandler, IEventSystemHandler, IScrollHandler
{
  public ScrollRect _scrollRect;
  [SerializeField]
  public float activateTime = 1f;
  [SerializeField]
  public float scrollSpeed = 1f;
  [SerializeField]
  public float acceleration = 1f;
  [SerializeField]
  public bool disableAtBottom = true;
  [SerializeField]
  public bool disableOnDrag = true;
  [SerializeField]
  public bool disableOnMouseScroll = true;
  [SerializeField]
  public bool reactivate = true;
  [SerializeField]
  [ShowIf("reactivate")]
  public float reactivateTime = 1f;
  [SerializeField]
  public UnityEvent onReachBottom;
  public float scrollSpeedCurrent;
  public static readonly Vector2 scroll = new Vector2(0.0f, 1f);
  public bool active = true;
  public float reactivateTimer;

  public ScrollRect scrollRect
  {
    get => this._scrollRect ?? (this._scrollRect = this.GetComponent<ScrollRect>());
  }

  public void Update()
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

  public void Stop()
  {
    this.active = false;
    if (this.reactivate)
      this.reactivateTimer = this.reactivateTime;
    this.scrollSpeedCurrent = 0.0f;
  }
}
