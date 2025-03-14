﻿// Decompiled with JetBrains decompiler
// Type: DrawWhenRedrawChargedModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DrawWhenRedrawChargedModifierSystem : GameSystem
{
  public const int drawAmount = 1;
  public RedrawBellSystem _redrawBellSystem;
  public bool drawOnTurnEnd;

  public RedrawBellSystem redrawBellSystem
  {
    get
    {
      return this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());
    }
  }

  public void OnEnable()
  {
    global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.BattleTurnEnd);
  }

  public void OnDisable()
  {
    global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.BattleTurnEnd);
  }

  public void BattleTurnStart(int turn)
  {
    if (!this.redrawBellSystem.IsCharged || Battle.instance.ended)
      return;
    this.drawOnTurnEnd = true;
  }

  public void BattleTurnEnd(int turn)
  {
    if (!this.drawOnTurnEnd || Battle.instance.ended)
      return;
    this.drawOnTurnEnd = false;
    ActionQueue.Stack((PlayAction) new ActionDraw(References.Player));
  }
}
