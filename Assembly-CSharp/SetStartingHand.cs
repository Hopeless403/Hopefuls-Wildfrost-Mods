// Decompiled with JetBrains decompiler
// Type: SetStartingHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SetStartingHand : MonoBehaviour
{
  [SerializeField]
  private CardData[] startingHand;

  private void OnEnable() => global::Events.OnBattleStart += new UnityAction(this.BattleStart);

  private void OnDisable() => global::Events.OnBattleStart -= new UnityAction(this.BattleStart);

  private void BattleStart() => References.Player.OrderNextCards(((IEnumerable<CardData>) this.startingHand).Select<CardData, string>((Func<CardData, string>) (a => a.name)).ToArray<string>());
}
