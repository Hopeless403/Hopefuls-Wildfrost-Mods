// Decompiled with JetBrains decompiler
// Type: TextImageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
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
