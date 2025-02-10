// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyHealed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Healed", fileName = "Apply X When Ally Is Healed")]
public class StatusEffectApplyXWhenAllyHealed : StatusEffectApplyX
{
  protected override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    this.OnApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.CheckStatus);
  }

  public override bool RunPostHitEvent(Hit hit) => this.target.enabled && (Object) hit.target != (Object) this.target && (Object) hit.target.owner == (Object) this.target.owner && hit.damage < 0 && Battle.IsOnBoard(this.target);

  private IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit), -hit.damage);

  public override bool RunApplyStatusEvent(StatusEffectApply apply) => this.target.enabled && (Object) apply.target != (Object) this.target && (Object) apply.target.owner == (Object) this.target.owner && apply.effectData.type == "max health up" && Battle.IsOnBoard(this.target) && Battle.IsOnBoard(apply.target);

  private IEnumerator CheckStatus(StatusEffectApply apply) => this.Run(this.GetTargets(targets: new Entity[1]
  {
    apply.target
  }), apply.count);
}
