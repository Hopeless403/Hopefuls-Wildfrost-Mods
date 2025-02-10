// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Trait", menuName = "Target Constraints/Has Trait")]
public class TargetConstraintHasTrait : TargetConstraint
{
  [SerializeField]
  public TraitData trait;
  [SerializeField]
  public bool ignoreSilenced;

  public override bool Check(Entity target)
  {
    if (this.ignoreSilenced && target.silenced)
      return this.not;
    bool flag = false;
    foreach (Entity.TraitStacks trait in target.traits)
    {
      if (trait.data.name == this.trait.name)
      {
        flag = true;
        break;
      }
    }
    return !flag ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    bool flag = false;
    foreach (CardData.TraitStacks trait in targetData.traits)
    {
      if (trait.data.name == this.trait.name)
      {
        flag = true;
        break;
      }
    }
    return !flag ? this.not : !this.not;
  }
}
