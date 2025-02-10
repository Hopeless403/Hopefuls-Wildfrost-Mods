// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveKirlia
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveKirlia : StatusEffectEvolve
  {
    public bool persist = true;
    public string faction = "self";
    public static string[] evolutions = new string[2]
    {
      "gardevoir",
      "gallade"
    };
    public static List<string> Offensive = new List<string>()
    {
      "damage up",
      "lumin",
      "frenzy",
      "spice",
      "teeth"
    };
    public static List<string> Defensive = new List<string>()
    {
      "block",
      "heal",
      "max health up",
      "scrap",
      "shell"
    };

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.evolutionCardName = "gardevoir";
      this.type = "evolve2";
      StringTable collection = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(this.name + "_text", descrip);
      this.textKey = collection.GetString(this.name + "_text");
    }

    public void SetEvolutions(params string[] cardNames)
    {
      this.evolutionCardName = cardNames[0];
      StatusEffectEvolveKirlia.evolutions = cardNames;
    }

    public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
    {
      base.RunPostApplyStatusEvent(apply);
      bool flag1 = false;
      StatusEffectData effectData = apply.effectData;
      bool flag2 = effectData != null && !effectData.type.IsNullOrEmpty();
      switch (this.faction)
      {
        case "ally":
          flag1 = (UnityEngine.Object) apply?.target?.owner == (UnityEngine.Object) this.target?.owner;
          break;
        case "self":
          flag1 = (UnityEngine.Object) apply?.target == (UnityEngine.Object) this.target;
          break;
      }
      if (flag1 & flag2 && this.CheckUniqueEffect(apply.effectData))
      {
        string newType = apply.effectData.type.Replace(", ", ",a");
        Debug.Log((object) "[Pokefrost] Unique Effect!");
        foreach (UnityEngine.Object statusEffect in this.target.statusEffects)
        {
          if (statusEffect.name == this.name && this.count > 0)
          {
            this.AddUniqueEffect(this.target.data, newType);
            --this.count;
            this.target.display.promptUpdateDescription = true;
            this.target.PromptUpdate();
          }
        }
        if (!this.persist && this.count != 0)
          return false;
        this.FindDeckCopy((Action<CardData, CardData.StatusEffectStacks>) ((card, status) =>
        {
          this.AddUniqueEffect(card, newType);
          status.count = this.count;
        }));
      }
      return false;
    }

    public bool CheckUniqueEffect(StatusEffectData effectData)
    {
      string str1;
      this.target.data.TryGetCustomData<string>("Effects Applied", out str1, "");
      string str2 = effectData.type.Replace(", ", ",a");
      return !str1.Split(new string[1]{ ", " }, StringSplitOptions.RemoveEmptyEntries).Contains<string>(str2);
    }

    public void AddUniqueEffect(CardData data, string newType)
    {
      string str;
      data.TryGetCustomData<string>("Effects Applied", out str, "");
      data.SetCustomData("Effects Applied", (object) (str + ", " + newType.Replace(", ", ",a")));
    }

    public void GardevoirOrGallade(CardData data, string newType)
    {
      int num1;
      data.TryGetCustomData<int>("Gardevoir", out num1, 0);
      int num2 = 0;
      if (StatusEffectEvolveKirlia.Offensive.Contains(newType))
        --num2;
      if (StatusEffectEvolveKirlia.Defensive.Contains(newType))
        ++num2;
      data.SetCustomData("Gardevoir", (object) (num1 + num2));
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
          return startWithEffect.count == 0;
      }
      return false;
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      int num;
      preEvo.TryGetCustomData<int>("Gardevoir", out num, 0);
      this.evolutionCardName = num >= 0 ? StatusEffectEvolveKirlia.evolutions[0] : StatusEffectEvolveKirlia.evolutions[1];
      base.Evolve(mod, preEvo);
    }

    public override CardData[] EvolveForFinalBoss(WildfrostMod mod)
    {
      this.evolutionCardName = StatusEffectEvolveKirlia.evolutions.RandomItem<string>();
      return base.EvolveForFinalBoss(mod);
    }
  }
}
