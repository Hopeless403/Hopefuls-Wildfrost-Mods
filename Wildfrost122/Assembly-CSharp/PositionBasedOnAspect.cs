// Decompiled with JetBrains decompiler
// Type: PositionBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class PositionBasedOnAspect : MonoBehaviourRect
{
  [SerializeField]
  private AnimationCurve curve;
  [SerializeField]
  private Vector3 maxPosition;
  [SerializeField]
  private Vector3 minPosition;

  public void UpdatePosition(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    this.rectTransform.anchoredPosition3D = this.minPosition + (this.maxPosition - this.minPosition) * this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
  }
}
