// Decompiled with JetBrains decompiler
// Type: Pokefrost.AlwaysIgniteModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class AlwaysIgniteModifierSystem : GameSystem
  {
    private StatusEffectData status = Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Burning");
    private int count = 3;

    public void OnEnable() => global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.ApplyIgnite);

    public void OnDisable()
    {
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.ApplyIgnite);
    }

    private void ApplyIgnite(int turn)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
        return;
      HashSet<Entity> allUnits = Battle.GetAllUnits(Battle.instance.enemy);
      if (allUnits.Count == 0)
        return;
      foreach (Entity entity in allUnits)
      {
        if ((UnityEngine.Object) entity.statusEffects.FirstOrDefault<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.type == "burning")) != (UnityEngine.Object) null)
          return;
      }
      ActionQueue.Stack((PlayAction) new ActionApplyStatus(allUnits.RandomItems<Entity>(1)[0], (Entity) null, this.status, this.count));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusIconExt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusIconExt : StatusIcon
  {
    public ButtonAnimator animator;
    public ButtonExt button;
    private IStatusToken effectToken;

    public override void Assign(Entity entity)
    {
      base.Assign(entity);
      this.SetText();
      this.onValueDown.AddListener((UnityAction<Stat, Stat>) ((_param1, _param2) => this.Ping()));
      this.onValueUp.AddListener((UnityAction<Stat, Stat>) ((_param1, _param2) => this.Ping()));
      this.afterUpdate.AddListener(new UnityAction(((StatusIcon) this).SetText));
      this.onValueDown.AddListener(new UnityAction<Stat, Stat>(((StatusIcon) this).CheckDestroy));
      if (!(entity.FindStatus(this.type) is IStatusToken status))
        return;
      this.effectToken = status;
      status.ButtonCreate(this);
      this.button.onClick.AddListener(new UnityAction(this.effectToken.RunButtonClicked));
      this.onDestroy.AddListener(new UnityAction(this.DisableDragBlocker));
    }

    public void DisableDragBlocker() => this.button.DisableDragBlocking();
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EntityCardScriptSwapTraits
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class EntityCardScriptSwapTraits : EntityCardScript
  {
    protected TraitData traitA;
    protected TraitData traitB;

    public override IEnumerator Run(Entity target, int _)
    {
      int origStackA = 0;
      int origStackB = 0;
      foreach (Entity.TraitStacks stacks in target.traits)
      {
        if (stacks.data.name == this.traitA.name)
        {
          origStackA = stacks.count - stacks.tempCount;
          stacks.count -= origStackA;
        }
        if (stacks.data.name == this.traitB.name)
        {
          origStackB = stacks.count - stacks.tempCount;
          stacks.count -= origStackB;
        }
      }
      target.GainTrait(this.traitA, origStackB);
      target.GainTrait(this.traitB, origStackA);
      yield return (object) target.UpdateTraits();
    }

    public static EntityCardScriptSwapTraits Create(TraitData traitA, TraitData traitB)
    {
      EntityCardScriptSwapTraits instance = ScriptableObject.CreateInstance<EntityCardScriptSwapTraits>();
      instance.traitA = traitA;
      instance.traitB = traitB;
      return instance;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.AppendFinalBossGeneration
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (FinalBossGenerationSettings), "Process")]
  internal class AppendFinalBossGeneration
  {
    private static string[] traitsToRemove = new string[4]
    {
      "Pickup",
      "Synchronize",
      "Synchronize2",
      "Salvage"
    };

    internal static void Prefix(FinalBossGenerationSettings __instance)
    {
      foreach (FinalBossEffectSwapper effectSwapper in __instance.effectSwappers)
      {
        if (effectSwapper.effect.name.Contains("Buff Card In Deck On Kill"))
          return;
      }
      AppendFinalBossGeneration.AddTraits(__instance);
      AppendFinalBossGeneration.AddEffectSwappers(__instance);
      AppendFinalBossGeneration.AddScripts(__instance);
    }

    internal static void AddTraits(FinalBossGenerationSettings __instance)
    {
      __instance.ignoreTraits = __instance.ignoreTraits.AddRangeToArray<TraitData>(((IEnumerable<string>) AppendFinalBossGeneration.traitsToRemove).Select<string, TraitData>((Func<string, TraitData>) (s => Pokefrost.Pokefrost.instance.TryGet<TraitData>(s))).ToArray<TraitData>());
    }

    internal static void AddEffectSwappers(FinalBossGenerationSettings __instance)
    {
      List<FinalBossEffectSwapper> bossEffectSwapperList = new List<FinalBossEffectSwapper>()
      {
        AppendFinalBossGeneration.CreateSwapper("While Active Frenzy To Crown Allies", "While Active Frenzy To Allies"),
        AppendFinalBossGeneration.CreateSwapper("Give Thick Club", "On Card Played Buff Marowak", maxBoost: 1),
        AppendFinalBossGeneration.CreateSwapper("While Active Increase Effects To Hand", "Ongoing Increase Effects"),
        AppendFinalBossGeneration.CreateSwapper("Give Slowking Crown"),
        AppendFinalBossGeneration.CreateSwapper("Give Combo to Card in Hand", "On Turn Apply Attack To Self", maxBoost: 1),
        AppendFinalBossGeneration.CreateSwapper("Discard Rightmost Button"),
        AppendFinalBossGeneration.CreateSwapper("When Deployed Sketch", attackOption: "Null"),
        AppendFinalBossGeneration.CreateSwapper("Trigger All Button", "When Destroyed Trigger To Allies"),
        AppendFinalBossGeneration.CreateSwapper("Trigger All Listener_1"),
        AppendFinalBossGeneration.CreateSwapper("When Ally Summoned Add Skull To Hand"),
        AppendFinalBossGeneration.CreateSwapper("Trigger When Summon", "Trigger When Card Destroyed"),
        AppendFinalBossGeneration.CreateSwapper("On Hit Snowed Target Double Attack Otherwise Half", attackOption: "Snow", minBoost: 1, maxBoost: 2),
        AppendFinalBossGeneration.CreateSwapper("Buff Card In Deck On Kill", "On Turn Apply Attack To Self", minBoost: 1, maxBoost: 3),
        AppendFinalBossGeneration.CreateSwapper("Trigger Clunker Ahead", "On Turn Apply Scrap To RandomAlly"),
        AppendFinalBossGeneration.CreateSwapper("On Card Played Increase Attack Of Cards In Hand", "While Active Increase Attack To Allies"),
        AppendFinalBossGeneration.CreateSwapper("When Hit Add Scrap Pile To Hand", "On Turn Apply Scrap To RandomAlly"),
        AppendFinalBossGeneration.CreateSwapper("End of Turn Draw a Card", "When Hit Add Junk To Hand"),
        AppendFinalBossGeneration.CreateSwapper("While Active It Is Overshroom", attackOption: "Overload", minBoost: 4, maxBoost: 4),
        AppendFinalBossGeneration.CreateSwapper("Gain Frenzy When Companion Is Killed", "MultiHit", minBoost: 2, maxBoost: 3),
        AppendFinalBossGeneration.CreateSwapper("Revive", "Heal Self", minBoost: 3, maxBoost: 5),
        AppendFinalBossGeneration.CreateSwapper("Rest Button", "Heal Self", minBoost: 3, maxBoost: 5),
        AppendFinalBossGeneration.CreateSwapper("Rest Listener_1"),
        AppendFinalBossGeneration.CreateSwapper("Redraw Cards", "Trigger When Redraw Hit"),
        AppendFinalBossGeneration.CreateSwapper("Add Tar Blade Button"),
        AppendFinalBossGeneration.CreateSwapper("Tar Shot Listener_1"),
        AppendFinalBossGeneration.CreateSwapper("Bonus Damage Equal To Darts In Hand", "Deal Bonus Damage Equal To Cards In Hand"),
        AppendFinalBossGeneration.CreateSwapper("Convert Spice To Burning To Front Enemy"),
        AppendFinalBossGeneration.CreateSwapper("Autotomize Button"),
        AppendFinalBossGeneration.CreateSwapper("While Active Unlimited Lumin", "Apply Lumin To Random Ally"),
        AppendFinalBossGeneration.CreateSwapper("On Turn Trigger Allies In Hand"),
        AppendFinalBossGeneration.CreateSwapper("Gain Hero On Recall", "Temporary Hero"),
        AppendFinalBossGeneration.CreateSwapper("Maybe Make Front Enemy Retreat", "On Card Played Return Front Enemy To Hand"),
        AppendFinalBossGeneration.CreateSwapper("On Turn Return Prophesized Card To Hand", "Deal Damage To All Enemies", minBoost: 39, maxBoost: 59),
        AppendFinalBossGeneration.CreateSwapper("When Prophesized Card Played Give Allies Attack")
      };
      __instance.effectSwappers = ((IEnumerable<FinalBossEffectSwapper>) __instance.effectSwappers.AddRangeToArray<FinalBossEffectSwapper>(bossEffectSwapperList.ToArray())).ToArray<FinalBossEffectSwapper>();
    }

    internal static FinalBossEffectSwapper CreateSwapper(
      string effect,
      string replaceOption = null,
      string attackOption = null,
      int minBoost = 0,
      int maxBoost = 0)
    {
      FinalBossEffectSwapper instance = ScriptableObject.CreateInstance<FinalBossEffectSwapper>();
      instance.effect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(effect);
      instance.name = instance.effect.name;
      instance.replaceWithOptions = new StatusEffectData[0];
      if (!replaceOption.IsNullOrEmpty())
        instance.replaceWithOptions = ((IEnumerable<StatusEffectData>) instance.replaceWithOptions).Append<StatusEffectData>(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(replaceOption)).ToArray<StatusEffectData>();
      if (!attackOption.IsNullOrEmpty())
        instance.replaceWithAttackEffect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(attackOption);
      instance.boostRange = new Vector2Int(minBoost, maxBoost);
      return instance;
    }

    private static void AddScripts(FinalBossGenerationSettings __instance)
    {
      FinalBossCardModifier[] items = new FinalBossCardModifier[6]
      {
        AppendFinalBossGeneration.CreateCardModifier("ambipom", (CardScript) AppendFinalBossGeneration.TraitScript("Trash", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("gardevoir", (CardScript) AppendFinalBossGeneration.PassiveScript("Copy Effects Applied To Front Enemy", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("gallade", (CardScript) AppendFinalBossGeneration.PassiveScript("Copy Effects Applied To Front Enemy", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("cresselia", (CardScript) AppendFinalBossGeneration.PassiveScript("Trigger When Dream Card Played", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("xatu", (CardScript) AppendFinalBossGeneration.CounterScript(10, 10)),
        AppendFinalBossGeneration.CreateCardModifier("ludicolo", (CardScript) AppendFinalBossGeneration.CounterScript(5, 5))
      };
      __instance.cardModifiers = __instance.cardModifiers.AddRangeToArray<FinalBossCardModifier>(items);
    }

    private static FinalBossCardModifier CreateCardModifier(
      string name,
      params CardScript[] scripts)
    {
      FinalBossCardModifier instance = ScriptableObject.CreateInstance<FinalBossCardModifier>();
      instance.name = name;
      instance.card = Pokefrost.Pokefrost.instance.TryGet<CardData>(name);
      instance.runAll = scripts;
      return instance;
    }

    private static CardScriptAddPassiveEffect PassiveScript(string name, int min, int max)
    {
      CardScriptAddPassiveEffect instance = ScriptableObject.CreateInstance<CardScriptAddPassiveEffect>();
      instance.name = "Add Passive: " + name;
      instance.effect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(name);
      instance.countRange = new Vector2Int(min, max);
      return instance;
    }

    private static CardScriptAddAttackEffect AttackScript(string name, int min, int max)
    {
      CardScriptAddAttackEffect instance = ScriptableObject.CreateInstance<CardScriptAddAttackEffect>();
      instance.name = "Add Attack Effect: " + name;
      instance.effect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(name);
      instance.countRange = new Vector2Int(min, max);
      return instance;
    }

    private static CardScriptAddTrait TraitScript(string name, int min, int max)
    {
      CardScriptAddTrait instance = ScriptableObject.CreateInstance<CardScriptAddTrait>();
      instance.name = "Add Trait: " + name;
      instance.trait = Pokefrost.Pokefrost.instance.TryGet<TraitData>(name);
      instance.countRange = new Vector2Int(min, max);
      return instance;
    }

    private static CardScriptSetCounter CounterScript(int min, int max)
    {
      CardScriptSetCounter instance = ScriptableObject.CreateInstance<CardScriptSetCounter>();
      instance.name = "Counter to " + min.ToString() + "-" + max.ToString();
      instance.counterRange = new Vector2Int(min, max);
      return instance;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptableCursesInHand
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;

#nullable disable
namespace Pokefrost
{
  internal class ScriptableCursesInHand : ScriptableAmount
  {
    public override int Get(Entity entity)
    {
      if (!(bool) (UnityEngine.Object) entity)
        return 0;
      int num = 0;
      foreach (Entity entity1 in References.Player.handContainer)
      {
        foreach (StatusEffectData statusEffect in entity1.statusEffects)
        {
          if (statusEffect.type == "paracurse" || statusEffect.type == "weakcurse" || statusEffect.type == "powercurse" || statusEffect.type == "frenzycurse")
          {
            num += (1 + entity.effectBonus) * (int) Math.Round((double) entity.effectFactor);
            break;
          }
        }
      }
      return num;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveCrown
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveCrown : StatusEffectEvolve
  {
    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
    }

    public override bool ReadyToEvolve(CardData cardData) => cardData.HasCrown;
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonLastRecycled
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonLastRecycled : StatusEffectInstantSummon
  {
    public override IEnumerator Process()
    {
      if ((Object) StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed != (Object) null)
      {
        this.targetSummon.summonCard = StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed;
        StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed = (CardData) null;
        yield return (object) base.Process();
      }
      else
        yield return (object) this.Remove();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.GiveZoomlinModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class GiveZoomlinModifierSystem : GameSystem
  {
    private TargetConstraint[] targetConstraints = Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Temporary Zoomlin").targetConstraints;

    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Zoomin);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Zoomin);
    }

    private void Zoomin(RedrawBellSystem arg0) => this.StartCoroutine(this.DumbWait());

    public IEnumerator DumbWait()
    {
      yield return (object) new WaitUntil((Func<bool>) (() => ActionQueue.Empty));
      ActionQueue.Add((PlayAction) new ActionSequence(this.GiveZoomlin()));
    }

    public IEnumerator GiveZoomlin()
    {
      List<Entity> list = References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (e =>
      {
        foreach (TargetConstraint targetConstraint in this.targetConstraints)
        {
          if (!targetConstraint.Check(e))
            return false;
        }
        return true;
      })).ToList<Entity>();
      if (list.Count != 0)
      {
        Entity rando = list.RandomItem<Entity>();
        yield return (object) StatusEffectSystem.Apply(rando, (Entity) null, Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Temporary Zoomlin"), 1);
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusTokenApplyX
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  public class StatusTokenApplyX : StatusEffectApplyX, IStatusToken
  {
    public static readonly string Key_Snowed = "websiteofsites.wildfrost.pokefrost.buttonSnowed";
    public static readonly string Key_Inked = "websiteofsites.wildfrost.pokefrost.buttonInked";
    public static readonly string Key_Generic = "websiteofsites.wildfrost.pokefrost.buttonGeneric";
    public static readonly string Key_Autotomize = "websiteofsites.wildfrost.pokefrost.buttonAutotomize";
    public string genericPopup;
    public StatusTokenApplyX.PlayFromFlags playFrom = StatusTokenApplyX.PlayFromFlags.Board;
    public bool finiteUses = false;
    public bool oncePerTurn = false;
    protected bool unusedThisTurn = true;
    public bool endTurn = false;
    public float timing = 0.2f;
    public TargetConstraint[] clickConstraints = new TargetConstraint[0];
    public int fixedAmount = 0;
    public int hitDamage = 0;

    [PokeLocalizer]
    public static void DefineStrings()
    {
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(StatusTokenApplyX.Key_Snowed, "Snowed!");
      collection.SetString(StatusTokenApplyX.Key_Inked, "Inked!");
      collection.SetString(StatusTokenApplyX.Key_Generic, "Not yet!");
      collection.SetString(StatusTokenApplyX.Key_Autotomize, "Please recycle!");
    }

    public override void Init() => base.Init();

    public override bool RunTurnStartEvent(Entity entity)
    {
      if (entity.data.cardType.name == "Leader")
        this.unusedThisTurn = true;
      return base.RunTurnStartEvent(entity);
    }

    public virtual void RunButtonClicked()
    {
      if ((UnityEngine.Object) References.Battle == (UnityEngine.Object) null)
        return;
      if (this.target.IsSnowed)
        this.PopupText(StatusTokenApplyX.Key_Snowed);
      else if (this.target.silenced)
      {
        this.PopupText(StatusTokenApplyX.Key_Inked);
      }
      else
      {
        foreach (TargetConstraint clickConstraint in this.clickConstraints)
        {
          if (!clickConstraint.Check(this.target))
          {
            this.PopupText(this.genericPopup ?? StatusTokenApplyX.Key_Generic);
            return;
          }
        }
        if (References.Battle.phase != Battle.Phase.Play || !this.CorrectPlace() || this.target.IsSnowed || !((UnityEngine.Object) this.target.owner == (UnityEngine.Object) References.Player) || this.target.silenced || this.oncePerTurn && !this.unusedThisTurn)
          return;
        this.target.StartCoroutine(this.ButtonClicked());
        this.unusedThisTurn = false;
      }
    }

    public virtual void PopupText(string s)
    {
      NoTargetTextSystem objectOfType = UnityEngine.Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((UnityEngine.Object) objectOfType != (UnityEngine.Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(this.target.transform.position);
    }

    public bool CheckFlag(StatusTokenApplyX.PlayFromFlags flag) => (this.playFrom & flag) != 0;

    public virtual bool CorrectPlace()
    {
      return this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Board) && Battle.IsOnBoard(this.target) || this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Hand) && References.Player.handContainer.Contains(this.target) || this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Draw) && this.target.preContainers.Contains<CardContainer>(References.Player.drawContainer) || this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Discard) && this.target.preContainers.Contains<CardContainer>(References.Player.discardContainer);
    }

    public IEnumerator ButtonClicked()
    {
      if (this.hitDamage != 0)
      {
        List<Entity> enemies = this.GetTargets();
        int trueAmount = this.hitDamage == -1 ? this.count : this.hitDamage;
        foreach (Entity enemy in enemies)
        {
          if (enemy.IsAliveAndExists())
          {
            Hit hit = new Hit(this.target, enemy, trueAmount);
            hit.canRetaliate = false;
            yield return (object) hit.Process();
            hit = (Hit) null;
          }
        }
        enemies = (List<Entity>) null;
      }
      yield return (object) this.Run(this.GetTargets(), this.fixedAmount);
      List<StatusTokenApplyXListener> listeners = this.FindListeners();
      foreach (StatusTokenApplyXListener listener in listeners)
        yield return (object) listener.Run();
      this.target.display.promptUpdateDescription = true;
      yield return (object) this.PostClick();
    }

    public List<StatusTokenApplyXListener> FindListeners()
    {
      List<StatusTokenApplyXListener> listeners = new List<StatusTokenApplyXListener>();
      foreach (StatusEffectData statusEffect in this.target.statusEffects)
      {
        if (statusEffect is StatusTokenApplyXListener tokenApplyXlistener && tokenApplyXlistener.type == this.type + "_listener")
          listeners.Add(tokenApplyXlistener);
      }
      return listeners;
    }

    public virtual IEnumerator PostClick()
    {
      if (this.finiteUses)
      {
        --this.count;
        if (this.count == 0)
          yield return (object) this.Remove();
        this.target.promptUpdate = true;
      }
      if (this.endTurn)
      {
        yield return (object) Sequences.Wait(this.timing);
        References.Player.endTurn = true;
      }
    }

    public void ButtonCreate(StatusIconExt icon)
    {
    }

    [Flags]
    public enum PlayFromFlags
    {
      None = 0,
      Board = 1,
      Hand = 2,
      Draw = 4,
      Discard = 8,
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EntityCardScriptReturnProphCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Pokefrost
{
  public class EntityCardScriptReturnProphCard : EntityCardScript
  {
    public override IEnumerator Run(Entity entity, int stack)
    {
      string name = this.ProphCard(entity);
      List<Entity> targets = References.Player.discardContainer.entities.Clone<Entity>();
      targets.AddRange((IEnumerable<Entity>) References.Player.drawContainer);
      for (int i = targets.Count - 1; i >= 0; --i)
      {
        if (targets[i].data.name == name)
        {
          yield return (object) Sequences.CardMove(targets[i], new CardContainer[1]
          {
            References.Player.handContainer
          });
          if (--stack <= 0)
            break;
        }
        ActionQueue.Stack((PlayAction) new ActionRevealAll(new CardContainer[1]
        {
          References.Player.handContainer
        }));
      }
    }

    public string ProphCard(Entity entity)
    {
      string str;
      entity.data.TryGetCustomData<string>("Future Sight", out str, "");
      return str;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptableNegativeHalfAttack
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class ScriptableNegativeHalfAttack : ScriptableAmount
  {
    public override int Get(Entity entity)
    {
      return !(bool) (Object) entity ? 0 : -Mathf.FloorToInt((float) ((entity.damage.current + entity.tempDamage.Value) / 2));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonLuminPart
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonLuminPart : StatusEffectInstantSummon
  {
    public CardData card1;
    public CardData card2;

    public override IEnumerator Process()
    {
      List<Entity> entityList = new List<Entity>();
      entityList.AddRange((IEnumerable<Entity>) References.Player.handContainer.ToList<Entity>());
      entityList.AddRange((IEnumerable<Entity>) References.Player.drawContainer.ToList<Entity>());
      entityList.AddRange((IEnumerable<Entity>) References.Player.discardContainer.ToList<Entity>());
      Debug.Log((object) "[Pokefrost] Checking deck");
      foreach (Entity entity in entityList)
      {
        if (entity.data.name == this.card1.name)
        {
          this.targetSummon.summonCard = this.card2;
          break;
        }
        if (entity.data.name == this.card2.name)
        {
          this.targetSummon.summonCard = this.card1;
          break;
        }
      }
      return base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.GiveDreamCardModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class GiveDreamCardModifierSystem : GameSystem
  {
    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Dream);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Dream);
    }

    private void Dream(RedrawBellSystem arg0) => this.StartCoroutine(this.DumbWait());

    public IEnumerator DumbWait()
    {
      yield return (object) new WaitUntil((Func<bool>) (() => ActionQueue.Empty));
      ActionQueue.Add((PlayAction) new ActionSequence(this.GainDream()));
    }

    public IEnumerator GainDream()
    {
      List<Entity> list = References.Player.handContainer.ToList<Entity>();
      if (list.Count != 0)
      {
        Entity rando = list.RandomItem<Entity>();
        Debug.Log((object) ("[Pokefrost] " + rando.name));
        yield return (object) StatusEffectSystem.Apply(rando, rando, Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Instant Summon Dream Base In Hand"), 2);
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusTokenApplyXListener
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusTokenApplyXListener : StatusEffectApplyX
  {
    public IEnumerator Run()
    {
      yield return (object) this.Run(this.GetTargets());
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.LeaderScripts
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class LeaderScripts
  {
    public static CardScript GiveUpgrade(string name = "Crown")
    {
      CardScriptGiveUpgrade instance = ScriptableObject.CreateInstance<CardScriptGiveUpgrade>();
      instance.name = "Give " + name;
      instance.upgradeData = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>(name);
      return (CardScript) instance;
    }

    public static CardScript AddRandomHealth(int min, int max)
    {
      CardScriptAddRandomHealth instance = ScriptableObject.CreateInstance<CardScriptAddRandomHealth>();
      instance.name = "Random Health";
      instance.healthRange = new Vector2Int(min, max);
      return (CardScript) instance;
    }

    public static CardScript AddRandomDamage(int min, int max)
    {
      CardScriptAddRandomDamage instance = ScriptableObject.CreateInstance<CardScriptAddRandomDamage>();
      instance.name = "Give Damage";
      instance.damageRange = new Vector2Int(min, max);
      return (CardScript) instance;
    }

    public static CardScript AddRandomCounter(int min, int max)
    {
      CardScriptAddRandomCounter instance = ScriptableObject.CreateInstance<CardScriptAddRandomCounter>();
      instance.name = "Give Counter";
      instance.counterRange = new Vector2Int(min, max);
      return (CardScript) instance;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetConstraintHasLastRecycled
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class TargetConstraintHasLastRecycled : TargetConstraint
  {
    public override bool Check(CardData targetData)
    {
      return Campaign.FindCharacterNode(References.Player).id == StatusEffectAllCardsAreRecycled.PatchRecycle.node && (bool) (Object) StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed;
    }

    public override bool Check(Entity target) => this.Check(target.data);
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonReserve
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonReserve : StatusEffectInstantSummon
  {
    public static List<CardData> reserve;
    public static int node_id = -1;
    public static readonly string Key_ReserveEmpty = "websiteofsites.wildfrost.pokefrost.reserveEmpty";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectInstantSummonReserve.Key_ReserveEmpty, "No More in Reserve!");
    }

    public override void Init()
    {
      if (Campaign.FindCharacterNode(References.Player).id != StatusEffectInstantSummonReserve.node_id)
      {
        StatusEffectInstantSummonReserve.reserve = References.Player.data.inventory.reserve.Clone<CardData>();
        StatusEffectInstantSummonReserve.node_id = Campaign.FindCharacterNode(References.Player).id;
      }
      base.Init();
    }

    public UnityAction GetReserve()
    {
      CardDataList reserve = References.Player.data.inventory.reserve;
      return (UnityAction) null;
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public override IEnumerator Process()
    {
      Debug.Log((object) "[Pokefrost] Process Reserve");
      if (StatusEffectInstantSummonReserve.reserve.Count<CardData>() > 0)
      {
        int index = Dead.Random.Range(0, StatusEffectInstantSummonReserve.reserve.Count<CardData>() - 1);
        CardData cardData = StatusEffectInstantSummonReserve.reserve[index];
        Debug.Log((object) ("[Pokefrost] Found card " + cardData.name));
        if ((Object) cardData != (Object) null)
        {
          this.targetSummon.summonCard = cardData;
          if (this.CanSummon(out CardContainer _, out Dictionary<Entity, List<CardSlot>> _))
            StatusEffectInstantSummonReserve.reserve.RemoveAt(index);
        }
        return base.Process();
      }
      Debug.Log((object) "[Pokefrost] No Card Found");
      this.PopupText(this.target, StatusEffectInstantSummonReserve.Key_ReserveEmpty);
      return this.Remove();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EarlyBellDrawModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class EarlyBellDrawModifierSystem : GameSystem
  {
    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Draw);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Draw);
    }

    private void Draw(RedrawBellSystem arg0)
    {
      if (arg0.counter.current == 0)
        return;
      ActionQueue.Add((PlayAction) new ActionRedraw(arg0.owner, 3));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CardScriptCopy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class CardScriptCopy : CardScript
  {
    public static float waitTime = 1f;

    public override void Run(CardData target)
    {
      CardData data = target.Clone(false);
      data.upgrades.RemoveAll((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown));
      References.Player.data.inventory.deck.Add(data);
      MonoBehaviourSingleton<References>.instance.StartCoroutine(this.Animation(CardManager.Get(data, (CardController) UnityEngine.Object.FindObjectOfType<CardControllerDeck>(), References.Player, false, true)));
    }

    public IEnumerator Animation(Card card)
    {
      yield return (object) new WaitForSeconds(CardScriptCopy.waitTime);
      yield return (object) card.UpdateData(false);
      Entity entity = card.entity;
      CardContainerGrid[] cardContainerGridArray = UnityEngine.Object.FindObjectsOfType<CardContainerGrid>();
      for (int index = 0; index < cardContainerGridArray.Length; ++index)
      {
        CardContainerGrid cardGrid = cardContainerGridArray[index];
        if (cardGrid.name == "ItemGrid")
          cardGrid.Add(entity);
        cardGrid = (CardContainerGrid) null;
      }
      cardContainerGridArray = (CardContainerGrid[]) null;
      UnityEngine.Object.FindObjectOfType<DeckDisplaySequence>()?.UpdatePositions();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetConstraintHasSlowkingCrown
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;

#nullable disable
namespace Pokefrost
{
  public class TargetConstraintHasSlowkingCrown : TargetConstraint
  {
    public override bool Check(Entity target) => this.Check(target.data);

    public override bool Check(CardData targetData)
    {
      return !((UnityEngine.Object) targetData.upgrades.Find((Predicate<CardUpgradeData>) (a => a.name == "websiteofsites.wildfrost.pokefrost.CrownSlowking")) != (UnityEngine.Object) null) ? this.not : !this.not;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.DestoryCardSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class DestoryCardSystem : GameSystem
  {
    private Entity target;

    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.DestoryCard);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.DestoryCard);
    }

    private void DestoryCard(RedrawBellSystem arg0)
    {
      CardContainer handContainer = References.Player.handContainer;
      if (handContainer == null || handContainer.Count <= 0)
        return;
      this.target = References.Player.handContainer[0];
      if ((Object) this.target != (Object) null)
        ActionQueue.Add((PlayAction) new ActionKill(this.target));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetConstraintHasNegativeStatus
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class TargetConstraintHasNegativeStatus : TargetConstraint
  {
    public override bool Check(Entity target)
    {
      return !target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.IsNegativeStatusEffect())) ? this.not : !this.not;
    }

    public override bool Check(CardData targetData)
    {
      bool flag = false;
      foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
      {
        if (startWithEffect.data.IsNegativeStatusEffect())
        {
          flag = true;
          break;
        }
      }
      return !this.not ? flag : !flag;
    }

    public bool CheckWillApply(Hit hit)
    {
      bool flag = false;
      List<CardData.StatusEffectStacks> statusEffects = hit.statusEffects;
      if (statusEffects != null && statusEffects.Count > 0)
      {
        foreach (CardData.StatusEffectStacks statusEffect in hit.statusEffects)
        {
          if (statusEffect.data.IsNegativeStatusEffect())
          {
            flag = true;
            break;
          }
        }
      }
      return !this.not ? flag : !flag;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.RecallToTopModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class RecallToTopModifierSystem : GameSystem
  {
    public RecallToTopModifierSystem.Container toContainer = RecallToTopModifierSystem.Container.Hand;

    public void OnEnable()
    {
      global::Events.OnActionQueued += new UnityAction<PlayAction>(this.EntityDiscard);
    }

    public void OnDisable()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.EntityDiscard);
    }

    public void EntityDiscard(PlayAction action)
    {
      if (!(action is ActionMove actionMove) || !actionMove.toContainers.Contains<CardContainer>(References.Player.discardContainer) || !Battle.IsOnBoard(actionMove.entity.containers))
        return;
      Debug.Log((object) ("[Pokefrost] " + actionMove.entity.containers.ToString()));
      this.StartCoroutine(this.PutOnTop(actionMove.entity));
    }

    private IEnumerator PutOnTop(Entity target)
    {
      Debug.Log((object) "[Pokefrost] Here!");
      yield return (object) new WaitUntil((Func<bool>) (() => ActionQueue.Empty));
      CardContainer cc = References.Player.drawContainer;
      int index1 = cc.Count;
      CardPocketSequence sequence = UnityEngine.Object.FindObjectOfType<CardPocketSequence>();
      CardPocketSequence.Card card = (CardPocketSequence.Card) null;
      if ((UnityEngine.Object) sequence != (UnityEngine.Object) null)
      {
        int i = 0;
        while (sequence.cards.Count > 0)
        {
          if ((UnityEngine.Object) sequence.cards[i].entity == (UnityEngine.Object) target)
          {
            card = sequence.cards[i];
            target.transform.SetParent(MonoBehaviourSingleton<References>.instance.transform, true);
            sequence.cards.RemoveAt(i);
            break;
          }
          ++i;
        }
        sequence.promptEnd = true;
        yield return (object) new WaitUntil((Func<bool>) (() => !sequence.isActiveAndEnabled));
        card.Reset();
        card.Return();
        yield return (object) new WaitForSeconds(0.25f);
      }
      if (cc.Contains(target))
        --index1;
      yield return (object) Sequences.CardMove(target, new CardContainer[1]
      {
        cc
      }, index1);
      CardContainer[] cardContainerArray = target.preContainers;
      for (int index2 = 0; index2 < cardContainerArray.Length; ++index2)
      {
        CardContainer c = cardContainerArray[index2];
        c.TweenChildPositions();
        c = (CardContainer) null;
      }
      cardContainerArray = (CardContainer[]) null;
      if (!target.preContainers.Contains<CardContainer>(cc))
        cc.TweenChildPositions();
    }

    public enum Container
    {
      DrawPile,
      Hand,
      DiscardPile,
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetConstraintHeight
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class TargetConstraintHeight : TargetConstraint
  {
    private int height = 1;

    public override bool Check(Entity entity)
    {
      return entity.height == this.height ? !this.not : this.not;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptRunScriptsOnDeckAlt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class ScriptRunScriptsOnDeckAlt : Script
  {
    [SerializeField]
    public CardScript[] scripts;
    [SerializeField]
    public TargetConstraint[] constraints;
    [SerializeField]
    public Vector2Int countRange;
    [SerializeField]
    public bool includeReserve;

    public override IEnumerator Run()
    {
      List<CardData> list = new List<CardData>();
      ScriptRunScriptsOnDeckAlt.AddRangeIfConstraints((ICollection<CardData>) list, References.PlayerData.inventory.deck, this.constraints);
      if (this.includeReserve)
        ScriptRunScriptsOnDeckAlt.AddRangeIfConstraints((ICollection<CardData>) list, References.PlayerData.inventory.reserve, this.constraints);
      if (list.Count > 0)
      {
        this.Affect((IReadOnlyCollection<CardData>) list);
        yield break;
      }
    }

    public static void AddRangeIfConstraints(
      ICollection<CardData> collection,
      CardDataList toAdd,
      TargetConstraint[] constraints)
    {
      foreach (CardData cardData in toAdd)
        ScriptRunScriptsOnDeckAlt.AddIfConstraints(collection, cardData, constraints);
    }

    public static void AddIfConstraints(
      ICollection<CardData> collection,
      CardData item,
      TargetConstraint[] constraints)
    {
      if (((IEnumerable<TargetConstraint>) constraints).Any<TargetConstraint>((Func<TargetConstraint, bool>) (c => !c.Check(item))))
        return;
      collection.Add(item);
    }

    public void Affect(IReadOnlyCollection<CardData> cards)
    {
      int num = this.countRange.Random();
      Debug.Log((object) ("[" + this.name + "] Affecting [" + string.Join<CardData>(", ", (IEnumerable<CardData>) cards) + "]"));
      foreach (CardData target in (IEnumerable<CardData>) cards.InRandomOrder<CardData>())
      {
        foreach (CardScript script in this.scripts)
          script.Run(target);
        --num;
        if (num <= 0)
          break;
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.InitialBellCounterReductionModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class InitialBellCounterReductionModifierSystem : GameSystem
  {
    private Timer timer;
    private int preCounter;
    private bool active = false;

    public void OnEnable()
    {
      global::Events.OnBattleStart += new UnityAction(this.CreateTimer);
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleEnd += new UnityAction(this.HideTimer);
    }

    public void OnDisable()
    {
      global::Events.OnBattleStart -= new UnityAction(this.CreateTimer);
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleEnd -= new UnityAction(this.HideTimer);
      if (!(bool) (Object) this.timer)
        return;
      this.timer.End();
    }

    private void HideTimer()
    {
      if (!(bool) (Object) this.timer)
        return;
      this.timer.Hide();
    }

    private void StartTimer(int turn)
    {
      if (!(bool) (Object) this.timer || turn != 0)
        return;
      this.Activate();
    }

    private void CreateTimer()
    {
      if (!(bool) (Object) this.timer)
      {
        this.timer = Timer.Create(60f);
        this.timer.OnFinished += new UnityAction(this.Deactivate);
      }
      else
      {
        this.timer.SetTime(60f);
        this.timer.Show();
      }
    }

    public void Activate()
    {
      if (this.active)
        return;
      RedrawBellSystem objectOfType = Object.FindObjectOfType<RedrawBellSystem>();
      this.preCounter = objectOfType.counter.max;
      objectOfType.counter.max = 1;
      if (objectOfType.counter.current > 1)
      {
        objectOfType.counter.current = 1;
        objectOfType.SetCounter(objectOfType.counter.current);
      }
      this.timer.Play();
      this.active = true;
    }

    public void Deactivate()
    {
      if (!this.active)
        return;
      Object.FindObjectOfType<RedrawBellSystem>().counter.max = this.preCounter;
      Debug.Log((object) "[Pokefrost] Set max.");
      this.timer.Stop();
      this.timer.Hide();
      this.active = false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CountdownRedrawWhenLeaderIsHitModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class CountdownRedrawWhenLeaderIsHitModifierSystem : GameSystem
  {
    public void OnEnable() => global::Events.OnEntityPostHit += new UnityAction<Hit>(this.Countdown);

    public void OnDisable() => global::Events.OnEntityPostHit -= new UnityAction<Hit>(this.Countdown);

    private void Countdown(Hit hit)
    {
      if (hit == null || !hit.Offensive || !((UnityEngine.Object) hit.target != (UnityEngine.Object) null) || !(hit.target.data.cardType.name == "Leader") || !((UnityEngine.Object) hit.target.owner == (UnityEngine.Object) References.Player))
        return;
      RedrawBellSystem objectOfType = UnityEngine.Object.FindObjectOfType<RedrawBellSystem>();
      if ((UnityEngine.Object) objectOfType != (UnityEngine.Object) null)
        objectOfType.SetCounter(Math.Max(0, objectOfType.counter.current - 1));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.AddressableExtMethods
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using BattleEditor;
using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;

#nullable disable
namespace Pokefrost
{
  internal static class AddressableExtMethods
  {
    internal static SpriteAtlas Sprites;

    internal static void LoadAtlas()
    {
      if (!Addressables.ResourceLocators.Any<IResourceLocator>((Func<IResourceLocator, bool>) (r => r is ResourceLocationMap resourceLocationMap && resourceLocationMap.LocatorId == Pokefrost.Pokefrost.CatalogPath)))
        Addressables.LoadContentCatalogAsync(Pokefrost.Pokefrost.CatalogPath).WaitForCompletion();
      AddressableExtMethods.Sprites = (SpriteAtlas) Addressables.LoadAssetAsync<UnityEngine.Object>((object) "Assets/websiteofsites.pokefrost/PokefrostAtlas.spriteatlas").WaitForCompletion();
    }

    internal static Sprite SaferASprite(string spriteName)
    {
      Sprite sprite = AddressableExtMethods.ASprite(spriteName);
      if ((UnityEngine.Object) sprite == (UnityEngine.Object) null || sprite.texture.width < 10)
        sprite = Pokefrost.Pokefrost.instance.ImagePath(spriteName).ToSprite();
      return sprite;
    }

    internal static Sprite ASprite(string spriteName)
    {
      return AddressableExtMethods.Sprites.GetSprite(spriteName.Replace(".png", ""));
    }

    internal static CardDataBuilder SetASprites(
      this CardDataBuilder b,
      string mainImage,
      string backgroundImage)
    {
      return b.SetSprites(AddressableExtMethods.ASprite(mainImage), AddressableExtMethods.ASprite(backgroundImage));
    }

    internal static CardUpgradeDataBuilder WithAImage(this CardUpgradeDataBuilder b, string image)
    {
      return b.WithImage(AddressableExtMethods.ASprite(image));
    }

    internal static GameModifierDataBuilder ChangeASprites(
      this GameModifierDataBuilder b,
      string bell,
      string dinger)
    {
      b.WithBellSprite(AddressableExtMethods.ASprite(bell));
      if (!dinger.IsNullOrEmpty())
        b.WithDingerSprite(AddressableExtMethods.ASprite(dinger));
      else
        b.WithDingerSprite(Sprite.Create(b._data.bellSprite.texture, new Rect(0.0f, 0.0f, 0.0f, 0.0f), 0.5f * Vector2.one));
      return b.WithBellSprite(AddressableExtMethods.ASprite(bell));
    }

    internal static BattleDataEditor SetASprite(this BattleDataEditor b, string sprite)
    {
      return b.SetSprite(AddressableExtMethods.ASprite(sprite));
    }
  }
}
﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;

[assembly: Extension]
[assembly: AssemblyTitle("Pokefrost")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Pokefrost")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("56fae09f-692b-4a5b-a952-70610df1ef79")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.BattleDataWithRewards
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class BattleDataWithRewards : BattleData
  {
    public List<BossRewardData.Data>[] dataGroups;
    public int canTake = 2;
    public int bonusPulls = 0;
    public List<int> minPulls;
    public List<int> bonusProfile;

    public virtual void AddRewards(CampaignNode node)
    {
      List<BossRewardData.Data> dataList = new List<BossRewardData.Data>();
      List<int> profile = this.DetermineProfile();
      for (int index = 0; index < this.dataGroups.Length; ++index)
        dataList.AddRange(this.dataGroups[index].InRandomOrder<BossRewardData.Data>().Take<BossRewardData.Data>(profile[index]));
      node.data.Add("rewards", (object) new CampaignNodeTypeBoss.RewardData()
      {
        rewards = dataList,
        canTake = this.canTake
      });
    }

    public virtual List<int> DetermineProfile()
    {
      List<int> profile = this.minPulls != null ? this.minPulls.Clone<int>() : this.DefaultMinPulls();
      if (this.bonusPulls > 0 && this.bonusProfile != null)
      {
        int maxInclusive = 0;
        foreach (int num in this.bonusProfile)
          maxInclusive += num;
        int bonusPulls = this.bonusPulls;
        while (bonusPulls > 0)
        {
          int num = Dead.Random.Range(1, maxInclusive);
          for (int index = 0; index < this.bonusProfile.Count; ++index)
          {
            num -= this.bonusProfile[index];
            if (num <= 0)
            {
              profile[index]++;
              --bonusPulls;
              break;
            }
          }
        }
      }
      return profile;
    }

    public List<int> DefaultMinPulls()
    {
      return ((IEnumerable<List<BossRewardData.Data>>) this.dataGroups).Select<List<BossRewardData.Data>, int>((Func<List<BossRewardData.Data>, int>) (g => 1)).ToList<int>();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.BattleGenerationScriptHooh
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class BattleGenerationScriptHooh : BattleGenerationScript
  {
    public override SaveCollection<BattleWaveManager.WaveData> Run(
      BattleData battleData,
      int points)
    {
      Debug.Log((object) string.Format("Creating Waves for [{0}]", (object) battleData));
      List<BattleWavePoolData> battleWavePoolDataList = new List<BattleWavePoolData>();
      int targetValue = Mathf.RoundToInt((float) points * battleData.pointFactor);
      Debug.Log((object) string.Format("Points: {0}", (object) targetValue));
      BattleGenerationScript.WaveList waves = new BattleGenerationScript.WaveList(targetValue);
      BattleWavePoolData[] array1 = ((IEnumerable<BattleWavePoolData>) battleData.pools).Select<BattleWavePoolData, BattleWavePoolData>((Func<BattleWavePoolData, BattleWavePoolData>) (p => p.InstantiateKeepName<BattleWavePoolData>())).ToArray<BattleWavePoolData>();
      BattleWavePoolData.Wave wave1 = array1[0].Pull();
      Dead.Random.Range(0, array1[1].waves.Length);
      BattleWavePoolData[] array2 = ((IEnumerable<BattleWavePoolData>) array1).Skip<BattleWavePoolData>(1).ToArray<BattleWavePoolData>();
      for (int index = 0; index < 3; ++index)
        waves.Add(this.Concat(((IEnumerable<BattleWavePoolData>) array2).Select<BattleWavePoolData, BattleWavePoolData.Wave>((Func<BattleWavePoolData, BattleWavePoolData.Wave>) (p => p.Pull())).ToArray<BattleWavePoolData.Wave>()));
      waves.AddUnit(0, wave1.units[0]);
      this.AddBonusUnits(waves, battleData);
      List<BattleWaveManager.WaveData> collection = new List<BattleWaveManager.WaveData>();
      int count = waves.Count;
      for (int waveIndex = 0; waveIndex < count; ++waveIndex)
      {
        BattleWaveManager.WaveDataBasic waveDataBasic1 = new BattleWaveManager.WaveDataBasic();
        waveDataBasic1.counter = battleData.waveCounter;
        BattleWaveManager.WaveDataBasic waveDataBasic2 = waveDataBasic1;
        BattleWavePoolData.Wave wave2 = waves.GetWave(waveIndex);
        List<string> source = new List<string>();
        foreach (CardData unit in wave2.units)
        {
          source.Add(unit.name);
          if (!waveDataBasic2.isBossWave && unit.cardType.miniboss)
            waveDataBasic2.isBossWave = true;
        }
        waveDataBasic2.cards = source.Select<string, BattleWaveManager.Card>((Func<string, BattleWaveManager.Card>) (a => new BattleWaveManager.Card(a))).ToArray<BattleWaveManager.Card>();
        collection.Add((BattleWaveManager.WaveData) waveDataBasic2);
      }
      return new SaveCollection<BattleWaveManager.WaveData>(collection);
    }

    public BattleWavePoolData.Wave Concat(params BattleWavePoolData.Wave[] waves)
    {
      BattleWavePoolData.Wave wave = new BattleWavePoolData.Wave();
      wave.units = new List<CardData>(6);
      for (int index = 0; index < waves.Length; ++index)
      {
        wave.units.AddRange((IEnumerable<CardData>) waves[index].units);
        wave.value += waves[index].value;
        wave.positionPriority = Math.Max(wave.positionPriority, waves[index].positionPriority);
        wave.fixedOrder = true;
        wave.maxSize += waves[index].maxSize;
      }
      return wave;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.BounceJuiceModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class BounceJuiceModifierSystem : GameSystem
  {
    public void OnEnable()
    {
      StatusEffectSpicune.OnJuiceCleared += new UnityAction<Entity, int>(this.BounceJuice);
    }

    public void OnDisable()
    {
      StatusEffectSpicune.OnJuiceCleared -= new UnityAction<Entity, int>(this.BounceJuice);
    }

    private void BounceJuice(Entity entity, int amount)
    {
      if ((Object) Battle.instance == (Object) null)
        return;
      List<Entity> cards = Battle.GetCards(References.Player);
      TargetConstraintCanBeBoosted instance = ScriptableObject.CreateInstance<TargetConstraintCanBeBoosted>();
      foreach (Entity target in (IEnumerable<Entity>) cards.InRandomOrder<Entity>())
      {
        if (instance.Check(target) && (Object) target != (Object) entity)
        {
          ActionQueue.Stack((PlayAction) new ActionApplyStatus(target, (Entity) null, Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Spicune"), 1));
          break;
        }
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.BossRewardDataCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class BossRewardDataCard : BossRewardData
  {
    public static BossRewardDataCard.Data Example(string name = "spinda")
    {
      BossRewardDataCard.Data data = new BossRewardDataCard.Data();
      data.cardDataName = name;
      data.type = BossRewardData.Type.Crown;
      return data;
    }

    public override BossRewardData.Data Pull()
    {
      BossRewardDataCard.Data data = new BossRewardDataCard.Data();
      data.type = BossRewardData.Type.Crown;
      return (BossRewardData.Data) data;
    }

    public new class Data : BossRewardData.Data
    {
      public string cardDataName;
      public Entity card;

      public CardData GetCardData() => Pokefrost.Pokefrost.instance.Get<CardData>(this.cardDataName);

      public override void Select()
      {
        References.PlayerData.inventory.deck.Add(this.card.data);
        this.MoveCardToDeck(this.card);
      }

      private void MoveCardToDeck(Entity entity)
      {
        global::Events.InvokeEntityEnterBackpack(entity);
        entity.transform.parent = References.Player.entity.display.transform;
        entity.display?.hover?.Disable();
        Routine routine = new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) entity));
      }
    }

    [HarmonyPatch(typeof (BossRewardSelectCrown), "SetUp")]
    private class PatchBossRewardCard
    {
      private static void Postfix(
        BossRewardSelectCrown __instance,
        BossRewardData.Data rewardData,
        GainBlessingSequence2 gainBlessingSequence)
      {
        BossRewardDataCard.Data data = rewardData as BossRewardDataCard.Data;
        if (data == null)
          return;
        __instance.crownImage.color = new Color(1f, 1f, 1f, 0.0f);
        CardData cardData = data.GetCardData().Clone();
        GameObject gameObject = __instance.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
        CardLane lane = gameObject.AddComponent<CardLane>();
        lane.holder = gameObject.GetComponent<RectTransform>();
        lane.onAdd = new UnityEventEntity();
        lane.onRemove = new UnityEventEntity();
        lane.SetSize(1, 0.7f);
        CardControllerSelectCard controllerSelectCard = gameObject.AddComponent<CardControllerSelectCard>();
        controllerSelectCard.pressEvent = new UnityEventEntity();
        controllerSelectCard.hoverEvent = new UnityEventEntity();
        controllerSelectCard.unHoverEvent = new UnityEventEntity();
        lane.AssignController((CardController) controllerSelectCard);
        __instance.popUpName = "{popUpName}";
        __instance.title = cardData.title;
        __instance.body = "Spin-da to Win-da!!";
        controllerSelectCard.pressEvent.AddListener((UnityAction<Entity>) (d =>
        {
          gainBlessingSequence.Select((BossRewardData.Data) data);
          __instance.StartCoroutine(BossRewardDataCard.PatchBossRewardCard.DelayDestroy(__instance));
        }));
        __instance.StartCoroutine(BossRewardDataCard.PatchBossRewardCard.SetUpEntity(lane, data, cardData, controllerSelectCard));
      }

      private static IEnumerator DelayDestroy(BossRewardSelectCrown __instance)
      {
        yield return (object) new WaitForSeconds(0.05f);
        __instance.UnPop();
        __instance.gameObject.SetActive(false);
      }

      private static IEnumerator SetUpEntity(
        CardLane lane,
        BossRewardDataCard.Data data,
        CardData cardData,
        CardControllerSelectCard cc)
      {
        Card card = CardManager.Get(cardData, (CardController) cc, References.Player, false, true);
        yield return (object) card.UpdateData(false);
        lane.Add(card.entity);
        data.card = card.entity;
        global::Events.InvokeEntityOffered(card.entity);
        lane.SetChildPositions();
        card.FlipUp();
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ButtonExt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public class ButtonExt : Button
  {
    internal static ButtonExt dragBlocker;

    internal StatusIconExt Icon => this.GetComponent<StatusIconExt>();

    internal Entity Entity => this.Icon?.target;

    public override void OnPointerEnter(PointerEventData eventData) => ButtonExt.dragBlocker = this;

    public override void OnPointerExit(PointerEventData eventData) => this.DisableDragBlocking();

    public void DisableDragBlocking()
    {
      if (!((Object) ButtonExt.dragBlocker == (Object) this))
        return;
      ButtonExt.dragBlocker = (ButtonExt) null;
    }

    public static void DisableDrag(ref Entity arg0, ref bool arg1)
    {
      if ((Object) ButtonExt.dragBlocker == (Object) null || (Object) arg0 != (Object) ButtonExt.dragBlocker.Entity)
        return;
      arg1 = false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CampaignNodeTypeTrade
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class CampaignNodeTypeTrade : CampaignNodeTypeEvent
  {
    public string key = "Trade";
    public static Dictionary<string, GameObject> Prefabs = new Dictionary<string, GameObject>();
    public int choices = 3;
    public int valueCap = 499;
    public List<CardData> force;
    public List<CardUpgradeData> upgrades;
    public int baseUpgradeAmount = 1;
    public int BonusUpgradePerArea = 1;

    public override IEnumerator SetUp(CampaignNode node)
    {
      Debug.Log((object) "[Trade]");
      List<CardData> list = CampaignNodeTypeTrade.ObtainCards(this.choices, this.valueCap);
      int upgradeAmount = (this.baseUpgradeAmount + this.BonusUpgradePerArea * node.areaIndex) * this.choices;
      List<CardUpgradeData> listCharm = CampaignNodeTypeTrade.ObtainCharms(upgradeAmount);
      node.data = new Dictionary<string, object>()
      {
        {
          "cards",
          (object) list.ToSaveCollectionOfNames<CardData>()
        },
        {
          "charms",
          (object) listCharm.ToSaveCollectionOfNames<CardUpgradeData>()
        }
      };
      yield break;
    }

    public override bool HasMissingData(CampaignNode node)
    {
      object obj1;
      if (!node.data.TryGetValue("cards", out obj1) || !(obj1 is SaveCollection<string> saveCollection1))
        return true;
      foreach (string assetName in saveCollection1.collection)
      {
        if ((UnityEngine.Object) AddressableLoader.Get<CardData>("CardData", assetName) == (UnityEngine.Object) null)
          return true;
      }
      object obj2;
      if (!node.data.TryGetValue("charms", out obj2) || !(obj2 is SaveCollection<string> saveCollection2))
        return true;
      foreach (string assetName in saveCollection2.collection)
      {
        if ((UnityEngine.Object) AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", assetName) == (UnityEngine.Object) null)
          return true;
      }
      return false;
    }

    public static List<CardData> ObtainCards(int choices, int valueCap)
    {
      List<CardData> list1 = AddressableLoader.GetGroup<CardData>("CardData").Clone<CardData>();
      list1.RemoveAll((Predicate<CardData>) (card => card.cardType.name != "Friendly" || card.mainSprite?.name == "Nothing" || card.value > valueCap));
      List<CardData> list2 = list1.TakeRandom<CardData>(choices).ToList<CardData>();
      Debug.Log((object) list1.Count.ToString());
      return list2;
    }

    public static List<CardUpgradeData> ObtainCharms(int choices)
    {
      List<CardUpgradeData> list1 = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Clone<CardUpgradeData>();
      list1.RemoveAll((Predicate<CardUpgradeData>) (charm => charm.type != CardUpgradeData.Type.Charm || charm.tier < 0));
      List<CardUpgradeData> list2 = list1.TakeRandom<CardUpgradeData>(choices).ToList<CardUpgradeData>();
      Debug.Log((object) list1.Count.ToString());
      return list2;
    }

    public override IEnumerator Populate(CampaignNode node)
    {
      EventRoutineTrade eventRoutineCompanion = UnityEngine.Object.FindObjectOfType<EventRoutineTrade>();
      eventRoutineCompanion.node = node;
      yield return (object) eventRoutineCompanion.Populate();
    }

    public override IEnumerator Run(CampaignNode node)
    {
      yield return (object) Transition.To("Event");
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CampaignNodeTypeTrade.Prefabs[this.key], UnityEngine.Object.FindObjectOfType<EventManager>(true).transform);
      gameObject.SetActive(true);
      EventRoutine eventRoutine = gameObject.GetComponent<EventRoutine>();
      GameObject.Find("SnowfallFX").SetActive(false);
      Events.InvokeEventStart(node, eventRoutine);
      yield return (object) this.Populate(node);
      Events.InvokeEventPopulated(eventRoutine);
      Transition.End();
      yield return (object) eventRoutine.Run();
      yield return (object) Transition.To("MapNew");
      Transition.End();
      yield return (object) MapNew.CheckCompanionLimit();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CampaignNodeTypeSpecialBattle
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class CampaignNodeTypeSpecialBattle : CampaignNodeTypeBattle
  {
    public override IEnumerator Run(CampaignNode node)
    {
      string failureText = "Conditions not met!";
      bool flag = false;
      QuestSystem theQuest = (QuestSystem) null;
      QuestSystem[] questSystemArray1 = Campaign.instance.systems.GetComponents<QuestSystem>();
      for (int index = 0; index < questSystemArray1.Length; ++index)
      {
        QuestSystem quest = questSystemArray1[index];
        if (quest.CheckConditions(out failureText))
        {
          flag = true;
          theQuest = quest;
          break;
        }
        quest = (QuestSystem) null;
      }
      questSystemArray1 = (QuestSystem[]) null;
      if (!flag)
      {
        QuestSystem[] questSystemArray2 = Campaign.instance.gameObject.GetComponents<QuestSystem>();
        for (int index = 0; index < questSystemArray2.Length; ++index)
        {
          QuestSystem quest = questSystemArray2[index];
          if (quest.CheckConditions(out failureText))
          {
            flag = true;
            theQuest = quest;
            break;
          }
          quest = (QuestSystem) null;
        }
        questSystemArray2 = (QuestSystem[]) null;
      }
      if (flag || (UnityEngine.Object) References.Map == (UnityEngine.Object) null)
      {
        Debug.Log((object) "[Pokefrost] Quest succeeded! Entering bonus battle...");
        theQuest?.QuestBattleStart();
        yield return (object) base.Run(node);
        theQuest?.QuestBattleFinish();
      }
      else
      {
        Debug.Log((object) "[Pokefrost] Quest failed. Skipping bonus battle...");
        Ext.PopupText(References.Map.FindNode(Campaign.FindCharacterNode(References.Player)).transform, failureText, false);
        yield return (object) Sequences.Wait(1f);
        node.SetCleared();
        References.Map.Continue();
      }
    }

    internal virtual BattleData SelectBattle()
    {
      if (EventBattleManager.battleList.ContainsKey(EventBattleManager.forceBattle))
      {
        EventBattleManager.battleChosen = EventBattleManager.forceBattle;
        return Pokefrost.Pokefrost.instance.Get<BattleData>(EventBattleManager.forceBattle);
      }
      foreach (string name in (IEnumerable<string>) EventBattleManager.battleList.Keys.InRandomOrder<string>())
      {
        BattleData battleData = Pokefrost.Pokefrost.instance.Get<BattleData>(name);
        if ((UnityEngine.Object) battleData != (UnityEngine.Object) null)
        {
          EventBattleManager.battleChosen = name;
          return battleData;
        }
      }
      throw new Exception("No Event Battle Found");
    }

    public override IEnumerator SetUp(CampaignNode node)
    {
      BattleData battle = this.SelectBattle();
      foreach (string str in (IEnumerable<string>) EventBattleManager.battleList.Keys.InRandomOrder<string>())
      {
        string battleName = str;
        battle = Pokefrost.Pokefrost.instance.Get<BattleData>(battleName);
        if ((UnityEngine.Object) battle != (UnityEngine.Object) null)
        {
          EventBattleManager.battleChosen = battleName;
          break;
        }
        battleName = (string) null;
      }
      node.data = new Dictionary<string, object>()
      {
        ["battle"] = (object) battle.name,
        ["waves"] = (object) battle.generationScript.Run(battle, 100)
      };
      if (battle is BattleDataWithRewards b)
        b.AddRewards(node);
      this.isBattle = true;
      yield break;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CardScriptForsee
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class CardScriptForsee : CardScript
  {
    public static List<int> ids = new List<int>();

    public override void Run(CardData target)
    {
      if (!(target.name == "websiteofsites.wildfrost.pokefrost.natu") || !((Object) Campaign.instance != (Object) null))
        return;
      Debug.Log((object) "[Pokefrost] Forseeing...");
      int id = Campaign.FindCharacterNode(References.Player).id;
      foreach (CampaignNode node in Campaign.instance.nodes)
      {
        if (node.type.isBattle && node.id >= id)
        {
          id = node.id;
          break;
        }
      }
      foreach (CampaignNode campaignNode in (IEnumerable<CampaignNode>) Campaign.instance.nodes.InRandomOrder<CampaignNode>())
      {
        if (campaignNode.id > id)
        {
          if (campaignNode.type.name == "CampaignNodeItem" || campaignNode.type.name == "CampaignNodeCurseItems")
          {
            foreach (string name in (IEnumerable<string>) ((IEnumerable<string>) campaignNode.data.Get<SaveCollection<string>>("cards").collection).InRandomOrder<string>())
            {
              if (!Pokefrost.Pokefrost.rotomAppliances.Contains<string>(name) && !this.ConsumeOrClunker(name))
              {
                target.SetCustomData("Future Sight", (object) name);
                string str;
                target.TryGetCustomData<string>("Future Sight", out str, "");
                Debug.Log((object) string.Format("[Pokefrost] Foresaw {0}, {1}", (object) str, (object) campaignNode.id));
                target.SetCustomData("Future Sight ID", (object) campaignNode.id);
                return;
              }
            }
          }
          if (campaignNode.type.name == "CampaignNodeShop")
          {
            ShopRoutine.Data data = campaignNode.data.Get<ShopRoutine.Data>("shopData");
            foreach (int index in (IEnumerable<int>) data.items.GetIndices<ShopRoutine.Item>().InRandomOrder<int>())
            {
              if (data.items[index].category == "Items" && !this.ConsumeOrClunker(data.items[index].cardDataName))
              {
                target.SetCustomData("Future Sight ID", (object) campaignNode.id);
                target.SetCustomData("Future Sight", (object) data.items[index].cardDataName);
                string str;
                target.TryGetCustomData<string>("Future Sight", out str, "");
                Debug.Log((object) string.Format("[Pokefrost] Foresaw {0}, {1}", (object) str, (object) campaignNode.id));
                return;
              }
            }
          }
        }
      }
    }

    private bool ConsumeOrClunker(string name)
    {
      CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>(name);
      if (cardData?.cardType?.name != "Item" || cardData != null && cardData.playType == Card.PlayType.None)
        return true;
      if (cardData.traits != null)
      {
        foreach (CardData.TraitStacks trait in cardData.traits)
        {
          if ((Object) trait.data == (Object) null || trait.data.name == "Consume")
            return true;
        }
      }
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHitFree
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class StatusEffectApplyXWhenHitFree : StatusEffectApplyX
{
  [SerializeField]
  public TargetConstraint[] attackerConstraints;

  public override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && (Object) hit.target == (Object) this.target && hit.canRetaliate && (!this.targetMustBeAlive || this.target.alive && Battle.IsOnBoard(this.target)) && hit.Offensive && hit.BasicHit && this.CheckAttackerConstraints(hit.attacker);
  }

  private IEnumerator CheckHit(Hit hit)
  {
    return this.Run(this.GetTargets(hit, this.GetTargetContainers(), this.GetTargetActualContainers()), hit.damage + hit.damageBlocked);
  }

  private bool CheckAttackerConstraints(Entity attacker)
  {
    if (this.attackerConstraints != null)
    {
      foreach (TargetConstraint attackerConstraint in this.attackerConstraints)
      {
        if (!attackerConstraint.Check(attacker))
          return false;
      }
    }
    return true;
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectMultEffects
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class StatusEffectMultEffects : StatusEffectData
{
  [SerializeField]
  public List<StatusEffectData> effects = new List<StatusEffectData>();
  public List<Entity.TraitStacks> silenced;
  public Entity.TraitStacks added;
  public List<int> addedAmount;

  public override bool HasStackRoutine => true;

  public override bool Instant => true;

  public override IEnumerator StackRoutine(int stacks)
  {
    foreach (StatusEffectData item in this.effects)
    {
      item.count = stacks;
      yield return (object) StatusEffectSystem.Apply(this.target, this.applier, item, stacks);
    }
    yield return (object) this.target.UpdateTraits();
    this.target.display.promptUpdateDescription = true;
    this.target.PromptUpdate();
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CombineCardInBattleSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
namespace Pokefrost
{
  public class CombineCardInBattleSystem : GameSystem
  {
    [SerializeField]
    public string combineSceneName;
    [SerializeField]
    public CombineCardInBattleSystem.Combo[] combos;

    public void OnEnable()
    {
      global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityEnterHand);
      this.combineSceneName = "CardCombine";
      this.combos = new CombineCardInBattleSystem.Combo[1]
      {
        new CombineCardInBattleSystem.Combo()
        {
          cardNames = new string[2]
          {
            "LuminSealant",
            "BrokenVase"
          },
          resultingCardName = "LuminVase"
        }
      };
    }

    public void OnDisable()
    {
      global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityEnterHand);
    }

    public void EntityEnterHand(Entity entity)
    {
      foreach (CombineCardInBattleSystem.Combo combo in this.combos)
      {
        List<Entity> deck = new List<Entity>();
        deck.Add(entity);
        deck.AddRange((IEnumerable<Entity>) References.Player.handContainer.ToList<Entity>());
        deck.AddRange((IEnumerable<Entity>) References.Player.drawContainer.ToList<Entity>());
        deck.AddRange((IEnumerable<Entity>) References.Player.discardContainer.ToList<Entity>());
        Debug.Log((object) ("[Pokefrost] " + deck[0].name));
        if (combo.cardNames.Contains<string>(entity.data.name) && combo.AllCardsInDeck(deck))
        {
          Debug.Log((object) "[Pokefrost] Found Lumin Parts");
          this.StopAllCoroutines();
          ActionQueue.Stack((PlayAction) new CombineCardInBattleSystem.CombineAction()
          {
            combineSceneName = this.combineSceneName,
            tooFuse = combo.FindCards(deck),
            combo = combo
          });
          break;
        }
      }
    }

    [Serializable]
    public struct Combo
    {
      public string[] cardNames;
      public string resultingCardName;

      public bool AllCardsInDeck(List<Entity> deck)
      {
        bool flag = true;
        foreach (string cardName in this.cardNames)
        {
          if (!this.HasCard(cardName, deck))
          {
            flag = false;
            break;
          }
        }
        return flag;
      }

      public List<Entity> FindCards(List<Entity> deck)
      {
        List<Entity> cards = new List<Entity>();
        foreach (string cardName in this.cardNames)
        {
          foreach (Entity entity in deck)
          {
            if (entity.data.name == cardName)
            {
              cards.Add(entity);
              break;
            }
          }
        }
        return cards;
      }

      public bool HasCard(string cardName, List<Entity> deck)
      {
        foreach (Entity entity in deck)
        {
          if (entity.data.name == cardName)
            return true;
        }
        return false;
      }
    }

    public class CombineAction : PlayAction
    {
      [SerializeField]
      public string combineSceneName;
      public CombineCardInBattleSystem.Combo combo;
      public List<Entity> tooFuse;

      public override IEnumerator Run() => this.CombineSequence(this.combo, this.tooFuse);

      public IEnumerator CombineSequence(
        CombineCardInBattleSystem.Combo combo,
        List<Entity> tooFuse)
      {
        CombineCardSequence combineSequence = (CombineCardSequence) null;
        yield return (object) SceneManager.Load(this.combineSceneName, SceneType.Temporary, (Action<Scene>) (scene => combineSequence = scene.FindObjectOfType<CombineCardSequence>()));
        if ((bool) (UnityEngine.Object) combineSequence)
          yield return (object) combineSequence.Run2(tooFuse, combo.resultingCardName);
        yield return (object) SceneManager.Unload(this.combineSceneName);
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CombineCardSequenceExtension
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public static class CombineCardSequenceExtension
  {
    public static IEnumerator Run2(
      this CombineCardSequence seq,
      List<Entity> cardsToCombine,
      string resultingCard)
    {
      CardData cardDataClone = AddressableLoader.GetCardDataClone(resultingCard);
      CardUpgradeData upgrade = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>("CardUpgradeHunger").Clone();
      upgrade.Assign(cardDataClone);
      yield return (object) seq.Run2(cardsToCombine.ToArray(), cardDataClone);
    }

    public static IEnumerator Run2(
      this CombineCardSequence seq,
      Entity[] entities,
      CardData finalCard)
    {
      PauseMenu.Block();
      Card card = CardManager.Get(finalCard, Battle.instance.playerCardController, References.Player, false, true);
      card.transform.localScale = Vector3.one * 1f;
      card.transform.SetParent(seq.finalEntityParent);
      Entity finalEntity = card.entity;
      Routine.Clump clump = new Routine.Clump();
      Entity[] array = entities;
      Entity[] entityArray1 = array;
      for (int index = 0; index < entityArray1.Length; ++index)
      {
        Entity entity = entityArray1[index];
        clump.Add(entity.display.UpdateData());
        entity = (Entity) null;
      }
      entityArray1 = (Entity[]) null;
      clump.Add(finalEntity.display.UpdateData());
      clump.Add(Sequences.Wait(0.5f));
      yield return (object) clump.WaitForEnd();
      array = entities;
      Entity[] entityArray2 = array;
      for (int index = 0; index < entityArray2.Length; ++index)
      {
        Entity entity2 = entityArray2[index];
        entity2.RemoveFromContainers();
        entity2 = (Entity) null;
      }
      entityArray2 = (Entity[]) null;
      array = entities;
      for (int i = 0; i < array.Length; ++i)
        array[i].transform.localScale = Vector3.one * 0.8f;
      seq.fader.In();
      Vector3 zero = Vector3.zero;
      array = entities;
      Entity[] entityArray3 = array;
      for (int index = 0; index < entityArray3.Length; ++index)
      {
        Entity entity3 = entityArray3[index];
        zero += entity3.transform.position;
        entity3 = (Entity) null;
      }
      entityArray3 = (Entity[]) null;
      zero /= (float) entities.Length;
      seq.group.position = zero;
      array = entities;
      Entity[] entityArray4 = array;
      for (int index = 0; index < entityArray4.Length; ++index)
      {
        Entity entity4 = entityArray4[index];
        Transform transform = UnityEngine.Object.Instantiate<Transform>(seq.pointPrefab, entity4.transform.position, Quaternion.identity, seq.group);
        transform.gameObject.SetActive(true);
        entity4.transform.SetParent(transform);
        entity4.flipper.FlipUp();
        seq.points.Add(transform);
        LeanTween.alphaCanvas(((Card) entity4.display).canvasGroup, 1f, 0.4f).setEaseInQuad();
        transform = (Transform) null;
        entity4 = (Entity) null;
      }
      entityArray4 = (Entity[]) null;
      foreach (Transform point in seq.points)
        LeanTween.moveLocal(point.gameObject, point.localPosition.normalized, 0.4f).setEaseInQuart();
      yield return (object) new WaitForSeconds(0.4f);
      Events.InvokeScreenShake();
      array = entities;
      for (int i = 0; i < array.Length; ++i)
        array[i].wobbler.WobbleRandom();
      foreach (Transform point2 in seq.points)
        LeanTween.moveLocal(point2.gameObject, point2.localPosition.normalized * 3f, 1f).setEase(seq.bounceCurve);
      LeanTween.moveLocal(seq.group.gameObject, new Vector3(0.0f, 0.0f, -2f), 1f).setEaseInOutQuad();
      LeanTween.rotateZ(seq.group.gameObject, PettyRandom.Range(160f, 180f), 1f).setOnUpdateVector3((Action<Vector3>) (_param1 =>
      {
        foreach (Component point in seq.points)
          point.transform.eulerAngles = Vector3.zero;
      })).setEaseInOutQuad();
      yield return (object) new WaitForSeconds(1f);
      Events.InvokeScreenShake();
      if ((bool) (UnityEngine.Object) seq.ps)
        seq.ps.Play();
      seq.combinedFx.SetActive(true);
      finalEntity.transform.position = Vector3.zero;
      array = entities;
      for (int i = 0; i < array.Length; ++i)
        CardManager.ReturnToPool(array[i]);
      seq.group.transform.localRotation = Quaternion.identity;
      double num = (double) finalEntity.curveAnimator.Ping();
      finalEntity.wobbler.WobbleRandom();
      yield return (object) new WaitForSeconds(1f);
      seq.fader.gameObject.Destroy();
      PauseMenu.Unblock();
      yield return (object) Sequences.CardMove(finalEntity, new CardContainer[1]
      {
        References.Player.handContainer
      });
      References.Player.handContainer.TweenChildPositions();
      finalEntity.inPlay = true;
      ActionQueue.Stack((PlayAction) new ActionReveal(finalEntity));
      Debug.Log((object) "[Pokefrost] Fused Lumin Vase");
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CommandFillEvolveDebug1
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class CommandFillEvolveDebug1 : Console.Command
  {
    public override string id => "evo1";

    public override string format => "evo1";

    public override void Run(string args)
    {
      MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.Run());
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.CommandFillEvolves
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class CommandFillEvolves : Console.Command
  {
    public override string id => "evofill";

    public override string format => "evofill";

    public override void Run(string args)
    {
      for (int index = 0; index < 3; ++index)
      {
        EvolutionPopUp.evolvedPokemonLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>("eevee").Clone());
        EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>(StatusEffectEvolveEevee.eeveelutions.RandomItem<string>()).Clone());
      }
      EvolutionPopUp.evolvedPokemonLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>("BerryPet").Clone());
      EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>(StatusEffectEvolveEevee.eeveelutions.RandomItem<string>()).Clone());
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.Commands
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class Commands
  {
    public static IEnumerator AddCustomCommands()
    {
      yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("MainMenu")));
      if (Console.commands != null)
        Commands.AddCommands();
    }

    public static void AddCommands()
    {
      Console.commands.Add((Console.Command) new Commands.CommandModifier());
      Console.commands.Add((Console.Command) new Commands.CommandEvent());
      Console.commands.Add((Console.Command) new Commands.CommandDebug());
    }

    public class CommandModifier : Console.Command
    {
      public override string id => "poke.modifier";

      public override string format => "poke.modifier <name>";

      public override string desc => "Gives the corresponding modifier";

      public override bool IsRoutine => false;

      public override void Run(string args)
      {
        GameModifierData modifier = AddressableLoader.GetGroup<GameModifierData>("GameModifierData").FirstOrDefault<GameModifierData>((Func<GameModifierData, bool>) (a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)));
        if ((UnityEngine.Object) modifier == (UnityEngine.Object) null)
          this.Fail("Upgrade [" + args + "] does not exist!");
        if ((UnityEngine.Object) Campaign.instance == (UnityEngine.Object) null)
          this.Fail("Must be in a run!");
        ModifierSystem.AddModifier(Campaign.Data, modifier);
        Routine.Clump clump = new Routine.Clump();
        foreach (Script startScript in modifier.startScripts)
          clump.Add(startScript.Run());
        foreach (Script setupScript in modifier.setupScripts)
          clump.Add(setupScript.Run());
        foreach (string componentName in modifier.systemsToAdd)
        {
          Debug.Log((object) string.Format("[{0}] adding system: {1}", (object) modifier, (object) componentName));
          Campaign.instance.gameObject.AddComponentByName(componentName);
        }
      }

      public override IEnumerator GetArgOptions(string currentArgs)
      {
        yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
        IEnumerable<GameModifierData> enumerable = AddressableLoader.GetGroup<GameModifierData>("GameModifierData").Where<GameModifierData>((Func<GameModifierData, bool>) (a => a.name.ToLower().Contains(currentArgs.ToLower())));
        List<string> list = new List<string>();
        foreach (GameModifierData item in enumerable)
          list.Add(item.name);
        this.predictedArgs = list.ToArray();
      }
    }

    public class CommandEvent : Console.Command
    {
      public override string id => "poke.event";

      public override string format => "poke.event <name>";

      public override string desc => "Guarantees the specific event";

      public override bool IsRoutine => false;

      public override void Run(string args)
      {
        if (EventBattleManager.battleList.ContainsKey(args))
        {
          foreach (string key in EventBattleManager.battleList.Keys.ToArray<string>())
          {
            if (key != args)
              EventBattleManager.battleList.Remove(key);
          }
        }
        else
          this.Fail("Could not find key [" + args + "]");
      }

      public override IEnumerator GetArgOptions(string currentArgs)
      {
        this.predictedArgs = EventBattleManager.battleList.Keys.ToArray<string>();
        yield break;
      }
    }

    public class CommandDebug : Console.Command
    {
      public override string id => "poke.debug";

      public override string format => "poke.debug";

      public override string desc => "Runs arbitrary code for debugging";

      public override bool IsRoutine => false;

      public override void Run(string args)
      {
        List<StatusEffectData> group = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData");
        Debug.Log((object) ("[Pokefrost] STARTING DEBUG: " + group.Count.ToString()));
        foreach (StatusEffectData statusEffectData in group)
        {
          if (statusEffectData.type == null)
            Debug.Log((object) ("[Pokefrost] " + statusEffectData.name));
        }
        Debug.Log((object) "[Pokefrost] ENDING DEBUG");
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWhileInHandXUpdate
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWhileInHandXUpdate : StatusEffectWhileInHandX
  {
    public bool removeOnPlay = false;

    public override bool HasCardPlayedRoutine => this.removeOnPlay;

    public override IEnumerator BeginRoutine()
    {
      yield return (object) base.BeginRoutine();
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
    }

    public override IEnumerator CardPlayedRoutine(Entity entity, Entity[] targets)
    {
      Debug.Log((object) "[Curse] Card Played");
      if ((Object) entity == (Object) this.target && this.removeOnPlay)
      {
        yield return (object) this.CountDown(this.target, this.count);
        entity.statusEffects.Remove((StatusEffectData) this);
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
        Debug.Log((object) "[Curse] Removed... maybe");
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EntityCardScript
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public abstract class EntityCardScript : ScriptableObject
  {
    public abstract IEnumerator Run(Entity entity, int stack);
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EventBattleManager
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using BattleEditor;
using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class EventBattleManager
  {
    public static EventBattleManager instance;
    public static float minChance = 0.25f;
    public static float maxChance = 1f;
    public bool successfulRoll = false;
    public static Dictionary<string, string> battleList = new Dictionary<string, string>();
    public static string battleChosen = "";
    public static string forceBattle = "";

    public EventBattleManager() => EventBattleManager.instance = this;

    public void Enable(Pokefrost.Pokefrost mod)
    {
      this.CreateBattles(mod);
      global::Events.OnCampaignLoadPreset += new global::Events.UnityActionRef<string[]>(this.RollForEvent);
      global::Events.OnPreCampaignPopulate += new UnityAction(this.HideNode);
      MoreEvents.OnCampaignGenerated += new UnityAction(this.AddEventItems);
    }

    public void Disable(Pokefrost.Pokefrost mod)
    {
      EventBattleManager.battleList.Clear();
      global::Events.OnCampaignLoadPreset -= new global::Events.UnityActionRef<string[]>(this.RollForEvent);
      global::Events.OnPreCampaignPopulate -= new UnityAction(this.HideNode);
      MoreEvents.OnCampaignGenerated -= new UnityAction(this.AddEventItems);
    }

    private void CreateBattles(Pokefrost.Pokefrost mod)
    {
      new BattleDataEditor((WildfrostMod) mod).Create<BattleDataWithRewards>("Darkrai").SetASprite("MapDarkrai").SetNameRef("Dark Crater Pit").EnemyDictionary(('D', "enemy_darkrai"), ('H', "enemy_hypno"), ('M', "enemy_mismagius"), ('G', "enemy_magmortar"), ('S', "enemy_spiritomb")).StartWavePoolData(0, "Curses!").ConstructWaves(4, 0, "SMMS").StartWavePoolData(1, "More curses").ConstructWaves(4, 1, "HMMG", "GMMH", "HSMG", "SSHG").StartWavePoolData(2, "Darkrai is here!").ConstructWaves(3, 9, "DMH", "DGH").GiveMiniBossesCharms(new string[1]
      {
        "enemy_darkrai"
      }, "CardUpgradeDemonize", "CardUpgradeInk").FreeModify<BattleDataWithRewards>((Action<BattleDataWithRewards>) (b =>
      {
        b.dataGroups = new List<BossRewardData.Data>[3];
        b.dataGroups[0] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCard("darkrai"),
          (BossRewardData.Data) EventBattleManager.CreateCard("cresselia")
        };
        b.dataGroups[1] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeCurse"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeDuplicate")
        };
        b.dataGroups[2] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingDarkrai"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingCresselia")
        };
      })).AddBattleToLoader();
      new BattleDataEditor((WildfrostMod) mod).Create<BattleDataWithRewards>("Lati Twins").SetASprite("MapLati").SetNameRef("Southern Island").EnemyDictionary(('P', "enemy_plusle"), ('M', "enemy_minun"), ('V', "enemy_volbeat"), ('I', "enemy_illumise"), ('D', "enemy_dustox"), ('B', "enemy_beautifly"), ('G', "enemy_gorebyss"), ('H', "enemy_huntail"), ('S', "enemy_solrock"), ('L', "enemy_lunatone"), ('A', "enemy_latias"), ('O', "enemy_latios")).StartWavePoolData(0, "Charging up").ConstructWaves(4, 0, "PMDB").StartWavePoolData(1, "Scary").ConstructWaves(4, 1, "VIGH").StartWavePoolData(2, "Lati!").ConstructWaves(4, 9, "SLAO").GiveMiniBossesCharms(new string[1]
      {
        "enemy_latias"
      }, "CardUpgradeHeartmist", "CardUpgradeAcorn").GiveMiniBossesCharms(new string[1]
      {
        "enemy_latios"
      }, "CardUpgradeSpice", "CardUpgradeBattle").FreeModify<BattleDataWithRewards>((Action<BattleDataWithRewards>) (b =>
      {
        b.dataGroups = new List<BossRewardData.Data>[3];
        b.dataGroups[0] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCard("latias"),
          (BossRewardData.Data) EventBattleManager.CreateCard("latios")
        };
        b.dataGroups[1] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeResist"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeCharged")
        };
        b.dataGroups[2] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingLatias"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingLatios")
        };
      })).AddBattleToLoader();
      new BattleDataEditor((WildfrostMod) mod).Create<BattleDataWithRewards>("Ho-Oh").SetASprite("MapHooh").SetNameRef("Mt. Faraway").EnemyDictionary(('H', "enemy_hooh"), ('E', "enemy_entei"), ('R', "enemy_raikou"), ('S', "enemy_suicune"), ('V', "enemy_vaporeon"), ('J', "enemy_jolteon"), ('F', "enemy_flareon"), ('P', "enemy_espeon"), ('U', "enemy_umbreon"), ('L', "enemy_leafeon"), ('G', "enemy_glaceon"), ('Y', "enemy_sylveon")).StartWavePoolData(0, "Mystery").ConstructWaves(1, 0, "H").StartWavePoolData(1, "Beasts").ConstructWaves(2, 1, "EF", "RJ", "SV").StartWavePoolData(2, "Eeveeloutions").ConstructWaves(2, 9, "PU", "GL", "Y").GiveMiniBossesCharms(new string[1]
      {
        "enemy_hooh"
      }, "CardUpgradeCloudberry", "CardUpgradeBlock").GiveMiniBossesCharms(new string[1]
      {
        "enemy_suicune"
      }, "CardUpgradeBlock", "CardUpgradeBoost").GiveMiniBossesCharms(new string[1]
      {
        "enemy_raikou"
      }, "CardUpgradeSun", "CardUpgradeAimless").GiveMiniBossesCharms(new string[1]
      {
        "enemy_entei"
      }, "CardUpgradeAttackAndHealth", "CardUpgradeTrashBad").SetGenerationScript((BattleGenerationScript) ScriptableObject.CreateInstance<BattleGenerationScriptHooh>()).FreeModify<BattleDataWithRewards>((Action<BattleDataWithRewards>) (b =>
      {
        b.bonusPulls = 1;
        b.bonusProfile = new List<int>() { 0, 1, 1 };
        b.dataGroups = new List<BossRewardData.Data>[3];
        b.dataGroups[0] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCard("raikou"),
          (BossRewardData.Data) EventBattleManager.CreateCard("entei"),
          (BossRewardData.Data) EventBattleManager.CreateCard("suicune"),
          (BossRewardData.Data) EventBattleManager.CreateCard("hooh")
        };
        b.dataGroups[1] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeConduit"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeBackBurn"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeJuice"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeSacredAsh")
        };
        b.dataGroups[2] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingSpicune"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingRaikou"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingEntei"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingHooh")
        };
      })).AddBattleToLoader();
      EventBattleManager.battleList["Darkrai"] = "darkraiEvent";
      EventBattleManager.battleList["Lati Twins"] = "latiEvent";
      EventBattleManager.battleList["Ho-Oh"] = "hoohEvent";
    }

    private void RollForEvent(ref string[] lines)
    {
      CampaignNodeTypeBattle campaignNodeTypeBattle = Pokefrost.Pokefrost.instance.Get<CampaignNodeType>("specialBattle") as CampaignNodeTypeBattle;
      if ((UnityEngine.Object) campaignNodeTypeBattle != (UnityEngine.Object) null)
        campaignNodeTypeBattle.isBattle = false;
      float num1 = Dead.Random.Range(0.0f, 1f);
      float num2 = EventBattleManager.minChance + (float) ((double) StormBellManager.GetCurrentStormPoints(StormBellManager.GetActiveStormBells()) / 10.0 * ((double) EventBattleManager.maxChance - (double) EventBattleManager.minChance));
      Debug.Log((object) string.Format("[Pokefrost] {0}", (object) num2));
      if ((double) num1 > (double) num2)
      {
        this.successfulRoll = false;
      }
      else
      {
        int length1 = lines.Length;
        int length2 = lines[0].Length;
        for (int index1 = 0; index1 < length2; ++index1)
        {
          if (lines[0][index1] == 'B' && lines[length1 - 1].Length > index1 && lines[length1 - 1][index1] == '1')
          {
            lines[0] = lines[0].Insert(index1 + 1, "e");
            lines[length1 - 2] = lines[length1 - 2].Insert(index1 + 1, "6");
            lines[length1 - 1] = lines[length1 - 1].Insert(index1 + 1, "2");
            for (int index2 = 1; index2 < length1 - 2; ++index2)
              lines[index2] = lines[index2].Insert(index1 + 1, " ");
            this.successfulRoll = true;
            break;
          }
        }
      }
    }

    private void HideNode()
    {
      if (!this.successfulRoll)
        return;
      for (int index = 0; index < Campaign.instance.nodes.Count; ++index)
      {
        CampaignNode node = Campaign.instance.nodes[index];
        if (node.type.letter == "e")
        {
          Debug.Log((object) "[Pokefrost] Hiding battle node");
          Campaign.instance.nodes[index - 1].connections = node.connections;
          node.connections = new List<CampaignNode.Connection>();
          break;
        }
      }
    }

    internal void ReturnNode()
    {
      for (int index = 0; index < Campaign.instance.nodes.Count; ++index)
      {
        CampaignNode node1 = Campaign.instance.nodes[index];
        if (node1.type.letter == "e")
        {
          Debug.Log((object) "[Pokefrost] Returning battle node");
          CampaignNode node2 = Campaign.instance.nodes[index - 1];
          if (node1.connections.Count > 0)
            break;
          node1.connections = node2.connections;
          node2.connections = new List<CampaignNode.Connection>()
          {
            new CampaignNode.Connection()
            {
              otherId = node1.id,
              direction = 1f
            }
          };
          break;
        }
      }
    }

    private void AddEventItems()
    {
      if (!this.successfulRoll)
        return;
      Debug.Log((object) "[Pokefrost] Starting...");
      for (int index = 0; index < References.Campaign.nodes.Count; ++index)
      {
        CampaignNode node = References.Campaign.nodes[index];
        if (node.type is CampaignNodeTypeBoss)
        {
          Debug.Log((object) "[Pokefrost] Found Act I Boss node");
          node.data.Get<CampaignNodeTypeBoss.RewardData>("rewards").rewards.Add((BossRewardData.Data) new BossRewardDataModifier.Data()
          {
            modifierName = (Pokefrost.Pokefrost.instance.GUID + "." + EventBattleManager.battleList[EventBattleManager.battleChosen])
          });
          Debug.Log((object) "[Pokefrost] Success!");
          break;
        }
      }
      this.successfulRoll = false;
    }

    public static BossRewardDataCard.Data CreateCard(string cardName)
    {
      BossRewardDataCard.Data card = new BossRewardDataCard.Data();
      card.type = BossRewardData.Type.Crown;
      card.cardDataName = cardName;
      return card;
    }

    public static BossRewardDataRandomCharm.Data CreateCharm(string upgradeName)
    {
      BossRewardDataRandomCharm.Data charm = new BossRewardDataRandomCharm.Data();
      charm.type = BossRewardData.Type.Charm;
      charm.upgradeName = Pokefrost.Pokefrost.instance.GUID + "." + upgradeName;
      return charm;
    }

    public static BossRewardDataModifier.Data CreateBell(string modifierName)
    {
      BossRewardDataModifier.Data bell = new BossRewardDataModifier.Data();
      bell.type = BossRewardData.Type.Modifier;
      bell.modifierName = Pokefrost.Pokefrost.instance.GUID + "." + modifierName;
      return bell;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EventRoutineTrade
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class EventRoutineTrade : EventRoutine, IRerollable
  {
    public static readonly string Seq1Key = "websiteofsites.wildfrost.pokefrost.trade_text1";
    public static readonly string Seq2Key = "websiteofsites.wildfrost.pokefrost.trade_text2";
    public static readonly string TradeConfirm = "websiteofsites.wildfrost.pokefrost.trade_confirm";
    public static readonly string TradeCancel = "websiteofsites.wildfrost.pokefrost.trade_cancel";
    private StringTable stringTable;
    public CardControllerSelectCard cc;
    public CardSelector cs;
    public CardLane topRow;
    public CardLane bottomRow;
    public GameObject backButton;
    public GameObject TradeLines;
    public List<Image> TradeLinesList = new List<Image>();
    public Vector2 linesScale = new Vector2(2.5f, 8.25f);
    public Color offColor = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    public Color onColor = new Color(0.3f, 0.8f, 0.5f, 0.7f);
    public GameObject selectionBackground;
    public GameObject cancelObject;
    public GameObject confirmObject;
    public TextMeshProUGUI title;
    public int swapped = -1;
    public bool selected = false;
    public float selectTime = 0.5f;
    public LeanTweenType selectType = LeanTweenType.easeOutQuart;
    private Vector3 left = new Vector3(-2.5f, 1f, 0.0f);
    private Vector3 right = new Vector3(2.5f, 1f, 0.0f);
    public float tradeTime = 1f;
    public bool routineActive = true;
    private bool initialized = false;

    public override IEnumerator Populate()
    {
      string[] saveCollection = this.data.GetSaveCollection<string>("cards");
      string[] upgradeCollection = this.data.GetSaveCollection<string>("charms");
      int size = saveCollection.Length;
      int amountPer = upgradeCollection.Length / size;
      if (!this.data.ContainsKey("currentcompanions"))
      {
        List<CardData> items = new List<CardData>();
        foreach (CardData cardData in References.PlayerData.inventory.deck)
        {
          if (cardData.cardType.name == "Friendly")
            items.Add(cardData);
        }
        foreach (CardData cardData in References.PlayerData.inventory.reserve)
        {
          if (cardData.cardType.name == "Friendly")
            items.Add(cardData);
        }
        size = Math.Min(size, items.Count<CardData>());
        items = items.InRandomOrder<CardData>().ToList<CardData>().GetRange(0, size);
        this.node.data.Add("currentcompanions", (object) items.ToSaveCollectionOfNames<CardData>());
        items = (List<CardData>) null;
      }
      string[] savedOffers = this.data.GetSaveCollection<string>("currentcompanions");
      size = Math.Min(((IEnumerable<string>) saveCollection).Count<string>(), ((IEnumerable<string>) savedOffers).Count<string>());
      this.topRow.SetSize(saveCollection.Length, 0.7f);
      this.bottomRow.SetSize(saveCollection.Length, 0.7f);
      Routine.Clump clump = new Routine.Clump();
      for (int i = 0; i < size; ++i)
      {
        List<string> upgrades = upgradeCollection.RangeSubset<string>(amountPer * i, amountPer).ToList<string>();
        clump.Add(EventRoutineTrade.CreateCardsFromLoader(saveCollection[i], upgrades, (CardController) this.cc, (CardContainer) this.topRow));
        if (!this.initialized)
          clump.Add(EventRoutineTrade.CreateCardsFromDeck(savedOffers[i], (CardController) this.cc, (CardContainer) this.bottomRow));
        upgrades = (List<string>) null;
      }
      yield return (object) clump.WaitForEnd();
      this.topRow.SetChildPositions();
      this.bottomRow.SetChildPositions();
      if (!this.initialized)
      {
        this.initialized = true;
        this.SetSize();
        this.cc.pressEvent.AddListener(new UnityAction<Entity>(this.Select));
        this.cc.hoverEvent.AddListener(new UnityAction<Entity>(this.Hover));
        this.cc.unHoverEvent.AddListener(new UnityAction<Entity>(this.Unhover));
        this.cs.character = References.Player;
        this.backButton.GetComponentInChildren<Button>().onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        this.backButton.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.Leave));
        this.cancelObject.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.Cancel));
        this.cancelObject.GetComponentInChildren<Button>().onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        this.confirmObject.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.Confirm));
        this.confirmObject.GetComponentInChildren<Button>().onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        this.cancelObject.GetComponentInChildren<ButtonAnimator>().baseColour = new Color(0.9f, 0.3f, 0.3f, 1f);
      }
    }

    public void PrepareButtons()
    {
      this.cancelObject.GetComponentInChildren<ButtonAnimator>().baseColour = new Color(0.9f, 0.3f, 0.3f, 1f);
      this.cancelObject.SetActive(false);
      this.cancelObject.SetActive(true);
      this.cancelObject.GetComponentInChildren<TextMeshProUGUI>().SetText(this.stringTable.GetString(EventRoutineTrade.TradeCancel).GetLocalizedString());
      this.confirmObject.GetComponentInChildren<TextMeshProUGUI>().SetText(this.stringTable.GetString(EventRoutineTrade.TradeConfirm).GetLocalizedString());
    }

    private void SetSize()
    {
      for (int index = 0; index < this.bottomRow.entities.Count; ++index)
      {
        GameObject gameObject = UICollector.PullPrefab("Box", "Box", this.TradeLines);
        gameObject.transform.localPosition = new Vector3(this.bottomRow.GetChildPosition(this.bottomRow.entities[index]).x, 0.0f, 0.0f);
        gameObject.GetComponent<RectTransform>().sizeDelta = this.linesScale;
        this.TradeLinesList.Add(gameObject.GetComponent<Image>());
        this.TradeLinesList[index].color = this.offColor;
      }
    }

    public override IEnumerator Run()
    {
      this.stringTable = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      while (this.routineActive)
      {
        if (this.swapped != -1)
        {
          this.title.SetText(this.stringTable.GetString(EventRoutineTrade.Seq1Key).GetLocalizedString());
          this.topRow.entities[this.swapped].transform.SetParent(this.topRow.transform, true);
          this.bottomRow.entities[this.swapped].transform.SetParent(this.bottomRow.transform, true);
          this.topRow.TweenChildPositions();
          this.bottomRow.TweenChildPositions();
          this.swapped = -1;
        }
        this.cc.enabled = true;
        this.selectionBackground.SetActive(false);
        yield return (object) new WaitUntil((Func<bool>) (() => this.selected));
        if (this.swapped == -1)
        {
          yield break;
        }
        else
        {
          string s = this.stringTable.GetString(EventRoutineTrade.Seq2Key).GetLocalizedString();
          this.title.SetText(string.Format(s, (object) this.bottomRow.entities[this.swapped].data.title, (object) this.topRow.entities[this.swapped].data.title));
          this.selectionBackground.SetActive(true);
          this.PrepareButtons();
          this.UnhoverAll();
          this.topRow.entities[this.swapped].transform.SetParent(this.selectionBackground.transform, true);
          this.bottomRow.entities[this.swapped].transform.SetParent(this.selectionBackground.transform, true);
          this.cc.enabled = false;
          LeanTween.moveLocal(this.topRow.entities[this.swapped].gameObject, this.right, this.selectTime).setEase(this.selectType);
          LeanTween.moveLocal(this.bottomRow.entities[this.swapped].gameObject, this.left, this.selectTime).setEase(this.selectType);
          LeanTween.scale(this.topRow.entities[this.swapped].gameObject, Vector3.one, this.selectTime).setEase(this.selectType);
          LeanTween.scale(this.bottomRow.entities[this.swapped].gameObject, Vector3.one, this.selectTime).setEase(this.selectType);
          yield return (object) Sequences.Wait(this.selectTime + 0.1f);
          yield return (object) new WaitUntil((Func<bool>) (() => !this.selected));
          s = (string) null;
        }
      }
      LeanTween.moveLocal(this.topRow.entities[this.swapped].gameObject, this.left, this.tradeTime).setEase(this.selectType);
      LeanTween.moveLocal(this.bottomRow.entities[this.swapped].gameObject, this.right, this.tradeTime).setEase(this.selectType);
      yield return (object) Sequences.Wait(this.tradeTime + 0.1f);
      this.cs.TakeCard(this.topRow.entities[this.swapped]);
      this.node.SetCleared();
      yield return (object) Sequences.Wait(0.2f);
    }

    private static IEnumerator CreateCardsFromDeck(
      string cardName,
      CardController cardController,
      CardContainer cardContainer,
      bool startFlipped = true)
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if (cardData.name == cardName)
          return EventRoutineTrade.CreateCards(cardData, cardController, cardContainer, startFlipped);
      }
      foreach (CardData cardData in References.PlayerData.inventory.reserve)
      {
        if (cardData.name == cardName)
          return EventRoutineTrade.CreateCards(cardData, cardController, cardContainer, startFlipped);
      }
      return (IEnumerator) null;
    }

    private static IEnumerator CreateCardsFromLoader(
      string cardName,
      List<string> upgrades,
      CardController cardController,
      CardContainer cardContainer,
      bool startFlipped = true)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", cardName).Clone();
      foreach (string upgrade in upgrades)
      {
        CardUpgradeData cardUpgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgrade);
        if (!((UnityEngine.Object) cardUpgradeData == (UnityEngine.Object) null) && cardUpgradeData.CanAssign(cardData))
          cardUpgradeData.Clone().Assign(cardData);
      }
      return EventRoutineTrade.CreateCards(cardData, cardController, cardContainer, startFlipped);
    }

    private static IEnumerator CreateCards(
      CardData cardData,
      CardController cardController,
      CardContainer cardContainer,
      bool startFlipped = true)
    {
      Card card = CardManager.Get(cardData, cardController, (Character) null, false, true);
      if (startFlipped)
        card.entity.flipper.FlipDownInstant();
      Debug.Log((object) "Trading!");
      Debug.Log((object) ((UnityEngine.Object) cardContainer != (UnityEngine.Object) null));
      cardContainer.Add(card.entity);
      yield return (object) card.UpdateData(false);
      if (startFlipped)
        card.entity.flipper.FlipUp(true);
    }

    public void Hover(Entity entity)
    {
      int index = this.FindIndex(entity);
      if (index == -1)
        return;
      this.TradeLinesList[index].color = this.onColor;
    }

    public void Unhover(Entity entity)
    {
      int index = this.FindIndex(entity);
      if (index == -1)
        return;
      this.TradeLinesList[index].color = this.offColor;
    }

    public void UnhoverAll()
    {
      foreach (Graphic tradeLines in this.TradeLinesList)
        tradeLines.color = this.offColor;
    }

    public int FindIndex(Entity entity)
    {
      int index = this.topRow.entities.IndexOf(entity);
      if (index == -1)
        index = this.bottomRow.entities.IndexOf(entity);
      return index;
    }

    public void Select(Entity entity)
    {
      this.cc.UnHover(entity);
      this.swapped = this.FindIndex(entity);
      if (this.swapped == -1)
        return;
      this.selected = true;
    }

    public void Swap(Entity entity)
    {
      int index = this.topRow.entities.IndexOf(entity);
      if (index == -1)
        index = this.bottomRow.entities.IndexOf(entity);
      if (index == -1)
        return;
      this.Swap(index);
    }

    public void Swap(int index)
    {
      if (index >= Math.Min(this.topRow.entities.Count, this.bottomRow.entities.Count))
      {
        Debug.Log((object) "[Pokeforst] How did that happen?");
      }
      else
      {
        Entity entity1 = this.topRow.entities[index];
        Entity entity2 = this.bottomRow.entities[index];
        this.topRow.RemoveAt(index);
        this.bottomRow.RemoveAt(index);
        this.topRow.Insert(index, entity2);
        this.bottomRow.Insert(index, entity1);
        this.topRow.TweenChildPositions();
        this.bottomRow.TweenChildPositions();
        if (this.swapped == index)
        {
          this.swapped = -1;
          this.TradeLinesList[index].color = this.offColor;
        }
        else
        {
          this.swapped = index;
          this.TradeLinesList[index].color = this.onColor;
        }
        this.selected = true;
      }
    }

    public void Leave() => this.selected = true;

    public void Cancel()
    {
      this.selected = false;
      Debug.Log((object) "[Pokefrost] Cancel");
    }

    public void Confirm()
    {
      int swapped = this.swapped;
      foreach (CardUpgradeData upgrade in this.bottomRow.entities[swapped].data.upgrades)
      {
        if (upgrade.type != CardUpgradeData.Type.Charm && upgrade.canBeRemoved)
          References.PlayerData.inventory.upgrades.Add(AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgrade.name).Clone());
      }
      bool flag = false;
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if (cardData.name == this.bottomRow.entities[swapped].data.name)
        {
          References.PlayerData.inventory.deck.Remove(cardData);
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        foreach (CardData cardData in References.PlayerData.inventory.reserve)
        {
          if (cardData.name == this.bottomRow.entities[swapped].data.name)
          {
            References.PlayerData.inventory.reserve.Remove(cardData);
            break;
          }
        }
      }
      this.routineActive = false;
      this.selected = false;
      Debug.Log((object) "[Pokefrost] Confirm");
    }

    public bool Reroll()
    {
      if (this.selected)
        return false;
      string[] saveCollection1 = this.data.GetSaveCollection<string>("cards");
      string[] saveCollection2 = this.data.GetSaveCollection<string>("charms");
      this.data["cards"] = (object) CampaignNodeTypeTrade.ObtainCards(saveCollection1.Length, 499).ToSaveCollectionOfNames<CardData>();
      this.data["charms"] = (object) CampaignNodeTypeTrade.ObtainCharms(saveCollection2.Length).ToSaveCollectionOfNames<CardUpgradeData>();
      foreach (Entity entity in (CardContainer) this.topRow)
        CardManager.ReturnToPool(entity);
      this.topRow.Clear();
      this.StartCoroutine(this.Populate());
      CardPopUp.Clear();
      return true;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EventSaveSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal static class EventSaveSystem
  {
    private static Dictionary<string, int> eventProgress;

    private static bool FileName(CampaignData data, out string fileName)
    {
      fileName = (string) null;
      string name = data?.GameMode?.name;
      string profile = SaveSystem.GetProfile();
      if (profile == null || name == null)
        return false;
      fileName = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, profile + "_" + name + "_quest.txt");
      return true;
    }

    private static void LoadProgress(CampaignData data)
    {
      EventSaveSystem.eventProgress = new Dictionary<string, int>();
      try
      {
        string fileName;
        if (!EventSaveSystem.FileName(data, out fileName) || !File.Exists(fileName))
          return;
        string[] strArray1 = File.ReadAllLines(fileName);
        int result;
        if (int.TryParse(strArray1[0], out result) && result == data.Seed)
        {
          for (int index = 1; index < strArray1.Length; ++index)
          {
            string[] strArray2 = strArray1[index].Split(' ');
            EventSaveSystem.eventProgress[strArray2[0]] = int.Parse(strArray2[1]);
          }
        }
        else
          File.Delete(fileName);
      }
      catch (Exception ex)
      {
        EventSaveSystem.eventProgress = new Dictionary<string, int>();
        Debug.Log((object) ex.Message);
      }
    }

    private static void SaveProgress(CampaignData data)
    {
      string fileName;
      if (EventSaveSystem.eventProgress == null || EventSaveSystem.eventProgress.Count == 0 || !EventSaveSystem.FileName(data, out fileName))
        return;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(data.Seed.ToString());
      foreach (string key in EventSaveSystem.eventProgress.Keys)
        stringBuilder.AppendLine(string.Format("{0} {1}", (object) key, (object) EventSaveSystem.eventProgress[key]));
      File.WriteAllText(fileName, stringBuilder.ToString());
    }

    public static void Add(string key, int value)
    {
      if (EventSaveSystem.eventProgress == null)
        EventSaveSystem.LoadProgress(Campaign.Data);
      EventSaveSystem.eventProgress[key] = value;
      EventSaveSystem.SaveProgress(Campaign.Data);
    }

    public static int Get(string key)
    {
      EventSaveSystem.LoadProgress(Campaign.Data);
      int num;
      return EventSaveSystem.eventProgress.TryGetValue(key, out num) ? num : -1;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EvolutionPopUp
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal static class EvolutionPopUp
  {
    public static List<CardData> evolvedPokemonLastBattle = new List<CardData>(3);
    public static List<CardData> pokemonEvolvedIntoLastBattle = new List<CardData>(3);
    private static bool WaitingToPopUp = false;
    public static List<GameObject> silhouettes = new List<GameObject>();
    public static string EvoTitleKey1A = "websiteofsites.wildfrost.pokefrost.evo_title1a";
    public static string EvoTitleKey1B = "websiteofsites.wildfrost.pokefrost.evo_title1b";
    public static string EvoTitleKey2A = "websiteofsites.wildfrost.pokefrost.evo_title2a";
    public static string EvoTitleKey2B = "websiteofsites.wildfrost.pokefrost.evo_title2b";
    public static string EvoObserve = "websiteofsites.wildfrost.pokefrost.evo_observe";
    public static StringTable stringTable;
    private static CardFramesUnlockedSequence sequence;
    private static TextMeshProUGUI titleObject;
    private static Button continueButton;
    private static GameObject fader;
    private static int eventProgress = 0;
    private static bool startClosingSequence = false;
    private static LeanTweenType silTweenType = LeanTweenType.linear;
    private static float duration = 0.5f;
    private static float overlap = 0.2f;
    private static Vector3 translate = new Vector3(0.0f, -3f, 0.0f);
    private static Vector3 translate2 = new Vector3(0.0f, -0.5f, 0.0f);
    private static float fadeInDur = 0.75f;
    private static LeanTweenType fadeInType = LeanTweenType.easeInCubic;
    private static float hold = 0.25f;
    private static float fadeOutDur = 0.3f;
    private static LeanTweenType fadeOutType = LeanTweenType.easeOutCubic;
    private static float frequency = 0.05f;
    private static float endDelay = 0.3f;
    private static Vector3 gap = new Vector3(0.4f, 0.0f, 0.0f);

    private static WildfrostMod mod => (WildfrostMod) Pokefrost.Pokefrost.instance;

    private static void AddCommands()
    {
      Console.commands.Add((Console.Command) new CommandFillEvolves());
      Console.commands.Add((Console.Command) new CommandFillEvolveDebug1());
    }

    public static IEnumerator DelayedRun()
    {
      if (!EvolutionPopUp.WaitingToPopUp)
      {
        EvolutionPopUp.WaitingToPopUp = true;
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.IsLoaded("MapNew") && !PickupRoutine.Active));
        ActionSequence action = new ActionSequence(EvolutionPopUp.Run());
        ActionQueue.Add((PlayAction) action);
        EvolutionPopUp.WaitingToPopUp = false;
      }
    }

    public static IEnumerator Run()
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count != 0)
      {
        EvolutionPopUp.stringTable = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
        EvolutionPopUp.eventProgress = 0;
        yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
        yield return (object) SceneManager.Load("CardFramesUnlocked", SceneType.Temporary);
        EvolutionPopUp.sequence = UnityEngine.Object.FindObjectOfType<CardFramesUnlockedSequence>();
        EvolutionPopUp.sequence.container1.transform.Translate(EvolutionPopUp.translate2);
        EvolutionPopUp.titleObject = EvolutionPopUp.sequence.GetComponentInChildren<TextMeshProUGUI>(true);
        EvolutionPopUp.fader = UICollector.PullPrefab("Box", "Fader", EvolutionPopUp.sequence.gameObject);
        EvolutionPopUp.fader.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.0f);
        EvolutionPopUp.fader.SetActive(false);
        Button back = EvolutionPopUp.sequence.group.GetComponentInChildren<Button>();
        back.onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        back.onClick.AddListener((UnityAction) (() => EvolutionPopUp.End()));
        yield return (object) new WaitForSeconds(0.3f);
        GameObject obj = UICollector.PullPrefab("Button", "Continue Button", EvolutionPopUp.sequence.gameObject);
        obj.transform.position = EvolutionPopUp.translate;
        EvolutionPopUp.continueButton = obj.GetComponentInChildren<Button>();
        EvolutionPopUp.continueButton.onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        EvolutionPopUp.continueButton.onClick.AddListener(new UnityAction(EvolutionPopUp.ProgressEvent));
        EvolutionPopUp.fader.transform.SetAsLastSibling();
        yield return (object) EvolutionPopUp.Preevos();
        yield return (object) new WaitUntil((Func<bool>) (() => EvolutionPopUp.eventProgress > 0));
        if (EvolutionPopUp.eventProgress == 1)
        {
          EvolutionPopUp.fader.SetActive(true);
          yield return (object) new WaitForSeconds(EvolutionPopUp.duration - EvolutionPopUp.overlap);
          EvolutionPopUp.BackgroundFade(0.0f, 1f, EvolutionPopUp.fadeInDur, EvolutionPopUp.fadeInType);
          yield return (object) new WaitForSeconds(EvolutionPopUp.fadeInDur);
          yield return (object) EvolutionPopUp.Evos();
          SfxSystem.OneShot("event:/sfx/inventory/charm_assign");
          EvolutionPopUp.continueButton.gameObject.SetActive(false);
          yield return (object) new WaitForSeconds(EvolutionPopUp.hold);
          EvolutionPopUp.BackgroundFade(1f, 0.0f, EvolutionPopUp.fadeOutDur, EvolutionPopUp.fadeOutType);
          yield return (object) new WaitForSeconds(EvolutionPopUp.fadeOutDur);
          EvolutionPopUp.fader.SetActive(false);
          Pokefrost.Pokefrost.fx.TryPlaySound("evolution");
        }
        yield return (object) new WaitUntil((Func<bool>) (() => EvolutionPopUp.eventProgress > 1));
        if (EvolutionPopUp.eventProgress == 2)
        {
          Routine.Clump clump = new Routine.Clump();
          for (int i = EvolutionPopUp.sequence.container1.Count - 1; i >= 0; --i)
          {
            clump.Add(new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) EvolutionPopUp.sequence.container1[i])));
            yield return (object) new WaitForSeconds(EvolutionPopUp.frequency);
          }
          yield return (object) clump.WaitForEnd();
          yield return (object) new WaitForSeconds(EvolutionPopUp.endDelay);
          clump = (Routine.Clump) null;
        }
        EvolutionPopUp.evolvedPokemonLastBattle.Clear();
        EvolutionPopUp.pokemonEvolvedIntoLastBattle.Clear();
        EvolutionPopUp.sequence.End();
      }
    }

    public static void End()
    {
      if (EvolutionPopUp.eventProgress == 0)
      {
        EvolutionPopUp.eventProgress = 3;
      }
      else
      {
        if (EvolutionPopUp.eventProgress != 1)
          return;
        EvolutionPopUp.eventProgress = 2;
      }
    }

    public static void MoveCardToDeck(Entity entity)
    {
      global::Events.InvokeEntityEnterBackpack(entity);
      entity.transform.parent = References.Player.entity.display.transform;
      entity.display?.hover?.Disable();
      Routine routine = new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) entity));
    }

    public static IEnumerator Preevos()
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count == 1)
      {
        string preEvo = EvolutionPopUp.evolvedPokemonLastBattle[0].title;
        string evo = EvolutionPopUp.pokemonEvolvedIntoLastBattle[0].title;
        EvolutionPopUp.titleObject.fontSize = 0.55f;
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey1A).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) preEvo);
        preEvo = (string) null;
        evo = (string) null;
        text = (string) null;
      }
      else
      {
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey1B).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) EvolutionPopUp.evolvedPokemonLastBattle.Count);
        text = (string) null;
      }
      yield return (object) EvolutionPopUp.CreateCardsAlt(EvolutionPopUp.evolvedPokemonLastBattle);
      string text2 = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoObserve).GetLocalizedString();
      EvolutionPopUp.continueButton.GetComponentInChildren<TextMeshProUGUI>().SetText(text2);
    }

    public static IEnumerator Evos()
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count == 1)
      {
        string preEvo = EvolutionPopUp.evolvedPokemonLastBattle[0].title;
        string evo = Pokefrost.Pokefrost.instance.Get<CardData>(EvolutionPopUp.pokemonEvolvedIntoLastBattle[0].name)?.title ?? EvolutionPopUp.pokemonEvolvedIntoLastBattle[0].name;
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey2A).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) preEvo, (object) evo);
        preEvo = (string) null;
        evo = (string) null;
        text = (string) null;
      }
      else
      {
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey2B).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) EvolutionPopUp.pokemonEvolvedIntoLastBattle.Count);
        text = (string) null;
      }
      EvolutionPopUp.sequence.container1.ClearAndDestroyAllImmediately();
      yield return (object) EvolutionPopUp.CreateCardsAlt(EvolutionPopUp.pokemonEvolvedIntoLastBattle, true);
    }

    public static IEnumerator CreateCardsAlt(List<CardData> cards, bool flipped = false)
    {
      EvolutionPopUp.sequence.SetScaleAndPosition(cards.Count);
      Routine.Clump clump = new Routine.Clump();
      int num = Math.Min(cards.Count, 4);
      EvolutionPopUp.sequence.container1.gap = EvolutionPopUp.gap;
      EvolutionPopUp.sequence.container1.SetSize(num, 0.8f);
      foreach (CardData card in cards)
        clump.Add(EvolutionPopUp.sequence.CreateCard(card, (CardContainer) EvolutionPopUp.sequence.container1, flipped));
      yield return (object) clump.WaitForEnd();
      EvolutionPopUp.sequence.group.SetActive(true);
      EvolutionPopUp.sequence.container1.SetChildPositions();
    }

    public static void ProgressEvent()
    {
      ++EvolutionPopUp.eventProgress;
      EvolutionPopUp.continueButton.interactable = false;
    }

    public static void BackgroundFade(float from, float to, float dur, LeanTweenType type)
    {
      LeanTween.cancel(EvolutionPopUp.fader);
      LeanTween.value(EvolutionPopUp.fader, from, to, dur).setEase(type).setOnUpdate((Action<float>) (a => EvolutionPopUp.fader.GetComponent<Image>().color = Color.white.WithAlpha(a)));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.Ext
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public static class Ext
  {
    public static Sprite panel;
    public static Sprite panelSmall;

    public static StringTable Collection
    {
      get
      {
        return LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      }
    }

    public static StringTable KeyCollection
    {
      get
      {
        return LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      }
    }

    public static void CreateColoredInkAnim(WildfrostMod mod, Color color, string type)
    {
      VfxStatusSystem objectOfType = UnityEngine.Object.FindObjectOfType<VfxStatusSystem>();
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(objectOfType.profileLookup["ink"].applyEffectPrefab, Pokefrost.Pokefrost.pokefrostUI.transform);
      ParticleSystem component1 = gameObject.transform.GetChild(0).GetComponent<ParticleSystem>();
      component1.colorOverLifetime.color = (ParticleSystem.MinMaxGradient) color;
      component1.main.startColor = (ParticleSystem.MinMaxGradient) color;
      Sprite sprite1 = AddressableExtMethods.ASprite("Splatter.png");
      ParticleSystem component2 = gameObject.transform.GetChild(4).GetComponent<ParticleSystem>();
      component2.textureSheetAnimation.AddSprite(sprite1);
      component2.textureSheetAnimation.RemoveSprite(0);
      component2.main.startColor = (ParticleSystem.MinMaxGradient) color;
      ParticleSystem component3 = gameObject.transform.GetChild(5).GetComponent<ParticleSystem>();
      component3.textureSheetAnimation.AddSprite(sprite1);
      component3.textureSheetAnimation.RemoveSprite(0);
      component3.main.startColor = (ParticleSystem.MinMaxGradient) color;
      ParticleSystem component4 = gameObject.transform.GetChild(6).GetComponent<ParticleSystem>();
      component4.textureSheetAnimation.AddSprite(sprite1);
      component4.textureSheetAnimation.RemoveSprite(0);
      component4.main.startColor = (ParticleSystem.MinMaxGradient) color;
      Sprite sprite2 = mod.ImagePath("Splat.png").ToSprite();
      ParticleSystem component5 = gameObject.transform.GetChild(9).GetComponent<ParticleSystem>();
      component5.textureSheetAnimation.AddSprite(sprite2);
      component5.textureSheetAnimation.RemoveSprite(0);
      component5.main.startColor = (ParticleSystem.MinMaxGradient) color;
      VfxStatusSystem.Profile profile = new VfxStatusSystem.Profile()
      {
        type = type,
        applyEffectPrefab = gameObject
      };
      objectOfType.profiles = ((IEnumerable<VfxStatusSystem.Profile>) objectOfType.profiles).AddItem<VfxStatusSystem.Profile>(profile).ToArray<VfxStatusSystem.Profile>();
      objectOfType.profileLookup["juice"] = profile;
    }

    public static void PopupText(Transform transform, string s, bool localized = true)
    {
      NoTargetTextSystem objectOfType = UnityEngine.Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((UnityEngine.Object) objectOfType != (UnityEngine.Object) null))
        return;
      TMP_Text textElement = objectOfType.textElement;
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      string str = localized ? collection.GetString(s).GetLocalizedString() : s;
      textElement.text = str;
      objectOfType.PopText(transform.position);
    }

    public static void AddLookup(string summoned, string summoner)
    {
      CreatedByLookup.lookup[summoned] = summoner;
    }

    public static void LoadPanels(WildfrostMod mod)
    {
      Ext.panel = AddressableExtMethods.ASprite("Panel");
      Ext.panelSmall = AddressableExtMethods.ASprite("PanelSmall");
    }

    public static T[] RemoveNulls<T>(this T[] data, WildfrostMod mod) where T : DataFile
    {
      List<T> list = data.ToList<T>();
      list.RemoveAll((Predicate<T>) (x => (UnityEngine.Object) x == (UnityEngine.Object) null || x?.ModAdded == mod));
      return list.ToArray();
    }

    public static T CreateTrait<T>(
      string name,
      WildfrostMod mod,
      KeywordData keyword,
      params StatusEffectData[] effects)
      where T : TraitData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = name;
      instance.effects = effects;
      instance.keyword = keyword;
      instance.ModAdded = mod;
      AddressableLoader.AddToGroup<TraitData>("TraitData", (TraitData) instance);
      return instance;
    }

    public static T CreateStatus<T>(
      string name,
      string desc = null,
      string textInsert = null,
      string type = "",
      bool boostable = false,
      bool stackable = true)
      where T : StatusEffectData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = name;
      instance.targetConstraints = new TargetConstraint[0];
      if (!desc.IsNullOrEmpty())
      {
        Ext.Collection.SetString(name + "_text", desc);
        instance.textKey = Ext.Collection.GetString(name + "_text");
        if (!textInsert.IsNullOrEmpty())
          instance.textInsert = textInsert;
      }
      instance.type = type;
      instance.hiddenKeywords = new KeywordData[0];
      instance.canBeBoosted = boostable;
      instance.stackable = stackable;
      return instance;
    }

    public static T SetConstraints<T>(this T t, params TargetConstraint[] ts) where T : StatusEffectData
    {
      t.targetConstraints = ts;
      return t;
    }

    public static T ApplyX<T>(
      this T t,
      StatusEffectData effectToApply,
      StatusEffectApplyX.ApplyToFlags flags)
      where T : StatusEffectApplyX
    {
      t.effectToApply = effectToApply;
      t.applyToFlags = flags;
      return t;
    }

    public static T SetApplyConstraints<T>(this T t, params TargetConstraint[] ts) where T : StatusEffectApplyX
    {
      t.applyConstraints = ts;
      return t;
    }

    public static T Register<T>(this T status, WildfrostMod mod) where T : StatusEffectData
    {
      status.ModAdded = mod;
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) status);
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) status);
      return status;
    }

    public static GameObject CreateButtonIcon(
      this WildfrostMod mod,
      string name,
      Sprite sprite,
      string type,
      string copyTextFrom,
      Color textColor,
      KeywordData[] keys)
    {
      GameObject buttonIcon = new GameObject(name);
      buttonIcon.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform);
      buttonIcon.SetActive(false);
      StatusIconExt statusIconExt = buttonIcon.AddComponent<StatusIconExt>();
      Dictionary<string, GameObject> cardIcons = CardManager.cardIcons;
      statusIconExt.animator = buttonIcon.AddComponent<ButtonAnimator>();
      statusIconExt.button = buttonIcon.AddComponent<ButtonExt>();
      statusIconExt.animator.button = (Selectable) statusIconExt.button;
      if (!copyTextFrom.IsNullOrEmpty())
      {
        GameObject gameObject = cardIcons[copyTextFrom].GetComponentInChildren<TextMeshProUGUI>().gameObject.InstantiateKeepName<GameObject>();
        gameObject.transform.SetParent(buttonIcon.transform);
        statusIconExt.textElement = (TMP_Text) gameObject.GetComponent<TextMeshProUGUI>();
        statusIconExt.textColour = textColor;
        statusIconExt.textColourAboveMax = textColor;
        statusIconExt.textColourBelowMax = textColor;
      }
      statusIconExt.onCreate = new UnityEvent();
      statusIconExt.onDestroy = new UnityEvent();
      statusIconExt.onValueDown = new UnityEventStatStat();
      statusIconExt.onValueUp = new UnityEventStatStat();
      statusIconExt.afterUpdate = new UnityEvent();
      buttonIcon.AddComponent<Image>().sprite = sprite;
      CardHover cardHover = buttonIcon.AddComponent<CardHover>();
      cardHover.enabled = false;
      cardHover.IsMaster = false;
      CardPopUpTarget cardPopUpTarget = buttonIcon.AddComponent<CardPopUpTarget>();
      cardPopUpTarget.keywords = keys;
      cardHover.pop = cardPopUpTarget;
      RectTransform component = buttonIcon.GetComponent<RectTransform>();
      component.anchorMin = Vector2.zero;
      component.anchorMax = Vector2.zero;
      component.sizeDelta *= 0.008f;
      buttonIcon.SetActive(true);
      statusIconExt.type = type;
      cardIcons[type] = buttonIcon;
      buttonIcon.AddComponent<UINavigationItem>();
      return buttonIcon;
    }

    public static GameObject CreateIcon(
      this WildfrostMod mod,
      string name,
      Sprite sprite,
      string type,
      string copyTextFrom,
      Color textColor,
      KeywordData[] keys,
      int posX = 1)
    {
      GameObject icon = new GameObject(name);
      icon.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform);
      icon.SetActive(false);
      StatusIcon statusIcon = (StatusIcon) icon.AddComponent<StatusIconExt>();
      Dictionary<string, GameObject> cardIcons = CardManager.cardIcons;
      if (!copyTextFrom.IsNullOrEmpty())
      {
        GameObject gameObject = cardIcons[copyTextFrom].GetComponentInChildren<TextMeshProUGUI>().gameObject.InstantiateKeepName<GameObject>();
        gameObject.transform.SetParent(icon.transform);
        statusIcon.textElement = (TMP_Text) gameObject.GetComponent<TextMeshProUGUI>();
        statusIcon.textColour = textColor;
        statusIcon.textColourAboveMax = textColor;
        statusIcon.textColourBelowMax = textColor;
      }
      statusIcon.onCreate = new UnityEvent();
      statusIcon.onDestroy = new UnityEvent();
      statusIcon.onValueDown = new UnityEventStatStat();
      statusIcon.onValueUp = new UnityEventStatStat();
      statusIcon.afterUpdate = new UnityEvent();
      icon.AddComponent<Image>().sprite = sprite;
      CardHover cardHover = icon.AddComponent<CardHover>();
      cardHover.enabled = false;
      cardHover.IsMaster = false;
      CardPopUpTarget cardPopUpTarget = icon.AddComponent<CardPopUpTarget>();
      cardPopUpTarget.keywords = keys;
      cardPopUpTarget.posX = (float) posX;
      cardHover.pop = cardPopUpTarget;
      RectTransform component = icon.GetComponent<RectTransform>();
      component.anchorMin = Vector2.zero;
      component.anchorMax = Vector2.zero;
      component.sizeDelta *= 0.01f;
      icon.SetActive(true);
      statusIcon.type = type;
      cardIcons[type] = icon;
      return icon;
    }

    public static KeywordData CreateBasicKeyword(
      this WildfrostMod mod,
      string name,
      string title,
      string desc,
      bool useSmallPanel = false)
    {
      KeywordData instance = ScriptableObject.CreateInstance<KeywordData>();
      instance.name = name;
      Ext.KeyCollection.SetString(instance.name + "_text", title);
      instance.titleKey = Ext.KeyCollection.GetString(instance.name + "_text");
      Ext.KeyCollection.SetString(instance.name + "_desc", desc);
      instance.descKey = Ext.KeyCollection.GetString(instance.name + "_desc");
      instance.ModAdded = mod;
      instance.showName = true;
      instance.panelSprite = useSmallPanel ? Ext.panelSmall : Ext.panel;
      instance.panelColor = new Color(0.15f, 0.15f, 0.15f, 0.9f);
      AddressableLoader.AddToGroup<KeywordData>("KeywordData", instance);
      return instance;
    }

    public static KeywordData CreateIconKeyword(
      this WildfrostMod mod,
      string name,
      string title,
      string desc,
      string icon,
      bool useSmallPanel = false)
    {
      KeywordData instance = ScriptableObject.CreateInstance<KeywordData>();
      instance.name = name;
      Ext.KeyCollection.SetString(instance.name + "_text", title);
      instance.titleKey = Ext.KeyCollection.GetString(instance.name + "_text");
      Ext.KeyCollection.SetString(instance.name + "_desc", desc);
      instance.descKey = Ext.KeyCollection.GetString(instance.name + "_desc");
      instance.showIcon = true;
      instance.showName = false;
      instance.iconName = icon;
      instance.ModAdded = mod;
      instance.panelSprite = useSmallPanel ? Ext.panelSmall : Ext.panel;
      instance.panelColor = new Color(0.15f, 0.15f, 0.15f, 0.9f);
      AddressableLoader.AddToGroup<KeywordData>("KeywordData", instance);
      return instance;
    }

    public static KeywordData ChangeColor(
      this KeywordData data,
      Color? title = null,
      Color? body = null,
      Color? note = null)
    {
      Color valueOrDefault1;
      int num1;
      if (title.HasValue)
      {
        valueOrDefault1 = title.GetValueOrDefault();
        num1 = 1;
      }
      else
        num1 = 0;
      if (num1 != 0)
        data.titleColour = valueOrDefault1;
      Color valueOrDefault2;
      int num2;
      if (body.HasValue)
      {
        valueOrDefault2 = body.GetValueOrDefault();
        num2 = 1;
      }
      else
        num2 = 0;
      if (num2 != 0)
        data.bodyColour = valueOrDefault2;
      Color valueOrDefault3;
      int num3;
      if (note.HasValue)
      {
        valueOrDefault3 = note.GetValueOrDefault();
        num3 = 1;
      }
      else
        num3 = 0;
      if (num3 != 0)
        data.noteColour = valueOrDefault3;
      return data;
    }

    public static KeywordData ChangePanel(this KeywordData data, Sprite panel = null, Color? color = null)
    {
      if ((UnityEngine.Object) panel != (UnityEngine.Object) null)
        data.panelSprite = panel;
      Color valueOrDefault;
      int num;
      if (color.HasValue)
      {
        valueOrDefault = color.GetValueOrDefault();
        num = 1;
      }
      else
        num = 0;
      data.panelColor = num == 0 ? Color.white : valueOrDefault;
      return data;
    }

    public static T CreateStatusButton<T>(
      this WildfrostMod mod,
      string name,
      string type,
      string iconGroup = "counter")
      where T : StatusEffectData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = name;
      instance.targetConstraints = new TargetConstraint[0];
      instance.type = type;
      instance.isStatus = true;
      instance.iconGroupName = iconGroup;
      instance.visible = true;
      instance.stackable = false;
      return instance;
    }

    public static CampaignNodeTypeBuilder CreateCampaignNodeType<T>(
      this WildfrostMod mod,
      string name,
      string letter,
      bool canSkip = true)
      where T : CampaignNodeType
    {
      return new CampaignNodeTypeBuilder(mod).Create<T>(name).WithCanEnter(true).WithCanLink(true).WithInteractable(true).WithCanSkip(canSkip).WithMustClear(!canSkip).WithLetter(letter).WithZoneName(name);
    }

    public static GameModifierDataBuilder CreateBell(
      this WildfrostMod mod,
      string name,
      string title,
      string description)
    {
      return new GameModifierDataBuilder(mod).Create(name).WithTitle(title).WithDescription(description).WithRingSfxEvent(mod.Get<GameModifierData>("DoubleBlingsFromCombos").ringSfxEvent);
    }

    public static GameModifierDataBuilder ChangeSprites(
      this GameModifierDataBuilder b,
      string bell = null,
      string dinger = null)
    {
      GameModifierData data = b._data;
      if (!bell.IsNullOrEmpty())
      {
        Texture2D tex = Pokefrost.Pokefrost.instance.ImagePath(bell).ToTex();
        data.bellSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, (float) tex.width, (float) tex.height), new Vector2(0.5f, 0.9f), 327f);
      }
      if (!dinger.IsNullOrEmpty())
      {
        Texture2D tex = Pokefrost.Pokefrost.instance.ImagePath(dinger).ToTex();
        data.dingerSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, (float) tex.width, (float) tex.height), new Vector2(0.5f, 1.5f), 327f);
      }
      return b;
    }

    public static CampaignNodeTypeBuilder BetterEvent(
      this CampaignNodeTypeBuilder cn,
      string key,
      WildfrostMod mod)
    {
      MapNode mapNodePrefab = mod.Get<CampaignNodeType>("CampaignNodeCharm").mapNodePrefab.InstantiateKeepName<MapNode>();
      mapNodePrefab.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform, false);
      StringTable collection = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString("map_" + mapNodePrefab.name, key);
      mapNodePrefab.label.GetComponentInChildren<LocalizeStringEvent>().StringReference = collection.GetString("map_" + mapNodePrefab.name);
      mapNodePrefab.spriteOptions[0] = AddressableExtMethods.ASprite("trade_event");
      mapNodePrefab.clearedSpriteOptions[0] = AddressableExtMethods.ASprite("trade_done");
      return cn.WithMapNodePrefab(mapNodePrefab).FreeModify<CampaignNodeTypeTrade>((Action<CampaignNodeTypeTrade>) (data => data.key = key));
    }

    public static CampaignNodeTypeBuilder BetterBattle(
      this CampaignNodeTypeBuilder cn,
      WildfrostMod mod)
    {
      MapNode mapNodePrefab = mod.Get<CampaignNodeType>("CampaignNodeBattle").mapNodePrefab.InstantiateKeepName<MapNode>();
      mapNodePrefab.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform, false);
      return cn.WithMapNodePrefab(mapNodePrefab);
    }

    public static void Register(this CampaignNodeTypeBuilder cn, WildfrostMod mod)
    {
      CampaignNodeType campaignNodeType = cn.Build();
      campaignNodeType.ModAdded = mod;
      AddressableLoader.AddToGroup<CampaignNodeType>("CampaignNodeType", campaignNodeType);
    }

    public static CardDataBuilder SStartEffects(
      this CardDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.startWithEffects = array;
      }));
    }

    public static CardUpgradeDataBuilder SEffects(
      this CardUpgradeDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.effects = array;
      }));
    }

    public static CardDataBuilder SAttackEffects(
      this CardDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.attackEffects = array;
      }));
    }

    public static CardUpgradeDataBuilder SAttackEffects(
      this CardUpgradeDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.attackEffects = array;
      }));
    }

    public static CardDataBuilder STraits(this CardDataBuilder b, params (string, int)[] traits)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        List<CardData.TraitStacks> list = ((IEnumerable<(string, int)>) traits).Select<(string, int), CardData.TraitStacks>((Func<(string, int), CardData.TraitStacks>) (tr => new CardData.TraitStacks(Pokefrost.Pokefrost.instance.Get<TraitData>(tr.Item1), tr.Item2))).ToList<CardData.TraitStacks>();
        data.traits = list;
      }));
    }

    public static CardUpgradeDataBuilder STraits(
      this CardUpgradeDataBuilder b,
      params (string, int)[] traits)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.TraitStacks[] array = ((IEnumerable<(string, int)>) traits).Select<(string, int), CardData.TraitStacks>((Func<(string, int), CardData.TraitStacks>) (tr => new CardData.TraitStacks(Pokefrost.Pokefrost.instance.Get<TraitData>(tr.Item1), tr.Item2))).ToArray<CardData.TraitStacks>();
        data.giveTraits = array;
      }));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EyeDataAdder
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public static class EyeDataAdder
  {
    private static Dictionary<string, (float, float, float, float, float)[]> eyeDictionary = new Dictionary<string, (float, float, float, float, float)[]>()
    {
      {
        "websiteofsites.wildfrost.pokefrost.alolansandslash",
        new (float, float, float, float, float)[2]
        {
          (0.6f, 0.8f, 0.8f, 1.2f, 45f),
          (1.1f, 0.8f, 0.4f, 0.7f, -10f)
        }
      }
    };

    public static void Eyes()
    {
      AddressableLoader.AddRangeToGroup<EyeData>("EyeData", (IEnumerable<EyeData>) new List<EyeData>()
      {
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.abomasnow", (0.36f, 1.9f, 1.2f, 1.2f, 0.0f), (-0.08f, 1.9f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.absol", (-0.32f, 1.47f, 0.8f, 0.8f, 0.0f), (-0.67f, 1.46f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.aggron", (0.67f, 1.94f, 0.7f, 0.7f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.alolanmarowak", (0.5f, 0.75f, 0.7f, 1.3f, 45f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.alolansandslash", (1.09f, 0.79f, 0.5f, 1.3f, 340f), (0.62f, 0.77f, 0.8f, 1.5f, 40f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.ambipom", (-0.25f, 1.17f, 0.7f, 0.9f, 0.0f), (0.22f, 1.16f, 0.7f, 0.9f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.bastiodon", (0.28f, 0.59f, 1f, 1f, 55f), (1.06f, 0.8f, 0.8f, 0.8f, 55f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.chandelure", (-0.03f, 0.82f, 1f, 1f, 0.0f), (0.58f, 0.71f, 0.4f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.chimecho", (0.22f, 1.84f, 0.6f, 0.6f, 0.0f), (0.57f, 1.74f, 0.5f, 0.5f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.cradily", (0.01f, 1.11f, 1f, 1.6f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.crustle", (0.39f, 0.41f, 0.6f, 0.9f, 10f), (0.75f, 0.39f, 0.5f, 0.9f, 345f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.dusclops", (0.44f, 1.57f, 1.3f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.electrode", (0.04f, 1.11f, 1f, 1.1f, 0.0f), (0.97f, 1.18f, 1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.empoleon", (-0.21f, 1.9f, 0.5f, 0.5f, 0.0f), (0.06f, 1.9f, 0.4f, 0.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.espeon", (0.57f, 1.44f, 1f, 1f, 0.0f), (1.04f, 1.65f, 0.8f, 0.8f, 335f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.farfetchd", (-0.17f, 1.3f, 0.7f, 1f, 0.0f), (0.2f, 1.26f, 0.5f, 0.9f, 350f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.flareon", (0.75f, 0.57f, 0.9f, 0.9f, 350f), (1.14f, 0.65f, 0.3f, 0.6f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.furret", (-0.19f, 1.89f, 0.6f, 0.6f, 0.0f), (0.18f, 1.95f, 0.5f, 0.5f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gallade", (-0.08f, 1.66f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.garbodor", (-0.43f, 1.49f, 0.9f, 0.9f, 0.0f), (0.33f, 1.57f, 0.8f, 0.9f, 20f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gardevoir", (0.63f, 1.92f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gengar", (-0.15f, 1.13f, 1.3f, 1.3f, 0.0f), (0.53f, 1.31f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.glaceon", (0.62f, 1.13f, 0.9f, 0.9f, 0.0f), (0.97f, 1.22f, 0.6f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.goomy", (0.36f, 0.94f, 1f, 1f, 0.0f), (0.69f, 0.9f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gyarados", (1.04f, 1.17f, 0.8f, 1f, 0.0f), (1.31f, 1.2f, 0.6f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.hariyama", (0.08f, 1.63f, 1f, 1.2f, 0.0f), (0.55f, 1.73f, 0.8f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.hippowdon", (-0.15f, 1.25f, 0.7f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.hisuiansneasel", (0.22f, 1.26f, 1.2f, 1.2f, 0.0f), (0.78f, 1.31f, 0.9f, 0.9f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.honchkrow", (-0.19f, 1.35f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.jolteon", (0.93f, 1.23f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.kingambit", (0.03f, 1f, 0.6f, 0.6f, 0.0f), (0.23f, 1f, 0.6f, 0.6f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.kingdra", (0.53f, 1.42f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.klefki", (-0.22f, 0.69f, 0.6f, 0.8f, 0.0f), (0.06f, 0.71f, 0.6f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.leafeon", (0.56f, 1.16f, 1f, 1f, 0.0f), (0.97f, 1.17f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.lickilicky", (-0.14f, 2.02f, 1.1f, 1.1f, 0.0f), (0.49f, 2.03f, 1.1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.ludicolo", (-0.07f, 1.41f, 0.9f, 1.2f, 15f), (0.26f, 1.48f, 0.9f, 1.2f, 10f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.lumineon", (0.59f, 0.57f, 1f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.machamp", (0.05f, 1.3f, 1f, 1f, 0.0f), (0.32f, 1.23f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.magcargo", (0.28f, 1.74f, 1.6f, 2.6f, 15f), (0.96f, 1.83f, 1.6f, 2.6f, 15f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.magneton", (0.03f, 1.4f, 2f, 2f, 0.0f), (-0.88f, 0.54f, 1.4f, 1.9f, 0.0f), (0.78f, 0.52f, 1.5f, 1.9f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.marowak", (0.64f, 0.96f, 1f, 2f, 50f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.muk", (0.06f, 1.23f, 1.2f, 0.4f, 15f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.musharna", (0.28f, 0.67f, 1.3f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.ninjask", (0.11f, 0.95f, 1.2f, 1.2f, 0.0f), (0.85f, 1.04f, 1.1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.nosepass", (-0.33f, 1.53f, 2.5f, 1.6f, 30f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.persian", (0.52f, 1.96f, 0.8f, 1f, 30f), (0.99f, 1.96f, 1.3f, 1f, 30f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.polteageist", (-0.04f, 2.19f, 0.6f, 1f, 0.0f), (0.22f, 2.22f, 0.6f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotom", (-0.16f, 1.37f, 0.8f, 1.7f, 30f), (0.21f, 1.48f, 0.8f, 1.7f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomfan", (0.02f, 0.46f, 0.9f, 1.6f, 30f), (0.4f, 0.49f, 0.9f, 1.6f, 355f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomfrost", (-0.11f, 1.1f, 1.1f, 2f, 40f), (0.4f, 1.2f, 1.1f, 2f, 355f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomheat", (-0.22f, 1.15f, 1.2f, 2f, 25f), (0.36f, 1.12f, 1.2f, 2f, 335f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotommow", (0.15f, 0.71f, 1.3f, 2.1f, 20f), (0.73f, 0.63f, 1.1f, 2f, 345f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomwash", (-0.53f, 1.54f, 1f, 1.8f, 35f), (0.0f, 1.62f, 1f, 1.9f, 345f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sableye", (-0.18f, 1.18f, 2.7f, 2.7f, 0.0f), (0.58f, 1.33f, 1.8f, 2.5f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.salazzle", (0.39f, 2.35f, 1.5f, 0.8f, 340f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sharpedo", (0.24f, 1.41f, 1.3f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.slowbro", (0.14f, 1.82f, 1.4f, 1.4f, 0.0f), (0.8f, 1.84f, 1.4f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.slowking", (-0.56f, 1.63f, 1.2f, 1.2f, 0.0f), (-0.2f, 1.59f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.smeargle", (0.1f, 1.3f, 1.1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sneasel", (0.14f, 1.39f, 0.8f, 1f, 0.0f), (0.52f, 1.41f, 0.7f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.snorlax", (-0.28f, 1.2f, 1.3f, 1f, 0.0f), (0.35f, 1.22f, 1.3f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.spheal", (0.37f, 1.22f, 1.2f, 1.2f, 0.0f), (0.81f, 1.34f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.spinda", (-0.33f, 1.18f, 1f, 1f, 0.0f), (0.45f, 1.36f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sylveon", (0.33f, 1.25f, 1f, 1.3f, 0.0f), (0.75f, 1.34f, 1f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.toxicroak", (0.1f, 1.73f, 1.3f, 1.1f, 0.0f), (0.74f, 1.77f, 1.2f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.tyrantrum", (0.75f, 1.24f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.umbreon", (0.76f, 1.41f, 1.4f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.vaporeon", (-0.15f, 1.71f, 1.2f, 1.2f, 0.0f), (0.35f, 1.81f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.volcarona", (0.3f, 1.57f, 1.1f, 0.6f, 310f), (0.53f, 1.52f, 0.8f, 0.2f, 55f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.weezing", (-0.87f, 1.42f, 1f, 1f, 0.0f), (-0.51f, 1.5f, 1f, 1f, 0.0f), (0.27f, 1.25f, 1.5f, 1.5f, 0.0f), (0.91f, 1.07f, 1.4f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.whimsicott", (0.04f, 1.03f, 0.7f, 1.4f, 0.0f), (0.44f, 1f, 0.7f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.xatu", (0.05f, 1.9f, 1.7f, 1.1f, 0.0f))
      });
    }

    public static EyeData Eyes(string cardName, params (float, float, float, float, float)[] data)
    {
      EyeData instance = ScriptableObject.CreateInstance<EyeData>();
      instance.cardData = cardName;
      instance.name = instance.cardData + "_EyeData";
      instance.eyes = ((IEnumerable<(float, float, float, float, float)>) data).Select<(float, float, float, float, float), EyeData.Eye>((Func<(float, float, float, float, float), EyeData.Eye>) (e => new EyeData.Eye()
      {
        position = new Vector2(e.Item1, e.Item2),
        scale = new Vector2(e.Item3, e.Item4),
        rotation = e.Item5
      })).ToArray<EyeData.Eye>();
      return instance;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.AppendCardReplacement
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (FinalBossGenerationSettings), "ReplaceCards", new System.Type[] {typeof (IList<CardData>)})]
  internal class AppendCardReplacement
  {
    internal static void Prefix(FinalBossGenerationSettings __instance)
    {
      foreach (FinalBossGenerationSettings.ReplaceCard replaceCard in __instance.replaceCards)
      {
        if (replaceCard.card.name == "websiteofsites.wildfrost.pokefrost.eevee")
          return;
      }
      List<FinalBossGenerationSettings.ReplaceCard> replaceCardList = new List<FinalBossGenerationSettings.ReplaceCard>();
      foreach (CardDataBuilder cardDataBuilder in Pokefrost.Pokefrost.instance.list)
      {
        CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>(cardDataBuilder._data.name);
        foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
        {
          if (startWithEffect.data is StatusEffectEvolve data)
          {
            Debug.Log((object) ("[Pokefrost] Replacing " + cardData.name));
            CardData[] cardDataArray = data.EvolveForFinalBoss((WildfrostMod) Pokefrost.Pokefrost.instance);
            if (cardDataArray != null)
            {
              FinalBossGenerationSettings.ReplaceCard replaceCard = new FinalBossGenerationSettings.ReplaceCard()
              {
                card = cardData,
                options = cardDataArray
              };
              replaceCardList.Add(replaceCard);
            }
          }
        }
      }
      __instance.replaceCards = ((IEnumerable<FinalBossGenerationSettings.ReplaceCard>) __instance.replaceCards.AddRangeToArray<FinalBossGenerationSettings.ReplaceCard>(replaceCardList.ToArray())).ToArray<FinalBossGenerationSettings.ReplaceCard>();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.FixClassesGetter
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (References), "Classes", MethodType.Getter)]
  internal static class FixClassesGetter
  {
    private static void Postfix(ref ClassData[] __result)
    {
      __result = AddressableLoader.GetGroup<ClassData>("ClassData").ToArray();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.FixTribeFlags
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (InspectSystem), "GetClass", new System.Type[] {typeof (CardData)})]
  internal static class FixTribeFlags
  {
    internal static bool Prefix(ref ClassData __result, CardData cardData)
    {
      string name = cardData.name;
      if (!name.Contains("websiteofsites.wildfrost.pokefrost"))
        return true;
      foreach (string str in Pokefrost.Pokefrost.basicPool)
      {
        if (name.Contains(str))
        {
          __result = References.Classes[0];
          return false;
        }
      }
      foreach (string str in Pokefrost.Pokefrost.magicPool)
      {
        if (name.Contains(str))
        {
          __result = References.Classes[2];
          return false;
        }
      }
      foreach (string str in Pokefrost.Pokefrost.clunkPool)
      {
        if (name.Contains(str))
        {
          __result = References.Classes[1];
          return false;
        }
      }
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.Furret
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class Furret
  {
    [HarmonyPatch(typeof (InjuredCompanionEventSystem), "CampaignLoadPreset")]
    public class FurretCompanionEventSystem1
    {
      internal static bool Prefix(ref string[] lines)
      {
        string path = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "furret.txt");
        if (Campaign.Data.GameMode.mainGameMode && !Campaign.Data.GameMode.tutorialRun && File.Exists(path))
        {
          Debug.Log((object) "[Pokefrost] Adding Furret To Injured Companion Event");
          string[] strArray = File.ReadAllLines(path);
          int result;
          if (strArray.Length > 3 && int.TryParse(strArray[2], out result))
          {
            int num = result;
            int startIndex = num >= 6 ? 23 : (num >= 3 ? 11 : 2);
            lines[0] = lines[0].Insert(startIndex, "#");
            lines[1] = lines[1].Insert(startIndex, " ");
            lines[2] = lines[2].Insert(startIndex, lines[2][startIndex - 1].ToString());
            lines[3] = lines[3].Insert(startIndex, lines[3][startIndex - 1].ToString());
            return false;
          }
        }
        return true;
      }
    }

    [HarmonyPatch(typeof (InjuredCompanionEventSystem), "GetEligibleCompanions")]
    public class FurretCompanionEventSystem2
    {
      internal static bool Prefix(ref List<CardSaveData> __result)
      {
        string path = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "furret.txt");
        if (!File.Exists(path))
          return true;
        string[] strArray = File.ReadAllLines(path);
        if (strArray.Length <= 4)
          return true;
        CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>("furret").Clone();
        cardData.forceTitle = strArray[0].Trim();
        cardData.startWithEffects = new CardData.StatusEffectStacks[0];
        for (int index = 5; index < strArray.Length; ++index)
        {
          CardUpgradeData cardUpgradeData = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>(strArray[index].Trim());
          if ((Object) cardUpgradeData != (Object) null && cardUpgradeData.CanAssign(cardData))
            cardUpgradeData.Clone().Assign(cardData);
        }
        CardUpgradeData cardUpgradeData1 = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>("CardUpgradeRemoveCharmLimit");
        if (cardUpgradeData1.CanAssign(cardData))
          cardUpgradeData1.Clone().Assign(cardData);
        List<CardUpgradeData> group = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
        int num = Dead.Random.Range(20, 25);
        Debug.Log((object) ("[Pokefrost] Furret rolled " + num.ToString() + " charms"));
        for (int index1 = 0; index1 < num; ++index1)
        {
          int index2 = Dead.Random.Range(0, group.Count - 1);
          CardUpgradeData cardUpgradeData2 = group[index2].Clone();
          if (cardUpgradeData2.CanAssign(cardData) && cardUpgradeData2.tier > 0 && cardUpgradeData2.name != "CardUpgradeMuncher")
            cardUpgradeData2.Assign(cardData);
        }
        if (strArray[4].Trim() == "Hasty")
          Pokefrost.Pokefrost.instance.Shinify(cardData);
        __result = new List<CardSaveData>()
        {
          cardData.Save()
        };
        return false;
      }
    }

    [HarmonyPatch(typeof (EventRoutineInjuredCompanion), "Populate")]
    public class FurretCompanionEventSystem3
    {
      internal static IEnumerator Postfix(IEnumerator __result)
      {
        yield return (object) __result;
        string fileName = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "furret.txt");
        if (File.Exists(fileName))
        {
          string[] furretData = File.ReadAllLines(fileName);
          GameObject furretPanel = UICollector.PullPrefab("Box", "FurretBox", GameObject.Find("Canvas/SafeArea/EventManager/Event-InjuredCompanion(Clone)/EnterTweener/Zoomer/Inspect Companion/"));
          furretPanel.GetComponent<RectTransform>().sizeDelta = new Vector2(5f, 3f);
          furretPanel.transform.localPosition = new Vector3(5.3f, 1.9f, 0.0f);
          Sprite sprite = Pokefrost.Pokefrost.instance.ImagePath("FurretPanel.png").ToSprite();
          Debug.Log((object) "[Pokefrost] Made Sprite");
          Image image = furretPanel.GetComponent<Image>();
          if ((Object) image == (Object) null)
            Debug.Log((object) "[Pokefrost] Image null");
          Debug.Log((object) "[Pokefrost] Made Image");
          image.sprite = sprite;
          GameObject furretText = new GameObject("Paneltext");
          furretText.transform.SetParent(furretPanel.transform, false);
          TextMeshProUGUI text = furretText.AddComponent<TextMeshProUGUI>();
          furretText.GetComponent<RectTransform>().sizeDelta = new Vector2(4.5f, 2f);
          text.alignment = TextAlignmentOptions.Top;
          text.text = "<color=#FF8>" + furretData[1] + "'s</color> <color=#940>" + furretData[0] + "</color> is back!\n<color=#888><size=0.2>" + furretData[0] + " has been missing since " + furretData[3] + "</size></color>";
          File.Delete(fileName);
          furretData = (string[]) null;
          furretPanel = (GameObject) null;
          sprite = (Sprite) null;
          image = (Image) null;
          furretText = (GameObject) null;
          text = (TextMeshProUGUI) null;
        }
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.FXHelper
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using WildfrostHopeMod.SFX;
using WildfrostHopeMod.VFX;

#nullable disable
namespace Pokefrost
{
  public class FXHelper
  {
    public GIFLoader giffy;
    public SFXLoader silly;
    public WildfrostMod mod;

    public FXHelper(WildfrostMod mod, string animLocation, string soundLocation)
    {
      this.giffy = new GIFLoader((WildfrostMod) null, mod.ImagePath(animLocation));
      this.giffy.RegisterAllAsApplyEffect();
      this.silly = new SFXLoader(mod.ImagePath(soundLocation));
      this.silly.LoadSoundsFromDir(this.silly.Directory);
    }

    public void TryPlaySound(string key, SFXLoader.PlayAs playAs = SFXLoader.PlayAs.SFX)
    {
      this.silly.TryPlaySound(key, playAs);
    }

    public GameObject TryPlayEffect(
      string key,
      Vector3 position = default (Vector3),
      Vector3 scale = default (Vector3),
      GIFLoader.PlayType playAs = GIFLoader.PlayType.applyEffect)
    {
      return this.giffy.TryPlayEffect(key, position, scale, playAs);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.GatekeeperModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public class GatekeeperModifierSystem : QuestSystem
  {
    public static string Key_Fled = "websiteofsites.wildfrost.pokefrost.gatekeeperFlee";
    public string[] gatekeepers = new string[3]
    {
      "quest_entei",
      "quest_suicune",
      "quest_raikou"
    };

    public override string ProgressName => "ThreeBeasts";

    [PokeLocalizer]
    public new static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(GatekeeperModifierSystem.Key_Fled, "Nobody is here...");
    }

    public void OnEnable()
    {
      global::Events.OnEntityFlee += new UnityAction<Entity>(this.CheckFlee);
      global::Events.PostBattle += new UnityAction<CampaignNode>(this.ConfirmSpawn);
      this.FindProgress();
      if (this.progress != 0)
        return;
      this.SpawnGatekeepers();
    }

    private void ConfirmSpawn(CampaignNode _)
    {
      if (this.progress != 0)
        return;
      this.UpdateProgress(1);
    }

    public void OnDisable()
    {
      global::Events.OnEntityFlee -= new UnityAction<Entity>(this.CheckFlee);
      global::Events.PostBattle -= new UnityAction<CampaignNode>(this.ConfirmSpawn);
    }

    public void SpawnGatekeepers()
    {
      string[] array = ((IEnumerable<string>) this.gatekeepers).InRandomOrder<string>().ToArray<string>();
      int id = Campaign.FindCharacterNode(References.Player).id;
      int index1 = 0;
      for (int index2 = 0; index2 < Campaign.instance.nodes.Count && index1 < array.Length; ++index2)
      {
        CampaignNode node = Campaign.instance.nodes[index2];
        if (node.id > id)
        {
          if (node.type is CampaignNodeTypeSpecialBattle)
            break;
          if (node.type.isBattle && this.TryAddCard(array[index1], node))
            ++index1;
        }
      }
    }

    private bool TryAddCard(string name, CampaignNode node)
    {
      object obj;
      if (node.data.TryGetValue("waves", out obj))
      {
        BattleWaveManager.WaveData[] collection = ((SaveCollection<BattleWaveManager.WaveData>) obj).collection;
        for (int index = 0; index < collection.Length; ++index)
        {
          if (collection[index].Count < 6)
          {
            collection[index].AddCard(Pokefrost.Pokefrost.instance.Get<CardData>(name));
            return true;
          }
        }
        if (collection.Length != 0)
        {
          collection[0].AddCard(Pokefrost.Pokefrost.instance.Get<CardData>(name));
          return true;
        }
      }
      return false;
    }

    private void CheckFlee(Entity entity)
    {
      if (entity?.data?.name == null || !((IEnumerable<string>) this.gatekeepers).Select<string, string>((Func<string, string>) (s => Pokefrost.Pokefrost.instance.GUID + "." + s)).Contains<string>(entity.data.name))
        return;
      this.UpdateProgress(2);
    }

    public override bool CheckConditions(out string failureText)
    {
      failureText = this.GetFailureText(GatekeeperModifierSystem.Key_Fled);
      return this.progress == 1;
    }

    public override void QuestBattleFinish() => this.UpdateProgress(2);
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.IStatusToken
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public interface IStatusToken
  {
    void ButtonCreate(StatusIconExt icon);

    void RunButtonClicked();

    IEnumerator ButtonClicked();
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ModComp
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public static class ModComp
  {
    private static float tScale = 1f;
    private static float rScale = -30f;
    private static float dur = 1f;

    public static IEnumerator InspectCosmetic(RectTransform parent)
    {
      GameObject holder = new GameObject("Holder", new System.Type[1]
      {
        typeof (RectTransform)
      });
      holder.transform.SetParent(parent.transform, false);
      GameObject icon = new GameObject("Icon", new System.Type[1]
      {
        typeof (Image)
      });
      icon.transform.SetParent(holder.transform, false);
      icon.GetComponent<RectTransform>().sizeDelta = 5f * Vector2.one;
      icon.GetComponent<Image>().sprite = Pokefrost.Pokefrost.instance.IconSprite;
      AnimationCurve sineCurve = new AnimationCurve(new Keyframe[9]
      {
        new Keyframe(0.0f, 0.0f),
        new Keyframe(0.125f, 0.707f),
        new Keyframe(0.25f, 1f),
        new Keyframe(0.375f, 0.707f),
        new Keyframe(0.5f, 0.0f),
        new Keyframe(0.625f, -0.707f),
        new Keyframe(0.75f, -1f),
        new Keyframe(0.875f, -0.707f),
        new Keyframe(1f, 0.0f)
      });
      while (true)
      {
        yield return (object) Sequences.Wait(2f);
        LeanTween.moveLocalX(icon, ModComp.tScale, ModComp.dur).setEase(sineCurve);
        LeanTween.rotateZ(icon, ModComp.rScale, ModComp.dur).setEase(sineCurve);
        yield return (object) Sequences.Wait(ModComp.dur);
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.MoreEvents
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (global::Events))]
  internal class MoreEvents
  {
    public static event UnityAction OnCampaignGenerated;

    [HarmonyPatch("InvokeCampaignGenerated")]
    private static void Postfix()
    {
      if (MoreEvents.OnCampaignGenerated == null)
        return;
      MoreEvents.OnCampaignGenerated();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchAddComponent
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (GameObjectExt), "AddComponentByName")]
  internal class PatchAddComponent
  {
    private static string assem => typeof (PatchAddComponent).Assembly.GetName().Name;

    private static string namesp => typeof (PatchAddComponent).Namespace;

    private static Component Postfix(
      Component __result,
      GameObject gameObject,
      string componentName)
    {
      if ((UnityEngine.Object) __result == (UnityEngine.Object) null)
      {
        System.Type type = System.Type.GetType(PatchAddComponent.namesp + "." + componentName + "," + PatchAddComponent.assem);
        if (type != (System.Type) null)
          return gameObject.AddComponent(type);
      }
      return __result;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchDynamicKeyword
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (CardPopUpTarget), "Pop")]
  internal static class PatchDynamicKeyword
  {
    public static List<string> dynamicKeywords = new List<string>()
    {
      "pickup",
      "resist"
    };
    public static List<string> dynamicTypes = new List<string>()
    {
      typeof (StatusEffectPickup).Name,
      typeof (StatusEffectResist).Name
    };

    private static void Postfix(CardPopUpTarget __instance)
    {
      foreach (string str in __instance.current)
      {
        Tooltip tooltip;
        if (PatchDynamicKeyword.dynamicKeywords.Contains(str) && MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.TryGetValue(str, out tooltip))
        {
          int index = PatchDynamicKeyword.dynamicKeywords.IndexOf(str);
          string newValue = "???";
          if (__instance.IsCard)
          {
            foreach (StatusEffectData statusEffect in __instance.card.entity.statusEffects)
            {
              if (statusEffect.GetType().Name == PatchDynamicKeyword.dynamicTypes[index] | (statusEffect is StatusEffectApplyX statusEffectApplyX && (Object) statusEffectApplyX.effectToApply != (Object) null && statusEffectApplyX.effectToApply.GetType().Name == PatchDynamicKeyword.dynamicTypes[index]))
              {
                newValue = statusEffect.GetAmount().ToString();
                break;
              }
            }
          }
          KeywordData keyword = AddressableLoader.Get<KeywordData>("KeywordData", str);
          ((CardPopUpPanel) tooltip).Set(keyword, keyword.body.Replace("???", newValue));
        }
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchDynamicKeyword2
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (InspectSystem), "Popup", new System.Type[] {typeof (KeywordData), typeof (Transform)})]
  internal static class PatchDynamicKeyword2
  {
    private static void Postfix(InspectSystem __instance, KeywordData keyword)
    {
      if (!PatchDynamicKeyword.dynamicKeywords.Contains(keyword.name))
        return;
      CardPopUpPanel cardPopUpPanel = __instance.popups.FirstOrDefault<Tooltip>((Func<Tooltip, bool>) (p => p.name == keyword.name)) as CardPopUpPanel;
      int index = PatchDynamicKeyword.dynamicKeywords.IndexOf(keyword.name);
      string newValue = "???";
      foreach (StatusEffectData statusEffect in __instance.inspect.statusEffects)
      {
        if (statusEffect.GetType().Name == PatchDynamicKeyword.dynamicTypes[index])
          newValue = statusEffect.GetAmount().ToString();
      }
      cardPopUpPanel.Set(keyword, keyword.body.Replace("{0}", newValue));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchHarmony
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using HarmonyLib.Tools;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (WildfrostMod.DebugLoggerTextWriter), "WriteLine")]
  internal class PatchHarmony
  {
    private static bool Prefix()
    {
      PatchHarmony.Postfix();
      return false;
    }

    private static void Postfix()
    {
      Logger.ChannelFilter = Logger.LogChannel.Warn | Logger.LogChannel.Error;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchInkedTargetModeRemove
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (StatusEffectChangeTargetMode), "RunEndEvent")]
  internal static class PatchInkedTargetModeRemove
  {
    private static void Postfix(StatusEffectChangeTargetMode __instance)
    {
      if (!__instance.target.silenced)
        return;
      __instance.target.targetMode = (TargetMode) ScriptableObject.CreateInstance<TargetModeBasic>();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchInPetFlag
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (PetHutFlagSetter), "SetupFlag")]
  internal static class PatchInPetFlag
  {
    private static void Prefix(PetHutFlagSetter __instance)
    {
      __instance.flagSprites = ((IEnumerable<Sprite>) __instance.flagSprites).Append<Sprite>(AddressableExtMethods.ASprite("eeveeflag")).ToArray<Sprite>();
      __instance.flagSprites = ((IEnumerable<Sprite>) __instance.flagSprites).Append<Sprite>(AddressableExtMethods.ASprite("rotomflag")).ToArray<Sprite>();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchmentionedCards
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (Card), "SetDescription")]
  internal static class PatchmentionedCards
  {
    private static void Postfix(Card __instance)
    {
      CardData data = __instance.entity?.data;
      string name;
      if (!((Object) data != (Object) null) || !data.TryGetCustomData<string>("Future Sight", out name, "Junk"))
        return;
      CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>(name);
      if ((Object) cardData != (Object) null)
        __instance.mentionedCards.Add(cardData);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchNullCheckForFinalBossScripts
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (FinalBossGenerationSettings), "RunScripts")]
  internal class PatchNullCheckForFinalBossScripts
  {
    private static void Prefix(FinalBossGenerationSettings __instance)
    {
      int length = __instance.cardModifiers.Length;
      __instance.cardModifiers = ((IEnumerable<FinalBossCardModifier>) __instance.cardModifiers).Where<FinalBossCardModifier>((Func<FinalBossCardModifier, bool>) (x => (UnityEngine.Object) x.card != (UnityEngine.Object) null)).ToArray<FinalBossCardModifier>();
      if (length == __instance.cardModifiers.Length)
        return;
      Debug.LogError((object) "[Pokefrost] Null Scripts!");
      if (!PatchNullCheckForRewards.queuedWarning)
      {
        Debug.LogError((object) "[Pokefrost] Null Rewards!");
        MonoBehaviourSingleton<References>.instance.StartCoroutine(PatchNullCheckForRewards.PromptWarning());
        PatchNullCheckForRewards.queuedWarning = true;
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchNullCheckForRewards
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (CharacterRewards), "Add", new System.Type[] {typeof (RewardPool)})]
  internal class PatchNullCheckForRewards
  {
    public static bool queuedWarning = false;
    private static string key = "websiteofsites.wildfrost.pokefrost.unloadwarningkey";
    private static string yesKey = "websiteofsites.wildfrost.pokefrost.unloadwarningyeskey";
    private static string noKey = "websiteofsites.wildfrost.pokefrost.unloadwarningnokey";

    private static void Prefix(RewardPool rewardPool)
    {
      for (int index = rewardPool.list.Count - 1; index >= 0; --index)
      {
        if ((UnityEngine.Object) rewardPool.list[index] == (UnityEngine.Object) null)
        {
          rewardPool.list.RemoveAt(index);
          if (!PatchNullCheckForRewards.queuedWarning)
          {
            Debug.LogError((object) "[Pokefrost] Null Rewards!");
            MonoBehaviourSingleton<References>.instance.StartCoroutine(PatchNullCheckForRewards.PromptWarning());
            PatchNullCheckForRewards.queuedWarning = true;
          }
        }
      }
    }

    public static IEnumerator PromptWarning()
    {
      if (!PatchNullCheckForRewards.queuedWarning)
      {
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.IsLoaded("MapNew")));
        StringTable ui = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
        HelpPanelSystem.Show(ui.GetString(PatchNullCheckForRewards.key));
        HelpPanelSystem.SetEmote(Prompt.Emote.Type.Scared);
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, ui.GetString(PatchNullCheckForRewards.yesKey), "Select", (UnityAction) null);
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Negative, ui.GetString(PatchNullCheckForRewards.noKey), "Back", (UnityAction) null);
        PatchNullCheckForRewards.queuedWarning = false;
      }
    }

    [PokeLocalizer]
    public static void DefineStrings()
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(PatchNullCheckForRewards.key, "Unloading Anomolies Detected|Bugs may be appear during gameplay. For the best experience, please restart Wildfrost.|-[Pokefrost]");
      collection.SetString(PatchNullCheckForRewards.yesKey, "Of course!");
      collection.SetString(PatchNullCheckForRewards.noKey, "No way!");
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PickupRoutine
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal static class PickupRoutine
  {
    private static GameObject objectGroup;
    private static GameObject obj;
    private static ChooseNewCardSequence sequence;
    private static Transform deadCards;
    private static bool active = false;
    private static List<(string, int)> queue = new List<(string, int)>();

    public static bool Active => PickupRoutine.queue.Count != 0;

    public static void Queue(string name, int amount) => PickupRoutine.queue.Add((name, amount));

    public static void Debug1()
    {
      PickupRoutine.Create("<color=#8F0>Pizza Frog</color> Found A Card");
    }

    public static void Debug2(int amount = 4)
    {
      RewardPool rewardPool = Extensions.GetRewardPool("GeneralItemPool");
      MonoBehaviourSingleton<References>.instance.StartCoroutine(PickupRoutine.AddRandomCards(amount, new RewardPool[1]
      {
        rewardPool
      }));
    }

    public static async Task Debug3()
    {
      MonoBehaviourSingleton<References>.instance.StartCoroutine(PickupRoutine.Run());
    }

    public static void Debug4()
    {
      global::Events.PreBattleEnd += new global::Events.AsyncAction(PickupRoutine.Debug3);
    }

    public static void OnSceneChanged(Scene scene)
    {
      if (scene.name == "Battle" || scene.name == "Town" || scene.name == "CharacterSelect")
        PickupRoutine.queue.Clear();
      if (!(scene.name == "MapNew") || !PickupRoutine.Active)
        return;
      ActionQueue.Stack((PlayAction) new ActionSequence(PickupRoutine.RunMultiple()));
    }

    public static void Create(string text)
    {
      if ((UnityEngine.Object) PickupRoutine.objectGroup != (UnityEngine.Object) null)
      {
        PickupRoutine.objectGroup.GetComponentInChildren<FloatingText>().SetText(text);
      }
      else
      {
        PickupRoutine.objectGroup = new GameObject("SelectCardRoutine");
        PickupRoutine.objectGroup.SetActive(false);
        PickupRoutine.objectGroup.transform.SetParent(GameObject.Find("Canvas/Padding/HUD/DeckpackLayout").transform.parent.GetChild(0));
        PickupRoutine.objectGroup.transform.SetAsFirstSibling();
        GameObject gameObject1 = UICollector.PullPrefab("Box", "Background", PickupRoutine.objectGroup);
        gameObject1.GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 15f);
        gameObject1.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.8f);
        GameObject gameObject2 = UICollector.PullPrefab("Text", "Title", PickupRoutine.objectGroup);
        gameObject2.GetComponent<FloatingText>().SetText(text);
        gameObject2.transform.position = new Vector3(0.0f, 4.5f, 0.0f);
        PickupRoutine.obj = new GameObject("SelectCard");
        PickupRoutine.obj.transform.SetParent(PickupRoutine.objectGroup.transform);
        PickupRoutine.obj.transform.Translate(new Vector3(0.0f, 1f, 0.0f));
        PickupRoutine.obj.AddComponent<RectTransform>().sizeDelta = new Vector2(7f, 2f);
        CardControllerSelectCard controller = PickupRoutine.obj.AddComponent<CardControllerSelectCard>();
        controller.owner = References.Player;
        controller.unHoverEvent = new UnityEventEntity();
        controller.hoverEvent = new UnityEventEntity();
        controller.pressEvent = new UnityEventEntity();
        controller.pressEvent.AddListener(new UnityAction<Entity>(PickupRoutine.Select));
        CardHand cardHand = PickupRoutine.obj.AddComponent<CardHand>();
        cardHand.fanCircleAngleAddCurve = new AnimationCurve();
        cardHand.staticAngleAdd = true;
        cardHand.holder = PickupRoutine.obj.GetComponent<RectTransform>();
        cardHand.onAdd = new UnityEventEntity();
        cardHand.onRemove = new UnityEventEntity();
        cardHand.AssignController((CardController) controller);
        cardHand.SetSize(5, 0.889f);
        CardSelector cardSelector = PickupRoutine.obj.AddComponent<CardSelector>();
        cardSelector.character = References.Player;
        cardSelector.selectEvent = new UnityEventEntity();
        GameObject gameObject3 = new GameObject("DeadObject");
        PickupRoutine.deadCards = gameObject3.transform;
        gameObject3.SetActive(false);
        PickupRoutine.sequence = PickupRoutine.objectGroup.AddComponent<ChooseNewCardSequence>();
        PickupRoutine.sequence.cardContainer = (CardContainer) cardHand;
        PickupRoutine.sequence.cardSelector = cardSelector;
        PickupRoutine.sequence.cardController = (CardController) controller;
        PickupRoutine.sequence.background = gameObject1.GetComponent<RectTransform>();
        PickupRoutine.sequence.cardGroupLayout = PickupRoutine.obj;
      }
    }

    public static IEnumerator AddRandomCards(int amount, RewardPool[] rewards)
    {
      CardHand hand = PickupRoutine.obj.GetComponent<CardHand>();
      Debug.Log((object) "[Pokefrost] Cleared!");
      hand.Clear();
      List<DataFile> data = new List<DataFile>();
      RewardPool[] rewardPoolArray = rewards;
      for (int index = 0; index < rewardPoolArray.Length; ++index)
      {
        RewardPool r = rewardPoolArray[index];
        data = data.Concat<DataFile>((IEnumerable<DataFile>) r.list).ToList<DataFile>();
        r = (RewardPool) null;
      }
      rewardPoolArray = (RewardPool[]) null;
      List<CardData> cards = data.Where<DataFile>((Func<DataFile, bool>) (d => d is CardData)).Select<DataFile, CardData>((Func<DataFile, CardData>) (d => (CardData) d)).ToList<CardData>();
      Routine.Clump clump = new Routine.Clump();
      foreach (CardData card in (IEnumerable<CardData>) cards.InRandomOrder<CardData>())
      {
        if (card.cardType.name != "Friendly")
        {
          Card item = CardManager.Get(card.Clone(), PickupRoutine.obj.GetComponent<CardController>(), References.Player, false, true);
          clump.Add(item.UpdateData(false));
          PickupRoutine.obj.GetComponent<CardContainer>().Add(item.entity);
          --amount;
          if (amount > 0)
            item = (Card) null;
          else
            break;
        }
      }
      yield return (object) clump.WaitForEnd();
      PickupRoutine.obj.GetComponent<CardContainer>().TweenChildPositions();
    }

    public static IEnumerator RunMultiple()
    {
      for (int i = PickupRoutine.queue.Count - 1; i >= 0; --i)
      {
        PickupRoutine.Create(PickupRoutine.queue[i].Item1);
        yield return (object) PickupRoutine.AddRandomCards(PickupRoutine.queue[i].Item2, PickupRoutine.GetPools());
        yield return (object) PickupRoutine.Run();
      }
      PickupRoutine.obj.SetActive(false);
      PickupRoutine.queue.Clear();
    }

    public static IEnumerator Run()
    {
      PickupRoutine.obj.SetActive(true);
      PickupRoutine.sequence.cardController.Enable();
      PickupRoutine.sequence.promptEnd = PickupRoutine.obj.GetComponent<CardHand>().entities.Count == 0;
      Coroutine hide = Campaign.instance.StartCoroutine(PickupRoutine.HideInDeckView());
      yield return (object) PickupRoutine.objectGroup.GetComponent<ChooseNewCardSequence>().Run();
      CardHand hand = PickupRoutine.obj.GetComponent<CardHand>();
      Debug.Log((object) "[Pokefrost] Cleared!");
      hand.Clear();
      Campaign.instance.StopCoroutine(hide);
    }

    public static IEnumerator HideInDeckView()
    {
      GameObject obj = GameObject.Find("Canvas/Padding/PlayerDisplay/DeckDisplay");
      while (true)
      {
        yield return (object) new WaitUntil((Func<bool>) (() => obj.activeSelf));
        yield return (object) new WaitForSeconds(0.1f);
        PickupRoutine.objectGroup.SetActive(false);
        yield return (object) new WaitUntil((Func<bool>) (() => !obj.activeSelf));
        PickupRoutine.objectGroup.SetActive(true);
      }
    }

    public static RewardPool[] GetPools()
    {
      List<ClassData> group = AddressableLoader.GetGroup<ClassData>("ClassData");
      ClassData classData1 = group[0];
      string name = References.Player.name;
      Debug.Log((object) ("[Pokefrost] " + name));
      foreach (ClassData classData2 in group)
      {
        if (name.ToLower().Contains(classData2.name.ToLower()))
        {
          classData1 = classData2;
          break;
        }
      }
      return ((IEnumerable<RewardPool>) classData1.rewardPools).Where<RewardPool>((Func<RewardPool, bool>) (r => (UnityEngine.Object) r != (UnityEngine.Object) null && r.type == "Items" && !r.isGeneralPool)).ToArray<RewardPool>();
    }

    public static void Select(Entity entity)
    {
      References.PlayerData.inventory.deck.Add(entity.data);
      PickupRoutine.sequence.cardController.Disable();
      entity.RemoveFromContainers();
      PickupRoutine.sequence.cardSelector.MoveCardToDeck(entity);
      PickupRoutine.sequence.promptEnd = true;
      global::Events.InvokeEntityChosen(entity);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.Pokefrost
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using WildfrostHopeMod.Utils;

#nullable disable
namespace Pokefrost
{
  public class Pokefrost : WildfrostMod
  {
    public static string[] basicPool = new string[8]
    {
      "spheal",
      "croagunk",
      "toxicroak",
      "salazzle",
      "magcargo",
      "kirlia",
      "gardevoir",
      "gallade"
    };
    public static string[] magicPool = new string[11]
    {
      "cubone",
      "marowak",
      "alolanmarowak",
      "muk",
      "carvanha",
      "sharpedo",
      "duskull",
      "dusclops",
      "litwick",
      "lampent",
      "chandelure"
    };
    public static string[] clunkPool = new string[7]
    {
      "weezing",
      "aron",
      "lairon",
      "aggron",
      "hippowdon",
      "trubbish",
      "garbodor"
    };
    internal List<CardDataBuilder> list;
    internal List<CardUpgradeDataBuilder> charmlist;
    internal static List<StatusEffectData> statusList;
    private bool preLoaded = false;
    private static float shinyrate = 0.01f;
    public static Pokefrost.Pokefrost instance;
    public TMP_SpriteAsset pokefrostSprites;
    internal static FXHelper fx;
    internal static GameObject pokefrostUI;
    public static Sprite sprite;
    private static readonly string[] summoner = new string[1]
    {
      "nincada"
    };
    private static readonly string[] summoned = new string[1]
    {
      "shedinja"
    };
    public static List<GameModifierDataBuilder> bells = new List<GameModifierDataBuilder>();
    internal static readonly string[] rotomAppliances = new string[5]
    {
      "websiteofsites.wildfrost.pokefrost.microwave",
      "websiteofsites.wildfrost.pokefrost.washingmachine",
      "websiteofsites.wildfrost.pokefrost.fridge",
      "websiteofsites.wildfrost.pokefrost.fan",
      "websiteofsites.wildfrost.pokefrost.lawnmower"
    };
    private readonly string[] rotomForms = new string[5]
    {
      "websiteofsites.wildfrost.pokefrost.rotomheat",
      "websiteofsites.wildfrost.pokefrost.rotomwash",
      "websiteofsites.wildfrost.pokefrost.rotomfrost",
      "websiteofsites.wildfrost.pokefrost.rotomfan",
      "websiteofsites.wildfrost.pokefrost.rotommow"
    };
    private CardData fusedRotom;

    public override TMP_SpriteAsset SpriteAsset => this.pokefrostSprites;

    public static string AssetFolder
    {
      get => Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "Images\\Assets");
    }

    public static string CatalogPath => Path.Combine(Pokefrost.Pokefrost.AssetFolder, "catalog.json");

    internal T TryGet<T>(string name) where T : DataFile
    {
      T obj = !typeof (StatusEffectData).IsAssignableFrom(typeof (T)) ? this.Get<T>(name) : this.Get<StatusEffectData>(name) as T;
      return !((UnityEngine.Object) obj == (UnityEngine.Object) null) ? obj : throw new Exception("TryGet Error: Could not find a [" + typeof (T).Name + "] with the name [" + name + "] or [" + Deadpan.Enums.Engine.Components.Modding.Extensions.PrefixGUID(name, (WildfrostMod) this) + "]");
    }

    internal CardData.StatusEffectStacks SStack(string name, int count)
    {
      return new CardData.StatusEffectStacks(this.Get<StatusEffectData>(name), count);
    }

    internal CardData.TraitStacks TStack(string name, int count)
    {
      return new CardData.TraitStacks(this.Get<TraitData>(name), count);
    }

    public Pokefrost(string modDirectory)
      : base(modDirectory)
    {
      Pokefrost.Pokefrost.instance = this;
      this.HarmonyInstance.PatchAll(typeof (PatchHarmony));
    }

    private void CreateModAssets()
    {
      Ext.LoadPanels((WildfrostMod) this);
      Pokefrost.Pokefrost.pokefrostUI = new GameObject("PokefrostUI");
      Pokefrost.Pokefrost.pokefrostUI.SetActive(false);
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) Pokefrost.Pokefrost.pokefrostUI);
      if (Pokefrost.Pokefrost.fx == null)
        Pokefrost.Pokefrost.fx = new FXHelper((WildfrostMod) this, "Anim", "Sounds");
      Ext.CreateColoredInkAnim((WildfrostMod) this, new Color(0.23f, 0.96f, 0.8f), "juice");
      Pokefrost.Pokefrost.statusList = new List<StatusEffectData>(150);
      this.pokefrostSprites = HopeUtils.CreateSpriteAsset("pokefrostSprites", this.ImagePath("Sprites"), new Texture2D[0], new Sprite[0]);
      foreach (TMP_TextElement tmpTextElement in this.pokefrostSprites.spriteCharacterTable)
        tmpTextElement.scale = 1.3f;
      StringTable collection1 = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      this.CreateBasicKeyword("evolve", "Evolve", "If the condition is met at the end of battle evolve into a new Pokemon|Inactive while in reserve");
      KeywordData basicKeyword1 = this.CreateBasicKeyword("taunt", "Taunt", "All enemies are <keyword=taunted>");
      KeywordData basicKeyword2 = this.CreateBasicKeyword("taunted", "Taunted", "Target only enemies with <keyword=taunt>|Hits them all!");
      this.CreateBasicKeyword("randomeffect", "Random Effect", "Does a random effect from the listed options");
      this.CreateBasicKeyword("debuffed", "Debuffed", "Has a negative status");
      this.CreateBasicKeyword("legendary", "Legendary", "Counts as an additional leader|You lose when all your leaders die");
      StatusEffectFreeTrait instance1 = ScriptableObject.CreateInstance<StatusEffectFreeTrait>();
      instance1.trait = this.Get<TraitData>("Wild");
      instance1.silenced = (List<Entity.TraitStacks>) null;
      instance1.added = (Entity.TraitStacks) null;
      instance1.addedAmount = 0;
      instance1.targetConstraints = new TargetConstraint[0];
      instance1.offensive = true;
      instance1.isKeyword = false;
      instance1.stackable = false;
      StringTable collection2 = LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      instance1.name = "Apply Wild Trait";
      collection2.SetString(instance1.name + "_text", "Apply <keyword=wild>");
      instance1.textKey = collection2.GetString(instance1.name + "_text");
      instance1.ModAdded = (WildfrostMod) this;
      instance1.hiddenKeywords = new KeywordData[0];
      instance1.textInsert = "Wild Party!";
      instance1.applyFormat = "";
      instance1.type = "";
      instance1.applyFormatKey = new LocalizedString();
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance1);
      KeywordData iconKeyword1 = this.CreateIconKeyword("overshroom", "Overshroom", "Acts like both <sprite name=overload> and <sprite name=shroom>|Counts as both too!", "overshroomicon");
      Color? title1 = new Color?(new Color(0.0f, 0.6f, 0.6f));
      Color? nullable1 = new Color?(new Color(0.0f, 0.6f, 0.6f));
      Color? nullable2 = new Color?();
      Color? body1 = nullable2;
      Color? note1 = nullable1;
      KeywordData keywordData = iconKeyword1.ChangeColor(title1, body1, note1);
      this.CreateIcon("OvershroomIcon", AddressableExtMethods.ASprite("overshroomicon"), "overshroom", "shroom", Color.black, new KeywordData[1]
      {
        keywordData
      }, -1);
      StatusEffectDummy instance2 = ScriptableObject.CreateInstance<StatusEffectDummy>();
      instance2.name = "Overload";
      instance2.type = "overload";
      instance2.iconGroupName = "health";
      instance2.visible = false;
      instance2.isStatus = true;
      instance2.targetConstraints = new TargetConstraint[0];
      instance2.applyFormat = "";
      instance2.applyFormatKey = new LocalizedString();
      instance2.keyword = "";
      instance2.textOrder = 0;
      instance2.textInsert = "";
      StatusEffectDummy instance3 = ScriptableObject.CreateInstance<StatusEffectDummy>();
      instance3.name = "Shroom";
      instance3.type = "shroom";
      instance3.iconGroupName = "health";
      instance3.visible = false;
      instance3.isStatus = true;
      instance3.targetConstraints = new TargetConstraint[0];
      instance3.applyFormat = "";
      instance3.applyFormatKey = new LocalizedString();
      instance3.keyword = "";
      instance3.textOrder = 0;
      instance3.textInsert = "";
      StatusEffectOvershroom instance4 = ScriptableObject.CreateInstance<StatusEffectOvershroom>();
      instance4.name = "Overshroom";
      instance4.type = "overshroom";
      instance4.dummy1 = (StatusEffectData) instance2;
      instance4.dummy2 = (StatusEffectData) instance3;
      instance4.visible = true;
      instance4.stackable = true;
      instance4.buildupAnimation = ((StatusEffectOverload) this.Get<StatusEffectData>("Overload")).buildupAnimation;
      instance4.iconGroupName = "health";
      instance4.offensive = true;
      instance4.applyFormat = "";
      instance4.applyFormatKey = new LocalizedString();
      instance4.keyword = "overshroom";
      instance4.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintCanBeHit>()
      };
      instance4.textOrder = 0;
      instance4.eventPriority = 99;
      instance4.textInsert = "{a}";
      instance4.ModAdded = (WildfrostMod) this;
      instance4.isStatus = true;
      instance4.applyFormatKey = this.Get<StatusEffectData>("Shroom").applyFormatKey;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance4);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance4);
      StatusEffectBecomeOvershroom instance5 = ScriptableObject.CreateInstance<StatusEffectBecomeOvershroom>();
      instance5.name = "Turn Overload and Shroom to Overshroom";
      instance5.applyFormat = "";
      instance5.applyFormatKey = new LocalizedString();
      instance5.keyword = "";
      instance5.targetConstraints = new TargetConstraint[0];
      instance5.textKey = new LocalizedString();
      instance5.type = "";
      instance5.textOrder = 0;
      instance5.eventPriority = 100;
      instance5.textInsert = "";
      instance5.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance5);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance5);
      StatusEffectWhileActiveX instance6 = ScriptableObject.CreateInstance<StatusEffectWhileActiveX>();
      instance6.applyConstraints = new TargetConstraint[0];
      instance6.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance6.doPing = true;
      instance6.effectToApply = (StatusEffectData) instance5;
      instance6.pauseAfter = 0.0f;
      instance6.targetMustBeAlive = true;
      instance6.applyFormat = "";
      instance6.applyFormatKey = new LocalizedString();
      instance6.keyword = "";
      instance6.hiddenKeywords = new KeywordData[0];
      instance6.targetConstraints = new TargetConstraint[0];
      instance6.textInsert = "";
      instance6.name = "While Active It Is Overshroom";
      collection2.SetString(instance6.name + "_text", "While active, your <keyword=overload> and <keyword=shroom> is <keyword=overshroom> instead");
      instance6.textKey = collection2.GetString(instance6.name + "_text");
      instance6.textOrder = 0;
      instance6.type = "";
      instance6.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance6);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance6);
      StatusEffectApplyXWhenHitFree instance7 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenHitFree>();
      instance7.attackerConstraints = new TargetConstraint[0];
      instance7.applyConstraints = new TargetConstraint[0];
      instance7.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
      instance7.effectToApply = ((StatusEffectApplyX) this.Get<StatusEffectData>("Pre Turn Take Gold")).effectToApply;
      instance7.pauseAfter = 0.0f;
      instance7.applyFormat = "";
      instance7.applyFormatKey = new LocalizedString();
      instance7.canBeBoosted = true;
      instance7.count = 0;
      instance7.eventPriority = 0;
      instance7.hiddenKeywords = new KeywordData[1]
      {
        this.Get<KeywordData>("hit")
      };
      instance7.iconGroupName = "";
      instance7.keyword = "";
      instance7.stackable = true;
      instance7.targetConstraints = new TargetConstraint[0];
      instance7.temporary = 0;
      instance7.textInsert = "<{a}><keyword=blings>";
      instance7.name = "Drop Bling on Hit";
      instance7.type = "";
      collection2.SetString(instance7.name + "_text", "Lose <{a}><keyword=blings> when hit");
      instance7.textKey = collection2.GetString(instance7.name + "_text");
      instance7.textOrder = 0;
      instance7.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance7);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance7);
      StatusEffectApplyXOnTurn instance8 = ScriptableObject.CreateInstance<StatusEffectApplyXOnTurn>();
      instance8.applyConstraints = new TargetConstraint[0];
      instance8.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies;
      instance8.doPing = true;
      instance8.effectToApply = this.Get<StatusEffectData>("Haze");
      instance8.pauseAfter = 0.0f;
      instance8.targetMustBeAlive = true;
      instance8.waitForAnimationEnd = true;
      instance8.applyFormat = "";
      instance8.applyFormatKey = new LocalizedString();
      instance8.canBeBoosted = true;
      instance8.keyword = "";
      instance8.stackable = true;
      instance8.targetConstraints = new TargetConstraint[0];
      instance8.textInsert = "<{a}><keyword=haze>";
      instance8.name = "Apply Haze to All";
      instance8.type = "";
      collection2.SetString(instance8.name + "_text", "Apply <{a}><keyword=haze> to all");
      instance8.textKey = collection2.GetString(instance8.name + "_text");
      instance8.textOrder = 0;
      instance8.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance8);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance8);
      StatusEffectApplyXOnTurn effectApplyXonTurn = instance8.InstantiateKeepName<StatusEffectApplyXOnTurn>();
      effectApplyXonTurn.effectToApply = this.Get<StatusEffectData>("Null");
      effectApplyXonTurn.name = "Apply Ink to All";
      effectApplyXonTurn.textInsert = "<{a}><keyword=null>";
      collection2.SetString(effectApplyXonTurn.name + "_text", "Apply <{a}><keyword=null> to all");
      effectApplyXonTurn.textKey = collection2.GetString(effectApplyXonTurn.name + "_text");
      effectApplyXonTurn.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectApplyXonTurn);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectApplyXonTurn);
      StatusEffectApplyXOnTurn instance9 = ScriptableObject.CreateInstance<StatusEffectApplyXOnTurn>();
      instance9.applyConstraints = new TargetConstraint[0];
      instance9.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance9.doPing = true;
      instance9.effectToApply = this.Get<StatusEffectData>("Heal (No Ping)");
      instance9.pauseAfter = 0.0f;
      instance9.targetMustBeAlive = true;
      instance9.waitForAnimationEnd = true;
      instance9.applyFormat = "";
      instance9.applyFormatKey = new LocalizedString();
      instance9.canBeBoosted = true;
      instance9.keyword = "";
      instance9.stackable = true;
      instance9.targetConstraints = new TargetConstraint[0];
      instance9.textInsert = "<{a}><keyword=health>";
      instance9.name = "Heal Self";
      instance9.type = "";
      collection2.SetString(instance9.name + "_text", "Restore <{a}><keyword=health> to self");
      instance9.textKey = collection2.GetString(instance9.name + "_text");
      instance9.textOrder = 0;
      instance9.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance9);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance9);
      StatusEffectApplyXOnTurn instance10 = ScriptableObject.CreateInstance<StatusEffectApplyXOnTurn>();
      instance10.applyConstraints = new TargetConstraint[0];
      instance10.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.Allies;
      instance10.doPing = true;
      instance10.effectToApply = this.Get<StatusEffectData>("Heal & Cleanse (No Ping)");
      instance10.pauseAfter = 0.0f;
      instance10.targetMustBeAlive = true;
      instance10.waitForAnimationEnd = true;
      instance10.applyFormat = "";
      instance10.applyFormatKey = new LocalizedString();
      instance10.canBeBoosted = true;
      instance10.keyword = "";
      instance10.stackable = true;
      instance10.targetConstraints = new TargetConstraint[0];
      instance10.textInsert = "<{a}><keyword=health>";
      instance10.name = "Heal & Cleanse All";
      instance10.type = "";
      collection2.SetString(instance10.name + "_text", "Restore <{a}><keyword=health> and <keyword=cleanse> all allies and self");
      instance10.textKey = collection2.GetString(instance10.name + "_text");
      instance10.textOrder = 0;
      instance10.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance10);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance10);
      StatusEffectWhileActiveX instance11 = ScriptableObject.CreateInstance<StatusEffectWhileActiveX>();
      instance11.applyConstraints = new TargetConstraint[0];
      instance11.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
      instance11.doPing = true;
      instance11.effectToApply = this.Get<StatusEffectData>("Ongoing Increase Effects");
      instance11.pauseAfter = 0.0f;
      instance11.targetMustBeAlive = true;
      instance11.applyFormat = "";
      instance11.applyFormatKey = new LocalizedString();
      instance11.canBeBoosted = false;
      instance11.keyword = "";
      instance11.stackable = false;
      instance11.targetConstraints = new TargetConstraint[0];
      instance11.textInsert = "";
      instance11.name = "Boost Allies";
      instance11.type = "";
      collection2.SetString(instance11.name + "_text", "While active, boost the effects of all allies");
      instance11.textKey = collection2.GetString(instance11.name + "_text");
      instance11.textOrder = 0;
      instance11.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance11);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance11);
      StatusEffectWhileActiveX instance12 = ScriptableObject.CreateInstance<StatusEffectWhileActiveX>();
      instance12.applyConstraints = new TargetConstraint[0];
      instance12.applyToFlags = StatusEffectApplyX.ApplyToFlags.FrontAlly;
      instance12.doPing = true;
      instance12.effectToApply = this.Get<StatusEffectData>("Temporary Unmovable");
      instance12.pauseAfter = 0.0f;
      instance12.targetMustBeAlive = true;
      instance12.applyFormat = "";
      instance12.applyFormatKey = new LocalizedString();
      instance12.keyword = "";
      instance12.hiddenKeywords = new KeywordData[1]
      {
        this.Get<KeywordData>("Active")
      };
      instance12.targetConstraints = new TargetConstraint[0];
      instance12.textInsert = "<keyword=unmovable>";
      instance12.name = "Unmovable to Some Allies";
      instance12.type = "";
      collection2.SetString(instance12.name + "_text", "While active, add <keyword=unmovable> to allies in other row");
      instance12.textKey = collection2.GetString(instance12.name + "_text");
      instance12.textOrder = 0;
      instance12.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance12);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance12);
      StatusEffectApplyXOnCardPlayed instance13 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance13.applyConstraints = new TargetConstraint[0];
      instance13.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
      instance13.effectToApply = this.Get<StatusEffectData>("Trigger Against (Don't Count As Trigger)");
      instance13.pauseAfter = 0.0f;
      instance13.separateActions = true;
      instance13.targetMustBeAlive = true;
      instance13.applyFormat = "";
      instance13.applyFormatKey = new LocalizedString();
      instance13.keyword = "";
      instance13.targetConstraints = new TargetConstraint[0];
      instance13.textInsert = "Hit Row";
      instance13.name = "Hit Your Row";
      instance13.type = "";
      collection2.SetString(instance13.name + "_text", "Also hits allies in row");
      instance13.textKey = collection2.GetString(instance13.name + "_text");
      instance13.textOrder = 0;
      instance13.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance13);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance13);
      StatusEffectApplyXOnCardPlayed instance14 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance14.applyConstraints = new TargetConstraint[0];
      instance14.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
      instance14.effectToApply = this.Get<StatusEffectData>("Reduce Counter");
      instance14.pauseAfter = 0.0f;
      instance14.separateActions = true;
      instance14.targetMustBeAlive = true;
      instance14.canBeBoosted = true;
      instance14.applyFormat = "";
      instance14.applyFormatKey = new LocalizedString();
      instance14.keyword = "";
      instance14.targetConstraints = new TargetConstraint[0];
      instance14.textInsert = "Reduce Counter Row";
      instance14.name = "On Card Played Reduce Counter Row";
      instance14.type = "";
      collection2.SetString(instance14.name + "_text", "Count down <keyword=counter> by <{a}> to allies in row");
      instance14.textKey = collection2.GetString(instance14.name + "_text");
      instance14.textOrder = 0;
      instance14.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance14);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance14);
      StatusEffectMultEffects instance15 = ScriptableObject.CreateInstance<StatusEffectMultEffects>();
      instance15.effects = new List<StatusEffectData>()
      {
        this.Get<StatusEffectData>("Increase Max Counter"),
        this.Get<StatusEffectData>("MultiHit")
      };
      instance15.silenced = (List<Entity.TraitStacks>) null;
      instance15.targetConstraints = this.Get<CardData>("BlazeTea").attackEffects[1].data.targetConstraints;
      instance15.canBeBoosted = true;
      instance15.offensive = false;
      instance15.isKeyword = false;
      instance15.name = "Apply Blaze Tea";
      collection2.SetString(instance15.name + "_text", "Add <x{a}><keyword=frenzy> and increase <keyword=counter> by <{a}>");
      instance15.textKey = collection2.GetString(instance15.name + "_text");
      instance15.ModAdded = (WildfrostMod) this;
      instance15.textInsert = "Tea Party!";
      instance15.applyFormat = "";
      instance15.type = "";
      instance15.applyFormatKey = new LocalizedString();
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance15);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance15);
      StatusEffectApplyXOnCardPlayed instance16 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance16.applyConstraints = new TargetConstraint[0];
      instance16.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomAlly;
      instance16.effectToApply = this.Get<StatusEffectData>("Apply Blaze Tea");
      instance16.pauseAfter = 0.0f;
      instance16.separateActions = true;
      instance16.targetMustBeAlive = true;
      instance16.canBeBoosted = true;
      instance16.applyFormat = "";
      instance16.applyFormatKey = new LocalizedString();
      instance16.keyword = "";
      instance16.targetConstraints = this.Get<CardData>("BlazeTea").attackEffects[1].data.targetConstraints;
      instance16.textInsert = "Add MultiHit To Random Ally";
      instance16.name = "On Card Played Blaze Tea Random Ally";
      instance16.type = "";
      collection2.SetString(instance16.name + "_text", "Add <x{a}><keyword=frenzy> and increase <keyword=counter> by <{a}> to a random ally");
      instance16.textKey = collection2.GetString(instance16.name + "_text");
      instance16.textOrder = 0;
      instance16.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance16);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance16);
      StatusEffectSummon statusEffectSummon1 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon1.summonCard = this.Get<CardData>("ScrapPile");
      statusEffectSummon1.gainTrait = this.Get<StatusEffectData>("Temporary Zoomlin");
      statusEffectSummon1.name = "Summon Scrap Pile";
      collection2.SetString(statusEffectSummon1.name + "_text", "Summon Scrap Pile");
      statusEffectSummon1.textKey = collection2.GetString(statusEffectSummon1.name + "_text");
      statusEffectSummon1.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon1);
      StatusEffectInstantSummon effectInstantSummon1 = this.Get<StatusEffectData>("Instant Summon Junk In Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectInstantSummon;
      effectInstantSummon1.targetSummon = this.Get<StatusEffectData>("Summon Scrap Pile") as StatusEffectSummon;
      effectInstantSummon1.name = "Instant Summon Scrap Pile In Hand";
      collection2.SetString(effectInstantSummon1.name + "_text", "Add Scrap Pile to hand");
      effectInstantSummon1.textKey = collection2.GetString(effectInstantSummon1.name + "_text");
      effectInstantSummon1.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectInstantSummon1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectInstantSummon1);
      StatusEffectApplyXWhenHit effectApplyXwhenHit1 = this.Get<StatusEffectData>("When Hit Add Junk To Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXWhenHit;
      effectApplyXwhenHit1.effectToApply = (StatusEffectData) (this.Get<StatusEffectData>("Instant Summon Scrap Pile In Hand") as StatusEffectInstantSummon);
      effectApplyXwhenHit1.canBeBoosted = false;
      effectApplyXwhenHit1.name = "When Hit Add Scrap Pile To Hand";
      collection2.SetString(effectApplyXwhenHit1.name + "_text", "When hit, add <card=ScrapPile> with <keyword=zoomlin> to hand");
      effectApplyXwhenHit1.textKey = collection2.GetString(effectApplyXwhenHit1.name + "_text");
      effectApplyXwhenHit1.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectApplyXwhenHit1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectApplyXwhenHit1);
      StatusEffectSummon statusEffectSummon2 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon2.summonCard = this.Get<CardData>("ZapOrb");
      statusEffectSummon2.gainTrait = this.Get<StatusEffectData>("Temporary Consume");
      statusEffectSummon2.name = "Summon Azul Skull";
      collection2.SetString(statusEffectSummon2.name + "_text", "Summon Azul Skull");
      statusEffectSummon2.textKey = collection2.GetString(statusEffectSummon2.name + "_text");
      statusEffectSummon2.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon2);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon2);
      StatusEffectInstantSummon effectInstantSummon2 = this.Get<StatusEffectData>("Instant Summon Junk In Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectInstantSummon;
      effectInstantSummon2.targetSummon = this.Get<StatusEffectData>("Summon Azul Skull") as StatusEffectSummon;
      effectInstantSummon2.name = "Instant Summon Azul Skull In Hand";
      collection2.SetString(effectInstantSummon2.name + "_text", "Add Azul Skull to hand");
      effectInstantSummon2.textKey = collection2.GetString(effectInstantSummon2.name + "_text");
      effectInstantSummon2.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectInstantSummon2);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectInstantSummon2);
      StatusEffectSummon statusEffectSummon3 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon3.summonCard = this.Get<CardData>("SharkTooth");
      statusEffectSummon3.gainTrait = this.Get<StatusEffectData>("Temporary Consume");
      statusEffectSummon3.name = "Summon Tiger Skull";
      collection2.SetString(statusEffectSummon3.name + "_text", "Summon Tiger Skull");
      statusEffectSummon3.textKey = collection2.GetString(statusEffectSummon3.name + "_text");
      statusEffectSummon3.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon3);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon3);
      StatusEffectInstantSummon effectInstantSummon3 = this.Get<StatusEffectData>("Instant Summon Junk In Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectInstantSummon;
      effectInstantSummon3.targetSummon = this.Get<StatusEffectData>("Summon Tiger Skull") as StatusEffectSummon;
      effectInstantSummon3.name = "Instant Summon Tiger Skull In Hand";
      collection2.SetString(effectInstantSummon3.name + "_text", "Add Tiger Skull to hand");
      effectInstantSummon3.textKey = collection2.GetString(effectInstantSummon3.name + "_text");
      effectInstantSummon3.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectInstantSummon3);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectInstantSummon3);
      StatusEffectSummon statusEffectSummon4 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon4.summonCard = this.Get<CardData>("SnowMaul");
      statusEffectSummon4.gainTrait = this.Get<StatusEffectData>("Temporary Consume");
      statusEffectSummon4.name = "Summon Yeti Skull";
      collection2.SetString(statusEffectSummon4.name + "_text", "Summon Yeti Skull");
      statusEffectSummon4.textKey = collection2.GetString(statusEffectSummon4.name + "_text");
      statusEffectSummon4.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon4);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon4);
      StatusEffectInstantSummon effectInstantSummon4 = this.Get<StatusEffectData>("Instant Summon Junk In Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectInstantSummon;
      effectInstantSummon4.targetSummon = this.Get<StatusEffectData>("Summon Yeti Skull") as StatusEffectSummon;
      effectInstantSummon4.name = "Instant Summon Yeti Skull In Hand";
      collection2.SetString(effectInstantSummon4.name + "_text", "Add Yeti Skull to hand");
      effectInstantSummon4.textKey = collection2.GetString(effectInstantSummon4.name + "_text");
      effectInstantSummon4.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectInstantSummon4);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectInstantSummon4);
      StatusEffectApplyRandomOnCardPlayed instance17 = ScriptableObject.CreateInstance<StatusEffectApplyRandomOnCardPlayed>();
      instance17.type = "duskull";
      instance17.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance17.effectsToapply = new StatusEffectData[3]
      {
        (StatusEffectData) effectInstantSummon2,
        (StatusEffectData) effectInstantSummon3,
        (StatusEffectData) effectInstantSummon4
      };
      instance17.canBeBoosted = false;
      instance17.name = "When Ally Summoned Add Skull To Hand";
      instance17.applyFormat = "";
      instance17.applyFormatKey = new LocalizedString();
      instance17.keyword = "";
      instance17.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance17.name + "_text", "Add a skull with <keyword=consume> to hand");
      instance17.textKey = collection2.GetString(instance17.name + "_text");
      instance17.textOrder = 0;
      instance17.doPing = false;
      instance17.textInsert = "";
      instance17.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance17);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance17);
      StatusEffectTriggerWhenSummonDeployed instance18 = ScriptableObject.CreateInstance<StatusEffectTriggerWhenSummonDeployed>();
      instance18.name = "Trigger When Summon";
      instance18.type = "";
      instance18.isReaction = true;
      instance18.applyFormat = "";
      instance18.applyFormatKey = new LocalizedString();
      instance18.keyword = "";
      instance18.targetConstraints = new TargetConstraint[0];
      instance18.descColorHex = "F99C61";
      instance18.textOrder = 0;
      instance18.textInsert = "";
      instance18.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance18);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance18);
      KeywordData basicKeyword3 = this.CreateBasicKeyword("spook", "Spook", "Trigger whenever anything is summoned");
      basicKeyword3.showName = true;
      Ext.CreateTrait<TraitData>("Spook", (WildfrostMod) this, basicKeyword3, (StatusEffectData) instance18).isReaction = true;
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed1 = this.Get<StatusEffectData>("On Card Played Apply Spice To RandomAlly").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXOnCardPlayed;
      applyXonCardPlayed1.effectToApply = this.Get<StatusEffectData>("Demonize");
      applyXonCardPlayed1.name = "On Card Apply Demonize To RandomAlly";
      collection2.SetString(applyXonCardPlayed1.name + "_text", "Apply <{a}><keyword=demonize> to a random ally");
      applyXonCardPlayed1.textKey = collection2.GetString(applyXonCardPlayed1.name + "_text");
      applyXonCardPlayed1.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) applyXonCardPlayed1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) applyXonCardPlayed1);
      StatusEffectApplyRandomOnCardPlayed instance19 = ScriptableObject.CreateInstance<StatusEffectApplyRandomOnCardPlayed>();
      instance19.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
      instance19.effectsToapply = new StatusEffectData[3]
      {
        this.Get<StatusEffectData>("Shroom"),
        this.Get<StatusEffectData>("Overload"),
        this.Get<StatusEffectData>("Weakness")
      };
      instance19.canBeBoosted = true;
      instance19.name = "On Card Played Apply Shroom Overburn Or Bom";
      instance19.type = "";
      instance19.applyFormat = "";
      instance19.applyFormatKey = new LocalizedString();
      instance19.keyword = "";
      instance19.hiddenKeywords = new KeywordData[1]
      {
        this.Get<KeywordData>("randomeffect")
      };
      instance19.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance19.name + "_text", "Apply <{a}><keyword=shroom>/<keyword=overload>/<keyword=weakness> randomly");
      instance19.textKey = collection2.GetString(instance19.name + "_text");
      instance19.textOrder = 0;
      instance19.textInsert = "<keyword=shroom>, <keyword=overload>, <keyword=weakness>";
      instance19.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance19);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance19);
      StatusEffectApplyXPreTurn effectApplyXpreTurn1 = this.Get<StatusEffectData>("Pre Turn Take Gold").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXPreTurn;
      effectApplyXpreTurn1.effectToApply = this.Get<StatusEffectData>("Overload");
      effectApplyXpreTurn1.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      effectApplyXpreTurn1.name = "Overload Self";
      collection2.SetString(effectApplyXpreTurn1.name + "_text", "Gain <{a}><keyword=overload>");
      effectApplyXpreTurn1.textKey = collection2.GetString(effectApplyXpreTurn1.name + "_text");
      effectApplyXpreTurn1.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectApplyXpreTurn1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectApplyXpreTurn1);
      StatusEffectApplyXOnEffect instance20 = ScriptableObject.CreateInstance<StatusEffectApplyXOnEffect>();
      instance20.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
      instance20.doPing = false;
      instance20.conditionEffect = this.Get<StatusEffectData>("Overload");
      instance20.effectToApply = instance20.conditionEffect;
      instance20.applyEqualAmount = true;
      instance20.name = "Apply Overload Equal To Overload";
      instance20.type = "";
      instance20.applyFormat = "";
      instance20.applyFormatKey = new LocalizedString();
      instance20.keyword = "";
      instance20.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance20.name + "_text", "Apply current <keyword=overload>");
      instance20.textKey = collection2.GetString(instance20.name + "_text");
      instance20.textOrder = 0;
      instance20.textInsert = "";
      instance20.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance20);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance20);
      TraitData element1 = this.Get<TraitData>("Aimless");
      TraitData traitData1 = this.Get<TraitData>("Barrage");
      TraitData traitData2 = this.Get<TraitData>("Longshot");
      TraitData traitData3 = this.Get<TraitData>("Bombard 1");
      TraitData traitData4 = this.Get<TraitData>("Bombard 2");
      KeywordData basicKeyword4 = this.CreateBasicKeyword("pluck", "Pluck", "Hits lowest health target in row|Prioritizes front target in case of tie");
      TargetModeLowHealth instance21 = ScriptableObject.CreateInstance<TargetModeLowHealth>();
      StatusEffectChangeTargetMode changeTargetMode1 = this.Get<StatusEffectData>("Hit Random Target").InstantiateKeepName<StatusEffectData>() as StatusEffectChangeTargetMode;
      changeTargetMode1.name = "Hit Lowest Health Target";
      changeTargetMode1.targetMode = (TargetMode) instance21;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) changeTargetMode1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) changeTargetMode1);
      TraitData element2 = this.Get<TraitData>("Aimless").InstantiateKeepName<TraitData>();
      element2.name = "Pluck";
      element2.keyword = basicKeyword4;
      StatusEffectData[] statusEffectDataArray1 = new StatusEffectData[1]
      {
        (StatusEffectData) changeTargetMode1
      };
      element2.effects = statusEffectDataArray1;
      element2.overrides = ((IEnumerable<TraitData>) element2.overrides).Append<TraitData>(element1).ToArray<TraitData>();
      element2.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<TraitData>("TraitData", element2);
      element1.overrides = ((IEnumerable<TraitData>) element1.overrides).Append<TraitData>(element2).ToArray<TraitData>();
      traitData1.overrides = ((IEnumerable<TraitData>) traitData1.overrides).Append<TraitData>(element2).ToArray<TraitData>();
      traitData2.overrides = ((IEnumerable<TraitData>) traitData2.overrides).Append<TraitData>(element2).ToArray<TraitData>();
      StatusEffectChangeTargetMode changeTargetMode2 = this.Get<StatusEffectData>("Hit All Enemies").InstantiateKeepName<StatusEffectData>() as StatusEffectChangeTargetMode;
      changeTargetMode2.name = "Hit All Taunt";
      changeTargetMode2.targetMode = (TargetMode) ScriptableObject.CreateInstance<TargetModeTaunt>();
      changeTargetMode2.textKey = new LocalizedString();
      changeTargetMode2.ModAdded = (WildfrostMod) this;
      StatusEffectWhileActiveX effectWhileActiveX1 = this.Get<StatusEffectData>("While Active Aimless To Enemies").InstantiateKeepName<StatusEffectData>() as StatusEffectWhileActiveX;
      effectWhileActiveX1.name = "Target Mode Taunt";
      effectWhileActiveX1.keyword = "";
      effectWhileActiveX1.textKey = new LocalizedString();
      effectWhileActiveX1.ModAdded = (WildfrostMod) this;
      TraitData traitData5 = this.Get<TraitData>("Hellbent").InstantiateKeepName<TraitData>();
      traitData5.name = "Taunt";
      traitData5.keyword = basicKeyword1;
      StatusEffectData[] statusEffectDataArray2 = new StatusEffectData[1]
      {
        (StatusEffectData) effectWhileActiveX1
      };
      traitData5.effects = statusEffectDataArray2;
      traitData5.ModAdded = (WildfrostMod) this;
      TraitData element3 = this.Get<TraitData>("Hellbent").InstantiateKeepName<TraitData>();
      element3.name = "Taunted";
      element3.keyword = basicKeyword2;
      StatusEffectData[] statusEffectDataArray3 = new StatusEffectData[1]
      {
        (StatusEffectData) changeTargetMode2
      };
      element3.effects = statusEffectDataArray3;
      TraitData[] traitDataArray = new TraitData[4]
      {
        this.Get<TraitData>("Aimless"),
        this.Get<TraitData>("Barrage"),
        this.Get<TraitData>("Longshot"),
        element2
      };
      element3.overrides = traitDataArray;
      element3.ModAdded = (WildfrostMod) this;
      TargetConstraintHasTrait instance22 = ScriptableObject.CreateInstance<TargetConstraintHasTrait>();
      instance22.name = "Has Taunt Trait";
      instance22.trait = traitData5;
      TargetConstraint[] targetConstraintArray = new TargetConstraint[1]
      {
        (TargetConstraint) instance22
      };
      StatusEffectTemporaryTrait effectTemporaryTrait1 = this.Get<StatusEffectData>("Temporary Aimless").InstantiateKeepName<StatusEffectData>() as StatusEffectTemporaryTrait;
      effectTemporaryTrait1.name = "Temporary Taunted";
      effectTemporaryTrait1.trait = element3;
      effectTemporaryTrait1.ModAdded = (WildfrostMod) this;
      effectWhileActiveX1.effectToApply = (StatusEffectData) effectTemporaryTrait1;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) changeTargetMode2);
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectWhileActiveX1);
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectTemporaryTrait1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) changeTargetMode2);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectWhileActiveX1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectTemporaryTrait1);
      AddressableLoader.AddToGroup<TraitData>("TraitData", traitData5);
      AddressableLoader.AddToGroup<TraitData>("TraitData", element3);
      traitData3.overrides = ((IEnumerable<TraitData>) traitData3.overrides).Append<TraitData>(element3).ToArray<TraitData>();
      traitData4.overrides = ((IEnumerable<TraitData>) traitData4.overrides).Append<TraitData>(element3).ToArray<TraitData>();
      StatusEffectInstantEat effectInstantEat = this.Get<StatusEffectData>("Eat (Health, Attack & Effects)") as StatusEffectInstantEat;
      effectInstantEat.illegalEffects = ((IEnumerable<StatusEffectData>) effectInstantEat.illegalEffects).AddItem<StatusEffectData>((StatusEffectData) effectTemporaryTrait1).ToArray<StatusEffectData>();
      StatusEffectApplyXOnHit effectApplyXonHit = this.Get<StatusEffectData>("On Hit Equal Snow To Target").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXOnHit;
      effectApplyXonHit.effectToApply = this.Get<StatusEffectData>("Shroom");
      effectApplyXonHit.name = "On Hit Equal Shroom To Target";
      collection2.SetString(effectApplyXonHit.name + "_text", "Apply <keyword=shroom> equal to damage dealt");
      effectApplyXonHit.textKey = collection2.GetString(effectApplyXonHit.name + "_text");
      effectApplyXonHit.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectApplyXonHit);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectApplyXonHit);
      StatusEffectTemporaryTrait effectTemporaryTrait2 = this.Get<StatusEffectData>("Temporary Aimless").InstantiateKeepName<StatusEffectData>() as StatusEffectTemporaryTrait;
      effectTemporaryTrait2.name = "Temporary Explode";
      effectTemporaryTrait2.trait = this.Get<TraitData>("Explode");
      effectTemporaryTrait2.ModAdded = (WildfrostMod) this;
      effectTemporaryTrait2.targetConstraints = new TargetConstraint[0];
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectTemporaryTrait2);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectTemporaryTrait2);
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed2 = this.Get<StatusEffectData>("On Card Played Apply Attack To Self").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXOnCardPlayed;
      applyXonCardPlayed2.effectToApply = (StatusEffectData) effectTemporaryTrait2;
      applyXonCardPlayed2.canBeBoosted = true;
      applyXonCardPlayed2.doesDamage = true;
      applyXonCardPlayed2.targetConstraints = new TargetConstraint[0];
      applyXonCardPlayed2.name = "On Card Played Give Self Explode";
      collection2.SetString(applyXonCardPlayed2.name + "_text", "Gain <keyword=explode> <{a}>");
      applyXonCardPlayed2.textKey = collection2.GetString(applyXonCardPlayed2.name + "_text");
      applyXonCardPlayed2.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) applyXonCardPlayed2);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) applyXonCardPlayed2);
      StatusEffectApplyXPreTurn effectApplyXpreTurn2 = this.Get<StatusEffectData>("Pre Turn Take Gold").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXPreTurn;
      effectApplyXpreTurn2.effectToApply = this.Get<StatusEffectData>("Weakness");
      effectApplyXpreTurn2.applyToFlags = StatusEffectApplyX.ApplyToFlags.Enemies;
      effectApplyXpreTurn2.name = "Pre Turn Weakness All Enemies";
      collection2.SetString(effectApplyXpreTurn2.name + "_text", "Before triggering, apply <{a}><keyword=weakness> to all enemies");
      effectApplyXpreTurn2.textKey = collection2.GetString(effectApplyXpreTurn2.name + "_text");
      effectApplyXpreTurn2.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectApplyXpreTurn2);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectApplyXpreTurn2);
      StatusEffectApplyXWhenAnyoneTakesDamage instance23 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenAnyoneTakesDamage>();
      instance23.name = "Trigger When Teeth Damage";
      instance23.type = "";
      instance23.effectToApply = this.Get<StatusEffectData>("Trigger (High Prio)");
      instance23.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance23.isReaction = true;
      instance23.applyFormat = "";
      instance23.applyFormatKey = new LocalizedString();
      instance23.keyword = "";
      instance23.targetConstraints = new TargetConstraint[0];
      instance23.targetDamageType = "spikes";
      collection2.SetString(instance23.name + "_text", "Trigger whenever anything takes damage from <keyword=teeth>");
      instance23.descColorHex = "F99C61";
      instance23.textKey = collection2.GetString(instance23.name + "_text");
      instance23.textOrder = 0;
      instance23.textInsert = "";
      instance23.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance23);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance23);
      StatusEffectIncreaseAttackBasedOnCardsDrawnThisTurn instance24 = ScriptableObject.CreateInstance<StatusEffectIncreaseAttackBasedOnCardsDrawnThisTurn>();
      instance24.name = "Increase Attack Based on Cards Drawn";
      instance24.type = "";
      instance24.effectToGain = this.Get<StatusEffectData>("Ongoing Increase Attack");
      instance24.canBeBoosted = true;
      instance24.applyFormat = "";
      instance24.applyFormatKey = new LocalizedString();
      instance24.keyword = "";
      instance24.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance24.name + "_text", "<+{a}><keyword=attack> for each card drawn this turn");
      instance24.textKey = collection2.GetString(instance24.name + "_text");
      instance24.textOrder = 0;
      instance24.textInsert = "";
      instance24.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance24);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance24);
      StatusEffectApplyXWhenClunkerDestroyed instance25 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenClunkerDestroyed>();
      instance25.name = "When Clunker Destroyed Add Junk To Hand";
      instance25.type = "";
      instance25.effectToApply = this.Get<StatusEffectData>("Instant Summon Junk In Hand");
      instance25.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance25.waitForAnimationEnd = true;
      instance25.canBeBoosted = true;
      instance25.applyFormat = "";
      instance25.applyFormatKey = new LocalizedString();
      instance25.keyword = "";
      instance25.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance25.name + "_text", "<keyword=trash> <{a}> when a <Clunker> is destroyed");
      instance25.textKey = collection2.GetString(instance25.name + "_text");
      instance25.textOrder = 0;
      instance25.textInsert = "";
      instance25.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance25);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance25);
      StatusEffectApplyXWhenClunkerDestroyed instance26 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenClunkerDestroyed>();
      instance26.name = "When Clunker Destroyed Gain Scrap";
      instance26.type = "";
      instance26.effectToApply = this.Get<StatusEffectData>("Scrap");
      instance26.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance26.waitForAnimationEnd = true;
      instance26.canBeBoosted = true;
      instance26.applyFormat = "";
      instance26.applyFormatKey = new LocalizedString();
      instance26.keyword = "";
      instance26.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance26.name + "_text", "Gain <{a}><keyword=scrap> when a <Clunker> is destroyed");
      instance26.textKey = collection2.GetString(instance26.name + "_text");
      instance26.textOrder = 0;
      instance26.textInsert = "";
      instance26.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance26);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance26);
      StatusEffectApplyXOnCardPlayed instance27 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance27.name = "On Card Played Increase Attack Of Cards In Hand";
      instance27.type = "";
      instance27.effectToApply = this.Get<StatusEffectData>("Increase Attack");
      instance27.applyToFlags = StatusEffectApplyX.ApplyToFlags.Hand;
      instance27.canBeBoosted = true;
      instance27.applyFormat = "";
      instance27.applyFormatKey = new LocalizedString();
      instance27.keyword = "";
      instance27.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintDoesDamage>()
      };
      collection2.SetString(instance27.name + "_text", "Add <+{a}><keyword=attack> to cards in hand");
      instance27.textKey = collection2.GetString(instance27.name + "_text");
      instance27.textOrder = 0;
      instance27.textInsert = "";
      instance27.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance27);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance27);
      StatusEffectApplyXWhenHit instance28 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenHit>();
      instance28.name = "When Hit Cleanse Team";
      instance28.type = "";
      instance28.effectToApply = this.Get<StatusEffectData>("Cleanse");
      instance28.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.Allies;
      instance28.waitForAnimationEnd = true;
      instance28.applyFormat = "";
      instance28.applyFormatKey = new LocalizedString();
      instance28.keyword = "";
      instance28.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance28.name + "_text", "<keyword=cleanse> self and allies when hit");
      instance28.textKey = collection2.GetString(instance28.name + "_text");
      instance28.textOrder = 0;
      instance28.textInsert = "";
      instance28.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance28);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance28);
      StatusEffectApplyXWhenCardDestroyed xwhenCardDestroyed1 = this.Get<StatusEffectData>("Trigger When Enemy Is Killed").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXWhenCardDestroyed;
      xwhenCardDestroyed1.name = "Trigger When Card Destroyed";
      xwhenCardDestroyed1.type = "";
      xwhenCardDestroyed1.canBeAlly = true;
      xwhenCardDestroyed1.mustBeOnBoard = false;
      collection2.SetString(xwhenCardDestroyed1.name + "_text", "Trigger when a card is destroyed");
      xwhenCardDestroyed1.descColorHex = "F99C61";
      xwhenCardDestroyed1.textKey = collection2.GetString(xwhenCardDestroyed1.name + "_text");
      xwhenCardDestroyed1.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) xwhenCardDestroyed1);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) xwhenCardDestroyed1);
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed3 = this.Get<StatusEffectData>("On Card Played Trigger RandomAlly").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXOnCardPlayed;
      applyXonCardPlayed3.name = "Trigger Clunker Ahead";
      applyXonCardPlayed3.applyToFlags = StatusEffectApplyX.ApplyToFlags.AllyInFrontOf;
      TargetConstraintIsCardType instance29 = ScriptableObject.CreateInstance<TargetConstraintIsCardType>();
      instance29.allowedTypes = new CardType[1]
      {
        this.Get<CardType>("Clunker")
      };
      applyXonCardPlayed3.applyConstraints = ((IEnumerable<TargetConstraint>) applyXonCardPlayed3.applyConstraints).Append<TargetConstraint>((TargetConstraint) instance29).ToArray<TargetConstraint>();
      collection2.SetString(applyXonCardPlayed3.name + "_text", "Trigger <Clunker> ahead");
      applyXonCardPlayed3.textKey = collection2.GetString(applyXonCardPlayed3.name + "_text");
      applyXonCardPlayed3.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) applyXonCardPlayed3);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) applyXonCardPlayed3);
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed4 = this.Get<StatusEffectData>("On Card Played Vim To Self").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXOnCardPlayed;
      applyXonCardPlayed4.name = "On Card Played Reduce Own Max Counter";
      applyXonCardPlayed4.effectToApply = this.Get<StatusEffectData>("Reduce Max Counter");
      collection2.SetString(applyXonCardPlayed4.name + "_text", "Reduce own <keyword=counter> by <{a}>");
      applyXonCardPlayed4.textKey = collection2.GetString(applyXonCardPlayed4.name + "_text");
      applyXonCardPlayed4.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) applyXonCardPlayed4);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) applyXonCardPlayed4);
      StatusEffectXActsLikeShell instance30 = ScriptableObject.CreateInstance<StatusEffectXActsLikeShell>();
      instance30.name = "Snow Acts Like Shell";
      instance30.type = "";
      instance30.targetType = "snow";
      instance30.sprite = AddressableExtMethods.ASprite("shnell");
      collection2.SetString(instance30.name + "_text", "Uses <keyword=snow> as <keyword=shell>");
      instance30.textKey = collection2.GetString(instance30.name + "_text");
      instance30.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance30);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance30);
      StatusEffectInstantApplyXCardInDeck instance31 = ScriptableObject.CreateInstance<StatusEffectInstantApplyXCardInDeck>();
      instance31.name = "Instant Buff Card In Deck";
      collection2.SetString(instance31.name + "_text", "");
      instance31.textKey = collection2.GetString(instance31.name + "_text");
      instance31.type = "";
      instance31.effectToApply = this.Get<StatusEffectData>("Increase Attack");
      instance31.targetConstraints = new TargetConstraint[0];
      instance31.constraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintDoesDamage>()
      };
      instance31.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance31);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance31);
      StatusEffectApplyXOnKill instance32 = ScriptableObject.CreateInstance<StatusEffectApplyXOnKill>();
      instance32.name = "Buff Card In Deck On Kill";
      collection2.SetString(instance32.name + "_text", "Permanently give <+{a}><keyword=attack> to a card on kill");
      instance32.textKey = collection2.GetString(instance32.name + "_text");
      instance32.canBeBoosted = true;
      instance32.type = "";
      instance32.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance32.ModAdded = (WildfrostMod) this;
      instance32.effectToApply = this.Get<StatusEffectData>("Instant Buff Card In Deck");
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance32);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance32);
      StatusEffectApplyXWhenYAppliedTo instance33 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenYAppliedTo>();
      instance33.name = "When Snowed Snow Random Enemy";
      collection2.SetString(instance33.name + "_text", "When <keyword=snow>'d, apply equal <keyword=snow> to a random enemy");
      instance33.textKey = collection2.GetString(instance33.name + "_text");
      instance33.type = "";
      instance33.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomEnemy;
      instance33.ModAdded = (WildfrostMod) this;
      instance33.effectToApply = this.Get<StatusEffectData>("Snow");
      instance33.applyEqualAmount = true;
      instance33.queue = true;
      instance33.targetMustBeAlive = true;
      instance33.doPing = true;
      instance33.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance33.whenAppliedTypes = new string[1]{ "snow" };
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance33);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance33);
      StatusEffectApplyXWhenUnitIsKilled instance34 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenUnitIsKilled>();
      instance34.name = "Gain Frenzy When Companion Is Killed";
      collection2.SetString(instance34.name + "_text", "When a <Companion> is killed, gain <x{a}><keyword=frenzy>");
      instance34.textKey = collection2.GetString(instance34.name + "_text");
      instance34.canBeBoosted = true;
      instance34.type = "";
      instance34.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance34.ModAdded = (WildfrostMod) this;
      instance34.effectToApply = this.Get<StatusEffectData>("MultiHit");
      TargetConstraintIsCardType instance35 = ScriptableObject.CreateInstance<TargetConstraintIsCardType>();
      instance35.name = "Must be Friendly";
      instance35.allowedTypes = new CardType[1]
      {
        this.Get<CardType>("Friendly")
      };
      instance34.unitConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) instance35
      };
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance34);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance34);
      this.CreateBasicKeyword("wonderguard", "Wonder Guard", "Immune to direct damage");
      StatusEffectImmuneToDamage instance36 = ScriptableObject.CreateInstance<StatusEffectImmuneToDamage>();
      instance36.name = "Wonder Guard";
      collection2.SetString(instance36.name + "_text", "<keyword=wonderguard>");
      instance36.textKey = collection2.GetString(instance36.name + "_text");
      instance36.immuneTypes = new List<string>()
      {
        "basic"
      };
      instance36.type = "";
      instance36.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance36);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance36);
      StatusEffectSummon statusEffectSummon5 = this.Get<StatusEffectData>("Summon Plep").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon5.name = "Summon Shedinja";
      collection2.SetString(statusEffectSummon5.name + "_text", "Summon <card=websiteofsites.wildfrost.pokefrost.shedinja>");
      statusEffectSummon5.textKey = collection2.GetString(statusEffectSummon5.name + "_text");
      statusEffectSummon5.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon5);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon5);
      KeywordData basicKeyword5 = this.CreateBasicKeyword("sketch", "Sketch", "When deployed, permanently copy the effects of a random enemy in the row|Counts down");
      nullable1 = new Color?(Color.black);
      nullable2 = new Color?(Color.black);
      Color? title2 = new Color?();
      Color? body2 = nullable1;
      Color? note2 = nullable2;
      basicKeyword5.ChangeColor(title2, body2, note2).ChangePanel(AddressableExtMethods.ASprite("sketchpaint"), new Color?(new Color(0.9f, 0.9f, 0.8f)));
      StatusEffectSketch instance37 = ScriptableObject.CreateInstance<StatusEffectSketch>();
      instance37.name = "Sketch";
      instance37.type = "";
      instance37.ModAdded = (WildfrostMod) this;
      instance37.targetConstraints = new TargetConstraint[0];
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance37);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance37);
      StatusEffectSketchOnDeploy instance38 = ScriptableObject.CreateInstance<StatusEffectSketchOnDeploy>();
      instance38.name = "When Deployed Sketch";
      instance38.type = "";
      instance38.canBeBoosted = false;
      instance38.queue = true;
      instance38.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomEnemyInRow;
      collection2.SetString(instance38.name + "_text", "<keyword=sketch> <{a}>");
      instance38.textKey = collection2.GetString(instance38.name + "_text");
      instance38.ModAdded = (WildfrostMod) this;
      instance38.effectToApply = this.Get<StatusEffectData>("Sketch");
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance38);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance38);
      StatusEffectBonusDamageEqualToX instance39 = ScriptableObject.CreateInstance<StatusEffectBonusDamageEqualToX>();
      instance39.name = "Damage Equal To Missing Health";
      instance39.add = true;
      instance39.on = StatusEffectBonusDamageEqualToX.On.ScriptableAmount;
      instance39.scriptableAmount = (ScriptableAmount) ScriptableObject.CreateInstance<ScriptableMissingHealth>();
      instance39.type = "";
      instance39.canBeBoosted = false;
      collection2.SetString(instance39.name + "_text", "Deal damage equal to missing <keyword=health>");
      instance39.textKey = collection2.GetString(instance39.name + "_text");
      instance39.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance39);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance39);
      StatusEffectApplyXWhileStatused instance40 = ScriptableObject.CreateInstance<StatusEffectApplyXWhileStatused>();
      instance40.name = "Increase Attack While Statused";
      instance40.effectToGain = this.Get<StatusEffectData>("Ongoing Increase Attack");
      instance40.canBeBoosted = true;
      instance40.type = "";
      collection2.SetString(instance40.name + "_text", "While <keyword=debuffed>, <keyword=attack> is increased by <{a}>");
      instance40.textKey = collection2.GetString(instance40.name + "_text");
      instance40.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance40);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance40);
      StatusEffectApplyXWhileStatused instance41 = ScriptableObject.CreateInstance<StatusEffectApplyXWhileStatused>();
      instance41.name = "Gain Frenzy While Statused";
      instance41.effectToGain = this.Get<StatusEffectData>("MultiHit");
      instance41.canBeBoosted = true;
      instance41.type = "";
      collection2.SetString(instance41.name + "_text", "While <keyword=debuffed>, gain <x{a}><keyword=frenzy>");
      instance41.textKey = collection2.GetString(instance41.name + "_text");
      instance41.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance41);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance41);
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed5 = this.Get<StatusEffectData>("On Card Played Vim To Self").InstantiateKeepName<StatusEffectData>() as StatusEffectApplyXOnCardPlayed;
      applyXonCardPlayed5.name = "On Card Played Increase Targets and Own Max Counter";
      applyXonCardPlayed5.effectToApply = this.Get<StatusEffectData>("Increase Max Counter");
      applyXonCardPlayed5.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.Target;
      collection2.SetString(applyXonCardPlayed5.name + "_text", "Increase target's and own <keyword=counter> by <{a}>");
      applyXonCardPlayed5.textKey = collection2.GetString(applyXonCardPlayed5.name + "_text");
      applyXonCardPlayed5.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) applyXonCardPlayed5);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) applyXonCardPlayed5);
      StatusEffectApplyXOnCardPlayed instance42 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance42.name = "On Card Played Trigger All Slowking Crowns";
      instance42.type = "";
      instance42.effectToApply = this.Get<StatusEffectData>("Trigger (High Prio)");
      instance42.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
      instance42.applyConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintHasSlowkingCrown>()
      };
      instance42.canBeBoosted = false;
      instance42.doPing = true;
      collection2.SetString(instance42.name + "_text", "Trigger <sprite name=slowking_crown>'d allies");
      instance42.textKey = collection2.GetString(instance42.name + "_text");
      instance42.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance42);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance42);
      StatusEffectDreamDummy instance43 = ScriptableObject.CreateInstance<StatusEffectDreamDummy>();
      instance43.name = "Give Slowking Crown";
      instance43.type = "";
      collection2.SetString(instance43.name + "_text", "Gain a <sprite name=slowking_crown> upon evolution or battle end");
      instance43.textKey = collection2.GetString(instance43.name + "_text");
      instance43.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance43);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance43);
      StatusEffectApplyXInstant instance44 = ScriptableObject.CreateInstance<StatusEffectApplyXInstant>();
      instance44.name = "Instant Double Attack of Attacker";
      instance44.effectToApply = this.Get<StatusEffectData>("Double Attack");
      instance44.applyToFlags = StatusEffectApplyX.ApplyToFlags.Applier;
      instance44.canBeBoosted = false;
      instance44.targetMustBeAlive = false;
      instance44.type = "";
      instance44.targetConstraints = new TargetConstraint[0];
      instance44.textKey = (LocalizedString) null;
      instance44.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance44);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance44);
      StatusEffectInstantIncreaseAttack effectToApply1 = Ext.CreateStatus<StatusEffectInstantIncreaseAttack>("Half Attack").Register<StatusEffectInstantIncreaseAttack>((WildfrostMod) this);
      effectToApply1.scriptableAmount = (ScriptableAmount) ScriptableObject.CreateInstance<ScriptableNegativeHalfAttack>();
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectToApply1);
      StatusEffectApplyXInstant effectApplyXinstant = Ext.CreateStatus<StatusEffectApplyXInstant>("Instant Half Attack").ApplyX<StatusEffectApplyXInstant>((StatusEffectData) effectToApply1, StatusEffectApplyX.ApplyToFlags.Applier).Register<StatusEffectApplyXInstant>((WildfrostMod) this);
      effectApplyXinstant.targetMustBeAlive = false;
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectApplyXinstant);
      StatusEffectApplyXOnHitOtherwiseY instance45 = ScriptableObject.CreateInstance<StatusEffectApplyXOnHitOtherwiseY>();
      instance45.name = "On Hit Snowed Target Double Attack Otherwise Half";
      instance45.addDamageFactor = 0;
      instance45.multiplyDamageFactor = 1f;
      instance45.effectToApply = (StatusEffectData) instance44;
      instance45.mainEffect = (StatusEffectData) instance44;
      instance45.otherEffect = (StatusEffectData) effectApplyXinstant;
      instance45.applyConstraints = new TargetConstraint[0];
      instance45.applyConstraints2 = new TargetConstraint[1]
      {
        (TargetConstraint) SCon("Snow")
      };
      instance45.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
      instance45.targetMustBeAlive = false;
      instance45.canBeBoosted = false;
      instance45.type = "";
      instance45.postHit = true;
      collection2.SetString(instance45.name + "_text", "Double <keyword=attack> after hitting a <keyword=snow>'d target, otherwise halve <keyword=attack>");
      instance45.textKey = collection2.GetString(instance45.name + "_text");
      instance45.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance45);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance45);
      KeywordData basicKeyword6 = this.CreateBasicKeyword("Revive", "Revive", "Cut <keyword=health> and <keyword=attack> in half instead of dying|Once per run!");
      nullable2 = new Color?(new Color(0.8f, 0.3f, 0.3f));
      Color? title3 = new Color?();
      Color? body3 = new Color?();
      Color? note3 = nullable2;
      basicKeyword6.ChangeColor(title3, body3, note3);
      StatusEffectRevive instance46 = ScriptableObject.CreateInstance<StatusEffectRevive>();
      instance46.name = "Revive";
      instance46.canBeBoosted = false;
      instance46.type = "";
      instance46.preventDeath = true;
      instance46.eventPriority = -999998;
      instance46.targetConstraints = new TargetConstraint[1]
      {
        this.Get<CardUpgradeData>("CardUpgradeHeart").targetConstraints[0]
      };
      collection2.SetString(instance46.name + "_text", "<keyword=revive>");
      instance46.textKey = collection2.GetString(instance46.name + "_text");
      instance46.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance46);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance46);
      StatusEffectApplyXOnHitOtherwiseY instance47 = ScriptableObject.CreateInstance<StatusEffectApplyXOnHitOtherwiseY>();
      instance47.name = "On Hit Deal Double Damage To Statused Targets";
      instance47.addDamageFactor = 0;
      instance47.multiplyDamageFactor = 2f;
      TargetConstraintHasNegativeStatus instance48 = ScriptableObject.CreateInstance<TargetConstraintHasNegativeStatus>();
      instance47.applyConstraints2 = new TargetConstraint[1]
      {
        (TargetConstraint) instance48
      };
      instance47.applyConstraints = new TargetConstraint[0];
      instance47.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
      instance47.canBeBoosted = false;
      instance47.type = "";
      instance47.postHit = true;
      collection2.SetString(instance47.name + "_text", "Deal double damage to <keyword=debuffed> targets");
      instance47.textKey = collection2.GetString(instance47.name + "_text");
      instance47.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance47);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance47);
      StatusEffectImmuneToDamage instance49 = ScriptableObject.CreateInstance<StatusEffectImmuneToDamage>();
      instance49.name = "Immune to Indirect Damage";
      instance49.immuneTypes = new List<string>()
      {
        "basic"
      };
      instance49.reverse = true;
      instance49.type = "";
      instance49.invis = true;
      instance49.eventPriority = 9999;
      instance49.ignoreReactions = true;
      instance49.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance49);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance49);
      KeywordData basicKeyword7 = this.CreateBasicKeyword("Immaterial", "Immaterial", "Immune to indirect damage and prevents reactions");
      TraitData instance50 = ScriptableObject.CreateInstance<TraitData>();
      instance50.name = "Immaterial";
      instance50.keyword = basicKeyword7;
      StatusEffectData[] statusEffectDataArray4 = new StatusEffectData[1]
      {
        (StatusEffectData) instance49
      };
      instance50.effects = statusEffectDataArray4;
      instance50.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<TraitData>("TraitData", instance50);
      StatusEffectApplyXEveryTurn instance51 = ScriptableObject.CreateInstance<StatusEffectApplyXEveryTurn>();
      instance51.name = "End of Turn Draw a Card";
      instance51.mode = StatusEffectApplyXEveryTurn.Mode.AfterTurn;
      instance51.canBeBoosted = true;
      instance51.effectToApply = this.Get<StatusEffectData>("Instant Draw");
      instance51.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance51.type = "";
      collection2.SetString(instance51.name + "_text", "Draw <{a}> at the end of each turn");
      instance51.textKey = collection2.GetString(instance51.name + "_text");
      instance51.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance51);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance51);
      KeywordData basicKeyword8 = this.CreateBasicKeyword("Dream", "Dream", "Changes to a random card each turn|Destroyed after use or discard");
      StatusEffectDreamDummy instance52 = ScriptableObject.CreateInstance<StatusEffectDreamDummy>();
      instance52.name = "Trigger When Dream Card Played";
      instance52.isReaction = true;
      instance52.type = "dream";
      collection2.SetString(instance52.name + "_text", "Trigger when a <keyword=dream> card is played");
      instance52.descColorHex = "F99C61";
      instance52.textKey = collection2.GetString(instance52.name + "_text");
      instance52.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance52);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance52);
      TargetConstraintHasStatus instance53 = ScriptableObject.CreateInstance<TargetConstraintHasStatus>();
      instance53.status = (StatusEffectData) instance52;
      StatusEffectApplyXOnCardPlayed instance54 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance54.name = "Trigger Dreamers";
      instance54.effectToApply = this.Get<StatusEffectData>("Trigger (High Prio)");
      instance54.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies;
      instance54.eventPriority = 999;
      instance54.type = "";
      instance54.applyConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) instance53
      };
      instance54.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance54);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance54);
      StatusEffectApplyXWhenDiscardedFixed instance55 = ScriptableObject.CreateInstance<StatusEffectApplyXWhenDiscardedFixed>();
      instance55.name = "Destroyed On Discard";
      instance55.effectToApply = this.Get<StatusEffectData>("Sacrifice Card In Hand");
      instance55.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      instance55.canBeBoosted = false;
      instance55.type = "";
      instance55.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance55);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance55);
      StatusEffectChangeData instance56 = ScriptableObject.CreateInstance<StatusEffectChangeData>();
      instance56.name = "Change Card Data";
      instance56.type = "";
      instance56.sprite = AddressableExtMethods.ASprite("musharnaBG");
      instance56.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance56);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance56);
      TraitData instance57 = ScriptableObject.CreateInstance<TraitData>();
      instance57.name = "Dream";
      instance57.keyword = basicKeyword8;
      StatusEffectData[] statusEffectDataArray5 = new StatusEffectData[4]
      {
        (StatusEffectData) instance55,
        this.Get<StatusEffectData>("Destroy After Use"),
        (StatusEffectData) instance54,
        (StatusEffectData) instance56
      };
      instance57.effects = statusEffectDataArray5;
      instance57.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<TraitData>("TraitData", instance57);
      StatusEffectTemporaryTrait effectTemporaryTrait3 = this.Get<StatusEffectData>("Temporary Aimless").InstantiateKeepName<StatusEffectData>() as StatusEffectTemporaryTrait;
      effectTemporaryTrait3.targetConstraints = new TargetConstraint[0];
      effectTemporaryTrait3.name = "Temporary Dream";
      effectTemporaryTrait3.trait = instance57;
      effectTemporaryTrait3.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectTemporaryTrait3);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectTemporaryTrait3);
      StatusEffectSummon statusEffectSummon6 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon6.summonCard = this.Get<CardData>("Sword");
      statusEffectSummon6.name = "Summon Lumin Goop";
      statusEffectSummon6.gainTrait = (StatusEffectData) effectTemporaryTrait3;
      collection2.SetString(statusEffectSummon6.name + "_text", "Summon Lumin Goop");
      statusEffectSummon6.textKey = collection2.GetString(statusEffectSummon6.name + "_text");
      statusEffectSummon6.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon6);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon6);
      StatusEffectInstantSummon effectToApply2 = this.Get<StatusEffectData>("Instant Summon Junk In Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectInstantSummon;
      effectToApply2.targetSummon = statusEffectSummon6;
      effectToApply2.name = "Instant Summon Dream Base In Hand";
      collection2.SetString(effectToApply2.name + "_text", "Add a <keyword=dream> card to hand");
      effectToApply2.textKey = collection2.GetString(effectToApply2.name + "_text");
      effectToApply2.ModAdded = (WildfrostMod) this;
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectToApply2);
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectToApply2);
      Ext.CreateStatus<StatusEffectGiveDreamCard>("When Deployed Or Redraw, Gain Dream Card To Hand", "Gain a <keyword=dream> card on deploy and redraw", stackable: false).ApplyX<StatusEffectGiveDreamCard>((StatusEffectData) effectToApply2, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectGiveDreamCard>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Gain Dream Card To Hand", "Gain a <keyword=dream> card", stackable: false).ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply2, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      StatusEffectApplyXWhenCardDestroyed xwhenCardDestroyed2 = Ext.CreateStatus<StatusEffectApplyXWhenCardDestroyed>("When Card Destroyed, Gain Dream Card", "When an allied card is destroyed, gain a <keyword=dream> card").ApplyX<StatusEffectApplyXWhenCardDestroyed>((StatusEffectData) effectToApply2, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenCardDestroyed>((WildfrostMod) this);
      xwhenCardDestroyed2.mustBeOnBoard = false;
      xwhenCardDestroyed2.canBeEnemy = false;
      StatusEffectTemporaryTrait effectTemporaryTrait4 = this.Get<StatusEffectData>("Temporary Aimless").InstantiateKeepName<StatusEffectData>() as StatusEffectTemporaryTrait;
      effectTemporaryTrait4.name = "Temporary Combo";
      effectTemporaryTrait4.trait = this.Get<TraitData>("Combo");
      effectTemporaryTrait4.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectTemporaryTrait4);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectTemporaryTrait4);
      StatusEffectApplyXOnCardPlayed instance58 = ScriptableObject.CreateInstance<StatusEffectApplyXOnCardPlayed>();
      instance58.name = "Give Combo to Card in Hand";
      instance58.effectToApply = (StatusEffectData) effectTemporaryTrait4;
      instance58.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomCardInHand;
      instance58.type = "";
      instance58.applyConstraints = this.Get<CardUpgradeData>("CardUpgradeCritical").targetConstraints;
      collection2.SetString(instance58.name + "_text", "Give a card in hand <keyword=combo>");
      instance58.textKey = collection2.GetString(instance58.name + "_text");
      instance58.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance58);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance58);
      this.CreateBasicKeyword("teeterdance", "Teeter Dance", "<End Turn>: Trigger self, then enemies, then allies |Click to activate");
      this.CreateButtonIcon("ludicoloTeeterDance", AddressableExtMethods.ASprite("ludicolobutton"), "teeterDance", "", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("teeterdance")
      });
      this.CreateStatusButton<StatusTokenApplyX>("Trigger All Button", "teeterDance").ApplyX<StatusTokenApplyX>(this.Get<StatusEffectData>("Trigger"), StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusTokenApplyX>((WildfrostMod) this).endTurn = true;
      Ext.CreateStatus<StatusTokenApplyXListener>("Trigger All Listener_1", type: "teeterDance_listener").ApplyX<StatusTokenApplyXListener>(this.Get<StatusEffectData>("Trigger"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusTokenApplyXListener>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectInstantFullHeal>("Heal Full").Register<StatusEffectInstantFullHeal>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectInstantRemoveCounter>("Remove Counter").Register<StatusEffectInstantRemoveCounter>((WildfrostMod) this);
      this.CreateBasicKeyword("rest", "Rest", "<End Turn>: Heal to full, then set max counter to 99 and remove all effects |Click to activate");
      this.CreateButtonIcon("snorlaxRest", AddressableExtMethods.ASprite("snorlaxbutton"), "rest", "counter", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("rest")
      });
      StatusTokenApplyX statusTokenApplyX1 = this.CreateStatusButton<StatusTokenApplyX>("Rest Button", "rest").ApplyX<StatusTokenApplyX>(this.Get<StatusEffectData>("Heal Full"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusTokenApplyX>((WildfrostMod) this);
      statusTokenApplyX1.endTurn = true;
      statusTokenApplyX1.finiteUses = true;
      Ext.CreateStatus<StatusTokenApplyXListener>("Rest Listener_1", type: "rest_listener").ApplyX<StatusTokenApplyXListener>(this.Get<StatusEffectData>("Remove Counter"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusTokenApplyXListener>((WildfrostMod) this);
      this.CreateBasicKeyword("focusenergy", "Focus Energy", "<Free Action>: Discard the rightmost card in hand|Click to activate\nOnce per turn");
      this.CreateButtonIcon("kingdraFocusEnergy", AddressableExtMethods.ASprite("kingdrabutton"), "focusEnergy", "", Color.white, new KeywordData[1]
      {
        this.Get<KeywordData>("focusenergy")
      });
      StatusEffectMoveCard statusEffectMoveCard = Ext.CreateStatus<StatusEffectMoveCard>("Discard Self").Register<StatusEffectMoveCard>((WildfrostMod) this);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectMoveCard);
      this.CreateStatusButton<StatusTokenApplyX>("Discard Rightmost Button", "focusEnergy").ApplyX<StatusTokenApplyX>(this.Get<StatusEffectData>("Discard Self"), StatusEffectApplyX.ApplyToFlags.RightCardInHand).Register<StatusTokenApplyX>((WildfrostMod) this).oncePerTurn = true;
      StatusEffectApplyRandomOnCardPlayed instance59 = ScriptableObject.CreateInstance<StatusEffectApplyRandomOnCardPlayed>();
      instance59.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.Allies;
      instance59.effectsToapply = new StatusEffectData[2]
      {
        this.Get<StatusEffectData>("Increase Max Health"),
        this.Get<StatusEffectData>("Increase Attack")
      };
      instance59.canBeBoosted = true;
      instance59.name = "On Card Played Buff Marowak";
      instance59.applyFormat = "";
      instance59.type = "marowak";
      instance59.applyFormatKey = new LocalizedString();
      instance59.keyword = "";
      instance59.hiddenKeywords = new KeywordData[1]
      {
        this.TryGet<KeywordData>("randomeffect")
      };
      instance59.targetConstraints = new TargetConstraint[0];
      collection2.SetString(instance59.name + "_text", "Increase <Marowak's> <keyword=health> or <keyword=attack> by <{a}>");
      instance59.textKey = collection2.GetString(instance59.name + "_text");
      instance59.textOrder = 0;
      instance59.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance59);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance59);
      Ext.CreateStatus<StatusEffectDreamDummy>("Give Thick Club", "Gain a <Thick Club> upon evolution and battle end").Register<StatusEffectDreamDummy>((WildfrostMod) this);
      this.CreateBasicKeyword("curseofweakness", "Curse of Weakness", "While in hand, reduce <keyword=attack> of all allies by <1>|Cannot be cleared or replaced!").showName = true;
      this.CreateBasicKeyword("curseofpower", "Curse of Power", "While in hand, increase <keyword=attack> of all enemies by <1>|Cannot be cleared or replaced!").showName = true;
      this.CreateBasicKeyword("curseofpara", "Curse of Slumber", "While in hand, add <keyword=unmovable> to all allies|Cannot be cleared or replaced!").showName = true;
      this.CreateBasicKeyword("curseoffrenzy", "Curse of Frenzy", "While in hand, add <x1><keyword=frenzy> to all units|Cannot be cleared or replaced!").showName = true;
      this.CreateIcon("curseofweakicon", AddressableExtMethods.ASprite("curseofweakicon"), "weakcurse", "", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("curseofweakness")
      });
      this.CreateIcon("curseofpowericon", AddressableExtMethods.ASprite("curseofpowericon"), "powercurse", "", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("curseofpower")
      });
      this.CreateIcon("curseofparaicon", AddressableExtMethods.ASprite("curseofparaicon"), "paracurse", "", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("curseofpara")
      });
      this.CreateIcon("curseoffrenzyicon", AddressableExtMethods.ASprite("curseoffrenzyicon"), "frenzycurse", "", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("curseoffrenzy")
      });
      StatusEffectWhileInHandXUpdate effectToApply3 = Ext.CreateStatus<StatusEffectWhileInHandXUpdate>("WeakCurse", type: "weakcurse").ApplyX<StatusEffectWhileInHandXUpdate>(this.Get<StatusEffectData>("Ongoing Reduce Attack"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectWhileInHandXUpdate>((WildfrostMod) this);
      effectToApply3.iconGroupName = "crown";
      effectToApply3.visible = true;
      StatusEffectWhileInHandXUpdate effectToApply4 = Ext.CreateStatus<StatusEffectWhileInHandXUpdate>("PowerCurse", type: "powercurse").ApplyX<StatusEffectWhileInHandXUpdate>(this.Get<StatusEffectData>("Ongoing Increase Attack"), StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusEffectWhileInHandXUpdate>((WildfrostMod) this);
      effectToApply4.iconGroupName = "crown";
      effectToApply4.visible = true;
      StatusEffectWhileInHandXUpdate effectToApply5 = Ext.CreateStatus<StatusEffectWhileInHandXUpdate>("ParaCurse", type: "paracurse").ApplyX<StatusEffectWhileInHandXUpdate>(this.Get<StatusEffectData>("Temporary Unmovable"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectWhileInHandXUpdate>((WildfrostMod) this);
      effectToApply5.iconGroupName = "crown";
      effectToApply5.visible = true;
      StatusEffectWhileInHandXUpdate whileInHandXupdate = Ext.CreateStatus<StatusEffectWhileInHandXUpdate>("FrenzyCurse", type: "frenzycurse").ApplyX<StatusEffectWhileInHandXUpdate>(this.Get<StatusEffectData>("MultiHit"), StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusEffectWhileInHandXUpdate>((WildfrostMod) this);
      whileInHandXupdate.iconGroupName = "crown";
      whileInHandXupdate.visible = true;
      Ext.CreateStatus<StatusEffectApplyXPreTrigger>("Pre Trigger Gain Temp MultiHit Equal To Curses In Hand", "Attack an additional time for each <curse> in hand").ApplyX<StatusEffectApplyXPreTrigger>(this.Get<StatusEffectData>("MultiHit (Temporary, Not Visible)"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXPreTrigger>((WildfrostMod) this).scriptableAmount = (ScriptableAmount) ScriptableObject.CreateInstance<ScriptableCursesInHand>();
      Ext.CreateStatus<StatusEffectWhileExistingX>("Frenzy Equal To Curses In Hand", "Has <keyword=frenzy> equal to <curses> in hand").ApplyX<StatusEffectWhileExistingX>(this.Get<StatusEffectData>("MultiHit"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileExistingX>((WildfrostMod) this).scriptableAmount = (ScriptableAmount) ScriptableObject.CreateInstance<ScriptableCursesInHand>();
      StatusEffectWhileExistingX effectWhileExistingX = Ext.CreateStatus<StatusEffectWhileExistingX>("Frenzy Equal To Scrap", "Has <keyword=frenzy> equal to <keyword=scrap>").ApplyX<StatusEffectWhileExistingX>(this.Get<StatusEffectData>("MultiHit"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileExistingX>((WildfrostMod) this);
      ScriptableCurrentStatus instance60 = ScriptableObject.CreateInstance<ScriptableCurrentStatus>();
      instance60.statusType = "scrap";
      effectWhileExistingX.scriptableAmount = (ScriptableAmount) instance60;
      TargetConstraintStatusMoreThan instance61 = ScriptableObject.CreateInstance<TargetConstraintStatusMoreThan>();
      instance61.not = true;
      instance61.status = (StatusEffectData) effectToApply3;
      instance61.amount = 0;
      TargetConstraintStatusMoreThan instance62 = ScriptableObject.CreateInstance<TargetConstraintStatusMoreThan>();
      instance62.not = true;
      instance62.status = (StatusEffectData) effectToApply4;
      instance62.amount = 0;
      TargetConstraintStatusMoreThan instance63 = ScriptableObject.CreateInstance<TargetConstraintStatusMoreThan>();
      instance63.not = true;
      instance63.status = (StatusEffectData) effectToApply5;
      instance63.amount = 0;
      TargetConstraintStatusMoreThan instance64 = ScriptableObject.CreateInstance<TargetConstraintStatusMoreThan>();
      instance64.not = true;
      instance64.status = (StatusEffectData) whileInHandXupdate;
      instance64.amount = 0;
      TargetConstraintHasTrait instance65 = ScriptableObject.CreateInstance<TargetConstraintHasTrait>();
      instance65.not = true;
      instance65.trait = instance57;
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Give Random Card In Hand While In Hand Reduce Attack To Allies", "Give a card in hand <keyword=curseofweakness>").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply3, StatusEffectApplyX.ApplyToFlags.RandomCardInHand).SetApplyConstraints<StatusEffectApplyXOnCardPlayed>((TargetConstraint) instance61, (TargetConstraint) instance62, (TargetConstraint) instance63, (TargetConstraint) instance64, (TargetConstraint) instance65).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Give Random Card In Hand While In Hand Increase Attack To Enemies", "Give a card in hand <keyword=curseofpower>").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply4, StatusEffectApplyX.ApplyToFlags.RandomCardInHand).SetApplyConstraints<StatusEffectApplyXOnCardPlayed>((TargetConstraint) instance61, (TargetConstraint) instance62, (TargetConstraint) instance63, (TargetConstraint) instance64, (TargetConstraint) instance65).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Give Random Card In Hand While In Hand Unmovable To Allies", "Give a card in hand <keyword=curseofpara>").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply5, StatusEffectApplyX.ApplyToFlags.RandomCardInHand).SetApplyConstraints<StatusEffectApplyXOnCardPlayed>((TargetConstraint) instance61, (TargetConstraint) instance62, (TargetConstraint) instance63, (TargetConstraint) instance64, (TargetConstraint) instance65).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      KeywordData iconKeyword2 = this.CreateIconKeyword("jolted", "Jolted", "Take damage after triggering | Does not count down!", "joltedicon");
      nullable2 = new Color?(new Color(0.98f, 0.89f, 0.61f));
      Color? title4 = new Color?();
      Color? body4 = new Color?();
      Color? note4 = nullable2;
      iconKeyword2.ChangeColor(title4, body4, note4);
      this.CreateIcon("joltedicon", AddressableExtMethods.ASprite("joltedicon"), "jolted", "counter", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("jolted")
      }, -1);
      StatusEffectJolted statusEffectJolted = Ext.CreateStatus<StatusEffectJolted>("Jolted", type: "jolted").Register<StatusEffectJolted>((WildfrostMod) this);
      statusEffectJolted.iconGroupName = "health";
      statusEffectJolted.visible = true;
      statusEffectJolted.removeOnDiscard = true;
      statusEffectJolted.isStatus = true;
      statusEffectJolted.offensive = true;
      statusEffectJolted.stackable = true;
      statusEffectJolted.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintIsUnit>()
      };
      statusEffectJolted.textInsert = "{a}";
      statusEffectJolted.keyword = "jolted";
      statusEffectJolted.applyFormatKey = this.Get<StatusEffectData>("Shroom").applyFormatKey;
      KeywordData iconKeyword3 = this.CreateIconKeyword("spicune", "Juice", "Temporarily boosts effects | Clears after triggering", "juice");
      Color? title5 = new Color?(new Color(0.23f, 0.96f, 0.8f));
      nullable2 = new Color?(new Color(0.23f, 0.96f, 0.8f));
      Color? body5 = new Color?();
      Color? note5 = nullable2;
      iconKeyword3.ChangeColor(title5, body5, note5);
      GameObject icon = this.CreateIcon("juiceicon", AddressableExtMethods.ASprite("juiceicon"), "juice", "lumin", Color.black, new KeywordData[1]
      {
        this.Get<KeywordData>("spicune")
      });
      icon.GetComponentInChildren<TextMeshProUGUI>(true).enabled = true;
      icon.GetComponent<RectTransform>().sizeDelta = new Vector2(1f, 1.1f);
      StatusEffectSpicune statusEffectSpicune = Ext.CreateStatus<StatusEffectSpicune>("Spicune", type: "juice").Register<StatusEffectSpicune>((WildfrostMod) this);
      statusEffectSpicune.eventPriority = -999;
      statusEffectSpicune.iconGroupName = "damage";
      statusEffectSpicune.visible = true;
      statusEffectSpicune.isStatus = true;
      statusEffectSpicune.offensive = false;
      statusEffectSpicune.stackable = true;
      statusEffectSpicune.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintCanBeBoosted>()
      };
      statusEffectSpicune.textInsert = "{a}";
      statusEffectSpicune.keyword = "spicune";
      statusEffectSpicune.applyFormatKey = this.Get<StatusEffectData>("Shroom").applyFormatKey;
      KeywordData iconKeyword4 = this.CreateIconKeyword("burning", "Ignite", "Explodes when hit or damaged, hurting allies in row then clearing | Applying more increases the explosion!", "burningicon");
      Color? title6 = new Color?(new Color(1f, 0.2f, 0.2f));
      nullable2 = new Color?(new Color(1f, 0.2f, 0.2f));
      Color? body6 = new Color?();
      Color? note6 = nullable2;
      iconKeyword4.ChangeColor(title6, body6, note6);
      this.CreateIcon("burningicon", AddressableExtMethods.ASprite("burningicon"), "burning", "spice", Color.white, new KeywordData[1]
      {
        this.Get<KeywordData>("burning")
      }, -1).GetComponentInChildren<TextMeshProUGUI>(true).gameObject.transform.localPosition = new Vector3(0.0f, -0.06f, 0.0f);
      StatusEffectBurning effectToApply6 = Ext.CreateStatus<StatusEffectBurning>("Burning", type: "burning").Register<StatusEffectBurning>((WildfrostMod) this);
      effectToApply6.iconGroupName = "health";
      effectToApply6.visible = true;
      effectToApply6.removeOnDiscard = true;
      effectToApply6.isStatus = true;
      effectToApply6.offensive = true;
      effectToApply6.stackable = true;
      effectToApply6.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintIsUnit>()
      };
      effectToApply6.textInsert = "{a}";
      effectToApply6.keyword = "burning";
      effectToApply6.applyFormatKey = this.Get<StatusEffectData>("Shroom").applyFormatKey;
      Ext.CreateStatus<StatusEffectApplyXOnKill>("On Kill Boost Effects", "Boost effects on kill").ApplyX<StatusEffectApplyXOnKill>(this.Get<StatusEffectData>("Increase Effects"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnKill>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenUnitIsKilled>("When Unit Is Killed Boost Effects", "When an ally or enemy is killed, boost effects").ApplyX<StatusEffectApplyXWhenUnitIsKilled>(this.Get<StatusEffectData>("Increase Effects"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenUnitIsKilled>((WildfrostMod) this).enemy = true;
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Reduce Attack To Enemies", "While active, reduce <keyword=attack> of all enemies by <{a}>", boostable: true).ApplyX<StatusEffectWhileActiveX>(this.Get<StatusEffectData>("Ongoing Reduce Attack"), StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Boost Allies", "When hit, boost effects of all allies").ApplyX<StatusEffectApplyXWhenHit>(this.Get<StatusEffectData>("Increase Effects"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenDestroyed>("When Destroyed Boost Allies", "When destroyed, boost effects of all allies by <{a}>", boostable: true).ApplyX<StatusEffectApplyXWhenDestroyed>(this.Get<StatusEffectData>("Increase Effects"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXWhenDestroyed>((WildfrostMod) this).targetMustBeAlive = false;
      KeywordData basicKeyword9 = this.CreateBasicKeyword("falseswipe", "False Swipe", "Deals nonlethal damage|Except to Clunkers");
      basicKeyword9.showName = true;
      StatusEffectFalseSwipe effectFalseSwipe = Ext.CreateStatus<StatusEffectFalseSwipe>("False Swipe").Register<StatusEffectFalseSwipe>((WildfrostMod) this);
      effectFalseSwipe.eventPriority = -3;
      Ext.CreateTrait<TraitData>("FalseSwipe", (WildfrostMod) this, basicKeyword9, (StatusEffectData) effectFalseSwipe);
      KeywordData basicKeyword10 = this.CreateBasicKeyword("resist", "Resist", "Reduce damage by <???>");
      basicKeyword10.showName = true;
      basicKeyword10.canStack = true;
      StatusEffectResist statusEffectResist = Ext.CreateStatus<StatusEffectResist>("Resist", boostable: true).Register<StatusEffectResist>((WildfrostMod) this);
      Ext.CreateTrait<TraitData>("Resist", (WildfrostMod) this, basicKeyword10, (StatusEffectData) statusEffectResist);
      StatusEffectTemporaryTrait effectToApply7 = Ext.CreateStatus<StatusEffectTemporaryTrait>("Temp Resist", stackable: false).Register<StatusEffectTemporaryTrait>((WildfrostMod) this);
      effectToApply7.trait = this.Get<TraitData>("Resist");
      this.CreateBasicKeyword("transfer", "Transfer", "Give this effect to a random ally");
      StatusEffectMultEffects effectToApply8 = Ext.CreateStatus<StatusEffectMultEffects>("Effects for Transfering Resist to Random Ally").Register<StatusEffectMultEffects>((WildfrostMod) this);
      StatusEffectTransfer effectToApply9 = Ext.CreateStatus<StatusEffectTransfer>("Transfer Resist to Random Ally").ApplyX<StatusEffectTransfer>((StatusEffectData) effectToApply8, StatusEffectApplyX.ApplyToFlags.RandomAlly).Register<StatusEffectTransfer>((WildfrostMod) this);
      StatusEffectApplyXWhenHit effectApplyXwhenHit2 = Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Transfer Resist to Random Ally", "When hit, <keyword=transfer> '<keyword=resist> {a}' to a random ally").ApplyX<StatusEffectApplyXWhenHit>((StatusEffectData) effectToApply9, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      effectToApply8.effects = new List<StatusEffectData>()
      {
        (StatusEffectData) effectToApply7,
        (StatusEffectData) effectApplyXwhenHit2
      };
      effectToApply9.targetMustBeAlive = false;
      effectApplyXwhenHit2.targetMustBeAlive = false;
      StatusEffectPickup statusEffectPickup = Ext.CreateStatus<StatusEffectPickup>("Pickup Items And Clunkers", boostable: true).Register<StatusEffectPickup>((WildfrostMod) this);
      statusEffectPickup.constraint = (Func<CardData, bool>) (c => c.cardType.name == "Item" || c.cardType.name == "Clunker");
      statusEffectPickup.rewardPoolNames = new string[5]
      {
        "GeneralItemPool",
        "SnowItemPool",
        "BasicItemPool",
        "MagicItemPool",
        "ClunkItemPool"
      };
      KeywordData basicKeyword11 = this.CreateBasicKeyword("pickup", "Pickup", "Pick one card from a selection of <???> at the end of battle");
      basicKeyword11.canStack = true;
      basicKeyword11.showName = true;
      basicKeyword11.showIcon = false;
      Ext.CreateTrait<TraitData>("Pickup", (WildfrostMod) this, basicKeyword11, (StatusEffectData) statusEffectPickup);
      StatusEffectWhileActiveX effectWhileActiveX2 = Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Allies Have Resist (No Desc)", stackable: false).ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply7, StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      StatusEffectMultEffects effectToApply10 = Ext.CreateStatus<StatusEffectMultEffects>("Effects for Transfering Resist to Allies to Random Ally").Register<StatusEffectMultEffects>((WildfrostMod) this);
      StatusEffectTransfer effectToApply11 = Ext.CreateStatus<StatusEffectTransfer>("Transfer Resist to Allies to Random Ally").ApplyX<StatusEffectTransfer>((StatusEffectData) effectToApply10, StatusEffectApplyX.ApplyToFlags.RandomAlly).Register<StatusEffectTransfer>((WildfrostMod) this);
      StatusEffectApplyXWhenHit effectApplyXwhenHit3 = Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Transfer Resist to Allies to Random Ally", "When hit, <keyword=transfer> 'While acitve, add <keyword=resist> {a} to all allies'").ApplyX<StatusEffectApplyXWhenHit>((StatusEffectData) effectToApply11, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      effectToApply10.effects = new List<StatusEffectData>()
      {
        (StatusEffectData) effectWhileActiveX2,
        (StatusEffectData) effectApplyXwhenHit3
      };
      effectToApply11.targetMustBeAlive = false;
      effectApplyXwhenHit3.targetMustBeAlive = false;
      StatusEffectMultEffects effectToApply12 = Ext.CreateStatus<StatusEffectMultEffects>("Effects for Transfering MultiHit to Random Ally").Register<StatusEffectMultEffects>((WildfrostMod) this);
      StatusEffectTransfer effectToApply13 = Ext.CreateStatus<StatusEffectTransfer>("Transfer MultiHit to Random Ally").ApplyX<StatusEffectTransfer>((StatusEffectData) effectToApply12, StatusEffectApplyX.ApplyToFlags.RandomAlly).Register<StatusEffectTransfer>((WildfrostMod) this);
      StatusEffectApplyXWhenHit effectApplyXwhenHit4 = Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Transfer MultiHit to Random Ally", "When hit, <keyword=transfer> 'x{a}<keyword=frenzy>'").ApplyX<StatusEffectApplyXWhenHit>((StatusEffectData) effectToApply13, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      effectToApply12.effects = new List<StatusEffectData>()
      {
        this.Get<StatusEffectData>("MultiHit"),
        (StatusEffectData) effectApplyXwhenHit4
      };
      effectToApply13.targetMustBeAlive = false;
      effectApplyXwhenHit4.targetMustBeAlive = false;
      StatusEffectMultEffects effectToApply14 = Ext.CreateStatus<StatusEffectMultEffects>("Effects for Transfering Attack to Random Ally").Register<StatusEffectMultEffects>((WildfrostMod) this);
      StatusEffectTransfer effectToApply15 = Ext.CreateStatus<StatusEffectTransfer>("Transfer Attack to Random Ally").ApplyX<StatusEffectTransfer>((StatusEffectData) effectToApply14, StatusEffectApplyX.ApplyToFlags.RandomAlly).Register<StatusEffectTransfer>((WildfrostMod) this);
      effectToApply15.applyConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintDoesDamage>()
      };
      effectToApply15.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintDoesDamage>()
      };
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed6 = Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Transfer Attack to Random Ally", "<keyword=transfer> '+{a}<keyword=attack>'").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply15, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      effectToApply14.effects = new List<StatusEffectData>()
      {
        this.Get<StatusEffectData>("Ongoing Increase Attack"),
        (StatusEffectData) applyXonCardPlayed6
      };
      effectToApply15.targetMustBeAlive = false;
      applyXonCardPlayed6.targetMustBeAlive = false;
      StatusEffectSummon statusEffectSummon7 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      statusEffectSummon7.summonCard = this.Get<CardData>("Dart");
      statusEffectSummon7.gainTrait = this.Get<StatusEffectData>("Temporary Zoomlin");
      statusEffectSummon7.name = "Summon Tar Blade";
      statusEffectSummon7.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) statusEffectSummon7);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) statusEffectSummon7);
      StatusEffectInstantSummon effectInstantSummon5 = this.Get<StatusEffectData>("Instant Summon Junk In Hand").InstantiateKeepName<StatusEffectData>() as StatusEffectInstantSummon;
      effectInstantSummon5.targetSummon = this.Get<StatusEffectData>("Summon Tar Blade") as StatusEffectSummon;
      effectInstantSummon5.name = "Instant Summon Tar Blade In Hand";
      effectInstantSummon5.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) effectInstantSummon5);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) effectInstantSummon5);
      Ext.CreateStatus<StatusEffectInstantAddDeck>("Add Tar Blade To Deck").Register<StatusEffectInstantAddDeck>((WildfrostMod) this).card = this.Get<CardData>("Dart");
      this.CreateBasicKeyword("tarshot", "Tar Shot", "<Free Action>: Place a <card=Dart> into your hand and backpack\n Give it <keyword=zoomlin> this battle |Click to activate\n Once per turn\n Thrice per battle");
      this.CreateButtonIcon("mukTarShot", AddressableExtMethods.ASprite("mukbutton"), "tarshot", "ink", Color.white, new KeywordData[1]
      {
        this.Get<KeywordData>("tarshot")
      }).GetComponentInChildren<TextMeshProUGUI>().fontSize = 0.5f;
      StatusTokenApplyX statusTokenApplyX2 = this.CreateStatusButton<StatusTokenApplyX>("Add Tar Blade Button", "tarshot").ApplyX<StatusTokenApplyX>(this.Get<StatusEffectData>("Instant Summon Tar Blade In Hand"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusTokenApplyX>((WildfrostMod) this);
      statusTokenApplyX2.oncePerTurn = true;
      statusTokenApplyX2.finiteUses = true;
      statusTokenApplyX2.applyEqualAmount = true;
      statusTokenApplyX2.fixedAmount = 1;
      Ext.CreateStatus<StatusTokenApplyXListener>("Tar Shot Listener_1", type: "tarshot_listener").ApplyX<StatusTokenApplyXListener>(this.Get<StatusEffectData>("Add Tar Blade To Deck"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusTokenApplyXListener>((WildfrostMod) this);
      StatusEffectInstantHitRedrawBell effectToApply16 = Ext.CreateStatus<StatusEffectInstantHitRedrawBell>("Hit Redraw Bell").Register<StatusEffectInstantHitRedrawBell>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Hit Redraw Bell", "Hit <Redraw Bell>").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply16, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      this.CreateBasicKeyword("conduit", "Conduit", "Does an effect whenever anyone takes damage from <keyword=jolted>").showName = true;
      Ext.CreateStatus<StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage>("When Anyone Takes Jolted Damage Apply Equal Jolted To A Random Enemy", "<keyword=conduit>: Apply equal <keyword=jolted> to a random enemy").ApplyX<StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage>(this.Get<StatusEffectData>("Jolted"), StatusEffectApplyX.ApplyToFlags.RandomEnemy).Register<StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage>((WildfrostMod) this).targetDamageType = "jolt";
      Ext.CreateStatus<StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage>("When Anyone Takes Jolted Damage Apply Equal Jolted To Front Enemy", "<keyword=conduit>: Apply equal <keyword=jolted> to front enemy").ApplyX<StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage>(this.Get<StatusEffectData>("Jolted"), StatusEffectApplyX.ApplyToFlags.FrontEnemy).Register<StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage>((WildfrostMod) this).targetDamageType = "jolt";
      StatusEffectApplyXWhenAnyoneTakesDamage anyoneTakesDamage = Ext.CreateStatus<StatusEffectApplyXWhenAnyoneTakesDamage>("When Anyone Takes Jolted Damage Trigger", "<keyword=conduit>: Trigger").ApplyX<StatusEffectApplyXWhenAnyoneTakesDamage>(this.Get<StatusEffectData>("Trigger (High Prio)"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenAnyoneTakesDamage>((WildfrostMod) this);
      anyoneTakesDamage.targetDamageType = "jolt";
      anyoneTakesDamage.isReaction = true;
      anyoneTakesDamage.descColorHex = "F99C61";
      Ext.CreateStatus<StatusEffectApplyXWhenDestroyed>("When Destroyed Apply Shroom To All Enemies In Row", "When destroyed, apply <{a}><keyword=shroom> to all enemies in row", boostable: true).ApplyX<StatusEffectApplyXWhenDestroyed>(this.Get<StatusEffectData>("Shroom"), StatusEffectApplyX.ApplyToFlags.EnemiesInRow).Register<StatusEffectApplyXWhenDestroyed>((WildfrostMod) this).targetMustBeAlive = false;
      Ext.CreateStatus<StatusEffectApplyXWhenDestroyed>("When Destroyed Apply Bom To All Enemies In Row", "When destroyed, apply <{a}><keyword=weakness> to all enemies in row", boostable: true).ApplyX<StatusEffectApplyXWhenDestroyed>(this.Get<StatusEffectData>("Weakness"), StatusEffectApplyX.ApplyToFlags.EnemiesInRow).Register<StatusEffectApplyXWhenDestroyed>((WildfrostMod) this).targetMustBeAlive = false;
      StatusEffectBonusDamageEqualToX bonusDamageEqualToX = Ext.CreateStatus<StatusEffectBonusDamageEqualToX>("Deal Bonus Damage Equal To Cards In Hand", "Deal additional damage equal to cards in hand").Register<StatusEffectBonusDamageEqualToX>((WildfrostMod) this);
      bonusDamageEqualToX.on = StatusEffectBonusDamageEqualToX.On.ScriptableAmount;
      bonusDamageEqualToX.scriptableAmount = (ScriptableAmount) ScriptableObject.CreateInstance<ScriptableCardsInHand>();
      TargetModeStatus instance66 = ScriptableObject.CreateInstance<TargetModeStatus>();
      instance66.missing = true;
      instance66.targetType = "burning";
      Ext.CreateStatus<StatusEffectChangeTargetMode>("Hits All NonBurning Targets", "Hit all enemies without <keyword=burning>").Register<StatusEffectChangeTargetMode>((WildfrostMod) this).targetMode = (TargetMode) instance66;
      StatusEffectWeather effectToApply17 = Ext.CreateStatus<StatusEffectWeather>("Sandstorm").Register<StatusEffectWeather>((WildfrostMod) this);
      effectToApply17.color = new Color(1f, 1f, 0.75f);
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Sandstorm").ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply17, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      StatusEffectWeather effectToApply18 = Ext.CreateStatus<StatusEffectWeather>("Snowstorm").Register<StatusEffectWeather>((WildfrostMod) this);
      effectToApply18.color = new Color(1f, 1f, 1f);
      effectToApply18.intensityMultiplier = 5f;
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Snowstorm").ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply18, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      StatusEffectAddAttackEffects effectToApply19 = Ext.CreateStatus<StatusEffectAddAttackEffects>("All Hits Apply Snow", boostable: true).Register<StatusEffectAddAttackEffects>((WildfrostMod) this);
      effectToApply19.effectToApply = this.Get<StatusEffectData>("Snow");
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active All Hits Apply Snow", "While active, everyone applies <{a}><keyword=snow>").ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply19, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      StatusEffectDuplicateEffect effectDuplicateEffect1 = Ext.CreateStatus<StatusEffectDuplicateEffect>("Copy Effects Applied To Ally Ahead").ApplyX<StatusEffectDuplicateEffect>(this.Get<StatusEffectData>("Gain Gold"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectDuplicateEffect>((WildfrostMod) this);
      effectDuplicateEffect1.applyEqualAmount = true;
      effectDuplicateEffect1.whenAppliedFlags = StatusEffectApplyX.ApplyToFlags.AllyInFrontOf;
      effectDuplicateEffect1.eventPriority = -25;
      KeywordData basicKeyword12 = this.CreateBasicKeyword("synchronize", "Synchronize", "When a status effect or stat change is applied to ally ahead, also apply it to self|Watch out for debuffs!");
      basicKeyword12.canStack = false;
      Ext.CreateTrait<TraitData>("Synchronize", (WildfrostMod) this, basicKeyword12, (StatusEffectData) effectDuplicateEffect1);
      StatusEffectDuplicateEffect effectDuplicateEffect2 = Ext.CreateStatus<StatusEffectDuplicateEffect>("Copy Effects Applied To Ally Ahead For Row").ApplyX<StatusEffectDuplicateEffect>(this.Get<StatusEffectData>("Gain Gold"), StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.AllyBehind).Register<StatusEffectDuplicateEffect>((WildfrostMod) this);
      effectDuplicateEffect2.applyEqualAmount = true;
      effectDuplicateEffect2.whenAppliedFlags = StatusEffectApplyX.ApplyToFlags.AllyInFrontOf;
      effectDuplicateEffect2.eventPriority = -25;
      KeywordData basicKeyword13 = this.CreateBasicKeyword("synchronize2", "Synchronize II", "When a status effect or stat change is applied to ally ahead, also apply it to self <AND ally behind>|Watch out for debuffs!");
      basicKeyword13.canStack = false;
      Ext.CreateTrait<TraitData>("Synchronize2", (WildfrostMod) this, basicKeyword13, (StatusEffectData) effectDuplicateEffect2);
      StatusEffectApplyXInstant effectToApply20 = Ext.CreateStatus<StatusEffectApplyXInstant>("Dummy Instant To Random Ally").ApplyX<StatusEffectApplyXInstant>((StatusEffectData) null, StatusEffectApplyX.ApplyToFlags.RandomAlly);
      StatusEffectDuplicateEffect effectDuplicateEffect3 = Ext.CreateStatus<StatusEffectDuplicateEffect>("Copy Effects Applied To Front Enemy", "When a <debuff> is applied to the front enemy, also apply it to a random enemy").ApplyX<StatusEffectDuplicateEffect>((StatusEffectData) effectToApply20, StatusEffectApplyX.ApplyToFlags.FrontEnemy).Register<StatusEffectDuplicateEffect>((WildfrostMod) this);
      effectDuplicateEffect3.applyEqualAmount = true;
      effectDuplicateEffect3.instantCustom = true;
      effectDuplicateEffect3.debuffsOnly = true;
      effectDuplicateEffect3.whenAppliedFlags = StatusEffectApplyX.ApplyToFlags.FrontEnemy;
      effectDuplicateEffect3.hiddenKeywords = new KeywordData[1]
      {
        this.Get<KeywordData>("debuffed")
      };
      effectDuplicateEffect3.eventPriority = -25;
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("Give Cards In Hand Juice", "Apply <{a}><keyword=spicune> to cards in hand", boostable: true).ApplyX<StatusEffectApplyXOnCardPlayed>(this.Get<StatusEffectData>("Spicune"), StatusEffectApplyX.ApplyToFlags.Hand).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("Give Allies Juice", "Apply <{a}><keyword=spicune> to allies", boostable: true).ApplyX<StatusEffectApplyXOnCardPlayed>(this.Get<StatusEffectData>("Spicune"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenHit>("Gain Juice On Hit", "When hit, gain <{a}><keyword=spicune>", boostable: true).ApplyX<StatusEffectApplyXWhenHit>(this.Get<StatusEffectData>("Spicune"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      StatusEffectApplyXPreTurn effectApplyXpreTurn3 = Ext.CreateStatus<StatusEffectApplyXPreTurn>("Give Your Juice To All", "Apply current <keyword=spicune> to everything else").ApplyX<StatusEffectApplyXPreTurn>(this.Get<StatusEffectData>("Spicune"), StatusEffectApplyX.ApplyToFlags.Hand | StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusEffectApplyXPreTurn>((WildfrostMod) this);
      ScriptableCurrentStatus instance67 = ScriptableObject.CreateInstance<ScriptableCurrentStatus>();
      instance67.statusType = "juice";
      effectApplyXpreTurn3.scriptableAmount = (ScriptableAmount) instance67;
      Ext.CreateStatus<StatusEffectApplyXPreTurn>("Give Your Juice To Allies", "Apply current <keyword=spicune> to allies").ApplyX<StatusEffectApplyXPreTurn>(this.Get<StatusEffectData>("Spicune"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXPreTurn>((WildfrostMod) this).scriptableAmount = (ScriptableAmount) instance67;
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("Give Revive To Allies", "Add <keyword=revive> to allies").ApplyX<StatusEffectApplyXOnCardPlayed>(this.Get<StatusEffectData>("Revive"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      StatusEffectSummon status1 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      status1.name = "Summon Placeholder";
      status1.Register<StatusEffectSummon>((WildfrostMod) this);
      StatusEffectInstantSummonCustom effectToApply21 = Ext.CreateStatus<StatusEffectInstantSummonCustom>("Instant Summon Placeholder To Hand").Register<StatusEffectInstantSummonCustom>((WildfrostMod) this);
      effectToApply21.targetSummon = status1;
      effectToApply21.summonPosition = StatusEffectInstantSummon.Position.Hand;
      Ext.CreateStatus<StatusEffectApplyXWhenDeployed>("When Deployed Summon Placeholder To Hand", "When deployed, add the <keyword=prophesized> card to hand").ApplyX<StatusEffectApplyXWhenDeployed>((StatusEffectData) effectToApply21, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXWhenDeployed>((WildfrostMod) this);
      this.CreateBasicKeyword("prophesized", "Prophesized", "The card is fated to be in your deck");
      StatusEffectSummon statusEffectSummon8 = this.Get<StatusEffectData>("Summon Plep").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      StatusEffectInstantSummonReserve effectToApply22 = Ext.CreateStatus<StatusEffectInstantSummonReserve>("Instant Summon Companion From Reserve").Register<StatusEffectInstantSummonReserve>((WildfrostMod) this);
      effectToApply22.targetSummon = statusEffectSummon8;
      effectToApply22.summonPosition = StatusEffectInstantSummon.Position.InFrontOf;
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Summon From Reserve", "Summon an ally from the reserve").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply22, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      StatusEffectInstantRunScript effectToApply23 = Ext.CreateStatus<StatusEffectInstantRunScript>("Return Prophesized Card To Hand").Register<StatusEffectInstantRunScript>((WildfrostMod) this);
      effectToApply23.scriptList = new List<EntityCardScript>()
      {
        (EntityCardScript) ScriptableObject.CreateInstance<EntityCardScriptReturnProphCard>()
      };
      Ext.CreateStatus<StatusEffectApplyXOnTurn>("On Turn Return Prophesized Card To Hand", "Return the <keyword=prophesized> card to hand").ApplyX<StatusEffectApplyXOnTurn>((StatusEffectData) effectToApply23, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnTurn>((WildfrostMod) this);
      StatusEffectApplyXWhenCertainCardPlayed certainCardPlayed = Ext.CreateStatus<StatusEffectApplyXWhenCertainCardPlayed>("When Prophesized Card Played Give Allies Attack", "When the <keyword=prophesized> card is played, add <+{a}><keyword=attack> to all allies", boostable: true).ApplyX<StatusEffectApplyXWhenCertainCardPlayed>(this.Get<StatusEffectData>("Increase Attack"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXWhenCertainCardPlayed>((WildfrostMod) this);
      certainCardPlayed.useCardName = false;
      certainCardPlayed.useCustomData = true;
      certainCardPlayed.customDataKey = "Future Sight";
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("Deal Damage To All Enemies", "Deal <{a}> damage to all enemies", boostable: true).ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) null, StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this).dealDamage = true;
      this.CreateBasicKeyword("lavaplume", "Lava Plume", "<Free Action>: Convert the front enemy's <keyword=spice> into <keyword=burning>|Click to activate\nOnce per turn");
      this.CreateButtonIcon("magcargoLavaPlume", AddressableExtMethods.ASprite("magcargobutton"), "lavaPlume", "", Color.white, new KeywordData[1]
      {
        this.Get<KeywordData>("lavaplume")
      });
      StatusEffectConvertEffects effectToApply24 = Ext.CreateStatus<StatusEffectConvertEffects>("Instance Convert Spice To Burning").Register<StatusEffectConvertEffects>((WildfrostMod) this);
      effectToApply24.effectA = "Spice";
      effectToApply24.effectB = "Burning";
      this.CreateStatusButton<StatusTokenApplyX>("Convert Spice To Burning To Front Enemy", "lavaPlume").ApplyX<StatusTokenApplyX>((StatusEffectData) effectToApply24, StatusEffectApplyX.ApplyToFlags.FrontEnemy).Register<StatusTokenApplyX>((WildfrostMod) this).oncePerTurn = true;
      this.CreateBasicKeyword("fidget", "Fidget", "<Free Action>: Replace <Trash> with <Recycle> and vice versa|Click to activate");
      this.CreateButtonIcon("aronFidget", AddressableExtMethods.ASprite("aronbutton"), "fidget", "", Color.white, new KeywordData[1]
      {
        this.Get<KeywordData>("fidget")
      });
      Ext.CreateStatus<StatusEffectInstantRunScript>("Run Fidget Script").Register<StatusEffectInstantRunScript>((WildfrostMod) this).scriptList = new List<EntityCardScript>()
      {
        (EntityCardScript) EntityCardScriptSwapTraits.Create(this.Get<TraitData>("Trash"), this.Get<TraitData>("Recycle"))
      };
      this.CreateStatusButton<StatusTokenApplyX>("Fidget Button", "fidget").ApplyX<StatusTokenApplyX>(this.Get<StatusEffectData>("Run Fidget Script"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusTokenApplyX>((WildfrostMod) this);
      StatusEffectAllCardsAreRecycled effectToApply25 = Ext.CreateStatus<StatusEffectAllCardsAreRecycled>("All Cards Are Recyclable").Register<StatusEffectAllCardsAreRecycled>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active All Cards Are Recyclable", "While active, all cards are recyclable").ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply25, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      StatusEffectUnlimitedLumin effectToApply26 = Ext.CreateStatus<StatusEffectUnlimitedLumin>("Unlimited Lumin").Register<StatusEffectUnlimitedLumin>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Unlimited Lumin", "While active, <keyword=lumin> does not clear!").ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply26, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      this.CreateBasicKeyword("autotomize", "Autotomize", "<Free Action>: Return the last <Recycled> card to hand|Click to activate\nRecycle to refresh");
      this.CreateButtonIcon("aggronAutotomize", AddressableExtMethods.ASprite("aggronbutton"), "autotomize", "", Color.white, new KeywordData[1]
      {
        this.Get<KeywordData>("autotomize")
      });
      StatusEffectInstantSummonLastRecycled effectToApply27 = Ext.CreateStatus<StatusEffectInstantSummonLastRecycled>("Instant Summon Last Recycled To Hand").Register<StatusEffectInstantSummonLastRecycled>((WildfrostMod) this);
      effectToApply27.targetSummon = status1;
      effectToApply27.summonPosition = StatusEffectInstantSummon.Position.Hand;
      StatusTokenApplyX statusTokenApplyX3 = this.CreateStatusButton<StatusTokenApplyX>("Autotomize Button", "autotomize").ApplyX<StatusTokenApplyX>((StatusEffectData) effectToApply27, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusTokenApplyX>((WildfrostMod) this);
      statusTokenApplyX3.clickConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintHasLastRecycled>()
      };
      statusTokenApplyX3.genericPopup = StatusTokenApplyX.Key_Autotomize;
      StatusEffectSummon status2 = this.Get<StatusEffectData>("Summon Junk").InstantiateKeepName<StatusEffectData>() as StatusEffectSummon;
      status2.name = "Summon Lumin Goop or Broken Vase";
      status2.summonCard = this.Get<CardData>("LuminSealant");
      status2.Register<StatusEffectSummon>((WildfrostMod) this);
      StatusEffectInstantSummonLuminPart effectToApply28 = Ext.CreateStatus<StatusEffectInstantSummonLuminPart>("Instant Summon Lumin Part").Register<StatusEffectInstantSummonLuminPart>((WildfrostMod) this);
      effectToApply28.targetSummon = status2;
      effectToApply28.summonPosition = StatusEffectInstantSummon.Position.Hand;
      effectToApply28.card1 = this.Get<CardData>("LuminSealant");
      effectToApply28.card2 = this.Get<CardData>("BrokenVase");
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("Apply Lumin To Random Ally", "Apply <keyword=lumin> to a random ally").ApplyX<StatusEffectApplyXOnCardPlayed>(this.TryGet<StatusEffectData>("Lumin"), StatusEffectApplyX.ApplyToFlags.RandomAlly).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      StatusEffectApplyXOnCardPlayed applyXonCardPlayed7 = Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Add Lumin Part To Hand").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply28, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      KeywordData basicKeyword14 = this.CreateBasicKeyword("salvage", "Salvage", "Add a <Lumin Part> to hand that can combine into <card=LuminVase> with <keyword=zoomlin> and <keyword=consume>");
      basicKeyword14.canStack = false;
      Ext.CreateTrait<TraitData>("Salvage", (WildfrostMod) this, basicKeyword14, (StatusEffectData) applyXonCardPlayed7);
      StatusEffectAddAttackEffects effectToApply29 = Ext.CreateStatus<StatusEffectAddAttackEffects>("Allied Hits Have Burning", boostable: true).Register<StatusEffectAddAttackEffects>((WildfrostMod) this);
      effectToApply29.sameOwner = true;
      effectToApply29.includeSelf = false;
      effectToApply29.effectToApply = (StatusEffectData) effectToApply6;
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Allied Hits Have Burning", "While active, allies apply <{a}><keyword=burning>").ApplyX<StatusEffectWhileActiveX>((StatusEffectData) effectToApply29, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Increase Targets Counter", "Increase target's <keyword=counter> by <{a}>", boostable: true).ApplyX<StatusEffectApplyXOnCardPlayed>(this.Get<StatusEffectData>("Increase Max Counter"), StatusEffectApplyX.ApplyToFlags.Target).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Boost Effects of Rightmost Card", "Boost the effects of the rightmost card in hand by <{a}>", boostable: true).ApplyX<StatusEffectApplyXOnCardPlayed>(this.Get<StatusEffectData>("Increase Effects"), StatusEffectApplyX.ApplyToFlags.RightCardInHand).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectWhileActiveX>("While Active Allies Have ImmuneToSnow", "While active, allies <keyword=immunetosnow>").ApplyX<StatusEffectWhileActiveX>(this.Get<StatusEffectData>("ImmuneToSnow"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectWhileActiveX>((WildfrostMod) this);
      collection1.SetString("websiteofsites.wildfrost.pokefrost.snowimmuneToAllies", "While active, allies gain <keyword=immunetosnow>");
      this.Get<StatusEffectData>("While Active Snow Immune To Allies").textKey = collection1.GetString("websiteofsites.wildfrost.pokefrost.snowimmuneToAllies");
      this.Get<KeywordData>("immunetosnow").showName = true;
      this.Get<KeywordData>("immunetosnow").show = true;
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Cleanse Targets", "<keyword=cleanse> targets").ApplyX<StatusEffectApplyXOnCardPlayed>(this.Get<StatusEffectData>("Cleanse"), StatusEffectApplyX.ApplyToFlags.Target).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Apply Jolted To Attacker", "When hit, apply <{a}><keyword=jolted> to the attacker").ApplyX<StatusEffectApplyXWhenHit>(this.Get<StatusEffectData>("Jolted"), StatusEffectApplyX.ApplyToFlags.Attacker).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Apply Burning To Attacker", "When hit, apply <{a}><keyword=burning> to the attacker").ApplyX<StatusEffectApplyXWhenHit>(this.Get<StatusEffectData>("Burning"), StatusEffectApplyX.ApplyToFlags.Attacker).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Apply Spicune To All Allies And Enemies", "When hit, apply <{a}><keyword=spicune> to allies and enemies").ApplyX<StatusEffectApplyXWhenHit>(this.Get<StatusEffectData>("Spicune"), StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnRecall>("Gain Spice On Recall", "When recalled gain <{a}><keyword=spice>").ApplyX<StatusEffectApplyXOnRecall>(this.Get<StatusEffectData>("Spice"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnRecall>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnRecall>("Gain Barrage On Recall", "When recalled gain <keyword=barrage>").ApplyX<StatusEffectApplyXOnRecall>(this.Get<StatusEffectData>("Temporary Barrage"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnRecall>((WildfrostMod) this).once = true;
      StatusEffectApplyXOnRecall effectApplyXonRecall = Ext.CreateStatus<StatusEffectApplyXOnRecall>("Trigger On Recall").ApplyX<StatusEffectApplyXOnRecall>(this.Get<StatusEffectData>("Trigger (High Prio)"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnRecall>((WildfrostMod) this);
      effectApplyXonRecall.isReaction = true;
      KeywordData basicKeyword15 = this.CreateBasicKeyword("uturn", "U-turn", "Trigger when recalled");
      basicKeyword15.showName = true;
      Ext.CreateTrait<TraitData>("U-turn", (WildfrostMod) this, basicKeyword15, (StatusEffectData) effectApplyXonRecall).isReaction = true;
      StatusEffectApplyXWhenAllyIsHit applyXwhenAllyIsHit = Ext.CreateStatus<StatusEffectApplyXWhenAllyIsHit>("Trigger Against Attacker When Ally Is Hit").ApplyX<StatusEffectApplyXWhenAllyIsHit>(this.Get<StatusEffectData>("Trigger Against"), StatusEffectApplyX.ApplyToFlags.Attacker).Register<StatusEffectApplyXWhenAllyIsHit>((WildfrostMod) this);
      applyXwhenAllyIsHit.isReaction = true;
      KeywordData basicKeyword16 = this.CreateBasicKeyword("hero", "Hero", "When an ally is hit, counterattack");
      basicKeyword16.showName = true;
      TraitData trait = Ext.CreateTrait<TraitData>("Hero", (WildfrostMod) this, basicKeyword16, (StatusEffectData) applyXwhenAllyIsHit);
      trait.isReaction = true;
      StatusEffectTemporaryTrait effectToApply30 = Ext.CreateStatus<StatusEffectTemporaryTrait>("Temporary Hero").Register<StatusEffectTemporaryTrait>((WildfrostMod) this);
      effectToApply30.trait = trait;
      Ext.CreateStatus<StatusEffectApplyXOnRecall>("Gain Hero On Recall", "When recalled gain <keyword=hero>").ApplyX<StatusEffectApplyXOnRecall>((StatusEffectData) effectToApply30, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnRecall>((WildfrostMod) this).once = true;
      StatusEffectRetreat effectToApply31 = Ext.CreateStatus<StatusEffectRetreat>("Instant Retreat").Register<StatusEffectRetreat>((WildfrostMod) this);
      effectToApply31.eventPriority = -99998;
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayedMaybe>("Maybe Make Front Enemy Retreat", "<{a}>% chance to send the front enemy to the next wave", boostable: true).ApplyX<StatusEffectApplyXOnCardPlayedMaybe>((StatusEffectData) effectToApply31, StatusEffectApplyX.ApplyToFlags.FrontEnemy).Register<StatusEffectApplyXOnCardPlayedMaybe>((WildfrostMod) this);
      StatusEffectInstantReturnToHand effectToApply32 = Ext.CreateStatus<StatusEffectInstantReturnToHand>("Instant Return To Hand").Register<StatusEffectInstantReturnToHand>((WildfrostMod) this);
      Ext.CreateStatus<StatusEffectApplyXOnCardPlayed>("On Card Played Return Front Enemy To Hand", "Return the front enemy to hand").ApplyX<StatusEffectApplyXOnCardPlayed>((StatusEffectData) effectToApply32, StatusEffectApplyX.ApplyToFlags.FrontEnemy).Register<StatusEffectApplyXOnCardPlayed>((WildfrostMod) this);
      StatusEffectPlayCardsInHand effectToApply33 = Ext.CreateStatus<StatusEffectPlayCardsInHand>("Trigger Allies In Hand").Register<StatusEffectPlayCardsInHand>((WildfrostMod) this);
      TargetConstraint targetConstraint = this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1];
      TargetConstraintIsCardType instance68 = ScriptableObject.CreateInstance<TargetConstraintIsCardType>();
      instance68.allowedTypes = new CardType[1]
      {
        this.Get<CardType>("Friendly")
      };
      effectToApply33.applyConstraints = new TargetConstraint[2]
      {
        targetConstraint,
        (TargetConstraint) instance68
      };
      Ext.CreateStatus<StatusEffectApplyXWhenDestroyed>("When Destoryed Give Revive To All Allies", "When destroyed, add <keyword=revive> to all allies").ApplyX<StatusEffectApplyXWhenDestroyed>(this.Get<StatusEffectData>("Revive"), StatusEffectApplyX.ApplyToFlags.Allies).Register<StatusEffectApplyXWhenDestroyed>((WildfrostMod) this).targetMustBeAlive = false;
      Ext.CreateStatus<StatusEffectApplyXOnTurn>("On Turn Trigger Allies In Hand", "Trigger allies in hand").ApplyX<StatusEffectApplyXOnTurn>((StatusEffectData) effectToApply33, StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectApplyXOnTurn>((WildfrostMod) this);
      string str = "<color=#FFCA57>{a}</color>";
      Ext.CreateStatus<StatusEffectWhileRedrawBellChargedX>("While Redraw Bell Is Charged Gain Frenzy", "While the <Redraw Bell> is charged, gain <x{a}><keyword=frenzy>", boostable: true).ApplyX<StatusEffectWhileRedrawBellChargedX>(this.Get<StatusEffectData>("MultiHit"), StatusEffectApplyX.ApplyToFlags.Self).Register<StatusEffectWhileRedrawBellChargedX>((WildfrostMod) this);
      StatusEffectApplyXWhenHit effectApplyXwhenHit5 = Ext.CreateStatus<StatusEffectApplyXWhenHit>("When Hit Apply Equal Burning To The Attacker", "When hit, apply equal <keyword=burning> to the attacker").ApplyX<StatusEffectApplyXWhenHit>((StatusEffectData) effectToApply6, StatusEffectApplyX.ApplyToFlags.Attacker).Register<StatusEffectApplyXWhenHit>((WildfrostMod) this);
      effectApplyXwhenHit5.applyEqualAmount = true;
      effectApplyXwhenHit5.targetMustBeAlive = false;
      StatusEffectEvolveFromKill instance69 = ScriptableObject.CreateInstance<StatusEffectEvolveFromKill>();
      instance69.Autofill("Evolve Magikarp", "<keyword=evolve>: Kill " + str + " bosses or minibosses", (WildfrostMod) this);
      instance69.SetEvolution("websiteofsites.wildfrost.pokefrost.gyarados");
      instance69.SetConstraints(new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrueIfCardTypeIsBossOrMiniboss));
      instance69.Confirm();
      StatusEffectEvolve instance70 = (StatusEffectEvolve) ScriptableObject.CreateInstance<StatusEffectEvolveEevee>();
      instance70.Autofill("Evolve Eevee", "<keyword=evolve>: Equip charm", (WildfrostMod) this);
      instance70.SetEvolution("f");
      instance70.Confirm();
      StatusEffectEvolve instance71 = (StatusEffectEvolve) ScriptableObject.CreateInstance<StatusEffectEvolveExternalFactor>();
      instance71.Autofill("Evolve Meowth", "<keyword=evolve>: Have " + str + "<keyword=blings>", (WildfrostMod) this);
      instance71.SetEvolution("websiteofsites.wildfrost.pokefrost.persian");
      instance71.Confirm();
      StatusEffectEvolveFromKill instance72 = ScriptableObject.CreateInstance<StatusEffectEvolveFromKill>();
      instance72.Autofill("Evolve Lickitung", "<keyword=evolve>: Consume " + str + " cards", (WildfrostMod) this);
      instance72.SetEvolution("websiteofsites.wildfrost.pokefrost.lickilicky");
      instance72.anyKill = true;
      instance72.SetConstraints(new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrueIfCardWasConsumed));
      instance72.Confirm();
      StatusEffectEvolveExternalFactor instance73 = ScriptableObject.CreateInstance<StatusEffectEvolveExternalFactor>();
      instance73.Autofill("Evolve Munchlax", "<keyword=evolve>: Have an empty deck", (WildfrostMod) this);
      instance73.SetEvolution("websiteofsites.wildfrost.pokefrost.snorlax");
      instance73.SetConstraint(new Action<int>(StatusEffectEvolveExternalFactor.ReturnTrueIfEmptyDeck));
      instance73.Confirm();
      StatusEffectEvolveFromStatusApplied instance74 = ScriptableObject.CreateInstance<StatusEffectEvolveFromStatusApplied>();
      instance74.Autofill("Evolve Croagunk", "<keyword=evolve>: Team applies " + str + "<keyword=shroom>", (WildfrostMod) this);
      instance74.SetEvolution("websiteofsites.wildfrost.pokefrost.toxicroak");
      instance74.targetType = "shroom";
      instance74.faction = "ally";
      instance74.Confirm();
      StatusEffectEvolveFromKill instance75 = ScriptableObject.CreateInstance<StatusEffectEvolveFromKill>();
      instance75.Autofill("Evolve Voltorb", "<keyword=evolve>: Kill 3 in a battle", (WildfrostMod) this);
      instance75.SetEvolution("websiteofsites.wildfrost.pokefrost.electrode");
      instance75.SetConstraints(new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrue));
      instance75.persist = false;
      instance75.Confirm();
      StatusEffectEvolveFromHitApplied instance76 = ScriptableObject.CreateInstance<StatusEffectEvolveFromHitApplied>();
      instance76.Autofill("Evolve Carvanha", "<keyword=evolve>: Team deals " + str + "<keyword=teeth> damage", (WildfrostMod) this);
      instance76.SetEvolution("websiteofsites.wildfrost.pokefrost.sharpedo");
      instance76.targetType = "spikes";
      instance76.faction = "ally";
      instance76.Confirm();
      StatusEffectEvolveExternalFactor instance77 = ScriptableObject.CreateInstance<StatusEffectEvolveExternalFactor>();
      instance77.Autofill("Evolve Trubbish", "<keyword=evolve>: Have <4> <card=Junk> on battle end", (WildfrostMod) this);
      instance77.SetEvolution("websiteofsites.wildfrost.pokefrost.garbodor");
      instance77.SetConstraint(new Action<int>(StatusEffectEvolveExternalFactor.ReturnTrueIfEnoughJunk));
      instance77.Confirm();
      StatusEffectEvolveFromKill instance78 = ScriptableObject.CreateInstance<StatusEffectEvolveFromKill>();
      instance78.Autofill("Evolve Litwick", "<keyword=evolve>: Kill " + str + " enemy", (WildfrostMod) this);
      instance78.SetEvolution("websiteofsites.wildfrost.pokefrost.lampent");
      instance78.SetConstraints(new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrue));
      instance78.Confirm();
      StatusEffectEvolveNincada instance79 = ScriptableObject.CreateInstance<StatusEffectEvolveNincada>();
      instance79.Autofill("Evolve Nincada", "<keyword=evolve>: " + str + " battles", (WildfrostMod) this);
      instance79.SetEvolution("websiteofsites.wildfrost.pokefrost.ninjask");
      instance79.Confirm();
      StatusEffectEvolveCrown instance80 = ScriptableObject.CreateInstance<StatusEffectEvolveCrown>();
      instance80.Autofill("Evolve Murkrow", "<keyword=evolve>: Wear <sprite name=crown>", (WildfrostMod) this);
      instance80.SetEvolution("websiteofsites.wildfrost.pokefrost.honchkrow");
      instance80.Confirm();
      StatusEffectEvolveFromStatusApplied instance81 = ScriptableObject.CreateInstance<StatusEffectEvolveFromStatusApplied>();
      instance81.Autofill("Evolve Piplup", "<keyword=evolve>: Team applies " + str + "<keyword=snow>", (WildfrostMod) this);
      instance81.SetEvolution("websiteofsites.wildfrost.pokefrost.prinplup");
      instance81.targetType = "snow";
      instance81.faction = "ally";
      instance81.Confirm();
      StatusEffectEvolveFromStatusApplied instance82 = ScriptableObject.CreateInstance<StatusEffectEvolveFromStatusApplied>();
      instance82.Autofill("Evolve Prinplup", "<keyword=evolve>: Apply " + str + "<keyword=snow> to self", (WildfrostMod) this);
      instance82.SetEvolution("websiteofsites.wildfrost.pokefrost.empoleon");
      instance82.targetType = "snow";
      instance82.faction = "toSelf";
      instance82.Confirm();
      StatusEffectEvolvePlayCards instance83 = ScriptableObject.CreateInstance<StatusEffectEvolvePlayCards>();
      instance83.Autofill("Evolve Duskull", "<keyword=evolve>: Play {0} skulls", (WildfrostMod) this);
      instance83.SetEvolution("websiteofsites.wildfrost.pokefrost.dusclops");
      instance83.SetCardNames("ZapOrb", "SharkTooth", "SnowMaul");
      instance83.SetDispalyedNames("Azul", "Tiger", "Yeti");
      instance83.SetTextTemplate("{0}, {1}, and {2}");
      instance83.Confirm();
      StatusEffectEvolveFromStatusApplied instance84 = ScriptableObject.CreateInstance<StatusEffectEvolveFromStatusApplied>();
      instance84.Autofill("Evolve Lampent", "<keyword=evolve>: Reach " + str + "<keyword=overload>", (WildfrostMod) this);
      instance84.SetEvolution("websiteofsites.wildfrost.pokefrost.chandelure");
      instance84.targetType = "overload";
      instance84.faction = "toSelf";
      instance84.threshold = true;
      instance84.Confirm();
      StatusEffectEvolveFromNode instance85 = ScriptableObject.CreateInstance<StatusEffectEvolveFromNode>();
      instance85.Autofill("Evolve Haunter", "<keyword=evolve>: Witness a <Trade>", (WildfrostMod) this);
      instance85.SetEvolution("websiteofsites.wildfrost.pokefrost.gengar");
      instance85.targetNodeName = "trade";
      instance85.Confirm();
      StatusEffectEvolveFromNode instance86 = ScriptableObject.CreateInstance<StatusEffectEvolveFromNode>();
      instance86.Autofill("Evolve Machoke", "<keyword=evolve>: Witness a <Trade>", (WildfrostMod) this);
      instance86.SetEvolution("websiteofsites.wildfrost.pokefrost.machamp");
      instance86.targetNodeName = "trade";
      instance86.Confirm();
      StatusEffectEvolveSlowpoke instance87 = ScriptableObject.CreateInstance<StatusEffectEvolveSlowpoke>();
      instance87.Autofill("Evolve Slowpoke", "<keyword=evolve>: Visit a <Blingsnail Cave> with or without <sprite name=crown>", (WildfrostMod) this);
      instance87.evolveUncrowned = "slowbro";
      instance87.evolveCrowned = "slowking";
      instance87.targetNodeName = "Blingsnail Cave";
      instance87.Confirm();
      StatusEffectEvolvePlayCards instance88 = ScriptableObject.CreateInstance<StatusEffectEvolvePlayCards>();
      instance88.Autofill("Evolve Seadra", "<keyword=evolve>: Play " + str + " <keyword=combo> cards", (WildfrostMod) this);
      instance88.SetEvolution("websiteofsites.wildfrost.pokefrost.kingdra");
      instance88.SetCardConstraint((Func<Entity, Entity[], bool>) ((entity, entities) => StatusEffectEvolvePlayCards.ReturnTrueIfTrait("Combo", entity)));
      instance88.Confirm();
      StatusEffectEvolveFromHitApplied instance89 = ScriptableObject.CreateInstance<StatusEffectEvolveFromHitApplied>();
      instance89.Autofill("Evolve Makuhita", "<keyword=evolve>: Deal " + str + " damage", (WildfrostMod) this);
      instance89.Autofill2("self", "all");
      instance89.SetEvolution("websiteofsites.wildfrost.pokefrost.hariyama");
      instance89.Confirm();
      StatusEffectEvolveCubone instance90 = ScriptableObject.CreateInstance<StatusEffectEvolveCubone>();
      instance90.Autofill("Evolve Cubone", "<keyword=evolve>: Become injured <i><color=#A6A6A6>(by whom?)</i></color>", (WildfrostMod) this);
      instance90.SetEvolutions("websiteofsites.wildfrost.pokefrost.marowak", "websiteofsites.wildfrost.pokefrost.alolanmarowak");
      instance90.Confirm();
      StatusEffectEvolveKirlia instance91 = ScriptableObject.CreateInstance<StatusEffectEvolveKirlia>();
      instance91.Autofill("Evolve Kirlia", "<keyword=evolve>: Gain " + str + " unique effects", (WildfrostMod) this);
      instance91.SetEvolutions("gardevoir", "gallade");
      instance91.Confirm();
      StatusEffectEvolveFromKill instance92 = ScriptableObject.CreateInstance<StatusEffectEvolveFromKill>();
      instance92.Autofill("Evolve Aron", "<keyword=evolve>: Team <keyword=recycle><color=#FFCA57>s</color> " + str + " cards", (WildfrostMod) this);
      instance92.SetEvolution("lairon");
      instance92.SetConstraints(new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrueIfCardWasRecycled));
      instance92.anyKill = true;
      instance92.Confirm();
      StatusEffectEvolveFromKill instance93 = ScriptableObject.CreateInstance<StatusEffectEvolveFromKill>();
      instance93.Autofill("Evolve Lairon", "<keyword=evolve>: Team <keyword=recycle><color=#FFCA57>s</color> " + str + " <keyword=recycle> card", (WildfrostMod) this);
      instance93.SetEvolution("aggron");
      instance93.SetConstraints(new Func<Entity, DeathType, bool>(StatusEffectEvolveFromKill.ReturnTrueIfRecycleCardWasRecycled));
      instance93.anyKill = true;
      instance93.Confirm();
      StatusEffectEvolveNatu instance94 = ScriptableObject.CreateInstance<StatusEffectEvolveNatu>();
      instance94.Autofill("Evolve Natu", "<keyword=evolve>: Fulfill the <Prophecy>", (WildfrostMod) this);
      instance94.SetEvolution("xatu");
      instance94.Confirm();
      StatusEffectEvolveExternalFactor instance95 = ScriptableObject.CreateInstance<StatusEffectEvolveExternalFactor>();
      instance95.Autofill("Evolve Aipom", "<keyword=evolve>: Have " + str + " <Items> in deck", (WildfrostMod) this);
      instance95.SetEvolution("ambipom");
      instance95.SetConstraint(new Action<int>(StatusEffectEvolveExternalFactor.ReturnTrueIfThickDeck));
      instance95.Confirm();
      StatusEffectEvolveFromStatusApplied instance96 = ScriptableObject.CreateInstance<StatusEffectEvolveFromStatusApplied>();
      instance96.Autofill("Evolve Snover", "<keyword=evolve>: " + str + " units <keyword=snow>'d at once", (WildfrostMod) this);
      instance96.SetEvolution("abomasnow");
      instance96.SetConstraints(new Func<StatusEffectEvolveFromStatusApplied, StatusEffectApply, bool>(StatusEffectEvolveFromStatusApplied.ReturnTrueIfEnoughAffected));
      instance96.targetType = "snow";
      instance96.faction = "all";
      instance96.once = true;
      instance96.Confirm();
      StatusEffectEvolveChingling instance97 = ScriptableObject.CreateInstance<StatusEffectEvolveChingling>();
      instance97.Autofill("Evolve Chingling", "<keyword=evolve>: Collect " + str + " <Sun Bells/Quest Items>", (WildfrostMod) this);
      instance97.SetEvolution("chimecho");
      instance97.Confirm();
      StatusEffectShiny instance98 = ScriptableObject.CreateInstance<StatusEffectShiny>();
      instance98.name = "Shiny";
      instance98.type = "shiny";
      instance98.applyFormat = "";
      instance98.applyFormatKey = new LocalizedString();
      instance98.textKey = new LocalizedString();
      instance98.targetConstraints = new TargetConstraint[0];
      instance98.keyword = "";
      instance98.textOrder = 0;
      instance98.textInsert = "";
      instance98.ModAdded = (WildfrostMod) this;
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) instance98);
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) instance98);
      collection2.SetString(this.Get<StatusEffectData>("Double Negative Effects").name + "_text", "Double the target's negative effects");
      this.Get<StatusEffectData>("Double Negative Effects").textKey = collection2.GetString(this.Get<StatusEffectData>("Double Negative Effects").name + "_text");
      collection2.SetString(this.Get<StatusEffectData>("While Active Increase Effects To Hand").name + "_text", "While active, boost effects of cards in hand by <{a}>");
      this.Get<StatusEffectData>("While Active Increase Effects To Hand").textKey = collection2.GetString(this.Get<StatusEffectData>("While Active Increase Effects To Hand").name + "_text");
      collection2.SetString(this.Get<StatusEffectData>("Redraw Cards").name + "_text", "<Redraw>");
      this.Get<StatusEffectData>("Redraw Cards").textKey = collection2.GetString(this.Get<StatusEffectData>("Redraw Cards").name + "_text");
      StatusEffectApplyX statusEffectApplyX = this.Get<StatusEffectData>("Gain Frenzy When Wild Unit Killed") as StatusEffectApplyX;
      statusEffectApplyX.applyEqualAmount = true;
      statusEffectApplyX.contextEqualAmount = (ScriptableAmount) ScriptableObject.CreateInstance<ScriptableFixedAmount>();

      TargetConstraintHasStatus SCon(string name)
      {
        TargetConstraintHasStatus instance = ScriptableObject.CreateInstance<TargetConstraintHasStatus>();
        instance.status = this.Get<StatusEffectData>(name);
        return instance;
      }
    }

    private void CreateModAssetsCards()
    {
      this.list = new List<CardDataBuilder>(100);
      Debug.Log((object) "[Pokefrost] Loading Cards");
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("alolansandslash", "Alolan Sandslash", bloodProfile: "Blood Profile Snow").SetStats(new int?(6), new int?(5), 4).SetASprites("alolansandslash.png", "alolansandslashBG.png").SAttackEffects(("Snow", 3), ("Block", 1)).AddPool("SnowUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("meowth", "Meowth").SetStats(new int?(4), new int?(3), 3).SetASprites("meowth.png", "meowthBG.png").SStartEffects(("On Kill Apply Gold To Self", 5), ("Evolve Meowth", 300)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("persian", "Persian").SetStats(new int?(7), new int?(0), 4).SetASprites("persian.png", "persianBG.png").STraits(("Greed", 1)).SStartEffects(("While Active Frenzy To Crown Allies", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("machoke", "Machoke").SetStats(new int?(8), new int?(3), 5).SetASprites("machoke.png", "machokeBG.png").SStartEffects(("Increase Attack While Statused", 5), ("Evolve Machoke", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("machamp", "Machamp").SetStats(new int?(8), new int?(3), 5).SetASprites("machamp.png", "machampBG.png").SStartEffects(("Gain Frenzy While Statused", 3)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("slowpoke", "Slowpoke").SetStats(new int?(10), new int?(1), 5).SetASprites("slowpoke.png", "slowpokeBG.png").SStartEffects(("Evolve Slowpoke", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("slowbro", "Slowbro").SetStats(new int?(10), new int?(1), 5).SetASprites("slowbro.png", "slowbroBG.png").SStartEffects(("On Card Played Increase Targets Counter", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("magneton", "Magneton", bloodProfile: "Blood Profile Black", idleAnim: "FloatAnimationProfile").SetStats(new int?(3), new int?(0), 3).SetASprites("magneton.png", "magnetonBG.png").SStartEffects(("On Card Played Apply Shroom Overburn Or Bom", 3)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("farfetchd", "Farfetch'd").SetStats(new int?(4), new int?(6), 3).SetASprites("farfetchd.png", "farfetchdBG.png").STraits(("FalseSwipe", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("muk", "Muk").SetStats(new int?(7), new int?(0), 4).SetASprites("muk.png", "mukBG.png").SStartEffects(("Bonus Damage Equal To Darts In Hand", 1), ("Add Tar Blade Button", 3), ("Tar Shot Listener_1", 1)).AddPool("MagicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("haunter", "Haunter").SetStats(new int?(8), new int?(2), 3).SetASprites("haunter.png", "haunterBG.png").SStartEffects(("On Hit Deal Double Damage To Statused Targets", 1), ("Evolve Haunter", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("gengar", "Gengar").SetStats(new int?(8), new int?(3), 3).SetASprites("gengar.png", "gengarBG.png").SStartEffects(("On Hit Deal Double Damage To Statused Targets", 1)).STraits(("Immaterial", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("voltorb", "Voltorb", bloodProfile: "Blood Profile Black", idleAnim: "PulseAnimationProfile").SetStats(new int?(4), counter: 2).SetASprites("voltorb.png", "voltorbBG.png").SStartEffects(("On Card Played Give Self Explode", 2), ("Evolve Voltorb", 3)).WithValue(50).AddPool("GeneralItemPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("electrode", "Electrode", bloodProfile: "Blood Profile Black", idleAnim: "PulseAnimationProfile").SetStats(new int?(6), counter: 2).SetASprites("electrode.png", "electrodeBG.png").SStartEffects(("On Card Played Give Self Explode", 2), ("When Hit Trigger To Self", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("cubone", "Cubone").SetStats(new int?(4), new int?(2), 4).SetASprites("cubone.png", "cuboneBG.png").SStartEffects(("Evolve Cubone", 1)).AddPool("MagicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("marowak", "Marowak").SetStats(new int?(4), new int?(2), 4).SetASprites("marowak.png", "marowakBG.png").SStartEffects(("Give Thick Club", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("alolanmarowak", "Alolan Marowak", bloodProfile: "Blood Profile Husk").SetStats(new int?(4)).SetASprites("alolanmarowak.png", "alolanmarowakBG.png").SStartEffects(("When Ally Is Sacrificed Trigger To Self", 1), ("Summon Beepop", 1)).STraits(("Spark", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("lickitung", "Lickitung", bloodProfile: "Blood Profile Berry").SetStats(new int?(7), new int?(3), 3).SetASprites("lickitung.png", "lickitungBG.png").STraits(("Longshot", 1), ("Pull", 1)).SStartEffects(("Evolve Lickitung", 5)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("weezing", "Weezing", bloodProfile: "Blood Profile Husk", idleAnim: "FloatAnimationProfile").SetStats(new int?(9), new int?(4), 3).SetASprites("weezing.png", "weezingBG.png").SStartEffects(("Apply Ink to All", 4)).AddPool("ClunkUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("seadra", "Seadra", idleAnim: "FloatAnimationProfile").SetStats(new int?(7), new int?(5), 5).SetASprites("seadra.png", "seadraBG.png").SStartEffects(("Give Combo to Card in Hand", 1), ("Evolve Seadra", 4)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("magikarp", "Magikarp", idleAnim: "ShakeAnimationProfile").SetStats(new int?(1), new int?(0), 4).SetASprites("magikarp.png", "magikarpBG.png").SStartEffects(("Evolve Magikarp", 2)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("gyarados", "Gyarados", idleAnim: "GiantAnimationProfile").SetStats(new int?(8), new int?(4), 4).SetASprites("gyarados.png", "gyaradosBG.png").STraits(("Fury", 4)).SStartEffects(("Hit Your Row", 1), ("MultiHit", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("eevee", "Eevee").SetStats(new int?(4), new int?(3), 3).SetASprites("eevee.png", "eeveeBG.png").IsPet((ChallengeData) null).SStartEffects(("Evolve Eevee", 1)).WithFlavour("Despite the limitless possibilities, Eevee is already perfect"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("vaporeon", "Vaporeon", bloodProfile: "Blood Profile Blue (x2)").SetStats(new int?(4), new int?(3), 3).SetASprites("vaporeon.png", "vaporeonBG.png").SStartEffects(("Block", 1)).SAttackEffects(("Null", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("jolteon", "Jolteon").SetStats(new int?(4), new int?(3), 3).SetASprites("jolteon.png", "jolteonBG.png").SAttackEffects(("Jolted", 1)).STraits(("Draw", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("flareon", "Flareon").SetStats(new int?(4), new int?(2), 3).SetASprites("flareon.png", "flareonBG.png").SStartEffects(("While Active Increase Attack To Allies", 2)).SAttackEffects(("Burning", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("snorlax", "Snorlax", idleAnim: "SquishAnimationProfile").SetStats(new int?(10), new int?(6), 5).SetASprites("snorlax.png", "snorlaxBG.png").SStartEffects(("While Active Consume To Items In Hand", 1), ("Rest Button", 1), ("Rest Listener_1", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("furret", "Furret").SetStats(new int?(15), new int?(2), 5).SetASprites("furret.png", "furretBG.png").SStartEffects(("On Turn Escape To Self", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("natu", "Natu").SetStats(new int?(8), new int?(3), 4).SetASprites("natu.png", "natuBG.png").SStartEffects(("When Deployed Summon Placeholder To Hand", 1), ("Evolve Natu", 1)).FreeModify((Action<CardData>) (c => c.createScripts = new CardScript[1]
      {
        (CardScript) ScriptableObject.CreateInstance<CardScriptForsee>()
      })).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("xatu", "Xatu").SetStats(new int?(8), new int?(3), 4).SetASprites("xatu.png", "xatuBG.png").SStartEffects(("On Turn Return Prophesized Card To Hand", 1), ("When Prophesized Card Played Give Allies Attack", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("aipom", "Aipom").SetStats(new int?(6), new int?(3), 3).SetASprites("aipom.png", "aipomBG.png").SStartEffects(("On Kill Boost Effects", 1), ("Evolve Aipom", 20)).STraits(("Pickup", 2)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("espeon", "Espeon").SetStats(new int?(4), new int?(3), 3).SetASprites("espeon.png", "espeonBG.png").SStartEffects(("On Card Played Boost Effects of Rightmost Card", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("umbreon", "Umbreon").SetStats(new int?(8), new int?(1), 3).SetASprites("umbreon.png", "umbreonBG.png").SStartEffects(("Teeth", 2)).SAttackEffects(("Demonize", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("murkrow", "Murkrow").SetStats(new int?(7), new int?(4), 4).SetASprites("murkrow.png", "murkrowBG.png").SStartEffects(("Evolve Murkrow", 1)).STraits(("Pluck", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("slowking", "Slowking").SetStats(new int?(10), counter: 5).SetASprites("slowking.png", "slowkingBG.png").SStartEffects(("On Card Played Trigger All Slowking Crowns", 1), ("Give Slowking Crown", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("sneasel", "Sneasel", idleAnim: "PingAnimationProfile").SetStats(new int?(6), new int?(0), 2).SetASprites("sneasel.png", "sneaselBG.png").SStartEffects(("Increase Attack Based on Cards Drawn", 1), ("When Hit Draw", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("hisuiansneasel", "Hisuian Sneasel", idleAnim: "PingAnimationProfile").SetStats(new int?(6), new int?(0), 3).SetASprites("hisuiansneasel.png", "hisuiansneaselBG.png").SStartEffects(("Deal Bonus Damage Equal To Cards In Hand", 1), ("When Hit Draw", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("magcargo", "Magcargo", idleAnim: "GoopAnimationProfile").SetStats(new int?(15), new int?(0), 6).SetASprites("magcargo.png", "magcargoBG.png").SStartEffects(("When Hit Apply Spice To Allies & Enemies & Self", 1), ("Convert Spice To Burning To Front Enemy", 1)).AddPool("BasicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("kingdra", "Kingdra").SetStats(new int?(9), new int?(3), 5).SetASprites("kingdra.png", "kingdraBG.png").SStartEffects(("Give Combo to Card in Hand", 1), ("Discard Rightmost Button", 1), ("MultiHit", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("smeargle", "Smeargle").SetStats(new int?(1), new int?(1), 4).SetASprites("smeargle.png", "smeargleBG.png").SStartEffects(("When Deployed Sketch", 4)).STraits(("Pigheaded", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("raikou", "Raikou").SetStats(new int?(9), new int?(3), 3).SetASprites("raikou.png", "raikouBG.png").SAttackEffects(("Jolted", 3)).SStartEffects(("When Anyone Takes Jolted Damage Apply Equal Jolted To A Random Enemy", 1)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("entei", "Entei").SetStats(new int?(5), new int?(1), 4).SetASprites("entei.png", "enteiBG.png").SAttackEffects(("Burning", 3)).SStartEffects(("Hits All NonBurning Targets", 1)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("suicune", "Suicune").SetStats(new int?(7), new int?(1), 5).SetASprites("suicune.png", "suicuneBG.png").SStartEffects(("Gain Juice On Hit", 1), ("Give Your Juice To All", 1)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("hooh", "Ho-Oh").WithCardType("Leader").SetStats(new int?(8), new int?(3), 3).SetASprites("hooh.png", "hoohBG.png").WithText("<keyword=legendary>").SStartEffects(("On Card Played Summon From Reserve", 1)).FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("ludicolo", "Ludicolo").SetStats(new int?(10), new int?(4)).SetASprites("ludicolo.png", "ludicoloBG.png").SStartEffects(("Trigger All Button", 1), ("Trigger All Listener_1", 1), ("On Turn Heal Allies", 2)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("kirlia", "Kirlia").SetStats(new int?(4), new int?(2), 4).SetASprites("kirlia.png", "kirliaBG.png").STraits(("Synchronize", 1)).SStartEffects(("Evolve Kirlia", 8)).AddPool("BasicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("gardevoir", "Gardevoir").SetStats(new int?(4), new int?(2), 4).SetASprites("gardevoir.png", "gardevoirBG.png").STraits(("Synchronize2", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("nincada", "Nincada", bloodProfile: "Blood Profile Fungus", idleAnim: "PingAnimationProfile").SetStats(new int?(6), new int?(2), 4).SetASprites("nincada.png", "nincadaBG.png").SStartEffects(("Evolve Nincada", 2)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("ninjask", "Ninjask", bloodProfile: "Blood Profile Fungus", idleAnim: "FlyAnimationProfile").SetStats(new int?(6), new int?(2), 4).SetASprites("ninjask.png", "ninjaskBG.png").SStartEffects(("On Card Played Reduce Own Max Counter", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("shedinja", "Shedinja", bloodProfile: "Blood Profile Husk", idleAnim: "FloatAnimationProfile").WithCardType("Summoned").SetStats(new int?(1), new int?(2), 4).SetASprites("shedinja.png", "shedinjaBG.png").SStartEffects(("Wonder Guard", 1), ("ImmuneToSnow", 1)).STraits(("Fragile", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("makuhita", "Makuhita").SetStats(new int?(6), new int?(0), 4).SetASprites("makuhita.png", "makuhitaBG.png").SStartEffects(("Damage Equal To Missing Health", 1), ("Evolve Makuhita", 60)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("hariyama", "Hariyama", idleAnim: "GiantAnimationProfile").SetStats(new int?(12), new int?(0), 4).SetASprites("hariyama.png", "hariyamaBG.png").SStartEffects(("Damage Equal To Missing Health", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("nosepass", "Nosepass", bloodProfile: "Blood Profile Husk").SetStats(new int?(8), new int?(4), 4).SetASprites("nosepass.png", "nosepassBG.png").WithFlavour("My magnetic field attracts tons of charms from the reserve").AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("sableye", "Sableye", bloodProfile: "Blood Profile Pink Wisp").SetStats(new int?(10), new int?(0), 2).SetASprites("sableye.png", "sableyeBG.png").SStartEffects(("Drop Bling on Hit", 4)).STraits(("Greed", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("aron", "Aron").SetStats(new int?(4), new int?(6), 4).SetASprites("aron.png", "aronBG.png").STraits(("Recycle", 1)).SStartEffects(("Evolve Aron", 8), ("Fidget Button", 1)).AddPool("ClunkUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("lairon", "Lairon").SetStats(new int?(6), new int?(6), 4).SetASprites("lairon.png", "laironBG.png").STraits(("Recycle", 1)).SStartEffects(("While Active All Cards Are Recyclable", 1), ("Evolve Lairon", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("aggron", "Aggron").SetStats(new int?(8), new int?(6), 4).SetASprites("aggron.png", "aggronBG.png").STraits(("Recycle", 1)).SStartEffects(("While Active All Cards Are Recyclable", 1), ("Autotomize Button", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("carvanha", "Carvanha", idleAnim: "FloatAnimationProfile").SetStats(new int?(6), new int?(3), 4).SetASprites("carvanha.png", "carvanhaBG.png").SStartEffects(("Teeth", 3), ("Evolve Carvanha", 30)).AddPool("MagicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("sharpedo", "Sharpedo", idleAnim: "FloatAnimationProfile").SetStats(new int?(7), new int?(3), 4).SetASprites("sharpedo.png", "sharpedoBG.png").SStartEffects(("Teeth", 3), ("Trigger When Teeth Damage", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("spinda", "Spinda", idleAnim: "Heartbeat2AnimationProfile").SetStats(new int?(5), new int?(4), 4).SetASprites("spinda.png", "spindaBG.png").SStartEffects(("Apply Haze to All", 1), ("Haze", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("cradily", "Cradily", bloodProfile: "Blood Profile Fungus", idleAnim: "GoopAnimationProfile").SetStats(new int?(12), counter: 5).SetASprites("cradily.png", "cradilyBG.png").SStartEffects(("Heal Self", 4)).STraits(("Frontline", 1), ("Pigheaded", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("duskull", "Duskull", bloodProfile: "Blood Profile Black", idleAnim: "FloatAnimationProfile").SetStats(new int?(8)).SetASprites("duskull.png", "duskullBG.png").SStartEffects(("When Ally Summoned Add Skull To Hand", 1), ("Evolve Duskull", 7)).STraits(("Spook", 1)).AddPool("MagicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("dusclops", "Dusclops", bloodProfile: "Blood Profile Black").SetStats(new int?(10), new int?(4)).SetASprites("dusclops.png", "dusclopsBG.png").SStartEffects(("When Ally Summoned Add Skull To Hand", 1)).STraits(("Spook", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("chimecho", "Chimecho").SetStats(new int?(6), new int?(3)).SetASprites("chimecho.png", "chimechoBG.png").SStartEffects(("On Turn Trigger Allies In Hand", 1), ("Trigger When Redraw Hit", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("absol", "Absol").SetStats(new int?(5), new int?(5), 2).SetASprites("absol.png", "absolBG.png").SStartEffects(("On Card Apply Demonize To RandomAlly", 1)).WithFlavour("Once mistaken to be the bringer of Wildfrost").AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("spheal", "Spheal", idleAnim: "PingAnimationProfile").SetStats(new int?(4), new int?(1), 3).SetASprites("spheal.png", "sphealBG.png").SStartEffects(("On Hit Snowed Target Double Attack Otherwise Half", 1)).AddPool("BasicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("latias", "Latias").SetStats(new int?(6), new int?(2), 3).SetASprites("latias.png", "latiasBG.png").SStartEffects(("When Hit Transfer Resist to Random Ally", 1), ("Temp Resist", 1)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("latios", "Latios").SetStats(new int?(5), new int?(3), 3).SetASprites("latios.png", "latiosBG.png").SStartEffects(("On Card Played Transfer Attack to Random Ally", 5), ("Ongoing Increase Attack", 5)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("piplup", "Piplup", bloodProfile: "Blood Profile Snow").SetStats(new int?(6), new int?(2), 3).SetASprites("piplup.png", "piplupBG.png").SStartEffects(("When Snow Applied To Self Gain Equal Attack", 1), ("Evolve Piplup", 10)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("prinplup", "Prinplup", bloodProfile: "Blood Profile Snow").SetStats(new int?(7), new int?(2), 3).SetASprites("prinplup.png", "prinplupBG.png").SStartEffects(("Snow Acts Like Shell", 1), ("When Snow Applied To Self Gain Equal Attack", 1), ("Evolve Prinplup", 11)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("empoleon", "Empoleon", bloodProfile: "Blood Profile Snow").SetStats(new int?(8), new int?(2), 3).SetASprites("empoleon.png", "empoleonBG.png").SStartEffects(("Snow Acts Like Shell", 1), ("When Snow Applied To Self Gain Equal Attack", 1), ("When Snowed Snow Random Enemy", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("bastiodon", "Bastiodon", idleAnim: "SquishAnimationProfile").SetStats(new int?(10), new int?(4), 6).SetASprites("bastiodon.png", "bastiodonBG.png").STraits(("Taunt", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("ambipom", "Ambipom").SetStats(new int?(6), new int?(2), 3).SetASprites("ambipom.png", "ambipomBG.png").SStartEffects(("When Unit Is Killed Boost Effects", 1), ("MultiHit", 1)).STraits(("Pickup", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("honchkrow", "Honchkrow", idleAnim: "SquishAnimationProfile").SetStats(new int?(7), new int?(4), 4).SetASprites("honchkrow.png", "honchkrowBG.png").STraits(("Pluck", 1)).SStartEffects(("Buff Card In Deck On Kill", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("chingling", "Chingling", idleAnim: "HangAnimationProfile").SetStats(new int?(6), new int?(3)).SetASprites("chingling.png", "chinglingBG.png").SStartEffects(("Trigger When Redraw Hit", 1), ("Evolve Chingling", 4)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("hippowdon", "Hippowdon", idleAnim: "SquishAnimationProfile").SetStats(new int?(12), new int?(3), 5).SetASprites("hippowdon.png", "hippowdonBG.png").SStartEffects(("Pre Turn Weakness All Enemies", 1), ("While Active Sandstorm", 1)).AddPool("ClunkUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("munchlax", "Munchlax").SetStats(new int?(7), new int?(3), 5).SetASprites("munchlax.png", "munchlaxBG.png").SStartEffects(("While Active Consume To Items In Hand", 1), ("Evolve Munchlax", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("croagunk", "Croagunk", bloodProfile: "Blood Profile Fungus").SetStats(new int?(6), new int?(2), 5).SetASprites("croagunk.png", "croagunkBG.png").SStartEffects(("On Hit Equal Shroom To Target", 1), ("Evolve Croagunk", 50)).AddPool("BasicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("toxicroak", "Toxicroak", bloodProfile: "Blood Profile Fungus").SetStats(new int?(6), new int?(2), 4).SetASprites("toxicroak.png", "toxicroakBG.png").SStartEffects(("On Hit Equal Shroom To Target", 1)).STraits(("Fury", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("lumineon", "Lumineon").SetStats(new int?(8), counter: 3).SetASprites("lumineon.png", "lumineonBG.png").SStartEffects(("While Active Unlimited Lumin", 1)).STraits(("Salvage", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("snover", "Snover").SetStats(new int?(8), new int?(4), 4).SetASprites("snover.png", "snoverBG.png").SStartEffects(("While Active Snowstorm", 1), ("While Active All Hits Apply Snow", 1), ("ImmuneToSnow", 1), ("Evolve Snover", 4)).AddPool("SnowUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("abomasnow", "Abomasnow").SetStats(new int?(10), new int?(4), 4).SetASprites("abomasnow.png", "abomasnowBG.png").SStartEffects(("While Active Snowstorm", 1), ("While Active All Hits Apply Snow", 1), ("ImmuneToSnow", 1), ("While Active Snow Immune To Allies", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("lickilicky", "Lickilicky", bloodProfile: "Blood Profile Berry", idleAnim: "SquishAnimationProfile").SetStats(new int?(8), new int?(3), 3).SetASprites("lickilicky.png", "lickilickyBG.png").STraits(("Barrage", 1), ("Pull", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("leafeon", "Leafeon", bloodProfile: "Blood Profile Fungus").SetStats(new int?(4), new int?(1), 3).SetASprites("leafeon.png", "leafeonBG.png").SStartEffects(("On Turn Apply Shell To AllyInFrontOf", 2)).SAttackEffects(("Shroom", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("glaceon", "Glaceon", bloodProfile: "Blood Profile Snow").SetStats(new int?(4), new int?(3), 3).SetASprites("glaceon.png", "glaceonBG.png").SAttackEffects(("Snow", 1), ("Frost", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("gallade", "Gallade").SetStats(new int?(5), new int?(3), 4).SetASprites("gallade.png", "galladeBG.png").SStartEffects(("MultiHit", 1)).STraits(("Synchronize", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("froslass", "Froslass", bloodProfile: "Blood Profile Pink Wisp", idleAnim: "FloatAnimationProfile").SetStats(new int?(4), new int?(1), 4).SetASprites("froslass.png", "froslassBG.png").SAttackEffects(("Frost", 1), ("Double Negative Effects", 1)).STraits(("Aimless", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("rotom", "Rotom", bloodProfile: "Blood Profile Blue (x2)", idleAnim: "Heartbeat2AnimationProfile").SetStats(new int?(8), new int?(3), 4).SetASprites("rotom.png", "rotomBG.png").SStartEffects(("Trigger Clunker Ahead", 1), ("Jolted", 1)).IsPet((ChallengeData) null));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("rotomheat", "Rotom Heat", bloodProfile: "Blood Profile Black").SetStats(new int?(8), new int?(5), 4).SetASprites("rotomheat.png", "rotomBG.png").SStartEffects(("On Card Played Increase Attack Of Cards In Hand", 3), ("Jolted", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("rotomwash", "Rotom Wash", bloodProfile: "Blood Profile Black").SetStats(new int?(10), new int?(4), 4).SetASprites("rotomwash.png", "rotomBG.png").SStartEffects(("When Hit Cleanse Team", 1), ("Jolted", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("rotomfrost", "Rotom Frost", bloodProfile: "Blood Profile Black").SetStats(new int?(12), new int?(3), 4).SetASprites("rotomfrost.png", "rotomBG.png").SStartEffects(("When Hit Apply Frost To RandomEnemy", 3), ("Jolted", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("rotomfan", "Rotom Fan", bloodProfile: "Blood Profile Black").SetStats(new int?(9), new int?(4), 4).SetASprites("rotomfan.png", "rotomBG.png").SStartEffects(("Redraw Cards", 1), ("Jolted", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("rotommow", "Rotom Mow", bloodProfile: "Blood Profile Black", idleAnim: "ShakeAnimationProfile").SetStats(new int?(9), new int?(3)).SetASprites("rotommow.png", "rotomBG.png").SStartEffects(("Trigger When Card Destroyed", 1), ("Jolted", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("cresselia", "Cresselia").SetStats(new int?(2), new int?(2), 4).SetASprites("cresselia.png", "cresseliaBG.png").SStartEffects(("When Card Destroyed, Gain Dream Card", 1)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("darkrai", "Darkrai").SetStats(new int?(8), new int?(4), 2).SetASprites("darkrai.png", "darkraiBG.png").SStartEffects(("On Card Played Give Random Card In Hand While In Hand Increase Attack To Enemies", 1), ("Frenzy Equal To Curses In Hand", 1)).WithCardType("Leader").WithText("<keyword=legendary>").FreeModify((Action<CardData>) (data => data.createScripts = new CardScript[1]
      {
        LeaderScripts.GiveUpgrade()
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("musharna", "Musharna", idleAnim: "FloatAnimationProfile").SetStats(new int?(7), new int?(3)).SetASprites("musharna.png", "musharnaBG.png").SStartEffects(("Trigger When Dream Card Played", 1), ("When Deployed Or Redraw, Gain Dream Card To Hand", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("whimsicott", "Whimsicott", idleAnim: "FloatAnimationProfile").SetStats(new int?(5), new int?(3), 4).SetASprites("whimsicott.png", "whimsicottBG.png").SStartEffects(("Maybe Make Front Enemy Retreat", 50)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("crustle", "Crustle", bloodProfile: "Blood Profile Husk", idleAnim: "GiantAnimationProfile").SetStats(new int?(8), new int?(3), 4).SetASprites("crustle.png", "crustleBG.png").SStartEffects(("When Hit Add Scrap Pile To Hand", 1)).AddPool("ClunkUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("trubbish", "Trubbish", bloodProfile: "Blood Profile Husk", idleAnim: "SquishAnimationProfile").SetStats(new int?(6), new int?(3), 4).SetASprites("trubbish.png", "trubbishBG.png").SStartEffects(("When Clunker Destroyed Add Junk To Hand", 1), ("Evolve Trubbish", 4)).AddPool("ClunkUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("garbodor", "Garbodor", bloodProfile: "Blood Profile Husk", idleAnim: "GiantAnimationProfile").SetStats(new int?(6), new int?(3), 4).SetASprites("garbodor.png", "garbodorBG.png").SStartEffects(("When Clunker Destroyed Gain Scrap", 1), ("Frenzy Equal To Scrap", 1), ("Scrap", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("litwick", "Litwick", bloodProfile: "Blood Profile Black", idleAnim: "SquishAnimationProfile").SetStats(new int?(3), new int?(0), 2).SetASprites("litwick.png", "litwickBG.png").SAttackEffects(("Overload", 1)).SStartEffects(("Evolve Litwick", 2)).AddPool("MagicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("lampent", "Lampent", bloodProfile: "Blood Profile Black", idleAnim: "HangAnimationProfile").SetStats(new int?(10), new int?(0), 4).SetASprites("lampent.png", "lampentBG.png").SStartEffects(("Overload Self", 3), ("Apply Overload Equal To Overload", 1), ("Evolve Lampent", 9)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("chandelure", "Chandelure", bloodProfile: "Blood Profile Black", idleAnim: "HangAnimationProfile").SetStats(new int?(10), new int?(0), 4).SetASprites("chandelure.png", "chandelureBG.png").STraits(("Barrage", 1)).SStartEffects(("Overload Self", 3), ("Apply Overload Equal To Overload", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("volcarona", "Volcarona", idleAnim: "FlyAnimationProfile").SetStats(new int?(6), new int?(4), 4).SetASprites("volcarona.png", "volcaronaBG.png").SStartEffects(("On Card Played Reduce Counter Row", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("espurr", "Espurr", idleAnim: "PulseAnimationProfile").SetStats(new int?(2)).SetASprites("espurr.png", "espurrBG.png").SStartEffects(("End of Turn Draw a Card", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("tyrantrum", "Tyrantrum", idleAnim: "GiantAnimationProfile").SetStats(new int?(7), new int?(4), 4).SetASprites("tyrantrum.png", "tyrantrumBG.png").SAttackEffects(("Apply Wild Trait", 1)).SStartEffects(("MultiHit", 1)).STraits(("Aimless", 1), ("Wild", 1)).WithFlavour("Seems to have been frozen long before the storm").AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("sylveon", "Sylveon", bloodProfile: "Blood Profile Berry").SetStats(new int?(4), new int?(3), 3).SetASprites("sylveon.png", "sylveonBG.png").SStartEffects(("On Turn Heal & Cleanse Allies", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("goomy", "Goomy", bloodProfile: "Blood Profile Blue (x2)", idleAnim: "SquishAnimationProfile").SetStats(new int?(13), new int?(1), 3).SetASprites("goomy.png", "goomyBG.png").SStartEffects(("When X Health Lost Split", 3)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("klefki", "Klefki", bloodProfile: "Blood Profile Husk", idleAnim: "ShakeAnimationProfile").SetStats(new int?(6), new int?(2), 2).SetASprites("klefki.png", "klefkiBG.png").WithFlavour("I can hold all of your charms for safe keeping ;)").AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("salazzle", "Salazzle").SetStats(new int?(7), new int?(1), 3).SetASprites("salazzle.png", "salazzleBG.png").SStartEffects(("While Active It Is Overshroom", 1)).AddPool("BasicUnitPool").AddPool("MagicUnitPool"));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("polteageist", "Polteageist", bloodProfile: "Blood Profile Husk", idleAnim: "FloatAnimationProfile").SetStats(new int?(7), counter: 4).SetASprites("polteageist.png", "polteageistBG.png").SStartEffects(("On Card Played Blaze Tea Random Ally", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("palafin", "Palafin").SetStats(new int?(6), new int?(3), 5).SetASprites("palafin.png", "palafinBG.png").SStartEffects(("Gain Hero On Recall", 1), ("MultiHit", 1)).AddPool().SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        GameObject target = this.Get<CardData>("Bolgo").scriptableImagePrefab.gameObject.InstantiateKeepName<GameObject>();
        Image image = target.GetComponent<Bolgo>().image;
        target.GetComponent<Bolgo>().Destroy();
        UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) target);
        PalafinHero palafinHero = target.AddComponent<PalafinHero>();
        palafinHero.image = image;
        data.scriptableImagePrefab = (ScriptableCardImage) palafinHero;
      })));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("kingambit", "Kingambit", idleAnim: "GiantAnimationProfile").SetStats(new int?(10), new int?(5), 5).SetASprites("kingambit.png", "kingambitBG.png").SStartEffects(("Gain Frenzy When Companion Is Killed", 1)).AddPool());
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateItem("shedinjamask", "Shedinja Mask", idleAnim: "FloatAnimationProfile").SetASprites("shedinja_mask.png", "shedinja_maskBG.png").CanPlayOnBoard().CanPlayOnEnemy(false).FreeModify((Action<CardData>) (c => c.playOnSlot = true)).STraits(("Consume", 1)).SStartEffects(("Summon Shedinja", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateItem("microwave", "Microwave").SetASprites("microwave.png", "rotomBG.png").WithFlavour("Appears to be a safe without a lock. What use is that?").CanPlayOnFriendly(false).CanPlayOnEnemy(false).NeedsTarget(false).WithPlayType(Card.PlayType.None));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateItem("washingmachine", "Washing Machine").SetASprites("washingmachine.png", "rotomBG.png").WithFlavour("A device that spins and makes loud noises. What use is that?").CanPlayOnFriendly(false).CanPlayOnEnemy(false).NeedsTarget(false).CanPlayOnBoard(false).WithPlayType(Card.PlayType.None));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateItem("fridge", "Fridge").SetASprites("fridge.png", "rotomBG.png").WithFlavour("This strange device seems to... keep things cold? What use is that?").CanPlayOnFriendly(false).CanPlayOnEnemy(false).NeedsTarget(false).CanPlayOnBoard(false).WithPlayType(Card.PlayType.None));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateItem("fan", "Fan").SetASprites("fan.png", "rotomBG.png").WithFlavour("A strange saw sealed by an even stranger cage. What use is that?").CanPlayOnFriendly(false).CanPlayOnEnemy(false).NeedsTarget(false).CanPlayOnBoard(false).WithPlayType(Card.PlayType.None));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateItem("lawnmower", "Lawnmower").SetASprites("lawnmower.png", "rotomBG.png").WithFlavour("Seems to be some sort of vehicle, but lacks seating. What use is that?").CanPlayOnFriendly(false).CanPlayOnEnemy(false).NeedsTarget(false).CanPlayOnBoard(false).WithPlayType(Card.PlayType.None));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_hypno", "Hypno").SetStats(new int?(20), new int?(3), 4).SetASprites("hypno.png", "hypnoBG.png").SStartEffects(("On Card Played Give Random Card In Hand While In Hand Unmovable To Allies", 1)).WithCardType("Enemy").WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_vaporeon", "Vaporeon", bloodProfile: "Blood Profile Blue (x2)").SetStats(new int?(8), new int?(3), 3).WithCardType("Enemy").WithValue(50).SetASprites("vaporeon.png", "vaporeonBG.png").SStartEffects(("Block", 1)).SAttackEffects(("Null", 4)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_jolteon", "Jolteon").SetStats(new int?(8), new int?(1), 3).WithCardType("Enemy").WithValue(50).SetASprites("jolteon.png", "jolteonBG.png").SStartEffects(("MultiHit", 1)).SAttackEffects(("Jolted", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_flareon", "Flareon").SetStats(new int?(8), new int?(2), 3).WithCardType("Enemy").WithValue(50).SetASprites("flareon.png", "flareonBG.png").SStartEffects(("While Active Increase Attack To Allies", 2)).SAttackEffects(("Burning", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_espeon", "Espeon").SetStats(new int?(10), new int?(0), 3).WithCardType("Enemy").WithValue(50).SetASprites("espeon.png", "espeonBG.png").SStartEffects(("Give Allies Juice", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_umbreon", "Umbreon").SetStats(new int?(10), new int?(0), 3).WithCardType("Enemy").WithValue(50).SetASprites("umbreon.png", "umbreonBG.png").SStartEffects(("Teeth", 2)).SAttackEffects(("Demonize", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_raikou", "Raikou").SetStats(new int?(30), new int?(3), 4).SetASprites("raikou.png", "raikouBG.png").WithCardType("Miniboss").SAttackEffects(("Jolted", 2)).SStartEffects(("When Anyone Takes Jolted Damage Apply Equal Jolted To Front Enemy", 1), ("ImmuneToSnow", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("quest_raikou", "Raikou").WithCardType("Enemy").SetStats(new int?(6), counter: 6).SetASprites("raikou.png", "raikouBG.png").SStartEffects(("When Hit Apply Jolted To Attacker", 1), ("On Turn Escape To Self", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_entei", "Entei").SetStats(new int?(25), new int?(0), 4).SetASprites("entei.png", "enteiBG.png").WithCardType("Miniboss").SAttackEffects(("Burning", 5)).SStartEffects(("ImmuneToSnow", 1)).STraits(("Barrage", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("quest_entei", "Entei").WithCardType("Enemy").SetStats(new int?(8), new int?(5), 8).SetASprites("entei.png", "raikouBG.png").SStartEffects(("When Hit Apply Burning To Attacker", 3), ("On Turn Escape To Self", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_suicune", "Suicune").SetStats(new int?(35), new int?(2), 4).SetASprites("suicune.png", "suicuneBG.png").WithCardType("Miniboss").SStartEffects(("Gain Juice On Hit", 1), ("Give Your Juice To Allies", 1), ("ImmuneToSnow", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("quest_suicune", "Suicune").WithCardType("Enemy").SetStats(new int?(10), counter: 7).SetASprites("suicune.png", "suicuneBG.png").SStartEffects(("When Hit Apply Spicune To All Allies And Enemies", 1), ("On Turn Escape To Self", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_hooh", "Ho-Oh").SetStats(new int?(100), new int?(5), 6).SetASprites("hooh.png", "hoohBG.png").WithCardType("Boss").SStartEffects(("Give Revive To Allies", 1), ("Revive", 1), ("ImmuneToSnow", 1), ("On Card Played Cleanse Targets", 1)).STraits(("Backline", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_beautifly", "Beautifly").SetStats(new int?(6), new int?(1), 2).SetASprites("beautifly.png", "beautiflyBG.png").WithCardType("Enemy").SStartEffects(("When Destroyed Apply Bom To All Enemies In Row", 1)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_dustox", "Dustox").SetStats(new int?(6), new int?(2), 2).SetASprites("dustox.png", "dustoxBG.png").WithCardType("Enemy").SStartEffects(("When Destroyed Apply Shroom To All Enemies In Row", 3)).WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_plusle", "Plusle").SetStats(new int?(14), new int?(3), 5).SetASprites("plusle.png", "plusleBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("While Active Increase Attack To Allies", 1), ("When Destroyed Boost Allies", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_minun", "Minun").SetStats(new int?(14), new int?(3), 5).SetASprites("minun.png", "minunBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("While Active Reduce Attack To Enemies", 1), ("When Destroyed Boost Allies", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_volbeat", "Volbeat").SetStats(new int?(10), new int?(1), 3).SetASprites("volbeat.png", "volbeatBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("On Turn Apply Attack To Self", 4)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_illumise", "Illumise").SetStats(new int?(10), new int?(1), 3).SetASprites("illumise.png", "illumiseBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("Heal Self", 4)).STraits(("Heartburn", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_lunatone", "Lunatone").SetStats(new int?(16), counter: 4).SetASprites("lunatone.png", "lunatoneBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("On Turn Apply Snow To Enemies", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_solrock", "Solrock").SetStats(new int?(16), counter: 4).SetASprites("solrock.png", "solrockBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("On Card Played Reduce Counter To Allies", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_huntail", "Huntail").SetStats(new int?(10), new int?(2)).SetASprites("huntail.png", "huntailBG.png").WithCardType("Enemy").WithValue(50).SStartEffects(("Trigger Against When Ally Attacks", 1)).STraits(("Resist", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_gorebyss", "Gorebyss").SetStats(new int?(14), new int?(0), 5).SetASprites("gorebyss.png", "gorebyssBG.png").WithCardType("Enemy").WithValue(50).SAttackEffects(("Frost", 2)).SStartEffects(("Hit All Enemies", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_latias", "Latias").SetStats(new int?(35), new int?(2), 5).SetASprites("latias.png", "latiasBG.png").WithCardType("Miniboss").WithValue(50).SStartEffects(("When Hit Transfer Resist to Allies to Random Ally", 3), ("While Active Allies Have Resist (No Desc)", 3), ("ImmuneToSnow", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_latios", "Latios").SetStats(new int?(30), new int?(5), 4).SetASprites("latios.png", "latiosBG.png").WithCardType("Miniboss").WithValue(50).SStartEffects(("When Hit Transfer MultiHit to Random Ally", 1), ("MultiHit", 1), ("ImmuneToSnow", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_mismagius", "Mismagius").SetStats(new int?(8), new int?(0), 2).SetASprites("mismagius.png", "mismagiusBG.png").SStartEffects(("On Card Played Give Random Card In Hand While In Hand Increase Attack To Enemies", 1)).WithCardType("Enemy").WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_spiritomb", "Spiritomb").SetStats(new int?(12), new int?(0)).SetASprites("spiritomb.png", "spiritombBG.png").SStartEffects(("On Card Played Give Random Card In Hand While In Hand Reduce Attack To Allies", 1), ("On Turn Apply Attack To Self", 1)).STraits(("Smackback", 1)).WithCardType("Enemy").WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_magmortar", "Magmortar").SetStats(new int?(10), new int?(7), 5).SetASprites("magmortar.png", "magmortarBG.png").STraits(("Longshot", 1), ("Explode", 2)).SStartEffects(("ImmuneToSnow", 1)).WithCardType("Enemy").WithValue(50));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_leafeon", "Leafeon", bloodProfile: "Blood Profile Fungus").SetStats(new int?(10), new int?(1), 3).WithCardType("Enemy").WithValue(50).SetASprites("leafeon.png", "leafeonBG.png").SStartEffects(("On Turn Apply Shell To AllyInFrontOf", 4)).SAttackEffects(("Shroom", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_glaceon", "Glaceon", bloodProfile: "Blood Profile Snow").SetStats(new int?(10), new int?(3), 3).WithCardType("Enemy").WithValue(50).SetASprites("glaceon.png", "glaceonBG.png").SAttackEffects(("Snow", 2), ("Frost", 2)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("quest_cresselia", "Cresselia").WithCardType("Summoned").SetStats(new int?(6), counter: 6).SetASprites("cresselia.png", "cresseliaBG.png").SStartEffects(("On Card Played Gain Dream Card To Hand", 1), ("Cannot Recall", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_darkrai", "Darkrai").SetStats(new int?(66), new int?(2), 4).SetASprites("darkrai.png", "darkraiBG.png").WithCardType("Miniboss").WithValue(50).SStartEffects(("ImmuneToSnow", 1), ("Frenzy Equal To Curses In Hand", 1)));
      this.list.Add(new CardDataBuilder((WildfrostMod) this).CreateUnit("enemy_sylveon", "Sylveon", bloodProfile: "Blood Profile Berry").SetStats(new int?(10), new int?(2), 3).WithCardType("Enemy").WithValue(50).SetASprites("sylveon.png", "sylveonBG.png").SStartEffects(("On Turn Heal & Cleanse Allies", 2)));
    }

    private void AddGreetings()
    {
      foreach (DataFileBuilder<CardData, CardDataBuilder> dataFileBuilder in this.list)
        dataFileBuilder.FreeModify((Action<CardData>) (data => data.greetMessages = new string[3]
        {
          "Oh! A wild <name> appeared!",
          "Hey! <name> wants to join your team!",
          "\"<name>?\" (This Pokemon is waiting for a response.)"
        }));
    }

    private void AddShades()
    {
      for (int index = 0; index < Pokefrost.Pokefrost.summoner.Length; ++index)
        CreatedByLookup.Add(this.GUID + "." + Pokefrost.Pokefrost.summoned[index], this.GUID + "." + Pokefrost.Pokefrost.summoner[index]);
    }

    private void CreateModAssetsCharms()
    {
      Debug.Log((object) "[Pokefrost] Loading Charms");
      CardUpgradeData cardUpgradeData1 = this.Get<CardUpgradeData>("CardUpgradeAimless");
      CardUpgradeData cardUpgradeData2 = this.Get<CardUpgradeData>("CardUpgradeBarrage");
      CardUpgradeData cardUpgradeData3 = this.Get<CardUpgradeData>("CardUpgradeWildcard");
      TargetConstraintHasTrait instance1 = ScriptableObject.CreateInstance<TargetConstraintHasTrait>();
      instance1.name = "Does Not Have Pluck";
      instance1.trait = this.Get<TraitData>("Pluck");
      instance1.not = true;
      TargetConstraintHasTrait instance2 = ScriptableObject.CreateInstance<TargetConstraintHasTrait>();
      instance2.name = "Does Not Have Aimless";
      instance2.trait = this.Get<TraitData>("Aimless");
      instance2.not = true;
      TargetConstraint[] source = new TargetConstraint[0];
      foreach (TargetConstraint targetConstraint in cardUpgradeData1.targetConstraints)
        source = ((IEnumerable<TargetConstraint>) source).Append<TargetConstraint>(targetConstraint).ToArray<TargetConstraint>();
      TargetConstraint[] array = ((IEnumerable<TargetConstraint>) source).Append<TargetConstraint>((TargetConstraint) instance2).ToArray<TargetConstraint>();
      cardUpgradeData1.targetConstraints = ((IEnumerable<TargetConstraint>) cardUpgradeData1.targetConstraints).Append<TargetConstraint>((TargetConstraint) instance1).ToArray<TargetConstraint>();
      cardUpgradeData2.targetConstraints = ((IEnumerable<TargetConstraint>) cardUpgradeData2.targetConstraints).Append<TargetConstraint>((TargetConstraint) instance1).ToArray<TargetConstraint>();
      cardUpgradeData3.targetConstraints = ((IEnumerable<TargetConstraint>) cardUpgradeData3.targetConstraints).Append<TargetConstraint>((TargetConstraint) instance1).ToArray<TargetConstraint>();
      TargetConstraintStatusMoreThan instance3 = ScriptableObject.CreateInstance<TargetConstraintStatusMoreThan>();
      instance3.not = true;
      instance3.status = this.Get<StatusEffectData>("On Card Played Buff Marowak");
      instance3.amount = 0;
      this.charmlist = new List<CardUpgradeDataBuilder>();
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradeMagnemite").WithTier(1).WithAImage("magnemiteCharm").SEffects(("On Card Played Apply Shroom Overburn Or Bom", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeShroom").targetConstraints).SetBecomesTarget(true).WithTitle("Magnemite Charm").WithText("Apply <1><keyword=shroom>/<keyword=overload>/<keyword=weakness> randomly"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradePluck").WithTier(0).WithAImage("murkrowCharm").STraits(("Pluck", 1)).SetConstraints(array).ChangeDamage(2).WithTitle("Murkrow Charm").WithText("Gain <keyword=pluck>\n<+2><keyword=attack>\nCA-CAW"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradeSketch").WithTier(0).WithAImage("smeargleCharm").SEffects(("When Deployed Sketch", 1)).STraits(("Pigheaded", 1)).ChangeDamage(-2).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeBlock").targetConstraints[0], this.Get<CardUpgradeData>("CardUpgradePig").targetConstraints[1], this.Get<CardUpgradeData>("CardUpgradeBarrage").targetConstraints[2]).WithTitle("Smeargle Charm").WithText("Gain <keyword=sketch> <1>, <keyword=pigheaded> and reduce <keyword=attack> by <2>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeConduit").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("raikouCharm").SetBecomesTarget(true).SEffects(("When Anyone Takes Jolted Damage Trigger", 1)).SAttackEffects(("Jolted", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2]).WithTitle("Raikou Charm").WithText("Apply <1><keyword=jolted> and gain <keyword=conduit><color=#F99C61>: Trigger</color>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeBackBurn").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("enteiCharm").SEffects(("When Hit Apply Equal Burning To The Attacker", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2]).WithTitle("Entei Charm").WithText("When hit, apply equal <keyword=burning> to the attacker"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeJuice").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("suicuneCharm").SEffects(("Spicune", 4)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1], this.Get<CardUpgradeData>("CardUpgradeCake").targetConstraints[1]).WithTitle("Suicune Charm").WithText("Start with <4><keyword=spicune>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeSacredAsh").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("hoohCharm").SEffects(("When Destoryed Give Revive To All Allies", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2]).WithTitle("Ho-Oh Charm").WithText("When charmed unit is destroyed, add <keyword=revive> to all allies"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradeUturn").WithTier(2).WithAImage("masquerainCharm").WithType(CardUpgradeData.Type.Charm).STraits(("U-turn", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1], this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2], this.Get<CardUpgradeData>("CardUpgradePig").targetConstraints[1]).WithTitle("Masquerain Charm").WithText("Gain <keyword=uturn>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeResist").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("latiasCharm").STraits(("Resist", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2]).WithTitle("Latias Charm").WithText("Gain <keyword=resist> <1>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeCharged").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("latiosCharm").SEffects(("While Redraw Bell Is Charged Gain Frenzy", 1)).WithTitle("Latios Charm").WithText("Gain <x1><keyword=frenzy> while the <Redraw Bell> is charged"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradeTaunt").WithTier(1).WithAImage("shieldonCharm").WithType(CardUpgradeData.Type.Charm).STraits(("Taunt", 1)).ChangeHP(3).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeHeart").targetConstraints).WithTitle("Shieldon Charm").WithText("Gain <keyword=taunt>\n<+3><keyword=health>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeDuplicate").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("cresseliaCharm").SetScripts((CardScript) ScriptableObject.CreateInstance<CardScriptCopy>()).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeFrenzyConsume").targetConstraints[0], (TargetConstraint) ScriptableObject.CreateInstance<TargetConstraintIsInDeck>()).WithTitle("Cresselia Charm").WithText("Duplicate an item card"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeCurse").WithType(CardUpgradeData.Type.Charm).WithTier(2).WithAImage("darkraiCharm").SEffects(("FrenzyCurse", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeFrenzyConsume").targetConstraints).WithTitle("Darkrai Charm").WithText("Gain <keyword=curseoffrenzy>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradeTyrunt").WithTier(1).WithAImage("tyruntCharm").WithType(CardUpgradeData.Type.Charm).STraits(("Wild", 1)).SAttackEffects(("Apply Wild Trait", 1)).SetBecomesTarget(true).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1], this.Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2]).WithTitle("Tyrunt Charm").WithText("Gain <keyword=wild>\nApply <keyword=wild>\nBE <WILD>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).CreateCharm("CardUpgradeRevive").WithTier(1).WithAImage("reviveCharm").WithType(CardUpgradeData.Type.Charm).SEffects(("Revive", 1)).SetConstraints(this.Get<CardUpgradeData>("CardUpgradeHeart").targetConstraints[0]).WithTitle("Revive Charm").WithText("Gain <keyword=revive>"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CardUpgradeThickClub").WithType(CardUpgradeData.Type.Charm).WithTier(-1).WithAImage("thickclubCharm").SEffects(("On Card Played Buff Marowak", 1)).SetConstraints((TargetConstraint) instance3).WithTitle("Thick Club").WithText("Gain 'increase <Marowak's> <keyword=health> or <keyword=attack> by <1>'\n\nRandomly each trigger"));
      this.charmlist.Add(new CardUpgradeDataBuilder((WildfrostMod) this).Create("CrownSlowking").WithType(CardUpgradeData.Type.Crown).WithAImage("slowking_crown").ChangeCounter(1).WithTitle("Shellder Crown").WithText("Cards with Crowns are always played at the start of battle\n\nIncrease <keyword=counter> by <1>").SetCanBeRemoved(true));
      this.preLoaded = true;
    }

    private void CreateModAssetsBells()
    {
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingSpicune", "Suicune Bell of Juice", "Give <1><keyword=spicune> to <2> random cards in deck. When <keyword=spicune> lost, apply <keyword=spicune> to a random card in deck").ChangeASprites("suicuneBell", "suicuneDinger").WithSystemsToAdd("BounceJuiceModifierSystem").SubscribeToAfterAllBuildEvent((DataFileBuilder<GameModifierData, GameModifierDataBuilder>.AfterBuildDelegate) (data =>
      {
        ScriptRunScriptsOnDeckAlt instance1 = ScriptableObject.CreateInstance<ScriptRunScriptsOnDeckAlt>();
        CardScriptAddPassiveEffect instance2 = ScriptableObject.CreateInstance<CardScriptAddPassiveEffect>();
        instance2.effect = this.Get<StatusEffectData>("Spicune");
        instance2.countRange = new Vector2Int(1, 1);
        TargetConstraintCanBeBoosted instance3 = ScriptableObject.CreateInstance<TargetConstraintCanBeBoosted>();
        TargetConstraintHasStatus instance4 = ScriptableObject.CreateInstance<TargetConstraintHasStatus>();
        instance4.status = instance2.effect;
        instance4.not = true;
        instance1.scripts = new CardScript[1]
        {
          (CardScript) instance2
        };
        instance1.constraints = new TargetConstraint[2]
        {
          (TargetConstraint) instance3,
          (TargetConstraint) instance4
        };
        instance1.countRange = new Vector2Int(2, 2);
        data.startScripts = new Script[1]
        {
          (Script) instance1
        };
      })));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingEntei", "Entei Bell of Ignition", "At the start of each turn if no enemies are <keyword=burning>'d, apply <3><keyword=burning> to a random enemy").ChangeASprites("enteiBell", "enteiDinger").WithSystemsToAdd("AlwaysIgniteModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingRaikou", "Raikou Bell of Zoomlin", "After <Redraw Bell> is hit, give a random card in hand <keyword=zoomlin>").ChangeASprites("raikouBell", "raikouDinger").WithSystemsToAdd("GiveZoomlinModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingHooh", "Ho-Oh Bell of Friendship", "Allies get recalled to the top of your deck").ChangeASprites("hoohBell", "hoohDinger").WithSystemsToAdd("RecallToTopModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingLatios", "Latios Bell of Impatience", "For the first minute of battle, the <Redraw Bell> fully recharges every turn").ChangeASprites("latiosBell", "latiosDinger").WithSystemsToAdd("InitialBellCounterReductionModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingLatias", "Latias Bell of Impulse", "When leader is hit, count down <Redraw Bell> by 1").ChangeASprites("latiasBell", "latiasDinger").WithSystemsToAdd("CountdownRedrawWhenLeaderIsHitModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingCresselia", "Cresselia Bell of Dreams", "When <Redraw Bell> is hit, add 2 <keyword=dream> cards to hand").ChangeASprites("cresseliaBell", "cresseliaDinger").WithSystemsToAdd("GiveDreamCardModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("BlessingDarkrai", "Darkrai Bell of Destruction", "Redraw Bell Counter -1. When <Redraw Bell> is hit, destroy the rightmost card in hand before redrawing").ChangeASprites("darkraiBell", "darkraiDinger").WithSystemsToAdd("DestoryCardSystem").SubscribeToAfterAllBuildEvent((DataFileBuilder<GameModifierData, GameModifierDataBuilder>.AfterBuildDelegate) (data =>
      {
        ScriptChangeRedrawBellCounter instance = ScriptableObject.CreateInstance<ScriptChangeRedrawBellCounter>();
        instance.add = true;
        instance.value = -1;
        data.startScripts = new Script[1]
        {
          (Script) instance
        };
      })));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("hoohEvent", "Mystery Part", "<Quest>: Prove your strength against the <3> <Legendary Beasts>").ChangeASprites("mysteryJello", (string) null).WithStartScripts((Script) ScriptableObject.CreateInstance<ScriptReturnNode>()).WithSystemsToAdd("GatekeeperModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("darkraiEvent", "Lunar Feather", "<Quest>: Protect <Cresselia> and confront <Darkrai>").ChangeASprites("lunarFeather", (string) null).WithStartScripts((Script) ScriptableObject.CreateInstance<ScriptReturnNode>()).WithSystemsToAdd("SpawnCressliaModifierSystem"));
      Pokefrost.Pokefrost.bells.Add(this.CreateBell("latiEvent", "Eon Ticket", "<Quest>: Reach the <Frostlands> before the ship departs").ChangeASprites("eonTicket", (string) null).WithStartScripts((Script) ScriptableObject.CreateInstance<ScriptReturnNode>()).WithSystemsToAdd("TicketTimerModifierSystem"));
    }

    private void CreateEvents()
    {
      this.CreateCampaignNodeType<CampaignNodeTypeTrade>("trade", "t").BetterEvent("Trade", (WildfrostMod) this).Register((WildfrostMod) this);
      StringTable collection = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(EventRoutineTrade.Seq1Key, "Select a Trade!");
      collection.SetString(EventRoutineTrade.Seq2Key, "{0} for {1}?");
      collection.SetString(EventRoutineTrade.TradeConfirm, "Confirm");
      collection.SetString(EventRoutineTrade.TradeCancel, "Cancel");
      this.CreateCampaignNodeType<CampaignNodeTypeSpecialBattle>("specialBattle", "e", false).BetterBattle((WildfrostMod) this).Register((WildfrostMod) this);
    }

    private void LoadStatusEffects()
    {
      AddressableLoader.AddRangeToGroup<StatusEffectData>("StatusEffectData", (IEnumerable<StatusEffectData>) Pokefrost.Pokefrost.statusList);
    }

    private void PokemonPostBattle()
    {
      CardDataList deck = References.Player.data.inventory.deck;
      for (int index = deck.Count - 1; index >= 0; --index)
      {
        CardData cardData = deck.list[index];
        if (cardData.name == "websiteofsites.wildfrost.pokefrost.marowak")
        {
          Debug.Log((object) "[Pokefrost] Marowak found a bone lying on the battlefield.");
          foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
          {
            if (startWithEffect.data.name == "Give Thick Club")
            {
              References.Player.data.inventory.upgrades.Add(AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", "websiteofsites.wildfrost.pokefrost.CardUpgradeThickClub").Clone());
              break;
            }
          }
        }
        if (cardData.name == "websiteofsites.wildfrost.pokefrost.slowking")
        {
          Debug.Log((object) "[Pokefrost] Slowking bestows a crown(?) to the party.");
          foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
          {
            if (startWithEffect.data.name == "Give Slowking Crown")
            {
              References.Player.data.inventory.upgrades.Add(AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", "websiteofsites.wildfrost.pokefrost.CrownSlowking").Clone());
              break;
            }
          }
        }
      }
      CardDataList reserve = References.PlayerData.inventory.reserve;
      for (int index1 = reserve.Count - 1; index1 >= 0; --index1)
      {
        CardData cardData = reserve.list[index1];
        if (cardData.name == "websiteofsites.wildfrost.pokefrost.nosepass")
        {
          Debug.Log((object) "[Pokefrost] Nosepass's magentic field attrached a charm to it.");
          List<CardUpgradeData> group = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
          for (int index2 = 0; index2 < 30; ++index2)
          {
            int index3 = UnityEngine.Random.Range(0, group.Count);
            CardUpgradeData cardUpgradeData = group[index3];
            if ((cardUpgradeData.ModAdded == null || cardUpgradeData.ModAdded == this || cardUpgradeData.scripts == null || cardUpgradeData.scripts.Length == 0) && cardUpgradeData.CanAssign(cardData) && cardUpgradeData.tier > 0)
            {
              Debug.Log((object) ("Nosepass found " + cardUpgradeData.name.ToString()));
              cardUpgradeData.Assign(cardData);
              break;
            }
          }
        }
      }
    }

    private void ShinyPet()
    {
      CardScriptForsee.ids.Clear();
      if (References.PlayerData?.inventory?.deck == null)
        return;
      foreach (CardData card in References.PlayerData.inventory.deck)
      {
        if (card.name.Contains("websiteofsites.wildfrost.pokefrost") && (double) UnityEngine.Random.Range(0.0f, 1f) < (double) Pokefrost.Pokefrost.shinyrate)
          this.Shinify(card);
      }
    }

    private void GetShiny(Entity entity)
    {
      if (!entity.data.name.Contains("websiteofsites.wildfrost.pokefrost") || (double) UnityEngine.Random.Range(0.0f, 1f) >= (double) Pokefrost.Pokefrost.shinyrate)
        return;
      entity.GetCard().mainImage.sprite = this.Shinify(entity.data);
    }

    internal Sprite Shinify(CardData card)
    {
      CardData.StatusEffectStacks[] second = new CardData.StatusEffectStacks[1]
      {
        new CardData.StatusEffectStacks(this.Get<StatusEffectData>("Shiny"), 1)
      };
      card.startWithEffects = ((IEnumerable<CardData.StatusEffectStacks>) card.startWithEffects).Concat<CardData.StatusEffectStacks>((IEnumerable<CardData.StatusEffectStacks>) second).ToArray<CardData.StatusEffectStacks>();
      return this.ApplyShinySprite(card);
    }

    internal Sprite ApplyShinySprite(CardData card)
    {
      string str = card.name.Split('.')[3];
      Sprite sprite = AddressableExtMethods.SaferASprite("shiny_" + str + ".png");
      if ((UnityEngine.Object) sprite == (UnityEngine.Object) null || sprite.texture.width < 50)
      {
        Debug.Log((object) ("[Pokefrost] Could not find [shiny_" + str + ".png]. Go yell at one of the devs."));
        return card.mainSprite;
      }
      sprite.name = "shiny";
      card.mainSprite = sprite;
      return sprite;
    }

    private void DebugShiny()
    {
      foreach (DataFileBuilder<CardData, CardDataBuilder> dataFileBuilder in this.list)
      {
        string str = dataFileBuilder._data.name.Split('.')[3];
        if (!File.Exists(this.ImagePath("shiny_" + str + ".png")))
          Debug.Log((object) ("[Pokefrost] WARNING: Shiny file for " + str + "does not exist."));
        else
          Debug.Log((object) ("[Pokefrost] " + str + "has a shiny version."));
      }
    }

    public override void Load()
    {
      if (!this.preLoaded)
        AddressableExtMethods.LoadAtlas();
      this.CreateModAssets();
      if (!this.preLoaded)
      {
        this.CreateModAssetsCards();
        this.CreateModAssetsCharms();
        this.CreateModAssetsBells();
        this.AddGreetings();
        this.AddShades();
        EyeDataAdder.Eyes();
      }
      this.CreateEvents();
      this.MiscLocalizationStrings();
      base.Load();
      if (EventBattleManager.instance == null)
      {
        EventBattleManager eventBattleManager = new EventBattleManager();
      }
      EventBattleManager.instance.Enable(this);
      global::Events.OnBattleEnd += new UnityAction(StatusEffectEvolve.CheckEvolve);
      global::Events.OnEntityOffered += new UnityAction<Entity>(this.GetShiny);
      global::Events.OnCheckEntityDrag += new global::Events.UnityActionRef<Entity, bool>(ButtonExt.DisableDrag);
      global::Events.OnSceneLoaded += new UnityAction<Scene>(this.BattleFuse);
      global::Events.OnEntityChosen += new UnityAction<Entity>(StatusEffectEvolveFromCardPickup.CheckEvolveFromSelect);
      global::Events.OnShopItemPurchase += new UnityAction<ShopItem>(StatusEffectEvolveFromCardPickup.CheckEvolveFromSelect);
      global::Events.OnSceneChanged += new UnityAction<Scene>(PickupRoutine.OnSceneChanged);
      global::Events.OnBattleEnd += new UnityAction(this.PokemonPostBattle);
      global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(this.RotomFuse);
      global::Events.OnEntityFlee += new UnityAction<Entity>(this.FurretFlee);
      MoreEvents.OnCampaignGenerated += new UnityAction(this.ApplianceSpawns);
      global::Events.OnCampaignLoaded += new UnityAction(this.CountNatus);
      global::Events.OnMapNodeReveal += new UnityAction<MapNode>(this.NatuForsee);
      global::Events.OnEntityCreated += new UnityAction<Entity>(this.FixImage);
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(StatusEffectRetreat.FailSafe);
      UnityEngine.Object.FindObjectOfType<FloatingText>(true).textAsset.spriteAsset.fallbackSpriteAssets.Add(this.pokefrostSprites);
      this.Get<CardData>("websiteofsites.wildfrost.pokefrost.klefki").charmSlots = 100;
      ((StatusEffectSummon) this.Get<StatusEffectData>("Summon Shedinja")).summonCard = this.Get<CardData>("websiteofsites.wildfrost.pokefrost.shedinja");
      TargetConstraintIsSpecificCard instance = ScriptableObject.CreateInstance<TargetConstraintIsSpecificCard>();
      instance.allowedCards = new CardData[1]
      {
        this.Get<CardData>("websiteofsites.wildfrost.pokefrost.marowak")
      };
      ((StatusEffectApplyX) this.Get<StatusEffectData>("On Card Played Buff Marowak")).applyConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) instance
      };
      global::Events.OnSceneLoaded += new UnityAction<Scene>(this.SceneLoaded);
      MonoBehaviourSingleton<References>.instance.StartCoroutine(UICollector.CollectPrefabs());
      MonoBehaviourSingleton<References>.instance.StartCoroutine(Commands.AddCustomCommands());
      this.preLoaded = true;
    }

    private void MiscLocalizationStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      StringTable collection = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      PokeLocalizer.Run();
      collection.SetString(EvolutionPopUp.EvoTitleKey1A, "Huh? <#ff0>{0}</color> is evolving?");
      collection.SetString(EvolutionPopUp.EvoTitleKey1B, "Huh? <#ff0>{0}</color> Pokemon are evolving?");
      collection.SetString(EvolutionPopUp.EvoTitleKey2A, "<#ff0>{0}</color> has evolved into <#ff0>{1}</color>!");
      collection.SetString(EvolutionPopUp.EvoTitleKey2B, "<#ff0>{0}</color> Pokemon have evolved!");
      collection.SetString(EvolutionPopUp.EvoObserve, "Observe");
    }

    public override void Unload()
    {
      base.Unload();
      EventBattleManager.instance.Disable(this);
      global::Events.OnBattleEnd -= new UnityAction(this.PokemonPostBattle);
      global::Events.OnBattleEnd -= new UnityAction(StatusEffectEvolve.CheckEvolve);
      global::Events.OnEntityOffered -= new UnityAction<Entity>(this.GetShiny);
      global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(this.RotomFuse);
      global::Events.OnCampaignStart -= new UnityAction(this.ShinyPet);
      MoreEvents.OnCampaignGenerated -= new UnityAction(this.ApplianceSpawns);
      global::Events.OnCheckEntityDrag -= new global::Events.UnityActionRef<Entity, bool>(ButtonExt.DisableDrag);
      global::Events.OnEntityFlee -= new UnityAction<Entity>(this.FurretFlee);
      global::Events.OnSceneLoaded -= new UnityAction<Scene>(this.BattleFuse);
      global::Events.OnCampaignLoaded -= new UnityAction(this.CountNatus);
      global::Events.OnMapNodeReveal -= new UnityAction<MapNode>(this.NatuForsee);
      global::Events.OnEntitySelect -= new UnityAction<Entity>(StatusEffectEvolveFromCardPickup.CheckEvolveFromSelect);
      global::Events.OnEntityCreated -= new UnityAction<Entity>(this.FixImage);
      this.UnloadFromClasses();
      this.RevertVanillaChanges();
      global::Events.OnSceneLoaded -= new UnityAction<Scene>(this.SceneLoaded);
      global::Events.OnSceneChanged -= new UnityAction<Scene>(PickupRoutine.OnSceneChanged);
    }

    private void CountNatus()
    {
      CardScriptForsee.ids.Clear();
      if (References.PlayerData?.inventory?.deck == null)
        return;
      List<CardData> list = References.PlayerData.inventory.deck.Where<CardData>((Func<CardData, bool>) (c => c.name == "websiteofsites.wildfrost.pokefrost.natu")).ToList<CardData>();
      list.AddRange(References.PlayerData.inventory.reserve.Where<CardData>((Func<CardData, bool>) (c => c.name == "websiteofsites.wildfrost.pokefrost.natu")));
      foreach (CardData cardData in list)
      {
        int num;
        if (cardData.TryGetCustomData<int>("Future Sight ID", out num, -1))
          CardScriptForsee.ids.Add(num);
      }
    }

    private void NatuForsee(MapNode node)
    {
      if (!CardScriptForsee.ids.Contains(node.campaignNode.id) || node.campaignNode.glow)
        return;
      node.campaignNode.glow = true;
      node.glow.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1f, 0.0f, 0.3f);
      node.glow.SetActive(true);
    }

    private void RevertVanillaChanges()
    {
      TraitData traitData = this.Get<TraitData>("Aimless");
      traitData.overrides = traitData.overrides.RemoveNulls<TraitData>((WildfrostMod) this);
      this.Get<TraitData>("Barrage").overrides = traitData.overrides.RemoveNulls<TraitData>((WildfrostMod) this);
      this.Get<TraitData>("Longshot").overrides = traitData.overrides.RemoveNulls<TraitData>((WildfrostMod) this);
      StatusEffectInstantEat effectInstantEat = this.Get<StatusEffectData>("Eat (Health, Attack & Effects)") as StatusEffectInstantEat;
      effectInstantEat.illegalEffects = effectInstantEat.illegalEffects.RemoveNulls<StatusEffectData>((WildfrostMod) this);
    }

    private void SceneLoaded(Scene scene)
    {
      if (!(scene.name == "Campaign"))
        return;
      SpecialEventsSystem objectOfType = UnityEngine.Object.FindObjectOfType<SpecialEventsSystem>();
      objectOfType.events = ((IEnumerable<SpecialEventsSystem.Event>) objectOfType.events).AddItem<SpecialEventsSystem.Event>(new SpecialEventsSystem.Event()
      {
        requiresUnlock = (UnlockData) null,
        nodeType = this.Get<CampaignNodeType>("trade"),
        replaceNodeTypes = new string[1]
        {
          "CampaignNodeReward"
        },
        minTier = 2,
        perTier = new Vector2Int(1, 1),
        perRun = new Vector2Int(1, 2)
      }).ToArray<SpecialEventsSystem.Event>();
    }

    private void PokemonPhoto(Scene scene)
    {
      if (!(scene.name == "Town"))
        return;
      MonoBehaviourSingleton<References>.instance.StartCoroutine(this.PokemonPhoto2());
    }

    private IEnumerator PokemonPhoto2()
    {
      string[] everyGeneration = new string[17]
      {
        "farfetchd",
        "muk",
        "furret",
        "aipom",
        "kirlia",
        "gardevoir",
        "gallade",
        "natu",
        "xatu",
        "abomasnow",
        "aron",
        "lairon",
        "aggron",
        "lumineon",
        "chimecho",
        "palafin",
        "whimsicott"
      };
      string[] everyType = new string[22]
      {
        "raikou",
        "entei",
        "suicune",
        "hooh",
        "latias",
        "latios",
        "cresselia",
        "darkrai",
        "enemy_beautifly",
        "enemy_dustox",
        "enemy_plusle",
        "enemy_volbeat",
        "enemy_illumise",
        "enemy_minun",
        "enemy_lunatone",
        "enemy_solrock",
        "enemy_huntail",
        "enemy_gorebyss",
        "enemy_hypno",
        "enemy_mismagius",
        "enemy_spiritomb",
        "enemy_magmortar"
      };
      yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
      yield return (object) SceneManager.Load("CardFramesUnlocked", SceneType.Temporary);
      CardFramesUnlockedSequence sequence = UnityEngine.Object.FindObjectOfType<CardFramesUnlockedSequence>();
      TextMeshProUGUI titleObject = sequence.GetComponentInChildren<TextMeshProUGUI>(true);
      titleObject.text = "10 New Companions";
      yield return (object) sequence.StartCoroutine("CreateCards", (object) ((IEnumerable<string>) everyGeneration).Select<string, string>((Func<string, string>) (n => this.GUID + "." + n)).ToArray<string>());
      yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
      yield return (object) SceneManager.Load("CardFramesUnlocked", SceneType.Temporary);
      sequence = UnityEngine.Object.FindObjectOfType<CardFramesUnlockedSequence>();
      titleObject = sequence.GetComponentInChildren<TextMeshProUGUI>(true);
      titleObject.text = "Pokemon of Every Type";
      yield return (object) sequence.StartCoroutine("CreateCards", (object) ((IEnumerable<string>) everyType).Select<string, string>((Func<string, string>) (n => this.GUID + "." + n)).ToArray<string>());
    }

    public void UnloadFromClasses()
    {
      foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
      {
        if (!((UnityEngine.Object) classData == (UnityEngine.Object) null) && classData.rewardPools != null)
        {
          foreach (RewardPool rewardPool in classData.rewardPools)
          {
            if (!((UnityEngine.Object) rewardPool == (UnityEngine.Object) null))
              rewardPool.list.RemoveAllWhere<DataFile>((Predicate<DataFile>) (item => (UnityEngine.Object) item == (UnityEngine.Object) null || item.ModAdded == this));
          }
        }
      }
    }

    private void ApplianceSpawns()
    {
      if ((UnityEngine.Object) References.PlayerData.inventory.deck.FirstOrDefault<CardData>((Func<CardData, bool>) (c => c.name == "websiteofsites.wildfrost.pokefrost.rotom")) == (UnityEngine.Object) null)
        return;
      string[] array = ((IEnumerable<string>) Pokefrost.Pokefrost.rotomAppliances).InRandomOrder<string>().ToArray<string>();
      for (int index = 0; index < References.Campaign.nodes.Count; ++index)
      {
        CampaignNode node = References.Campaign.nodes[index];
        if (node.tier >= 2 && node.type.name == "CampaignNodeItem")
        {
          SaveCollection<string> saveCollection = (SaveCollection<string>) node.data["cards"];
          saveCollection.Add(array[index % 5]);
          node.data["cards"] = (object) saveCollection;
        }
      }
    }

    private void RotomFuse(Entity entity)
    {
      for (int index = 0; index < Pokefrost.Pokefrost.rotomAppliances.Length; ++index)
      {
        if (entity.data.name == Pokefrost.Pokefrost.rotomAppliances[index])
        {
          CardData cardData = References.PlayerData.inventory.deck.FirstOrDefault<CardData>((Func<CardData, bool>) (c => c.name == "websiteofsites.wildfrost.pokefrost.rotom"));
          if ((UnityEngine.Object) cardData == (UnityEngine.Object) null)
          {
            cardData = References.PlayerData.inventory.reserve.FirstOrDefault<CardData>((Func<CardData, bool>) (c => c.name == "websiteofsites.wildfrost.pokefrost.rotom"));
            if ((UnityEngine.Object) cardData == (UnityEngine.Object) null)
              break;
            References.PlayerData.inventory.reserve.Remove(cardData);
            References.PlayerData.inventory.deck.Add(cardData);
          }
          if ((bool) (UnityEngine.Object) cardData)
          {
            this.fusedRotom = cardData;
            CombineCardSystem objectOfType = UnityEngine.Object.FindObjectOfType<CombineCardSystem>();
            CombineCardSystem.Combo combo = new CombineCardSystem.Combo()
            {
              cardNames = new string[2]
              {
                "websiteofsites.wildfrost.pokefrost.rotom",
                Pokefrost.Pokefrost.rotomAppliances[index]
              },
              resultingCardName = this.rotomForms[index]
            };
            global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(this.RotomAdjust);
            objectOfType.StopAllCoroutines();
            objectOfType.StartCoroutine(objectOfType.CombineSequence(combo));
          }
        }
      }
    }

    private void RotomAdjust(Entity entity)
    {
      if (this.fusedRotom.mainSprite.name == "shiny")
      {
        string[] strArray = entity.data.name.Split('.');
        string str = strArray[strArray.Length - 1];
        Sprite sprite = Pokefrost.Pokefrost.instance.ImagePath("shiny_" + str + ".png").ToSprite();
        sprite.name = "shiny";
        entity.data.mainSprite = sprite;
        entity.GetComponent<Card>().mainImage.sprite = sprite;
        CardData.StatusEffectStacks[] second = new CardData.StatusEffectStacks[1]
        {
          new CardData.StatusEffectStacks(this.Get<StatusEffectData>("Shiny"), 1)
        };
        entity.data.startWithEffects = ((IEnumerable<CardData.StatusEffectStacks>) entity.data.startWithEffects).Concat<CardData.StatusEffectStacks>((IEnumerable<CardData.StatusEffectStacks>) second).ToArray<CardData.StatusEffectStacks>();
      }
      foreach (CardUpgradeData upgrade in this.fusedRotom.upgrades)
      {
        if (upgrade.CanAssign(entity.data))
          upgrade.Assign(entity.data);
      }
      if (Pokefrost.Pokefrost.instance.Get<CardData>(this.fusedRotom.name).title != this.fusedRotom.title)
      {
        entity.data.forceTitle = this.fusedRotom.title;
        entity.GetComponent<Card>().SetName(this.fusedRotom.title);
        Debug.Log((object) ("[Pokefrost] renamed evolution to " + this.fusedRotom.title));
        global::Events.InvokeRename(entity, this.fusedRotom.title);
      }
      global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(this.RotomAdjust);
    }

    private void PokemonEdits(Scene scene)
    {
      if (scene.name != "MapNew")
        return;
      Debug.Log((object) "Fixing Shinies");
      CardDataList deck = References.PlayerData.inventory.deck;
      CardDataList reserve = References.PlayerData.inventory.reserve;
      foreach (CardData cardData in deck)
      {
        if (cardData.name.Contains("websiteofsites.wildfrost.pokefrost"))
        {
          bool flag = false;
          foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
          {
            if (startWithEffect.data.name == "Shiny")
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            string str = cardData.name.Split('.')[3];
            string path = this.ImagePath("shiny_" + str + ".png");
            Debug.Log((object) ("shiny_" + str));
            if (!File.Exists(path))
            {
              Debug.Log((object) "[Pokefrost] Oops, shiny file not found. Contact devs.");
              return;
            }
            Sprite sprite = this.ImagePath("shiny_" + str + ".png").ToSprite();
            sprite.name = "shiny";
            cardData.mainSprite = sprite;
          }
        }
      }
      foreach (CardData cardData in reserve)
      {
        if (cardData.name.Contains("websiteofsites.wildfrost.pokefrost"))
        {
          bool flag = false;
          foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
          {
            if (startWithEffect.data.name == "Shiny")
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            string str = cardData.name.Split('.')[3];
            string path = this.ImagePath("shiny_" + str + ".png");
            Debug.Log((object) ("shiny_" + str));
            if (!File.Exists(path))
            {
              Debug.Log((object) "[Pokefrost] Oops, shiny file not found. Contact devs.");
              break;
            }
            Sprite sprite = this.ImagePath("shiny_" + str + ".png").ToSprite();
            sprite.name = "shiny";
            cardData.mainSprite = sprite;
          }
        }
      }
    }

    public void DisplayEvolutions(CampaignNode whatever)
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count <= 0)
        return;
      MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.DelayedRun());
    }

    public void BattleFuse(Scene scene)
    {
      if (!(scene.name == "Campaign"))
        return;
      GameObject.Find("Systems").AddComponent<CombineCardInBattleSystem>();
    }

    private void FixImage(Entity entity)
    {
      if (!(entity.display is Card display) || display.hasScriptableImage)
        return;
      display.mainImage.gameObject.SetActive(true);
    }

    public override string GUID => "websiteofsites.wildfrost.pokefrost";

    public override string[] Depends => new string[0];

    public override string Title => nameof (Pokefrost);

    public override string Description
    {
      get
      {
        return "Pokemon Companions\r\n\r\nAdds 58 new companions, 2 new pets, 7 new charms, a new map event, and 3 quests ending new battles.\n\n\nThe developers can be contacted through Steam or Discord (@Josh A, @Michael C)\n\n\nThanks to Lost for Jolted icon, to MegaMairne for Ignite icon and animations, and to tonofdirt726 for recolors.";
      }
    }

    public override List<T> AddAssets<T, Y>()
    {
      switch (typeof (Y).Name)
      {
        case "CardData":
          return Enumerable.Cast<T>(this.list).ToList<T>();
        case "CardUpgradeData":
          return Enumerable.Cast<T>(this.charmlist).ToList<T>();
        case "GameModifierData":
          return Enumerable.Cast<T>(Pokefrost.Pokefrost.bells).ToList<T>();
        default:
          return base.AddAssets<T, Y>();
      }
    }

    public void FurretFlee(Entity entity)
    {
      string path = Path.Combine(this.ModDirectory, "furret.txt");
      if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player) || !(entity.name == "websiteofsites.wildfrost.pokefrost.furret") || !(entity.data.cardType.name == "Friendly"))
        return;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(entity.data.title);
      stringBuilder.AppendLine(References.Player.data.inventory.deck[0].title);
      stringBuilder.AppendLine(StatsSystem.instance.Stats.Count("battlesWon").ToString());
      stringBuilder.AppendLine(DateTime.Now.ToString());
      string str = (UnityEngine.Object) entity.FindStatus("shiny") != (UnityEngine.Object) null ? "Hasty" : "Modest";
      stringBuilder.AppendLine(str);
      foreach (CardUpgradeData upgrade in entity.data.upgrades)
        stringBuilder.AppendLine(upgrade.name);
      File.WriteAllText(path, stringBuilder.ToString());
      References.Player.data.inventory.deck.RemoveWhere<CardData>((Predicate<CardData>) (e => e.name == entity.name));
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PokeLocalizer
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
  public class PokeLocalizer : Attribute
  {
    public static void Run()
    {
      MethodInfo[] array = ((IEnumerable<Type>) typeof (PokeLocalizer).Assembly.GetTypes()).SelectMany<Type, MethodInfo>((Func<Type, IEnumerable<MethodInfo>>) (t => (IEnumerable<MethodInfo>) t.GetMethods())).Where<MethodInfo>((Func<MethodInfo, bool>) (m => m.GetCustomAttribute<PokeLocalizer>() != null)).ToArray<MethodInfo>();
      Debug.Log((object) string.Format("[Pokefrost] {0}", (object) array.Length));
      foreach (MethodBase methodBase in array)
        methodBase.Invoke((object) null, (object[]) null);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.QuestSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public abstract class QuestSystem : GameSystem
  {
    public int progress = 0;
    public static string Key_GeneralFail = "websiteofsites.wildfrost.pokefrost.generalquestfailed";

    public virtual string ProgressName => "Quest";

    public virtual string GetFailureText(string key)
    {
      return LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).GetString(key).GetLocalizedString();
    }

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(QuestSystem.Key_GeneralFail, "Conditions not met...");
    }

    public virtual void UpdateProgress(int value)
    {
      this.progress = value;
      EventSaveSystem.Add(this.ProgressName, value);
    }

    public virtual void FindProgress()
    {
      int num = EventSaveSystem.Get(this.ProgressName);
      if (num != -1)
        this.progress = num;
      else
        this.UpdateProgress(this.progress);
    }

    public abstract bool CheckConditions(out string failureText);

    public virtual void QuestBattleStart()
    {
    }

    public virtual void QuestBattleFinish()
    {
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptableMissingHealth
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class ScriptableMissingHealth : ScriptableAmount
  {
    public override int Get(Entity entity)
    {
      return !(bool) (Object) entity ? 0 : entity.hp.max - entity.hp.current;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.PalafinHero
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class PalafinHero : ScriptableCardImage
  {
    public Image image;
    private bool shiny = false;
    private List<Sprite> sprites = new List<Sprite>()
    {
      AddressableExtMethods.ASprite("palafin"),
      AddressableExtMethods.ASprite("shiny_palafin"),
      AddressableExtMethods.ASprite("palafinhero"),
      AddressableExtMethods.ASprite("shiny_palafinhero")
    };

    public override void AssignEvent()
    {
      this.image.sprite = this.sprites[0];
      foreach (CardData.StatusEffectStacks startWithEffect in this.entity.data.startWithEffects)
      {
        if (startWithEffect.data.type == "shiny")
        {
          this.shiny = true;
          this.image.sprite = this.sprites[1];
          break;
        }
      }
      base.AssignEvent();
    }

    public override void UpdateEvent()
    {
      if (this.entity.traits.FirstOrDefault<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (t => t.data.name == "Hero")) != null)
        this.image.sprite = !this.shiny ? this.sprites[2] : this.sprites[3];
      base.UpdateEvent();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptReturnNode
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class ScriptReturnNode : Script
  {
    public override IEnumerator Run()
    {
      EventBattleManager.instance.ReturnNode();
      yield break;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.SpawnCressliaModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public class SpawnCressliaModifierSystem : QuestSystem
  {
    public override string ProgressName => "Dreams";

    public static string Key_Cresselia => "websiteofsites.wildfrost.pokefrost.cresseliaHurt";

    [PokeLocalizer]
    public new static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(SpawnCressliaModifierSystem.Key_Cresselia, "Cresselia is too injured...");
    }

    public void OnEnable()
    {
      global::Events.OnBattleStart += new UnityAction(this.Spawn);
      global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.CheckCresseliaAlive);
      this.FindProgress();
    }

    public void OnDisable()
    {
      global::Events.OnBattleStart -= new UnityAction(this.Spawn);
      global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.CheckCresseliaAlive);
    }

    private void CheckCresseliaAlive(Entity entity, DeathType deathType)
    {
      if (entity?.data?.name != "websiteofsites.wildfrost.pokefrost.quest_cresselia")
        return;
      foreach (Entity card in References.Battle.cards)
      {
        if (card?.data?.name == "websiteofsites.wildfrost.pokefrost.quest_cresselia" && card.IsAliveAndExists())
          return;
      }
      this.UpdateProgress(1);
    }

    private void Spawn()
    {
      if (this.progress != 0)
        return;
      this.StartCoroutine(this.TrueSpawn());
    }

    private IEnumerator TrueSpawn()
    {
      CardContainer slot = Battle.instance.GetRows(References.Player).RandomItem<CardContainer>();
      Debug.Log((object) "[Pokefrost] Got Slot");
      CardData data = Pokefrost.Pokefrost.instance.Get<CardData>("quest_cresselia").Clone();
      Debug.Log((object) "[Pokefrost] Got Data");
      Card card = CardManager.Get(data, References.Battle.playerCardController, References.Player, true, true);
      Debug.Log((object) "[Pokefrost] Got Card");
      card.entity.flipper.FlipDownInstant();
      card.transform.localPosition = new Vector3(-15f, 0.0f, 0.0f);
      yield return (object) card.UpdateData(false);
      slot.Add(card.entity);
      Debug.Log((object) "[Pokefrost] Added to Slot");
      slot.TweenChildPositions();
      ActionQueue.Add((PlayAction) new ActionReveal(card.entity));
      ActionQueue.Add((PlayAction) new ActionRunEnableEvent(card.entity));
      yield return (object) ActionQueue.Wait();
    }

    public override bool CheckConditions(out string failureText)
    {
      failureText = this.GetFailureText(SpawnCressliaModifierSystem.Key_Cresselia);
      Debug.Log((object) string.Format("[Pokefrost] Checking Progress... {0}", (object) this.progress));
      return this.progress == 0;
    }

    public override void QuestBattleFinish() => this.UpdateProgress(2);
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectAddAttackEffects
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectAddAttackEffects : StatusEffectData
  {
    public StatusEffectData effectToApply;
    public bool sameOwner = false;
    public bool includeSelf = true;
    public TargetConstraint[] attackerConstraints = new TargetConstraint[0];

    public override bool RunHitEvent(Hit hit)
    {
      if ((UnityEngine.Object) hit.attacker == (UnityEngine.Object) null || !Battle.IsOnBoard(hit.attacker) || (UnityEngine.Object) hit.target == (UnityEngine.Object) null || !hit.Offensive || !hit.BasicHit || this.sameOwner && (UnityEngine.Object) hit?.attacker?.owner != (UnityEngine.Object) this.target.owner || !this.includeSelf && (UnityEngine.Object) hit?.attacker == (UnityEngine.Object) this.target)
        return false;
      foreach (TargetConstraint targetConstraint in this.targetConstraints)
      {
        if (!targetConstraint.Check(hit.target))
          return false;
      }
      foreach (TargetConstraint attackerConstraint in this.attackerConstraints)
      {
        if (!attackerConstraint.Check(hit.attacker))
          return false;
      }
      CardData.StatusEffectStacks statusEffectStacks = (CardData.StatusEffectStacks) null;
      if (hit.statusEffects != null)
        statusEffectStacks = hit.statusEffects.FirstOrDefault<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => s.data?.name == this.effectToApply.name));
      if (statusEffectStacks == null)
        hit.AddStatusEffect(new CardData.StatusEffectStacks(this.effectToApply, this.GetAmount()));
      else
        statusEffectStacks.data.count += this.GetAmount();
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyRandomOnCardPlayed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyRandomOnCardPlayed : StatusEffectApplyXOnCardPlayed
  {
    public StatusEffectData[] effectsToapply = new StatusEffectData[0];

    public override void Init()
    {
      base.Init();
      global::Events.OnActionQueued += new UnityAction<PlayAction>(this.DetermineEffect);
    }

    public void OnDestory()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.DetermineEffect);
    }

    private void DetermineEffect(PlayAction arg)
    {
      this.effectToApply = this.effectsToapply[Random.Range(0, this.effectsToapply.Length)];
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnCardPlayedMaybe
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnCardPlayedMaybe : StatusEffectApplyXOnCardPlayed
  {
    public static readonly string Key_FailedFlip = "websiteofsites.wildfrost.pokefrost.failedflip";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectApplyXOnCardPlayedMaybe.Key_FailedFlip, "Better Luck Next Time!");
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if ((Object) entity != (Object) this.target)
        return false;
      int amount = this.GetAmount(entity);
      if (amount == 0)
        return false;
      int num = Dead.Random.Range(1, 100);
      if (amount >= num)
        return base.RunCardPlayedEvent(entity, targets);
      this.PopupText(entity, StatusEffectApplyXOnCardPlayedMaybe.Key_FailedFlip);
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnEffect
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnEffect : StatusEffectApplyX
  {
    [SerializeField]
    private bool postHit;
    public StatusEffectData conditionEffect;
    [Header("Modify Damage")]
    [SerializeField]
    private int addDamageFactor;
    [SerializeField]
    private float multiplyDamageFactor = 1f;
    private readonly List<Hit> storedHit = new List<Hit>();

    public override void Init()
    {
      if (this.postHit)
        this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
      else
        this.OnHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
    }

    public override bool RunPreAttackEvent(Hit hit)
    {
      if ((Object) hit.attacker == (Object) this.target && this.target.alive && this.target.enabled && (bool) (Object) hit.target)
      {
        if (this.addDamageFactor != 0 || (double) this.multiplyDamageFactor != 1.0)
        {
          bool flag = true;
          foreach (TargetConstraint applyConstraint in this.applyConstraints)
          {
            if (!applyConstraint.Check(hit.target) && (!(applyConstraint is TargetConstraintHasStatus constraintHasStatus) || !constraintHasStatus.CheckWillApply(hit)))
            {
              flag = false;
              break;
            }
          }
          if (flag)
          {
            int amount = this.GetAmount();
            if (this.addDamageFactor != 0)
              hit.damage += amount * this.addDamageFactor;
            if ((double) this.multiplyDamageFactor != 1.0)
              hit.damage = Mathf.RoundToInt((float) hit.damage * this.multiplyDamageFactor);
          }
        }
        if (!hit.Offensive && (hit.damage > 0 || (bool) (Object) this.effectToApply && this.effectToApply.offensive))
          hit.FlagAsOffensive();
        this.storedHit.Add(hit);
      }
      return false;
    }

    public override bool RunPostHitEvent(Hit hit) => this.storedHit.Contains(hit) && hit.Offensive;

    public override bool RunHitEvent(Hit hit) => this.storedHit.Contains(hit) && hit.Offensive;

    private IEnumerator CheckHit(Hit hit)
    {
      if ((bool) (Object) this.effectToApply)
      {
        foreach (StatusEffectData statusEffect in hit.attacker.statusEffects)
        {
          StatusEffectData status = statusEffect;
          if (status.name == this.conditionEffect.name)
          {
            yield return (object) this.Run(this.GetTargets(hit), status.count);
            break;
          }
          status = (StatusEffectData) null;
        }
        yield return (object) null;
      }
      this.storedHit.Remove(hit);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnHitOtherwiseY
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnHitOtherwiseY : StatusEffectApplyXOnHit
  {
    public StatusEffectData mainEffect;
    public StatusEffectData otherEffect;
    public TargetConstraint[] applyConstraints2;

    public override bool RunPreAttackEvent(Hit hit)
    {
      if ((Object) hit.attacker == (Object) this.target && this.target.alive && this.target.enabled && (bool) (Object) hit.target)
      {
        bool flag = true;
        foreach (TargetConstraint targetConstraint in this.applyConstraints2)
        {
          if (!targetConstraint.Check(hit.target) && (!(targetConstraint is TargetConstraintHasStatus constraintHasStatus) || !constraintHasStatus.CheckWillApply(hit)) && (!(targetConstraint is TargetConstraintHasNegativeStatus hasNegativeStatus) || !hasNegativeStatus.CheckWillApply(hit)))
          {
            flag = false;
            this.effectToApply = this.otherEffect;
            break;
          }
        }
        if (flag)
        {
          this.effectToApply = this.mainEffect;
          int amount = this.GetAmount();
          if (this.addDamageFactor != 0)
            hit.damage += amount * this.addDamageFactor;
          if ((double) this.multiplyDamageFactor != 1.0 && !this.target.silenced)
            hit.damage = Mathf.RoundToInt((float) hit.damage * this.multiplyDamageFactor);
        }
        if (!hit.Offensive && (hit.damage > 0 || (bool) (Object) this.effectToApply && this.effectToApply.offensive))
          hit.FlagAsOffensive();
        this.storedHit.Add(hit);
      }
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnRecall
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnRecall : StatusEffectApplyX
  {
    public bool once = false;

    public override void Init()
    {
      global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
    }

    public void OnDestroy()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.ActionQueued);
    }

    public void ActionQueued(PlayAction action)
    {
      if (!(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !(bool) (Object) this.target.owner || !actionMove.toContainers.Contains<CardContainer>(this.target.owner.discardContainer) || !Battle.IsOnBoard(actionMove.entity.containers))
        return;
      ActionQueue.Insert(ActionQueue.IndexOf(action), (PlayAction) new ActionSequence(this.Sequence()));
    }

    public IEnumerator Sequence()
    {
      yield return (object) this.Run(this.GetTargets());
      if (this.once)
      {
        yield return (object) this.Remove();
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage : 
    StatusEffectApplyXWhenAnyoneTakesDamage
  {
    public int damageAmount;

    public override bool RunPostHitEvent(Hit hit)
    {
      if (!this.target.enabled || !this.target.alive || !hit.Offensive || !(hit.damageType == this.targetDamageType))
        return false;
      this.damageAmount = hit.damage + hit.damageBlocked;
      return Battle.IsOnBoard(this.target);
    }

    public override int GetAmount(Entity entity, bool equalAmount = false, int equalTo = 0)
    {
      return this.damageAmount;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhenCertainCardPlayed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhenCertainCardPlayed : StatusEffectApplyXOnTurn
  {
    public string cardName = "";
    public bool useCardName = true;
    public string customDataKey = "";
    public bool useCustomData = false;

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if (this.turnTaken || !this.target.enabled || !this.DesiredCard(entity) || !Battle.IsOnBoard(this.target))
        return false;
      if (!this.trueOnTurn)
        return true;
      this.turnTaken = true;
      return false;
    }

    protected virtual bool DesiredCard(Entity entity)
    {
      if (this.useCardName)
        return entity?.data?.name == this.cardName;
      if (!this.useCustomData)
        return false;
      string str;
      this.target.data.TryGetCustomData<string>(this.customDataKey, out str, "");
      return entity?.data?.name == str;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhenDiscardedFixed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhenDiscardedFixed : StatusEffectApplyXWhenDiscarded
  {
    public void OnDestroy()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(((StatusEffectApplyXWhenDiscarded) this).ActionQueued);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhileStatused
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhileStatused : StatusEffectData
  {
    [SerializeField]
    public StatusEffectData effectToGain;
    public int currentAmount;
    public bool active;

    public override bool HasEnableRoutine => true;

    public override bool HasDisableRoutine => true;

    public override bool HasPostHitRoutine => true;

    public override bool HasTurnEndRoutine => true;

    public override bool RunEnableEvent(Entity entity) => (Object) entity == (Object) this.target;

    public override IEnumerator EnableRoutine(Entity entity) => this.Check();

    public override bool RunDisableEvent(Entity entity)
    {
      return (Object) entity == (Object) this.target && this.currentAmount != 0;
    }

    public override IEnumerator DisableRoutine(Entity entity) => this.Deactivate();

    public override bool RunPostHitEvent(Hit hit) => (Object) hit.target == (Object) this.target;

    public override IEnumerator PostHitRoutine(Hit hit) => this.Check();

    public override IEnumerator TurnEndRoutine(Entity entity) => this.Check();

    public IEnumerator Check()
    {
      if (this.target.alive)
      {
        bool flag = false;
        for (int num = this.target.statusEffects.Count - 1; num >= 0; --num)
        {
          StatusEffectData statusEffectData = this.target.statusEffects[num];
          if (statusEffectData.isStatus && statusEffectData.offensive && statusEffectData.visible)
          {
            flag = true;
            if (!this.active)
            {
              yield return (object) this.Activate();
              break;
            }
            break;
          }
          statusEffectData = (StatusEffectData) null;
        }
        if (this.active && !flag)
          yield return (object) this.Deactivate();
      }
    }

    public IEnumerator Activate()
    {
      this.currentAmount = this.GetAmount();
      yield return (object) StatusEffectSystem.Apply(this.target, this.target, this.effectToGain, this.currentAmount, true);
      this.active = true;
    }

    public IEnumerator Deactivate()
    {
      for (int num = this.target.statusEffects.Count - 1; num >= 0; --num)
      {
        StatusEffectData statusEffectData = this.target.statusEffects[num];
        if ((bool) (Object) statusEffectData && statusEffectData.name == this.effectToGain.name)
        {
          yield return (object) statusEffectData.RemoveStacks(this.currentAmount, true);
          break;
        }
        statusEffectData = (StatusEffectData) null;
      }
      this.currentAmount = 0;
      this.active = false;
    }

    public override bool RunEffectBonusChangedEvent()
    {
      if (this.target.enabled && this.active)
        ActionQueue.Add((PlayAction) new ActionSequence(this.ReAffect()));
      return false;
    }

    public IEnumerator ReAffect()
    {
      yield return (object) this.Deactivate();
      yield return (object) this.Activate();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectBecomeOvershroom
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectBecomeOvershroom : StatusEffectData
  {
    public override bool HasApplyStatusRoutine => true;

    public override IEnumerator ApplyStatusRoutine(StatusEffectApply apply)
    {
      Debug.Log((object) "[Test] ApplyStatusRoutine");
      int num;
      if (apply != null && (Object) apply.applier?.owner == (Object) this.target.owner)
      {
        StatusEffectData effectData = apply.effectData;
        if ((effectData != null ? (effectData.offensive ? 1 : 0) : 0) != 0)
        {
          num = apply?.effectData.name == "Overload" ? 1 : (apply?.effectData.name == "Shroom" ? 1 : 0);
          goto label_4;
        }
      }
      num = 0;
label_4:
      if (num != 0)
      {
        Debug.Log((object) "[Test] found overload");
        apply.effectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", "Overshroom");
      }
      return (IEnumerator) null;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectBurning
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectBurning : StatusEffectData
  {
    public CardAnimation buildupAnimation;
    public bool burning;

    public override void Init() => global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);

    public void OnDestroy() => global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);

    public void EntityHit(Hit hit)
    {
      if (!((Object) hit.target == (Object) this.target) || !hit.Offensive || !hit.canRetaliate || !hit.countsAsHit)
        return;
      this.Check();
    }

    public void Check()
    {
      if (this.count <= 0 || this.burning)
        return;
      ActionSequence action1 = new ActionSequence(this.DealDamage());
      action1.fixedPosition = true;
      action1.priority = this.eventPriority;
      action1.note = "Burned";
      ActionQueue.Stack((PlayAction) action1);
      ActionSequence action2 = new ActionSequence(this.Clear());
      action2.fixedPosition = true;
      action2.priority = this.eventPriority;
      action2.note = "Clear Burns";
      ActionQueue.Stack((PlayAction) action2);
      this.burning = true;
    }

    public IEnumerator DealDamage()
    {
      if ((bool) (Object) this && (bool) (Object) this.target && this.target.alive)
      {
        HashSet<Entity> targets = new HashSet<Entity>();
        CardContainer[] cardContainerArray = this.target.containers;
        for (int index = 0; index < cardContainerArray.Length; ++index)
        {
          CardContainer collection = cardContainerArray[index];
          targets.AddRange<Entity>((IEnumerable<Entity>) collection);
          collection = (CardContainer) null;
        }
        cardContainerArray = (CardContainer[]) null;
        if ((bool) (Object) this.buildupAnimation)
          yield return (object) this.buildupAnimation.Routine((object) this.target);
        Entity damager = this.GetDamager();
        Routine.Clump clump = new Routine.Clump();
        foreach (Entity item in targets)
        {
          Hit hit = new Hit(damager, item, this.count)
          {
            damageType = "burning",
            canRetaliate = false
          };
          clump.Add(hit.Process());
          Pokefrost.Pokefrost.fx.TryPlayEffect("burntei", item.transform.position, item.transform.lossyScale);
          hit = (Hit) null;
        }
        SfxSystem.OneShot("event:/sfx/status/overburn_damage");
        clump.Add(Sequences.Wait(0.5f));
        yield return (object) clump.WaitForEnd();
      }
    }

    public IEnumerator Clear()
    {
      if ((bool) (Object) this && (bool) (Object) this.target && this.target.alive)
      {
        yield return (object) this.Remove();
        this.burning = false;
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectConvertEffects
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectConvertEffects : StatusEffectInstant
  {
    public string effectA = "";
    public string effectB = "";
    public bool swap = false;
    protected int stackA = 0;
    protected int stackB = 0;

    public override IEnumerator Process()
    {
      Routine.Clump clump = new Routine.Clump();
      for (int i = this.target.statusEffects.Count - 1; i >= 0; --i)
      {
        if (this.target.statusEffects[i]?.name == this.effectA)
        {
          this.stackA = this.target.statusEffects[i].count;
          clump.Add(this.target.statusEffects[i].Remove());
        }
        if (this.swap && this.target.statusEffects[i]?.name == this.effectB)
        {
          this.stackB = this.target.statusEffects[i].count;
          clump.Add(this.target.statusEffects[i].Remove());
        }
      }
      yield return (object) clump.WaitForEnd();
      if (this.stackA > 0)
        clump.Add(StatusEffectSystem.Apply(this.target, this.applier, Pokefrost.Pokefrost.instance.Get<StatusEffectData>(this.effectB), this.stackA));
      if (this.swap && this.stackB > 0)
        clump.Add(StatusEffectSystem.Apply(this.target, this.applier, Pokefrost.Pokefrost.instance.Get<StatusEffectData>(this.effectA), this.stackB));
      yield return (object) clump.WaitForEnd();
      yield return (object) base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectDreamDummy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class StatusEffectDreamDummy : StatusEffectData
  {
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectDummy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectDummy : StatusEffectData
  {
    public bool dummy = true;
    public string truename = string.Empty;

    public override void Init()
    {
      this.temporary = 99;
      this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.Decrease);
    }

    public IEnumerator Decrease(Entity entity)
    {
      int amount = 1;
      Events.InvokeStatusEffectCountDown((StatusEffectData) this, ref amount);
      if (amount != 0)
        yield return (object) this.CountDown(entity, amount);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectDuplicateEffect
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectDuplicateEffect : StatusEffectApplyX
  {
    private int chain = 0;
    private int maxChain = 3;
    private Dictionary<string, Vector2Int> amounts = new Dictionary<string, Vector2Int>();
    public StatusEffectApplyX.ApplyToFlags whenAppliedFlags;
    public bool debuffsOnly = false;
    public bool instantCustom = false;

    public override void Init()
    {
      this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Copy);
    }

    public override bool RunApplyStatusEvent(StatusEffectApply apply)
    {
      if (!(bool) (UnityEngine.Object) apply.applier || (UnityEngine.Object) apply.applier == (UnityEngine.Object) this.target || !(bool) (UnityEngine.Object) apply.target || !(bool) (UnityEngine.Object) apply.effectData || apply.effectData.type.IsNullOrWhitespace() || this.target.silenced || (!apply.effectData.isStatus || !apply.effectData.offensive || !apply.effectData.visible) && this.debuffsOnly || !this.GetAppliedTargets().Contains(apply.target))
        return false;
      this.amounts[apply.effectData.type] = this.CurrentAmounts(apply.target, apply.effectData.type);
      Debug.Log((object) ("[Pokefrost] " + apply.effectData.type));
      return false;
    }

    public List<Entity> GetAppliedTargets()
    {
      StatusEffectApplyX.ApplyToFlags applyToFlags = this.applyToFlags;
      this.applyToFlags = this.whenAppliedFlags;
      List<Entity> targets = this.GetTargets();
      this.applyToFlags = applyToFlags;
      return targets;
    }

    private IEnumerator Copy(StatusEffectApply apply)
    {
      ++this.chain;
      if (this.chain != this.maxChain)
      {
        StatusEffectApplyXInstant effect;
        int num;
        if (this.instantCustom)
        {
          effect = this.effectToApply as StatusEffectApplyXInstant;
          num = effect != null ? 1 : 0;
        }
        else
          num = 0;
        if (num != 0)
          effect.effectToApply = apply.effectData;
        else
          this.effectToApply = apply.effectData;
        yield return (object) this.Run(this.GetTargets(), apply.count);
        this.chain = 0;
      }
    }

    public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
    {
      Vector2Int vector2Int1;
      if (!(bool) (UnityEngine.Object) apply.applier || (UnityEngine.Object) apply.applier == (UnityEngine.Object) this.target || !(bool) (UnityEngine.Object) apply.target || !(bool) (UnityEngine.Object) apply.effectData || apply.effectData.type.IsNullOrWhitespace() || this.target.silenced || !this.GetAppliedTargets().Contains(apply.target) || !this.amounts.TryGetValue(apply.effectData.type, out vector2Int1))
        return false;
      Vector2Int vector2Int2 = this.CurrentAmounts(apply.target, apply.effectData.type);
      if (vector2Int2.x - vector2Int1.x - (vector2Int2.y - vector2Int1.y) <= 0 && vector2Int2.x - vector2Int1.x != 0)
        return false;
      this.amounts.Remove(apply.effectData.type);
      return true;
    }

    protected Vector2Int CurrentAmounts(Entity frontAlly, string effectType)
    {
      StatusEffectData statusEffectData = frontAlly.statusEffects.FirstOrDefault<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.type == effectType));
      return (UnityEngine.Object) statusEffectData == (UnityEngine.Object) null ? Vector2Int.zero : new Vector2Int(statusEffectData.count, statusEffectData.temporary);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveChingling
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveChingling : StatusEffectEvolveFromNode
  {
    public override bool NodeVisit(string nodeName, CardData cardData)
    {
      GameObject gameObject = GameObject.Find("Canvas/Padding/HUD/ModifierIcons");
      if ((Object) gameObject != (Object) null)
      {
        this.count = 0;
        foreach (Object allChild in gameObject.transform.GetAllChildren())
        {
          if (allChild.name == "BellModifierIcon(Clone)")
            ++this.count;
        }
        foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
        {
          if (startWithEffect.data.name == this.name)
            return startWithEffect.count <= this.count;
        }
      }
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveCubone
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveCubone : StatusEffectEvolveFromKill
  {
    public string normalEvolution;
    public string sacEvolution;

    public override void Init() => base.Init();

    public void SetEvolutions(string normal, string sac)
    {
      this.evolutionCardName = normal;
      this.normalEvolution = normal;
      this.sacEvolution = sac;
    }

    public override bool RunBeginEvent()
    {
      this.anyKill = true;
      this.constraint = (Func<Entity, DeathType, bool>) ((entity, death) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target);
      return false;
    }

    public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
    {
      if (this.count > 0)
      {
        base.RunEntityDestroyedEvent(entity, deathType);
        if (this.count == 0 && ((UnityEngine.Object) entity?.lastHit?.attacker?.owner == (UnityEngine.Object) this.target.owner || deathType == DeathType.Sacrifice))
          this.FindDeckCopy((Action<CardData, CardData.StatusEffectStacks>) ((card, status) => status.count = 2));
      }
      return false;
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data.name == this.name && (startWithEffect.count == 0 || startWithEffect.count == 2))
          return true;
      }
      return false;
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in preEvo.startWithEffects)
      {
        if (startWithEffect.data.name == this.name && startWithEffect.count == 2)
        {
          this.evolutionCardName = this.sacEvolution;
          base.Evolve(mod, preEvo);
          return;
        }
      }
      this.evolutionCardName = this.normalEvolution;
      base.Evolve(mod, preEvo);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveEevee
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveEevee : StatusEffectEvolve
  {
    public static Dictionary<string, string> upgradeMap = new Dictionary<string, string>();
    private string flareon = nameof (flareon);
    private string vaporeon = nameof (vaporeon);
    private string jolteon = nameof (jolteon);
    private string espeon = nameof (espeon);
    private string umbreon = nameof (umbreon);
    private string glaceon = nameof (glaceon);
    private string leafeon = nameof (leafeon);
    private string sylveon = nameof (sylveon);
    public static readonly string[] eeveelutions = new string[8]
    {
      nameof (flareon),
      nameof (vaporeon),
      nameof (jolteon),
      nameof (espeon),
      nameof (umbreon),
      nameof (glaceon),
      nameof (leafeon),
      nameof (sylveon)
    };

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      if (StatusEffectEvolveEevee.upgradeMap.ContainsKey("CardUpgradeOverload"))
        return;
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeOverload", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSpice", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBattle", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBombskull", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFlameberry", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeInk", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFury", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBlock", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeRemoveCharmLimit", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSpark", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeDraw", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFrenzyReduceAttack", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeWildcard", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeGlass", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("websiteofsites.wildfrost.pokefrost.CardUpgradeMagnemite", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBalanced", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBom", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBoost", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSun", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBootleg", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeGreed", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeTeethWhenHit", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSpiky", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeDemonize", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("websiteofsites.wildfrost.pokefrost.CardUpgradePluck", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSnowball", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFrosthand", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSnowImmune", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeAttackIncreaseCounter", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBlue", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeAcorn", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeShellOnKill", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeShroom", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeShroomReduceHealth", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradePlink", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeAttackAndHealth", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeHeart", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeCloudberry", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradePig", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeHeartmist", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("absentabigail.wildfrost.blahaj.CardUpgradeShark", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("bethanw10.wildfrost.allcharms.CardUpgradeMakoko", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("bethanw10.wildfrost.allcharms.CardUpgradeScales", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("bethanw10.wildfrost.allcharms.CardUpgradeShadeHeart", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("greenranger.wildfrost.devilcharm.CardUpgradeDevil", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("greenranger.wildfrost.basketcharm.CardUpgradeCleanse", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("kopie.wildfrost.charmscollection.charm_speed", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("semmiesem9.wildfrost.hatsunemiku.BobaCharm", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.CrystalShardCharm", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.SnowFlowerCharm", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.LuminiceCharm", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.BarrierCharm", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.OrangeCharm", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("vibeneutral.wildfrost.hollowfrost.focuscharm", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("vibeneutral.wildfrost.hollowfrost.grimmcharm", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("vibeneutral.wildfrost.hollowfrost.defendercharm", this.umbreon);
      this.type = "evolve2";
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardUpgradeData upgrade in cardData.upgrades)
      {
        if (upgrade.type == CardUpgradeData.Type.Charm)
          return true;
      }
      return false;
    }

    private void FindEvolution(CardData carddata)
    {
      foreach (CardUpgradeData upgrade in carddata.upgrades)
      {
        if (upgrade.type == CardUpgradeData.Type.Charm)
        {
          if (StatusEffectEvolveEevee.upgradeMap.ContainsKey(upgrade.name))
          {
            this.evolutionCardName = StatusEffectEvolveEevee.upgradeMap[upgrade.name];
          }
          else
          {
            Debug.Log((object) "[Pokefrost] Unrecognized/neutral charm: randomizing evolution.");
            int index = UnityEngine.Random.Range(0, 7);
            this.evolutionCardName = StatusEffectEvolveEevee.eeveelutions[index];
          }
          Debug.Log((object) ("[Pokefrost] Evolving into " + this.evolutionCardName));
        }
      }
    }

    public override CardData[] EvolveForFinalBoss(WildfrostMod mod)
    {
      return ((IEnumerable<string>) StatusEffectEvolveEevee.eeveelutions).Select<string, CardData>((Func<string, CardData>) (s => mod.Get<CardData>(s))).ToArray<CardData>();
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      this.FindEvolution(preEvo);
      this.evolutionCardName = Extensions.PrefixGUID(this.evolutionCardName, mod);
      Debug.Log((object) ("[Pokefrost] " + this.evolutionCardName));
      base.Evolve(mod, preEvo);
    }

    public enum eeveeEnum
    {
      Flareon,
      Vaporeon,
      Jolteon,
      Espeon,
      Umbreon,
      Glaceon,
      Leafeon,
      Sylveon,
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromCardPickup
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveFromCardPickup : StatusEffectEvolve
  {
    public virtual string CardName => "";

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve4";
    }

    public virtual bool CardSelected(CardData self, Entity selectedCard)
    {
      return selectedCard.data.name == this.CardName;
    }

    public static void CheckEvolveFromSelect(ShopItem item)
    {
      Entity componentInChildren = item.GetComponentInChildren<Entity>();
      if (!((UnityEngine.Object) componentInChildren != (UnityEngine.Object) null))
        return;
      StatusEffectEvolveFromCardPickup.CheckEvolveFromSelect(componentInChildren);
    }

    public static void CheckEvolveFromSelect(Entity entity)
    {
      if ((UnityEngine.Object) References.Player?.data?.inventory == (UnityEngine.Object) null)
        return;
      int num;
      if (entity.data.TryGetCustomData<int>("Future Sight ID", out num, -1))
        CardScriptForsee.ids.Add(num);
      StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromCardPickup>(References.PlayerData.inventory.deck, "evolve4", (Func<StatusEffectEvolveFromCardPickup, CardData, bool>) ((s, c) => s.CardSelected(c, entity)));
      StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromCardPickup>(References.PlayerData.inventory.reserve, "evolve4", (Func<StatusEffectEvolveFromCardPickup, CardData, bool>) ((s, c) => s.CardSelected(c, entity)));
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count <= 0)
        return;
      MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.DelayedRun());
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromNode
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveFromNode : StatusEffectEvolve
  {
    public string targetNodeName = "Salty Spicelands";
    public bool readyToEvolve = false;

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve3";
    }

    public virtual bool NodeVisit(string nodeName, CardData cardData)
    {
      return nodeName == this.targetNodeName;
    }

    public override bool ReadyToEvolve(CardData cardData) => false;

    [HarmonyPatch(typeof (CampaignNode), "SetCleared")]
    internal static class AfterNodeCleared
    {
      internal static void Prefix(CampaignNode __instance)
      {
        StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromNode>(References.Player.data.inventory.deck, "evolve3", (Func<StatusEffectEvolveFromNode, CardData, bool>) ((s, c) => s.NodeVisit(__instance.name, c)));
        StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromNode>(References.Player.data.inventory.reserve, "evolve3", (Func<StatusEffectEvolveFromNode, CardData, bool>) ((s, c) => s.NodeVisit(__instance.name, c)));
        if (EvolutionPopUp.evolvedPokemonLastBattle.Count <= 0)
          return;
        MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.DelayedRun());
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveNatu
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveNatu : StatusEffectEvolveFromCardPickup
  {
    public override bool CardSelected(CardData self, Entity selectedCard)
    {
      string str;
      self.TryGetCustomData<string>("Future Sight", out str, this.CardName);
      return str == selectedCard.data.name;
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      base.Evolve(mod, preEvo);
      CardData cardData1 = EvolutionPopUp.pokemonEvolvedIntoLastBattle.Last<CardData>();
      CardData cardData2 = EvolutionPopUp.evolvedPokemonLastBattle.Last<CardData>();
      if (!cardData1.name.Contains("xatu") || !cardData2.name.Contains("natu"))
        return;
      string str;
      cardData2.TryGetCustomData<string>("Future Sight", out str, this.CardName);
      cardData1.SetCustomData("Future Sight", (object) str);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveSlowpoke
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveSlowpoke : StatusEffectEvolveFromNode
  {
    public string evolveUncrowned = "slowbro";
    public string evolveCrowned = "slowking";

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.evolutionCardName = "slowking";
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      if (preEvo.HasCrown)
      {
        this.evolutionCardName = this.evolveCrowned;
        References.Player.data.inventory.upgrades.Add(mod.Get<CardUpgradeData>("CrownSlowking"));
      }
      else
        this.evolutionCardName = this.evolveUncrowned;
      base.Evolve(mod, preEvo);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectFalseSwipe
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectFalseSwipe : StatusEffectData
  {
    public override void Init()
    {
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    }

    public override bool RunHitEvent(Hit hit)
    {
      if (!((Object) hit.attacker == (Object) this.target) || this.target.silenced)
        return false;
      Debug.Log((object) "attacking");
      return hit.damage >= hit.target.hp.current;
    }

    public IEnumerator Check(Hit hit)
    {
      while (hit.damage >= hit.target.hp.current && hit.target.hp.current > 0)
      {
        --hit.damage;
        ++hit.damageBlocked;
      }
      this.target.PromptUpdate();
      yield return (object) true;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectFreeTrait
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific Effects/Temporary Trait", fileName = "Temporary Trait")]
public class StatusEffectFreeTrait : StatusEffectData
{
  [SerializeField]
  public TraitData trait;
  public List<Entity.TraitStacks> silenced;
  public Entity.TraitStacks added;
  public int addedAmount;

  public override bool HasStackRoutine => true;

  public override bool HasEndRoutine => true;

  public override bool Instant => true;

  public override IEnumerator StackRoutine(int stacks)
  {
    this.added = this.target.GainTrait(this.trait, stacks, true);
    yield return (object) this.target.UpdateTraits();
    this.addedAmount += stacks;
    this.target.display.promptUpdateDescription = true;
    this.target.PromptUpdate();
  }

  public override IEnumerator EndRoutine()
  {
    if ((bool) (Object) this.target)
    {
      if (this.added != null)
      {
        this.added.count -= this.addedAmount;
        this.added.tempCount -= this.addedAmount;
      }
      this.addedAmount = 0;
      yield return (object) this.target.UpdateTraits(this.added);
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectGiveDreamCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectGiveDreamCard : StatusEffectApplyX
  {
    public override void Init()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.GiveCard);
      this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.GiveCard2);
      base.Init();
    }

    public override bool RunCardMoveEvent(Entity entity)
    {
      return (Object) entity == (Object) this.target && StatusEffectGiveDreamCard.WasMovedOnToBoard(entity);
    }

    private IEnumerator GiveCard2(Entity entity) => this.Run(this.GetTargets());

    private void OnDestroy()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.GiveCard);
    }

    private void GiveCard(RedrawBellSystem arg0)
    {
      if (!Battle.IsOnBoard(this.target))
        return;
      ActionQueue.Add((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
    }

    public static bool WasMovedOnToBoard(Entity entity)
    {
      return Battle.IsOnBoard(entity) && !Battle.IsOnBoard(entity.preContainers);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectImmuneToDamage
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectImmuneToDamage : StatusEffectData
  {
    public List<string> immuneTypes;
    public bool reverse = false;
    public bool invis = false;
    public float invisFadeIn = 0.2f;
    public float invisFadeOut = 0.8f;
    protected Hit invisHit;
    public bool ignoreReactions;

    public override void Init()
    {
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
      if (!this.invis)
        return;
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Invisible);
    }

    private IEnumerator Invisible(Hit hit)
    {
      this.invisHit = hit;
      yield return (object) this.Fade(1f, 0.5f, this.invisFadeIn);
    }

    public override bool RunHitEvent(Hit hit)
    {
      if ((UnityEngine.Object) hit.target == (UnityEngine.Object) this.target && hit.Offensive && hit.canBeNullified && !this.target.silenced)
      {
        Debug.Log((object) hit.damageType);
        if (this.reverse ^ this.immuneTypes.Contains(hit.damageType))
        {
          Debug.Log((object) "here");
          SfxSystem.OneShot("event:/sfx/status_icon/block_decrease");
          hit.damageBlocked = hit.damage;
          hit.damage = 0;
          this.target.PromptUpdate();
        }
      }
      if (!((UnityEngine.Object) hit.attacker == (UnityEngine.Object) this.target) || !this.ignoreReactions)
        return false;
      hit.canRetaliate = false;
      return this.invis;
    }

    public override bool RunPostHitEvent(Hit hit)
    {
      if (this.invis && hit == this.invisHit)
        this.target.StartCoroutine(this.Fade(0.5f, 1f, this.invisFadeOut));
      return false;
    }

    private IEnumerator Check(Hit hit)
    {
      if (!this.target.silenced)
      {
        Debug.Log((object) "here");
        SfxSystem.OneShot("event:/sfx/status_icon/block_decrease");
        hit.damageBlocked = hit.damage;
        hit.damage = 0;
        this.target.PromptUpdate();
        yield break;
      }
    }

    private IEnumerator Fade(float start, float end, float dur)
    {
      LeanTween.value(this.target.gameObject, start, end, dur).setEase(LeanTweenType.easeOutQuad).setOnUpdate(new Action<float>(this.UpdateFade));
      yield return (object) dur;
    }

    private void UpdateFade(float alpha) => (this.target.display as Card).canvasGroup.alpha = alpha;
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectIncreaseAttackBasedOnCardsDrawnThisTurn
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectIncreaseAttackBasedOnCardsDrawnThisTurn : StatusEffectData
  {
    [SerializeField]
    public StatusEffectData effectToGain;
    public int currentAmount;
    public int amount;
    public int newAmount;
    public int cardsDrawn;

    public override bool HasTurnEndRoutine => true;

    public override bool HasActionPerformedRoutine => true;

    public override void Init()
    {
      global::Events.OnCardDraw += new UnityAction<int>(this.HowManyCardsDrawn);
      base.Init();
    }

    public void OnDestroy() => global::Events.OnCardDraw -= new UnityAction<int>(this.HowManyCardsDrawn);

    public void HowManyCardsDrawn(int arg)
    {
      this.cardsDrawn = Math.Min(arg, References.Player.drawContainer.Count);
      this.target.StartCoroutine(this.Activate(this.cardsDrawn));
    }

    public override IEnumerator ActionPerformedRoutine(PlayAction action)
    {
      yield break;
    }

    public override IEnumerator TurnEndRoutine(Entity entity)
    {
      if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target)
        yield return (object) this.Deactivate();
    }

    public IEnumerator Activate(int arg)
    {
      Debug.Log((object) "[Sneasel] Activate");
      Debug.Log((object) arg.ToString());
      this.amount = this.GetAmount() * arg;
      this.currentAmount += this.amount;
      this.cardsDrawn = 0;
      Debug.Log((object) ("[Sneasel] Gains " + this.amount.ToString() + " attack"));
      yield return (object) StatusEffectSystem.Apply(this.target, this.target, this.effectToGain, this.amount, true);
    }

    public IEnumerator Deactivate()
    {
      Debug.Log((object) "[Sneasel] Decactivate");
      for (int num = this.target.statusEffects.Count - 1; num >= 0; --num)
      {
        StatusEffectData statusEffectData = this.target.statusEffects[num];
        if ((bool) (UnityEngine.Object) statusEffectData && statusEffectData.name == this.effectToGain.name)
        {
          yield return (object) statusEffectData.RemoveStacks(this.currentAmount, true);
          break;
        }
        statusEffectData = (StatusEffectData) null;
      }
      this.currentAmount = 0;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantAddDeck
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantAddDeck : StatusEffectInstant
  {
    public CardData card;

    public override IEnumerator Process()
    {
      References.Player.data.inventory.deck.Add(this.card.Clone());
      yield return (object) base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantApplyXCardInDeck
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantApplyXCardInDeck : StatusEffectInstantApplyEffect
  {
    public TargetConstraint[] constraints;

    public override IEnumerator Process()
    {
      CardDataList deck = References.PlayerData.inventory.deck;
      List<CardData> cards = deck.InRandomOrder<CardData>().ToList<CardData>();
      foreach (CardData card in cards)
      {
        Debug.Log((object) ("[Pokefrost] " + card.title));
        if (this.SatisfiesConstraints(card))
        {
          Debug.Log((object) ("[Pokefrost] Upgrading " + card.title));
          card.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) card.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
          {
            new CardData.StatusEffectStacks(this.effectToApply, this.GetAmount())
          });
          foreach (Entity entity in Battle.GetAllCards())
          {
            if ((long) entity.data.id == (long) card.id)
              yield return (object) StatusEffectSystem.Apply(entity, this.target, this.effectToApply, this.GetAmount());
          }
          break;
        }
      }
      yield return (object) this.Remove();
    }

    public bool SatisfiesConstraints(CardData data)
    {
      foreach (TargetConstraint constraint in this.constraints)
      {
        if (!constraint.Check(data))
          return false;
      }
      return true;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantFullHeal
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantFullHeal : StatusEffectInstant
  {
    [SerializeField]
    public bool doPing = true;

    public override IEnumerator Process()
    {
      if (this.target.alive)
      {
        if (this.doPing)
        {
          CurveAnimator curveAnimator = this.target.curveAnimator;
          if (curveAnimator != null)
          {
            double num = (double) curveAnimator.Ping();
          }
        }
        Hit hit = new Hit(this.applier, this.target, -this.target.hp.max + this.target.hp.current);
        yield return (object) hit.Process();
        hit = (Hit) null;
      }
      yield return (object) base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantHitRedrawBell
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantHitRedrawBell : StatusEffectInstant
  {
    public override IEnumerator Process()
    {
      RedrawBellSystem objectOfType1 = Object.FindObjectOfType<RedrawBellSystem>();
      Debug.Log((object) "Got bell");
      if ((Object) objectOfType1 == (Object) null || (Object) objectOfType1.controller == (Object) null)
      {
        NoTargetTextSystem objectOfType2 = Object.FindObjectOfType<NoTargetTextSystem>();
        if ((Object) objectOfType2 != (Object) null)
        {
          objectOfType2.textElement.text = "No Bell To Hit!";
          objectOfType2.PopText(this.target.transform.position);
        }
        return base.Process();
      }
      int handSize = Events.GetHandSize(References.PlayerData.handSize);
      ActionRedraw action = new ActionRedraw(objectOfType1.owner, handSize);
      if (Events.CheckAction((PlayAction) action))
      {
        ActionQueue.Add((PlayAction) action);
        objectOfType1.controller.Disable();
        objectOfType1.reset = !objectOfType1.IsCharged;
        Events.InvokeRedrawBellHit(objectOfType1);
        SfxSystem.OneShot("event:/sfx/inventory/redraw_bell_use");
        objectOfType1.SetCounter(objectOfType1.counter.max);
        objectOfType1.AnimatorTrigger("Ring");
        Events.InvokeScreenShake();
        Events.InvokeUINavigationReset();
        objectOfType1.hitParticleSystem.Play();
      }
      return base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantRemoveCounter
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantRemoveCounter : StatusEffectInstant
  {
    public int cCount = 99;

    public override IEnumerator Process()
    {
      this.target.counter.current = this.cCount;
      this.target.counter.max = this.cCount;
      for (int j = this.target.statusEffects.Count - 1; j >= 0; --j)
      {
        if (this.target.statusEffects[j].HasDescOrIsKeyword && this.target.statusEffects[j].GetType() == typeof (StatusEffectWhileActiveX))
        {
          StatusEffectWhileActiveX activeEff = this.target.statusEffects[j] as StatusEffectWhileActiveX;
          if (activeEff.active)
            yield return (object) activeEff.Deactivate();
          activeEff = (StatusEffectWhileActiveX) null;
        }
        yield return (object) this.target.statusEffects[j].Remove();
      }
      this.target.attackEffects = new List<CardData.StatusEffectStacks>();
      this.target.traits.Clear();
      this.target.PromptUpdate();
      yield return (object) base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantReturnToHand
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantReturnToHand : StatusEffectInstant
  {
    public static readonly string Key_Leader = "websiteofsites.wildfrost.pokefrost.leader";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectInstantReturnToHand.Key_Leader, "Leader Cannot Be In Hand!");
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public override IEnumerator Process()
    {
      if ((Object) this.target.owner != (Object) References.Player)
      {
        yield return (object) base.Process();
      }
      else
      {
        if (this.target.data.cardType.name == "Leader")
        {
          this.PopupText(this.target, StatusEffectInstantReturnToHand.Key_Leader);
        }
        else
        {
          CardContainer hand = References.Player.handContainer;
          if ((Object) hand != (Object) null)
            yield return (object) Sequences.CardMove(this.target, new CardContainer[1]
            {
              hand
            });
          hand = (CardContainer) null;
        }
        yield return (object) base.Process();
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectJolted
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectJolted : StatusEffectData
  {
    public override void Init()
    {
      this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      return (Object) entity == (Object) this.target;
    }

    public IEnumerator Check(Entity entity, Entity[] targets)
    {
      Hit hit2 = new Hit(entity, entity, this.count)
      {
        canRetaliate = false,
        damageType = "jolt"
      };
      Pokefrost.Pokefrost.fx.TryPlayEffect("jolt", this.target.transform.position, 0.5f * this.target.transform.lossyScale);
      Pokefrost.Pokefrost.fx.TryPlaySound("jolt");
      double num = (double) this.target.curveAnimator.Ping();
      yield return (object) new WaitForSeconds(0.25f);
      yield return (object) hit2.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectMoveCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectMoveCard : StatusEffectInstant
  {
    public StatusEffectMoveCard.Containers toWhere = StatusEffectMoveCard.Containers.Discard;

    public virtual CardContainer GetContainer()
    {
      if (this.toWhere == StatusEffectMoveCard.Containers.Hand || this.toWhere == StatusEffectMoveCard.Containers.Draw)
        return References.Player.handContainer;
      if (this.toWhere == StatusEffectMoveCard.Containers.Discard)
        return References.Player.discardContainer;
      throw new Exception("Did you forget to declare a container when building the StatusEffect?");
    }

    public override IEnumerator Process()
    {
      yield return (object) Sequences.CardMove(this.target, new CardContainer[1]
      {
        this.GetContainer()
      });
      CardContainer[] cardContainerArray = this.target.preContainers;
      for (int index = 0; index < cardContainerArray.Length; ++index)
      {
        CardContainer c = cardContainerArray[index];
        c.TweenChildPositions();
        c = (CardContainer) null;
      }
      cardContainerArray = (CardContainer[]) null;
      yield return (object) base.Process();
    }

    public enum Containers
    {
      Hand,
      Draw,
      Discard,
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveNincada
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveNincada : StatusEffectEvolve
  {
    public string shedinjaMask = "websiteofsites.wildfrost.pokefrost.shedinjamask";

    public override bool ReadyToEvolve(CardData cardData)
    {
      CardData.StatusEffectStacks statusEffectStacks = ((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects).FirstOrDefault<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => (UnityEngine.Object) s?.data == (UnityEngine.Object) this));
      if (statusEffectStacks != null)
        statusEffectStacks.count = Math.Max(0, statusEffectStacks.count - 1);
      return base.ReadyToEvolve(cardData);
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      CardData data = mod.Get<CardData>(this.shedinjaMask).Clone();
      References.PlayerData.inventory.deck.Add(data);
      Events.InvokeEntityShowUnlocked(CardManager.Get(data, (CardController) null, References.Player, false, true).entity);
      base.Evolve(mod, preEvo);
      EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(data);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectOvershroom
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectOvershroom : StatusEffectData
  {
    [SerializeField]
    public CardAnimation buildupAnimation;
    public bool overloading;
    public bool subbed;
    public bool primed;
    public StatusEffectData dummy1;
    public StatusEffectData dummy2;
    public StatusEffectData dummy3;
    private string[] types = new string[2]
    {
      "Shroom",
      "Overload"
    };

    public override void Init()
    {
      this.OnStack += new StatusEffectData.EffectStackEventHandler(this.Stack);
      global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
      this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.DealDamage);
      global::Events.OnPostProcessUnits += new UnityAction<Character>(this.Prime);
      this.subbed = true;
    }

    public void OnDestroy()
    {
      global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
      this.Unsub();
    }

    public void EntityDisplayUpdated(Entity entity)
    {
      if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || !this.target.enabled)
        return;
      this.Check();
    }

    public IEnumerator Stack(int stacks)
    {
      bool flag = true;
      List<StatusEffectData> effectstoremove = new List<StatusEffectData>();
      foreach (StatusEffectData effect in this.target.statusEffects)
      {
        if (this.types.Contains<string>(effect.name) && effect.offensive)
        {
          this.count += effect.count;
          stacks += effect.count;
          effectstoremove.Add(effect);
        }
      }
      foreach (StatusEffectData effect in effectstoremove)
        yield return (object) effect.RemoveStacks(effect.count, false);
      Routine.Clump clump = new Routine.Clump();
      clump.Add(StatusEffectSystem.Apply(this.target, this.applier, this.dummy1, stacks, applyEvenIfZero: true));
      clump.Add(StatusEffectSystem.Apply(this.target, this.applier, this.dummy2, stacks, applyEvenIfZero: true));
      yield return (object) clump.WaitForEnd();
      int shroomDiff = 0;
      int overDiff = 0;
      StatusEffectData shroom = (StatusEffectData) null;
      StatusEffectData overload = (StatusEffectData) null;
      foreach (StatusEffectData effect in this.target.statusEffects)
      {
        if (!effect.offensive && effect.count != this.count)
        {
          if (effect.name == "Shroom")
            shroomDiff = effect.count - this.count;
          if (effect.name == "Overload")
            overDiff = effect.count - this.count;
        }
      }
      this.count = Math.Max(0, this.count + shroomDiff + overDiff);
      if ((bool) (UnityEngine.Object) shroom)
        shroom.count = this.count;
      if ((bool) (UnityEngine.Object) overload)
        overload.count = this.count;
      this.Check();
      yield return (object) null;
    }

    public void Check()
    {
      if (this.count < this.target.hp.current || this.overloading)
        return;
      ActionSequence action1 = new ActionSequence(this.DealDamage(this.count));
      action1.fixedPosition = true;
      action1.priority = this.eventPriority;
      action1.note = "Overload";
      ActionQueue.Stack((PlayAction) action1);
      ActionSequence action2 = new ActionSequence(this.Clear());
      action2.fixedPosition = true;
      action2.priority = this.eventPriority;
      action2.note = "Clear Overload";
      ActionQueue.Stack((PlayAction) action2);
      this.overloading = true;
    }

    public override bool RunApplyStatusEvent(StatusEffectApply apply)
    {
      int num;
      if (apply != null && (UnityEngine.Object) this.target == (UnityEngine.Object) apply?.target)
      {
        StatusEffectData effectData = apply.effectData;
        if ((effectData != null ? (effectData.offensive ? 1 : 0) : 0) != 0)
        {
          num = this.types.Contains<string>(apply?.effectData.name) ? 1 : 0;
          goto label_4;
        }
      }
      num = 0;
label_4:
      if (num != 0)
      {
        Debug.Log((object) "[Pokefrost] Changing to overshroom");
        apply.effectData = Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Overshroom");
      }
      return false;
    }

    public IEnumerator DealDamage(int damage)
    {
      if ((bool) (UnityEngine.Object) this && (bool) (UnityEngine.Object) this.target && this.target.alive)
      {
        HashSet<Entity> targets = new HashSet<Entity>();
        CardContainer[] cardContainerArray = this.target.containers;
        for (int index = 0; index < cardContainerArray.Length; ++index)
        {
          CardContainer collection = cardContainerArray[index];
          targets.AddRange<Entity>((IEnumerable<Entity>) collection);
          collection = (CardContainer) null;
        }
        cardContainerArray = (CardContainer[]) null;
        if ((bool) (UnityEngine.Object) this.buildupAnimation)
          yield return (object) this.buildupAnimation.Routine((object) this.target);
        Entity damager = this.GetDamager();
        Routine.Clump clump = new Routine.Clump();
        foreach (Entity item in targets)
        {
          Hit hit = new Hit(damager, item, damage)
          {
            damageType = "overload"
          };
          clump.Add(hit.Process());
          hit = (Hit) null;
        }
        clump.Add(Sequences.Wait(0.5f));
        yield return (object) clump.WaitForEnd();
      }
    }

    public IEnumerator Clear()
    {
      if ((bool) (UnityEngine.Object) this && (bool) (UnityEngine.Object) this.target && this.target.alive)
      {
        Routine.Clump clump = new Routine.Clump();
        for (int i = this.target.statusEffects.Count - 1; i >= 0; --i)
        {
          if ((UnityEngine.Object) this.target.statusEffects[i] != (UnityEngine.Object) null && this.types.Contains<string>(this.target.statusEffects[i].name))
            clump.Add(this.target.statusEffects[i].Remove());
        }
        clump.Add(this.Remove());
        yield return (object) clump.WaitForEnd();
        this.overloading = false;
        clump = (Routine.Clump) null;
      }
    }

    public void Unsub()
    {
      if (!this.subbed)
        return;
      global::Events.OnPostProcessUnits -= new UnityAction<Character>(this.Prime);
      this.subbed = false;
    }

    public void Prime(Character character)
    {
      this.primed = true;
      this.Unsub();
    }

    public override bool RunTurnEndEvent(Entity entity)
    {
      return this.primed && this.target.enabled && (UnityEngine.Object) entity == (UnityEngine.Object) this.target;
    }

    public IEnumerator DealDamage(Entity entity)
    {
      int amount = 1;
      global::Events.InvokeStatusEffectCountDown((StatusEffectData) this, ref amount);
      if (amount != 0)
        yield return (object) this.CountDown(entity, amount);
      Hit hit = new Hit(this.GetDamager(), this.target, this.count + 1)
      {
        screenShake = 0.25f,
        damageType = "shroom"
      };
      yield return (object) hit.Process();
      yield return (object) Sequences.Wait(0.2f);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectPickup
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectPickup : StatusEffectData
  {
    public string[] rewardPoolNames;
    public Func<CardData, bool> constraint;
    public int cap = 10;
    public string text = "{0} Found A Card";
    public string cappedText = "{0} Found A Fortune!";
    public static List<ulong> BlockingQueue = new List<ulong>();

    public override void Init()
    {
      global::Events.OnBattleEnd += new UnityAction(this.CheckPickup);
      base.Init();
    }

    public void OnDestroy() => global::Events.OnBattleEnd -= new UnityAction(this.CheckPickup);

    public virtual void CheckPickup()
    {
      if (!this.target.IsAliveAndExists())
        return;
      PickupRoutine.Queue((this.cap <= this.GetAmount() ? this.cappedText : this.text).Replace("{0}", this.target.data.title), Math.Min(this.cap, this.GetAmount()));
    }

    public virtual IEnumerator Run()
    {
      yield break;
    }

    protected RewardPool[] ConvertToPools()
    {
      List<RewardPool> rewardPoolList = new List<RewardPool>();
      foreach (string rewardPoolName in this.rewardPoolNames)
      {
        RewardPool rewardPool = Extensions.GetRewardPool(rewardPoolName);
        if ((UnityEngine.Object) rewardPool != (UnityEngine.Object) null)
          rewardPoolList.Add(rewardPool);
      }
      return rewardPoolList.ToArray();
    }

    protected static RewardPool[] GetPools()
    {
      List<ClassData> group = AddressableLoader.GetGroup<ClassData>("ClassData");
      ClassData classData1 = group[0];
      string name = References.Player.name;
      Debug.Log((object) ("[Pokefrost] " + name));
      foreach (ClassData classData2 in group)
      {
        if (name.ToLower().Contains(classData2.name.ToLower()))
        {
          classData1 = classData2;
          break;
        }
      }
      return ((IEnumerable<RewardPool>) classData1.rewardPools).Where<RewardPool>((Func<RewardPool, bool>) (r => (UnityEngine.Object) r != (UnityEngine.Object) null && r.type == "Items" && !r.isGeneralPool)).ToArray<RewardPool>();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectPlayCardsInHand
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
  public class StatusEffectPlayCardsInHand : StatusEffectInstant
  {
    public TargetConstraint[] applyConstraints;

    public override IEnumerator Process()
    {
      Entity[] array = ((IEnumerable<Entity>) (this.target.targetMode.GetPotentialTargets(this.target, (Entity) null, (CardContainer) null) ?? new Entity[0])).Where<Entity>((Func<Entity, bool>) (e => e.isActiveAndEnabled && e.canBeHit)).ToArray<Entity>();
      if (array.Length != 0)
      {
        Entity target = array.RandomItem<Entity>();
        List<Entity> list = References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (e => this.SatisfiesConstraints(e))).ToList<Entity>();
        for (int index = 0; index < list.Count; ++index)
          ActionQueue.Stack((PlayAction) new ActionTriggerAgainst(list[index], this.target, target, (CardContainer) null));
      }
      return base.Process();
    }

    public bool SatisfiesConstraints(Entity entity)
    {
      if (this.applyConstraints == null)
        return true;
      foreach (TargetConstraint applyConstraint in this.applyConstraints)
      {
        if (!applyConstraint.Check(entity))
          return false;
      }
      return true;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectResist
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectResist : StatusEffectData
  {
    public override void Init()
    {
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    }

    public override bool RunHitEvent(Hit hit)
    {
      return (Object) hit.target == (Object) this.target && hit.damage > 0;
    }

    public IEnumerator Check(Hit hit)
    {
      for (int countflag = 0; hit.damage > 0 && countflag < this.GetAmount(); ++countflag)
      {
        --hit.damage;
        ++hit.damageBlocked;
      }
      this.target.PromptUpdate();
      yield return (object) true;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectRetreat
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectRetreat : StatusEffectInstant
  {
    public static readonly string Key_TooBig = "websiteofsites.wildfrost.pokefrost.toobig";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectRetreat.Key_TooBig, "Target Too Big!");
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public static CardStack FindEnemyReserveStack()
    {
      foreach (CardStack enemyReserveStack in Object.FindObjectsOfType<CardStack>(true))
      {
        if (enemyReserveStack.name == "Enemy Reserve Stack")
          return enemyReserveStack;
      }
      return (CardStack) null;
    }

    public static WaveDeploySystem FindWaveSystem()
    {
      foreach (WaveDeploySystem waveSystem in Object.FindObjectsOfType<WaveDeploySystem>(true))
      {
        if (waveSystem.name == "WaveDeployer")
          return waveSystem;
      }
      return (WaveDeploySystem) null;
    }

    public static WaveDeploySystemOverflow FindWaveSystemOverflow()
    {
      foreach (WaveDeploySystemOverflow waveSystemOverflow in Object.FindObjectsOfType<WaveDeploySystemOverflow>(true))
      {
        if (waveSystemOverflow.name == "WaveDeployerOverflow")
          return waveSystemOverflow;
      }
      return (WaveDeploySystemOverflow) null;
    }

    public static void FailSafe(int _)
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(Battle.GetOpponent(References.Player));
      if (cardsOnBoard == null || cardsOnBoard.Count > 0)
        return;
      CardStack enemyReserveStack = StatusEffectRetreat.FindEnemyReserveStack();
      if ((Object) enemyReserveStack == (Object) null)
        return;
      if (enemyReserveStack.Count > 0)
      {
        WaveDeploySystemOverflow waveSystemOverflow = StatusEffectRetreat.FindWaveSystemOverflow();
        if ((Object) waveSystemOverflow == (Object) null || waveSystemOverflow.currentWave < waveSystemOverflow.waves.Count)
          return;
        StatusEffectRetreat.FixWaves(enemyReserveStack.entities.Clone<Entity>().ToArray());
      }
      else
      {
        Battle.instance.winner = References.Player;
        Battle.instance.phase = Battle.Phase.End;
      }
    }

    public static bool FixWaves(params Entity[] entities)
    {
      if (((IEnumerable<Entity>) entities).Count<Entity>() == 0)
        return false;
      WaveDeploySystem waveSystem = StatusEffectRetreat.FindWaveSystem();
      WaveDeploySystemOverflow waveSystemOverflow = StatusEffectRetreat.FindWaveSystemOverflow();
      if ((Object) waveSystem == (Object) null || (Object) waveSystemOverflow == (Object) null)
        return false;
      bool flag1 = false;
      bool flag2 = false;
      if (waveSystemOverflow.currentWave >= waveSystemOverflow.waves.Count)
        flag1 = true;
      if (!flag1)
      {
        BattleWaveManager.Wave wave = waveSystemOverflow.waves[waveSystemOverflow.currentWave];
        if (wave.units.Count<CardData>() > 5)
        {
          flag2 = true;
        }
        else
        {
          waveSystemOverflow.deployed.Remove(entities[0].data.id);
          wave.units.Add(entities[0].data);
        }
      }
      if (flag1 | flag2)
      {
        waveSystemOverflow.Overflow((IEnumerable<Entity>) entities);
        waveSystemOverflow.deployed.Remove(entities[0].data.id);
        if (flag1)
        {
          waveSystemOverflow.SetCounter(waveSystemOverflow.waves[waveSystemOverflow.currentWave].counter);
          waveSystemOverflow.Show();
        }
      }
      return true;
    }

    public override IEnumerator Process()
    {
      if (this.target.height > 1)
      {
        this.PopupText(this.target, StatusEffectRetreat.Key_TooBig);
      }
      else
      {
        CardStack cardStack = StatusEffectRetreat.FindEnemyReserveStack();
        if ((Object) cardStack != (Object) null)
        {
          if (StatusEffectRetreat.FixWaves(this.target))
            yield return (object) Sequences.CardMove(this.target, new CardContainer[1]
            {
              (CardContainer) cardStack
            });
        }
        cardStack = (CardStack) null;
      }
      yield return (object) base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectRevive
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectRevive : StatusEffectData
  {
    public float healthFactor = 0.5f;
    public float damageFactor = 0.5f;

    public override void Init()
    {
      global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
    }

    public void OnDestroy()
    {
      global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
    }

    public void EntityDisplayUpdated(Entity entity)
    {
      if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.target.hp.current <= 0 && !this.target.silenced)
      {
        this.target.PromptUpdate();
        ActionQueue.Stack((PlayAction) new ActionSequence(this.Animate()));
        this.target.damage.current = Mathf.CeilToInt((float) this.target.damage.max * this.damageFactor);
        this.target.hp.current = Mathf.CeilToInt((float) this.target.hp.max * this.healthFactor);
        this.CountDown();
        this.target.statusEffects.Remove((StatusEffectData) this);
        global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
        if (this.target.display is Card display)
          display.promptUpdateDescription = true;
        this.target.PromptUpdate();
      }
      else
      {
        if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || this.target.hp.current > 0)
          return;
        this.target.statusEffects.Remove((StatusEffectData) this);
        global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
        if (this.target.display is Card display)
          display.promptUpdateDescription = true;
        this.target.PromptUpdate();
      }
    }

    public void CountDown()
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if ((long) this.target.data.id == (long) cardData.id)
        {
          for (int index = 0; index < cardData.startWithEffects.Length; ++index)
          {
            CardData.StatusEffectStacks stack = cardData.startWithEffects[index];
            if (stack.data.name == this.name)
            {
              --stack.count;
              if (stack.count == 0)
                cardData.startWithEffects = ((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (item => item != stack)).ToArray<CardData.StatusEffectStacks>();
            }
          }
        }
      }
    }

    public IEnumerator Animate()
    {
      ChangePhaseAnimationSystem animationSystem = UnityEngine.Object.FindObjectOfType<ChangePhaseAnimationSystem>();
      GameObject obj = new GameObject("focus");
      obj.transform.SetParent(animationSystem.container);
      obj.transform.position = this.target.transform.position;
      animationSystem.container = obj.transform;
      animationSystem?.Flash();
      yield return (object) animationSystem.Focus(this.target);
      yield return (object) Sequences.Wait(0.3f);
      ActionSequence action = new ActionSequence(animationSystem.UnFocus());
      action.note = "Unfocus boss";
      action.priority = 10;
      ActionQueue.Stack((PlayAction) action, true);
    }

    private IEnumerator blah()
    {
      this.target.containers[0].SetChildPosition(this.target);
      yield break;
    }

    public override bool RunBeginEvent()
    {
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
      return base.RunBeginEvent();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantRunScript
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantRunScript : StatusEffectInstant
  {
    public PlayAction action;
    public bool stack = true;
    public List<EntityCardScript> scriptList;

    public override IEnumerator Process()
    {
      if (this.action != null)
      {
        if (this.stack)
          ActionQueue.Stack(this.action);
        else
          ActionQueue.Add(this.action);
      }
      if (this.scriptList != null && this.scriptList.Count > 0)
      {
        foreach (EntityCardScript script in this.scriptList)
          yield return (object) script.Run(this.target, this.count);
      }
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
      yield return (object) base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectShiny
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectShiny : StatusEffectData
  {
    public override bool HasBeginRoutine => true;

    public override bool RunBeginEvent()
    {
      if ((Object) this.target != (Object) null && this.target.data.name.Contains("websiteofsites.wildfrost.pokefrost"))
      {
        Sprite sprite = Pokefrost.Pokefrost.instance.ApplyShinySprite(this.target.data);
        this.target.data.mainSprite = sprite;
        this.target.GetComponent<Card>().mainImage.sprite = sprite;
      }
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectSketchOnDeploy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectSketchOnDeploy : StatusEffectApplyXWhenDeployed
  {
    public override bool RunEnableEvent(Entity entity)
    {
      return base.RunEnableEvent(entity) && this.CountDown();
    }

    public override bool RunCardMoveEvent(Entity entity)
    {
      return base.RunCardMoveEvent(entity) && this.CountDown();
    }

    public bool CountDown()
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if ((long) this.target.data.id == (long) cardData.id)
        {
          for (int index = 0; index < cardData.startWithEffects.Length; ++index)
          {
            CardData.StatusEffectStacks startWithEffect = cardData.startWithEffects[index];
            if (startWithEffect.data.name == this.name)
            {
              --startWithEffect.count;
              if (startWithEffect.count == 0)
              {
                cardData.startWithEffects = cardData.startWithEffects.RemoveFromArray<CardData.StatusEffectStacks>(startWithEffect);
                return true;
              }
            }
          }
        }
      }
      return true;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectSpicune
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectSpicune : StatusEffectData
  {
    public bool cardPlayed;
    public int current;
    public int amountToClear;

    public static event UnityAction<Entity, int> OnJuiceCleared;

    public override void Init()
    {
      this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CardPlayed);
    }

    public override bool RunStackEvent(int stacks)
    {
      this.current += stacks;
      this.target.effectBonus += stacks;
      return false;
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || this.count <= 0)
        return false;
      this.amountToClear = this.current;
      return !((IEnumerable<PlayAction>) ActionQueue.GetActions()).Any<PlayAction>((Func<PlayAction, bool>) (a => a is ActionTrigger actionTrigger && (UnityEngine.Object) actionTrigger.entity == (UnityEngine.Object) this.target));
    }

    public override bool RunActionPerformedEvent(PlayAction action)
    {
      return this.cardPlayed && ActionQueue.Empty;
    }

    public IEnumerator Clear(int amount)
    {
      int amount2 = amount;
      global::Events.InvokeStatusEffectCountDown((StatusEffectData) this, ref amount2);
      if (amount2 != 0)
      {
        this.current -= amount2;
        this.target.effectBonus -= amount2;
        yield return (object) this.CountDown(this.target, amount2);
        if (this.count == 0)
        {
          UnityAction<Entity, int> onJuiceCleared = StatusEffectSpicune.OnJuiceCleared;
          if (onJuiceCleared != null)
            onJuiceCleared(this.target, amount2);
        }
      }
    }

    public IEnumerator CardPlayed(Entity entity, Entity[] targets)
    {
      yield return (object) this.Clear(this.amountToClear);
    }

    public override bool RunEndEvent()
    {
      this.target.effectBonus -= this.current;
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonCustom
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonCustom : StatusEffectInstantSummon
  {
    public override IEnumerator Process()
    {
      string str;
      this.target.data.TryGetCustomData<string>("Future Sight", out str, "");
      if (!str.IsNullOrEmpty())
      {
        CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>(str);
        if ((Object) cardData != (Object) null)
          this.targetSummon.summonCard = cardData;
      }
      return base.Process();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectTransfer
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectTransfer : StatusEffectApplyXInstant
  {
    public override void Init()
    {
      this.OnBegin += new StatusEffectData.EffectEventHandler(((StatusEffectApplyXInstant) this).Process);
      this.OnEnd += new StatusEffectData.EffectEventHandler(this.RemoveEffects);
    }

    public IEnumerator RemoveEffects()
    {
      if (this.effectToApply.GetType() == typeof (StatusEffectMultEffects))
      {
        StatusEffectMultEffects effs = this.effectToApply as StatusEffectMultEffects;
        for (int i = 0; i < effs.effects.Count; ++i)
        {
          for (int j = this.target.statusEffects.Count - 1; j >= 0; --j)
          {
            if (this.target.statusEffects[j].name == effs.effects[i].name)
            {
              if (this.target.statusEffects[j].GetType() == typeof (StatusEffectWhileActiveX))
              {
                StatusEffectWhileActiveX activeEff = this.target.statusEffects[j] as StatusEffectWhileActiveX;
                if (activeEff.active)
                {
                  Debug.Log((object) "DEACTIVATING");
                  yield return (object) activeEff.Deactivate();
                }
                activeEff = (StatusEffectWhileActiveX) null;
              }
              yield return (object) this.target.statusEffects[j].RemoveStacks(this.GetAmount(), true);
              break;
            }
          }
        }
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
        effs = (StatusEffectMultEffects) null;
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectTriggerWhenDamageType
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectTriggerWhenDamageType : StatusEffectData
  {
    private bool isAlreadyOnBoard;
    public string triggerdamagetype;

    public override bool HasPostHitRoutine => true;

    public override object GetMidBattleData() => (object) Battle.IsOnBoard(this.target);

    public override void RestoreMidBattleData(object data)
    {
      if (!(data is bool flag))
        return;
      this.isAlreadyOnBoard = flag && Battle.IsOnBoard(this.target);
    }

    public override void Init()
    {
      this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Enable);
    }

    public override bool RunPostHitEvent(Hit hit) => Battle.IsOnBoard(this.target);

    private IEnumerator Enable(Hit hit)
    {
      Debug.Log((object) ("[Pokefrost] Damage type is " + hit.damageType.ToString()));
      if (hit.damageType == this.triggerdamagetype)
      {
        yield return (object) Sequences.Wait(0.2f);
        yield return (object) this.Activate();
      }
    }

    private IEnumerator Activate()
    {
      if (!this.target.silenced)
      {
        yield return (object) Sequences.Wait(0.1f);
        CurveAnimator curveAnimator = this.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num = (double) curveAnimator.Ping();
        }
        yield return (object) Sequences.Wait(0.3f);
        ActionQueue.Stack((PlayAction) new ActionTrigger(this.target, (Entity) null), true);
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectTriggerWhenSummonDeployed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectTriggerWhenSummonDeployed : StatusEffectData
  {
    private bool isAlreadyOnBoard;

    public override bool HasEnableRoutine => true;

    public override object GetMidBattleData() => (object) Battle.IsOnBoard(this.target);

    public override void RestoreMidBattleData(object data)
    {
      if (!(data is bool flag))
        return;
      this.isAlreadyOnBoard = flag && Battle.IsOnBoard(this.target);
    }

    public override void Init()
    {
      this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Enable);
    }

    public override bool RunEnableEvent(Entity entity) => Battle.IsOnBoard(this.target);

    private IEnumerator Enable(Entity entity)
    {
      if (entity.data.cardType.name == "Summoned")
      {
        yield return (object) Sequences.Wait(0.2f);
        yield return (object) this.Activate();
      }
    }

    private IEnumerator Activate()
    {
      if (!this.target.silenced)
      {
        yield return (object) Sequences.Wait(0.1f);
        CurveAnimator curveAnimator = this.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num = (double) curveAnimator.Ping();
        }
        yield return (object) Sequences.Wait(0.2f);
        ActionQueue.Stack((PlayAction) new ActionTrigger(this.target, (Entity) null), true);
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectUnlimitedLumin
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectUnlimitedLumin : StatusEffectData
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
      ++StatusEffectUnlimitedLumin.PatchLumin.active;
      this.added = true;
    }

    protected void Deactivate()
    {
      if (!this.added)
        return;
      --StatusEffectUnlimitedLumin.PatchLumin.active;
      this.added = false;
    }

    [HarmonyPatch(typeof (StatusEffectLumin), "RunPostApplyStatusEvent")]
    private class PatchLumin
    {
      public static int active;

      public static bool Active => StatusEffectUnlimitedLumin.PatchLumin.active != 0;

      private static bool Prefix() => !StatusEffectUnlimitedLumin.PatchLumin.Active;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWeather
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWeather : StatusEffectData
  {
    private SnowfallParticles snowfall;
    private bool active;
    public float intensityMultiplier = 2f;
    public Color color;

    public override bool RunBeginEvent()
    {
      if ((Object) References.Battle != (Object) null && Battle.IsOnBoard(this.target))
        this.Activate();
      return false;
    }

    public void OnDestroy() => this.Deactivate();

    public override bool RunEndEvent()
    {
      this.Deactivate();
      return false;
    }

    public void Activate()
    {
      if (this.active)
        return;
      this.snowfall = GameObject.Find("Battle/Background/BackgroundSnowland(Clone)")?.GetComponentInChildren<SnowfallParticles>() ?? GameObject.Find("Battle/Background/BackgroundFrostland 5(Clone)")?.GetComponentInChildren<SnowfallParticles>() ?? GameObject.Find("Battle/Background/BackgroundFinalBoss 4(Clone)")?.GetComponentInChildren<SnowfallParticles>();
      if ((Object) this.snowfall != (Object) null)
        this.snowfall.frontSnow.startColor = this.color;
      this.active = true;
      global::Events.OnSetWeatherIntensity += new UnityAction<float, float>(this.Events_OnSetWeatherIntensity);
      global::Events.InvokeSetWeatherIntensity(0.2f, 1f);
    }

    private void Events_OnSetWeatherIntensity(float intensity, float duration)
    {
      if ((Object) this.snowfall == (Object) null)
        this.Deactivate();
      else
        this.snowfall.storminessTo = intensity * this.intensityMultiplier;
    }

    public void Deactivate()
    {
      if (!this.active)
        return;
      if ((Object) this.snowfall != (Object) null)
        this.snowfall.frontSnow.startColor = new Color(1f, 1f, 1f, 1f);
      this.active = false;
      global::Events.OnSetWeatherIntensity -= new UnityAction<float, float>(this.Events_OnSetWeatherIntensity);
      global::Events.InvokeSetWeatherIntensity(0.1f, 1f);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWhileExistingX
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWhileExistingX : StatusEffectWhileActiveX
  {
    public override bool CanActivate() => true;

    public override bool CheckActivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }

    public override bool CheckDeactivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWhileRedrawBellChargedX
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWhileRedrawBellChargedX : StatusEffectWhileActiveX
  {
    private RedrawBellSystem bellSystem;

    public override void Init()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Reset);
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.TryActivate);
      base.Init();
    }

    public override void OnDestroy()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Reset);
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.TryActivate);
      base.OnDestroy();
    }

    private void Reset(RedrawBellSystem arg0)
    {
      if (!this.active)
        return;
      ActionQueue.Stack((PlayAction) new ActionSequence(this.Deactivate()));
    }

    private void TryActivate(int arg0)
    {
      if (!this.CanActivate() || this.active)
        return;
      ActionQueue.Stack((PlayAction) new ActionSequence(this.Activate()));
    }

    public override bool CanActivate()
    {
      if ((Object) this.bellSystem == (Object) null)
        this.bellSystem = Object.FindObjectOfType<RedrawBellSystem>();
      return this.bellSystem.IsCharged && this.bellSystem.interactable;
    }

    public override bool CheckActivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }

    public override bool CheckDeactivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectXActsLikeShell
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectXActsLikeShell : StatusEffectData
  {
    public string targetType = "";
    public Sprite sprite;
    public bool active = true;

    public override void Init()
    {
      this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.ChangeIcon);
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.BlockDamage);
      this.OnEffectBonusChanged += new StatusEffectData.EffectEventHandler(this.SilenceCheck);
    }

    private IEnumerator SilenceCheck()
    {
      StatusIcon snowIcon = this.target?.GetComponent<Card>()?.FindStatusIcon("snow");
      if (!((Object) snowIcon == (Object) null))
      {
        if (this.GetAmount() > 0)
        {
          snowIcon.GetComponent<Image>().sprite = this.sprite;
          snowIcon.transform.SetParent(snowIcon.transform.parent.parent.Find("HealthLayout"));
        }
        else
        {
          snowIcon.GetComponent<Image>().sprite = CardManager.cardIcons["snow"].GetComponent<Image>().sprite;
          snowIcon.transform.SetParent(snowIcon.transform.parent.parent.Find("CounterLayout"));
          yield break;
        }
      }
    }

    public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
    {
      return (Object) this.target != (Object) null && (Object) apply?.target == (Object) this.target && this.GetAmount() > 0 && apply.effectData.type == this.targetType;
    }

    public IEnumerator ChangeIcon(StatusEffectApply apply)
    {
      StatusIcon snowIcon = apply.target.GetComponent<Card>().FindStatusIcon("snow");
      if ((Object) snowIcon != (Object) null && (Object) this.sprite != (Object) null)
      {
        snowIcon.GetComponent<Image>().sprite = this.sprite;
        snowIcon.transform.SetParent(snowIcon.transform.parent.parent.Find("HealthLayout"));
      }
      else
      {
        snowIcon = apply.target.GetComponent<Card>().SetStatusIcon("snow", "health", new Stat(apply.count, 0));
        snowIcon.GetComponent<Image>().sprite = this.sprite;
      }
      yield return (object) Sequences.Wait(apply.target.curveAnimator.Ping());
    }

    public override bool RunHitEvent(Hit hit)
    {
      return (Object) hit?.target == (Object) this.target && (bool) (Object) hit.target.FindStatus(this.targetType) && this.GetAmount() > 0 && hit.damage > 0;
    }

    public IEnumerator BlockDamage(Hit hit)
    {
      StatusEffectData targetEffect = hit.target.FindStatus(this.targetType);
      while (targetEffect.count > 0 && hit.damage > 0)
      {
        --targetEffect.count;
        --hit.damage;
        ++hit.damageBlocked;
      }
      if (targetEffect.count <= 0)
        yield return (object) targetEffect.Remove();
      this.target.PromptUpdate();
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetModeLowHealth
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class TargetModeLowHealth : TargetMode
  {
    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      HashSet<Entity> entitySet = new HashSet<Entity>();
      if ((bool) (Object) targetContainer)
      {
        if (targetContainer.Count > 0)
          entitySet.Add(this.GetTarget((IList<Entity>) targetContainer));
      }
      else if ((bool) (Object) target)
      {
        if (target.containers.Length != 0)
        {
          CardContainer targets = target.containers.RandomItem<CardContainer>();
          if (targets.Count > 0)
            entitySet.Add(this.GetTarget((IList<Entity>) targets));
        }
      }
      else
      {
        int[] rowIndices = Battle.instance.GetRowIndices(entity);
        foreach (int rowIndex in rowIndices)
          this.AddTargets(entity, entitySet, rowIndex);
        if (entitySet.Count == 0)
        {
          int rowCount = Battle.instance.rowCount;
          for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
          {
            if (!rowIndices.Contains<int>(rowIndex))
              this.AddTargets(entity, entitySet, rowIndex);
          }
        }
      }
      return entitySet.Count <= 0 ? (Entity[]) null : entitySet.ToArray<Entity>();
    }

    public override CardSlot[] GetTargetSlots(CardSlotLane row)
    {
      return new CardSlot[1]{ row.slots[row.max - 1] };
    }

    public override bool CanTarget(Entity entity)
    {
      bool flag = true;
      foreach (CardContainer container in entity.containers)
      {
        for (int index = 0; index < container.Count; ++index)
        {
          Entity entity1 = container[index];
          if ((bool) (Object) entity1 && entity1.enabled && entity1.alive && entity1.canBeHit)
          {
            if (entity.hp.current > entity1.hp.current)
            {
              flag = false;
              break;
            }
            if (entity.hp.current == entity1.hp.current && index < container.IndexOf(entity))
            {
              flag = false;
              break;
            }
          }
        }
      }
      return flag;
    }

    public void AddTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
    {
      Entity target = this.GetTarget((IList<Entity>) entity.GetEnemiesInRow(rowIndex));
      if ((bool) (Object) target)
      {
        targets.Add(target);
      }
      else
      {
        Entity enemyCharacter = this.GetEnemyCharacter(entity);
        if (!(bool) (Object) enemyCharacter)
          return;
        targets.Add(enemyCharacter);
      }
    }

    public Entity GetTarget(IList<Entity> targets)
    {
      int num = 1000000000;
      Entity target1 = (Entity) null;
      for (int index = 0; index < targets.Count; ++index)
      {
        Entity target2 = targets[index];
        if ((bool) (Object) target2 && target2.enabled && target2.alive && target2.canBeHit && num > target2.hp.current)
        {
          num = target2.hp.current;
          target1 = target2;
        }
      }
      return target1;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetModeStatus
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class TargetModeStatus : TargetMode
  {
    public string targetType;
    public bool missing = false;
    public bool failSafe = false;

    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      HashSet<Entity> list = new HashSet<Entity>();
      list.AddRange<Entity>(entity.GetAllEnemies().Where<Entity>((Func<Entity, bool>) (e => (bool) (UnityEngine.Object) e && e.enabled && e.alive && e.canBeHit && this.HasStatus(e))));
      return list.Count <= 0 && this.failSafe ? ScriptableObject.CreateInstance<TargetModeBasic>().GetPotentialTargets(entity, target, targetContainer) : list.ToArray<Entity>();
    }

    public override Entity[] GetSubsequentTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      return this.GetTargets(entity, target, targetContainer);
    }

    public bool HasStatus(Entity entity)
    {
      foreach (StatusEffectData statusEffect in entity.statusEffects)
      {
        if (statusEffect.type == this.targetType)
          return !this.missing;
      }
      return this.missing;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetModeTaunt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class TargetModeTaunt : TargetMode
  {
    public string targetTrait = "Taunt";
    public bool missing = false;
    public bool failSafe = true;

    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      HashSet<Entity> list = new HashSet<Entity>();
      list.AddRange<Entity>(entity.GetAllEnemies().Where<Entity>((Func<Entity, bool>) (e => (bool) (UnityEngine.Object) e && e.enabled && e.alive && e.canBeHit && this.HasTaunt(e))));
      return list.Count <= 0 && this.failSafe ? ScriptableObject.CreateInstance<TargetModeBasic>().GetPotentialTargets(entity, target, targetContainer) : list.ToArray<Entity>();
    }

    public override Entity[] GetSubsequentTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      return this.GetTargets(entity, target, targetContainer);
    }

    public bool HasTaunt(Entity entity)
    {
      foreach (Entity.TraitStacks trait in entity.traits)
      {
        if (trait.data.name == this.targetTrait)
          return !this.missing;
      }
      return this.missing;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.TicketTimerModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public class TicketTimerModifierSystem : QuestSystem
  {
    public static string Key_Slow = "websiteofsites.wildfrost.pokefrost.tooslow";
    private Timer timer;

    public override string ProgressName => "TickTock";

    [PokeLocalizer]
    public new static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(TicketTimerModifierSystem.Key_Slow, "The ship has departed...");
    }

    public void OnEnable()
    {
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleTurnEnd += new UnityAction<int>(this.ReadTime);
      global::Events.OnBattleEnd += new UnityAction(this.PauseTimer);
      this.progress = 900;
      this.FindProgress();
      if (this.progress <= 0)
        return;
      this.MakeTimer();
    }

    public void OnDisable()
    {
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.ReadTime);
      global::Events.OnBattleEnd -= new UnityAction(this.PauseTimer);
      if (!(bool) (Object) this.timer)
        return;
      this.timer.End();
    }

    private void PauseTimer()
    {
      if (!(bool) (Object) this.timer)
      {
        this.progress = 0;
      }
      else
      {
        this.timer.Stop();
        this.ReadTime(420);
      }
    }

    private void StartTimer(int _)
    {
      if (!(bool) (Object) this.timer)
        this.progress = 0;
      else
        this.timer.Play();
    }

    private void ReadTime(int _)
    {
      if (!(bool) (Object) this.timer)
        this.progress = 0;
      else
        this.UpdateProgress((int) this.timer.Time);
    }

    public void MakeTimer()
    {
      if (!(bool) (Object) this.timer)
        this.timer = Timer.Create((float) this.progress);
      this.timer.SetTime((float) this.progress);
    }

    public override bool CheckConditions(out string failureText)
    {
      failureText = this.GetFailureText(TicketTimerModifierSystem.Key_Slow);
      Debug.Log((object) string.Format("[Pokefrost] Checking Progress... {0}", (object) this.progress));
      return this.progress > 0;
    }

    public override void QuestBattleStart()
    {
      this.Disable();
      this.timer.End();
    }

    public override void QuestBattleFinish() => this.UpdateProgress(0);
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.Timer
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class Timer : MonoBehaviour
  {
    private float time;
    private float scale = -1f;
    public const string RED = "#ff4444";
    public const string YEL = "#ffca57";
    public const string WHT = "#ffffff";
    public const string GRN = "#3AF6CB";
    public const string BLU = "#7EDAFF";
    private string format = "<color={3}><mspace=0.4>{0}</mspace>:<mspace=0.4>{1}</mspace>.<mspace=0.3><size=0.6>{2}</size></mspace></color>";
    private string failFormat = "<color=#ff4444><mspace=0.4>XX</mspace>:<mspace=0.4>XX</mspace>.<mspace=0.3><size=0.6>XX</size></mspace></color>";
    public bool running = false;

    public float Time => this.time;

    private FloatingText Text => this.GetComponent<FloatingText>();

    public event UnityAction OnFinished;

    internal static Timer Create(float time)
    {
      Timer timer = UnityEngine.Object.FindObjectOfType<FloatingTextManager>().CreatePrefab().gameObject.AddComponent<Timer>();
      timer.SetTime(time);
      timer.Show();
      return timer;
    }

    public void Start()
    {
      this.Text.textAsset.outlineWidth = 0.05f;
      this.Text.textAsset.outlineColor = (Color32) Color.black;
    }

    public void SetTime(float time) => this.time = time;

    public void SetScale(float scale) => this.scale = scale;

    public void Show()
    {
      this.transform.position = new Vector3(0.0f, 5f, 0.0f);
      this.UpdateDisplay("#ffca57");
      this.gameObject.SetActive(true);
    }

    public void UpdateDisplay(string color = null)
    {
      if (color == null)
        color = this.running ? "#ffffff" : "#ffca57";
      if ((double) this.time <= 0.0)
      {
        this.Text.SetText(this.failFormat);
        this.time = 0.0f;
        this.running = false;
        UnityAction onFinished = this.OnFinished;
        if (onFinished == null)
          return;
        onFinished();
      }
      else
      {
        int time = (int) this.time;
        this.Text.SetText(string.Format(this.format, (object) (time / 60).ToString("00"), (object) (time % 60).ToString("00"), (object) Math.Floor((double) this.time % 1.0 * 100.0).ToString("00"), (object) color));
      }
    }

    public void Hide() => this.gameObject.SetActive(false);

    public void Play()
    {
      if (this.running || (double) this.time <= 0.0)
        return;
      this.running = true;
      this.StartCoroutine(this.Run());
    }

    public void Stop() => this.running = false;

    public void End() => this.gameObject.Destroy();

    public IEnumerator Run()
    {
      while (this.running)
      {
        this.time += this.scale * UnityEngine.Time.deltaTime;
        this.UpdateDisplay("#ffffff");
        yield return (object) null;
      }
      this.UpdateDisplay("#ffca57");
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.UICollector
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public static class UICollector
  {
    public static Dictionary<string, GameObject> Prefabs = new Dictionary<string, GameObject>();
    public static GameObject gameObject = (GameObject) null;

    public static IEnumerator CollectPrefabs()
    {
      if (!((UnityEngine.Object) UICollector.gameObject != (UnityEngine.Object) null))
      {
        UICollector.gameObject = new GameObject(nameof (UICollector));
        UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) UICollector.gameObject);
        UICollector.gameObject.SetActive(false);
        GameObject box = new GameObject("Box");
        box.AddComponent<Image>();
        UICollector.Prefabs.Add(box.name, box);
        box.transform.SetParent(UICollector.gameObject.transform, false);
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("Global")));
        GameObject floatingText = UnityEngine.Object.FindObjectOfType<FloatingTextManager>().CreatePrefab().gameObject;
        floatingText.name = "Text";
        UICollector.Prefabs.Add(floatingText.name, floatingText);
        floatingText.transform.SetParent(UICollector.gameObject.transform, false);
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("MainMenu")));
        GameObject button = GameObject.Find("ModsButton").InstantiateKeepName<GameObject>();
        button.name = "Button";
        UICollector.Prefabs.Add(button.name, button);
        button.transform.SetParent(UICollector.gameObject.transform, false);
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("Town")));
        GameObject backButton = GameObject.Find("Canvas/SafeArea/Back Button").InstantiateKeepName<GameObject>();
        backButton.name = "BackButton";
        UICollector.Prefabs.Add(backButton.name, backButton);
        backButton.transform.SetParent(UICollector.gameObject.transform, false);
        UICollector.PokemonTradeEvent();
      }
    }

    public static GameObject FindEx(string s) => GameObject.Find(s);

    public static GameObject PullPrefab(string key, string name, GameObject parent)
    {
      if (!UICollector.Prefabs.ContainsKey(key))
        Debug.Log((object) ("[UICollector] Could not find a prefab with key " + key));
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(UICollector.Prefabs[key], parent.transform);
      gameObject.name = name;
      return gameObject;
    }

    public static void PokemonTradeEvent()
    {
      GameObject gameObject1 = new GameObject("TradeEventManager");
      gameObject1.SetActive(false);
      CardControllerSelectCard controllerSelectCard = gameObject1.AddComponent<CardControllerSelectCard>();
      controllerSelectCard.pressEvent = new UnityEventEntity();
      controllerSelectCard.hoverEvent = new UnityEventEntity();
      controllerSelectCard.unHoverEvent = new UnityEventEntity();
      CardSelector cardSelector = gameObject1.AddComponent<CardSelector>();
      cardSelector.selectEvent = new UnityEventEntity();
      GameObject gameObject2 = new GameObject("Background");
      gameObject2.SetActive(false);
      gameObject2.transform.SetParent(gameObject1.transform, false);
      gameObject2.AddComponent<Image>().sprite = AddressableExtMethods.ASprite("trade_background");
      gameObject2.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 1f);
      gameObject2.transform.localScale = new Vector3(0.3f, 0.3f, 0.0f);
      GameObject gameObject3 = new GameObject("LineHolder");
      gameObject3.transform.SetParent(gameObject1.transform);
      gameObject3.transform.Translate(new Vector3(0.0f, -0.1f, 0.0f));
      GameObject gameObject4 = new GameObject("CardLane1");
      gameObject4.SetActive(false);
      gameObject4.AddComponent<Image>();
      gameObject4.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.0f);
      CardLane cardLane1 = gameObject4.AddComponent<CardLane>();
      cardLane1.holder = gameObject4.GetComponent<RectTransform>();
      cardLane1.onAdd = new UnityEventEntity();
      gameObject4.transform.SetParent(gameObject1.transform);
      gameObject4.transform.Translate(new Vector3(0.0f, 2.3f, 0.0f));
      cardLane1.gap = new Vector3(0.7f, 0.0f, 0.0f);
      GameObject gameObject5 = new GameObject("CardLane2");
      gameObject5.SetActive(false);
      gameObject5.AddComponent<Image>();
      gameObject5.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.0f);
      CardLane cardLane2 = gameObject5.AddComponent<CardLane>();
      cardLane2.holder = gameObject5.GetComponent<RectTransform>();
      cardLane2.onAdd = new UnityEventEntity();
      gameObject5.transform.SetParent(gameObject1.transform);
      gameObject5.transform.Translate(new Vector3(0.0f, -2.3f, 0.0f));
      cardLane2.gap = new Vector3(0.7f, 0.0f, 0.0f);
      GameObject gameObject6 = UICollector.PullPrefab("BackButton", "BackButton", gameObject1);
      gameObject6.transform.localPosition = new Vector3(-8f, 0.0f, 0.0f);
      GameObject parent = new GameObject("SelectBackground");
      parent.SetActive(false);
      parent.transform.SetParent(gameObject1.transform, false);
      parent.AddComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.6f);
      parent.GetComponent<RectTransform>().sizeDelta = new Vector2(100f, 100f);
      parent.AddComponent<UINavigationLayer>();
      GameObject gameObject7 = UICollector.PullPrefab("Button", "CancelButton", parent);
      gameObject7.GetComponent<RectTransform>().sizeDelta = new Vector2(4f, 1f);
      gameObject7.transform.localPosition = new Vector3(0.0f, -3.7f, 0.0f);
      GameObject gameObject8 = UICollector.PullPrefab("Button", "ConfirmButton", parent);
      gameObject8.GetComponent<RectTransform>().sizeDelta = new Vector2(4f, 1f);
      gameObject8.transform.localPosition = new Vector3(0.0f, -2.5f, 0.0f);
      GameObject gameObject9 = UICollector.PullPrefab("Text", "Title", gameObject1);
      gameObject9.GetComponentInChildren<TextMeshProUGUI>().text = "Trade Offers";
      gameObject9.transform.Translate(new Vector3(0.0f, 4.8f, 0.0f));
      EventRoutineTrade eventRoutineTrade = gameObject1.AddComponent<EventRoutineTrade>();
      eventRoutineTrade.cc = controllerSelectCard;
      eventRoutineTrade.cs = cardSelector;
      eventRoutineTrade.title = gameObject9.GetComponentInChildren<TextMeshProUGUI>();
      eventRoutineTrade.TradeLines = gameObject3;
      eventRoutineTrade.topRow = cardLane1;
      eventRoutineTrade.bottomRow = cardLane2;
      eventRoutineTrade.backButton = gameObject6;
      eventRoutineTrade.selectionBackground = parent;
      eventRoutineTrade.cancelObject = gameObject7;
      eventRoutineTrade.confirmObject = gameObject8;
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) gameObject1);
      gameObject2.SetActive(true);
      gameObject4.SetActive(true);
      gameObject5.SetActive(true);
      CampaignNodeTypeTrade.Prefabs.Add("Trade", gameObject1);
    }
  }
}
