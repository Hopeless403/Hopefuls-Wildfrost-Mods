// Decompiled with JetBrains decompiler
// Type: SceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
