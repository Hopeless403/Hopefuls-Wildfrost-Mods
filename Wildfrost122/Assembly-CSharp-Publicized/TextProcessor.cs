// Decompiled with JetBrains decompiler
// Type: TextProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class TextProcessor : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textElement;

  public void SetText(string input) => this.textElement.text = Text.Process(input);
}
