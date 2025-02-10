// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromKill
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveFromKill : StatusEffectEvolve
  {
    public Func<Entity, DeathType, bool> constraint = new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrue);
    public bool anyKill = false;
    public bool persist = true;

    public override void Init()
    {
      base.Init();
      foreach (CardData.StatusEffectStacks startWithEffect in this.target.data.startWithEffects)
      {
        if (startWithEffect.data.name == this.name)
        {
          this.constraint = ((StatusEffectEvolveFromKill) startWithEffect.data).constraint;
          break;
        }
      }
    }

    public static bool ReturnTrue(Entity entity, DeathType deathType) => true;

    public static bool ReturnTrueIfCardTypeIsBossOrMiniboss(Entity entity, DeathType deathType)
    {
      string name = entity.data.cardType.name;
      return name == "Boss" || name == "Miniboss" || name == "BossSmall";
    }

    public static bool ReturnTrueIfCardWasConsumed(Entity entity, DeathType deathType)
    {
      return deathType == DeathType.Consume;
    }

    public static bool ReturnTrueIfCardWasRecycled(Entity entity, DeathType _)
    {
      return (UnityEngine.Object) StatusEffectEvolveFromKill.PatchRecycleEvent.recycler != (UnityEngine.Object) null && StatusEffectEvolveFromKill.PatchRecycleEvent.recycler.toDestroy.Contains(entity);
    }

    public static bool ReturnTrueIfRecycleCardWasRecycled(Entity entity, DeathType _)
    {
      return (UnityEngine.Object) StatusEffectEvolveFromKill.PatchRecycleEvent.recycler != (UnityEngine.Object) null && StatusEffectEvolveFromKill.PatchRecycleEvent.recycler.toDestroy.Contains(entity) && entity.traits.FirstOrDefault<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (s => s.data?.name == "Recycle")) != null;
    }

    public virtual void SetConstraints(Func<Entity, DeathType, bool> c) => this.constraint = c;

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
      StringTable collection = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(this.name + "_text", descrip);
      this.textKey = collection.GetString(this.name + "_text");
    }

    public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
    {
      if ((this.anyKill || entity.lastHit != null && (UnityEngine.Object) entity.lastHit.attacker == (UnityEngine.Object) this.target) && this.constraint(entity, deathType))
      {
        foreach (UnityEngine.Object statusEffect in this.target.statusEffects)
        {
          if (statusEffect.name == this.name && this.count > 0)
          {
            --this.count;
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

    [HarmonyPatch(typeof (StatusEffectRecycle), "EntityPreTrigger")]
    private class PatchRecycleEvent
    {
      public static StatusEffectRecycle recycler;

      private static IEnumerator Postfix(IEnumerator __result, StatusEffectRecycle __instance)
      {
        StatusEffectRecycle pre = StatusEffectEvolveFromKill.PatchRecycleEvent.recycler;
        StatusEffectEvolveFromKill.PatchRecycleEvent.recycler = __instance;
        yield return (object) __result;
        StatusEffectEvolveFromKill.PatchRecycleEvent.recycler = pre;
      }
    }
  }
}
