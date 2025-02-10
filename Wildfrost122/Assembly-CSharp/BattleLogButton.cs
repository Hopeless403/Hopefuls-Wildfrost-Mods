// Decompiled with JetBrains decompiler
// Type: BattleLogButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class BattleLogButton : MonoBehaviour
{
  [SerializeField]
  private JournalTab battleLogTab;

  private void Awake()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.SetActive(false);
  }

  private void OnDestroy() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  private void SceneChanged(Scene scene) => this.SetActive(scene.name == "Battle");

  private void SetActive(bool value)
  {
    this.gameObject.SetActive(value);
    if (!(bool) (Object) this.battleLogTab)
      return;
    this.battleLogTab.gameObject.SetActive(value);
  }
}
