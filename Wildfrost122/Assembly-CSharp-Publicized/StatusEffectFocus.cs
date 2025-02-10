// Decompiled with JetBrains decompiler
// Type: StatusEffectFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Focus", fileName = "Focus")]
public class StatusEffectFocus : StatusEffectData
{
  public override void Init()
  {
    this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.ApplyStatus);
  }

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    return (bool) (Object) apply.effectData && apply.count > 0 && apply.effectData.type == this.type && (Object) apply.target != (Object) this.target;
  }

  public IEnumerator ApplyStatus(StatusEffectApply apply)
  {
    StatusEffectFocus status = this;
    int count = status.count;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref count);
    if (count != 0)
      yield return (object) status.CountDown(status.target, count);
  }

  public override bool RunPreTriggerEvent(Trigger trigger)
  {
    if (!trigger.nullified && trigger.countsAsTrigger && trigger.entity.owner.team != this.target.owner.team && trigger.type == "basic" && Battle.IsOnBoard(trigger.entity))
      trigger.targets = trigger.entity.targetMode.GetTargets(trigger.entity, this.target, this.target.containers.RandomItem<CardContainer>());
    return false;
  }
}
