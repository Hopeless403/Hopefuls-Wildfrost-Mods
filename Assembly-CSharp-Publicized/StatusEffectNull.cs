// Decompiled with JetBrains decompiler
// Type: StatusEffectNull
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Null", fileName = "Null")]
public class StatusEffectNull : StatusEffectData
{
  public bool primed;

  public override void Init() => this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.TurnEnd);

  public override bool RunBeginEvent()
  {
    ++this.target.silenceCount;
    return false;
  }

  public override bool RunEndEvent()
  {
    --this.target.silenceCount;
    return false;
  }

  public override bool RunTurnStartEvent(Entity entity)
  {
    if (!this.primed && (Object) entity == (Object) this.target)
      this.primed = true;
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity) => (Object) entity == (Object) this.target && this.primed;

  public IEnumerator TurnEnd(Entity entity)
  {
    StatusEffectNull status = this;
    int amount = 1;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(entity, amount);
  }
}
