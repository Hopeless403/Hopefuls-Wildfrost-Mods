// Decompiled with JetBrains decompiler
// Type: RenderTextureCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;

public class RenderTextureCreator : MonoBehaviour
{
  [SerializeField]
  private int width;
  [SerializeField]
  private int height;
  [SerializeField]
  private GraphicsFormat colorFormat;
  [SerializeField]
  private GraphicsFormat depthStencilFormat;
  [SerializeField]
  private int mipCount;
  [SerializeField]
  private bool destroyOnDisable = true;
  [SerializeField]
  private UnityEvent<RenderTexture> onCreate;
  private RenderTexture rt;

  private void OnEnable()
  {
    if ((Object) this.rt != (Object) null)
      this.rt.Destroy();
    this.rt = new RenderTexture(this.width, this.height, this.colorFormat, this.depthStencilFormat, this.mipCount);
    this.onCreate.Invoke(this.rt);
  }

  private void OnDisable()
  {
    if (!this.destroyOnDisable || !((Object) this.rt != (Object) null))
      return;
    this.rt.Destroy();
  }
}
