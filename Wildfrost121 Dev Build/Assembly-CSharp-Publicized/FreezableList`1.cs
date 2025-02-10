// Decompiled with JetBrains decompiler
// Type: FreezableList`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class FreezableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
  public readonly List<T> currentList = new List<T>();
  public readonly List<T> nextList = new List<T>();
  public int freezeCount;
  public bool updateRequired;
  public bool sortRequired;
  public bool autoSort;
  public IComparer<T> autoSortComparer;

  public FreezableList()
  {
  }

  public FreezableList(bool autoSort) => this.autoSort = autoSort;

  public FreezableList(bool autoSort, IComparer<T> autoSortComparer)
  {
    this.autoSort = autoSort;
    this.autoSortComparer = autoSortComparer;
  }

  public T this[int index]
  {
    get => this.currentList[index];
    set => this.nextList[index] = value;
  }

  public int Count => this.currentList.Count;

  public bool IsReadOnly => false;

  public void Add(T item)
  {
    int count = this.nextList.Count;
    int index1 = count;
    if (this.autoSort)
    {
      for (int index2 = 0; index2 < count; ++index2)
      {
        if (this.autoSortComparer.Compare(item, this.nextList[index2]) <= 0)
        {
          index1 = index2;
          break;
        }
      }
    }
    this.nextList.Insert(index1, item);
    if (this.freezeCount <= 0)
    {
      this.currentList.Insert(index1, item);
    }
    else
    {
      this.updateRequired = true;
      if (this.autoSort)
        return;
      this.sortRequired = true;
    }
  }

  public void Insert(int index, T item) => throw new NotImplementedException();

  public bool Remove(T item)
  {
    int num = this.nextList.Remove(item) ? 1 : 0;
    if (this.freezeCount <= 0)
    {
      this.currentList.Remove(item);
      return num != 0;
    }
    this.updateRequired = true;
    return num != 0;
  }

  public void RemoveAt(int index)
  {
    this.nextList.RemoveAt(index);
    if (this.freezeCount <= 0)
      this.currentList.RemoveAt(index);
    else
      this.updateRequired = true;
  }

  public void Clear()
  {
    this.nextList.Clear();
    if (this.freezeCount <= 0)
      this.currentList.Clear();
    else
      this.updateRequired = true;
  }

  public bool Contains(T item) => this.currentList.Contains(item);

  public void CopyTo(T[] array, int arrayIndex) => this.currentList.CopyTo(array, arrayIndex);

  public int IndexOf(T item) => this.currentList.IndexOf(item);

  public IEnumerator<T> GetEnumerator() => (IEnumerator<T>) this.currentList.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.currentList.GetEnumerator();

  public T[] ToArray() => this.nextList.ToArray();

  public List<T> ToList() => new List<T>((IEnumerable<T>) this.nextList);

  public void Freeze() => ++this.freezeCount;

  public void Thaw()
  {
    --this.freezeCount;
    if (this.freezeCount > 0)
      return;
    if (this.updateRequired && this.sortRequired && this.autoSort)
    {
      FreezableList<T>.Sort(this.nextList, this.autoSortComparer);
      this.sortRequired = false;
    }
    this.TryUpdate();
    if (!this.autoSort || !this.sortRequired)
      return;
    this.TrySort(this.autoSortComparer);
  }

  public void TryUpdate()
  {
    if (!this.updateRequired)
      return;
    this.currentList.Clear();
    this.currentList.AddRange((IEnumerable<T>) this.nextList);
    this.updateRequired = false;
  }

  public void TrySort(IComparer<T> comparer)
  {
    if (!this.sortRequired)
      return;
    FreezableList<T>.Sort(this.currentList, comparer);
    this.nextList.Clear();
    this.nextList.AddRange((IEnumerable<T>) this.currentList);
    this.sortRequired = false;
  }

  public static void Sort(List<T> list, IComparer<T> comparer)
  {
    T[] array = list.OrderBy<T, T>((Func<T, T>) (a => a), comparer).ToArray<T>();
    list.Clear();
    list.AddRange((IEnumerable<T>) array);
  }
}
