// Decompiled with JetBrains decompiler
// Type: Spinner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
