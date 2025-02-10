// Decompiled with JetBrains decompiler
// Type: BlurManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class BlurManager : MonoBehaviour
{
  [SerializeField]
  public Camera blurCamera;
  [SerializeField]
  public Material blurMaterial;

  public void Start()
  {
    if ((Object) this.blurCamera.targetTexture != (Object) null)
      this.blurCamera.targetTexture.Release();
    this.blurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32, 1);
    this.blurMaterial.SetTexture("_MainTex", (Texture) this.blurCamera.targetTexture);
  }
}
