// Decompiled with JetBrains decompiler
// Type: StatusEffectChangePriorityPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Change Priority Position", fileName = "Change Priority Position")]
public class StatusEffectChangePriorityPosition : StatusEffectData
{
  [Header("-1 = Backline, 2 = Frontline")]
  [SerializeField]
  private int positionPriorityChange = -1;
  private int pre;

  public override bool RunBeginEvent()
  {
    this.pre = this.target.positionPriority;
    if (!this.target.silenced)
      this.target.positionPriority = this.positionPriorityChange;
    return false;
  }

  public override bool RunEndEvent()
  {
    this.target.positionPriority = this.pre;
    return false;
  }

  public override bool RunEffectBonusChangedEvent()
  {
    this.RunEndEvent();
    this.RunBeginEvent();
    return false;
  }
}
