// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeTargetMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Change Target Mode", fileName = "Change Target Mode")]
public class StatusEffectChangeTargetMode : StatusEffectData
{
  [SerializeField]
  private TargetMode targetMode;
  private TargetMode pre;

  public override bool RunBeginEvent()
  {
    this.pre = this.target.targetMode;
    if (!this.target.silenced)
      this.target.targetMode = this.targetMode;
    return false;
  }

  public override bool RunEndEvent()
  {
    this.target.targetMode = this.pre;
    return false;
  }

  public override bool RunEffectBonusChangedEvent()
  {
    this.RunEndEvent();
    this.RunBeginEvent();
    return false;
  }
}
