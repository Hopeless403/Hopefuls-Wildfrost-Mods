// Decompiled with JetBrains decompiler
// Type: NegativeCharmAfterBossModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
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
