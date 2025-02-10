// Decompiled with JetBrains decompiler
// Type: Spinner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

public class Spinner : MonoBehaviour
{
  [SerializeField]
  private bool ignoreTimeScale;
  public Vector3 speed = new Vector3(0.0f, 0.0f, 1f);
  public bool setTargetSpeed;
  [ShowIf("setTargetSpeed")]
  public Vector3 targetSpeed;
  [ShowIf("setTargetSpeed")]
  public float targetSpeedAcc = 100f;

  private void Update()
  {
    if (this.setTargetSpeed)
      this.speed = Vector3.MoveTowards(this.speed, this.targetSpeed, this.targetSpeedAcc * Time.deltaTime);
    this.transform.localEulerAngles = this.transform.localEulerAngles + this.speed * (this.ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime);
  }
}
