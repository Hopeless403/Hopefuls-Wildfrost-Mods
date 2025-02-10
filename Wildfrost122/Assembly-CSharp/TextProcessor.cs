// Decompiled with JetBrains decompiler
// Type: TextProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
public class TextProcessor : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;

  public void SetText(string input) => this.textElement.text = Text.Process(input);
}
