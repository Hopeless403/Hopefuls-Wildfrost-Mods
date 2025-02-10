// Decompiled with JetBrains decompiler
// Type: NegativeCharmAfterBossModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class NegativeCharmAfterBossModifierSystem : GameSystem
{
  [SerializeField]
  public GainNegativeCharmSequence gainNegativeCharmSequencePrefab;

  public void OnEnable() => global::Events.OnBattleWin += new UnityAction(this.BattleWin);

  public void OnDisable() => global::Events.OnBattleWin -= new UnityAction(this.BattleWin);

  public void BattleWin()
  {
    if (!Campaign.FindCharacterNode(References.Player).type.isBoss)
      return;
    ActionQueue.Stack((PlayAction) new ActionSequence(this.GainCharmRoutine()));
  }

  public IEnumerator GainCharmRoutine()
  {
    GainNegativeCharmSequence sequence = Object.Instantiate<GainNegativeCharmSequence>(this.gainNegativeCharmSequencePrefab, References.Player.entity.display.transform);
    yield return (object) sequence.Run();
    sequence.gameObject.Destroy();
  }
}
