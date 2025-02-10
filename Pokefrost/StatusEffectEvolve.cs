// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolve
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolve : StatusEffectData
  {
    public string evolutionCardName;
    public static List<string> evolvedPokemonLastBattle = new List<string>(3);
    public static List<string> pokemonEvolvedIntoLastBattle = new List<string>(3);

    public virtual void Autofill(string n, string descrip, WildfrostMod mod)
    {
      this.canBeBoosted = false;
      this.targetConstraints = new TargetConstraint[0];
      this.name = n;
      StringTable collection = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      this.canBeBoosted = false;
      collection.SetString(this.name + "_text", descrip);
      this.textKey = collection.GetString(this.name + "_text");
      this.ModAdded = mod;
      this.textInsert = "Who knows what this does.";
      this.applyFormat = "";
      this.type = "evolve2";
    }

    public virtual void SetEvolution(string cn) => this.evolutionCardName = cn;

    public virtual void Confirm()
    {
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) this);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) this);
    }

    public virtual void FindDeckCopy()
    {
      this.FindDeckCopy((Action<CardData, CardData.StatusEffectStacks>) ((card, status) => status.count = this.count));
    }

    public virtual void FindDeckCopy(
      Action<CardData, CardData.StatusEffectStacks> action)
    {
      if (this.target.data.cardType.name == "Summoned")
        return;
      CardData cardData1 = (CardData) null;
      foreach (CardData cardData2 in References.Player.data.inventory.deck)
      {
        if ((long) cardData2.id == (long) this.target.data.id)
        {
          cardData1 = cardData2;
          break;
        }
        if (cardData2.name == this.target.data.name)
          cardData1 = cardData2;
      }
      if (!((UnityEngine.Object) cardData1 != (UnityEngine.Object) null))
        return;
      foreach (CardData.StatusEffectStacks startWithEffect in cardData1.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          action(cardData1, startWithEffect);
          Debug.Log((object) "[Pokefrost] Updated deck copy!");
          break;
        }
      }
    }

    public virtual bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
          return startWithEffect.count == 0;
      }
      return false;
    }

    public static IEnumerator EvolutionPopUpAlt(WildfrostMod mod)
    {
      yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
      yield return (object) SceneManager.Load("CardFramesUnlocked", SceneType.Temporary);
      CardFramesUnlockedSequence sequence = UnityEngine.Object.FindObjectOfType<CardFramesUnlockedSequence>();
      TextMeshProUGUI titleObject = sequence.GetComponentInChildren<TextMeshProUGUI>(true);
      if (StatusEffectEvolve.evolvedPokemonLastBattle.Count == 1)
      {
        string preEvo = mod.Get<CardData>(StatusEffectEvolve.evolvedPokemonLastBattle[0]).title;
        string evo = mod.Get<CardData>(StatusEffectEvolve.pokemonEvolvedIntoLastBattle[0]).title;
        titleObject.text = "<size=0.55>What? <#ff0>" + preEvo + "</color> has\n evolved into <#ff0>" + evo + "</color>!";
        preEvo = (string) null;
        evo = (string) null;
      }
      else
        titleObject.text = "<size=0.55>What? <#ff0>" + StatusEffectEvolve.evolvedPokemonLastBattle.Count.ToString() + "</color> Pokemon have evolved!";
      Pokefrost.Pokefrost.fx.TryPlaySound("evolution");
      yield return (object) sequence.StartCoroutine("CreateCards", (object) StatusEffectEvolve.pokemonEvolvedIntoLastBattle.ToArray());
      yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
      StatusEffectEvolve.evolvedPokemonLastBattle.Clear();
      StatusEffectEvolve.pokemonEvolvedIntoLastBattle.Clear();
    }

    public virtual CardData[] EvolveForFinalBoss(WildfrostMod mod)
    {
      CardData cardData = mod.Get<CardData>(this.evolutionCardName);
      if ((UnityEngine.Object) cardData == (UnityEngine.Object) null)
        return (CardData[]) null;
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data is StatusEffectEvolve data)
        {
          CardData[] cardDataArray = data.EvolveForFinalBoss(mod);
          if (cardDataArray == null)
            cardDataArray = new CardData[1]{ cardData };
          return cardDataArray;
        }
      }
      return new CardData[1]{ cardData };
    }

    public virtual void Evolve(WildfrostMod mod, CardData preEvo)
    {
      CardData cardData = mod.Get<CardData>(this.evolutionCardName).Clone();
      if (preEvo.mainSprite?.name == "shiny")
      {
        string[] strArray = this.evolutionCardName.Split('.');
        Sprite sprite = AddressableExtMethods.ASprite("shiny_" + strArray[strArray.Length - 1] + ".png");
        sprite.name = "shiny";
        cardData.mainSprite = sprite;
        cardData.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
        {
          new CardData.StatusEffectStacks(mod.Get<StatusEffectData>("Shiny"), 1)
        });
      }
      foreach (CardUpgradeData upgrade in preEvo.upgrades)
      {
        if (upgrade.CanAssign(cardData))
          upgrade.Assign(cardData);
        else
          References.PlayerData.inventory.upgrades.Add(mod.Get<CardUpgradeData>(upgrade.name).Clone());
      }
      if (preEvo.cardType.name == "Leader")
      {
        cardData.cardType = preEvo.cardType;
        cardData.SetCustomData("OverrideCardType", (object) "Leader");
      }
      Card card = CardManager.Get(cardData, (CardController) null, References.Player, false, true);
      if (mod.Get<CardData>(preEvo.name).title != preEvo.title)
      {
        cardData.forceTitle = preEvo.title;
        if ((UnityEngine.Object) card != (UnityEngine.Object) null)
        {
          card.SetName(preEvo.title);
          Debug.Log((object) ("[Pokefrost] renamed evolution to " + preEvo.title));
        }
        Events.InvokeRename(card.entity, preEvo.title);
      }
      if (preEvo.cardType.name == "Leader")
        References.Player.data.inventory.deck.Insert(0, card.entity.data);
      else
        References.Player.data.inventory.deck.Add(card.entity.data);
      Events.InvokeEntityShowUnlocked(card.entity);
      EvolutionPopUp.evolvedPokemonLastBattle.Add(preEvo);
      EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(card.entity.data);
    }

    public static void CheckEvolve()
    {
      if ((UnityEngine.Object) References.Battle.winner != (UnityEngine.Object) References.Player)
        return;
      StatusEffectEvolve.CheckEvolve<StatusEffectEvolve>(References.PlayerData.inventory.deck, "evolve2", (Func<StatusEffectEvolve, CardData, bool>) ((s, c) => s.ReadyToEvolve(c)));
    }

    protected static void CheckEvolve<T>(
      CardDataList list,
      string evolveType,
      Func<T, CardData, bool> condition)
      where T : StatusEffectEvolve
    {
      List<CardData> slateForEvolution = new List<CardData>();
      List<StatusEffectEvolve> statusEffectEvolveList = new List<StatusEffectEvolve>();
      foreach (CardData cardData in list)
      {
        if (cardData.cardType.name != "Leader")
        {
          foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
          {
            if (startWithEffect.data.type == evolveType)
            {
              if (condition((T) startWithEffect.data, cardData))
              {
                Debug.Log((object) "[Pokefrost] Ready for evolution!");
                slateForEvolution.Add(cardData);
                statusEffectEvolveList.Add((StatusEffectEvolve) startWithEffect.data);
              }
              else
                Debug.Log((object) "[Pokefrost] Conditions not met.");
            }
          }
        }
      }
      int count = slateForEvolution.Count;
      for (int i = 0; i < count; i++)
      {
        if (list.RemoveWhere<CardData>((Predicate<CardData>) (a => (long) slateForEvolution[i].id == (long) a.id)))
        {
          Debug.Log((object) ("[" + slateForEvolution[i].name + "] Removed From [" + References.Player.name + "] deck"));
          statusEffectEvolveList[i].Evolve((WildfrostMod) Pokefrost.Pokefrost.instance, slateForEvolution[i]);
        }
      }
    }
  }
}
