// Decompiled with JetBrains decompiler
// Type: TextImageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

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
