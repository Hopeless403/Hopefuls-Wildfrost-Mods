// Decompiled with JetBrains decompiler
// Type: ILoadableExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
