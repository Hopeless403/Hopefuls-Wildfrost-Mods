﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectSpikes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Spikes", fileName = "Spikes")]
public class StatusEffectSpikes : StatusEffectData
{
  protected override void Init() => this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);

  public override bool RunPostHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.canRetaliate && hit.Offensive && hit.BasicHit && (Object) hit.attacker != (Object) this.target;

  private IEnumerator Check(Hit hit)
  {
    StatusEffectSpikes statusEffectSpikes = this;
    if ((bool) (Object) hit.attacker && hit.attacker.canBeHit)
      yield return (object) new Hit(statusEffectSpikes.target, hit.attacker, statusEffectSpikes.count)
      {
        canRetaliate = false,
        damageType = "spikes"
      }.Process();
  }
}
