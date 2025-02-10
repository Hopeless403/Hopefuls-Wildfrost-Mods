// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class WorldSpaceCanvasScaler : WorldSpaceCanvasUpdater
{
  [SerializeField]
  private bool invert;
  [Header("Position")]
  [SerializeField]
  private bool scalePositionX;
  [SerializeField]
  [ShowIf("scalePositionX")]
  private float basePositionX;
  [SerializeField]
  private bool scalePositionY;
  [SerializeField]
  [ShowIf("scalePositionY")]
  private float basePositionY;
  [SerializeField]
  private bool scalePositionZ;
  [SerializeField]
  [ShowIf("scalePositionZ")]
  private float basePositionZ;
  [Header("Scale")]
  [SerializeField]
  private bool scaleX = true;
  [SerializeField]
  [ShowIf("scaleX")]
  private float baseScaleX = 1f;
  [SerializeField]
  private bool scaleY = true;
  [SerializeField]
  [ShowIf("scaleY")]
  private float baseScaleY = 1f;
  [SerializeField]
  private bool scaleZ;
  [SerializeField]
  [ShowIf("scaleZ")]
  private float baseScaleZ = 1f;

  public override void UpdateSize()
  {
    if (!WorldSpaceCanvasFitScreenSystem.exists)
      return;
    float num = 11.547f * WorldSpaceCanvasFitScreenSystem.instance.aspectRatio;
    float scale = (double) num < 17.320510864257813 ? num / 17.32051f : 1f;
    if (this.scalePositionX || this.scalePositionY || this.scalePositionZ)
      this.SetPosition(scale);
    if (!this.scaleX && !this.scaleY && !this.scaleZ)
      return;
    this.SetScale(scale);
  }

  private void SetPosition(float scale)
  {
    Vector3 anchoredPosition3D = this.rectTransform.anchoredPosition3D;
    if (this.scalePositionX)
      anchoredPosition3D.x = this.invert ? this.basePositionX / scale : this.basePositionX * scale;
    if (this.scalePositionY)
      anchoredPosition3D.y = this.invert ? this.basePositionY / scale : this.basePositionY * scale;
    if (this.scalePositionZ)
      anchoredPosition3D.z = this.invert ? this.basePositionZ / scale : this.basePositionZ * scale;
    this.rectTransform.anchoredPosition3D = anchoredPosition3D;
  }

  private void SetScale(float scale)
  {
    Vector3 localScale = this.rectTransform.localScale;
    if (this.scaleX)
      localScale.x = this.invert ? this.baseScaleX / scale : this.baseScaleX * scale;
    if (this.scaleY)
      localScale.y = this.invert ? this.baseScaleY / scale : this.baseScaleY * scale;
    if (this.scaleZ)
      localScale.z = this.invert ? this.baseScaleZ / scale : this.baseScaleZ * scale;
    this.rectTransform.localScale = localScale;
  }
}
