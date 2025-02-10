// Decompiled with JetBrains decompiler
// Type: TutorialCrownSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TutorialCrownSystem : TutorialParentSystem
{
  public static bool promptSystemNeedsReset;
  public bool deckpackOpen;
  public bool promptShown;

  public override void OnEnable()
  {
    if (SaveSystem.LoadProgressData<bool>("tutorialCrownDone", false))
    {
      Object.Destroy((Object) this);
    }
    else
    {
      base.OnEnable();
      global::Events.OnDeckpackOpen += new UnityAction(this.DeckpackOpen);
      global::Events.OnDeckpackClose += new UnityAction(this.DeckpackClose);
      global::Events.OnUpgradeAssign += new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssign);
    }
  }

  public override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnDeckpackOpen -= new UnityAction(this.DeckpackOpen);
    global::Events.OnDeckpackClose -= new UnityAction(this.DeckpackClose);
    global::Events.OnUpgradeAssign -= new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssign);
    this.HidePrompt();
  }

  public void DeckpackOpen() => this.deckpackOpen = true;

  public void DeckpackClose()
  {
    this.deckpackOpen = false;
    this.HidePrompt();
  }

  public void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    if (!this.deckpackOpen || upgradeData.type != CardUpgradeData.Type.Crown)
      return;
    this.ShowPrompt();
    SaveSystem.SaveProgressData<bool>("tutorialCrownDone", true);
  }

  public void ShowPrompt()
  {
    if (this.promptShown)
      return;
    PromptSystem.Hide();
    PromptSystem.SetSortingLayer("UI", 5);
    PromptSystem.Create(Prompt.Anchor.Left, 2f, 0.5f, 4f, Prompt.Emote.Type.Point);
    PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialCrown.GetLocalizedString()));
    TutorialCrownSystem.promptSystemNeedsReset = true;
    this.promptShown = true;
  }

  public void HidePrompt()
  {
    if (!this.promptShown)
      return;
    PromptSystem.Hide();
    TutorialCrownSystem.CheckPromptSystemReset();
  }

  public static void CheckPromptSystemReset()
  {
    if (!TutorialCrownSystem.promptSystemNeedsReset)
      return;
    PromptSystem.SetSortingLayer("Prompt", 0);
    TutorialCrownSystem.promptSystemNeedsReset = false;
  }
}
