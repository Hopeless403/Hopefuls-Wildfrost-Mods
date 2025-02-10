// Decompiled with JetBrains decompiler
// Type: Wobbler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using UnityEngine;

#nullable disable
public class Wobbler : MonoBehaviourCacheTransform, IPoolable
{
  public Vector3 rotationInfluence = new Vector3(10f, 10f, 2f);
  public Vector3 rotationMax = new Vector3(50f, 50f, 50f);
  public Vector3 rotationDamping = new Vector3(0.91f, 0.93f, 0.94f);
  public Vector3 rotationAcc = new Vector3(1f, 0.8f, 0.7f);
  private Vector3 rotation;
  private Vector3 rotationVelocity;

  private void Update()
  {
    this.rotationVelocity -= Vector3.Scale(this.rotation, this.rotationAcc) * Time.deltaTime;
    this.rotationVelocity = Delta.Multiply(this.rotationVelocity, this.rotationDamping, Time.deltaTime);
    this.rotation += this.rotationVelocity * (200f * Time.deltaTime);
    this.transform.localEulerAngles = this.rotation;
  }

  public void Wobble(Vector3 movement)
  {
    this.rotation = (this.rotation + Vector3.Scale(new Vector3(movement.y, -movement.x, -movement.x), this.rotationInfluence)).Clamp(-this.rotationMax, this.rotationMax);
  }

  public void WobbleRandom(float wobbleFactor = 1f)
  {
    this.Wobble((Vector3) (PettyRandom.Vector2() * wobbleFactor));
  }

  public void OnGetFromPool()
  {
  }

  public void OnReturnToPool()
  {
    this.rotation = Vector3.zero;
    this.rotationVelocity = Vector3.zero;
    this.transform.localScale = Vector3.one;
  }
}
