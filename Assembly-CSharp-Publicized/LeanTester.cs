// Decompiled with JetBrains decompiler
// Type: LeanTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

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
