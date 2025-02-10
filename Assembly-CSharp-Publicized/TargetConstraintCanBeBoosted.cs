// Decompiled with JetBrains decompiler
// Type: TargetConstraintCanBeBoosted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Can Be Boosted", menuName = "Target Constraints/Can Be Boosted")]
public class TargetConstraintCanBeBoosted : TargetConstraint
{
  public override bool Check(Entity target)
  {
    if (TargetConstraintCanBeBoosted.CheckAttackEffects(target))
      return !this.not;
    return TargetConstraintCanBeBoosted.CheckPassiveEffects(target) ? !this.not : this.not;
  }

  public override bool Check(CardData targetData)
  {
    if (TargetConstraintCanBeBoosted.CheckAttackEffects(targetData))
      return !this.not;
    if (TargetConstraintCanBeBoosted.CheckPassiveEffects(targetData))
      return !this.not;
    return TargetConstraintCanBeBoosted.CheckTraits(targetData) ? !this.not : this.not;
  }

  public static bool CheckAttackEffects(Entity target) => TargetConstraintCanBeBoosted.CheckAttackEffects(target.attackEffects.Select<CardData.StatusEffectStacks, StatusEffectData>((Func<CardData.StatusEffectStacks, StatusEffectData>) (a => a.data)));

  public static bool CheckAttackEffects(CardData targetData) => TargetConstraintCanBeBoosted.CheckAttackEffects(((IEnumerable<CardData.StatusEffectStacks>) targetData.attackEffects).Select<CardData.StatusEffectStacks, StatusEffectData>((Func<CardData.StatusEffectStacks, StatusEffectData>) (a => a.data)));

  public static bool CheckAttackEffects(IEnumerable<StatusEffectData> effects) => effects != null && effects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.stackable));

  public static bool CheckPassiveEffects(Entity target) => TargetConstraintCanBeBoosted.CheckPassiveEffects((IEnumerable<StatusEffectData>) target.statusEffects);

  public static bool CheckPassiveEffects(CardData targetData) => TargetConstraintCanBeBoosted.CheckPassiveEffects(((IEnumerable<CardData.StatusEffectStacks>) targetData.startWithEffects).Select<CardData.StatusEffectStacks, StatusEffectData>((Func<CardData.StatusEffectStacks, StatusEffectData>) (a => a.data)));

  public static bool CheckPassiveEffects(IEnumerable<StatusEffectData> effects) => effects != null && effects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.canBeBoosted));

  public static bool CheckTraits(Entity target)
  {
    if (target.traits == null)
      return false;
    foreach (Entity.TraitStacks trait in target.traits)
    {
      if (TargetConstraintCanBeBoosted.CheckPassiveEffects((IEnumerable<StatusEffectData>) trait.data.effects))
        return true;
    }
    return false;
  }

  public static bool CheckTraits(CardData targetData)
  {
    if (targetData.traits == null)
      return false;
    foreach (CardData.TraitStacks trait in targetData.traits)
    {
      if (TargetConstraintCanBeBoosted.CheckPassiveEffects((IEnumerable<StatusEffectData>) trait.data.effects))
        return true;
    }
    return false;
  }
}
