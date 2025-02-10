// Decompiled with JetBrains decompiler
// Type: ILoadableExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

#nullable disable
public static class ILoadableExt
{
  public static T[] LoadArray<T, TSaveData>(this TSaveData[] data) where TSaveData : ILoadable<T>
  {
    return data.LoadList<T, TSaveData>().ToArray();
  }

  public static List<T> LoadList<T, TSaveData>(this TSaveData[] data) where TSaveData : ILoadable<T>
  {
    List<T> list = new List<T>();
    foreach (TSaveData saveData in data)
      list.AddIfNotNull<T>(saveData.Load());
    return list;
  }
}
