// Decompiled with JetBrains decompiler
// Type: SaveCollection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public struct SaveCollection<T> : ICloneable
{
  public T[] collection;

  public int Count => this.collection.Length;

  public T this[int index]
  {
    get => this.collection[index];
    set => this.collection[index] = value;
  }

  public SaveCollection(T[] collection) => this.collection = collection;

  public SaveCollection(List<T> collection) => this.collection = collection.ToArray();

  public SaveCollection(T item) => this.collection = new T[1]
  {
    item
  };

  public void Add(T item)
  {
    List<T> list = this.collection.ToList<T>();
    list.Add(item);
    this.collection = list.ToArray();
  }

  public void Remove(int index)
  {
    List<T> list = this.collection.ToList<T>();
    list.RemoveAt(index);
    this.collection = list.ToArray();
  }

  public object Clone() => (object) new SaveCollection<T>()
  {
    collection = ((IEnumerable<T>) this.collection).ToArray<T>()
  };
}
