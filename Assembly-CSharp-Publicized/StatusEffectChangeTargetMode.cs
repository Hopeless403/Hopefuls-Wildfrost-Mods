// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeTargetMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
