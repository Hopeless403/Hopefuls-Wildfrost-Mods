// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public abstract class TutorialBattleSystem : TutorialParentSystem
{
  protected override void OnEnable()
  {
    base.OnEnable();
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
  }

  protected override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    this.BattleEnd();
  }

  private void SceneChanged(Scene scene) => Object.Destroy((Object) this);

  private void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.Init)
      return;
    this.BattleStart();
  }

  protected virtual void BattleStart()
  {
  }

  protected virtual void BattleEnd()
  {
  }
}
