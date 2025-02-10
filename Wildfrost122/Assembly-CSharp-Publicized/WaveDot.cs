// Decompiled with JetBrains decompiler
// Type: WaveDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class WaveDot : MonoBehaviour
{
  [SerializeField]
  public Image onImage;
  [SerializeField]
  public Image offImage;

  public void TurnOn()
  {
    this.onImage.enabled = true;
    this.offImage.enabled = false;
  }

  public void TurnOff()
  {
    this.onImage.enabled = false;
    this.offImage.enabled = true;
  }
}
