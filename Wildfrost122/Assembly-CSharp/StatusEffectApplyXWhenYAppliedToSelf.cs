// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedToSelf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To Self", fileName = "Apply X When Y Applied To Self")]
public class StatusEffectApplyXWhenYAppliedToSelf : StatusEffectApplyX
{
  public string whenAppliedType = "spice";
  public string[] whenAppliedTypes = new string[1]
  {
    "spice"
  };

  protected override void Init()
  {
    this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Check);
  }

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    return this.target.enabled && (Object) apply.target == (Object) this.target && (bool) (Object) apply.effectData && apply.count > 0 && this.whenAppliedTypes.Contains<string>(apply.effectData.type);
  }

  private IEnumerator Check(StatusEffectApply apply) => this.Run(this.GetTargets());
}
