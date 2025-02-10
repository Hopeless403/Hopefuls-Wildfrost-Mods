// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetModeTaunt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class TargetModeTaunt : TargetMode
  {
    public string targetTrait = "Taunt";
    public bool missing = false;
    public bool failSafe = true;

    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      HashSet<Entity> list = new HashSet<Entity>();
      list.AddRange<Entity>(entity.GetAllEnemies().Where<Entity>((Func<Entity, bool>) (e => (bool) (UnityEngine.Object) e && e.enabled && e.alive && e.canBeHit && this.HasTaunt(e))));
      return list.Count <= 0 && this.failSafe ? ScriptableObject.CreateInstance<TargetModeBasic>().GetPotentialTargets(entity, target, targetContainer) : list.ToArray<Entity>();
    }

    public override Entity[] GetSubsequentTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      return this.GetTargets(entity, target, targetContainer);
    }

    public bool HasTaunt(Entity entity)
    {
      foreach (Entity.TraitStacks trait in entity.traits)
      {
        if (trait.data.name == this.targetTrait)
          return !this.missing;
      }
      return this.missing;
    }
  }
}
