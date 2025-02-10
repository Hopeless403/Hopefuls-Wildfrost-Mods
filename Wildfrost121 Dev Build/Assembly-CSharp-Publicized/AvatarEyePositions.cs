// Decompiled with JetBrains decompiler
// Type: AvatarEyePositions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
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
