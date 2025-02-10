// Decompiled with JetBrains decompiler
// Type: ScaleBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class ScaleBasedOnAspect : MonoBehaviour
{
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public Vector3 maxScale;
  [SerializeField]
  public Vector3 minScale;
  [SerializeField]
  public bool autoLinkToParent;

  public void Awake()
  {
    if (!this.autoLinkToParent)
      return;
    WorldSpaceCanvasFitScreen componentInParent = this.transform.GetComponentInParent<WorldSpaceCanvasFitScreen>();
    if (!(bool) (Object) componentInParent)
      return;
    componentInParent.onUpdate.AddListener(new UnityAction<RectTransform>(this.UpdateScale));
    this.UpdateScale(componentInParent.rectTransform);
  }

  public void UpdateScale(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    this.transform.localScale = this.minScale + (this.maxScale - this.minScale) * this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
  }
}
