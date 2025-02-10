// Decompiled with JetBrains decompiler
// Type: BlurManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class BlurManager : MonoBehaviour
{
  [SerializeField]
  private Camera blurCamera;
  [SerializeField]
  private Material blurMaterial;

  private void Start()
  {
    if ((Object) this.blurCamera.targetTexture != (Object) null)
      this.blurCamera.targetTexture.Release();
    this.blurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32, 1);
    this.blurMaterial.SetTexture("_MainTex", (Texture) this.blurCamera.targetTexture);
  }
}
