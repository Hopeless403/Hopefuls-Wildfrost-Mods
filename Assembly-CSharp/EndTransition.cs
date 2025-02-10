// Decompiled with JetBrains decompiler
// Type: EndTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

public class EndTransition : MonoBehaviour
{
  [SerializeField]
  private bool destroyObject;

  private IEnumerator Start()
  {
    EndTransition endTransition = this;
    yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.HasNoActiveJobs));
    Transition.End();
    if (endTransition.destroyObject)
      UnityEngine.Object.Destroy((UnityEngine.Object) endTransition.gameObject);
    else
      UnityEngine.Object.Destroy((UnityEngine.Object) endTransition);
  }
}
