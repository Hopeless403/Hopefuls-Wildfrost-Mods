// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyHealed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Healed", fileName = "Apply X When Ally Is Healed")]
public class StatusEffectApplyXWhenAllyHealed : StatusEffectApplyX
{
  public override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    this.OnApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.CheckStatus);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && (Object) hit.target != (Object) this.target && (Object) hit.target.owner == (Object) this.target.owner && hit.damage < 0 && Battle.IsOnBoard(this.target);
  }

  public IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit), -hit.damage);

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    return this.target.enabled && (Object) apply.target != (Object) this.target && (Object) apply.target.owner == (Object) this.target.owner && apply.effectData.type == "max health up" && Battle.IsOnBoard(this.target) && Battle.IsOnBoard(apply.target);
  }

  public IEnumerator CheckStatus(StatusEffectApply apply)
  {
    return this.Run(this.GetTargets(targets: new Entity[1]
    {
      apply.target
    }), apply.count);
  }
}
