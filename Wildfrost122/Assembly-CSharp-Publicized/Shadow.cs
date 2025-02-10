// Decompiled with JetBrains decompiler
// Type: Shadow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Graphic))]
public class Shadow : MonoBehaviourCacheTransform
{
  [SerializeField]
  public Graphic graphic;
  [SerializeField]
  public Vector2 alphaRange;
  public Transform target;
  public CanvasGroup canvasGroup;
  public float preAlpha = -1f;

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
