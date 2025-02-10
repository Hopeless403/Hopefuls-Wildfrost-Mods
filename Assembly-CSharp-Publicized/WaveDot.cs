// Decompiled with JetBrains decompiler
// Type: WaveDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

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
