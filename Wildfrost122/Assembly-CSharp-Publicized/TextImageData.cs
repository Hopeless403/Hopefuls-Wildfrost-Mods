// Decompiled with JetBrains decompiler
// Type: TextImageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Text Image Data", fileName = "Text Image Data")]
public class TextImageData : ScriptableObject
{
  [SerializeField]
  public List<char> chars;
  [SerializeField]
  public List<Sprite> sprites;

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
