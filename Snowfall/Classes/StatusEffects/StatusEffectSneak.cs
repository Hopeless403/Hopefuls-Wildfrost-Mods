// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectSneak
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Collections;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectSneak : StatusEffectData
  {
    private bool couldRetaliate = false;

    public override void Init() => this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);

    public override bool RunPreAttackEvent(Hit hit)
    {
      if (hit == null || !((UnityEngine.Object) hit.attacker == (UnityEngine.Object) this.target) || hit.target == null)
        return false;
      this.couldRetaliate = hit.canRetaliate;
      hit.canRetaliate = false;
      return true;
    }

    public override bool RunPostHitEvent(Hit hit) => hit != null && (UnityEngine.Object) hit.attacker == (UnityEngine.Object) this.target && !hit.canRetaliate && this.couldRetaliate && hit.target != null;

    private IEnumerator Check(Hit hit)
    {
      StatusEffectData statusEffectData = hit.target.statusEffects.Find((Predicate<StatusEffectData>) (se => se is StatusEffectSpikes));
      StatusEffectSpikes statusEffectSpikes;
      int num;
      if (statusEffectData != null && !hit.canRetaliate && this.couldRetaliate)
      {
        statusEffectSpikes = statusEffectData as StatusEffectSpikes;
        num = statusEffectSpikes != null ? 1 : 0;
      }
      else
        num = 0;
      return num != 0 ? statusEffectSpikes.Check(hit) : (IEnumerator) null;
    }
  }
}
