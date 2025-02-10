// Decompiled with JetBrains decompiler
// Type: TextImageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Image Data", fileName = "Text Image Data")]
public class TextImageData : ScriptableObject
{
  [SerializeField]
  private List<char> chars;
  [SerializeField]
  private List<Sprite> sprites;

  public bool TryGetSprite(char value, out Sprite result)
  {
    int index = this.chars.IndexOf(value);
    if (index >= 0)
    {
      result = this.sprites[index];
      return true;
    }
    result = (Sprite) null;
    return false;
  }
}
