// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectSketch
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
  internal class StatusEffectSketch : StatusEffectInstant
  {
    public override IEnumerator Process()
    {
      yield return (object) this.AddEffectCopies();
      if (this.applier.display is Card card)
        card.promptUpdateDescription = true;
      this.applier.PromptUpdate();
      yield return (object) base.Process();
    }

    public IEnumerator AddEffectCopies()
    {
      CardData trueCopy = (CardData) null;
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        CardData card = cardData;
        if ((long) card.id == (long) this.applier.data.id)
        {
          trueCopy = card;
          break;
        }
        card = (CardData) null;
      }
      List<StatusEffectData> list = this.target.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e =>
      {
        if (e.count <= e.temporary || e.isStatus || !((UnityEngine.Object) e != (UnityEngine.Object) this))
          return false;
        return e.HasDescOrIsKeyword || e.name == "While Active Increase Attack To Allies (No Desc)" || e.name == "While Active Reduce Attack To Enemies(No Ping, No Desc)";
      })).ToList<StatusEffectData>();
      foreach (Entity.TraitStacks trait in this.target.traits)
      {
        foreach (StatusEffectData passiveEffect in trait.passiveEffects)
          list.Remove(passiveEffect);
        int num = trait.count - trait.tempCount;
        if (num > 0)
        {
          this.applier.GainTrait(trait.data, num);
          if ((UnityEngine.Object) trueCopy != (UnityEngine.Object) null)
            trueCopy.traits.Add(new CardData.TraitStacks(trait.data, num));
        }
      }
      foreach (StatusEffectData item in list)
      {
        if ((UnityEngine.Object) trueCopy != (UnityEngine.Object) null)
          trueCopy.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) trueCopy.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
          {
            new CardData.StatusEffectStacks(AddressableLoader.Get<StatusEffectData>("StatusEffectData", item.name), item.count - item.temporary)
          });
        yield return (object) StatusEffectSystem.Apply(this.applier, item.applier, item, item.count - item.temporary);
      }
      if ((UnityEngine.Object) trueCopy != (UnityEngine.Object) null)
        trueCopy.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) trueCopy.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) this.target.attackEffects.Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToArray<CardData.StatusEffectStacks>());
      this.applier.attackEffects = ((IEnumerable<CardData.StatusEffectStacks>) CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) this.applier.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) this.target.attackEffects)).Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToList<CardData.StatusEffectStacks>();
      for (int i = 0; i < this.applier.statusEffects.Count; ++i)
      {
        if (this.applier.statusEffects[i].name == "When Deployed Sketch")
        {
          --this.applier.statusEffects[i].count;
          if (this.applier.statusEffects[i].count == 0)
            yield return (object) this.applier.statusEffects[i].Remove();
        }
      }
      yield return (object) this.applier.UpdateTraits();
    }
  }
}
