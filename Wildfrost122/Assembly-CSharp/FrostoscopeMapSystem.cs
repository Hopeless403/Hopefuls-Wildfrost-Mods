// Decompiled with JetBrains decompiler
// Type: FrostoscopeMapSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class FrostoscopeMapSystem : GameSystem
{
  [SerializeField]
  private UnlockData requiresUnlock;
  [SerializeField]
  private string[] visibleDuringScenes = new string[2]
  {
    "MapNew",
    "Event"
  };
  [SerializeField]
  private GameObject button;

  private void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.CheckIfUnlocked();
  }

  private void OnDisable() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  private void SceneChanged(Scene scene)
  {
    this.button.SetActive(this.visibleDuringScenes.Contains<string>(scene.name));
  }

  private void CheckIfUnlocked()
  {
    if (MetaprogressionSystem.IsUnlocked(this.requiresUnlock))
      return;
    this.gameObject.SetActive(false);
  }
}
