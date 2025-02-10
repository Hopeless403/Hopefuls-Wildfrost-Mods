// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Status", menuName = "Target Constraints/Has Status")]
public class TargetConstraintHasStatus : TargetConstraint
{
  [SerializeField]
  public StatusEffectData status;

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

  [CompilerGenerated]
  public bool \u003CCheck\u003Eb__1_0(StatusEffectData a) => a.name == this.status.name;
}
