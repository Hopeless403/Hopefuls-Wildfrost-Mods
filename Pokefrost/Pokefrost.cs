// Decompiled with JetBrains decompiler
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
