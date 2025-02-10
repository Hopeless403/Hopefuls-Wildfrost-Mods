// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerWhenStatusApplied
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Reactions/Trigger When Status Applied", fileName = "Trigger When Status Applied")]
public class StatusEffectTriggerWhenStatusApplied : StatusEffectReaction
{
  [SerializeField]
  public StatusEffectData targetStatus;
  [SerializeField]
  public bool friendlyFire = true;
  [SerializeField]
  public bool selfFire = true;
  [SerializeField]
  public StatusEffectTriggerWhenStatusApplied.TriggerType triggerType;
  public int busy;
  public int triggerIndex;

  public override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Run);

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply) => this.target.enabled && Battle.IsOnBoard(this.target) && this.Check(apply) && this.CanTrigger();

  public IEnumerator Run(StatusEffectApply apply)
  {
    StatusEffectTriggerWhenStatusApplied whenStatusApplied = this;
    int i = whenStatusApplied.triggerIndex + whenStatusApplied.busy;
    ++whenStatusApplied.busy;
    yield return (object) new WaitUntil((Func<bool>) (() => this.triggerIndex == i));
    switch (whenStatusApplied.triggerType)
    {
      case StatusEffectTriggerWhenStatusApplied.TriggerType.Normal:
        ActionQueue.Stack((PlayAction) new ActionTrigger(whenStatusApplied.target, apply.applier), true);
        break;
      case StatusEffectTriggerWhenStatusApplied.TriggerType.Target:
        if ((bool) (UnityEngine.Object) apply.target && apply.target.alive)
        {
          CardContainer targetRow = Trigger.GetTargetRow(whenStatusApplied.target, apply.target);
          ActionQueue.Stack((PlayAction) new ActionTriggerSubsequent(whenStatusApplied.target, apply.applier, apply.target, targetRow), true);
          break;
        }
        break;
      case StatusEffectTriggerWhenStatusApplied.TriggerType.Applier:
        if ((bool) (UnityEngine.Object) apply.applier && apply.applier.alive)
        {
          CardContainer targetRow = Trigger.GetTargetRow(whenStatusApplied.target, apply.target);
          ActionQueue.Stack((PlayAction) new ActionTriggerSubsequent(whenStatusApplied.target, apply.applier, apply.applier, targetRow), true);
          break;
        }
        break;
    }
    --whenStatusApplied.busy;
    ++whenStatusApplied.triggerIndex;
  }

  public bool Check(StatusEffectApply apply) => (this.friendlyFire || !((UnityEngine.Object) apply.applier?.owner == (UnityEngine.Object) this.target.owner)) && (this.selfFire || !((UnityEngine.Object) apply.applier == (UnityEngine.Object) this.target)) && apply.effectData?.type == this.targetStatus?.type && this.CheckDuplicate(apply.applier) && this.CheckDuplicate(apply.applier.triggeredBy);

  public bool CheckDuplicate(Entity entity)
  {
    if (!(bool) (UnityEngine.Object) entity)
      return true;
    foreach (UnityEngine.Object statusEffect in entity.statusEffects)
    {
      if (statusEffect.name == this.name)
        return false;
    }
    return true;
  }

  public enum TriggerType
  {
    Normal,
    Target,
    Applier,
  }
}
