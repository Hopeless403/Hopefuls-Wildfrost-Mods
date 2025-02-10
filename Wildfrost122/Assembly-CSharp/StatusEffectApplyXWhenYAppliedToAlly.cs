// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedToAlly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To Ally", fileName = "Apply X When Y Applied To Ally")]
public class StatusEffectApplyXWhenYAppliedToAlly : StatusEffectApplyX
{
  public string whenAppliedType = "snow";

  protected override void Init()
  {
    this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Check);
  }

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    return this.target.enabled && (Object) apply.target.owner == (Object) this.target.owner && (Object) apply.effectData != (Object) null && apply.count > 0 && apply.effectData.type == this.whenAppliedType;
  }

  private IEnumerator Check(StatusEffectApply apply) => this.Run(this.GetTargets());
}
