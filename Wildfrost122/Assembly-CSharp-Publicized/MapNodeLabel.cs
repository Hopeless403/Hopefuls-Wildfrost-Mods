// Decompiled with JetBrains decompiler
// Type: MapNodeLabel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class MapNodeLabel : MonoBehaviour
{
  [SerializeField]
  public SpriteRenderer spriteRenderer;
  [SerializeField]
  public TextMeshFitter textFitter;
  public Vector3 startPos;
  public Color startColor;

  public void Awake()
  {
    this.startPos = this.transform.localPosition;
    this.startColor = this.spriteRenderer.color;
  }

  public void Show()
  {
    this.gameObject.SetActive(true);
    LeanTween.cancel(this.gameObject);
    LeanTween.cancel(this.spriteRenderer.gameObject);
    this.transform.localPosition = this.startPos + new Vector3(0.0f, -0.15f, 0.0f);
    LeanTween.moveLocal(this.gameObject, this.startPos, 1f).setEase(LeanTweenType.easeOutElastic);
    this.spriteRenderer.color = this.startColor.With(alpha: 0.0f);
    LeanTween.color(this.spriteRenderer.gameObject, this.startColor, 0.25f).setEase(LeanTweenType.easeOutQuart);
  }

  public void Hide() => this.gameObject.SetActive(false);
}
