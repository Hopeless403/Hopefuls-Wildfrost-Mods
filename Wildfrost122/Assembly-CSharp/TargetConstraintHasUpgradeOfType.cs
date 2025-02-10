// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasUpgradeOfType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Upgrade Of Type", menuName = "Target Constraints/Has Upgrade Of Type")]
public class TargetConstraintHasUpgradeOfType : TargetConstraint
{
  [SerializeField]
  private CardUpgradeData.Type type = CardUpgradeData.Type.Charm;
  [SerializeField]
  private int countRequired = 1;
  [SerializeField]
  private CardUpgradeData[] ignore;

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
