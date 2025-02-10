// Decompiled with JetBrains decompiler
// Type: StatusEffectDemonize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Demonize", fileName = "Demonize")]
public class StatusEffectDemonize : StatusEffectData
{
  public override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.DemonizeHit);
  }

  public override bool RunHitEvent(Hit hit)
  {
    return hit.Offensive && this.count > 0 && hit.damage > 0 && (Object) hit.target == (Object) this.target;
  }

  public IEnumerator DemonizeHit(Hit hit)
  {
    hit.damage = Mathf.RoundToInt((float) hit.damage * 2f);
    ActionSequence action = new ActionSequence(this.CountDown());
    action.fixedPosition = true;
    action.note = "Count Down Demonize";
    ActionQueue.Stack((PlayAction) action);
    yield break;
  }

  public IEnumerator CountDown()
  {
    StatusEffectDemonize status = this;
    if ((bool) (Object) status && (bool) (Object) status.target && status.target.alive)
    {
      int amount = 1;
      Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
      if (amount != 0)
        yield return (object) status.CountDown(status.target, amount);
    }
  }
}
