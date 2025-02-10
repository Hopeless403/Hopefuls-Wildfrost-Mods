// Decompiled with JetBrains decompiler
// Type: EndTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;

#nullable disable
public class EndTransition : MonoBehaviour
{
  [SerializeField]
  public bool destroyObject;

  public IEnumerator Start()
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
