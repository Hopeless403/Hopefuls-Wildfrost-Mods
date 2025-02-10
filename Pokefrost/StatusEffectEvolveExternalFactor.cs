// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveExternalFactor
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveExternalFactor : StatusEffectEvolve
  {
    public static Dictionary<string, string> upgradeMap = new Dictionary<string, string>();
    public int threshold;
    public Action<int> constraint = new Action<int>(StatusEffectEvolveExternalFactor.ReturnTrueIfMoneyIsAboveThreshold);
    public static bool result = false;

    public static void ReturnTrueIfMoneyIsAboveThreshold(int t)
    {
      StatusEffectEvolveExternalFactor.result = References.Player.data.inventory.gold >= t;
    }

    public static void ReturnTrueIfEmptyDeck(int t)
    {
      StatusEffectEvolveExternalFactor.result = References.Player.drawContainer.Count + References.Player.handContainer.Count + References.Player.discardContainer.Count == 0;
    }

    public static void ReturnTrueIfThickDeck(int t)
    {
      StatusEffectEvolveExternalFactor.result = References.PlayerData.inventory.deck.Where<CardData>((Func<CardData, bool>) (c => c.cardType.name == "Item")).Count<CardData>() >= t;
    }

    public static void ReturnTrueIfEnoughJunk(int t)
    {
      int num = 0;
      foreach (UnityEngine.Object @object in References.Player.drawContainer)
      {
        if (@object.name == "Junk")
          ++num;
      }
      foreach (UnityEngine.Object @object in References.Player.handContainer)
      {
        if (@object.name == "Junk")
          ++num;
      }
      foreach (UnityEngine.Object @object in References.Player.discardContainer)
      {
        if (@object.name == "Junk")
          ++num;
      }
      StatusEffectEvolveExternalFactor.result = num >= t;
    }

    public void SetConstraint(Action<int> c) => this.constraint = c;

    public override void Init()
    {
      base.Init();
      foreach (CardData.StatusEffectStacks startWithEffect in this.target.data.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          this.threshold = ((StatusEffectEvolveExternalFactor) startWithEffect.data).threshold;
          break;
        }
      }
    }

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
      StringTable collection = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(this.name + "_text", descrip);
      this.textKey = collection.GetString(this.name + "_text");
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          this.constraint(startWithEffect.count);
          return StatusEffectEvolveExternalFactor.result;
        }
      }
      return false;
    }
  }
}
