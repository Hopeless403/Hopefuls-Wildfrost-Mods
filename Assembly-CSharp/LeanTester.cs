// Decompiled with JetBrains decompiler
// Type: LeanTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
