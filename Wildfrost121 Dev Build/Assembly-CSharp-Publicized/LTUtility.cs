// Decompiled with JetBrains decompiler
// Type: LTUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LTUtility
{
  public static Vector3[] reverse(Vector3[] arr)
  {
    int length = arr.Length;
    int index1 = 0;
    for (int index2 = length - 1; index1 < index2; --index2)
    {
      Vector3 vector3 = arr[index1];
      arr[index1] = arr[index2];
      arr[index2] = vector3;
      ++index1;
    }
    return arr;
  }
}
