// Decompiled with JetBrains decompiler
// Type: ScrollToNavigation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ScrollToNavigation : MonoBehaviour
{
  [SerializeField]
  public Scroller scroller;
  [SerializeField]
  public SmoothScrollRect scrollRect;

  public bool HasScroller => (bool) (Object) this.scroller;

  public bool HasScrollRect => (bool) (Object) this.scrollRect;

  public void OnEnable() => global::Events.OnUINavigation += new UnityAction(this.Navigation);

  public void OnDisable() => global::Events.OnUINavigation -= new UnityAction(this.Navigation);

  public void Navigation()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return;
    UINavigationItem currentNavigationItem = MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem;
    if (this.HasScroller && this.scroller.ContentLargerThanBounds())
    {
      this.TryScrollScroller(currentNavigationItem.transform);
    }
    else
    {
      if (!this.HasScrollRect)
        return;
      this.TryScrollScrollRect(currentNavigationItem.transform);
    }
  }

  public void TryScrollScroller(Transform target)
  {
    if (!target.IsChildOf(this.scroller.transform))
      return;
    if (this.scroller.horizontal)
      this.ScrollScrollerHorizontal(target);
    else
      this.ScrollScrollerVertical(target);
  }

  public void ScrollScrollerVertical(Transform target)
  {
    this.scroller.ScrollTo(this.scroller.targetPos.WithY(this.scroller.transform.position.y - target.position.y));
  }

  public void ScrollScrollerHorizontal(Transform target)
  {
    this.scroller.ScrollTo(this.scroller.targetPos.WithX(this.scroller.transform.position.x - target.position.x));
  }

  public void TryScrollScrollRect(Transform target)
  {
    if (!target.IsChildOf(this.scrollRect.transform))
      return;
    if (this.scrollRect.horizontal)
      this.ScrollScrollRectHorizontal(target);
    else
      this.ScrollScrollRectVertical(target);
  }

  public void ScrollScrollRectVertical(Transform target)
  {
    this.scrollRect.ScrollTo(this.scrollRect.content.anchoredPosition.WithY((float) -((double) target.position.y - (double) this.scrollRect.content.position.y + (double) this.scrollRect.viewport.rect.size.y * 0.5)));
  }

  public void ScrollScrollRectHorizontal(Transform target)
  {
    this.scrollRect.ScrollTo(this.scrollRect.content.anchoredPosition.WithX((float) -((double) target.position.x - (double) this.scrollRect.content.position.x + (double) this.scrollRect.viewport.rect.size.x * 0.5)));
  }
}
