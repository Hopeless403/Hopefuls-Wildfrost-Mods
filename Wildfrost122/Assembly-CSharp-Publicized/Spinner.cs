// Decompiled with JetBrains decompiler
// Type: Spinner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class Spinner : MonoBehaviour
{
  [SerializeField]
  public bool ignoreTimeScale;
  public Vector3 speed = new Vector3(0.0f, 0.0f, 1f);
  public bool setTargetSpeed;
  [ShowIf("setTargetSpeed")]
  public Vector3 targetSpeed;
  [ShowIf("setTargetSpeed")]
  public float targetSpeedAcc = 100f;

  public void Update()
  {
    if (this.setTargetSpeed)
      this.speed = Vector3.MoveTowards(this.speed, this.targetSpeed, this.targetSpeedAcc * Time.deltaTime);
    this.transform.localEulerAngles = this.transform.localEulerAngles + this.speed * (this.ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime);
  }
}
