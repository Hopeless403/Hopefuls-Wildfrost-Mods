// Decompiled with JetBrains decompiler
// Type: GridLayoutBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (GridLayoutGroup))]
public class GridLayoutBasedOnAspect : MonoBehaviour
{
  public GridLayoutGroup _layoutGroup;
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public bool setSpacing;
  [SerializeField]
  [ShowIf("setSpacing")]
  public Vector2 minSpacing;
  [SerializeField]
  [ShowIf("setSpacing")]
  public Vector2 maxSpacing;
  [SerializeField]
  public bool autoLinkToParent;

  public GridLayoutGroup layoutGroup
  {
    get => this._layoutGroup ?? (this._layoutGroup = this.GetComponent<GridLayoutGroup>());
  }

  public void Awake()
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
