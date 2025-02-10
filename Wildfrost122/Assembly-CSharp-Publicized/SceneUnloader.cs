// Decompiled with JetBrains decompiler
// Type: SceneUnloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class SceneUnloader : MonoBehaviour
{
  public bool active = true;

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

  public IEnumerator UnloadAfterRoutine(float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    this.Unload();
  }
}
