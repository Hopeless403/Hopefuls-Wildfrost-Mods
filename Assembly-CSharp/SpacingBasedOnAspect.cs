// Decompiled with JetBrains decompiler
// Type: SpacingBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

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

  private HorizontalOrVerticalLayoutGroup layout => this._layout ?? (this._layout = this.GetComponent<HorizontalOrVerticalLayoutGroup>());

  public void UpdatePosition(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    this.layout.spacing = this.minSpacing + (this.maxSpacing - this.minSpacing) * this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
  }
}
