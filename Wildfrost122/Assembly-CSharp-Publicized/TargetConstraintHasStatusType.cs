// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Status Type", menuName = "Target Constraints/Has Status Type")]
public class TargetConstraintHasStatusType : TargetConstraint
{
  [SerializeField]
  public string statusType;

  public override bool Check(Entity target)
  {
    return !(bool) (Object) target.FindStatus(this.statusType) ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      if (startWithEffect.data.type == this.statusType)
        return !this.not;
    }
    return this.not;
  }
}
