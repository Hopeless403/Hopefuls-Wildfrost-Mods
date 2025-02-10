// Decompiled with JetBrains decompiler
// Type: TextContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class TextContainer : MonoBehaviour
{
  public TextMeshProUGUI textAsset;

  public void SetText(string text) => this.textAsset.text = text;
}
