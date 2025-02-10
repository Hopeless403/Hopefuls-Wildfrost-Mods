// Decompiled with JetBrains decompiler
// Type: TextTypewrite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
public class TextTypewrite : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;
  private const float startDelay = 0.25f;
  private const float defaultPause = 0.05f;
  private static readonly Dictionary<char, float> lookup = new Dictionary<char, float>()
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

  internal IEnumerator Write()
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
