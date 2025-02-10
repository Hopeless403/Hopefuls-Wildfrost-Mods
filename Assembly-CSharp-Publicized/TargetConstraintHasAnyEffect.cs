// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasAnyEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Has Any Effect", menuName = "Target Constraints/Has Any Effect")]
public class TargetConstraintHasAnyEffect : TargetConstraint
{
  public override bool Check(CardData targetData)
  {
    CardData.StatusEffectStacks[] attackEffects = targetData.attackEffects;
    if (attackEffects != null && attackEffects.Length > 0 || targetData.startWithEffects != null && ((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => !a.data.isStatus)))
      return true;
    List<CardData.TraitStacks> traits = targetData.traits;
    return traits != null && traits.Count > 0;
  }

  public override bool Check(Entity target)
  {
    List<CardData.StatusEffectStacks> attackEffects = target.attackEffects;
    if (attackEffects != null && attackEffects.Count > 0)
      return true;
    return target.statusEffects != null && target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => !a.isStatus));
  }
}
