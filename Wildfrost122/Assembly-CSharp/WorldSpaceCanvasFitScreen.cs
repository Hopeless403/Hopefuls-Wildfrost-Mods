﻿// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasFitScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class WorldSpaceCanvasFitScreen : WorldSpaceCanvasUpdater
{
  [ReadOnly]
  public float width;
  [ReadOnly]
  public float height;
  [SerializeField]
  private float scale = 1f;
  [SerializeField]
  private AnimationCurve largeScaleCurve;
  [SerializeField]
  private Vector2 padding;
  public UnityEvent<RectTransform> onUpdate;

  public override void UpdateSize()
  {
    if (!WorldSpaceCanvasFitScreenSystem.exists)
      return;
    if (WorldSpaceCanvasFitScreenSystem.instance.cam.orthographic)
    {
      this.height = WorldSpaceCanvasFitScreenSystem.instance.cam.orthographicSize * 2f;
      this.width = this.height * WorldSpaceCanvasFitScreenSystem.instance.aspectRatio;
    }
    else
    {
      this.height = 11.547f;
      this.width = this.height * WorldSpaceCanvasFitScreenSystem.instance.aspectRatio;
    }
    float num;
    if ((double) this.width < 17.320510864257813)
    {
      num = this.width / 17.32051f * this.scale;
      this.width = 17.32051f;
      this.height = this.width / 1.5f;
    }
    else
    {
      if ((double) this.width > 26.943000793457031)
        this.width = 26.943f;
      AnimationCurve largeScaleCurve = this.largeScaleCurve;
      if (largeScaleCurve != null)
      {
        int length = largeScaleCurve.length;
      }
      num = this.scale;
    }
    this.rectTransform.sizeDelta = new Vector2(this.width - this.padding.x, this.height - this.padding.y);
    this.rectTransform.localScale = new Vector3(num, num, 1f);
    this.onUpdate?.Invoke(this.rectTransform);
  }
}
