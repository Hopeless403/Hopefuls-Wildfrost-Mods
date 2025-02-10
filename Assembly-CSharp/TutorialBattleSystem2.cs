// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class TutorialBattleSystem2 : TutorialBattleSystem
{
  private Entity chosenUnit;

  protected override void BattleStart()
  {
    UnityEngine.Object.FindObjectOfType<BattleSaveSystem>()?.Disable();
    this.chosenUnit = TutorialBattleSystem2.FindChosenUnit();
    string[] nextCardNames = new string[6]
    {
      "Sword",
      "PinkberryJuice",
      this.chosenUnit.data.name,
      "Sword",
      "Sword",
      "Sword"
    };
    References.Player.OrderNextCards(nextCardNames);
    this.phases = new List<TutorialParentSystem.Phase>()
    {
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseWaitForLeader(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseInspectEnemy(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhasePlaceCompanion(this.chosenUnit),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseWaitDisallowRecall(2),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader(this.chosenUnit),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseBarrage(this.chosenUnit),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseWaitDisallowRecall(1),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseRecallToHeal(this.chosenUnit),
      (TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseRecallFree()
    };
  }

  private void InsertPhase(TutorialParentSystem.Phase phase) => this.phases.Insert(0, phase);

  private static Entity FindChosenUnit()
  {
    CardData chosenUnitData = References.PlayerData.inventory.deck.LastOrDefault<CardData>((Func<CardData, bool>) (a => a.cardType.unit));
    return Battle.GetCards(References.Player).LastOrDefault<Entity>((Func<Entity, bool>) (a => (long) a.data.id == (long) chosenUnitData.id));
  }

  private class PhaseWaitForLeader : TutorialParentSystem.Phase
  {
    protected override void OnEnable() => global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);

    protected override void OnDisable() => global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);

    private void EntityMove(Entity entity)
    {
      if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player) || !entity.data.cardType.miniboss || !Battle.IsOnBoard(entity))
        return;
      this.enabled = false;
    }
  }

  private class PhaseInspectEnemy : TutorialParentSystem.Phase
  {
    private Entity target;

    public override float delay => 0.2f;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnInspect += new UnityAction<Entity>(this.Inspect);
      global::Events.OnInspectEnd += new UnityAction<Entity>(this.InspectEnd);
      this.target = References.Battle.GetRow(References.Battle.enemy, 0).GetTop();
      PromptSystem.Create(Prompt.Anchor.TopLeft, 1.5f, -2f, 5f, Prompt.Emote.Type.Point);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(MonoBehaviourSingleton<Cursor3d>.instance.usingMouse ? ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_1) : ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_1Gamepad), (object) this.target.data.title)));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnInspect -= new UnityAction<Entity>(this.Inspect);
      global::Events.OnInspectEnd -= new UnityAction<Entity>(this.InspectEnd);
      PromptSystem.Hide();
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void Inspect(Entity entity) => PromptSystem.Hide();

    private void InspectEnd(Entity entity) => this.enabled = false;

    private bool CorrectAction(PlayAction action) => action is ActionInspect actionInspect && (UnityEngine.Object) actionInspect.entity == (UnityEngine.Object) this.target;
  }

  private class PhasePlaceCompanion : TutorialParentSystem.Phase
  {
    private readonly Entity target;

    public PhasePlaceCompanion(Entity target) => this.target = target;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      Routine routine = new Routine(this.PromptAfter(1f));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private IEnumerator PromptAfter(float delay)
    {
      TutorialBattleSystem2.PhasePlaceCompanion phasePlaceCompanion = this;
      yield return (object) new WaitForSeconds(delay);
      if (phasePlaceCompanion.enabled)
      {
        PromptSystem.Create(Prompt.Anchor.TopLeft, 1.5f, -2f, 5f);
        // ISSUE: reference to a compiler-generated method
        PromptSystem.SetTextAction(new Prompt.GetTextCallback(phasePlaceCompanion.\u003CPromptAfter\u003Eb__4_0));
      }
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void BattleTurnStart(int turn) => this.enabled = false;

    private bool CorrectAction(PlayAction action) => action is ActionMove actionMove && actionMove.entity.data.name == this.target.data.name && actionMove.toContainers.Length == 1 && Battle.IsOnBoard(actionMove.toContainers[0].Group) && actionMove.toContainers[0].Group.Count == 0;
  }

  private class PhaseWait : TutorialParentSystem.Phase
  {
    private int turns;

    public PhaseWait(int turns) => this.turns = turns;

    protected override void OnEnable() => global::Events.OnBattleTurnEnd += new UnityAction<int>(this.End);

    protected override void OnDisable() => global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.End);

    private void End(int turn)
    {
      if (--this.turns > 0)
        return;
      this.enabled = false;
    }
  }

  private class PhaseWaitDisallowRecall : TutorialParentSystem.Phase
  {
    private int turns;

    public PhaseWaitDisallowRecall(int turns) => this.turns = turns;

    protected override void OnEnable()
    {
      global::Events.OnBattleTurnEnd += new UnityAction<int>(this.End);
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    }

    protected override void OnDisable()
    {
      global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.End);
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!this.IsRecallAction(action) && !this.IsEarlyDeployAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private bool IsRecallAction(PlayAction action) => action is ActionMove actionMove && actionMove.toContainers.Length == 1 && (UnityEngine.Object) actionMove.toContainers[0] == (UnityEngine.Object) References.Player.discardContainer;

    private bool IsEarlyDeployAction(PlayAction action) => action is ActionEarlyDeploy;

    private void End(int turn)
    {
      if (--this.turns > 0)
        return;
      this.enabled = false;
    }
  }

  private class PhaseMoveCompanionInFrontOfLeader : TutorialParentSystem.Phase
  {
    private Entity leader;
    private Entity target;
    private CardSlot leaderSlot;
    private CardSlot targetSlot;

    public PhaseMoveCompanionInFrontOfLeader(Entity target) => this.target = target;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
      foreach (Entity entity in Battle.GetCardsOnBoard(References.Player))
      {
        if (entity.data.cardType.miniboss)
        {
          this.leader = entity;
          break;
        }
      }
      CardSlotLane container = this.leader.containers[0] as CardSlotLane;
      int index1 = container.IndexOf(this.leader);
      this.leaderSlot = container.slots[index1];
      int index2 = Mathf.Max(0, index1 - 1);
      this.targetSlot = container.slots[index2];
      Debug.Log((object) string.Format("Leader is in [{0}]", (object) this.leaderSlot));
      Debug.Log((object) string.Format("[{0}] SHOULD move to [{1}]", (object) this.target.data.title, (object) this.targetSlot));
      if ((UnityEngine.Object) this.targetSlot.GetTop() == (UnityEngine.Object) this.target)
      {
        this.enabled = false;
        Debug.Log((object) string.Format("[{0}] is already in [{1}]", (object) this.target.data.title, (object) this.targetSlot));
        UnityEngine.Object.FindObjectOfType<TutorialBattleSystem2>()?.InsertPhase((TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseWait(1));
      }
      else
      {
        PromptSystem.Create(Prompt.Anchor.Right, -2f, 1f, 5f, Prompt.Emote.Type.Talk);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_3.GetLocalizedString(), (object) this.target.data.title)));
        UnityEngine.Object.FindObjectOfType<TutorialBattleSystem2>()?.InsertPhase((TutorialParentSystem.Phase) new TutorialBattleSystem2.PhaseFreeMove());
      }
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
      PromptSystem.Hide();
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void ActionPerform(PlayAction action)
    {
      if (!this.CorrectAction(action))
        return;
      this.enabled = false;
    }

    private bool CorrectAction(PlayAction action) => action is ActionMove actionMove && actionMove.entity.data.name == this.target.data.name && actionMove.toContainers.Length == 1 && actionMove.toContainers[0] is CardSlot toContainer && (UnityEngine.Object) toContainer == (UnityEngine.Object) this.targetSlot;
  }

  private class PhaseBarrage : TutorialParentSystem.Phase
  {
    private Entity unitToMove;
    private readonly Entity chosenUnit;
    private Entity barrageEnemy;
    private PlayAction correctAction;

    public PhaseBarrage(Entity chosenUnit) => this.chosenUnit = chosenUnit;

    protected override void OnEnable()
    {
      this.barrageEnemy = Battle.GetCardsOnBoard(References.Battle.enemy).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.traits.Any<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => t.data.name == "Barrage"))));
      if (!(bool) (UnityEngine.Object) this.barrageEnemy)
        this.enabled = false;
      else if (References.Battle.GetRowIndex(this.barrageEnemy.containers[0]) != References.Battle.GetRowIndex(this.chosenUnit.containers[0]))
      {
        PromptSystem.Create(Prompt.Anchor.Left, 0.1f, 1f, 5f, Prompt.Emote.Type.Point);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_41a.GetLocalizedString(), (object) this.barrageEnemy.data.title, (object) this.chosenUnit.data.title)));
        this.unitToMove = this.chosenUnit;
      }
      else
      {
        PromptSystem.Create(Prompt.Anchor.Left, 0.1f, 1f, 5f, Prompt.Emote.Type.Point);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_41b.GetLocalizedString(), (object) this.barrageEnemy.data.title, (object) this.chosenUnit.data.title)));
        foreach (Entity entity in Battle.GetCardsOnBoard(References.Player))
        {
          if (entity.data.cardType.miniboss)
          {
            this.unitToMove = entity;
            break;
          }
        }
      }
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
      PromptSystem.Hide();
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (this.CorrectAction(action))
      {
        this.correctAction = action;
      }
      else
      {
        allow = false;
        PromptSystem.Shake();
      }
    }

    private void ActionPerform(PlayAction action)
    {
      if (this.correctAction == null || action != this.correctAction)
        return;
      this.enabled = false;
    }

    private bool CorrectAction(PlayAction action)
    {
      if (action is ActionMove actionMove && (UnityEngine.Object) actionMove.entity == (UnityEngine.Object) this.unitToMove && actionMove.toContainers.Length == 1)
      {
        CardContainer toContainer = actionMove.toContainers[0];
        if (toContainer != null && Battle.IsOnBoard(toContainer.Group))
          return (UnityEngine.Object) this.unitToMove.containers[0] != (UnityEngine.Object) toContainer.Group;
      }
      return false;
    }
  }

  private class PhaseFreeMove : TutorialParentSystem.Phase
  {
    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.HidePrompt);
      global::Events.OnBattleTurnEnd += new UnityAction<int>(this.End);
      PromptSystem.Create(Prompt.Anchor.Right, -2f, -1f, 5f, Prompt.Emote.Type.Point);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_4.GetLocalizedString()));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.HidePrompt);
      global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.End);
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || !this.IllegalAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void HidePrompt(int value) => PromptSystem.Hide();

    private void End(int value) => this.enabled = false;

    private bool IllegalAction(PlayAction action)
    {
      if (TutorialParentSystem.Phase.FreeMoveAction(action))
        return true;
      switch (action)
      {
        case ActionEarlyDeploy _:
          return true;
        case ActionMove actionMove:
          if (actionMove.toContainers.Length == 1 && (UnityEngine.Object) actionMove.toContainers[0] == (UnityEngine.Object) actionMove.entity.owner.discardContainer)
            return true;
          break;
      }
      return false;
    }
  }

  private class PhaseRecallToHeal : TutorialParentSystem.Phase
  {
    private Entity target;
    private WaveDeploySystemOverflow disabledWaveDeploySystem;

    public PhaseRecallToHeal(Entity target) => this.target = target;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
      PromptSystem.Create(Prompt.Anchor.Right, 0.0f, 1f, 5f);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_5.GetLocalizedString(), (object) this.target.data.title)));
      this.disabledWaveDeploySystem = UnityEngine.Object.FindObjectOfType<WaveDeploySystemOverflow>();
      if (!(bool) (UnityEngine.Object) this.disabledWaveDeploySystem)
        return;
      this.disabledWaveDeploySystem.navigationItem.enabled = false;
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
      PromptSystem.Hide();
      if (!(bool) (UnityEngine.Object) this.disabledWaveDeploySystem)
        return;
      this.disabledWaveDeploySystem.navigationItem.enabled = true;
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action) || TutorialBattleSystem2.PhaseRecallToHeal.DiscardHealAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void ActionPerform(PlayAction action)
    {
      if (!this.CorrectAction(action))
        return;
      this.enabled = false;
    }

    private bool CorrectAction(PlayAction action) => action is ActionMove actionMove && actionMove.entity.data.name == this.target.data.name && actionMove.toContainers.Length == 1 && (UnityEngine.Object) actionMove.toContainers[0] == (UnityEngine.Object) References.Player.discardContainer;

    private static bool DiscardHealAction(PlayAction action) => action is ActionDiscardEffect;
  }

  private class PhaseRecallFree : TutorialParentSystem.Phase
  {
    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.End);
      global::Events.OnBattleTurnEnd += new UnityAction<int>(this.End);
      MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_6.GetLocalizedString();
      PromptSystem.Create(Prompt.Anchor.Right, -2f, -1f, 5f, Prompt.Emote.Type.Happy);
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle2_6.GetLocalizedString()));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.End);
      global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.End);
      PromptSystem.Hide();
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!(action is ActionEarlyDeploy))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void End(int value) => this.enabled = false;
  }
}
