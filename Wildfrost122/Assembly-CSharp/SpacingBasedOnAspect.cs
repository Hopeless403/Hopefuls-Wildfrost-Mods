// Decompiled with JetBrains decompiler
// Type: SpacingBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (HorizontalOrVerticalLayoutGroup))]
public class SpacingBasedOnAspect : MonoBehaviour
{
  [SerializeField]
  private AnimationCurve curve;
  [SerializeField]
  private float maxSpacing;
  [SerializeField]
  private float minSpacing;
  private HorizontalOrVerticalLayoutGroup _layout;

  private HorizontalOrVerticalLayoutGroup layout
  {
    get => this._layout ?? (this._layout = this.GetComponent<HorizontalOrVerticalLayoutGroup>());
  }

  public void UpdatePosition(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    this.layout.spacing = this.minSpacing + (this.maxSpacing - this.minSpacing) * this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
  }
}
