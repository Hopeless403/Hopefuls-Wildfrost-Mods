﻿// Decompiled with JetBrains decompiler
// Type: SceneUnloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
