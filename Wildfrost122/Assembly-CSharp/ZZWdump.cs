// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BattleDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BattleDataBuilder : DataFileBuilder<BattleData, BattleDataBuilder>
  {
    public BattleDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BattleDataBuilder()
    {
    }

    public BattleDataBuilder WithTitle(string title)
    {
      this._data.title = title;
      return this;
    }

    public BattleDataBuilder WithPointFactor(float factor = 1f)
    {
      this._data.pointFactor = factor;
      return this;
    }

    public BattleDataBuilder WithWaveCounter(int waveCounter = 4)
    {
      this._data.waveCounter = waveCounter;
      return this;
    }

    public BattleDataBuilder WithPools(params BattleWavePoolData[] pools)
    {
      this._data.pools = pools;
      return this;
    }

    public BattleDataBuilder WithBonusUnitPool(params CardData[] pools)
    {
      this._data.bonusUnitPool = pools;
      return this;
    }

    public BattleDataBuilder WithBonusUnitRange(Vector2Int v)
    {
      this._data.bonusUnitRange = v;
      return this;
    }

    public BattleDataBuilder WithGoldGiverPool(params CardData[] pools)
    {
      this._data.goldGiverPool = pools;
      return this;
    }

    public BattleDataBuilder WithGoldGivers(int amount = 1)
    {
      this._data.goldGivers = amount;
      return this;
    }

    public BattleDataBuilder WithGenerationScript(BattleGenerationScript s)
    {
      this._data.generationScript = s;
      return this;
    }

    public BattleDataBuilder WithSetUpScript(Script s)
    {
      this._data.setUpScript = s;
      return this;
    }

    public BattleDataBuilder WithSprite(Sprite sprite)
    {
      this._data.sprite = sprite;
      return this;
    }

    public BattleDataBuilder WithSprite(string sprite)
    {
      this._data.sprite = this.Mod.GetImageSprite(sprite);
      return this;
    }

    public BattleDataBuilder WithName(string name, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_ref", name);
      this._data.nameRef = collection.GetString(this._data.name + "_ref");
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BossRewardDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BossRewardDataBuilder : DataFileBuilder<BossRewardData, BossRewardDataBuilder>
  {
    public BossRewardDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BossRewardDataBuilder()
    {
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BuildingPlotTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BuildingPlotTypeBuilder : DataFileBuilder<BuildingPlotType, BuildingPlotTypeBuilder>
  {
    public BuildingPlotTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BuildingPlotTypeBuilder()
    {
    }

    public BuildingPlotTypeBuilder WithIllegalBuildings(params BuildingType[] illegalBuildings)
    {
      this._data.illegalBuildings = illegalBuildings;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BuildingTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BuildingTypeBuilder : DataFileBuilder<BuildingType, BuildingTypeBuilder>
  {
    public BuildingTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BuildingTypeBuilder()
    {
    }

    public BuildingTypeBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public BuildingTypeBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_building_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_building_title");
      return this;
    }

    public BuildingTypeBuilder WithHelp(LocalizedString title)
    {
      this._data.helpKey = title;
      return this;
    }

    public BuildingTypeBuilder WithHelp(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_building_help", title);
      this._data.helpKey = collection.GetString(this._data.name + "_building_help");
      return this;
    }

    public BuildingTypeBuilder WithHelpEmoteType(Prompt.Emote.Type helpEmoteType = Prompt.Emote.Type.Explain)
    {
      this._data.helpEmoteType = helpEmoteType;
      return this;
    }

    public BuildingTypeBuilder WithStarted(UnlockData started)
    {
      this._data.started = started;
      return this;
    }

    public BuildingTypeBuilder WithFinished(UnlockData finished)
    {
      this._data.finished = finished;
      return this;
    }

    public BuildingTypeBuilder WithUnlocks(params UnlockData[] unlocks)
    {
      this._data.unlocks = unlocks;
      return this;
    }

    public BuildingTypeBuilder WithUnlockedCheckedKey(string unlockedCheckedKey)
    {
      this._data.unlockedCheckedKey = unlockedCheckedKey;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CampaignNodeTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CampaignNodeTypeBuilder : DataFileBuilder<CampaignNodeType, CampaignNodeTypeBuilder>
  {
    public CampaignNodeTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CampaignNodeTypeBuilder()
    {
    }

    public CampaignNodeTypeBuilder WithLetter(string letter)
    {
      this._data.letter = letter;
      return this;
    }

    public CampaignNodeTypeBuilder WithZoneName(string zoneName)
    {
      this._data.zoneName = zoneName;
      return this;
    }

    public CampaignNodeTypeBuilder WithMustClear(bool mustClear)
    {
      this._data.mustClear = mustClear;
      return this;
    }

    public CampaignNodeTypeBuilder WithCanSkip(bool canSkip)
    {
      this._data.canSkip = canSkip;
      return this;
    }

    public CampaignNodeTypeBuilder WithCanEnter(bool canEnter)
    {
      this._data.canEnter = canEnter;
      return this;
    }

    public CampaignNodeTypeBuilder WithIsBattle(bool isBattle)
    {
      this._data.isBattle = isBattle;
      return this;
    }

    public CampaignNodeTypeBuilder WithIsBoss(bool isBoss)
    {
      this._data.isBoss = isBoss;
      return this;
    }

    public CampaignNodeTypeBuilder WithModifierReward(bool modifierReward)
    {
      this._data.modifierReward = modifierReward;
      return this;
    }

    public CampaignNodeTypeBuilder WithInteractable(bool interactable)
    {
      this._data.interactable = interactable;
      return this;
    }

    public CampaignNodeTypeBuilder WithStartRevealed(bool startRevealed)
    {
      this._data.startRevealed = startRevealed;
      return this;
    }

    public CampaignNodeTypeBuilder WithFinalNode(bool finalNode)
    {
      this._data.finalNode = finalNode;
      return this;
    }

    public CampaignNodeTypeBuilder WithMapNodePrefab(MapNode mapNodePrefab)
    {
      this._data.mapNodePrefab = mapNodePrefab;
      return this;
    }

    public CampaignNodeTypeBuilder WithMapNodeSprite(Sprite mapNodeSprite)
    {
      this._data.mapNodeSprite = mapNodeSprite;
      return this;
    }

    public CampaignNodeTypeBuilder WithMapNodeSprite(string mapNodeSprite)
    {
      this._data.mapNodeSprite = this.Mod.GetImageSprite(mapNodeSprite);
      return this;
    }

    public CampaignNodeTypeBuilder WithSize(float size = 1f)
    {
      this._data.size = size;
      return this;
    }

    public CampaignNodeTypeBuilder WithCanLink(bool canLink)
    {
      this._data.canLink = canLink;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
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
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CardTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CardTypeBuilder : DataFileBuilder<CardType, CardTypeBuilder>
  {
    public CardTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CardTypeBuilder()
    {
    }

    public CardTypeBuilder WithSortPriority(int sortPriority)
    {
      this._data.sortPriority = sortPriority;
      return this;
    }

    public CardTypeBuilder WithIcon(Sprite icon)
    {
      this._data.icon = icon;
      return this;
    }

    public CardTypeBuilder WithIcon(string icon)
    {
      this._data.icon = this.Mod.GetImageSprite(icon);
      return this;
    }

    public CardTypeBuilder WithPrefabRef(AssetReference prefabRef)
    {
      this._data.prefabRef = prefabRef;
      return this;
    }

    public CardTypeBuilder WithTextBoxSprite(Sprite icon)
    {
      this._data.textBoxSprite = icon;
      return this;
    }

    public CardTypeBuilder WithTextBoxSprite(string icon)
    {
      this._data.textBoxSprite = this.Mod.GetImageSprite(icon);
      return this;
    }

    public CardTypeBuilder WithNameTagSprite(Sprite icon)
    {
      this._data.nameTagSprite = icon;
      return this;
    }

    public CardTypeBuilder WithNameTagSprite(string icon)
    {
      this._data.nameTagSprite = this.Mod.GetImageSprite(icon);
      return this;
    }

    public CardTypeBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_type_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_type_title");
      return this;
    }

    public CardTypeBuilder WithTitle(LocalizedString str)
    {
      this._data.titleKey = str;
      return this;
    }

    public CardTypeBuilder WithCanDie(bool canDie)
    {
      this._data.canDie = canDie;
      return this;
    }

    public CardTypeBuilder WithCanTakeCrown(bool canTakeCrown)
    {
      this._data.canTakeCrown = canTakeCrown;
      return this;
    }

    public CardTypeBuilder WithCanRecall(bool canRecall)
    {
      this._data.canRecall = canRecall;
      return this;
    }

    public CardTypeBuilder WithCanReserve(bool canReserve)
    {
      this._data.canReserve = canReserve;
      return this;
    }

    public CardTypeBuilder WithItem(bool item)
    {
      this._data.item = item;
      return this;
    }

    public CardTypeBuilder WithUnit(bool unit)
    {
      this._data.unit = unit;
      return this;
    }

    public CardTypeBuilder WithTag(string tag)
    {
      this._data.tag = tag;
      return this;
    }

    public CardTypeBuilder WithMiniboss(bool miniboss)
    {
      this._data.miniboss = miniboss;
      return this;
    }

    public CardTypeBuilder WithDiscoverInJournal(bool discoverInJournal)
    {
      this._data.discoverInJournal = discoverInJournal;
      return this;
    }

    public CardTypeBuilder WithDescriptionColours(Text.ColourProfileHex descriptionColours)
    {
      this._data.descriptionColours = descriptionColours;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CardUpgradeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using MonoMod.Cil;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CardUpgradeDataBuilder : DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>
  {
    private ChallengeData UnlockChallenge;

    public CardUpgradeDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CardUpgradeDataBuilder()
    {
    }

    public CardUpgradeDataBuilder CreateCharm(string name)
    {
      return this.Create(name).WithType(CardUpgradeData.Type.Charm).AddPool();
    }

    public CardUpgradeDataBuilder WithPools(params RewardPool[] pools)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.WithPools(pools));
      return this;
    }

    public CardUpgradeDataBuilder WithPools(params string[] pools)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.WithPools(((IEnumerable<string>) pools).Select<string, RewardPool>(new System.Func<string, RewardPool>(Extensions.GetRewardPool)).ToArray<RewardPool>()));
      return this;
    }

    public CardUpgradeDataBuilder AddPool(RewardPool pool)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.AddPool(pool));
      return this;
    }

    public CardUpgradeDataBuilder AddPool(string pool = "GeneralCharmPool")
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.AddPool(Extensions.GetRewardPool(pool)));
      return this;
    }

    public CardUpgradeDataBuilder WithTier(int tier)
    {
      this._data.tier = tier;
      return this;
    }

    public CardUpgradeDataBuilder WithImage(Sprite img)
    {
      this._data.image = img;
      return this;
    }

    public CardUpgradeDataBuilder WithType(CardUpgradeData.Type type)
    {
      this._data.type = type;
      return this;
    }

    public CardUpgradeDataBuilder SetAttackEffects(params CardData.StatusEffectStacks[] efs)
    {
      this._data.attackEffects = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetEffects(params CardData.StatusEffectStacks[] efs)
    {
      this._data.effects = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetTraits(params CardData.TraitStacks[] efs)
    {
      this._data.giveTraits = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetScripts(params CardScript[] efs)
    {
      this._data.scripts = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetConstraints(params TargetConstraint[] efs)
    {
      this._data.targetConstraints = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetBecomesTarget(bool val)
    {
      this._data.becomesTargetedCard = val;
      return this;
    }

    public CardUpgradeDataBuilder SetCanBeRemoved(bool val)
    {
      this._data.canBeRemoved = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeDamage(int val)
    {
      this._data.damage = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeHP(int val)
    {
      this._data.hp = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeCounter(int val)
    {
      this._data.counter = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeUses(int val)
    {
      this._data.uses = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeEffectBonus(int val)
    {
      this._data.effectBonus = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetDamage(bool val)
    {
      this._data.setDamage = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetHP(bool val)
    {
      this._data.setHp = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetCounter(bool val)
    {
      this._data.setCounter = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetUses(bool val)
    {
      this._data.setUses = val;
      return this;
    }

    public CardUpgradeDataBuilder IsCharm(ChallengeData challenge, bool value = true)
    {
      this.UnlockChallenge = challenge;
      if (value)
      {
        this._data.AddToCharms(challenge.reward);
        BuildingSequenceWithUnlocks<ChallengeShrineSequence>.OnStart += new RuntimeILReferenceBag.FastDelegateInvokers.Action<ChallengeShrineSequence>(this.UnlockSequenceOnOnStart<ChallengeShrineSequence>);
      }
      else
      {
        this._data.RemoveFromCharms(challenge.reward);
        BuildingSequenceWithUnlocks<ChallengeShrineSequence>.OnStart -= new RuntimeILReferenceBag.FastDelegateInvokers.Action<ChallengeShrineSequence>(this.UnlockSequenceOnOnStart<ChallengeShrineSequence>);
      }
      return this;
    }

    private void UnlockSequenceOnOnStart<T>(BuildingSequenceWithUnlocks<T> obj) where T : BuildingSequenceWithUnlocks<T>
    {
      obj.AddChallengeStone(this.UnlockChallenge);
    }

    public CardUpgradeDataBuilder WithImage(string img)
    {
      this._data.image = this.Mod.ImagePath(img).ToSprite();
      return this;
    }

    public CardUpgradeDataBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public CardUpgradeDataBuilder WithText(LocalizedString text)
    {
      this._data.textKey = text;
      return this;
    }

    public CardUpgradeDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Upgrades", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public CardUpgradeDataBuilder WithText(string text, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Upgrades", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", text);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ChallengeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ChallengeDataBuilder : DataFileBuilder<ChallengeData, ChallengeDataBuilder>
  {
    public ChallengeDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public ChallengeDataBuilder WithTitle(LocalizedString str)
    {
      this._data.titleKey = str;
      return this;
    }

    public ChallengeDataBuilder WithText(LocalizedString str)
    {
      this._data.textKey = str;
      return this;
    }

    public ChallengeDataBuilder WithRewardText(LocalizedString str)
    {
      this._data.rewardKey = str;
      return this;
    }

    public ChallengeDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public ChallengeDataBuilder WithText(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", title);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }

    public ChallengeDataBuilder()
    {
    }

    public ChallengeDataBuilder WithRewardText(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_reward", title);
      this._data.rewardKey = collection.GetString(this._data.name + "_reward");
      return this;
    }

    public ChallengeDataBuilder WithGoal(int amountGoal)
    {
      this._data.goal = amountGoal;
      return this;
    }

    public ChallengeDataBuilder WithListener(ChallengeListener listener)
    {
      this._data.listener = listener;
      return this;
    }

    public ChallengeDataBuilder WithListener(string listener)
    {
      this._data.listener = this.Mod.Get<ChallengeListener>(listener);
      return this;
    }

    public ChallengeDataBuilder WithIcon(Sprite icon)
    {
      this._data.icon = icon;
      return this;
    }

    public ChallengeDataBuilder WithRequires(params ChallengeData[] requires)
    {
      this._data.requires = requires;
      return this;
    }

    public ChallengeDataBuilder WithRequires(params string[] requires)
    {
      this._data.requires = ((IEnumerable<string>) requires).Select<string, ChallengeData>(new Func<string, ChallengeData>(this.Mod.Get<ChallengeData>)).ToArray<ChallengeData>();
      return this;
    }

    public ChallengeDataBuilder WithReward(UnlockData reward)
    {
      this._data.reward = reward;
      return this;
    }

    public ChallengeDataBuilder WithReward(string reward)
    {
      this._data.reward = this.Mod.Get<UnlockData>(reward);
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ChallengeListenerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ChallengeListenerBuilder : 
    DataFileBuilder<ChallengeListener, ChallengeListenerBuilder>
  {
    public ChallengeListenerBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public ChallengeListenerBuilder()
    {
    }

    public ChallengeListenerBuilder WithKey(string key)
    {
      this._data.key = key;
      this._data.hasKey = true;
      return this;
    }

    public ChallengeListenerBuilder WithCheckType(ChallengeListener.CheckType type)
    {
      this._data.checkType = type;
      return this;
    }

    public ChallengeListenerBuilder WithStat(string stat)
    {
      this._data.stat = stat;
      return this;
    }

    public ChallengeListenerBuilder WithStat(int toReach)
    {
      this._data.target = toReach;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ClassDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ClassDataBuilder : DataFileBuilder<ClassData, ClassDataBuilder>
  {
    public ClassDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public ClassDataBuilder()
    {
    }

    public ClassDataBuilder WithRequiresUnlock(UnlockData requiresUnlock)
    {
      this._data.requiresUnlock = requiresUnlock;
      return this;
    }

    public ClassDataBuilder WithStartingInventory(Inventory startingInventory)
    {
      this._data.startingInventory = startingInventory;
      return this;
    }

    public ClassDataBuilder WithLeaders(params CardData[] leaders)
    {
      this._data.leaders = leaders;
      return this;
    }

    public ClassDataBuilder WithCharacterPrefab(Character characterPrefab)
    {
      this._data.characterPrefab = characterPrefab;
      return this;
    }

    public ClassDataBuilder WithRewardPools(params RewardPool[] rewardPools)
    {
      this._data.rewardPools = rewardPools;
      return this;
    }

    public ClassDataBuilder WithSelectSfxEvent(EventReference selectSfxEvent)
    {
      this._data.selectSfxEvent = selectSfxEvent;
      return this;
    }

    public ClassDataBuilder WithFlag(Sprite flag)
    {
      this._data.flag = flag;
      return this;
    }

    public ClassDataBuilder WithFlag(string flag)
    {
      this._data.flag = this.Mod.GetImageSprite(flag);
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.DataFileBuilder`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public abstract class DataFileBuilder<T, Y>
    where T : DataFile
    where Y : DataFileBuilder<T, Y>, new()
  {
    internal T _data;
    public WildfrostMod Mod;

    protected virtual T BuildInstance() => this._data.InstantiateKeepName<T>();

    public T Build()
    {
      T d = this.BuildInstance();
      this.OnAfterBuildEvent(d);
      return d;
    }

    protected DataFileBuilder(WildfrostMod mod) => this.Mod = mod;

    protected DataFileBuilder()
    {
    }

    public Y FreeModify(Action<T> action)
    {
      if (action != null)
        action(this._data);
      return (Y) this;
    }

    public Y FreeModify<D>(Action<D> action) where D : T
    {
      if (action != null)
        action((object) this._data as D);
      return (Y) this;
    }

    public event DataFileBuilder<T, Y>.AfterBuildDelegate AfterBuildEvent;

    public event DataFileBuilder<T, Y>.AfterBuildDelegate AfterAllModBuildsEvent;

    public virtual Y Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if ((object) this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = ScriptableObject.CreateInstance<T>();
      this._data.name = name;
      return this as Y;
    }

    public virtual Y Create<X>(string name) where X : T
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if ((object) this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = (T) ScriptableObject.CreateInstance<X>();
      this._data.name = name;
      return this as Y;
    }

    public static implicit operator T(DataFileBuilder<T, Y> t) => t.Build();

    public virtual Y SubscribeToBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterBuildEvent += d;
      return (Y) this;
    }

    public virtual Y UnsubscribeToBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterBuildEvent -= d;
      return (Y) this;
    }

    public virtual Y SubscribeToAfterAllBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterAllModBuildsEvent += d;
      return (Y) this;
    }

    public virtual Y UnubscribeToAfterAllBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterAllModBuildsEvent -= d;
      return (Y) this;
    }

    protected virtual void OnAfterBuildEvent(T d)
    {
      DataFileBuilder<T, Y>.AfterBuildDelegate afterBuildEvent = this.AfterBuildEvent;
      if (afterBuildEvent == null)
        return;
      afterBuildEvent(d);
    }

    internal virtual void OnAfterAllModBuildsEvent(T d)
    {
      DataFileBuilder<T, Y>.AfterBuildDelegate allModBuildsEvent = this.AfterAllModBuildsEvent;
      if (allModBuildsEvent == null)
        return;
      allModBuildsEvent(d);
    }

    public delegate void AfterBuildDelegate(T d)
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new();
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.Extensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public static class Extensions
  {
    public static CardData[] GetCategoryCardData(string category, bool mustBeFinal = true)
    {
      return AddressableLoader.GetGroup<CardData>("CardData").FindAll(new Predicate<CardData>(Condition)).ToArray();

      bool Condition(CardData a)
      {
        if ((!(a.cardType.name == category) || a.isEnemyClunker) && (!(a.cardType.name == "Clunker") || !a.isEnemyClunker || !(category == "Enemy")))
          return false;
        if (!mustBeFinal)
          return true;
        LocalizedString titleKey = a.titleKey;
        return titleKey != null && !titleKey.IsEmpty;
      }
    }

    public static StatusEffectDataBuilder SetSummonPrefabRef(
      this StatusEffectDataBuilder inst,
      string name = "SummonCreateCard")
    {
      inst.FreeModify<StatusEffectSummon>((Action<StatusEffectSummon>) (summon => summon.effectPrefabRef = (AssetReference) new AssetReferenceGameObject(name)));
      return inst;
    }

    public static bool IsCharm(this CardUpgradeData inst)
    {
      return MetaprogressionSystem.Get<List<string>>("charms").Contains(inst.name);
    }

    public static void AddToCharms(this CardUpgradeData inst, UnlockData data)
    {
      MetaprogressionSystem.Add<string, string>("charms", data.name, inst.name);
    }

    public static bool RemoveFromCharms(this CardUpgradeData inst, UnlockData data)
    {
      return MetaprogressionSystem.Remove<string, string>("charms", data.name, inst.name);
    }

    public static bool IsCompanion(this CardData inst)
    {
      return MetaprogressionSystem.Get<List<string>>("companions").Contains(inst.name);
    }

    public static void AddToCompanions(this CardData inst)
    {
      MetaprogressionSystem.Add<string>("companions", inst.name);
    }

    public static bool RemoveFromCompanions(this CardData inst)
    {
      return MetaprogressionSystem.Remove<string>("companions", inst.name);
    }

    public static bool IsItem(this CardData inst)
    {
      return MetaprogressionSystem.Get<List<string>>("items").Contains(inst.name);
    }

    public static void AddToItems(this CardData inst)
    {
      MetaprogressionSystem.Add<string>("items", inst.name);
    }

    public static bool RemoveFromItems(this CardData inst)
    {
      return MetaprogressionSystem.Remove<string>("items", inst.name);
    }

    public static bool IsPet(this CardData inst)
    {
      return MetaprogressionSystem.Get<Dictionary<string, string>>("pets").ContainsKey(inst.name);
    }

    public static void AddToPets(this CardData inst, string requiredUnlock = null)
    {
      MetaprogressionSystem.Add<string, string>("pets", inst.name, requiredUnlock);
    }

    public static bool RemoveFromPets(this CardData inst)
    {
      return MetaprogressionSystem.Remove<string, string>("pets", inst.name, (string) null);
    }

    public static T[] RemoveFromArray<T>(this T[] sequence, T item)
    {
      return ((IEnumerable<T>) sequence).Where<T>((Func<T, bool>) (a => !a.Equals((object) (T) item))).ToArray<T>();
    }

    public static T[] RemoveFromArray<T>(this T[] sequence, Func<T, bool> item)
    {
      return ((IEnumerable<T>) sequence).Where<T>(item).ToArray<T>();
    }

    public static string PrefixGUID(string name, WildfrostMod mod)
    {
      return mod == null ? name : mod.GUID + "." + name;
    }

    public static string GetGUID(string name)
    {
      string str = name;
      int num1 = 0;
      int num2 = name.LastIndexOf('.') - num1;
      int startIndex = num1;
      int length = num2;
      return str.Substring(startIndex, length);
    }

    public static WildfrostMod GetModFromGuid(string guid)
    {
      return Bootstrap.Mods.ToList<WildfrostMod>().Find((Predicate<WildfrostMod>) (a => a.GUID == guid));
    }

    public static CardAnimationProfile GetCardAnimationProfile(string name)
    {
      return Addressables.LoadAssetAsync<CardAnimationProfile>((object) name).WaitForCompletion();
    }

    public static TargetMode GetTargetMode(string name)
    {
      return Addressables.LoadAssetAsync<TargetMode>((object) name).WaitForCompletion();
    }

    public static void WithPools(this CardData data, params RewardPool[] pools)
    {
      foreach (RewardPool pool in pools)
        pool.list.Add((DataFile) data);
    }

    public static void AddPool(this CardData data, RewardPool pool)
    {
      pool.list.Add((DataFile) data);
    }

    public static void WithPools(this CardUpgradeData data, params RewardPool[] pools)
    {
      foreach (RewardPool pool in pools)
        pool.list.Add((DataFile) data);
    }

    public static void AddPool(this CardUpgradeData data, RewardPool pool)
    {
      pool.list.Add((DataFile) data);
    }

    public static LocalizedString GetLocalizedString(string table, string key)
    {
      return LocalizationHelper.GetCollection(table, new LocaleIdentifier(SystemLanguage.English)).GetString(key);
    }

    public static HashSet<RewardPool> GetAllRewardPools()
    {
      HashSet<RewardPool> list = new HashSet<RewardPool>();
      foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
        list.AddRange<RewardPool>((IEnumerable<RewardPool>) classData.rewardPools);
      return list;
    }

    public static Y Edit<T, Y>(this T data)
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      Y y = new Y();
      y.Mod = data.ModAdded ?? (WildfrostMod) new InternalMod((string) null);
      y._data = data;
      return y;
    }

    public static RewardPool GetRewardPool(string name)
    {
      foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
      {
        foreach (RewardPool rewardPool in classData.rewardPools)
        {
          if (rewardPool.name == name)
            return rewardPool;
        }
      }
      return (RewardPool) null;
    }

    public static Texture2D ToTex(this string path)
    {
      Texture2D tex = new Texture2D(0, 0, TextureFormat.RGBA32, false);
      if (!File.Exists(path))
        return tex;
      tex.LoadImage(File.ReadAllBytes(path));
      return tex;
    }

    public static Sprite ToSprite(this string path) => path.ToTex().ToSprite();

    public static Sprite ToSprite(this Texture2D t, Vector2? v = null)
    {
      Vector2 pivot = v ?? new Vector2(0.5f, 0.5f);
      return Sprite.Create(t, new Rect(0.0f, 0.0f, (float) t.width, (float) t.height), pivot);
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.EyeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class EyeDataBuilder : DataFileBuilder<EyeData, EyeDataBuilder>
  {
    public EyeDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public EyeDataBuilder()
    {
    }

    public EyeDataBuilder WithCardData(string cardData)
    {
      this._data.cardData = cardData;
      return this;
    }

    public EyeDataBuilder WithCardData(CardData cardData)
    {
      this._data.cardData = cardData.name;
      return this;
    }

    public EyeDataBuilder WithEyes(params EyeData.Eye[] eyes)
    {
      this._data.eyes = eyes;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.GameModeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class GameModeBuilder : DataFileBuilder<GameMode, GameModeBuilder>
  {
    public GameModeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public GameModeBuilder()
    {
    }

    public GameModeBuilder WithSaveFileName(string saveFileName)
    {
      this._data.saveFileName = saveFileName;
      return this;
    }

    public GameModeBuilder WithSeed(string seed)
    {
      this._data.seed = seed;
      return this;
    }

    public GameModeBuilder WithClasses(params ClassData[] classes)
    {
      this._data.classes = classes;
      return this;
    }

    public GameModeBuilder WithGenerator(CampaignGenerator generator)
    {
      this._data.generator = generator;
      return this;
    }

    public GameModeBuilder WithPopulator(CampaignPopulator populator)
    {
      this._data.populator = populator;
      return this;
    }

    public GameModeBuilder WithStartInNode(bool startInNode)
    {
      this._data.startInNode = startInNode;
      return this;
    }

    public GameModeBuilder WithTakeStartingPet(bool takeStartingPet = true)
    {
      this._data.takeStartingPet = takeStartingPet;
      return this;
    }

    public GameModeBuilder WithCountsAsWin(bool countsAsWin = true)
    {
      this._data.countsAsWin = countsAsWin;
      return this;
    }

    public GameModeBuilder WithShowStats(bool showStats = true)
    {
      this._data.showStats = showStats;
      return this;
    }

    public GameModeBuilder WithGainProgress(bool gainProgress = true)
    {
      this._data.gainProgress = gainProgress;
      return this;
    }

    public GameModeBuilder WithDoSave(bool doSave = true)
    {
      this._data.doSave = doSave;
      return this;
    }

    public GameModeBuilder WithCanRestart(bool canRestart = true)
    {
      this._data.canRestart = canRestart;
      return this;
    }

    public GameModeBuilder WithCanGoBack(bool canGoBack = true)
    {
      this._data.canGoBack = canGoBack;
      return this;
    }

    public GameModeBuilder WithSubmitScore(bool submitScore = false)
    {
      this._data.submitScore = submitScore;
      return this;
    }

    public GameModeBuilder WithMainGameMode(bool mainGameMode = true)
    {
      this._data.mainGameMode = mainGameMode;
      return this;
    }

    public GameModeBuilder WithDailyRun(bool dailyRun = false)
    {
      this._data.dailyRun = dailyRun;
      return this;
    }

    public GameModeBuilder WithTutorialRun(bool tutorialRun = false)
    {
      this._data.tutorialRun = tutorialRun;
      return this;
    }

    public GameModeBuilder WithLeaderboardType(Scores.Type leaderboardType)
    {
      this._data.leaderboardType = leaderboardType;
      return this;
    }

    public GameModeBuilder WithStartScene(string startScene)
    {
      this._data.startScene = startScene;
      return this;
    }

    public GameModeBuilder WithSceneAfterSelection(string sceneAfterSelection = "Campaign")
    {
      this._data.sceneAfterSelection = sceneAfterSelection;
      return this;
    }

    public GameModeBuilder WithCampaignSystemNames(params string[] campaignSystemNames)
    {
      this._data.campaignSystemNames = campaignSystemNames;
      return this;
    }

    public GameModeBuilder WithSystemsToDisable(params string[] systemsToDisable)
    {
      this._data.systemsToDisable = systemsToDisable;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.GameModifierDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class GameModifierDataBuilder : DataFileBuilder<GameModifierData, GameModifierDataBuilder>
  {
    public GameModifierDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public GameModifierDataBuilder()
    {
    }

    public GameModifierDataBuilder WithValue(int value = 100)
    {
      this._data.value = value;
      return this;
    }

    public GameModifierDataBuilder WithVisible(bool visible = true)
    {
      this._data.visible = visible;
      return this;
    }

    public GameModifierDataBuilder WithBellSprite(Sprite bellSprite)
    {
      this._data.bellSprite = bellSprite;
      return this;
    }

    public GameModifierDataBuilder WithBellSprite(string bellSprite)
    {
      this._data.bellSprite = this.Mod.GetImageSprite(bellSprite);
      return this;
    }

    public GameModifierDataBuilder WithDingerSprite(Sprite dingerSprite)
    {
      this._data.dingerSprite = dingerSprite;
      return this;
    }

    public GameModifierDataBuilder WithDingerSprite(string dingerSprite)
    {
      this._data.dingerSprite = this.Mod.GetImageSprite(dingerSprite);
      return this;
    }

    public GameModifierDataBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public GameModifierDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_modifier_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_modifier_title");
      return this;
    }

    public GameModifierDataBuilder WithDescription(LocalizedString title)
    {
      this._data.descriptionKey = title;
      return this;
    }

    public GameModifierDataBuilder WithDescription(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_modifier_desc", title);
      this._data.descriptionKey = collection.GetString(this._data.name + "_modifier_desc");
      return this;
    }

    public GameModifierDataBuilder WithSystemsToAdd(params string[] systemsToAdd)
    {
      this._data.systemsToAdd = systemsToAdd;
      return this;
    }

    public GameModifierDataBuilder WithSetupScripts(params Script[] setupScripts)
    {
      this._data.setupScripts = setupScripts;
      return this;
    }

    public GameModifierDataBuilder WithStartScripts(params Script[] startScripts)
    {
      this._data.startScripts = startScripts;
      return this;
    }

    public GameModifierDataBuilder WithScriptPriority(int scriptPriority)
    {
      this._data.scriptPriority = scriptPriority;
      return this;
    }

    public GameModifierDataBuilder WithBlockedBy(params GameModifierData[] blockedBy)
    {
      this._data.blockedBy = blockedBy;
      return this;
    }

    public GameModifierDataBuilder WithLinkedStormBell(HardModeModifierData linkedStormBell)
    {
      this._data.linkedStormBell = linkedStormBell;
      return this;
    }

    public GameModifierDataBuilder WithRingSfxEvent(EventReference ringSfxEvent)
    {
      this._data.ringSfxEvent = ringSfxEvent;
      return this;
    }

    public GameModifierDataBuilder WithRingSfxPitch()
    {
      this._data.ringSfxPitch = new Vector2(1f, 1f);
      return this;
    }

    public GameModifierDataBuilder WithRingSfxPitch(Vector2 ringSfxPitch)
    {
      this._data.ringSfxPitch = ringSfxPitch;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.InternalMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  internal class InternalMod : WildfrostMod
  {
    internal InternalMod(string modDirectory)
      : base(modDirectory)
    {
    }

    public override string GUID => "wildfrost";

    public override string[] Depends => new string[0];

    public override string Title => "wildfrost";

    public override string Description => "wildfrost";
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.KeywordDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class KeywordDataBuilder : DataFileBuilder<KeywordData, KeywordDataBuilder>
  {
    public KeywordDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public KeywordDataBuilder()
    {
    }

    public KeywordDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public KeywordDataBuilder WithDescription(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_desc", title);
      this._data.descKey = collection.GetString(this._data.name + "_desc");
      return this;
    }

    public KeywordDataBuilder WithTitleColour(Color? theColour = null)
    {
      if (!theColour.HasValue)
        theColour = new Color?(new Color(1f, 0.7921569f, 0.3411765f, 1f));
      this._data.titleColour = theColour.Value;
      return this;
    }

    public KeywordDataBuilder WithBodyColour(Color? theColour = null)
    {
      if (!theColour.HasValue)
        theColour = new Color?(Color.white);
      this._data.bodyColour = theColour.Value;
      return this;
    }

    public KeywordDataBuilder WithNoteColour(Color? theColour = null)
    {
      if (!theColour.HasValue)
        theColour = new Color?(Color.gray);
      this._data.noteColour = theColour.Value;
      return this;
    }

    public KeywordDataBuilder WithPanelColour(Color theColour)
    {
      this._data.panelColor = theColour;
      return this;
    }

    public KeywordDataBuilder WithPanelSprite(string image)
    {
      this._data.panelSprite = this.Mod.GetImageSprite(image);
      return this;
    }

    public KeywordDataBuilder WithIconName(string iconName)
    {
      this._data.iconName = iconName;
      return this;
    }

    public KeywordDataBuilder WithIconTint(Color hexColor)
    {
      this._data.iconTintHex = hexColor.ToHexRGB();
      return this;
    }

    public KeywordDataBuilder WithShow(bool show = true)
    {
      this._data.show = show;
      return this;
    }

    public KeywordDataBuilder WithShowName(bool show)
    {
      this._data.showName = show;
      return this;
    }

    public KeywordDataBuilder WithShowIcon(bool show = true)
    {
      this._data.showIcon = show;
      return this;
    }

    public KeywordDataBuilder WithCanStack(bool show)
    {
      this._data.canStack = show;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.LocalizationHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public static class LocalizationHelper
  {
    private static readonly Dictionary<string, StringTable> stringTables = new Dictionary<string, StringTable>();
    private static Harmony _harmony = new Harmony("wildfrost");

    public static Locale TryAddLocale(LocaleIdentifier locali)
    {
      if (!LocalizationSettings.AvailableLocales.Locales.All<Locale>((Func<Locale, bool>) (a => a.Identifier != locali)))
        return LocalizationSettings.AvailableLocales.Locales.Find((Predicate<Locale>) (a => a.Identifier == locali));
      Locale locale = Locale.CreateLocale(locali);
      locale.SortOrder = (ushort) LocalizationSettings.AvailableLocales.Locales.Count;
      LocalizationSettings.AvailableLocales.Locales.Add(locale);
      return locale;
    }

    static LocalizationHelper()
    {
      LocalizationHelper._harmony.PatchAll(typeof (LocalizationHelper).Assembly);
    }

    public static StringTable GetCollection(string name, LocaleIdentifier identifier)
    {
      string key = name + "_" + identifier.Code;
      StringTable collection1 = Addressables.LoadAssetAsync<StringTable>((object) key).WaitForCompletion();
      if (!((UnityEngine.Object) collection1 == (UnityEngine.Object) null))
        return collection1;
      StringTable collection2;
      if (LocalizationHelper.stringTables.TryGetValue(key, out collection2))
        return collection2;
      StringTable instance = ScriptableObject.CreateInstance<StringTable>();
      instance.name = key;
      instance.LocaleIdentifier = identifier;
      StringTable stringTable = Addressables.LoadAssetAsync<StringTable>((object) (name + "_" + new LocaleIdentifier(SystemLanguage.English).Code)).WaitForCompletion();
      instance.SharedData = stringTable.SharedData;
      LocalizationHelper.stringTables.Add(key, instance);
      return instance;
    }

    public static LocalizedString GetString(this StringTable table, string key)
    {
      TableReference tableCollectionName = (TableReference) table.TableCollectionName;
      LocalizedString localizedString = new LocalizedString();
      localizedString.SetReference(tableCollectionName, (TableEntryReference) key);
      return localizedString;
    }

    public static void SetString(this StringTable table, string key, string value)
    {
      long id = table.SharedData.GetId(key);
      if (id == 0L)
        id = table.SharedData.AddKey(key).Id;
      if (!table.ContainsKey(id))
        table.AddEntry(key, value);
      else
        table[id].Value = value;
    }

    [HarmonyPatch(typeof (LocalizedString), "GetLocalizedString", new System.Type[] {})]
    private class PatchLocalie1
    {
      [HarmonyPostfix]
      private static void Postfix(ref string __result, LocalizedString __instance)
      {
        if (!string.IsNullOrEmpty(__result))
          return;
        StringTable collection = LocalizationHelper.GetCollection(__instance.TableReference.TableCollectionName, LocalizationSettings.SelectedLocale.Identifier);
        TableEntryReference tableEntryReference = __instance.TableEntryReference;
        long num;
        if (tableEntryReference.ReferenceType != TableEntryReference.Type.Id)
        {
          SharedTableData sharedData = collection.SharedData;
          tableEntryReference = __instance.TableEntryReference;
          string key = tableEntryReference.Key;
          num = sharedData.GetId(key);
        }
        else
        {
          tableEntryReference = __instance.TableEntryReference;
          num = tableEntryReference.KeyId;
        }
        long keyId = num;
        StringTableEntry stringTableEntry;
        if (!collection.TryGetValue(keyId, out stringTableEntry))
          return;
        __result = stringTableEntry.Value;
      }
    }

    [HarmonyPatch(typeof (LocalizedStringDatabase), "GenerateLocalizedString", new System.Type[] {typeof (StringTable), typeof (StringTableEntry), typeof (TableReference), typeof (TableEntryReference), typeof (Locale), typeof (IList<object>)})]
    private class PatchLocalie2
    {
      [HarmonyPostfix]
      private static void Postfix(
        ref string __result,
        LocalizedStringDatabase __instance,
        StringTable table,
        StringTableEntry entry,
        TableReference tableReference,
        TableEntryReference tableEntryReference,
        Locale locale,
        IList<object> arguments)
      {
        if (!string.IsNullOrEmpty(__result))
          return;
        StringTable collection = LocalizationHelper.GetCollection(tableReference.TableCollectionName, locale.Identifier);
        long keyId = tableEntryReference.ReferenceType == TableEntryReference.Type.Id ? tableEntryReference.KeyId : collection.SharedData.GetId(tableEntryReference.Key);
        StringTableEntry stringTableEntry;
        if (!collection.TryGetValue(keyId, out stringTableEntry))
          return;
        __result = stringTableEntry.Value;
      }
    }

    [HarmonyPatch(typeof (LocalizedStringDatabase), "GetLocalizedString", new System.Type[] {typeof (TableReference), typeof (TableEntryReference), typeof (IList<object>), typeof (Locale), typeof (FallbackBehavior)})]
    private class PatchLocalie3
    {
      [HarmonyPostfix]
      private static void Postfix(
        ref string __result,
        LocalizedStringDatabase __instance,
        TableReference tableReference,
        TableEntryReference tableEntryReference,
        IList<object> arguments,
        Locale locale = null,
        FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
      {
        if (!string.IsNullOrEmpty(__result))
          return;
        if ((UnityEngine.Object) locale == (UnityEngine.Object) null)
          locale = LocalizationSettings.SelectedLocale;
        StringTable collection = LocalizationHelper.GetCollection(tableReference.TableCollectionName, locale.Identifier);
        long keyId = tableEntryReference.ReferenceType == TableEntryReference.Type.Id ? tableEntryReference.KeyId : collection.SharedData.GetId(tableEntryReference.Key);
        StringTableEntry stringTableEntry;
        if (!collection.TryGetValue(keyId, out stringTableEntry))
          return;
        __result = stringTableEntry.Value;
      }
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ModsSceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ModsSceneManager : MonoBehaviour
  {
    [SerializeField]
    private GameObject Content;
    [SerializeField]
    private GameObject ModPrefab;
    private List<WildfrostMod> instantiatedMods = new List<WildfrostMod>();

    private IEnumerator Start()
    {
      foreach (WildfrostMod mod in Bootstrap.Mods)
      {
        if (!this.instantiatedMods.Contains(mod))
        {
          GameObject gameObject = this.ModPrefab.InstantiateKeepName<GameObject>();
          gameObject.transform.SetParent(this.Content.transform);
          gameObject.transform.SetLocalZ(0.0f);
          gameObject.transform.SetLocalPositionAndRotation(gameObject.transform.localPosition, Quaternion.identity);
          ModHolder componentInChildren = gameObject.GetComponentInChildren<ModHolder>();
          componentInChildren.Mod = mod;
          componentInChildren.UpdateInfo();
          this.instantiatedMods.Add(mod);
        }
      }
      Time.timeScale = 1f;
      yield break;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.StatusEffectDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class StatusEffectDataBuilder : DataFileBuilder<StatusEffectData, StatusEffectDataBuilder>
  {
    public StatusEffectDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public StatusEffectDataBuilder()
    {
    }

    public StatusEffectDataBuilder WithIsStatus(bool value)
    {
      this._data.isStatus = value;
      return this;
    }

    public StatusEffectDataBuilder WithIsReaction(bool value)
    {
      this._data.isReaction = value;
      return this;
    }

    public StatusEffectDataBuilder WithIsKeyword(bool value)
    {
      this._data.isKeyword = value;
      return this;
    }

    public StatusEffectDataBuilder WithType(string type)
    {
      this._data.type = type;
      return this;
    }

    public StatusEffectDataBuilder WithKeyword(string type)
    {
      this._data.keyword = type;
      return this;
    }

    public StatusEffectDataBuilder WithIconGroupName(string type)
    {
      this._data.iconGroupName = type;
      return this;
    }

    public StatusEffectDataBuilder WithVisible(bool value)
    {
      this._data.visible = value;
      return this;
    }

    public StatusEffectDataBuilder WithStackable(bool value)
    {
      this._data.stackable = value;
      return this;
    }

    public StatusEffectDataBuilder WithOffensive(bool value)
    {
      this._data.offensive = value;
      return this;
    }

    public StatusEffectDataBuilder WithMakesOffensive(bool value)
    {
      this._data.makesOffensive = value;
      return this;
    }

    public StatusEffectDataBuilder WithDoesDamage(bool value)
    {
      this._data.doesDamage = value;
      return this;
    }

    public StatusEffectDataBuilder WithCanBeBoosted(bool value)
    {
      this._data.canBeBoosted = value;
      return this;
    }

    public StatusEffectDataBuilder WithText(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Card Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", title);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }

    public StatusEffectDataBuilder WithTextInsert(string value)
    {
      this._data.textInsert = value;
      return this;
    }

    public StatusEffectDataBuilder WithOrder(int order)
    {
      this._data.textOrder = order;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.TraitDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class TraitDataBuilder : DataFileBuilder<TraitData, TraitDataBuilder>
  {
    public TraitDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public TraitDataBuilder()
    {
    }

    public TraitDataBuilder WithKeyword(KeywordData data)
    {
      this._data.keyword = data;
      return this;
    }

    public TraitDataBuilder WithEffects(params StatusEffectData[] effects)
    {
      this._data.effects = effects;
      return this;
    }

    public TraitDataBuilder WithOverrides(params TraitData[] traits)
    {
      this._data.overrides = traits;
      return this;
    }

    public TraitDataBuilder WithIsReaction(bool isReaction)
    {
      this._data.isReaction = isReaction;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.UnlockDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class UnlockDataBuilder : DataFileBuilder<UnlockData, UnlockDataBuilder>
  {
    public UnlockDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public UnlockDataBuilder()
    {
    }

    public UnlockDataBuilder WithUnlockDescription(LocalizedString str)
    {
      this._data.unlockDesc = str;
      return this;
    }

    public UnlockDataBuilder WithUnlockTitle(LocalizedString str)
    {
      this._data.unlockTitle = str;
      return this;
    }

    public UnlockDataBuilder WithUnlockDescription(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_unlockDesc", title);
      this._data.unlockDesc = collection.GetString(this._data.name + "_unlockDesc");
      return this;
    }

    public UnlockDataBuilder WithUnlockTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_unlockTitle", title);
      this._data.unlockTitle = collection.GetString(this._data.name + "_unlockTitle");
      return this;
    }

    public UnlockDataBuilder WithRequires(params UnlockData[] requires)
    {
      this._data.requires = requires;
      return this;
    }

    public UnlockDataBuilder WithRequires(params string[] requires)
    {
      this._data.requires = ((IEnumerable<string>) requires).Select<string, UnlockData>(new Func<string, UnlockData>(this.Mod.Get<UnlockData>)).ToArray<UnlockData>();
      return this;
    }

    public UnlockDataBuilder WithLowPriority(float priority)
    {
      this._data.lowPriority = priority;
      return this;
    }

    public UnlockDataBuilder WithBuilding(BuildingType relatedBuilding)
    {
      this._data.relatedBuilding = relatedBuilding;
      this.SubscribeToBuildEvent((DataFileBuilder<UnlockData, UnlockDataBuilder>.AfterBuildDelegate) (data => relatedBuilding.unlocks = relatedBuilding.unlocks.AddToArray<UnlockData>(data)));
      return this;
    }

    public UnlockDataBuilder WithBuilding(string relatedBuilding)
    {
      return this.WithBuilding(this.Mod.Get<BuildingType>(relatedBuilding));
    }

    public UnlockDataBuilder WithType(UnlockData.Type type)
    {
      this._data.type = type;
      return this;
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.WildfrostMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using HarmonyLib;
using HarmonyLib.Tools;
using JetBrains.Annotations;
using Steamworks;
using Steamworks.Ugc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public abstract class WildfrostMod : IComparable<WildfrostMod>
  {
    public string ModDirectory;
    protected Sprite _iconSprite;
    protected Harmony HarmonyInstance;
    public static List<System.Type> AllBuiledrs = typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a =>
    {
      System.Type baseType = a.BaseType;
      return (object) baseType != null && baseType.IsGenericType && a.BaseType.GetGenericTypeDefinition() == typeof (DataFileBuilder<,>);
    }));
    public static List<System.Type> AllDataTypes = typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a => a.BaseType == typeof (DataFile)));

    public T GetAsset<T>(string name)
    {
      return Addressables.LoadAssetAsync<T>((object) name).WaitForCompletion();
    }

    public Sprite GetImageSprite(string relPath) => this.RelToAbsPath(relPath).ToSprite();

    public string RelToAbsPath(params string[] relPath)
    {
      string[] strArray = new string[relPath.Length + 1];
      strArray[0] = this.ModDirectory;
      for (int index = 1; index < strArray.Length; ++index)
        strArray[index] = relPath[index - 1];
      return Path.Combine(strArray);
    }

    public CardData.TraitStacks CreateTraitStack(string name, int amount)
    {
      return new CardData.TraitStacks(this.Get<TraitData>(name), amount);
    }

    public CardData.StatusEffectStacks CreateEffectStack(string name, int amount)
    {
      return new CardData.StatusEffectStacks(this.Get<StatusEffectData>(name), amount);
    }

    [Obsolete("Use one without type parameters", true)]
    public CardData.StatusEffectStacks CreateEffectStack<T>(string name, int amount) where T : StatusEffectData
    {
      return new CardData.StatusEffectStacks(this.Get<StatusEffectData>(name), amount);
    }

    public T Get<T>(string name) where T : DataFile
    {
      T obj = AddressableLoader.Get<T>(typeof (T).Name, Extensions.PrefixGUID(name, this));
      return (bool) (UnityEngine.Object) obj ? obj : AddressableLoader.Get<T>(typeof (T).Name, name);
    }

    public T GetStatusEffect<T>(string name) where T : StatusEffectData
    {
      StatusEffectData statusEffectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", Extensions.PrefixGUID(name, this));
      return (bool) (UnityEngine.Object) statusEffectData ? (T) statusEffectData : (T) AddressableLoader.Get<StatusEffectData>("StatusEffectData", name);
    }

    internal static WildfrostMod[] GetLastMods()
    {
      string[] source = SaveSystem.LoadProgressData<string[]>("lastSavedMods");
      return source != null ? ((IEnumerable<string>) source).Select<string, WildfrostMod>(new Func<string, WildfrostMod>(Extensions.GetModFromGuid)).ToArray<WildfrostMod>() : new WildfrostMod[0];
    }

    internal static void SetLastMods(WildfrostMod[] enabled)
    {
      SaveSystem.SaveProgressData<string[]>("lastSavedMods", ((IEnumerable<WildfrostMod>) enabled).Select<WildfrostMod, string>((Func<WildfrostMod, string>) (a => a.GUID)).ToArray<string>());
    }

    private WildfrostMod.ConfigStorage FromConfigs()
    {
      (WildfrostMod.ConfigItemAttribute, FieldInfo)[] configs = this.GetConfigs();
      return new WildfrostMod.ConfigStorage()
      {
        Store = configs,
        Mod = this
      };
    }

    public (WildfrostMod.ConfigItemAttribute atr, FieldInfo field)[] GetConfigs()
    {
      List<(WildfrostMod.ConfigItemAttribute, FieldInfo)> valueTupleList = new List<(WildfrostMod.ConfigItemAttribute, FieldInfo)>();
      foreach (FieldInfo field in this.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public))
      {
        WildfrostMod.ConfigItemAttribute customAttribute = field.GetCustomAttribute<WildfrostMod.ConfigItemAttribute>();
        if (customAttribute != null)
          valueTupleList.Add((customAttribute, field));
      }
      return valueTupleList.ToArray();
    }

    public WildfrostMod(string modDirectory)
      : this()
    {
      this.ModDirectory = modDirectory;
    }

    public virtual string IconPath => Path.Combine(this.ModDirectory, "icon.png");

    public virtual Sprite IconSprite
    {
      get => this._iconSprite ?? (this._iconSprite = this.IconPath.ToSprite());
    }

    public abstract string GUID { get; }

    public abstract string[] Depends { get; }

    public abstract string Title { get; }

    public abstract string Description { get; }

    public bool HasLoaded { get; private set; }

    public virtual string ImagesDirectory => Path.Combine(this.ModDirectory, "images");

    public virtual TMP_SpriteAsset SpriteAsset { get; }

    public string ImagePath(string fileName) => Path.Combine(this.ImagesDirectory, fileName);

    public WildfrostMod[] GetDependancies(bool throwIfNotFound = true)
    {
      ILookup<string, WildfrostMod> look = Bootstrap.Mods.ToLookup<WildfrostMod, string>((Func<WildfrostMod, string>) (a => a.GUID));
      List<(string, WildfrostMod)> list = ((IEnumerable<string>) this.Depends).Select<string, (string, WildfrostMod)>((Func<string, (string, WildfrostMod)>) (a => (a, look[a].FirstOrDefault<WildfrostMod>()))).ToList<(string, WildfrostMod)>();
      if (throwIfNotFound)
      {
        (string, WildfrostMod) tuple = list.Find((Predicate<(string, WildfrostMod)>) (a => a.Item2 == null));
        if (tuple.Item2 == null && !string.IsNullOrEmpty(tuple.Item1))
          throw new Exception("Mod " + tuple.Item1 + " not found! While it is a dependency for " + this.GUID);
      }
      return list.Select<(string, WildfrostMod), WildfrostMod>((Func<(string, WildfrostMod), WildfrostMod>) (a => a.Item2)).ToArray<WildfrostMod>();
    }

    public void LoadDependancies()
    {
      foreach (WildfrostMod dependancy in this.GetDependancies())
        dependancy.ModLoad();
    }

    private void UnloadModsDependantOnThis()
    {
      foreach (WildfrostMod wildfrostMod in Bootstrap.Mods.Where<WildfrostMod>((Func<WildfrostMod, bool>) (a => a.HasLoaded && a.Depends.Contains<string>(this.GUID))))
        wildfrostMod.ModUnload();
    }

    public void ModLoad()
    {
      if (this.HasLoaded)
        return;
      this.LoadDependancies();
      WildfrostMod.ConfigStorage configStorage = this.FromConfigs();
      string str = Path.Combine(this.ModDirectory, "config.cfg");
      if (!File.Exists(str))
        configStorage.WriteToFile(str);
      configStorage.ReadFromFile(str);
      this.Load();
      this.UpdateSave();
      Events.InvokeModLoaded(this);
    }

    private void UpdateSave()
    {
      WildfrostMod.SetLastMods(Bootstrap.Mods.ToList<WildfrostMod>().FindAll((Predicate<WildfrostMod>) (a => a.HasLoaded)).ToArray());
    }

    public void ModToggle()
    {
      if (this.HasLoaded)
      {
        this.ModUnload();
      }
      else
      {
        if (this.HasLoaded)
          return;
        this.ModLoad();
      }
    }

    protected virtual void Load()
    {
      this.HarmonyInstance.PatchAll(this.GetType().Assembly);
      List<System.Type> allBuiledrs = WildfrostMod.AllBuiledrs;
      List<System.Type> allDataTypes = WildfrostMod.AllDataTypes;
      Dictionary<System.Type, object> dictionary = new Dictionary<System.Type, object>();
      foreach (System.Type type1 in allDataTypes)
      {
        System.Type dataType = type1;
        System.Type type2 = allBuiledrs.Find((Predicate<System.Type>) (a => a.BaseType.GetGenericArguments()[0] == dataType));
        if (!(type2 == (System.Type) null))
        {
          object obj = typeof (WildfrostMod).GetMethod("AddAllTAssetsToGroup", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(dataType, type2).Invoke((object) this, new object[0]);
          dictionary.Add(dataType, obj);
        }
      }
      foreach (System.Type type3 in allDataTypes)
      {
        System.Type dataType = type3;
        System.Type type4 = allBuiledrs.Find((Predicate<System.Type>) (a => a.BaseType.GetGenericArguments()[0] == dataType));
        if (!(type4 == (System.Type) null))
        {
          object obj = dictionary[dataType];
          typeof (WildfrostMod.BuilderToBuilt<,>).MakeGenericType(dataType, type4).GetMethod("OnAfterAllModBuildsEvent", BindingFlags.Instance | BindingFlags.Public).Invoke(obj, new object[0]);
        }
      }
      this.HasLoaded = true;
    }

    private WildfrostMod.BuilderToBuilt<T, Y> AddAllTAssetsToGroup<T, Y>()
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      List<Y> yList = this.AddAssets<Y, T>();
      if (yList == null)
        return new WildfrostMod.BuilderToBuilt<T, Y>()
        {
          builder = new List<Y>(),
          built = new List<T>()
        };
      List<T> list = yList.Select<Y, T>((Func<Y, T>) (a => a.Build())).ToList<T>();
      if (list != null)
      {
        foreach (T obj in list)
        {
          obj.ModAdded = this;
          if (obj is CardData cardData && !(bool) (UnityEngine.Object) cardData.targetMode)
            throw new Exception("Card must have a target mode " + cardData.name);
        }
        AddressableLoader.AddRangeToGroup<T>(typeof (T).Name, (IEnumerable<T>) list);
      }
      return new WildfrostMod.BuilderToBuilt<T, Y>(list, yList);
    }

    [CanBeNull]
    public virtual List<T> AddAssets<T, Y>()
      where T : DataFileBuilder<Y, T>, new()
      where Y : DataFile
    {
      return (List<T>) null;
    }

    public void ModUnload()
    {
      if (!this.HasLoaded)
        return;
      this.Unload();
      this.UnloadModsDependantOnThis();
      this.UpdateSave();
      Events.InvokeModUnloaded(this);
    }

    protected virtual void Unload()
    {
      if (!this.HasLoaded)
        return;
      this.HarmonyInstance.UnpatchAll(this.HarmonyInstance.Id);
      this.HasLoaded = false;
      foreach (System.Type type in typeof (WildfrostMod).Assembly.GetTypes().ToList<System.Type>().FindAll((Predicate<System.Type>) (a => a.BaseType == typeof (DataFile))))
        typeof (WildfrostMod).GetMethod("RemoveeAllTAssetsFromGroup", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(type).Invoke((object) this, new object[0]);
    }

    private void RemoveeAllTAssetsFromGroup<T>() where T : DataFile
    {
      foreach (T obj in UnityEngine.Object.FindObjectsOfType<T>())
      {
        if (obj.ModAdded == this)
        {
          if (obj is CardData inst)
            inst.RemoveFromPets();
          AddressableLoader.RemoveFromGroup<T>(typeof (T).Name, obj);
          obj.Destroy();
        }
      }
    }

    private WildfrostMod() => this.HarmonyInstance = new Harmony(this.GUID);

    static WildfrostMod()
    {
      Harmony.DEBUG = true;
      HarmonyFileLog.Enabled = true;
      HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Info | HarmonyLib.Tools.Logger.LogChannel.Debug;
      HarmonyFileLog.Writer = (TextWriter) new WildfrostMod.DebugLoggerTextWriter();
    }

    public void WriteLine(string text) => Debug.Log((object) ("[" + this.GUID + "] " + text));

    public void WriteWarn(string text)
    {
      Debug.LogWarning((object) ("[" + this.GUID + "] " + text));
    }

    public void WriteError(string text) => Debug.LogError((object) ("[" + this.GUID + "] " + text));

    public int CompareTo(WildfrostMod other)
    {
      if (this == other)
        return 0;
      return other == null ? 1 : string.Compare(this.GUID, other.GUID, StringComparison.Ordinal);
    }

    public async void UpdateOrPublishWorkshop()
    {
      WildfrostMod wildfrostMod = this;
      List<Steamworks.Ugc.Item> entries = (await new Query(UgcType.Items, user: SteamClient.SteamId).WithMetadata(true).WithTag("Mod").GetPageAsync(1)).Value.Entries.ToList<Steamworks.Ugc.Item>().FindAll((Predicate<Steamworks.Ugc.Item>) (a => a.Result != Steamworks.Result.FileNotFound));
      // ISSUE: reference to a compiler-generated method
      Steamworks.Ugc.Item curItem = entries.Find(new Predicate<Steamworks.Ugc.Item>(wildfrostMod.\u003CUpdateOrPublishWorkshop\u003Eb__62_1));
      PublishResult result;
      if (entries.Count == 0 || curItem.Equals((object) new Steamworks.Ugc.Item()))
      {
        Editor editor = Editor.NewCommunityFile;
        editor = editor.WithTitle(wildfrostMod.Title);
        editor = editor.WithDescription(wildfrostMod.Description);
        editor = editor.WithTag("Mod");
        editor = editor.ForAppId(SteamClient.AppId);
        editor = editor.WithPublicVisibility();
        editor = editor.WithPreviewFile(wildfrostMod.IconPath);
        editor = editor.WithContent(wildfrostMod.ModDirectory);
        editor = editor.WithMetaData(wildfrostMod.GUID);
        result = await editor.SubmitAsync();
        Steamworks.Ugc.Item? async = await Steamworks.Ugc.Item.GetAsync(result.FileId);
        foreach (string depend1 in wildfrostMod.Depends)
        {
          string depend = depend1;
          Steamworks.Ugc.Item obj = entries.Find((Predicate<Steamworks.Ugc.Item>) (a => a.Metadata == depend));
          if (!curItem.Equals((object) new Steamworks.Ugc.Item()) && async.HasValue)
            async.GetValueOrDefault().AddDependency(obj.Id);
        }
        Debug.Log((object) ("Upload result " + result.ToString()));
        result = new PublishResult();
        entries = (List<Steamworks.Ugc.Item>) null;
        curItem = new Steamworks.Ugc.Item();
      }
      else
      {
        Editor editor = new Editor(curItem.Id);
        editor = editor.WithTitle(wildfrostMod.Title);
        editor = editor.WithDescription(wildfrostMod.Description);
        editor = editor.WithTag("Mod");
        editor = editor.ForAppId(SteamClient.AppId);
        editor = editor.WithPublicVisibility();
        editor = editor.WithPreviewFile(wildfrostMod.IconPath);
        editor = editor.WithContent(wildfrostMod.ModDirectory);
        editor = editor.WithMetaData(wildfrostMod.GUID);
        result = await editor.SubmitAsync();
        Steamworks.Ugc.Item? async = await Steamworks.Ugc.Item.GetAsync(result.FileId);
        foreach (string depend2 in wildfrostMod.Depends)
        {
          string depend = depend2;
          Steamworks.Ugc.Item obj = entries.Find((Predicate<Steamworks.Ugc.Item>) (a => a.Metadata == depend));
          if (!curItem.Equals((object) new Steamworks.Ugc.Item()) && async.HasValue)
            async.GetValueOrDefault().AddDependency(obj.Id);
        }
        Debug.Log((object) ("Update result " + result.ToString()));
        result = new PublishResult();
        entries = (List<Steamworks.Ugc.Item>) null;
        curItem = new Steamworks.Ugc.Item();
      }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class ConfigItemAttribute : Attribute
    {
      public string comment;
      public string forceTitle;
      public string fieldName;
      public string defaultValue;

      public string Title
      {
        get => !string.IsNullOrEmpty(this.forceTitle) ? this.forceTitle : this.fieldName;
      }

      [Obsolete("Use new constructor", true)]
      public ConfigItemAttribute(object defaultValue, string forceTitle = null)
      {
        this.comment = "";
        this.forceTitle = forceTitle;
        this.defaultValue = TypeDescriptor.GetConverter(defaultValue.GetType()).ConvertToString(defaultValue);
      }

      public ConfigItemAttribute(object defaultValue, string comment = "", string forceTitle = null)
      {
        this.comment = comment;
        this.forceTitle = forceTitle;
        this.defaultValue = TypeDescriptor.GetConverter(defaultValue.GetType()).ConvertToString(defaultValue);
      }
    }

    private struct ConfigStorage
    {
      public (WildfrostMod.ConfigItemAttribute atr, FieldInfo field)[] Store;
      public (string title, string value)[] Read;
      public WildfrostMod Mod;

      public void WriteToFile(string name)
      {
        StringBuilder stringBuilder = new StringBuilder();
        foreach ((WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple in this.Store)
        {
          tuple.atr.fieldName = tuple.field.Name;
          stringBuilder.AppendLine("//" + tuple.atr.comment);
          stringBuilder.AppendLine(tuple.field.FieldType.FullName + " : " + tuple.atr.Title + " = " + tuple.atr.defaultValue);
        }
        File.WriteAllText(name, stringBuilder.ToString());
      }

      public void ReadFromFile(string name)
      {
        int num1 = 0;
        while (true)
        {
          try
          {
            IEnumerable<string> strings = File.ReadLines(name);
            foreach ((WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple in this.Store)
              tuple.atr.fieldName = tuple.field.Name;
            List<(WildfrostMod.ConfigItemAttribute atr, FieldInfo field)> list = this.Store.ToList<(WildfrostMod.ConfigItemAttribute, FieldInfo)>();
            using (IEnumerator<string> enumerator = strings.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                string current = enumerator.Current;
                if (!current.StartsWith("//"))
                {
                  int num2 = current.IndexOf(':');
                  int num3 = current.IndexOf('=');
                  string name1 = current.Substring(0, num2 - 1 - 0);
                  string str1 = current;
                  int num4 = num2 + 2;
                  int num5 = num3 - 1 - num4;
                  int startIndex1 = num4;
                  int length1 = num5;
                  string title = str1.Substring(startIndex1, length1);
                  string str2 = current;
                  int length2 = str2.Length;
                  int startIndex2 = num3 + 2;
                  int num6 = startIndex2;
                  int length3 = length2 - num6;
                  string text = str2.Substring(startIndex2, length3);
                  (WildfrostMod.ConfigItemAttribute atr, FieldInfo field) tuple = list.Find((Predicate<(WildfrostMod.ConfigItemAttribute, FieldInfo)>) (a => a.atr.Title == title));
                  (WildfrostMod.ConfigItemAttribute atr, FieldInfo field) = tuple;
                  if (atr == null && field == (FieldInfo) null)
                    throw new WildfrostMod.ConfigStorage.FileIsCorrupted("Config error, no store");
                  if (tuple.field == (FieldInfo) null)
                    throw new Exception("Config value not found " + tuple.atr.Title);
                  System.Type type1 = (System.Type) null;
                  foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                  {
                    System.Type type2 = assembly.GetType(name1);
                    if (type2 != (System.Type) null)
                    {
                      type1 = type2;
                      break;
                    }
                  }
                  object obj = !(type1 == (System.Type) null) ? TypeDescriptor.GetConverter(type1).ConvertFromInvariantString(text) : throw new Exception("Unknown value type " + name1);
                  tuple.field.SetValue((object) this.Mod, obj);
                }
              }
              break;
            }
          }
          catch (WildfrostMod.ConfigStorage.FileIsCorrupted ex)
          {
            ++num1;
            if (num1 > 1)
            {
              throw;
            }
            else
            {
              File.Delete(name);
              this.WriteToFile(name);
            }
          }
        }
      }

      public class FileIsCorrupted : Exception
      {
        public FileIsCorrupted(string s)
          : base(s)
        {
        }
      }
    }

    internal struct BuilderToBuilt<T, Y>
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new()
    {
      internal List<T> built;
      internal List<Y> builder;

      public BuilderToBuilt(List<T> dataFiles, List<Y> builders)
      {
        this.built = dataFiles;
        this.builder = builders;
      }

      public void OnAfterAllModBuildsEvent()
      {
        for (int index = 0; index < this.builder.Count; ++index)
          this.builder[index].OnAfterAllModBuildsEvent(this.built[index]);
      }
    }

    public class DebugLoggerTextWriter : TextWriter
    {
      public override Encoding Encoding => Encoding.UTF8;

      public override void Write(string value)
      {
        value = "[HARMONY] " + value;
        Debug.Log((object) value);
      }

      public override void WriteLine(string value)
      {
        value = "[HARMONY] " + value;
        Debug.Log((object) (value + "\n"));
      }
    }
  }
}
