// Decompiled with JetBrains decompiler
// Type: AvatarEyePositions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

public class AvatarEyePositions : MonoBehaviour
{
  public AvatarEyePositions.Eye[] eyes;

  [Serializable]
  public class Eye
  {
    public Vector3 pos;
    public Vector3 scale = new Vector3(2.12765956f, 2.12765956f, 1f);
  }
}
