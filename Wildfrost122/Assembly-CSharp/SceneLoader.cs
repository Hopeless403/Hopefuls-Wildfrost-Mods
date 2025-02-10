// Decompiled with JetBrains decompiler
// Type: SceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class SceneLoader : MonoBehaviour
{
  public string sceneKey;
  public SceneType sceneType = SceneType.Temporary;
  private bool loading;

  public void Load()
  {
    if (this.loading)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.LoadRoutine());
  }

  private IEnumerator LoadRoutine()
  {
    this.loading = true;
    yield return (object) SceneManager.Load(this.sceneKey, this.sceneType);
    this.loading = false;
  }
}
