// Decompiled with JetBrains decompiler
// Type: IListExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
