// Decompiled with JetBrains decompiler
// Type: WaveDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
