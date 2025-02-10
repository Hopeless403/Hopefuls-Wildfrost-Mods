// Decompiled with JetBrains decompiler
// Type: CardPoolReturner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
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
