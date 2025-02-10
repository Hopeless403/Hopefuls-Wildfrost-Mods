// Decompiled with JetBrains decompiler
// Type: CardPoolReturner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CardPoolReturner : MonoBehaviour
{
  [SerializeField]
  public string[] scenesToIgnore;

  public void OnEnable() => global::Events.OnSceneUnload += new UnityAction<Scene>(this.SceneUnload);

  public void OnDisable() => global::Events.OnSceneUnload -= new UnityAction<Scene>(this.SceneUnload);

  public void SceneUnload(Scene scene)
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
