// Decompiled with JetBrains decompiler
// Type: StatusEffectDemonize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Demonize", fileName = "Demonize")]
public class StatusEffectDemonize : StatusEffectData
{
  protected override void Init() => this.OnHit += new StatusEffectData.EffectHitEventHandler(this.DemonizeHit);

  public override bool RunHitEvent(Hit hit) => hit.Offensive && this.count > 0 && hit.damage > 0 && (Object) hit.target == (Object) this.target;

  private IEnumerator DemonizeHit(Hit hit)
  {
    hit.damage = Mathf.RoundToInt((float) hit.damage * 2f);
    ActionSequence action = new ActionSequence(this.CountDown());
    action.fixedPosition = true;
    action.note = "Count Down Demonize";
    ActionQueue.Stack((PlayAction) action);
    yield break;
  }

  private IEnumerator CountDown()
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
