// Decompiled with JetBrains decompiler
// Type: GridLayoutBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

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

  public GridLayoutGroup layoutGroup => this._layoutGroup ?? (this._layoutGroup = this.GetComponent<GridLayoutGroup>());

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
