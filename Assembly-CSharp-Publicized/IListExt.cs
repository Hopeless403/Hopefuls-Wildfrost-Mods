// Decompiled with JetBrains decompiler
// Type: IListExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public static class IListExt
{
  public static SaveCollection<string> ToSaveCollectionOfNames<T>(this IList<T> list) where T : Object => new SaveCollection<string>(list.ToArrayOfNames<T>());

  public static void DestroyAllAndClear(this IList<GameObject> list)
  {
    foreach (GameObject gameObject in (IEnumerable<GameObject>) list)
      gameObject.Destroy();
    list.Clear();
  }
}
