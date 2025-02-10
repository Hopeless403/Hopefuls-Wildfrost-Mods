// Decompiled with JetBrains decompiler
// Type: JoystickScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (ScrollRect))]
public class JoystickScroller : MonoBehaviour
{
  [SerializeField]
  public string scrollAction = "Scroll Vertical";
  public ScrollRect _scrollRect;
  public readonly Vector2 add = new Vector2(0.0f, -20f);

  public ScrollRect scrollRect => this._scrollRect ?? (this._scrollRect = this.GetComponent<ScrollRect>());

  public void LateUpdate()
  {
    if (!this.scrollRect.enabled)
      return;
    float axis = InputSystem.GetAxis(this.scrollAction);
    if ((double) Mathf.Abs(axis) <= 1.4012984643248171E-45 || !(bool) (Object) this.scrollRect.content)
      return;
    float normalizedPosition = this.scrollRect.verticalNormalizedPosition;
    if (((double) axis <= 0.0 || (double) normalizedPosition >= 1.0) && ((double) axis >= 0.0 || (double) normalizedPosition <= 0.0))
      return;
    this.scrollRect.content.anchoredPosition += this.add * (axis * Mathf.Abs(axis) * Time.unscaledDeltaTime);
  }
}
