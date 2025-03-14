﻿// Decompiled with JetBrains decompiler
// Type: PlayCrownCardsFirstSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class PlayCrownCardsFirstSystem : GameSystem
{
  public bool crownPhase;

  public void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.BattleTurnEnd);
  }

  public void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.BattleTurnEnd);
  }

  public void BattleStart() => this.crownPhase = true;

  public void CheckAction(ref PlayAction action, ref bool allow)
  {
    if (!this.crownPhase)
      return;
    switch (action)
    {
      case ActionMove actionMove:
        if (actionMove.entity.data.HasCrown || Battle.IsOnBoard(actionMove.entity) || !Battle.IsOnBoard(actionMove.toContainers))
          break;
        allow = false;
        if (!NoTargetTextSystem.Exists())
          break;
        this.StartCoroutine(NoTargetTextSystem.Run(actionMove.entity, NoTargetType.PlayCrownCardsFirst));
        break;
      case ActionTrigger actionTrigger:
        if (actionTrigger.entity.data.HasCrown)
          break;
        allow = false;
        if (!NoTargetTextSystem.Exists())
          break;
        this.StartCoroutine(NoTargetTextSystem.Run(actionTrigger.entity, NoTargetType.PlayCrownCardsFirst));
        break;
    }
  }

  public void BattleTurnEnd(int turnNumber)
  {
    this.crownPhase = false;
    this.enabled = false;
  }
}
