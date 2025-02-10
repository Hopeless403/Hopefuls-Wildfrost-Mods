// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Status", menuName = "Target Constraints/Has Status")]
public class TargetConstraintHasStatus : TargetConstraint
{
  [SerializeField]
  private StatusEffectData status;

  public override bool Check(Entity target)
  {
    return !target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.name == this.status.name)) ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    bool flag = false;
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      if (startWithEffect.data.name == this.status.name)
      {
        flag = true;
        break;
      }
    }
    return !this.not ? flag : !flag;
  }

  public bool CheckWillApply(Hit hit)
  {
    bool flag = false;
    List<CardData.StatusEffectStacks> statusEffects = hit.statusEffects;
    if (statusEffects != null && statusEffects.Count > 0)
    {
      foreach (CardData.StatusEffectStacks statusEffect in hit.statusEffects)
      {
        if (statusEffect.data.name == this.status.name)
        {
          flag = true;
          break;
        }
      }
    }
    return !this.not ? flag : !flag;
  }
}
