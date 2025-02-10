// Decompiled with JetBrains decompiler
// Type: Shadow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Graphic))]
public class Shadow : MonoBehaviourCacheTransform
{
  [SerializeField]
  private Graphic graphic;
  [SerializeField]
  private Vector2 alphaRange;
  public Transform target;
  public CanvasGroup canvasGroup;
  private float preAlpha = -1f;

  public void Assign(Entity entity)
  {
    this.target = entity.offset.transform;
    if (!(entity.display is Card display))
      return;
    CanvasGroup canvasGroup = display.canvasGroup;
    if (canvasGroup == null)
      return;
    this.canvasGroup = canvasGroup;
  }

  public void UpdateAlpha()
  {
    if ((double) Mathf.Abs(this.canvasGroup.alpha - this.preAlpha) > 0.0099999997764825821)
      this.graphic.color = this.graphic.color.WithAlpha(Mathf.Lerp(this.alphaRange.x, this.alphaRange.y, this.canvasGroup.alpha));
    this.preAlpha = this.canvasGroup.alpha;
  }
}
