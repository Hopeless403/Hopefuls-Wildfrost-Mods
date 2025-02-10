// Decompiled with JetBrains decompiler
// Type: StatusEffectFrost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Frost", fileName = "Frost")]
public class StatusEffectFrost : StatusEffectData
{
  public int toClear;
  public int current;
  public int addedThisTurn;

  public override void Init()
  {
    this.OnActionPerformed += new StatusEffectData.EffectActionPerformedHandler(this.ActionPerformed);
  }

  public override bool RunPreTriggerEvent(Trigger trigger)
  {
    if ((Object) trigger.entity == (Object) this.target)
      this.addedThisTurn = 0;
    return false;
  }

  public override bool RunStackEvent(int stacks)
  {
    this.current += stacks;
    this.target.tempDamage -= stacks;
    this.addedThisTurn += stacks;
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (this.toClear == 0 && (Object) entity == (Object) this.target && this.count > 0 && targets != null && targets.Length > 0)
      this.toClear = this.current - this.addedThisTurn;
    return false;
  }

  public override bool RunActionPerformedEvent(PlayAction action)
  {
    return this.toClear > 0 && ActionQueue.Empty;
  }

  public IEnumerator ActionPerformed(PlayAction action)
  {
    yield return (object) this.Clear(this.toClear);
    this.toClear = 0;
  }

  public IEnumerator Clear(int amount)
  {
    StatusEffectFrost status = this;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
    {
      status.current -= amount;
      status.target.tempDamage += amount;
      yield return (object) status.CountDown(status.target, amount);
    }
  }

  public override bool RunEndEvent()
  {
    this.target.tempDamage += this.current;
    return false;
  }
}
