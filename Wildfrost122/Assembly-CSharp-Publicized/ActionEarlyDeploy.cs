// Decompiled with JetBrains decompiler
// Type: ActionEarlyDeploy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class ActionEarlyDeploy : PlayAction
{
  public readonly Transform transform;
  public readonly IEnumerator earlyDeployRoutine;

  public ActionEarlyDeploy(Transform transform, IEnumerator earlyDeployRoutine)
  {
    this.transform = transform;
    this.earlyDeployRoutine = earlyDeployRoutine;
  }

  public override IEnumerator Run()
  {
    SfxSystem.OneShot("event:/sfx/inventory/wave_counter_ring");
    this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, 20f);
    LeanTween.cancel(this.transform.gameObject);
    LeanTween.rotateLocal(this.transform.gameObject, Vector3.zero, 1.5f).setEaseOutElastic();
    yield return (object) this.earlyDeployRoutine;
  }
}
