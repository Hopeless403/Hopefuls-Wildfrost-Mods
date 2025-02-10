// Decompiled with JetBrains decompiler
// Type: AvatarEyePositions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
