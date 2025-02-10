// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectAllCardsAreRecycled
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectAllCardsAreRecycled : StatusEffectData
  {
    public bool added = false;

    public override bool RunBeginEvent()
    {
      this.Activate();
      return false;
    }

    public void OnDestroy() => this.Deactivate();

    public override bool RunEffectBonusChangedEvent()
    {
      if (this.GetAmount() == 0)
        this.Deactivate();
      else
        this.Activate();
      return false;
    }

    protected void Activate()
    {
      if (this.added)
        return;
      ++StatusEffectAllCardsAreRecycled.PatchRecycle.active;
      this.added = true;
    }

    protected void Deactivate()
    {
      if (!this.added)
        return;
      --StatusEffectAllCardsAreRecycled.PatchRecycle.active;
      this.added = false;
    }

    [HarmonyPatch(typeof (StatusEffectRecycle), "GetTargets")]
    internal class PatchRecycle
    {
      public static int active = 0;
      public static CardData lastDestroyed = (CardData) null;
      public static int node = -1;

      public static bool Active => StatusEffectAllCardsAreRecycled.PatchRecycle.active != 0;

      private static void Prefix(
        StatusEffectRecycle __instance,
        ref int requiredAmount,
        out List<Entity> __state)
      {
        int num = 0;
        __state = new List<Entity>();
        if (!StatusEffectAllCardsAreRecycled.PatchRecycle.Active)
          return;
        foreach (Entity entity in References.Player.handContainer)
        {
          if (!((UnityEngine.Object) entity == (UnityEngine.Object) __instance.target))
          {
            if (entity.name == __instance.cardToRecycle)
            {
              ++num;
            }
            else
            {
              ++num;
              __state.Add(entity);
            }
          }
        }
        if (num < requiredAmount)
          return;
        int val1 = num - __state.Count;
        int count = Math.Max(0, requiredAmount - val1);
        requiredAmount = Math.Min(val1, requiredAmount);
        __state = __state.GetRange(0, count);
      }

      private static void Postfix(
        ref bool __result,
        StatusEffectRecycle __instance,
        int requiredAmount,
        List<Entity> __state)
      {
        if (!__result && requiredAmount == 0)
          __result = true;
        __instance.toDestroy.AddRange((IEnumerable<Entity>) __state);
        if (__instance.toDestroy.Count == 0)
          return;
        StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed = __instance.toDestroy[__instance.toDestroy.Count - 1].data;
        StatusEffectAllCardsAreRecycled.PatchRecycle.node = Campaign.FindCharacterNode(References.Player).id;
      }
    }

    [HarmonyPatch(typeof (DestroyTargetSystem), "ShowTargets")]
    internal class PatchShowRecycleTargets
    {
      private static void Prefix(DestroyTargetSystem __instance, Entity entity)
      {
        if (!StatusEffectAllCardsAreRecycled.PatchRecycle.Active || entity.silenced)
          return;
        foreach (StatusEffectData statusEffect in entity.statusEffects)
        {
          StatusEffectRecycle recycle = statusEffect as StatusEffectRecycle;
          if (recycle != null)
          {
            int num1 = References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (h => h.name == recycle.cardToRecycle)).Count<Entity>();
            int num2 = recycle.GetAmount() - num1;
            if (num2 <= 0)
              break;
            foreach (Entity entity1 in References.Player.handContainer)
            {
              if (entity1.name != recycle.cardToRecycle && (UnityEngine.Object) entity1 != (UnityEngine.Object) entity)
              {
                __instance.toIndicate.Add(entity1);
                if (--num2 <= 0)
                  break;
              }
            }
          }
        }
      }
    }
  }
}
