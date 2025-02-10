// Decompiled with JetBrains decompiler
// Type: StatusEffectAffectAllXApplied
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Affect All X Applied", fileName = "Affect All X Applied")]
public class StatusEffectAffectAllXApplied : StatusEffectData
{
  [SerializeField]
  private StatusEffectData effectToAffect;
  [SerializeField]
  private bool setToSpecificValue;
  [SerializeField]
  [ShowIf("setToSpecificValue")]
  private int specificValue;
  [SerializeField]
  [HideIf("setToSpecificValue")]
  private int add;
  [SerializeField]
  [HideIf("setToSpecificValue")]
  private float multiplyBy = 2f;
  [SerializeField]
  private bool targetCanBeFriendly = true;
  [SerializeField]
  private bool targetCanBeEnemy = true;
  [SerializeField]
  private bool applierCanBeFriendly = true;
  [SerializeField]
  private bool applierCanBeEnemy = true;

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    if ((Object) apply?.effectData != (Object) null && apply.effectData.type == this.effectToAffect.type && apply.count > 0 && this.CheckTeamOfTarget(apply.target) && this.CheckTeamOfApplier(apply.applier))
    {
      if (this.setToSpecificValue)
      {
        apply.count = this.specificValue;
      }
      else
      {
        apply.count += this.add * this.GetAmount();
        apply.count = Mathf.CeilToInt((float) apply.count * this.multiplyBy);
      }
    }
    return false;
  }

  private bool CheckTeamOfTarget(Entity target)
  {
    if (this.targetCanBeFriendly && (Object) target.owner == (Object) this.target.owner)
      return true;
    return this.targetCanBeEnemy && (Object) target.owner != (Object) this.target.owner;
  }

  private bool CheckTeamOfApplier(Entity applier)
  {
    if (this.applierCanBeFriendly && (Object) applier.owner == (Object) this.target.owner)
      return true;
    return this.applierCanBeEnemy && (Object) applier.owner != (Object) this.target.owner;
  }
}
