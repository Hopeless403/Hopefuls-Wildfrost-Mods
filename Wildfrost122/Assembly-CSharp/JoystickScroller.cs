// Decompiled with JetBrains decompiler
// Type: JoystickScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (ScrollRect))]
public class JoystickScroller : MonoBehaviour
{
  [SerializeField]
  private string scrollAction = "Scroll Vertical";
  private ScrollRect _scrollRect;
  private readonly Vector2 add = new Vector2(0.0f, -20f);

  private ScrollRect scrollRect
  {
    get => this._scrollRect ?? (this._scrollRect = this.GetComponent<ScrollRect>());
  }

  private void LateUpdate()
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
