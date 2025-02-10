// Decompiled with JetBrains decompiler
// Type: TiledImageMover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class TiledImageMover : MonoBehaviourCacheTransform
{
  [SerializeField]
  private float moveX = 1f;
  [SerializeField]
  private float resetPosX = 0.5f;

  private void Update()
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
