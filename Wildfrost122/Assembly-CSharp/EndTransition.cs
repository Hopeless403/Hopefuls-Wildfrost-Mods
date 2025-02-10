// Decompiled with JetBrains decompiler
// Type: EndTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

#nullable disable
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
