// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectJolted
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectJolted : StatusEffectData
  {
    public override void Init()
    {
      this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      return (Object) entity == (Object) this.target;
    }

    public IEnumerator Check(Entity entity, Entity[] targets)
    {
      Hit hit2 = new Hit(entity, entity, this.count)
      {
        canRetaliate = false,
        damageType = "jolt"
      };
      Pokefrost.Pokefrost.fx.TryPlayEffect("jolt", this.target.transform.position, 0.5f * this.target.transform.lossyScale);
      Pokefrost.Pokefrost.fx.TryPlaySound("jolt");
      double num = (double) this.target.curveAnimator.Ping();
      yield return (object) new WaitForSeconds(0.25f);
      yield return (object) hit2.Process();
    }
  }
}
