// Decompiled with JetBrains decompiler
// Type: SetStartingHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SetStartingHand : MonoBehaviour
{
  [SerializeField]
  public CardData[] startingHand;

  public void OnEnable() => global::Events.OnBattleStart += new UnityAction(this.BattleStart);

  public void OnDisable() => global::Events.OnBattleStart -= new UnityAction(this.BattleStart);

  public void BattleStart() => References.Player.OrderNextCards(((IEnumerable<CardData>) this.startingHand).Select<CardData, string>((Func<CardData, string>) (a => a.name)).ToArray<string>());
}
