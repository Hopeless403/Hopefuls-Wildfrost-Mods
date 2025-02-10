// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectInstantApplyXToCustom
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectInstantApplyXToCustom : StatusEffectInstant
  {
    public StatusEffectData effectToApply;
    public StatusEffectInstantApplyXToCustom.CustomTargetFlags customTargetFlags;
    public ScriptableAmount scriptableAmount;

    public override IEnumerator Process()
    {
      int num = (bool) (UnityEngine.Object) this.scriptableAmount ? this.scriptableAmount.Get(this.target) : this.GetAmount();
      foreach (Entity targ in this.GetTargets())
        yield return (object) StatusEffectSystem.Apply(targ, this.applier, this.effectToApply, num);
      yield return (object) base.Process();
    }

    public List<Entity> GetTargets()
    {
      List<Entity> targets = new List<Entity>();
      if (this.customTargetFlags.HasFlag((Enum) StatusEffectInstantApplyXToCustom.CustomTargetFlags.AlliesInFront))
      {
        List<Entity> alliesInRow = this.target.GetAlliesInRow();
        List<CardSlot> slots = Battle.instance.GetSlots(this.target.owner);
        int tIndex = slots.FindIndex((Predicate<CardSlot>) (slot => slot.entities.Contains(this.target)));
        int index = slots.FindIndex((Predicate<CardSlot>) (slot => slot.entities.Contains(this.target) && slots.IndexOf(slot) != tIndex));
        foreach (Entity entity in alliesInRow)
        {
          Entity a = entity;
          if (slots.FindIndex((Predicate<CardSlot>) (slot => slot.entities.Contains(a))) < tIndex)
            targets.Add(a);
          if (index != -1 && slots.FindIndex((Predicate<CardSlot>) (slot => slot.entities.Contains(a))) < index && slots.FindIndex((Predicate<CardSlot>) (slot => slot.entities.Contains(a))) > 2)
            targets.Add(a);
        }
      }
      if (this.customTargetFlags.HasFlag((Enum) StatusEffectInstantApplyXToCustom.CustomTargetFlags.FrontColumnEnemies))
      {
        foreach (CardContainer cardContainer in Battle.instance.rows[Battle.GetOpponent(this.target.owner)])
        {
          if (cardContainer.Count > 0 && cardContainer[0] != null)
            targets.Add(cardContainer[0]);
        }
      }
      return targets;
    }

    public enum CustomTargetFlags
    {
      None,
      AlliesInFront,
      FrontColumnEnemies,
    }
  }
}
