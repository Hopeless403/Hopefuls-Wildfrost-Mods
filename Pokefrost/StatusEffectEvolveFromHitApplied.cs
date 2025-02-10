// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromHitApplied
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveFromHitApplied : StatusEffectEvolve
  {
    public Func<Hit, bool> constraint = new Func<Hit, bool>(StatusEffectEvolveFromHitApplied.ReturnTrue);
    public string faction;
    public string targetType;
    public bool persist = true;

    public override bool HasPostHitRoutine => true;

    public void Autofill2(string faction, string targetType)
    {
      this.faction = faction;
      this.targetType = targetType;
    }

    public override void Init()
    {
      base.Init();
      foreach (CardData.StatusEffectStacks startWithEffect in this.target.data.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          this.constraint = ((StatusEffectEvolveFromHitApplied) startWithEffect.data).constraint;
          break;
        }
      }
    }

    public static bool ReturnTrue(Hit hit) => true;

    public virtual void SetConstraints(Func<Hit, bool> f) => this.constraint = f;

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
      StringTable collection = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(this.name + "_text", descrip);
      this.textKey = collection.GetString(this.name + "_text");
    }

    public override bool RunPostHitEvent(Hit hit)
    {
      base.RunPostHitEvent(hit);
      bool flag1 = this.constraint(hit);
      bool flag2 = false;
      bool flag3 = hit.damageType == this.targetType || this.targetType == "all";
      switch (this.faction)
      {
        case "ally":
          flag2 = (UnityEngine.Object) hit?.attacker?.owner == (UnityEngine.Object) this.target?.owner;
          break;
        case "self":
          flag2 = (UnityEngine.Object) hit?.attacker == (UnityEngine.Object) this.target;
          break;
      }
      if (flag1 & flag2 & flag3)
      {
        Debug.Log((object) "[Pokefrost] Confrimed Hit!");
        foreach (UnityEngine.Object statusEffect in this.target.statusEffects)
        {
          if (statusEffect.name == this.name && this.count > 0)
          {
            this.count -= Math.Min(this.count, hit.damage + hit.damageBlocked);
            this.target.display.promptUpdateDescription = true;
            this.target.PromptUpdate();
          }
        }
        if (!this.persist && this.count != 0)
          return false;
        this.FindDeckCopy();
      }
      return false;
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
  }
}
