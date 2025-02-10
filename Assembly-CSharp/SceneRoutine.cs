// Decompiled with JetBrains decompiler
// Type: SceneRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class SceneRoutine : MonoBehaviour
{
  public virtual IEnumerator Run() => (IEnumerator) null;

  [Button(null, EButtonEnableMode.Always)]
  protected void PromptRun()
  {
    if (!Application.isPlaying)
      return;
    Routine routine = new Routine(this.Run());
  }
}
