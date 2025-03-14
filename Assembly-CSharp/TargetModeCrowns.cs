﻿// Decompiled with JetBrains decompiler
// Type: TargetModeCrowns
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "TargetModeCrowns", menuName = "Target Modes/Crowns")]
public class TargetModeCrowns : TargetMode
{
  public override Entity[] GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    HashSet<Entity> list = new HashSet<Entity>();
    list.AddRange<Entity>(entity.GetAllEnemies().Where<Entity>((Func<Entity, bool>) (e => (bool) (UnityEngine.Object) e && e.enabled && e.alive && e.canBeHit && e.data.HasCrown)));
    return list.Count <= 0 ? (Entity[]) null : list.ToArray<Entity>();
  }

  public override Entity[] GetSubsequentTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    return this.GetTargets(entity, target, targetContainer);
  }
}
