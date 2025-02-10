// Decompiled with JetBrains decompiler
// Type: StatusEffectSpikes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Spikes", fileName = "Spikes")]
public class StatusEffectSpikes : StatusEffectData
{
  public override void Init() => this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);

  public override bool RunPostHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.canRetaliate && hit.Offensive && hit.BasicHit && (Object) hit.attacker != (Object) this.target;

  public IEnumerator Check(Hit hit)
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
