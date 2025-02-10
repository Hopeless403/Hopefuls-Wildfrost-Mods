// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantFullHeal
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantFullHeal : StatusEffectInstant
  {
    [SerializeField]
    public bool doPing = true;

    public override IEnumerator Process()
    {
      if (this.target.alive)
      {
        if (this.doPing)
        {
          CurveAnimator curveAnimator = this.target.curveAnimator;
          if (curveAnimator != null)
          {
            double num = (double) curveAnimator.Ping();
          }
        }
        Hit hit = new Hit(this.applier, this.target, -this.target.hp.max + this.target.hp.current);
        yield return (object) hit.Process();
        hit = (Hit) null;
      }
      yield return (object) base.Process();
    }
  }
}
