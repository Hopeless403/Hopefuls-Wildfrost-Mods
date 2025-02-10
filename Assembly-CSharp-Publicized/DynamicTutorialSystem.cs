// Decompiled with JetBrains decompiler
// Type: DynamicTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class DynamicTutorialSystem : GameSystem
{
  [SerializeField]
  public DynamicTutorialSystem.Tutorial redrawTutorial;
  [SerializeField]
  public DynamicTutorialSystem.Tutorial moveTutorial;
  [SerializeField]
  public DynamicTutorialSystem.Tutorial recallTutorial;
  [SerializeField]
  public DynamicTutorialSystem.Tutorial aimlessTutorial;
  [SerializeField]
  public DynamicTutorialSystem.Tutorial reactionTutorial;
  public DynamicTutorialSystem.Tutorial[] tutorials;
  public bool aimlessTutorialDone;
  public bool reactionTutorialDone;
  public Entity aimlessEnemy;
  public Entity reactionEnemy;

  public void OnEnable()
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

  public void OnDisable()
  {
    global::Events.OnEntityPlace -= new UnityAction<Entity, CardContainer[], bool>(this.EntityPlace);
    global::Events.OnDiscard -= new UnityAction<Entity>(this.Discard);
    global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnBattleTurnStart -= new UnityAction<int>(this.TurnStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.TurnEnd);
    global::Events.OnCampaignSaved -= new UnityAction(this.Save);
  }

  public void EntityPlace(Entity entity, CardContainer[] slots, bool freeMove)
  {
    if (!freeMove || entity.owner.team != References.Player.team)
      return;
    this.moveTutorial.actionDoneThisTurn = true;
    this.moveTutorial.ResetCount();
  }

  public void Discard(Entity entity)
  {
    if (!entity.data.hasHealth)
      return;
    this.recallTutorial.actionDoneThisTurn = true;
    this.recallTutorial.ResetCount();
  }

  public void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    if (redrawBellSystem.IsCharged)
      return;
    this.redrawTutorial.actionDoneThisTurn = true;
    this.redrawTutorial.ResetCount();
  }

  public void TurnStart(int turnCount)
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

  public void TurnEnd(int turnCount)
  {
    foreach (DynamicTutorialSystem.Tutorial tutorial in this.tutorials)
      tutorial.CheckIncreaseCount();
    if (References.Battle.ended || this.CheckAimlessTutorial(turnCount) || this.CheckReactionTutorial(turnCount) || this.CheckMoveTutorial() || this.CheckRedrawTutorial())
      return;
    this.CheckRecallTutorial();
  }

  public bool CheckAimlessTutorial(int turnCount)
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

  public bool CheckReactionTutorial(int turnCount)
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

  public bool CheckRecallTutorial()
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

  public bool CheckRedrawTutorial()
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

  public bool CheckMoveTutorial()
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

  public void Save()
  {
    foreach (DynamicTutorialSystem.Tutorial tutorial in this.tutorials)
      tutorial.Save();
  }

  [Serializable]
  public class Tutorial
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
    [CompilerGenerated]
    public int \u003Ccurrent\u003Ek__BackingField;
    [CompilerGenerated]
    public bool \u003CcurrentBool\u003Ek__BackingField;
    [CompilerGenerated]
    public bool \u003Cshown\u003Ek__BackingField;
    [CompilerGenerated]
    public bool \u003CactionDoneThisTurn\u003Ek__BackingField;

    public int current
    {
      get => this.\u003Ccurrent\u003Ek__BackingField;
      set => this.\u003Ccurrent\u003Ek__BackingField = value;
    }

    public bool currentBool
    {
      get => this.\u003CcurrentBool\u003Ek__BackingField;
      set => this.\u003CcurrentBool\u003Ek__BackingField = value;
    }

    public bool shown
    {
      get => this.\u003Cshown\u003Ek__BackingField;
      set => this.\u003Cshown\u003Ek__BackingField = value;
    }

    public bool actionDoneThisTurn
    {
      get => this.\u003CactionDoneThisTurn\u003Ek__BackingField;
      set => this.\u003CactionDoneThisTurn\u003Ek__BackingField = value;
    }

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
