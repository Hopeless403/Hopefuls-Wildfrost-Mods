// Decompiled with JetBrains decompiler
// Type: PlayCrownCardsFirstSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

public class PlayCrownCardsFirstSystem : GameSystem
{
  private bool crownPhase;

  private void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.BattleTurnEnd);
  }

  private void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.BattleTurnEnd);
  }

  private void BattleStart() => this.crownPhase = true;

  private void CheckAction(ref PlayAction action, ref bool allow)
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

  private void BattleTurnEnd(int turnNumber)
  {
    this.crownPhase = false;
    this.enabled = false;
  }
}
