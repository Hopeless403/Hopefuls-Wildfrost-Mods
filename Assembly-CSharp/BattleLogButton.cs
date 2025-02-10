// Decompiled with JetBrains decompiler
// Type: BattleLogButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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
