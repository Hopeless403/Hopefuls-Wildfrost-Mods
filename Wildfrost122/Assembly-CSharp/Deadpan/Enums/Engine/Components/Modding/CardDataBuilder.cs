// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CardDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CardDataBuilder : DataFileBuilder<CardData, CardDataBuilder>
  {
    private ChallengeData UnlockChallenge;

    public CardDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CardDataBuilder()
    {
    }

    public CardDataBuilder SetStats(int? health = null, int? damage = null, int counter = 0)
    {
      return this.SetHealth(health).SetDamage(damage).SetCounter(counter);
    }

    public CardDataBuilder SetCounter(int counter)
    {
      this._data.counter = counter;
      return this;
    }

    public CardDataBuilder SetDamage(int? damage)
    {
      if (damage.HasValue)
        this._data.damage = damage.Value;
      this._data.hasAttack = damage.HasValue;
      return this;
    }

    public CardDataBuilder NeedsTarget(bool value = true)
    {
      this._data.needsTarget = value;
      return this;
    }

    public CardDataBuilder SetHealth(int? health)
    {
      if (health.HasValue)
        this._data.hp = health.Value;
      this._data.hasHealth = health.HasValue;
      return this;
    }

    public CardDataBuilder SetSprites(Sprite mainSprite, Sprite backgroundSprite)
    {
      this._data.mainSprite = mainSprite;
      this._data.backgroundSprite = backgroundSprite;
      return this;
    }

    public CardDataBuilder SetSprites(string mainSprite, string backgroundSprite)
    {
      return this.SetSprites(this.Mod.ImagePath(mainSprite).ToSprite(), this.Mod.ImagePath(backgroundSprite).ToSprite());
    }

    public CardDataBuilder SetStartWithEffect(params CardData.StatusEffectStacks[] stacks)
    {
      this._data.startWithEffects = stacks;
      return this;
    }

    public CardDataBuilder SetTraits(params CardData.TraitStacks[] stacks)
    {
      this._data.traits = stacks.ToList<CardData.TraitStacks>();
      return this;
    }

    public CardDataBuilder WithDescription(string desc)
    {
      this._data.desc = desc;
      return this;
    }

    public CardDataBuilder WithValue(int price)
    {
      this._data.value = price;
      return this;
    }

    public CardDataBuilder WithTargetMode(TargetMode mode)
    {
      this._data.targetMode = mode;
      return this;
    }

    public CardDataBuilder WithTargetMode(string mode = "TargetModeBasic")
    {
      this._data.targetMode = Extensions.GetTargetMode(mode);
      return this;
    }

    public CardDataBuilder WithPlayType(Card.PlayType type)
    {
      this._data.playType = type;
      return this;
    }

    public CardDataBuilder SetAttackEffect(params CardData.StatusEffectStacks[] stacks)
    {
      this._data.attackEffects = stacks;
      return this;
    }

    public CardDataBuilder WithIdleAnimationProfile(CardAnimationProfile bp)
    {
      this._data.idleAnimationProfile = bp;
      return this;
    }

    public CardDataBuilder WithIdleAnimationProfile(string bp = "SwayAnimationProfile")
    {
      return this.WithIdleAnimationProfile(Extensions.GetCardAnimationProfile(bp));
    }

    public CardDataBuilder WithBloodProfile(BloodProfile bp)
    {
      this._data.bloodProfile = bp;
      return this;
    }

    public CardDataBuilder WithBloodProfile(string bp = "Blood Profile Normal")
    {
      return this.WithBloodProfile(this.Mod.GetAsset<BloodProfile>(bp));
    }

    public CardDataBuilder CanPlayOnBoard(bool value = true)
    {
      this._data.canPlayOnBoard = value;
      return this;
    }

    public CardDataBuilder CanPlayOnEnemy(bool value = true)
    {
      this._data.canPlayOnEnemy = value;
      return this;
    }

    public CardDataBuilder CanPlayOnFriendly(bool value = true)
    {
      this._data.canPlayOnFriendly = value;
      return this;
    }

    public CardDataBuilder CanPlayOnHand(bool value = true)
    {
      this._data.canPlayOnHand = value;
      return this;
    }

    public CardDataBuilder CanBeHit(bool value = true)
    {
      this._data.canBeHit = value;
      return this;
    }

    public CardDataBuilder CanShoveToOtherRow(bool value = true)
    {
      this._data.canShoveToOtherRow = value;
      return this;
    }

    public CardDataBuilder AsUnit(string targetMode = "TargetModeBasic", string idleAnim = "SwayAnimationProfile", string bloodProfile = "Blood Profile Normal")
    {
      this._data.canPlayOnEnemy = true;
      this._data.canBeHit = true;
      this._data.playType = Card.PlayType.Place;
      this._data.canPlayOnBoard = true;
      this._data.cardType = this.Mod.Get<CardType>("Friendly");
      return this.SetStats(new int?(0), new int?(0)).WithTargetMode(targetMode).WithBloodProfile(bloodProfile).WithIdleAnimationProfile(idleAnim);
    }

    public CardDataBuilder AsItem(string targetMode = "TargetModeBasic", string idleAnim = "SwayAnimationProfile")
    {
      this._data.canPlayOnEnemy = true;
      this._data.canBeHit = false;
      this._data.playType = Card.PlayType.Play;
      this._data.canPlayOnBoard = true;
      this._data.cardType = this.Mod.Get<CardType>("Item");
      return this.FreeModify((System.Action<CardData>) (a => a.uses = 1)).WithTargetMode(targetMode).WithIdleAnimationProfile(idleAnim).CanPlayOnHand(false);
    }

    public CardDataBuilder IsCompanion(ChallengeData challenge, bool value = true)
    {
      this.UnlockChallenge = challenge;
      if (value)
      {
        this._data.AddToCompanions();
        BuildingSequenceWithUnlocks<BuildingCardUnlockSequence>.OnStart += new RuntimeILReferenceBag.FastDelegateInvokers.Action<BuildingCardUnlockSequence>(this.UnlockSequenceOnOnStart<BuildingCardUnlockSequence>);
      }
      else
      {
        this._data.RemoveFromCompanions();
        BuildingSequenceWithUnlocks<BuildingCardUnlockSequence>.OnStart -= new RuntimeILReferenceBag.FastDelegateInvokers.Action<BuildingCardUnlockSequence>(this.UnlockSequenceOnOnStart<BuildingCardUnlockSequence>);
      }
      return this;
    }

    public CardDataBuilder IsItem(ChallengeData challenge, bool value = true)
    {
      this.UnlockChallenge = challenge;
      if (value)
      {
        this._data.AddToItems();
        BuildingSequenceWithUnlocks<InventorHutSequence>.OnStart += new RuntimeILReferenceBag.FastDelegateInvokers.Action<InventorHutSequence>(this.UnlockSequenceOnOnStart<InventorHutSequence>);
      }
      else
      {
        this._data.RemoveFromItems();
        BuildingSequenceWithUnlocks<InventorHutSequence>.OnStart -= new RuntimeILReferenceBag.FastDelegateInvokers.Action<InventorHutSequence>(this.UnlockSequenceOnOnStart<InventorHutSequence>);
      }
      return this;
    }

    public CardDataBuilder IsPet(string challenge, bool value = true)
    {
      return this.IsPet(this.Mod.Get<ChallengeData>(challenge), value);
    }

    public CardDataBuilder IsPet(ChallengeData challenge, bool value = true)
    {
      this.UnlockChallenge = challenge;
      if (value)
      {
        this._data.AddToPets((UnityEngine.Object) challenge == (UnityEngine.Object) null ? (string) null : challenge.name);
        BuildingSequenceWithUnlocks<PetHutSequence>.OnStart += new RuntimeILReferenceBag.FastDelegateInvokers.Action<PetHutSequence>(this.UnlockSequenceOnOnStart<PetHutSequence>);
      }
      else
      {
        this._data.RemoveFromPets();
        BuildingSequenceWithUnlocks<PetHutSequence>.OnStart -= new RuntimeILReferenceBag.FastDelegateInvokers.Action<PetHutSequence>(this.UnlockSequenceOnOnStart<PetHutSequence>);
      }
      return this;
    }

    private void UnlockSequenceOnOnStart<T>(BuildingSequenceWithUnlocks<T> obj) where T : BuildingSequenceWithUnlocks<T>
    {
      obj.AddSlot(this.UnlockChallenge);
    }

    public CardDataBuilder CreateItem(
      string name,
      string englishTitle,
      string targetMode = "TargetModeBasic",
      string idleAnim = "SwayAnimationProfile")
    {
      return this.Create(name).WithTitle(englishTitle).AsItem(targetMode, idleAnim);
    }

    [Obsolete("Reverse", true)]
    public CardDataBuilder CreateItem(
      string name,
      string englishTitle,
      string targetMode,
      string wtv,
      string idleAnim)
    {
      return this.Create(name).WithTitle(englishTitle).AsItem(targetMode, idleAnim);
    }

    public CardDataBuilder CreateUnit(
      string name,
      string englishTitle,
      string targetMode = "TargetModeBasic",
      string bloodProfile = "Blood Profile Normal",
      string idleAnim = "SwayAnimationProfile")
    {
      return this.Create(name).WithTitle(englishTitle).AsUnit(targetMode, idleAnim, bloodProfile);
    }

    public CardDataBuilder WithPools(params RewardPool[] pools)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data => data.WithPools(pools));
      return this;
    }

    public CardDataBuilder WithPools(params string[] pools)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data => data.WithPools(((IEnumerable<string>) pools).Select<string, RewardPool>(new System.Func<string, RewardPool>(Extensions.GetRewardPool)).ToArray<RewardPool>()));
      return this;
    }

    public CardDataBuilder AddPool(RewardPool pool)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data => data.AddPool(pool));
      return this;
    }

    public CardDataBuilder AddPool(string pool = "GeneralUnitPool")
    {
      this.AfterBuildEvent += (DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data => data.AddPool(Extensions.GetRewardPool(pool)));
      return this;
    }

    public CardDataBuilder WithCardType(CardType type)
    {
      this._data.cardType = type;
      return this;
    }

    public CardDataBuilder WithCardType(string type = "Friendly")
    {
      this._data.cardType = this.Mod.Get<CardType>(type);
      return this;
    }

    public CardDataBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public CardDataBuilder WithFlavour(LocalizedString flavour)
    {
      this._data.flavourKey = flavour;
      return this;
    }

    public CardDataBuilder WithText(LocalizedString text)
    {
      this._data.textKey = text;
      return this;
    }

    public CardDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public CardDataBuilder WithFlavour(string flavour, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_flavour", flavour);
      this._data.flavourKey = collection.GetString(this._data.name + "_flavour");
      return this;
    }

    public CardDataBuilder WithText(string text, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", text);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }

    ~CardDataBuilder() => UnityEngine.Object.Destroy((UnityEngine.Object) this._data);

    public CardDataBuilder Clone()
    {
      CardDataBuilder cardDataBuilder = new CardDataBuilder(this.Mod);
      cardDataBuilder._data = this._data.InstantiateKeepName<CardData>();
      return cardDataBuilder;
    }
  }
}
