// Decompiled with JetBrains decompiler
// Type: NegativeCharmAfterBossModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class NegativeCharmAfterBossModifierSystem : GameSystem
{
  [SerializeField]
  private GainNegativeCharmSequence gainNegativeCharmSequencePrefab;

  private void OnEnable() => global::Events.OnBattleWin += new UnityAction(this.BattleWin);

  private void OnDisable() => global::Events.OnBattleWin -= new UnityAction(this.BattleWin);

  private void BattleWin()
  {
    if (!Campaign.FindCharacterNode(References.Player).type.isBoss)
      return;
    ActionQueue.Stack((PlayAction) new ActionSequence(this.GainCharmRoutine()));
  }

  private IEnumerator GainCharmRoutine()
  {
    GainNegativeCharmSequence sequence = Object.Instantiate<GainNegativeCharmSequence>(this.gainNegativeCharmSequencePrefab, References.Player.entity.display.transform);
    yield return (object) sequence.Run();
    sequence.gameObject.Destroy();
  }
}
