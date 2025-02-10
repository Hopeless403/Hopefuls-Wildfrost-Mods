// Decompiled with JetBrains decompiler
// Type: FrostoscopeMapSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class FrostoscopeMapSystem : GameSystem
{
  [SerializeField]
  public UnlockData requiresUnlock;
  [SerializeField]
  public string[] visibleDuringScenes = new string[2]
  {
    "MapNew",
    "Event"
  };
  [SerializeField]
  public GameObject button;

  public void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.CheckIfUnlocked();
  }

  public void OnDisable() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  public void SceneChanged(Scene scene)
  {
    this.button.SetActive(this.visibleDuringScenes.Contains<string>(scene.name));
  }

  public void CheckIfUnlocked()
  {
    if (MetaprogressionSystem.IsUnlocked(this.requiresUnlock))
      return;
    this.gameObject.SetActive(false);
  }
}
