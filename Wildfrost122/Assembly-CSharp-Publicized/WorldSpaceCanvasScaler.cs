// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class WorldSpaceCanvasScaler : WorldSpaceCanvasUpdater
{
  [SerializeField]
  public bool invert;
  [Header("Position")]
  [SerializeField]
  public bool scalePositionX;
  [SerializeField]
  [ShowIf("scalePositionX")]
  public float basePositionX;
  [SerializeField]
  public bool scalePositionY;
  [SerializeField]
  [ShowIf("scalePositionY")]
  public float basePositionY;
  [SerializeField]
  public bool scalePositionZ;
  [SerializeField]
  [ShowIf("scalePositionZ")]
  public float basePositionZ;
  [Header("Scale")]
  [SerializeField]
  public bool scaleX = true;
  [SerializeField]
  [ShowIf("scaleX")]
  public float baseScaleX = 1f;
  [SerializeField]
  public bool scaleY = true;
  [SerializeField]
  [ShowIf("scaleY")]
  public float baseScaleY = 1f;
  [SerializeField]
  public bool scaleZ;
  [SerializeField]
  [ShowIf("scaleZ")]
  public float baseScaleZ = 1f;

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

  public void SetPosition(float scale)
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

  public void SetScale(float scale)
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
