// Decompiled with JetBrains decompiler
// Type: ScaleBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class ScaleBasedOnAspect : MonoBehaviour
{
  [SerializeField]
  private AnimationCurve curve;
  [SerializeField]
  private Vector3 maxScale;
  [SerializeField]
  private Vector3 minScale;
  [SerializeField]
  private bool autoLinkToParent;

  private void Awake()
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
