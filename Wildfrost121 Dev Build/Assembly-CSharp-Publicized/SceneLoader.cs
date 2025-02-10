// Decompiled with JetBrains decompiler
// Type: SceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class SceneLoader : MonoBehaviour
{
  public string sceneKey;
  public SceneType sceneType = SceneType.Temporary;
  public bool loading;

  public void Load()
  {
    if (this.loading)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.LoadRoutine());
  }

  public IEnumerator LoadRoutine()
  {
    this.loading = true;
    yield return (object) SceneManager.Load(this.sceneKey, this.sceneType);
    this.loading = false;
  }
}
