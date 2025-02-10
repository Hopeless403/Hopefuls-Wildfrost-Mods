// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectResist
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectResist : StatusEffectData
  {
    public override void Init()
    {
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    }

    public override bool RunHitEvent(Hit hit)
    {
      return (Object) hit.target == (Object) this.target && hit.damage > 0;
    }

    public IEnumerator Check(Hit hit)
    {
      for (int countflag = 0; hit.damage > 0 && countflag < this.GetAmount(); ++countflag)
      {
        --hit.damage;
        ++hit.damageBlocked;
      }
      this.target.PromptUpdate();
      yield return (object) true;
    }
  }
}
