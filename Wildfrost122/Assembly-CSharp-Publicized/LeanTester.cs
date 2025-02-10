// Decompiled with JetBrains decompiler
// Type: LeanTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class LeanTester : MonoBehaviour
{
  public float timeout = 15f;

  public void Start() => this.StartCoroutine(this.timeoutCheck());

  public IEnumerator timeoutCheck()
  {
    float pauseEndTime = Time.realtimeSinceStartup + this.timeout;
    while ((double) Time.realtimeSinceStartup < (double) pauseEndTime)
      yield return (object) 0;
    if (!LeanTest.testsFinished)
    {
      Debug.Log((object) LeanTest.formatB("Tests timed out!"));
      LeanTest.overview();
    }
  }
}
