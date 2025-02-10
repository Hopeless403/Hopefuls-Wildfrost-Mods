// Decompiled with JetBrains decompiler
// Type: TutorialCharmSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TutorialCharmSystem : TutorialParentSystem
{
  private static bool promptSystemNeedsReset;

  protected override void OnEnable()
  {
    if (SaveSystem.LoadProgressData<bool>("tutorialCharmDone", false))
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this);
    }
    else
    {
      base.OnEnable();
      global::Events.OnDeckpackOpen += new UnityAction(this.DeckpackOpen);
      global::Events.OnDeckpackClose += new UnityAction(this.DeckpackClose);
    }
  }

  protected override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnDeckpackOpen -= new UnityAction(this.DeckpackOpen);
    global::Events.OnDeckpackClose -= new UnityAction(this.DeckpackClose);
    TutorialCharmSystem.CheckPromptSystemReset();
  }

  private void DeckpackOpen()
  {
    if (References.PlayerData.inventory.upgrades.Count<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm)) <= 0)
      return;
    this.phases = new List<TutorialParentSystem.Phase>()
    {
      (TutorialParentSystem.Phase) new TutorialCharmSystem.PhaseEquipCharm(),
      (TutorialParentSystem.Phase) new TutorialCharmSystem.PhaseCharmEquipped()
    };
  }

  private void DeckpackClose()
  {
    this.phases = (List<TutorialParentSystem.Phase>) null;
    if (this.currentPhase != null)
      this.currentPhase.enabled = false;
    this.currentPhase = (TutorialParentSystem.Phase) null;
    this.delay = 0.0f;
    TutorialCharmSystem.CheckPromptSystemReset();
    if (!SaveSystem.LoadProgressData<bool>("tutorialCharmDone", false))
      return;
    UnityEngine.Object.Destroy((UnityEngine.Object) this);
  }

  private static void CheckPromptSystemReset()
  {
    if (!TutorialCharmSystem.promptSystemNeedsReset)
      return;
    PromptSystem.SetSortingLayer("Prompt", 0);
    TutorialCharmSystem.promptSystemNeedsReset = false;
  }

  private static void Done() => SaveSystem.SaveProgressData<bool>("tutorialCharmDone", true);

  private class PhaseEquipCharm : TutorialParentSystem.Phase
  {
    protected override void OnEnable()
    {
      global::Events.OnUpgradeAssign += new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssign);
      Routine.Create(this.PromptAfterDelay(1f));
    }

    protected override void OnDisable()
    {
      PromptSystem.Hide();
      global::Events.OnUpgradeAssign -= new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssign);
    }

    private void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
    {
      if (upgradeData.type != CardUpgradeData.Type.Charm)
        return;
      this.enabled = false;
    }

    private IEnumerator PromptAfterDelay(float delay)
    {
      TutorialCharmSystem.PhaseEquipCharm phaseEquipCharm = this;
      yield return (object) new WaitForSeconds(delay);
      if (phaseEquipCharm.enabled)
      {
        PromptSystem.SetSortingLayer("UI", 5);
        PromptSystem.Create(Prompt.Anchor.Left, 2f, 0.5f, 4f, Prompt.Emote.Type.Explain);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialCharm1.GetLocalizedString()));
        PromptSystem.Prompt.SetEmotePosition(Prompt.Emote.Position.Above, 1f, forceFlip: -1f);
        TutorialCharmSystem.promptSystemNeedsReset = true;
      }
    }
  }

  private class PhaseCharmEquipped : TutorialParentSystem.Phase
  {
    protected override void OnEnable()
    {
      global::Events.OnDeckpackClose += new UnityAction(this.DeckpackClose);
      Routine.Create(this.PromptAfterDelay(2f));
      TutorialCharmSystem.Done();
    }

    protected override void OnDisable()
    {
      PromptSystem.Hide();
      global::Events.OnDeckpackClose -= new UnityAction(this.DeckpackClose);
    }

    private void DeckpackClose() => this.enabled = false;

    private IEnumerator PromptAfterDelay(float delay)
    {
      TutorialCharmSystem.PhaseCharmEquipped phaseCharmEquipped = this;
      yield return (object) new WaitForSeconds(delay);
      if (phaseCharmEquipped.enabled)
      {
        PromptSystem.SetSortingLayer("UI", 5);
        PromptSystem.Create(Prompt.Anchor.Left, 1f, 1f, 5f, Prompt.Emote.Type.Scared);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialCharm2.GetLocalizedString()));
        TutorialCharmSystem.promptSystemNeedsReset = true;
      }
    }
  }
}
