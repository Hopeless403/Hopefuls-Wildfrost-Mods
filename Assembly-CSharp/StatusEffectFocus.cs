// Decompiled with JetBrains decompiler
// Type: StatusEffectFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Focus", fileName = "Focus")]
public class StatusEffectFocus : StatusEffectData
{
  protected override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.ApplyStatus);

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply) => (bool) (Object) apply.effectData && apply.count > 0 && apply.effectData.type == this.type && (Object) apply.target != (Object) this.target;

  private IEnumerator ApplyStatus(StatusEffectApply apply)
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
