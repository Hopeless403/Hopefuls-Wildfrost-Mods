// Decompiled with JetBrains decompiler
// Type: StatusEffectAffectAllXApplied
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Affect All X Applied", fileName = "Affect All X Applied")]
public class StatusEffectAffectAllXApplied : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToAffect;
  [SerializeField]
  public bool setToSpecificValue;
  [SerializeField]
  [ShowIf("setToSpecificValue")]
  public int specificValue;
  [SerializeField]
  [HideIf("setToSpecificValue")]
  public int add;
  [SerializeField]
  [HideIf("setToSpecificValue")]
  public float multiplyBy = 2f;
  [SerializeField]
  public bool targetCanBeFriendly = true;
  [SerializeField]
  public bool targetCanBeEnemy = true;
  [SerializeField]
  public bool applierCanBeFriendly = true;
  [SerializeField]
  public bool applierCanBeEnemy = true;

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

  public bool CheckTeamOfTarget(Entity target)
  {
    if (this.targetCanBeFriendly && (Object) target.owner == (Object) this.target.owner)
      return true;
    return this.targetCanBeEnemy && (Object) target.owner != (Object) this.target.owner;
  }

  public bool CheckTeamOfApplier(Entity applier)
  {
    if (this.applierCanBeFriendly && (Object) applier.owner == (Object) this.target.owner)
      return true;
    return this.applierCanBeEnemy && (Object) applier.owner != (Object) this.target.owner;
  }
}
