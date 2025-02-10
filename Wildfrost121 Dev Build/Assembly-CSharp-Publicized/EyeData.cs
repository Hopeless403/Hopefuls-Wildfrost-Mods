// Decompiled with JetBrains decompiler
// Type: EyeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "EyeData", menuName = "EyeData")]
public class EyeData : DataFile
{
  public string cardData;
  public EyeData.Eye[] eyes;

  public void Set(params EyePositionSaver[] eyePositions)
  {
    this.eyes = new EyeData.Eye[eyePositions.Length];
    int num = 0;
    foreach (EyePositionSaver eyePosition in eyePositions)
      this.eyes[num++] = new EyeData.Eye(eyePosition.transform);
  }

  [Serializable]
  public struct Eye
  {
    public Vector2 position;
    public Vector2 scale;
    public float rotation;

    public Eye(Transform transform)
    {
      this.position = (Vector2) transform.localPosition;
      this.scale = (Vector2) transform.localScale;
      this.rotation = transform.localEulerAngles.z;
    }
  }
}
