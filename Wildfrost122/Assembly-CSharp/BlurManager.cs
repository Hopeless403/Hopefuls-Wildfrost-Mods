// Decompiled with JetBrains decompiler
// Type: BlurManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
