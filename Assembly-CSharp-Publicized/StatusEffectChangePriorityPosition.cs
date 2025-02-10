// Decompiled with JetBrains decompiler
// Type: StatusEffectChangePriorityPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Change Priority Position", fileName = "Change Priority Position")]
public class StatusEffectChangePriorityPosition : StatusEffectData
{
  [Header("-1 = Backline, 2 = Frontline")]
  [SerializeField]
  public int positionPriorityChange = -1;
  public int pre;

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
