// Decompiled with JetBrains decompiler
// Type: TiledImageMover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class TiledImageMover : MonoBehaviourCacheTransform
{
  [SerializeField]
  public float moveX = 1f;
  [SerializeField]
  public float resetPosX = 0.5f;

  public void Update()
  {
    Vector3 localPosition = this.transform.localPosition;
    float num = localPosition.x + this.moveX * Time.deltaTime;
    if ((double) num >= (double) this.resetPosX)
      num -= this.resetPosX * 2f;
    else if ((double) num <= -(double) this.resetPosX)
      num += this.resetPosX * 2f;
    this.transform.localPosition = localPosition.WithX(num);
  }
}
