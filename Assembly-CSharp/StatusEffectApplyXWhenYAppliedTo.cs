// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To", fileName = "Apply X When Y Applied To")]
public class StatusEffectApplyXWhenYAppliedTo : StatusEffectApplyX
{
  [SerializeField]
  private bool instead;
  public string whenAppliedType = "snow";
  [SerializeField]
  private StatusEffectApplyX.ApplyToFlags whenAppliedToFlags;
  [SerializeField]
  private bool mustReachAmount;
  [SerializeField]
  [ShowIf("mustReachAmount")]
  private int amountRequired;
  [Header("Adjust Amount Applied")]
  [SerializeField]
  private bool adjustAmount;
  [SerializeField]
  [ShowIf("adjustAmount")]
  private int addAmount;
  [SerializeField]
  [ShowIf("adjustAmount")]
  private float multiplyAmount = 1f;

  protected override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Run);

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    if ((this.adjustAmount || this.instead) && this.target.enabled && (this.target.alive || !this.targetMustBeAlive) && (bool) (Object) apply.effectData && apply.count > 0 && apply.effectData.type == this.whenAppliedType && this.CheckTarget(apply.target))
    {
      if (this.instead)
        apply.effectData = this.effectToApply;
      if (this.adjustAmount)
      {
        apply.count += this.addAmount;
        apply.count = Mathf.RoundToInt((float) apply.count * this.multiplyAmount);
      }
    }
    return false;
  }

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply) => this.target.enabled && (bool) (Object) apply.effectData && apply.count > 0 && apply.effectData.type == this.whenAppliedType && this.CheckTarget(apply.target) && this.CheckAmount(apply);

  private IEnumerator Run(StatusEffectApply apply) => this.Run(this.GetTargets(), apply.count);

  private bool CheckFlag(StatusEffectApplyX.ApplyToFlags whenAppliedTo) => (this.whenAppliedToFlags & whenAppliedTo) != 0;

  private bool CheckTarget(Entity entity)
  {
    if (!Battle.IsOnBoard(this.target))
      return false;
    if ((Object) entity == (Object) this.target)
      return this.CheckFlag(StatusEffectApplyX.ApplyToFlags.Self);
    if ((Object) entity.owner == (Object) this.target.owner)
      return this.CheckFlag(StatusEffectApplyX.ApplyToFlags.Allies);
    return (Object) entity.owner != (Object) this.target.owner && this.CheckFlag(StatusEffectApplyX.ApplyToFlags.Enemies);
  }

  private bool CheckAmount(StatusEffectApply apply)
  {
    if (!this.mustReachAmount)
      return true;
    StatusEffectData status = apply.target.FindStatus(apply.effectData.type);
    return (Object) status != (Object) null && status.count >= this.amountRequired;
  }
}
