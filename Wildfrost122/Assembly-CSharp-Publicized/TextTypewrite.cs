// Decompiled with JetBrains decompiler
// Type: TextTypewrite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
public class TextTypewrite : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textElement;
  public const float startDelay = 0.25f;
  public const float defaultPause = 0.05f;
  public static readonly Dictionary<char, float> lookup = new Dictionary<char, float>()
  {
    {
      ' ',
      0.005f
    },
    {
      ',',
      0.4f
    },
    {
      '，',
      0.4f
    },
    {
      '.',
      0.15f
    },
    {
      '…',
      0.4f
    }
  };

  public IEnumerator Write()
  {
    this.textElement.maxVisibleCharacters = 0;
    yield return (object) new WaitForSeconds(0.25f);
    int total = this.textElement.textInfo.characterCount;
    for (int i = 0; i < total; ++i)
    {
      this.textElement.maxVisibleCharacters = i + 1;
      char character = this.textElement.textInfo.characterInfo[i].character;
      yield return (object) new WaitForSeconds(TextTypewrite.lookup.ContainsKey(character) ? TextTypewrite.lookup[character] : 0.05f);
    }
  }
}
