// Decompiled with JetBrains decompiler
// Type: LargeUIScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;

public class LargeUIScaler : WorldSpaceCanvasUpdater
{
  [SerializeField]
  private bool setScale = true;
  [SerializeField]
  [ShowIf("setScale")]
  [FormerlySerializedAs("scaleMinV")]
  private Vector3 scaleMin = Vector3.one;
  [SerializeField]
  [ShowIf("setScale")]
  [FormerlySerializedAs("scaleMaxV")]
  private Vector3 scaleMax = Vector3.one;
  [SerializeField]
  private bool setPosition;
  [SerializeField]
  [ShowIf("setPosition")]
  private Vector3 positionMin;
  [SerializeField]
  [ShowIf("setPosition")]
  private Vector3 positionMax;
  [SerializeField]
  private AnimationCurve aspectRatioInfluence;

  public override void UpdateSize()
  {
    if (!this.setScale && !this.setPosition)
      return;
    float t = 0.0f;
    if (this.aspectRatioInfluence.length > 0)
      t *= this.aspectRatioInfluence.Evaluate(WorldSpaceCanvasFitScreenSystem.AspectRatio);
    if (this.setScale)
      this.rectTransform.localScale = Vector3.Lerp(this.scaleMin, this.scaleMax, t);
    if (!this.setPosition)
      return;
    this.rectTransform.anchoredPosition3D = Vector3.Lerp(this.positionMin, this.positionMax, t);
  }
}
