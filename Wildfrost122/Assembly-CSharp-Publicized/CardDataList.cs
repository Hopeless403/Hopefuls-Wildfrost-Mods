// Decompiled with JetBrains decompiler
// Type: CardDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Serializable]
public class CardDataList : 
  IList<CardData>,
  ICollection<CardData>,
  IEnumerable<CardData>,
  IEnumerable
{
  [SerializeField]
  public List<CardData> list = new List<CardData>();

  public IEnumerator<CardData> GetEnumerator() => (IEnumerator<CardData>) this.list.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.list.GetEnumerator();

  public void Add(CardData item) => this.list.Add(item);

  public void Clear() => this.list.Clear();

  public bool Contains(CardData item)
  {
    if (!(bool) (UnityEngine.Object) item)
      return false;
    foreach (CardData cardData in this.list)
    {
      if ((long) cardData.id == (long) item.id)
        return true;
    }
    return false;
  }

  public void CopyTo(CardData[] array, int arrayIndex) => this.list.CopyTo(array, arrayIndex);

  public bool Remove(CardData item)
  {
    int index = this.IndexOf(item);
    if (index < 0)
      return false;
    this.list.RemoveAt(index);
    return true;
  }

  public int Count => this.list.Count;

  public bool IsReadOnly => false;

  public int IndexOf(CardData item)
  {
    if (!(bool) (UnityEngine.Object) item)
      return -1;
    for (int index = 0; index < this.list.Count; ++index)
    {
      if ((long) this.list[index].id == (long) item.id)
        return index;
    }
    return -1;
  }

  public void Insert(int index, CardData item) => this.list.Insert(index, item);

  public void RemoveAt(int index) => this.list.RemoveAt(index);

  public CardData this[int index]
  {
    get => this.list[index];
    set => this.list[index] = value;
  }

  public void Sort() => this.list.Sort();

  public void Sort(Comparison<CardData> comparison) => this.list.Sort(comparison);

  public void Sort(IComparer<CardData> comparer) => this.list.Sort(comparer);

  public void Sort(int index, int count, IComparer<CardData> comparer)
  {
    this.list.Sort(index, count, comparer);
  }

  public List<CardData> FindAll(Predicate<CardData> predicate) => this.list.FindAll(predicate);
}
