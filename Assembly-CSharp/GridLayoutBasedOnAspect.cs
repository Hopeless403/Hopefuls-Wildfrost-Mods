// Decompiled with JetBrains decompiler
// Type: GridLayoutBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof (GridLayoutGroup))]
public class GridLayoutBasedOnAspect : MonoBehaviour
{
  private GridLayoutGroup _layoutGroup;
  [SerializeField]
  private AnimationCurve curve;
  [SerializeField]
  private bool setSpacing;
  [SerializeField]
  [ShowIf("setSpacing")]
  private Vector2 minSpacing;
  [SerializeField]
  [ShowIf("setSpacing")]
  private Vector2 maxSpacing;
  [SerializeField]
  private bool autoLinkToParent;

  private GridLayoutGroup layoutGroup => this._layoutGroup ?? (this._layoutGroup = this.GetComponent<GridLayoutGroup>());

  private void Awake()
  {
    if (!this.autoLinkToParent)
      return;
    WorldSpaceCanvasFitScreen componentInParent = this.transform.GetComponentInParent<WorldSpaceCanvasFitScreen>();
    if (!(bool) (Object) componentInParent)
      return;
    componentInParent.onUpdate.AddListener(new UnityAction<RectTransform>(this.UpdateLayout));
    this.UpdateLayout(componentInParent.rectTransform);
  }

  public void UpdateLayout(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    float num = this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
    if (!this.setSpacing)
      return;
    this.layoutGroup.spacing = this.minSpacing + (this.maxSpacing - this.minSpacing) * num;
  }
}
