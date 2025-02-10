// Decompiled with JetBrains decompiler
// Type: CardPoolReturner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CardPoolReturner : MonoBehaviour
{
  [SerializeField]
  private string[] scenesToIgnore;

  private void OnEnable() => global::Events.OnSceneUnload += new UnityAction<Scene>(this.SceneUnload);

  private void OnDisable() => global::Events.OnSceneUnload -= new UnityAction<Scene>(this.SceneUnload);

  private void SceneUnload(Scene scene)
  {
    if (this.scenesToIgnore.Contains<string>(scene.name))
      return;
    StopWatch.Start();
    int num = 0;
    foreach (GameObject rootGameObject in scene.GetRootGameObjects())
    {
      foreach (Card componentsInChild in rootGameObject.GetComponentsInChildren<Card>())
      {
        if (componentsInChild.entity.returnToPool && CardManager.ReturnToPool(componentsInChild))
          ++num;
      }
    }
    Debug.Log((object) string.Format("[{0}] Cards returned to pool from [{1}] ({2}ms)", (object) num, (object) scene.name, (object) StopWatch.Stop()));
  }
}
