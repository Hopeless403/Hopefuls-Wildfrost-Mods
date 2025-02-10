// Decompiled with JetBrains decompiler
// Type: TouchScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class TouchScroller : MonoBehaviour
{
  [SerializeField]
  private Scroller scroller;
  [SerializeField]
  private bool horizontal;
  [SerializeField]
  private bool vertical = true;
  [SerializeField]
  private float sensitivity = 0.0215f;
  [SerializeField]
  private float inertia = 0.15f;
  private float vx;
  private float vy;
  private const float threshold = 0.01f;

  private void Update()
  {
    if (!TouchInputModule.active || !this.horizontal && !this.vertical || !this.scroller.interactable || !this.scroller.CheckNavigationLayer() || (double) this.scroller.DeltaTime <= 0.0)
    {
      this.vx = 0.0f;
      this.vy = 0.0f;
    }
    else
    {
      Vector2 anchoredPosition = this.scroller.rectTransform.anchoredPosition;
      bool flag = false;
      if (this.horizontal)
      {
        float f = this.scroller.interactable ? TouchInputModule.ScrollX * this.sensitivity : 0.0f;
        if (TouchInputModule.touching)
        {
          if ((double) Mathf.Abs(f) > 0.0099999997764825821)
          {
            anchoredPosition.x += f;
            this.vx = f;
            flag = true;
          }
        }
        else if ((double) Mathf.Abs(this.vx) > 0.0099999997764825821)
        {
          anchoredPosition.x += this.vx;
          flag = true;
        }
      }
      if (this.vertical)
      {
        float f = this.scroller.interactable ? TouchInputModule.ScrollY * this.sensitivity : 0.0f;
        if (TouchInputModule.touching)
        {
          if ((double) Mathf.Abs(f) > 0.0099999997764825821)
          {
            anchoredPosition.y += f;
            this.vy = f;
            flag = true;
          }
        }
        else if ((double) Mathf.Abs(this.vy) > 0.0099999997764825821)
        {
          anchoredPosition.y += this.vy;
          flag = true;
        }
      }
      if (flag)
      {
        this.scroller.ScrollTo(anchoredPosition);
        this.scroller.CheckBounds();
        this.scroller.rectTransform.anchoredPosition = this.scroller.targetPos;
      }
      if (this.horizontal)
        this.vx = Delta.Lerp(this.vx, 0.0f, this.inertia, this.scroller.DeltaTime);
      if (!this.vertical)
        return;
      this.vy = Delta.Lerp(this.vy, 0.0f, this.inertia, this.scroller.DeltaTime);
    }
  }
}
