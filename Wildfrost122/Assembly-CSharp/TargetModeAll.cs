// Decompiled with JetBrains decompiler
// Type: TargetModeAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "TargetModeAll", menuName = "Target Modes/All")]
public class TargetModeAll : TargetMode
{
  [SerializeField]
  private TargetConstraint[] constraints;

  public override bool NeedsTarget => false;

  public override Entity[] GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> list = new HashSet<Entity>();
    list.AddRange<Entity>(entity.GetAllEnemies().Where<Entity>((Func<Entity, bool>) (e => (bool) (UnityEngine.Object) e && e.enabled && e.alive && e.canBeHit && this.CheckConstraints(e))));
    return list.Count <= 0 ? (Entity[]) null : list.ToArray<Entity>();
  }

  public override Entity[] GetSubsequentTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> list = new HashSet<Entity>();
    list.AddRange<Entity>((IEnumerable<Entity>) Battle.GetCardsOnBoard(target.owner));
    list.Remove(entity);
    return list.Count <= 0 ? (Entity[]) null : list.ToArray<Entity>();
  }

  private bool CheckConstraints(Entity target)
  {
    TargetConstraint[] constraints = this.constraints;
    return constraints == null || constraints.Length <= 0 || ((IEnumerable<TargetConstraint>) this.constraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(target)));
  }
}
