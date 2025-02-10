// Decompiled with JetBrains decompiler
// Type: Mover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class Mover : MonoBehaviour
{
  public Vector3 velocity;
  public float frictMult = 0.9f;
  public bool removeWhenStopped = true;
  public bool removeWhenDisabled = true;

  public void Update()
  {
    if (this.removeWhenStopped && (double) this.velocity.sqrMagnitude <= 0.0099999997764825821)
    {
      Object.Destroy((Object) this);
    }
    else
    {
      this.transform.position += this.velocity * Time.deltaTime;
      this.velocity = Delta.Multiply(this.velocity, this.frictMult, Time.deltaTime);
    }
  }

  public void OnDisable()
  {
    if (!this.removeWhenDisabled)
      return;
    Object.Destroy((Object) this);
  }
}
