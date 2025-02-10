// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasSafeArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class WorldSpaceCanvasSafeArea : WorldSpaceCanvasUpdater
{
  [SerializeField]
  public RectTransform parent;
  [SerializeField]
  public bool considerX = true;
  [SerializeField]
  public bool considerY;
  public bool waitForParent;

  public void LateUpdate()
  {
    if (!this.waitForParent || !this.parent.gameObject.activeSelf || !WorldSpaceCanvasFitScreenSystem.exists)
      return;
    Vector2 sizeDelta = this.parent.sizeDelta;
    float num1 = this.considerX ? WorldSpaceCanvasFitScreenSystem.instance.safeArea.x : 0.0f;
    float num2 = this.considerY ? WorldSpaceCanvasFitScreenSystem.instance.safeArea.y : 0.0f;
    float num3 = this.considerX ? WorldSpaceCanvasFitScreenSystem.instance.safeArea.width : 1f;
    float num4 = this.considerY ? WorldSpaceCanvasFitScreenSystem.instance.safeArea.height : 1f;
    float num5 = this.considerX ? 1f - WorldSpaceCanvasFitScreenSystem.instance.safeArea.width - WorldSpaceCanvasFitScreenSystem.instance.safeArea.x : 0.0f;
    float num6 = this.considerY ? 1f - WorldSpaceCanvasFitScreenSystem.instance.safeArea.height - WorldSpaceCanvasFitScreenSystem.instance.safeArea.y : 0.0f;
    double num7 = (double) num3 * (double) sizeDelta.x;
    float num8 = num4 * sizeDelta.y;
    double num9 = (double) num8;
    if (num7 / num9 < 1.5)
    {
      double num10 = (double) num8 * 1.5 / (double) sizeDelta.x;
      float num11 = (float) num10 - num3;
      num1 = Mathf.Max(0.0f, num1 - num11);
      num5 = Mathf.Max(0.0f, num5 - num11);
      num3 = (float) num10;
    }
    if (this.rectTransform.anchorMin == Vector2.zero && this.rectTransform.anchorMax == Vector2.one)
    {
      this.rectTransform.offsetMin = new Vector2(sizeDelta.x * num1, sizeDelta.y * num2);
      this.rectTransform.offsetMax = new Vector2(sizeDelta.x * -num5, sizeDelta.y * -num6);
    }
    else
    {
      this.rectTransform.sizeDelta = new Vector2(sizeDelta.x * num3, sizeDelta.y * num4);
      this.rectTransform.anchoredPosition = new Vector2(sizeDelta.x * num1, sizeDelta.y * num2);
    }
    this.waitForParent = false;
  }

  public override void UpdateSize() => this.waitForParent = true;
}
