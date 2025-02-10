// Decompiled with JetBrains decompiler
// Type: TargetModeAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "TargetModeAll", menuName = "Target Modes/All")]
public class TargetModeAll : TargetMode
{
  [SerializeField]
  public TargetConstraint[] constraints;

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

  public bool CheckConstraints(Entity target)
  {
    TargetConstraint[] constraints = this.constraints;
    return constraints == null || constraints.Length <= 0 || ((IEnumerable<TargetConstraint>) this.constraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(target)));
  }

  [CompilerGenerated]
  public bool \u003CGetPotentialTargets\u003Eb__3_0(Entity e) => (bool) (UnityEngine.Object) e && e.enabled && e.alive && e.canBeHit && this.CheckConstraints(e);
}
