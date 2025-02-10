// Decompiled with JetBrains decompiler
// Type: LargeUIScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
public class LargeUIScaler : WorldSpaceCanvasUpdater
{
  [SerializeField]
  public bool setScale = true;
  [SerializeField]
  [ShowIf("setScale")]
  [FormerlySerializedAs("scaleMinV")]
  public Vector3 scaleMin = Vector3.one;
  [SerializeField]
  [ShowIf("setScale")]
  [FormerlySerializedAs("scaleMaxV")]
  public Vector3 scaleMax = Vector3.one;
  [SerializeField]
  public bool setPosition;
  [SerializeField]
  [ShowIf("setPosition")]
  public Vector3 positionMin;
  [SerializeField]
  [ShowIf("setPosition")]
  public Vector3 positionMax;
  [SerializeField]
  public AnimationCurve aspectRatioInfluence;

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
