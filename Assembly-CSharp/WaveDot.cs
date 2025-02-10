// Decompiled with JetBrains decompiler
// Type: WaveDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class WaveDot : MonoBehaviour
{
  [SerializeField]
  private Image onImage;
  [SerializeField]
  private Image offImage;

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
