// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Has Status Type", menuName = "Target Constraints/Has Status Type")]
public class TargetConstraintHasStatusType : TargetConstraint
{
  [SerializeField]
  public string statusType;

  public override bool Check(Entity target) => !(bool) (Object) target.FindStatus(this.statusType) ? this.not : !this.not;

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
