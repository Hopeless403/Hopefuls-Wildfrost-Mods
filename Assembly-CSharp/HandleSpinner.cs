// Decompiled with JetBrains decompiler
// Type: HandleSpinner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

public class HandleSpinner : MonoBehaviour
{
  [SerializeField]
  private Transform handle;
  [SerializeField]
  private float startSpeed = 100f;
  [SerializeField]
  private float targetSpeed = 100f;
  [SerializeField]
  private float acceleration = 10f;
  [SerializeField]
  private float deceleration = 10f;
  private bool spinning;
  private float speed;

  [Button(null, EButtonEnableMode.Always)]
  public void Spin()
  {
    this.enabled = true;
    this.spinning = true;
    this.speed = this.startSpeed;
  }

  [Button(null, EButtonEnableMode.Always)]
  public void Stop() => this.spinning = false;

  private void Update()
  {
    float xAngle = -this.speed * Time.deltaTime;
    this.transform.Rotate(xAngle, 0.0f, 0.0f);
    this.handle.Rotate(-xAngle, 0.0f, 0.0f);
    if (this.spinning)
      this.speed = Mathf.Min(this.speed + this.acceleration * Time.deltaTime, this.targetSpeed);
    else
      this.speed = Mathf.Max(0.0f, this.speed - this.deceleration * Time.deltaTime);
  }
}
