// Decompiled with JetBrains decompiler
// Type: TargetConstraintStatusMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Status More Than", menuName = "Target Constraints/Status More Than")]
public class TargetConstraintStatusMoreThan : TargetConstraint
{
  [SerializeField]
  public StatusEffectData status;
  [SerializeField]
  public int amount;

  public override bool Check(Entity target)
  {
    StatusEffectData status = target.FindStatus(this.status.type);
    return !(bool) (Object) status || status.count <= this.amount ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      if (startWithEffect.data.type == this.status.type && startWithEffect.count > this.amount)
        return !this.not;
    }
    return this.not;
  }
}
