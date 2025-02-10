// Decompiled with JetBrains decompiler
// Type: TutorialCrownSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class TutorialCrownSystem : TutorialParentSystem
{
  private static bool promptSystemNeedsReset;
  private bool deckpackOpen;
  private bool promptShown;

  protected override void OnEnable()
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

  protected override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnDeckpackOpen -= new UnityAction(this.DeckpackOpen);
    global::Events.OnDeckpackClose -= new UnityAction(this.DeckpackClose);
    global::Events.OnUpgradeAssign -= new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssign);
    this.HidePrompt();
  }

  private void DeckpackOpen() => this.deckpackOpen = true;

  private void DeckpackClose()
  {
    this.deckpackOpen = false;
    this.HidePrompt();
  }

  private void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    if (!this.deckpackOpen || upgradeData.type != CardUpgradeData.Type.Crown)
      return;
    this.ShowPrompt();
    SaveSystem.SaveProgressData<bool>("tutorialCrownDone", true);
  }

  private void ShowPrompt()
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

  private void HidePrompt()
  {
    if (!this.promptShown)
      return;
    PromptSystem.Hide();
    TutorialCrownSystem.CheckPromptSystemReset();
  }

  private static void CheckPromptSystemReset()
  {
    if (!TutorialCrownSystem.promptSystemNeedsReset)
      return;
    PromptSystem.SetSortingLayer("Prompt", 0);
    TutorialCrownSystem.promptSystemNeedsReset = false;
  }
}
