// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedToAlly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To Ally", fileName = "Apply X When Y Applied To Ally")]
public class StatusEffectApplyXWhenYAppliedToAlly : StatusEffectApplyX
{
  public string whenAppliedType = "snow";

  public override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Check);

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply) => this.target.enabled && (Object) apply.target.owner == (Object) this.target.owner && (Object) apply.effectData != (Object) null && apply.count > 0 && apply.effectData.type == this.whenAppliedType;

  public IEnumerator Check(StatusEffectApply apply) => this.Run(this.GetTargets());
}
