// Decompiled with JetBrains decompiler
// Type: TextContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
public class TextContainer : MonoBehaviour
{
  public TextMeshProUGUI textAsset;

  public void SetText(string text) => this.textAsset.text = text;
}
