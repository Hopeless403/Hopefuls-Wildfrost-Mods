// Decompiled with JetBrains decompiler
// Type: PositionBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class PositionBasedOnAspect : MonoBehaviourRect
{
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public Vector3 maxPosition;
  [SerializeField]
  public Vector3 minPosition;

  public void UpdatePosition(RectTransform canvas)
  {
    Vector2 sizeDelta = canvas.sizeDelta;
    this.rectTransform.anchoredPosition3D = this.minPosition + (this.maxPosition - this.minPosition) * this.curve.Evaluate(sizeDelta.x / sizeDelta.y);
  }
}
