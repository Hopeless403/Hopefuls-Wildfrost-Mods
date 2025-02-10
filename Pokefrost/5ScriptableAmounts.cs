// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetConstraintHasNegativeStatus
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class TargetConstraintHasNegativeStatus : TargetConstraint
  {
    public override bool Check(Entity target)
    {
      return !target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.IsNegativeStatusEffect())) ? this.not : !this.not;
    }

    public override bool Check(CardData targetData)
    {
      bool flag = false;
      foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
      {
        if (startWithEffect.data.IsNegativeStatusEffect())
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
          if (statusEffect.data.IsNegativeStatusEffect())
          {
            flag = true;
            break;
          }
        }
      }
      return !this.not ? flag : !flag;
    }
  }
}
