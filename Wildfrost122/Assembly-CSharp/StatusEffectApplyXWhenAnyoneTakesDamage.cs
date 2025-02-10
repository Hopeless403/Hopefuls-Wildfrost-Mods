// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAnyoneTakesDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Anyone Takes Damage", fileName = "Apply X When Anyone Takes Damage")]
public class StatusEffectApplyXWhenAnyoneTakesDamage : StatusEffectApplyX
{
  [SerializeField]
  private string targetDamageType = "basic";

  protected override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && this.target.alive && hit.Offensive && hit.damageType == this.targetDamageType && Battle.IsOnBoard(this.target);
  }

  private IEnumerator CheckHit(Hit hit) => this.Run(this.GetTargets(hit));
}
