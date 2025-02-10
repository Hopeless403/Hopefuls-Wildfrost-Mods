// Decompiled with JetBrains decompiler
// Type: DynamicTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class DynamicTutorialSystem : GameSystem
{
  [SerializeField]
  private DynamicTutorialSystem.Tutorial redrawTutorial;
  [SerializeField]
  private DynamicTutorialSystem.Tutorial moveTutorial;
  [SerializeField]
  private DynamicTutorialSystem.Tutorial recallTutorial;
  [SerializeField]
  private DynamicTutorialSystem.Tutorial aimlessTutorial;
  [SerializeField]
  private DynamicTutorialSystem.Tutorial reactionTutorial;
  private DynamicTutorialSystem.Tutorial[] tutorials;
  private bool aimlessTutorialDone;
  private bool reactionTutorialDone;
  private Entity aimlessEnemy;
  private Entity reactionEnemy;

  private void OnEnable()
  {
    this.tutorials = new DynamicTutorialSystem.Tutorial[5]
    {
      this.redrawTutorial,
      this.moveTutorial,
      this.recallTutorial,
      this.aimlessTutorial,
      this.reactionTutorial
    };
    foreach (DynamicTutorialSystem.Tutorial tutorial in this.tutorials)
      tutorial.Load();
    this.aimlessTutorialDone = SaveSystem.LoadProgressData<bool>("dynamicAimlessTutorial", false);
    this.reactionTutorialDone = SaveSystem.LoadProgressData<bool>("dynamicReactionTutorial", false);
    global::Events.OnEntityPlace += new UnityAction<Entity, CardContainer[], bool>(this.EntityPlace);
    global::Events.OnDiscard += new UnityAction<Entity>(this.Discard);
    global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnBattleTurnStart += new UnityAction<int>(this.TurnStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.TurnEnd);
    global::Events.OnCampaignSaved += new UnityAction(this.Save);
  }

  private void OnDisable()
  {
    global::Events.OnEntityPlace -= new UnityAction<Entity, CardContainer[], bool>(this.EntityPlace);
    global::Events.OnDiscard -= new UnityAction<Entity>(this.Discard);
    global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnBattleTurnStart -= new UnityAction<int>(this.TurnStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.TurnEnd);
    global::Events.OnCampaignSaved -= new UnityAction(this.Save);
  }

  private void EntityPlace(Entity entity, CardContainer[] slots, bool freeMove)
  {
    if (!freeMove || entity.owner.team != References.Player.team)
      return;
    this.moveTutorial.actionDoneThisTurn = true;
    this.moveTutorial.ResetCount();
  }

  private void Discard(Entity entity)
  {
    if (!entity.data.hasHealth)
      return;
    this.recallTutorial.actionDoneThisTurn = true;
    this.recallTutorial.ResetCount();
  }

  private void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    if (redrawBellSystem.IsCharged)
      return;
    this.redrawTutorial.actionDoneThisTurn = true;
    this.redrawTutorial.ResetCount();
  }

  private void TurnStart(int turnCount)
  {
    foreach (DynamicTutorialSystem.Tutorial tutorial in this.tutorials)
    {
      if (tutorial.shown)
      {
        tutorial.Hide();
        break;
      }
    }
  }

  private void TurnEnd(int turnCount)
  {
    foreach (DynamicTutorialSystem.Tutorial tutorial in this.tutorials)
      tutorial.CheckIncreaseCount();
    if (References.Battle.ended || this.CheckAimlessTutorial(turnCount) || this.CheckReactionTutorial(turnCount) || this.CheckMoveTutorial() || this.CheckRedrawTutorial())
      return;
    this.CheckRecallTutorial();
  }

  private bool CheckAimlessTutorial(int turnCount)
  {
    if (this.aimlessTutorialDone)
      return false;
    if (turnCount == 0)
    {
      this.aimlessEnemy = Battle.GetCardsOnBoard(References.Battle.enemy).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.traits.Any<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => t.data.name == "Aimless"))));
      return false;
    }
    if (!(bool) (UnityEngine.Object) this.aimlessEnemy || !this.aimlessEnemy.IsAliveAndExists() || this.aimlessEnemy.counter.current != 1)
      return false;
    this.aimlessTutorial.Show((object) this.aimlessEnemy.data.title);
    SaveSystem.SaveProgressData<bool>("dynamicAimlessTutorial", true);
    this.aimlessTutorialDone = true;
    return true;
  }

  private bool CheckReactionTutorial(int turnCount)
  {
    if (this.reactionTutorialDone || turnCount != 0)
      return false;
    this.reactionEnemy = Battle.GetCardsOnBoard(References.Battle.enemy).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.isReaction))));
    if (!(bool) (UnityEngine.Object) this.reactionEnemy)
      return false;
    this.reactionTutorial.Show((object) this.reactionEnemy.data.title);
    SaveSystem.SaveProgressData<bool>("dynamicReactionTutorial", true);
    this.reactionTutorialDone = true;
    return true;
  }

  private bool CheckRecallTutorial()
  {
    if (this.recallTutorial.Check())
    {
      foreach (Entity entity in Battle.GetCardsOnBoard(References.Battle.player))
      {
        if (entity.data.hasHealth && (double) entity.hp.current <= (double) entity.hp.max * 0.5 && entity.CanRecall())
        {
          this.recallTutorial.Show();
          PromptSystem.Prompt.SetEmotePosition(Prompt.Emote.Position.Above, 2f);
          return true;
        }
      }
    }
    return false;
  }

  private bool CheckRedrawTutorial()
  {
    if (!this.redrawTutorial.Check() || References.Battle.turnCount != 0 || Battle.GetCardsOnBoard(References.Battle.player).Count != 1)
      return false;
    foreach (Entity entity in References.Battle.player.handContainer)
    {
      if (entity.data.counter > 0)
        return false;
    }
    int num = References.Battle.player.handContainer.max - References.Battle.player.handContainer.Count;
    int count = References.Battle.player.drawContainer.Count;
    for (int index1 = 0; index1 < num; ++index1)
    {
      int index2 = count - 1 - index1;
      if (index2 >= 0 && References.Battle.player.drawContainer[index2].data.counter > 0)
        return false;
    }
    this.redrawTutorial.Show();
    PromptSystem.Prompt.SetEmotePosition(Prompt.Emote.Position.Above, 1.5f, forceFlip: 1f);
    return true;
  }

  private bool CheckMoveTutorial()
  {
    if (this.moveTutorial.Check())
    {
      bool flag = false;
      foreach (Entity entity in Battle.GetCardsOnBoard(References.Battle.player))
      {
        if (entity.statusEffects.All<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.name != "Unmovable")))
        {
          flag = true;
          break;
        }
      }
      if (flag)
      {
        this.moveTutorial.Show();
        return true;
      }
    }
    return false;
  }

  private void Save()
  {
    foreach (DynamicTutorialSystem.Tutorial tutorial in this.tutorials)
      tutorial.Save();
  }

  [Serializable]
  private class Tutorial
  {
    public bool onlyShowOnce;
    public int turnsRequired;
    public int resetOffset = -50;
    public string saveString;
    public LocalizedString stringRef;
    public Prompt.Anchor promptAnchor;
    public Vector2 promptPosition;
    public float promptWidth;
    public Prompt.Emote.Type promptEmote;
    public int flipEmote = 1;

    private int current { get; set; }

    private bool currentBool { get; set; }

    public bool shown { get; private set; }

    public bool actionDoneThisTurn { get; set; }

    public void ResetCount()
    {
      this.current = this.resetOffset;
      if (!this.shown)
        return;
      this.Hide();
    }

    public void Load()
    {
      if (this.onlyShowOnce)
        return;
      this.current = SaveSystem.LoadProgressData<int>(this.saveString, 0);
    }

    public void Save()
    {
      if (this.onlyShowOnce)
        return;
      SaveSystem.SaveProgressData<int>(this.saveString, this.current);
    }

    public void CheckIncreaseCount()
    {
      if (this.onlyShowOnce)
        return;
      if (!this.actionDoneThisTurn)
        ++this.current;
      this.actionDoneThisTurn = false;
    }

    public bool Check() => this.current >= this.turnsRequired;

    public void Show(params object[] args)
    {
      this.shown = true;
      PromptSystem.Create(this.promptAnchor, this.promptPosition, this.promptWidth, this.promptEmote);
      PromptSystem.Prompt.SetEmotePosition(Prompt.Emote.Position.Above, forceFlip: (float) this.flipEmote);
      if (args.Length != 0)
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(this.stringRef.GetLocalizedString(), args)));
      else
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => this.stringRef.GetLocalizedString()));
      this.current = 0;
    }

    public void Hide()
    {
      this.shown = false;
      PromptSystem.Hide();
    }
  }
}
