// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectChangeData
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectChangeData : StatusEffectData
  {
    public CardData cardBase;
    public Sprite sprite;
    public int keepHowMany = 5;

    public override void Init()
    {
      this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.TurnStart);
    }

    public override bool RunBeginEvent()
    {
      this.target.data.backgroundSprite = this.sprite;
      if ((UnityEngine.Object) this.cardBase != (UnityEngine.Object) null)
        this.target.data.mainSprite = this.cardBase.mainSprite;
      this.target.data.playType = Card.PlayType.Play;
      this.target.StartCoroutine(this.target.display.UpdateData(true));
      return false;
    }

    public override bool RunTurnEndEvent(Entity entity) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target;

    private IEnumerator TurnStart(Entity entity)
    {
      this.ChangeCard();
      yield return (object) this.UpdateData();
      this.target.PromptUpdate();
      yield return (object) this.target.display.UpdateData(true);
      Card card = this.target.display as Card;
      card.SetName(this.cardBase.title);
    }

    public IEnumerator RemoveData()
    {
      for (int i = this.target.traits.Count - 1; i >= 1; --i)
      {
        this.target.traits[i].count -= this.target.traits[i].tempCount;
        this.target.traits[i].tempCount = 0;
        yield return (object) this.target.UpdateTraits(this.target.traits[i]);
      }
      for (int i = this.target.statusEffects.Count - 1; i >= this.keepHowMany; --i)
      {
        StatusEffectData status = this.target.statusEffects[i];
        yield return (object) status.Remove();
        status = (StatusEffectData) null;
      }
    }

    public void ChangeCard()
    {
      foreach (CardData cardData in (IEnumerable<CardData>) StatusEffectChangeData.InPettyRandomOrder<CardData>((IEnumerable<CardData>) AddressableLoader.GetGroup<CardData>("CardData")))
      {
        Debug.Log((object) ("[Test] " + cardData.title));
        if (cardData.cardType.name == "Item" && cardData.playType != Card.PlayType.None && cardData.mainSprite?.name != "Nothing" && (cardData.traits == null || !cardData.traits.Exists((Predicate<CardData.TraitStacks>) (b => b.data.name == "Consume" || b.data.name == "Recycle"))))
        {
          this.cardBase = cardData;
          break;
        }
      }
    }

    public static IOrderedEnumerable<T> InPettyRandomOrder<T>(IEnumerable<T> source)
    {
      return source.OrderBy<T, float>((Func<T, float>) (a => PettyRandom.Range(0.0f, 1f)));
    }

    public IEnumerator UpdateData()
    {
      yield return (object) this.RemoveData();
      CardData trueData = this.target.data;
      this.target.damage.current = this.cardBase.damage;
      this.target.targetMode = this.cardBase.targetMode;
      trueData.mainSprite = this.cardBase.mainSprite;
      trueData.hasAttack = this.cardBase.hasAttack;
      trueData.targetConstraints = this.cardBase.targetConstraints;
      trueData.canPlayOnBoard = this.cardBase.canPlayOnBoard;
      trueData.canPlayOnEnemy = this.cardBase.canPlayOnEnemy;
      trueData.canPlayOnHand = this.cardBase.canPlayOnHand;
      trueData.canPlayOnFriendly = this.cardBase.canPlayOnFriendly;
      trueData.damage = this.cardBase.damage;
      trueData.needsTarget = this.cardBase.needsTarget;
      trueData.playOnSlot = this.cardBase.playOnSlot;
      trueData.titleFallback = this.cardBase.titleFallback;
      trueData.textKey = this.cardBase.textKey;
      trueData.textInsert = this.cardBase.textInsert;
      Card card = this.target.display as Card;
      card.SetName(this.cardBase.title);
      if (this.cardBase.traits != null)
      {
        foreach (CardData.TraitStacks trait in this.cardBase.traits)
          this.target.GainTrait(trait.data, trait.count, true);
        yield return (object) this.target.UpdateTraits();
      }
      CardData.StatusEffectStacks[] statusEffectStacksArray = this.cardBase.startWithEffects;
      for (int index = 0; index < statusEffectStacksArray.Length; ++index)
      {
        CardData.StatusEffectStacks item = statusEffectStacksArray[index];
        yield return (object) StatusEffectSystem.Apply(this.target, (Entity) null, item.data, item.count, true, fireEvents: false);
        item = (CardData.StatusEffectStacks) null;
      }
      statusEffectStacksArray = (CardData.StatusEffectStacks[]) null;
      this.target.attackEffects = ((IEnumerable<CardData.StatusEffectStacks>) this.cardBase.attackEffects).Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToList<CardData.StatusEffectStacks>();
    }
  }
}
