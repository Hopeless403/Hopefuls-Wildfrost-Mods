// Decompiled with JetBrains decompiler
// Type: CloudMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using UnityEngine;

#nullable disable
public class CloudMovement : MonoBehaviour
{
  public Transform mover;
  public float speed = 0.1f;
  public float width = 20f;

  private void Awake()
  {
    this.mover.localPosition = this.mover.localPosition with
    {
      x = PettyRandom.Range(-this.width, this.width)
    };
  }

  private void Update()
  {
    Vector3 localPosition = this.mover.localPosition;
    localPosition.x += this.speed * Time.deltaTime;
    if ((double) localPosition.x > (double) this.width)
      localPosition.x = -this.width;
    else if ((double) localPosition.x < -(double) this.width)
      localPosition.x = this.width;
    this.mover.localPosition = localPosition;
  }
}
