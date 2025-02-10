// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAnyoneTakesDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Anyone Takes Damage", fileName = "Apply X When Anyone Takes Damage")]
public class StatusEffectApplyXWhenAnyoneTakesDamage : StatusEffectApplyX
{
  [SerializeField]
  public string targetDamageType = "basic";

  public override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && this.target.alive && hit.Offensive && hit.damageType == this.targetDamageType && Battle.IsOnBoard(this.target);
  }

  public IEnumerator CheckHit(Hit hit) => this.Run(this.GetTargets(hit));
}
