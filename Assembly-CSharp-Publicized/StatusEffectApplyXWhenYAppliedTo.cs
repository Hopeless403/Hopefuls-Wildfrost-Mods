// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To", fileName = "Apply X When Y Applied To")]
public class StatusEffectApplyXWhenYAppliedTo : StatusEffectApplyX
{
  [SerializeField]
  public bool instead;
  public string whenAppliedType = "snow";
  [SerializeField]
  public StatusEffectApplyX.ApplyToFlags whenAppliedToFlags;
  [SerializeField]
  public bool mustReachAmount;
  [SerializeField]
  [ShowIf("mustReachAmount")]
  public int amountRequired;
  [Header("Adjust Amount Applied")]
  [SerializeField]
  public bool adjustAmount;
  [SerializeField]
  [ShowIf("adjustAmount")]
  public int addAmount;
  [SerializeField]
  [ShowIf("adjustAmount")]
  public float multiplyAmount = 1f;

  public override void Init() => this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Run);

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

  public IEnumerator Run(StatusEffectApply apply) => this.Run(this.GetTargets(), apply.count);

  public bool CheckFlag(StatusEffectApplyX.ApplyToFlags whenAppliedTo) => (this.whenAppliedToFlags & whenAppliedTo) != 0;

  public bool CheckTarget(Entity entity)
  {
    if (!Battle.IsOnBoard(this.target))
      return false;
    if ((Object) entity == (Object) this.target)
      return this.CheckFlag(StatusEffectApplyX.ApplyToFlags.Self);
    if ((Object) entity.owner == (Object) this.target.owner)
      return this.CheckFlag(StatusEffectApplyX.ApplyToFlags.Allies);
    return (Object) entity.owner != (Object) this.target.owner && this.CheckFlag(StatusEffectApplyX.ApplyToFlags.Enemies);
  }

  public bool CheckAmount(StatusEffectApply apply)
  {
    if (!this.mustReachAmount)
      return true;
    StatusEffectData status = apply.target.FindStatus(apply.effectData.type);
    return (Object) status != (Object) null && status.count >= this.amountRequired;
  }
}
