// Decompiled with JetBrains decompiler
// Type: WaveDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
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
