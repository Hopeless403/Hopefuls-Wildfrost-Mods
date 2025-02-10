// Decompiled with JetBrains decompiler
// Type: ImageCutout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
