// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromStatusApplied
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
  internal class StatusEffectEvolveFromStatusApplied : StatusEffectEvolve
  {
    public static Dictionary<string, string> upgradeMap = new Dictionary<string, string>();
    public Func<StatusEffectEvolveFromStatusApplied, StatusEffectApply, bool> constraint = new Func<StatusEffectEvolveFromStatusApplied, StatusEffectApply, bool>(StatusEffectEvolveFromStatusApplied.ReturnTrue);
    public string faction;
    public string targetType;
    public bool persist = true;
    public bool threshold = false;
    public bool once = false;

    public override void Init()
    {
      base.Init();
      foreach (CardData.StatusEffectStacks startWithEffect in this.target.data.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          this.constraint = ((StatusEffectEvolveFromStatusApplied) startWithEffect.data).constraint;
          break;
        }
      }
    }

    public static bool ReturnTrue(
      StatusEffectEvolveFromStatusApplied instance,
      StatusEffectApply apply)
    {
      return true;
    }

    public static bool ReturnTrueIfEnoughAffected(
      StatusEffectEvolveFromStatusApplied instance,
      StatusEffectApply apply)
    {
      if (instance.count == 0)
        return false;
      int num = 0;
      foreach (Entity entity in Battle.GetCardsOnBoard())
      {
        if ((UnityEngine.Object) entity.FindStatus(instance.targetType) != (UnityEngine.Object) null)
          ++num;
      }
      return num == instance.count;
    }

    public virtual void SetConstraints(
      Func<StatusEffectEvolveFromStatusApplied, StatusEffectApply, bool> f)
    {
      this.constraint = f;
    }

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
      StringTable collection = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(this.name + "_text", descrip);
      this.textKey = collection.GetString(this.name + "_text");
    }

    public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
    {
      if (apply?.effectData?.type != this.targetType)
        return false;
      bool flag1 = this.constraint(this, apply);
      bool flag2 = false;
      switch (this.faction)
      {
        case "ally":
          flag2 = (UnityEngine.Object) apply?.applier?.owner == (UnityEngine.Object) this.target?.owner;
          break;
        case "toSelf":
          flag2 = (UnityEngine.Object) apply?.target == (UnityEngine.Object) this.target;
          break;
        case "all":
          flag2 = true;
          break;
      }
      if (flag1 & flag2)
      {
        Debug.Log((object) "[Pokefrost] Confirmed Status!");
        foreach (UnityEngine.Object statusEffect in this.target.statusEffects)
        {
          if (statusEffect.name == this.name && this.count > 0)
          {
            if (this.threshold)
            {
              int? count1 = this.target.FindStatus("overload")?.count;
              int count2 = this.count;
              if (count1.GetValueOrDefault() >= count2 & count1.HasValue)
                this.count = 0;
            }
            else if (this.once)
              this.count = 0;
            else
              this.count -= Math.Min(this.count, apply.count);
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
