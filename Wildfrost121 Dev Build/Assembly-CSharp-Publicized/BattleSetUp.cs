// Decompiled with JetBrains decompiler
// Type: BattleSetUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class BattleSetUp : SceneRoutine
{
  [SerializeField]
  [Required(null)]
  public Battle battle;
  [SerializeField]
  public Character enemy;
  [SerializeField]
  public CharacterDisplay enemyCharacterDisplay;
  [SerializeField]
  [Required(null)]
  public BoardDisplay board;
  [SerializeField]
  [Required(null)]
  public CardController cardController;
  [SerializeField]
  public TweenUI startTween;
  [Header("Background")]
  [SerializeField]
  public PrefabLoaderAsync backgroundLoader;
  public CharacterDisplay playerDisplay;

  public override IEnumerator Run()
  {
    Routine updateBackgroundRoutine = new Routine(this.UpdateBackground());
    Character player = References.Player;
    CampaignNode node = Campaign.FindCharacterNode(player);
    this.playerDisplay = (CharacterDisplay) player.entity.display;
    if ((bool) (UnityEngine.Object) this.playerDisplay)
    {
      Debug.Log((object) "BATTLE SET UP");
      this.battle.player = player;
      this.battle.enemy = this.enemy;
      this.board.player = player;
      this.board.enemy = this.enemy;
      this.cardController.owner = player;
      this.battle.rows[player] = new List<CardContainer>();
      this.battle.rows[this.enemy] = new List<CardContainer>();
      yield return (object) null;
      yield return (object) this.board.SetUp(node, this.cardController);
      player.handContainer.AssignController(this.cardController);
      player.handContainer.SetSize(player.data.handSize, player.handContainer.CardScale);
      player.discardContainer.AssignController(this.cardController);
      player.drawContainer.AssignController(this.cardController);
      this.enemyCharacterDisplay.Assign(this.enemy);
    }
    else
      Debug.LogError((object) string.Format("PLAYER [{0}] IS NOT ASSIGNED TO → CharacterDisplay", (object) player));
    yield return (object) new WaitUntil((Func<bool>) (() => !updateBackgroundRoutine.IsRunning));
  }

  public IEnumerator StartAnimation()
  {
    if ((bool) (UnityEngine.Object) this.startTween)
      this.startTween.Fire();
    new Routine.Clump().Add(this.playerDisplay.handOverlay.Show());
    yield return (object) Sequences.Wait(0.1f);
  }

  public IEnumerator UpdateBackground()
  {
    if (Campaign.FindCharacterNode(References.Player).type is CampaignNodeTypeBattle type && type.overrideBackground)
    {
      yield return (object) this.backgroundLoader.Load(type.background);
    }
    else
    {
      AreaData currentArea = References.GetCurrentArea();
      if ((bool) (UnityEngine.Object) currentArea)
        yield return (object) this.backgroundLoader.Load(currentArea.battleBackgroundPrefabRef);
    }
  }

  [Serializable]
  public struct Background
  {
    public string key;
    public GameObject prefab;
  }
}
