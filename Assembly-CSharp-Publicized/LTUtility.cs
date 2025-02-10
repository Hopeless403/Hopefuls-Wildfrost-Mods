// Decompiled with JetBrains decompiler
// Type: LTUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
