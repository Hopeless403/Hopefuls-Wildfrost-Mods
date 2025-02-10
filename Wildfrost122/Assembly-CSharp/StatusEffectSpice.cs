// Decompiled with JetBrains decompiler
// Type: StatusEffectSpice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Spice", fileName = "Spice")]
public class StatusEffectSpice : StatusEffectData
{
  private bool cardPlayed;
  private int current;
  private int amountToClear;

  protected override void Init()
  {
    this.OnActionPerformed += new StatusEffectData.EffectActionPerformedHandler(this.ActionPerformed);
  }

  public override bool RunStackEvent(int stacks)
  {
    this.current += stacks;
    this.target.tempDamage += stacks;
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!this.cardPlayed && (Object) entity == (Object) this.target && this.count > 0 && targets != null && targets.Length != 0)
    {
      this.cardPlayed = true;
      this.amountToClear = this.current;
    }
    return false;
  }

  public override bool RunActionPerformedEvent(PlayAction action)
  {
    return this.cardPlayed && ActionQueue.Empty;
  }

  private IEnumerator ActionPerformed(PlayAction action)
  {
    this.cardPlayed = false;
    yield return (object) this.Clear(this.amountToClear);
  }

  private IEnumerator Clear(int amount)
  {
    StatusEffectSpice status = this;
    int amount1 = amount;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount1);
    if (amount1 != 0)
    {
      status.current -= amount1;
      status.target.tempDamage -= amount1;
      yield return (object) status.CountDown(status.target, amount1);
    }
  }

  public override bool RunEndEvent()
  {
    this.target.tempDamage -= this.current;
    return false;
  }
}
