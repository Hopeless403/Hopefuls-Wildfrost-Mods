// Decompiled with JetBrains decompiler
// Type: ILoadableExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

public static class ILoadableExt
{
  public static T[] LoadArray<T, TSaveData>(this TSaveData[] data) where TSaveData : ILoadable<T> => data.LoadList<T, TSaveData>().ToArray();

  public static List<T> LoadList<T, TSaveData>(this TSaveData[] data) where TSaveData : ILoadable<T>
  {
    List<T> list = new List<T>();
    foreach (TSaveData saveData in data)
      list.AddIfNotNull<T>(saveData.Load());
    return list;
  }
}
