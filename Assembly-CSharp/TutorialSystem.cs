// Decompiled with JetBrains decompiler
// Type: TutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

public class TutorialSystem : GameSystem
{
  public LocalizedString redrawBellHelpKey;
  public Prompt.Emote.Type redrawBellHelpEmote = Prompt.Emote.Type.Explain;
  public LocalizedString redrawBellHelpButtonKey;
  public Sprite redrawBellHelpSprite;
  private TutorialSystem.Data data;

  private void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnCampaignSaved += new UnityAction(this.CampaignSaved);
    global::Events.OnCampaignLoaded += new UnityAction(this.CampaignLoaded);
  }

  private void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnCampaignSaved -= new UnityAction(this.CampaignSaved);
    global::Events.OnCampaignLoaded -= new UnityAction(this.CampaignLoaded);
  }

  private void SceneChanged(Scene scene)
  {
    switch (scene.name)
    {
      case "Battle":
        switch (this.data.battleNumber)
        {
          case 0:
            this.gameObject.AddComponent<TutorialBattleSystem1>();
            SaveSystem.SaveProgressData<int>("tutorialProgress", 1);
            global::Events.InvokeTutorialProgress(1);
            break;
          case 1:
            this.gameObject.AddComponent<TutorialBattleSystem2>();
            break;
          case 2:
            this.gameObject.AddComponent<TutorialBattleSystem3>();
            DynamicTutorialSystem objectOfType = UnityEngine.Object.FindObjectOfType<DynamicTutorialSystem>();
            if (objectOfType != null)
              objectOfType.enabled = true;
            SaveSystem.SaveProgressData<int>("tutorialProgress", 2);
            global::Events.InvokeTutorialProgress(2);
            break;
        }
        ++this.data.battleNumber;
        break;
      case "Event":
        switch (this.data.eventNumber)
        {
          case 0:
            this.gameObject.AddComponent<TutorialCompanionSystem>();
            break;
          case 2:
            this.gameObject.AddComponent<TutorialItemSystem2>();
            break;
        }
        ++this.data.eventNumber;
        break;
    }
  }

  private void CampaignSaved() => SaveSystem.SaveCampaignData<TutorialSystem.Data>(Campaign.Data.GameMode, "tutorialData", this.data);

  private void CampaignLoaded() => this.data = SaveSystem.LoadCampaignData<TutorialSystem.Data>(Campaign.Data.GameMode, "tutorialData", new TutorialSystem.Data());

  [Serializable]
  public struct Data
  {
    public int battleNumber;
    public int eventNumber;
  }
}
