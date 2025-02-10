// Decompiled with JetBrains decompiler
// Type: SceneRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
public class SceneRoutine : MonoBehaviour
{
  public virtual IEnumerator Run() => (IEnumerator) null;

  [Button(null, EButtonEnableMode.Always)]
  public void PromptRun()
  {
    if (!Application.isPlaying)
      return;
    Routine routine = new Routine(this.Run());
  }
}
