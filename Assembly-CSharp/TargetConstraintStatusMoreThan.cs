// Decompiled with JetBrains decompiler
// Type: TargetConstraintStatusMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Status More Than", menuName = "Target Constraints/Status More Than")]
public class TargetConstraintStatusMoreThan : TargetConstraint
{
  [SerializeField]
  private StatusEffectData status;
  [SerializeField]
  private int amount;

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
