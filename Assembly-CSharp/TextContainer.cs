// Decompiled with JetBrains decompiler
// Type: TextContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class TextContainer : MonoBehaviour
{
  public TextMeshProUGUI textAsset;

  public void SetText(string text) => this.textAsset.text = text;
}
