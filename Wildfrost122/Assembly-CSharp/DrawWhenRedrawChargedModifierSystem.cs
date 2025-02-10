// Decompiled with JetBrains decompiler
// Type: DrawWhenRedrawChargedModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DrawWhenRedrawChargedModifierSystem : GameSystem
{
  private const int drawAmount = 1;
  private RedrawBellSystem _redrawBellSystem;
  private bool drawOnTurnEnd;

  private RedrawBellSystem redrawBellSystem
  {
    get
    {
      return this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());
    }
  }

  private void OnEnable()
  {
    global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.BattleTurnEnd);
  }

  private void OnDisable()
  {
    global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.BattleTurnEnd);
  }

  private void BattleTurnStart(int turn)
  {
    if (!this.redrawBellSystem.IsCharged || Battle.instance.ended)
      return;
    this.drawOnTurnEnd = true;
  }

  private void BattleTurnEnd(int turn)
  {
    if (!this.drawOnTurnEnd || Battle.instance.ended)
      return;
    this.drawOnTurnEnd = false;
    ActionQueue.Stack((PlayAction) new ActionDraw(References.Player));
  }
}
