// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CardDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using MonoMod.Cil;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CardDataBuilder : DataFileBuilder<CardData, CardDataBuilder>
  {
    public static readonly CardDataBuilder MissingCardBuilder = new CardDataBuilder((WildfrostMod) null).Create("MISSINGCARD").WithCardType().AsUnit().WithTitle("Card missing");
    private ChallengeData UnlockChallenge;

    public CardDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CardDataBuilder()
    {
    }

    public CardDataBuilder SetStats(int? health = null, int? damage = null, int counter = 0) => this.SetHealth(health).SetDamage(damage).SetCounter(counter);

    public CardDataBuilder SetCounter(int counter)
    {
      this._data.counter = counter;
      return this;
    }

    public CardDataBuilder SetDamage(int? damage)
    {
      if (damage.HasValue)
      {
        this._data.hasAttack = true;
        this._data.damage = damage.Value;
      }
      return this;
    }

    public CardDataBuilder SetNeedsTarget(bool value)
    {
      this._data.needsTarget = value;
      return this;
    }

    public CardDataBuilder SetCanBeHit(bool value)
    {
      this._data.canBeHit = value;
      return this;
    }

    public CardDataBuilder SetHealth(int? health)
    {
      if (health.HasValue)
      {
        this._data.hasHealth = true;
        this._data.hp = health.Value;
      }
      return this;
    }

    public CardDataBuilder SetSprites(Sprite mainSprite, Sprite backgroundSprite)
    {
      this._data.mainSprite = mainSprite;
      this._data.backgroundSprite = backgroundSprite;
      return this;
    }

    public CardDataBuilder SetSprites(string mainSprite, string backgroundSprite) => this.SetSprites(this.Mod.ImagePath(mainSprite).ToSprite(), this.Mod.ImagePath(backgroundSprite).ToSprite());

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

    public CardDataBuilder WithIdleAnimationProfile(string bp = "SwayAnimationProfile") => this.WithIdleAnimationProfile(Extensions.GetCardAnimationProfile(bp));

    public CardDataBuilder WithBloodProfile(BloodProfile bp)
    {
      this._data.bloodProfile = bp;
      return this;
    }

    public CardDataBuilder WithBloodProfile(string bp = "BloodProfileNormal") => this.WithBloodProfile(Extensions.GetBloodProfile(bp));

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

    public CardDataBuilder AsUnit()
    {
      this._data.canBeHit = true;
      this._data.playType = Card.PlayType.Place;
      this._data.canPlayOnBoard = true;
      return this;
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

    public CardDataBuilder IsPet(string challenge, bool value = true) => this.IsPet(Extensions.GetChallengeData(challenge), value);

    public CardDataBuilder IsPet(ChallengeData challenge, bool value = true)
    {
      this.UnlockChallenge = challenge;
      if (value)
      {
        this._data.AddToPets();
        BuildingSequenceWithUnlocks<PetHutSequence>.OnStart += new RuntimeILReferenceBag.FastDelegateInvokers.Action<PetHutSequence>(this.UnlockSequenceOnOnStart<PetHutSequence>);
      }
      else
      {
        this._data.RemoveFromPets();
        BuildingSequenceWithUnlocks<PetHutSequence>.OnStart -= new RuntimeILReferenceBag.FastDelegateInvokers.Action<PetHutSequence>(this.UnlockSequenceOnOnStart<PetHutSequence>);
      }
      return this;
    }

    private void UnlockSequenceOnOnStart<T>(BuildingSequenceWithUnlocks<T> obj) where T : BuildingSequenceWithUnlocks<T> => obj.AddSlot(this.UnlockChallenge);

    public override CardDataBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = ScriptableObject.CreateInstance<CardData>();
      this._data.name = name;
      return this;
    }

    public CardDataBuilder CreateItem(
      string name,
      string englishTitle,
      string targetMode = "TargetModeBasic",
      string cardType = "Item",
      string ildeAnim = "SwayAnimationProfile")
    {
      return this.Create(name).WithTitle(englishTitle).AddPool().CanPlayOnEnemy().CanPlayOnBoard().CanBeHit(false).WithPlayType(Card.PlayType.Play).WithTargetMode(targetMode).FreeModify((System.Action<CardData>) (a => a.uses = 1)).WithIdleAnimationProfile(ildeAnim).WithCardType(cardType);
    }

    public CardDataBuilder CreateUnit(
      string name,
      string englishTitle,
      string targetMode = "TargetModeBasic",
      string cardType = "Friendly",
      string bloodProfile = "BloodProfileNormal",
      string ildeAnim = "SwayAnimationProfile")
    {
      return this.Create(name).WithTitle(englishTitle).AsUnit().AddPool().CanPlayOnEnemy().CanPlayOnBoard().WithTargetMode(targetMode).WithBloodProfile(bloodProfile).WithIdleAnimationProfile(ildeAnim).WithCardType(cardType).SetStats(new int?(0), new int?(0));
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
      this._data.cardType = Extensions.GetCardType(type);
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
