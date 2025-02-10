// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectPlayCardsInHand
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectPlayCardsInHand : StatusEffectInstant
  {
    public TargetConstraint[] applyConstraints;

    public override IEnumerator Process()
    {
      Entity[] array = ((IEnumerable<Entity>) (this.target.targetMode.GetPotentialTargets(this.target, (Entity) null, (CardContainer) null) ?? new Entity[0])).Where<Entity>((Func<Entity, bool>) (e => e.isActiveAndEnabled && e.canBeHit)).ToArray<Entity>();
      if (array.Length != 0)
      {
        Entity target = array.RandomItem<Entity>();
        List<Entity> list = References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (e => this.SatisfiesConstraints(e))).ToList<Entity>();
        for (int index = 0; index < list.Count; ++index)
          ActionQueue.Stack((PlayAction) new ActionTriggerAgainst(list[index], this.target, target, (CardContainer) null));
      }
      return base.Process();
    }

    public bool SatisfiesConstraints(Entity entity)
    {
      if (this.applyConstraints == null)
        return true;
      foreach (TargetConstraint applyConstraint in this.applyConstraints)
      {
        if (!applyConstraint.Check(entity))
          return false;
      }
      return true;
    }
  }
}
