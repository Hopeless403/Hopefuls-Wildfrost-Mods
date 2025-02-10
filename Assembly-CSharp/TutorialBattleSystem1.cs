// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class TutorialBattleSystem1 : TutorialBattleSystem
{
  private static readonly string[] startingHand = new string[6]
  {
    "Sword",
    "SnowStick",
    "Sword",
    "Foxee",
    "Sword",
    "Sword"
  };

  protected override void BattleStart()
  {
    UnityEngine.Object.FindObjectOfType<BattleSaveSystem>()?.Disable();
    CardContainer cardContainer = References.Battle.rows[References.Battle.enemy][0];
    cardContainer.canBePlacedOn = false;
    cardContainer.transform.parent.gameObject.SetActive(false);
    UnityEngine.Object.FindObjectOfType<RedrawBellSystem>()?.Disable();
    WaveDeploySystem objectOfType = UnityEngine.Object.FindObjectOfType<WaveDeploySystem>();
    if (objectOfType != null)
    {
      objectOfType.Hide();
      objectOfType.visible = false;
    }
    References.Player.OrderNextCards(TutorialBattleSystem1.startingHand);
    this.phases = new List<TutorialParentSystem.Phase>()
    {
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhasePlaceLeader(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhasePlaceCompanion(TutorialBattleSystem1.FindLastUnit().data),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseUseItem(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseCounters(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseEnemiesAttackFirst(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseWaitForNewEnemies(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseRedrawBell(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseRedrawBellPopUp(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseProtectLeader(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseWaveDeploy(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseWaitForMiniboss(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem1.PhaseMiniboss()
    };
  }

  private static Entity FindLastUnit()
  {
    CardData chosenUnitData = References.PlayerData.inventory.deck.LastOrDefault<CardData>((Func<CardData, bool>) (a => a.cardType.unit));
    return Battle.GetCards(References.Player).LastOrDefault<Entity>((Func<Entity, bool>) (a => (long) a.data.id == (long) chosenUnitData.id));
  }

  protected override void BattleEnd() => UnityEngine.Object.FindObjectOfType<RedrawBellSystem>()?.Enable();

  private class PhasePlaceLeader : TutorialParentSystem.Phase
  {
    protected override void OnEnable()
    {
      global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
      Routine routine = new Routine(this.PromptAfter(2f));
    }

    protected override void OnDisable()
    {
      global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
      PromptSystem.Hide();
    }

    private void EntityMove(Entity entity)
    {
      if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player) || !entity.data.cardType.miniboss || !Battle.IsOnBoard(entity))
        return;
      this.enabled = false;
    }

    private IEnumerator PromptAfter(float delay)
    {
      TutorialBattleSystem1.PhasePlaceLeader phasePlaceLeader = this;
      yield return (object) new WaitForSeconds(delay);
      if (phasePlaceLeader.enabled)
      {
        PromptSystem.Create(Prompt.Anchor.Top, 0.0f, -2f, 8.7f);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_1.GetLocalizedString()));
      }
    }
  }

  private class PhasePlaceCompanion : TutorialParentSystem.Phase
  {
    private readonly CardData target;

    public override float delay => 1f;

    public PhasePlaceCompanion(CardData target) => this.target = target;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Create(Prompt.Anchor.TopLeft, 2f, -2f, 8f, Prompt.Emote.Type.Talk);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_2.GetLocalizedString(), (object) this.target.title)));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void BattleTurnStart(int turn) => this.enabled = false;

    private bool CorrectAction(PlayAction action) => action is ActionMove actionMove && actionMove.entity.data.name == this.target.name && actionMove.toContainers.Length == 1 && Battle.IsOnBoard(actionMove.toContainers[0].Group);
  }

  private class PhaseUseItem : TutorialParentSystem.Phase
  {
    public override float delay => 1f;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Create(Prompt.Anchor.TopLeft, 1f, -2f, 6f, Prompt.Emote.Type.Point);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_3.GetLocalizedString()));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void BattleTurnStart(int turn) => this.enabled = false;

    private bool CorrectAction(PlayAction action) => action is ActionTriggerAgainst actionTriggerAgainst && actionTriggerAgainst.entity.data.name == "Sword" && actionTriggerAgainst.target.data.name == "Pengoon";
  }

  private class PhaseCounters : TutorialParentSystem.Phase
  {
    public override float delay => 1f;

    protected override void OnEnable()
    {
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Create(Prompt.Anchor.Top, 0.0f, -1.5f, 9f, Prompt.Emote.Type.Explain);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_4.GetLocalizedString()));
    }

    protected override void OnDisable()
    {
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private void BattleTurnStart(int turn) => this.enabled = false;
  }

  private class PhaseEnemiesAttackFirst : TutorialParentSystem.Phase
  {
    public override float delay => 0.0f;

    protected override void OnEnable()
    {
      global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(TutorialBattleSystem1.PhaseEnemiesAttackFirst.BattlePhaseStart);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
    }

    protected override void OnDisable()
    {
      global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(TutorialBattleSystem1.PhaseEnemiesAttackFirst.BattlePhaseStart);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private static void BattlePhaseStart(Battle.Phase phase)
    {
      if (phase != Battle.Phase.Play)
        return;
      PromptSystem.Create(Prompt.Anchor.TopRight, -3f, -3f, 4f, Prompt.Emote.Type.Scared);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_41.GetLocalizedString()));
    }

    private void BattleTurnStart(int turn) => this.enabled = false;
  }

  private class PhaseWaitForNewEnemies : TutorialParentSystem.Phase
  {
    protected override void OnEnable() => global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);

    protected override void OnDisable() => global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);

    private void ActionPerform(PlayAction action)
    {
      if (!(action is ActionMove actionMove) || !((UnityEngine.Object) actionMove.entity.owner == (UnityEngine.Object) References.Battle.enemy))
        return;
      this.enabled = false;
    }
  }

  private class PhaseRedrawBell : TutorialParentSystem.Phase
  {
    public override float delay => 1f;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(TutorialBattleSystem1.PhaseRedrawBell.CheckAction);
      global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
      PromptSystem.Create(Prompt.Anchor.TopRight, -1f, -1.25f, 6f, Prompt.Emote.Type.Talk);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_5.GetLocalizedString()));
      RedrawBellSystem objectOfType = UnityEngine.Object.FindObjectOfType<RedrawBellSystem>();
      if (!(bool) (UnityEngine.Object) objectOfType)
        return;
      objectOfType.Enable();
      objectOfType.BecomeInteractable();
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(TutorialBattleSystem1.PhaseRedrawBell.CheckAction);
      global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
      PromptSystem.Hide();
    }

    private static void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || TutorialBattleSystem1.PhaseRedrawBell.CorrectAction(action) || TutorialBattleSystem1.PhaseRedrawBell.PlayCardAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void ActionPerform(PlayAction action)
    {
      if (!TutorialBattleSystem1.PhaseRedrawBell.CorrectAction(action))
        return;
      this.enabled = false;
    }

    private static bool CorrectAction(PlayAction action) => action is ActionRedraw;

    private static bool PlayCardAction(PlayAction action) => action is ActionTrigger;
  }

  private class PhaseRedrawBellPopUp : TutorialParentSystem.Phase
  {
    private TutorialSystem tutorialSystem;

    public override float delay => 1f;

    protected override void OnEnable()
    {
      this.tutorialSystem = UnityEngine.Object.FindObjectOfType<TutorialSystem>();
      global::Events.OnBattleTurnEnd += new UnityAction<int>(this.Show);
    }

    protected override void OnDisable() => global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.Show);

    private void Show(int turn)
    {
      HelpPanelSystem.Show(this.tutorialSystem.redrawBellHelpKey);
      HelpPanelSystem.SetEmote(this.tutorialSystem.redrawBellHelpEmote);
      HelpPanelSystem.SetImage(1.5f, 1.5f, this.tutorialSystem.redrawBellHelpSprite);
      HelpPanelSystem.SetBackButtonActive(false);
      HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, this.tutorialSystem.redrawBellHelpButtonKey, "Select", new UnityAction(this.End));
    }

    private void End() => this.enabled = false;
  }

  private class PhaseProtectLeader : TutorialParentSystem.Phase
  {
    public override float delay => 1f;

    protected override void OnEnable() => this.Show();

    protected override void OnDisable() => PromptSystem.Hide();

    private void Show()
    {
      PromptSystem.Create(Prompt.Anchor.Left, 1f, 1f, 4f);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_6.GetLocalizedString()));
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.End);
    }

    private void End(int turn)
    {
      this.enabled = false;
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.End);
    }
  }

  private class PhaseWaveDeploy : TutorialParentSystem.Phase
  {
    public override float delay => 1f;

    protected override void OnEnable()
    {
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      UnityEngine.Object.FindObjectOfType<WaveDeploySystem>()?.Show();
      PromptSystem.Create(Prompt.Anchor.TopRight, -3f, -1.75f, 6f, Prompt.Emote.Type.Talk);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_7.GetLocalizedString()));
      PromptSystem.Prompt.SetEmotePosition(Prompt.Emote.Position.Above, 2f, forceFlip: 1f);
    }

    protected override void OnDisable()
    {
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private void BattleTurnStart(int turn) => this.enabled = false;
  }

  private class PhaseWaitForMiniboss : TutorialParentSystem.Phase
  {
    protected override void OnEnable() => global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);

    protected override void OnDisable() => global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);

    private void ActionPerform(PlayAction action)
    {
      if (!(action is ActionMove actionMove) || !((UnityEngine.Object) actionMove.entity.owner == (UnityEngine.Object) References.Battle.enemy) || !actionMove.entity.data.cardType.miniboss)
        return;
      this.enabled = false;
    }
  }

  private class PhaseMiniboss : TutorialParentSystem.Phase
  {
    public override float delay => 1f;

    protected override void OnEnable()
    {
      global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
      Routine routine = new Routine(this.PromptAfterDelay(2f));
    }

    protected override void OnDisable()
    {
      global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
      PromptSystem.Hide();
    }

    private void EntityKilled(Entity entity, DeathType deathType)
    {
      if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Battle.enemy) || !entity.data.cardType.miniboss)
        return;
      this.enabled = false;
    }

    private IEnumerator PromptAfterDelay(float delay)
    {
      TutorialBattleSystem1.PhaseMiniboss phaseMiniboss = this;
      yield return (object) new WaitForSeconds(delay);
      if (phaseMiniboss.enabled)
      {
        PromptSystem.Create(Prompt.Anchor.TopLeft, 2f, -1.5f, 5f, Prompt.Emote.Type.Talk);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle1_8.GetLocalizedString()));
      }
    }
  }
}
