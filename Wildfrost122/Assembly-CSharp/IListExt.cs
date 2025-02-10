// Decompiled with JetBrains decompiler
// Type: IListExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public static class IListExt
{
  public static SaveCollection<string> ToSaveCollectionOfNames<T>(this IList<T> list) where T : Object
  {
    return new SaveCollection<string>(list.ToArrayOfNames<T>());
  }

  public static void DestroyAllAndClear(this IList<GameObject> list)
  {
    foreach (GameObject gameObject in (IEnumerable<GameObject>) list)
      gameObject.Destroy();
    list.Clear();
  }
}
