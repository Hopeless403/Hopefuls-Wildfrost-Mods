// Decompiled with JetBrains decompiler
// Type: ScrollToNavigation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ScrollToNavigation : MonoBehaviour
{
  [SerializeField]
  private Scroller scroller;
  [SerializeField]
  private SmoothScrollRect scrollRect;

  private bool HasScroller => (bool) (Object) this.scroller;

  private bool HasScrollRect => (bool) (Object) this.scrollRect;

  private void OnEnable() => global::Events.OnUINavigation += new UnityAction(this.Navigation);

  private void OnDisable() => global::Events.OnUINavigation -= new UnityAction(this.Navigation);

  private void Navigation()
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

  private void TryScrollScroller(Transform target)
  {
    if (!target.IsChildOf(this.scroller.transform))
      return;
    if (this.scroller.horizontal)
      this.ScrollScrollerHorizontal(target);
    else
      this.ScrollScrollerVertical(target);
  }

  private void ScrollScrollerVertical(Transform target)
  {
    this.scroller.ScrollTo(this.scroller.targetPos.WithY(this.scroller.transform.position.y - target.position.y));
  }

  private void ScrollScrollerHorizontal(Transform target)
  {
    this.scroller.ScrollTo(this.scroller.targetPos.WithX(this.scroller.transform.position.x - target.position.x));
  }

  private void TryScrollScrollRect(Transform target)
  {
    if (!target.IsChildOf(this.scrollRect.transform))
      return;
    if (this.scrollRect.horizontal)
      this.ScrollScrollRectHorizontal(target);
    else
      this.ScrollScrollRectVertical(target);
  }

  private void ScrollScrollRectVertical(Transform target)
  {
    this.scrollRect.ScrollTo(this.scrollRect.content.anchoredPosition.WithY((float) -((double) target.position.y - (double) this.scrollRect.content.position.y + (double) this.scrollRect.viewport.rect.size.y * 0.5)));
  }

  private void ScrollScrollRectHorizontal(Transform target)
  {
    this.scrollRect.ScrollTo(this.scrollRect.content.anchoredPosition.WithX((float) -((double) target.position.x - (double) this.scrollRect.content.position.x + (double) this.scrollRect.viewport.rect.size.x * 0.5)));
  }
}
