// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Applied To", fileName = "Apply X When Y Applied To")]
public class StatusEffectApplyXWhenYAppliedTo : StatusEffectApplyX
{
  [SerializeField]
  public bool instead;
  public bool whenAnyApplied;
  [HideIf("whenAnyApplied")]
  public string[] whenAppliedTypes = new string[1]{ "snow" };
  [SerializeField]
  public StatusEffectApplyX.ApplyToFlags whenAppliedToFlags;
  [SerializeField]
  public bool mustReachAmount;
  [Header("Adjust Amount Applied")]
  [SerializeField]
  public bool adjustAmount;
  [SerializeField]
  [ShowIf("adjustAmount")]
  public int addAmount;
  [SerializeField]
  [ShowIf("adjustAmount")]
  public float multiplyAmount = 1f;

  public override void Init()
  {
    this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Run);
  }

  public bool CheckType(StatusEffectData effectData)
  {
    if (!effectData.isStatus)
      return false;
    return this.whenAnyApplied || this.whenAppliedTypes.Contains<string>(effectData.type);
  }

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    if ((this.adjustAmount || this.instead) && this.target.enabled && !this.TargetSilenced() && (this.target.alive || !this.targetMustBeAlive) && (bool) (Object) apply.effectData && apply.count > 0 && this.CheckType(apply.effectData) && this.CheckTarget(apply.target))
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

  public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    return this.target.enabled && !this.TargetSilenced() && (bool) (Object) apply.effectData && apply.count > 0 && this.CheckType(apply.effectData) && this.CheckTarget(apply.target) && this.CheckAmount(apply);
  }

  public IEnumerator Run(StatusEffectApply apply) => this.Run(this.GetTargets(), apply.count);

  public bool CheckFlag(StatusEffectApplyX.ApplyToFlags whenAppliedTo)
  {
    return (this.whenAppliedToFlags & whenAppliedTo) != 0;
  }

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
    return (bool) (Object) status && status.count >= this.GetAmount();
  }
}
