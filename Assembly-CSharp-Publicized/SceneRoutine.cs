// Decompiled with JetBrains decompiler
// Type: SceneRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

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
