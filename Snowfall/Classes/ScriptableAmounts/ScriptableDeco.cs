// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.ScriptableAmounts.ScriptableDeco
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowfall2.Classes.ScriptableAmounts
{
  public class ScriptableDeco : ScriptableAmount
  {
    public ScriptableAmount basic;
    public ScriptableDeco.DecoType decoType;
    public ScriptableAmount other;

    public override int Get(Entity entity)
    {
      switch (this.decoType)
      {
        case ScriptableDeco.DecoType.AlliesInRow:
          List<CardSlot> slots = Battle.instance.allSlots.ToList<CardSlot>();
          int index = slots.FindIndex((Predicate<CardSlot>) (slot => slot.Contains(entity)));
          return ((IEnumerable<int>) new int[3]{ 0, 1, 2 }).Sum<int>((Func<int, int>) (n => slots[index / 3 * 3 + n].entities.Count <= 0 ? 0 : this.basic.Get(slots[index / 3 * 3 + n].entities[0])));
        case ScriptableDeco.DecoType.HalfUp:
          return (this.basic.Get(entity) + 1) / 2;
        case ScriptableDeco.DecoType.ConditionalOnTarget:
          return ((IEnumerable<Entity>) entity.targetMode.GetPotentialTargets(entity, (Entity) null, (CardContainer) null)).Sum<Entity>((Func<Entity, int>) (target =>
          {
            ScriptableAmount other = this.other;
            return other == null ? 0 : other.Get(target);
          })) >= 1 ? this.basic.Get(entity) : 0;
        default:
          return base.Get(entity);
      }
    }

    public enum DecoType
    {
      AlliesInRow,
      HalfUp,
      ConditionalOnTarget,
    }
  }
}
