// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeTargetMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Change Target Mode", fileName = "Change Target Mode")]
public class StatusEffectChangeTargetMode : StatusEffectData
{
  [SerializeField]
  public TargetMode targetMode;
  public TargetMode pre;

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
