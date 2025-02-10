// Decompiled with JetBrains decompiler
// Type: SpacingBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (HorizontalOrVerticalLayoutGroup))]
public class SpacingBasedOnAspect : MonoBehaviour
{
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public float maxSpacing;
  [SerializeField]
  public float minSpacing;
  public HorizontalOrVerticalLayoutGroup _layout;

  public HorizontalOrVerticalLayoutGroup layout
  {
    get => this._layout ?? (this._layout = this.GetComponent<HorizontalOrVerticalLayoutGroup>());
  }

  public void UpdatePosition(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    this.layout.spacing = this.minSpacing + (this.maxSpacing - this.minSpacing) * this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
  }
}
