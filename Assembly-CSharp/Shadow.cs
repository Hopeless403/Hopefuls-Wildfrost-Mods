// Decompiled with JetBrains decompiler
// Type: Shadow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

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
