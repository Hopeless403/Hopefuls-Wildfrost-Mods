// Decompiled with JetBrains decompiler
// Type: TutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

#nullable disable
public class TutorialSystem : GameSystem
{
  public LocalizedString redrawBellHelpKey;
  public Prompt.Emote.Type redrawBellHelpEmote = Prompt.Emote.Type.Explain;
  public LocalizedString redrawBellHelpButtonKey;
  public Sprite redrawBellHelpSprite;
  public TutorialSystem.Data data;

  public void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnCampaignSaved += new UnityAction(this.CampaignSaved);
    global::Events.OnCampaignLoaded += new UnityAction(this.CampaignLoaded);
  }

  public void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnCampaignSaved -= new UnityAction(this.CampaignSaved);
    global::Events.OnCampaignLoaded -= new UnityAction(this.CampaignLoaded);
  }

  public void SceneChanged(Scene scene)
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

  public void CampaignSaved()
  {
    SaveSystem.SaveCampaignData<TutorialSystem.Data>(Campaign.Data.GameMode, "tutorialData", this.data);
  }

  public void CampaignLoaded()
  {
    this.data = SaveSystem.LoadCampaignData<TutorialSystem.Data>(Campaign.Data.GameMode, "tutorialData", new TutorialSystem.Data());
  }

  [Serializable]
  public struct Data
  {
    public int battleNumber;
    public int eventNumber;
  }
}
