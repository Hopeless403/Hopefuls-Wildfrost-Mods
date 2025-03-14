﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedToSelf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To Self", fileName = "Apply X When Y Applied To Self")]
public class StatusEffectApplyXWhenYAppliedToSelf : StatusEffectApplyX
{
  public string whenAppliedType = "spice";

  public override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Check);

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply) => this.target.enabled && (Object) apply.target == (Object) this.target && (Object) apply.effectData != (Object) null && apply.count > 0 && apply.effectData.type == this.whenAppliedType;

  public IEnumerator Check(StatusEffectApply apply) => this.Run(this.GetTargets());
}
