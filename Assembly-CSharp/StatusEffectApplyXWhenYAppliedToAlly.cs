// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedToAlly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To Ally", fileName = "Apply X When Y Applied To Ally")]
public class StatusEffectApplyXWhenYAppliedToAlly : StatusEffectApplyX
{
  public string whenAppliedType = "snow";

  protected override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Check);

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply) => this.target.enabled && (Object) apply.target.owner == (Object) this.target.owner && (Object) apply.effectData != (Object) null && apply.count > 0 && apply.effectData.type == this.whenAppliedType;

  private IEnumerator Check(StatusEffectApply apply) => this.Run(this.GetTargets());
}
