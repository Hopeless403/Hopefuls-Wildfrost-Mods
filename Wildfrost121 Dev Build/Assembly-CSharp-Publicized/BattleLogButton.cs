// Decompiled with JetBrains decompiler
// Type: BattleLogButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class BattleLogButton : MonoBehaviour
{
  [SerializeField]
  public JournalTab battleLogTab;

  public void Awake()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.SetActive(false);
  }

  public void OnDestroy() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  public void SceneChanged(Scene scene) => this.SetActive(scene.name == "Battle");

  public void SetActive(bool value)
  {
    this.gameObject.SetActive(value);
    if (!(bool) (Object) this.battleLogTab)
      return;
    this.battleLogTab.gameObject.SetActive(value);
  }
}
