// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public abstract class TutorialBattleSystem : TutorialParentSystem
{
  public override void OnEnable()
  {
    base.OnEnable();
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
  }

  public override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    this.BattleEnd();
  }

  public void SceneChanged(Scene scene) => Object.Destroy((Object) this);

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.Init)
      return;
    this.BattleStart();
  }

  public virtual void BattleStart()
  {
  }

  public virtual void BattleEnd()
  {
  }
}
