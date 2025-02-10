// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectOnTurnApplyXIfCondition
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectOnTurnApplyXIfCondition : StatusEffectApplyX
  {
    public TargetConstraint condition;
    public bool onTarget = false;
    public StatusEffectData onSuccess;
    public bool applyToTargetOnSuccess = false;
    public StatusEffectData onFailure;
    public bool applyToTargetOnFailure = false;

    public override void Init()
    {
      this.effectToApply = this.onSuccess;
      this.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
      this.PostAttack += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
    }

    public override bool RunPostAttackEvent(Hit hit) => this.target.enabled && (Object) hit.attacker == (Object) this.target && this.target.alive && Battle.IsOnBoard(this.target);

    public IEnumerator CheckHit(Hit hit)
    {
      StatusEffectData initialEffect = this.effectToApply;
      bool isSuccess = this.condition.Check(this.onTarget ? hit.target : this.target);
      this.effectToApply = isSuccess ? this.onSuccess : this.onFailure;
      bool applyToTarg = isSuccess ? this.applyToTargetOnSuccess : this.applyToTargetOnFailure;
      yield return (object) this.Run(new List<Entity>()
      {
        applyToTarg ? hit.target : this.target
      });
      this.effectToApply = initialEffect;
    }
  }
}
