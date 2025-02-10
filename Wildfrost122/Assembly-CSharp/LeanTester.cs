// Decompiled with JetBrains decompiler
// Type: LeanTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class LeanTester : MonoBehaviour
{
  public float timeout = 15f;

  public void Start() => this.StartCoroutine(this.timeoutCheck());

  private IEnumerator timeoutCheck()
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
