// Decompiled with JetBrains decompiler
// Type: SceneRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
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
