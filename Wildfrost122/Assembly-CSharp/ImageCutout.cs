// Decompiled with JetBrains decompiler
// Type: ImageCutout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ImageCutout : ImageSprite
{
  public override Material materialForRendering
  {
    get
    {
      if (!this.maskable)
        return base.materialForRendering;
      Material materialForRendering = new Material(base.materialForRendering);
      materialForRendering.SetInt("_StencilComp", 6);
      return materialForRendering;
    }
  }
}
