// Decompiled with JetBrains decompiler
// Type: SetStartingHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SetStartingHand : MonoBehaviour
{
  [SerializeField]
  private CardData[] startingHand;

  private void OnEnable() => global::Events.OnBattleStart += new UnityAction(this.BattleStart);

  private void OnDisable() => global::Events.OnBattleStart -= new UnityAction(this.BattleStart);

  private void BattleStart()
  {
    References.Player.OrderNextCards(((IEnumerable<CardData>) this.startingHand).Select<CardData, string>((Func<CardData, string>) (a => a.name)).ToArray<string>());
  }
}
