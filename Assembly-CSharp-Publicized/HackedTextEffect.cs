// Decompiled with JetBrains decompiler
// Type: HackedTextEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof (TMP_Text))]
public class HackedTextEffect : MonoBehaviour
{
  public TMP_Text _tmp;
  public char[] extraChars;
  public string[] extraCharColourHexes;
  public Vector2 delayBetweenRoutines = new Vector2(1f, 2f);

  public TMP_Text tmp => this._tmp ?? (this._tmp = this.GetComponent<TMP_Text>());

  public void SetText(string text)
  {
    this.StopAllCoroutines();
    this.StartRoutine(text);
  }

  public void StartRoutine(string text) => this.StartCoroutine(this.Routine(text));

  public void OnDisable() => this.StopAllCoroutines();

  public IEnumerator Routine(string text)
  {
    yield return (object) this.Appear(text);
    while (true)
    {
      yield return (object) new WaitForSeconds(this.delayBetweenRoutines.Random());
      yield return (object) Dead.Random.Choose<IEnumerator>(this.LoopChars(text), this.AddCharsRandom(text), this.AppendChars(text), this.AddChar(text), this.ReplaceChar(text), this.ColourChar(text), this.Appear(text));
    }
  }

  public IEnumerator Appear(string text)
  {
    for (int i = 1; i < text.Length; ++i)
    {
      char ch = Dead.Random.Choose<char>(this.extraChars.RandomItem<char>(), text[Mathf.Max(0, i - 1)]);
      this.tmp.text = text.Remove(i, 1).Insert(i, string.Format("<#{0}>{1}</color>", (object) this.extraCharColourHexes.RandomItem<string>(), (object) ch));
      this.tmp.maxVisibleCharacters = i + 1;
      yield return (object) new WaitForSeconds(0.05f);
    }
    this.tmp.text = text;
    this.tmp.maxVisibleCharacters = 1000;
    yield return (object) new WaitForSeconds(1f);
  }

  public IEnumerator LoopChars(string text)
  {
    int count = Dead.Random.Choose<int>(text.Length, Dead.Random.Range(0, text.Length));
    for (int i = 0; i < count; ++i)
    {
      char ch = Dead.Random.Choose<char>(this.extraChars.RandomItem<char>(), text[i]);
      this.tmp.text = text.Remove(i, 1).Insert(i, string.Format("<#{0}>{1}</color>", (object) this.extraCharColourHexes.RandomItem<string>(), (object) ch));
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.025f, 0.05f));
      this.tmp.text = text;
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.025f, 0.05f));
    }
  }

  public IEnumerator AddCharsRandom(string text)
  {
    int count = PettyRandom.Range(5, 15);
    for (int i = 0; i < count; ++i)
    {
      int num = text.RandomIndex<char>();
      char ch = Dead.Random.Choose<char>(this.extraChars.RandomItem<char>(), text[num]);
      this.tmp.text = text.Remove(num, 1).Insert(num, string.Format("<#{0}>{1}</color>", (object) this.extraCharColourHexes.RandomItem<string>(), (object) ch));
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.05f, 0.1f));
      this.tmp.text = text;
      yield return (object) new WaitForSeconds(0.1f);
    }
  }

  public IEnumerator AppendChars(string text)
  {
    int count = PettyRandom.Range(1, 3);
    string str = text;
    char finalChar = str[str.Length - 1];
    for (int i = 0; i < count; ++i)
    {
      this.tmp.text += string.Format("<#{0}>{1}</color>", (object) this.extraCharColourHexes.RandomItem<string>(), (object) finalChar);
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.1f, 0.2f));
    }
    yield return (object) new WaitForSeconds(0.3f);
    this.tmp.text = text;
  }

  public IEnumerator AddChar(string text)
  {
    int index = text.RandomIndex<char>();
    char c = Dead.Random.Choose<char>(this.extraChars.RandomItem<char>(), text[index]);
    int count = Dead.Random.Choose<int>(1, 2, 2);
    for (int i = 0; i < count; ++i)
    {
      this.tmp.text = this.tmp.text.Insert(index, string.Format("<#{0}>{1}</color>", (object) this.extraCharColourHexes.RandomItem<string>(), (object) c));
      yield return (object) new WaitForSeconds(PettyRandom.Range(1f, 2f));
    }
    this.tmp.text = text;
  }

  public IEnumerator ReplaceChar(string text)
  {
    int index = text.RandomIndex<char>();
    char ch = this.extraChars.RandomItem<char>();
    this.tmp.text = text.Remove(index, 1).Insert(index, string.Format("<#{0}>{1}</color>", (object) this.extraCharColourHexes.RandomItem<string>(), (object) ch));
    yield return (object) new WaitForSeconds(PettyRandom.Range(1f, 2f));
    this.tmp.text = text.Remove(index, 1).Insert(index, " ");
    yield return (object) new WaitForSeconds(1f);
  }

  public IEnumerator ColourChar(string text)
  {
    int index = text.RandomIndex<char>();
    char ch = text[index];
    string col = this.extraCharColourHexes.RandomItem<string>();
    this.tmp.text = text.Remove(index, 1).Insert(index, string.Format("<#{0}>{1}</color>", (object) col, (object) ch));
    yield return (object) new WaitForSeconds(PettyRandom.Range(2f, 3f));
    int count = Dead.Random.Range(6, 10) * Dead.Random.Choose<int>(1, 1, 1, 1, 1, 3);
    for (int i = 0; i < count; ++i)
    {
      this.tmp.text = text.Remove(index, 1).Insert(index, string.Format("<#{0}>{1}</color>", (object) col, (object) this.extraChars.RandomItem<char>()));
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.025f, 0.05f));
    }
    yield return (object) new WaitForSeconds(1f);
    this.tmp.text = text;
  }
}
