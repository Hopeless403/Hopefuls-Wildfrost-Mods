// Decompiled with JetBrains decompiler
// Type: SceneUnloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class SceneUnloader : MonoBehaviour
{
  private bool active = true;

  public void Unload()
  {
    if (!this.active)
      return;
    this.active = false;
    Routine routine = new Routine(SceneManager.Unload(this.gameObject.scene.name));
  }

  public void UnloadAfter(float delay)
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.UnloadAfterRoutine(delay));
  }

  private IEnumerator UnloadAfterRoutine(float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    this.Unload();
  }
}
