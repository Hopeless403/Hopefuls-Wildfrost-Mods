// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolvePlayCards
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolvePlayCards : StatusEffectEvolve
  {
    public string[] cardNames;
    public string[] displayedNames;
    public Func<Entity, Entity[], bool> cardConstraint;
    public string textInsertTemplate = "";

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
    }

    public void SetCardNames(params string[] names) => this.cardNames = names;

    public void SetDispalyedNames(params string[] names) => this.displayedNames = names;

    public void SetTextTemplate(string text)
    {
      this.textInsertTemplate = text;
      this.textInsert = string.Format(this.textInsertTemplate, (object[]) this.displayedNames);
    }

    public void SetCardConstraint(Func<Entity, Entity[], bool> constraint)
    {
      this.cardConstraint = constraint;
    }

    public static bool ReturnTrueIfTrait(string name, Entity entity)
    {
      foreach (Entity.TraitStacks trait in entity.traits)
      {
        if (trait.data.name == name)
          return true;
      }
      return false;
    }

    public override void Init()
    {
      base.Init();
      foreach (CardData.StatusEffectStacks startWithEffect in this.target.data.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          this.cardConstraint = ((StatusEffectEvolvePlayCards) startWithEffect.data).cardConstraint;
          return;
        }
      }
      this.UpdateTextInsert();
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if (this.cardConstraint != null && this.cardConstraint(entity, targets))
        return this.GeneralCardPlayed(entity, targets);
      return this.cardNames != null && this.cardNames.Length != 0 && this.SpecificCardPlayed(entity, targets);
    }

    public virtual bool SpecificCardPlayed(Entity entity, Entity[] targets)
    {
      for (int y = 0; y < this.cardNames.Length; ++y)
      {
        if (entity.name == this.cardNames[y])
        {
          Debug.Log((object) "[Pokefrost] Played corresponding card");
          int num = (int) Math.Round(Math.Pow(2.0, (double) y));
          if (this.count / num % 2 == 1)
          {
            this.count -= num;
            this.UpdateTextInsert();
            this.FindDeckCopy();
          }
        }
      }
      return false;
    }

    public virtual bool GeneralCardPlayed(Entity entity, Entity[] targets)
    {
      if (this.count > 0)
      {
        --this.count;
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
        this.FindDeckCopy();
      }
      return false;
    }

    private void UpdateTextInsert()
    {
      string[] strArray = this.displayedNames.Clone() as string[];
      for (int y = 0; y < strArray.Length; ++y)
      {
        if (this.count / (int) Math.Round(Math.Pow(2.0, (double) y)) % 2 == 0)
          strArray[y] = "<s>" + strArray[y] + "</s>";
      }
      this.textInsert = string.Format(this.textInsertTemplate, (object[]) strArray);
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      if (this.cardConstraint != null)
      {
        foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
        {
          if (startWithEffect.data.name == this.name)
            return startWithEffect.count == 0;
        }
        return false;
      }
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          int num = (int) Math.Round(Math.Pow(2.0, (double) (this.cardNames.Length + 1)));
          return startWithEffect.count % num == 0;
        }
      }
      return false;
    }
  }
}
