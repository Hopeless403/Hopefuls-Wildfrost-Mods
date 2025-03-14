﻿// Decompiled with JetBrains decompiler
// Type: PositionBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
