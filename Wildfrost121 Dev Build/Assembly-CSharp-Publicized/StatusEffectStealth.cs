// Decompiled with JetBrains decompiler
// Type: StatusEffectStealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Stealth", fileName = "Stealth")]
public class StatusEffectStealth : StatusEffectData
{
  public bool cardPlayed;

  public override void Init()
  {
    this.OnActionPerformed += new StatusEffectData.EffectActionPerformedHandler(this.ActionPerformed);
  }

  public override bool RunBeginEvent()
  {
    ++this.target.cannotBeHitCount;
    return false;
  }

  public override bool RunEndEvent()
  {
    --this.target.cannotBeHitCount;
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!this.cardPlayed && (Object) entity == (Object) this.target && this.count > 0 && targets != null && targets.Length != 0)
      this.cardPlayed = true;
    return false;
  }

  public override bool RunActionPerformedEvent(PlayAction action)
  {
    return this.cardPlayed && ActionQueue.Empty;
  }

  public IEnumerator ActionPerformed(PlayAction action)
  {
    yield return (object) this.CountDown();
  }

  public IEnumerator CountDown()
  {
    StatusEffectStealth status = this;
    int amount = 1;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(status.target, amount);
  }
}
