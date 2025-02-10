// Decompiled with JetBrains decompiler
// Type: TutorialInjurySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TutorialInjurySystem : TutorialParentSystem
{
  public bool promptShown;

  public override void OnEnable()
  {
    if (SaveSystem.LoadProgressData<bool>("tutorialInjuryDone", false))
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this);
    }
    else
    {
      base.OnEnable();
      global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);
      global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    }
  }

  public override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
  }

  public void SceneChanged(Scene scene)
  {
    if (this.promptShown)
    {
      PromptSystem.Hide();
      this.promptShown = false;
    }
    if (!SaveSystem.LoadProgressData<bool>("tutorialInjuryDone", false))
      return;
    UnityEngine.Object.Destroy((UnityEngine.Object) this);
  }

  public void BattleEnd()
  {
    if (!((UnityEngine.Object) References.Battle.winner == (UnityEngine.Object) References.Battle.player))
      return;
    CardData[] injuriesThisBattle = InjurySystem.GetInjuriesThisBattle();
    if (injuriesThisBattle.Length == 0)
      return;
    this.StartCoroutine(this.Routine(injuriesThisBattle));
  }

  public IEnumerator Routine(CardData[] injuries)
  {
    yield return (object) TutorialInjurySystem.WaitForInjuriesPanel();
    PromptSystem.Create(Prompt.Anchor.Left, 0.5f, 0.0f, 5f, Prompt.Emote.Type.Sad);
    PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => injuries.Length != 1 ? MonoBehaviourSingleton<StringReference>.instance.tutorialInjuryMultiple.GetLocalizedString() : string.Format(MonoBehaviourSingleton<StringReference>.instance.tutorialInjury.GetLocalizedString(), (object) injuries[0].title)));
    this.promptShown = true;
    SaveSystem.SaveProgressData<bool>("tutorialInjuryDone", true);
  }

  public static IEnumerator WaitForInjuriesPanel()
  {
    yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.IsLoaded("BattleWin")));
  }
}
