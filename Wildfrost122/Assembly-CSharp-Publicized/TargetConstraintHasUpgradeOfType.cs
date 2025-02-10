// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasUpgradeOfType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Upgrade Of Type", menuName = "Target Constraints/Has Upgrade Of Type")]
public class TargetConstraintHasUpgradeOfType : TargetConstraint
{
  [SerializeField]
  public CardUpgradeData.Type type = CardUpgradeData.Type.Charm;
  [SerializeField]
  public int countRequired = 1;
  [SerializeField]
  public CardUpgradeData[] ignore;

  public override bool Check(CardData targetData)
  {
    int num = 0;
    foreach (CardUpgradeData upgrade in targetData.upgrades)
    {
      if (upgrade.type == this.type && !this.ignore.Contains<CardUpgradeData>(upgrade))
      {
        if (++num >= this.countRequired)
          break;
      }
    }
    return num < this.countRequired ? this.not : !this.not;
  }

  public override bool Check(Entity target) => this.Check(target.data);
}
