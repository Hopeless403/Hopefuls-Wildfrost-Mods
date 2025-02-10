// Decompiled with JetBrains decompiler
// Type: HandleSpinner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

public class HandleSpinner : MonoBehaviour
{
  [SerializeField]
  public Transform handle;
  [SerializeField]
  public float startSpeed = 100f;
  [SerializeField]
  public float targetSpeed = 100f;
  [SerializeField]
  public float acceleration = 10f;
  [SerializeField]
  public float deceleration = 10f;
  public bool spinning;
  public float speed;

  [Button(null, EButtonEnableMode.Always)]
  public void Spin()
  {
    this.enabled = true;
    this.spinning = true;
    this.speed = this.startSpeed;
  }

  [Button(null, EButtonEnableMode.Always)]
  public void Stop() => this.spinning = false;

  public void Update()
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
