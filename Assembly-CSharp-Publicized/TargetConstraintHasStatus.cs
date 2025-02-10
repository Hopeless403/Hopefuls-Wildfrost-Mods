// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Has Status", menuName = "Target Constraints/Has Status")]
public class TargetConstraintHasStatus : TargetConstraint
{
  [SerializeField]
  public StatusEffectData status;

  public override bool Check(Entity target) => !(bool) (Object) target.FindStatus(this.status.type) ? this.not : !this.not;

  public override bool Check(CardData targetData)
  {
    bool flag = false;
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      if (startWithEffect.data.type == this.status.type)
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
        if (statusEffect.data.type == this.status.type)
        {
          flag = true;
          break;
        }
      }
    }
    return !this.not ? flag : !flag;
  }
}
