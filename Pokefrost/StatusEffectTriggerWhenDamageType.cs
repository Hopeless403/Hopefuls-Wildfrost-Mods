// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectTriggerWhenDamageType
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectTriggerWhenDamageType : StatusEffectData
  {
    private bool isAlreadyOnBoard;
    public string triggerdamagetype;

    public override bool HasPostHitRoutine => true;

    public override object GetMidBattleData() => (object) Battle.IsOnBoard(this.target);

    public override void RestoreMidBattleData(object data)
    {
      if (!(data is bool flag))
        return;
      this.isAlreadyOnBoard = flag && Battle.IsOnBoard(this.target);
    }

    public override void Init()
    {
      this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Enable);
    }

    public override bool RunPostHitEvent(Hit hit) => Battle.IsOnBoard(this.target);

    private IEnumerator Enable(Hit hit)
    {
      Debug.Log((object) ("[Pokefrost] Damage type is " + hit.damageType.ToString()));
      if (hit.damageType == this.triggerdamagetype)
      {
        yield return (object) Sequences.Wait(0.2f);
        yield return (object) this.Activate();
      }
    }

    private IEnumerator Activate()
    {
      if (!this.target.silenced)
      {
        yield return (object) Sequences.Wait(0.1f);
        CurveAnimator curveAnimator = this.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num = (double) curveAnimator.Ping();
        }
        yield return (object) Sequences.Wait(0.3f);
        ActionQueue.Stack((PlayAction) new ActionTrigger(this.target, (Entity) null), true);
      }
    }
  }
}
