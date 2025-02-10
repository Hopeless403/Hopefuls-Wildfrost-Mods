// Decompiled with JetBrains decompiler
// Type: RenderTextureCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;

#nullable disable
public class RenderTextureCreator : MonoBehaviour
{
  [SerializeField]
  public int width;
  [SerializeField]
  public int height;
  [SerializeField]
  public GraphicsFormat colorFormat;
  [SerializeField]
  public GraphicsFormat depthStencilFormat;
  [SerializeField]
  public int mipCount;
  [SerializeField]
  public bool destroyOnDisable = true;
  [SerializeField]
  public UnityEvent<RenderTexture> onCreate;
  public RenderTexture rt;

  public void OnEnable()
  {
    if ((Object) this.rt != (Object) null)
      this.rt.Destroy();
    this.rt = new RenderTexture(this.width, this.height, this.colorFormat, this.depthStencilFormat, this.mipCount);
    this.onCreate.Invoke(this.rt);
  }

  public void OnDisable()
  {
    if (!this.destroyOnDisable || !((Object) this.rt != (Object) null))
      return;
    this.rt.Destroy();
  }
}
