using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;
using UnityEngine;
using HarmonyLib;
using UnityEngine.AddressableAssets;
using FMODUnity;

namespace WildfrostHopeMod.DataHelpers
{
    public static class WildfrostModHelpers
    {
        public static T Get<T>(this WildfrostMod mod, string name) where T : DataFile
        {
            if (typeof(StatusEffectData).IsAssignableFrom(typeof(T)))
                return mod.Get<StatusEffectData>(name) as T;
            else
                return mod.Get<T>(name);
        }
    }
    public static class BattleDataHelpers
    {
        public static BattleData WithTitle(this BattleData dataFile, string title)
        {
            dataFile.title = title;
            return dataFile;
        }

        public static BattleData WithPointFactor(this BattleData dataFile, float factor = 1f)
        {
            dataFile.pointFactor = factor;
            return dataFile;
        }

        public static BattleData WithWaveCounter(this BattleData dataFile, int waveCounter = 4)
        {
            dataFile.waveCounter = waveCounter;
            return dataFile;
        }

        public static BattleData WithPools(this BattleData dataFile, params BattleWavePoolData[] pools)
        {
            dataFile.pools = pools;
            return dataFile;
        }

        public static BattleData WithBonusUnitPool(this BattleData dataFile, params CardData[] pools)
        {
            dataFile.bonusUnitPool = pools;
            return dataFile;
        }

        public static BattleData WithBonusUnitRange(this BattleData dataFile, Vector2Int v)
        {
            dataFile.bonusUnitRange = v;
            return dataFile;
        }

        public static BattleData WithGoldGiverPool(this BattleData dataFile, params CardData[] pools)
        {
            dataFile.goldGiverPool = pools;
            return dataFile;
        }

        public static BattleData WithGoldGivers(this BattleData dataFile, int amount = 1)
        {
            dataFile.goldGivers = amount;
            return dataFile;
        }

        public static BattleData WithGenerationScript(this BattleData dataFile, BattleGenerationScript s)
        {
            dataFile.generationScript = s;
            return dataFile;
        }

        public static BattleData WithSetUpScript(this BattleData dataFile, Script s)
        {
            dataFile.setUpScript = s;
            return dataFile;
        }

        public static BattleData WithSprite(this BattleData dataFile, Sprite sprite)
        {
            dataFile.sprite = sprite;
            return dataFile;
        }

        public static BattleData WithSprite(this BattleData dataFile, string sprite)
        {
            dataFile.sprite = new InternalMod(null).GetImageSprite(sprite);
            return dataFile;
        }

        public static BattleData WithName(this BattleData dataFile, string name, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_ref", name);
            dataFile.nameRef = collection.GetString(dataFile.name + "_ref");
            return dataFile;
        }
    }
    public static class BuildingPlotTypeHelpers
    {
        public static BuildingPlotType WithIllegalBuildings(this BuildingPlotType dataFile, params BuildingType[] illegalBuildings)
        {
            dataFile.illegalBuildings = illegalBuildings;
            return dataFile;
        }
    }
    public static class BuildingTypeHelpers
    {
        public static BuildingType WithTitle(this BuildingType dataFile, LocalizedString title)
        {
            dataFile.titleKey = title;
            return dataFile;
        }

        public static BuildingType WithTitle(this BuildingType dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_building_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_building_title");
            return dataFile;
        }

        public static BuildingType WithHelp(this BuildingType dataFile, LocalizedString title)
        {
            dataFile.helpKey = title;
            return dataFile;
        }

        public static BuildingType WithHelp(this BuildingType dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_building_help", title);
            dataFile.helpKey = collection.GetString(dataFile.name + "_building_help");
            return dataFile;
        }

        public static BuildingType WithHelpEmoteType(this BuildingType dataFile, Prompt.Emote.Type helpEmoteType = Prompt.Emote.Type.Explain)
        {
            dataFile.helpEmoteType = helpEmoteType;
            return dataFile;
        }

        public static BuildingType WithStarted(this BuildingType dataFile, UnlockData started)
        {
            dataFile.started = started;
            return dataFile;
        }

        public static BuildingType WithFinished(this BuildingType dataFile, UnlockData finished)
        {
            dataFile.finished = finished;
            return dataFile;
        }

        public static BuildingType WithUnlocks(this BuildingType dataFile, params UnlockData[] unlocks)
        {
            dataFile.unlocks = unlocks;
            return dataFile;
        }

        public static BuildingType WithUnlockedCheckedKey(this BuildingType dataFile, string unlockedCheckedKey)
        {
            dataFile.unlockedCheckedKey = unlockedCheckedKey;
            return dataFile;
        }
    }
    public static class CampaignNodeTypeHelpers
    {
        public static CampaignNodeType WithLetter(this CampaignNodeType dataFile, string letter)
        {
            dataFile.letter = letter;
            return dataFile;
        }

        public static CampaignNodeType WithZoneName(this CampaignNodeType dataFile, string zoneName)
        {
            dataFile.zoneName = zoneName;
            return dataFile;
        }

        public static CampaignNodeType WithMustClear(this CampaignNodeType dataFile, bool mustClear)
        {
            dataFile.mustClear = mustClear;
            return dataFile;
        }

        public static CampaignNodeType WithCanSkip(this CampaignNodeType dataFile, bool canSkip)
        {
            dataFile.canSkip = canSkip;
            return dataFile;
        }

        public static CampaignNodeType WithCanEnter(this CampaignNodeType dataFile, bool canEnter)
        {
            dataFile.canEnter = canEnter;
            return dataFile;
        }

        public static CampaignNodeType WithIsBattle(this CampaignNodeType dataFile, bool isBattle)
        {
            dataFile.isBattle = isBattle;
            return dataFile;
        }

        public static CampaignNodeType WithIsBoss(this CampaignNodeType dataFile, bool isBoss)
        {
            dataFile.isBoss = isBoss;
            return dataFile;
        }

        public static CampaignNodeType WithModifierReward(this CampaignNodeType dataFile, bool modifierReward)
        {
            dataFile.modifierReward = modifierReward;
            return dataFile;
        }

        public static CampaignNodeType WithInteractable(this CampaignNodeType dataFile, bool interactable)
        {
            dataFile.interactable = interactable;
            return dataFile;
        }

        public static CampaignNodeType WithStartRevealed(this CampaignNodeType dataFile, bool startRevealed)
        {
            dataFile.startRevealed = startRevealed;
            return dataFile;
        }

        public static CampaignNodeType WithFinalNode(this CampaignNodeType dataFile, bool finalNode)
        {
            dataFile.finalNode = finalNode;
            return dataFile;
        }

        public static CampaignNodeType WithMapNodePrefab(this CampaignNodeType dataFile, MapNode mapNodePrefab)
        {
            dataFile.mapNodePrefab = mapNodePrefab;
            return dataFile;
        }

        public static CampaignNodeType WithMapNodeSprite(this CampaignNodeType dataFile, Sprite mapNodeSprite)
        {
            dataFile.mapNodeSprite = mapNodeSprite;
            return dataFile;
        }

        public static CampaignNodeType WithMapNodeSprite(this CampaignNodeType dataFile, string mapNodeSprite)
        {
            dataFile.mapNodeSprite = new InternalMod(null).GetImageSprite(mapNodeSprite);
            return dataFile;
        }

        public static CampaignNodeType WithSize(this CampaignNodeType dataFile, float size = 1f)
        {
            dataFile.size = size;
            return dataFile;
        }

        public static CampaignNodeType WithCanLink(this CampaignNodeType dataFile, bool canLink)
        {
            dataFile.canLink = canLink;
            return dataFile;
        }
    }
    public static class CardDataHelpers
    {

        public static CardData SetStats(this CardData dataFile, int? health = null, int? damage = null, int counter = 0)
        {
            return dataFile.SetHealth(health).SetDamage(damage).SetCounter(counter);
        }

        public static CardData SetCounter(this CardData dataFile, int counter)
        {
            dataFile.counter = counter;
            return dataFile;
        }

        public static CardData SetDamage(this CardData dataFile, int? damage)
        {
            if (damage.HasValue)
                dataFile.damage = damage.Value;
            dataFile.hasAttack = damage.HasValue;
            return dataFile;
        }

        public static CardData NeedsTarget(this CardData dataFile, bool value = true)
        {
            dataFile.needsTarget = value;
            return dataFile;
        }

        public static CardData SetHealth(this CardData dataFile, int? health)
        {
            if (health.HasValue)
                dataFile.hp = health.Value;
            dataFile.hasHealth = health.HasValue;
            return dataFile;
        }

        public static CardData SetSprites(this CardData dataFile, Sprite mainSprite, Sprite backgroundSprite)
        {
            dataFile.mainSprite = mainSprite;
            dataFile.backgroundSprite = backgroundSprite;
            return dataFile;
        }

        public static CardData SetSprites(this CardData dataFile, string mainSprite, string backgroundSprite)
        {
            return dataFile.SetSprites(new InternalMod(null).ImagePath(mainSprite).ToSprite(), new InternalMod(null).ImagePath(backgroundSprite).ToSprite());
        }

        public static CardData SetStartWithEffect(this CardData dataFile, params CardData.StatusEffectStacks[] stacks)
        {
            dataFile.startWithEffects = stacks;
            return dataFile;
        }

        public static CardData SetTraits(this CardData dataFile, params CardData.TraitStacks[] stacks)
        {
            dataFile.traits = stacks.ToList<CardData.TraitStacks>();
            return dataFile;
        }

        public static CardData WithDescription(this CardData dataFile, string desc)
        {
            dataFile.desc = desc;
            return dataFile;
        }

        public static CardData WithValue(this CardData dataFile, int price)
        {
            dataFile.value = price;
            return dataFile;
        }

        public static CardData WithTargetMode(this CardData dataFile, TargetMode mode)
        {
            dataFile.targetMode = mode;
            return dataFile;
        }

        public static CardData WithTargetMode(this CardData dataFile, string mode = "TargetModeBasic")
        {
            dataFile.targetMode = Extensions.GetTargetMode(mode);
            return dataFile;
        }

        public static CardData WithPlayType(this CardData dataFile, Card.PlayType type)
        {
            dataFile.playType = type;
            return dataFile;
        }

        public static CardData SetAttackEffect(this CardData dataFile, params CardData.StatusEffectStacks[] stacks)
        {
            dataFile.attackEffects = stacks;
            return dataFile;
        }

        public static CardData WithIdleAnimationProfile(this CardData dataFile, CardAnimationProfile bp)
        {
            dataFile.idleAnimationProfile = bp;
            return dataFile;
        }

        public static CardData WithIdleAnimationProfile(this CardData dataFile, string bp = "SwayAnimationProfile")
        {
            return dataFile.WithIdleAnimationProfile(Extensions.GetCardAnimationProfile(bp));
        }

        public static CardData WithBloodProfile(this CardData dataFile, BloodProfile bp)
        {
            dataFile.bloodProfile = bp;
            return dataFile;
        }

        public static CardData WithBloodProfile(this CardData dataFile, string bp = "Blood Profile Normal")
        {
            return dataFile.WithBloodProfile(new InternalMod(null).GetAsset<BloodProfile>(bp));
        }

        public static CardData CanPlayOnBoard(this CardData dataFile, bool value = true)
        {
            dataFile.canPlayOnBoard = value;
            return dataFile;
        }

        public static CardData CanPlayOnEnemy(this CardData dataFile, bool value = true)
        {
            dataFile.canPlayOnEnemy = value;
            return dataFile;
        }

        public static CardData CanPlayOnFriendly(this CardData dataFile, bool value = true)
        {
            dataFile.canPlayOnFriendly = value;
            return dataFile;
        }

        public static CardData CanPlayOnHand(this CardData dataFile, bool value = true)
        {
            dataFile.canPlayOnHand = value;
            return dataFile;
        }

        public static CardData CanBeHit(this CardData dataFile, bool value = true)
        {
            dataFile.canBeHit = value;
            return dataFile;
        }

        public static CardData CanShoveToOtherRow(this CardData dataFile, bool value = true)
        {
            dataFile.canShoveToOtherRow = value;
            return dataFile;
        }
        public static CardData WithCardType(this CardData dataFile, CardType type)
        {
            dataFile.cardType = type;
            return dataFile;
        }

        public static CardData WithCardType(this CardData dataFile, string type = "Friendly")
        {
            dataFile.cardType = new InternalMod(null).Get<CardType>(type);
            return dataFile;
        }

        public static CardData WithTitle(this CardData dataFile, LocalizedString title)
        {
            dataFile.titleKey = title;
            return dataFile;
        }

        public static CardData WithFlavour(this CardData dataFile, LocalizedString flavour)
        {
            dataFile.flavourKey = flavour;
            return dataFile;
        }

        public static CardData WithText(this CardData dataFile, LocalizedString text)
        {
            dataFile.textKey = text;
            return dataFile;
        }

        public static CardData WithTitle(this CardData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_title");
            return dataFile;
        }

        public static CardData WithFlavour(this CardData dataFile, string flavour, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_flavour", flavour);
            dataFile.flavourKey = collection.GetString(dataFile.name + "_flavour");
            return dataFile;
        }

        public static CardData WithText(this CardData dataFile, string text, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_text", text);
            dataFile.textKey = collection.GetString(dataFile.name + "_text");
            return dataFile;
        }
    }
    public static class CardTypeHelpers
    {
        public static CardType WithSortPriority(this CardType dataFile, int sortPriority)
        {
            dataFile.sortPriority = sortPriority;
            return dataFile;
        }

        public static CardType WithIcon(this CardType dataFile, Sprite icon)
        {
            dataFile.icon = icon;
            return dataFile;
        }

        public static CardType WithIcon(this CardType dataFile, string icon)
        {
            dataFile.icon = new InternalMod(null).GetImageSprite(icon);
            return dataFile;
        }

        public static CardType WithPrefabRef(this CardType dataFile, AssetReference prefabRef)
        {
            dataFile.prefabRef = prefabRef;
            return dataFile;
        }

        public static CardType WithTextBoxSprite(this CardType dataFile, Sprite icon)
        {
            dataFile.textBoxSprite = icon;
            return dataFile;
        }

        public static CardType WithTextBoxSprite(this CardType dataFile, string icon)
        {
            dataFile.textBoxSprite = new InternalMod(null).GetImageSprite(icon);
            return dataFile;
        }

        public static CardType WithNameTagSprite(this CardType dataFile, Sprite icon)
        {
            dataFile.nameTagSprite = icon;
            return dataFile;
        }

        public static CardType WithNameTagSprite(this CardType dataFile, string icon)
        {
            dataFile.nameTagSprite = new InternalMod(null).GetImageSprite(icon);
            return dataFile;
        }

        public static CardType WithTitle(this CardType dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_type_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_type_title");
            return dataFile;
        }

        public static CardType WithTitle(this CardType dataFile, LocalizedString str)
        {
            dataFile.titleKey = str;
            return dataFile;
        }

        public static CardType WithCanDie(this CardType dataFile, bool canDie)
        {
            dataFile.canDie = canDie;
            return dataFile;
        }

        public static CardType WithCanTakeCrown(this CardType dataFile, bool canTakeCrown)
        {
            dataFile.canTakeCrown = canTakeCrown;
            return dataFile;
        }

        public static CardType WithCanRecall(this CardType dataFile, bool canRecall)
        {
            dataFile.canRecall = canRecall;
            return dataFile;
        }

        public static CardType WithCanReserve(this CardType dataFile, bool canReserve)
        {
            dataFile.canReserve = canReserve;
            return dataFile;
        }

        public static CardType WithItem(this CardType dataFile, bool item)
        {
            dataFile.item = item;
            return dataFile;
        }

        public static CardType WithUnit(this CardType dataFile, bool unit)
        {
            dataFile.unit = unit;
            return dataFile;
        }

        public static CardType WithTag(this CardType dataFile, string tag)
        {
            dataFile.tag = tag;
            return dataFile;
        }

        public static CardType WithMiniboss(this CardType dataFile, bool miniboss)
        {
            dataFile.miniboss = miniboss;
            return dataFile;
        }

        public static CardType WithDiscoverInJournal(this CardType dataFile, bool discoverInJournal)
        {
            dataFile.discoverInJournal = discoverInJournal;
            return dataFile;
        }

    }
    public static class CardUpgradeDataHelpers
    {

        public static CardUpgradeData WithTier(this CardUpgradeData dataFile, int tier)
        {
            dataFile.tier = tier;
            return dataFile;
        }

        public static CardUpgradeData WithImage(this CardUpgradeData dataFile, Sprite img)
        {
            dataFile.image = img;
            return dataFile;
        }

        public static CardUpgradeData WithType(this CardUpgradeData dataFile, CardUpgradeData.Type type)
        {
            dataFile.type = type;
            return dataFile;
        }

        public static CardUpgradeData SetAttackEffects(this CardUpgradeData dataFile, params CardData.StatusEffectStacks[] efs)
        {
            dataFile.attackEffects = efs;
            return dataFile;
        }

        public static CardUpgradeData SetEffects(this CardUpgradeData dataFile, params CardData.StatusEffectStacks[] efs)
        {
            dataFile.effects = efs;
            return dataFile;
        }

        public static CardUpgradeData SetTraits(this CardUpgradeData dataFile, params CardData.TraitStacks[] efs)
        {
            dataFile.giveTraits = efs;
            return dataFile;
        }

        public static CardUpgradeData SetScripts(this CardUpgradeData dataFile, params CardScript[] efs)
        {
            dataFile.scripts = efs;
            return dataFile;
        }

        public static CardUpgradeData SetConstraints(this CardUpgradeData dataFile, params TargetConstraint[] efs)
        {
            dataFile.targetConstraints = efs;
            return dataFile;
        }

        public static CardUpgradeData SetBecomesTarget(this CardUpgradeData dataFile, bool val)
        {
            dataFile.becomesTargetedCard = val;
            return dataFile;
        }

        public static CardUpgradeData SetCanBeRemoved(this CardUpgradeData dataFile, bool val)
        {
            dataFile.canBeRemoved = val;
            return dataFile;
        }

        public static CardUpgradeData ChangeDamage(this CardUpgradeData dataFile, int val)
        {
            dataFile.damage = val;
            return dataFile;
        }

        public static CardUpgradeData ChangeHP(this CardUpgradeData dataFile, int val)
        {
            dataFile.hp = val;
            return dataFile;
        }

        public static CardUpgradeData ChangeCounter(this CardUpgradeData dataFile, int val)
        {
            dataFile.counter = val;
            return dataFile;
        }

        public static CardUpgradeData ChangeUses(this CardUpgradeData dataFile, int val)
        {
            dataFile.uses = val;
            return dataFile;
        }

        public static CardUpgradeData ChangeEffectBonus(this CardUpgradeData dataFile, int val)
        {
            dataFile.effectBonus = val;
            return dataFile;
        }

        public static CardUpgradeData WithSetDamage(this CardUpgradeData dataFile, bool val)
        {
            dataFile.setDamage = val;
            return dataFile;
        }

        public static CardUpgradeData WithSetHP(this CardUpgradeData dataFile, bool val)
        {
            dataFile.setHp = val;
            return dataFile;
        }

        public static CardUpgradeData WithSetCounter(this CardUpgradeData dataFile, bool val)
        {
            dataFile.setCounter = val;
            return dataFile;
        }

        public static CardUpgradeData WithSetUses(this CardUpgradeData dataFile, bool val)
        {
            dataFile.setUses = val;
            return dataFile;
        }

        public static CardUpgradeData WithImage(this CardUpgradeData dataFile, string img)
        {
            dataFile.image = new InternalMod(null).ImagePath(img).ToSprite();
            return dataFile;
        }

        public static CardUpgradeData WithTitle(this CardUpgradeData dataFile, LocalizedString title)
        {
            dataFile.titleKey = title;
            return dataFile;
        }

        public static CardUpgradeData WithText(this CardUpgradeData dataFile, LocalizedString text)
        {
            dataFile.textKey = text;
            return dataFile;
        }

        public static CardUpgradeData WithTitle(this CardUpgradeData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Upgrades", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_title");
            return dataFile;
        }

        public static CardUpgradeData WithText(this CardUpgradeData dataFile, string text, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Upgrades", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_text", text);
            dataFile.textKey = collection.GetString(dataFile.name + "_text");
            return dataFile;
        }
    }
    public static class ChallengeDataHelpers
    {
        public static ChallengeData WithText(this ChallengeData dataFile, LocalizedString str)
        {
            dataFile.textKey = str;
            return dataFile;
        }

        public static ChallengeData WithRewardText(this ChallengeData dataFile, LocalizedString str)
        {
            dataFile.rewardKey = str;
            return dataFile;
        }

        public static ChallengeData WithTitle(this ChallengeData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_title");
            return dataFile;
        }

        public static ChallengeData WithText(this ChallengeData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_text", title);
            dataFile.textKey = collection.GetString(dataFile.name + "_text");
            return dataFile;
        }

        public static ChallengeData WithRewardText(this ChallengeData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_reward", title);
            dataFile.rewardKey = collection.GetString(dataFile.name + "_reward");
            return dataFile;
        }

        public static ChallengeData WithGoal(this ChallengeData dataFile, int amountGoal)
        {
            dataFile.goal = amountGoal;
            return dataFile;
        }

        public static ChallengeData WithListener(this ChallengeData dataFile, ChallengeListener listener)
        {
            dataFile.listener = listener;
            return dataFile;
        }

        public static ChallengeData WithListener(this ChallengeData dataFile, string listener)
        {
            dataFile.listener = new InternalMod(null).Get<ChallengeListener>(listener);
            return dataFile;
        }

        public static ChallengeData WithIcon(this ChallengeData dataFile, Sprite icon)
        {
            dataFile.icon = icon;
            return dataFile;
        }

        public static ChallengeData WithRequires(this ChallengeData dataFile, params ChallengeData[] requires)
        {
            dataFile.requires = requires;
            return dataFile;
        }

        public static ChallengeData WithRequires(this ChallengeData dataFile, params string[] requires)
        {
            dataFile.requires = ((IEnumerable<string>)requires).Select<string, ChallengeData>(new Func<string, ChallengeData>(new InternalMod(null).Get<ChallengeData>)).ToArray<ChallengeData>();
            return dataFile;
        }

        public static ChallengeData WithReward(this ChallengeData dataFile, UnlockData reward)
        {
            dataFile.reward = reward;
            return dataFile;
        }

        public static ChallengeData WithReward(this ChallengeData dataFile, string reward)
        {
            dataFile.reward = new InternalMod(null).Get<UnlockData>(reward);
            return dataFile;
        }
    }
    public static class ChallengeListenerHelpers
    {
        public static ChallengeListener WithKey(this ChallengeListener dataFile, string key)
        {
            dataFile.key = key;
            dataFile.hasKey = true;
            return dataFile;
        }

        public static ChallengeListener WithCheckType(this ChallengeListener dataFile, ChallengeListener.CheckType type)
        {
            dataFile.checkType = type;
            return dataFile;
        }

        public static ChallengeListener WithStat(this ChallengeListener dataFile, string stat)
        {
            dataFile.stat = stat;
            return dataFile;
        }

        public static ChallengeListener WithStat(this ChallengeListener dataFile, int toReach)
        {
            dataFile.target = toReach;
            return dataFile;
        }
    }
    public static class ClassDataHelpers
    {
        public static ClassData WithRequiresUnlock(this ClassData dataFile, UnlockData requiresUnlock)
        {
            dataFile.requiresUnlock = requiresUnlock;
            return dataFile;
        }

        public static ClassData WithStartingInventory(this ClassData dataFile, Inventory startingInventory)
        {
            dataFile.startingInventory = startingInventory;
            return dataFile;
        }

        public static ClassData WithLeaders(this ClassData dataFile, params CardData[] leaders)
        {
            dataFile.leaders = leaders;
            return dataFile;
        }

        public static ClassData WithCharacterPrefab(this ClassData dataFile, Character characterPrefab)
        {
            dataFile.characterPrefab = characterPrefab;
            return dataFile;
        }

        public static ClassData WithRewardPools(this ClassData dataFile, params RewardPool[] rewardPools)
        {
            dataFile.rewardPools = rewardPools;
            return dataFile;
        }

        public static ClassData WithSelectSfxEvent(this ClassData dataFile, EventReference selectSfxEvent)
        {
            dataFile.selectSfxEvent = selectSfxEvent;
            return dataFile;
        }
        /// <summary>see vanilla references</summary>
        /// <param name="selectSfxEvent">format: "event:/..."</param>
        public static ClassData WithSelectSfxEvent(this ClassData dataFile, string selectSfxEvent)
        {
            dataFile.selectSfxEvent = RuntimeManager.PathToEventReference(selectSfxEvent);
            return dataFile;
        }

        public static ClassData WithFlag(this ClassData dataFile, Sprite flag)
        {
            dataFile.flag = flag;
            return dataFile;
        }

        public static ClassData WithFlag(this ClassData dataFile, string flag)
        {
            dataFile.flag = new InternalMod(null).GetImageSprite(flag);
            return dataFile;
        }
    }
    public static class EyeDataHelpers
    {
        public static EyeData WithCardData(this EyeData dataFile, string cardData)
        {
            dataFile.cardData = cardData;
            return dataFile;
        }

        public static EyeData WithCardData(this EyeData dataFile, CardData cardData)
        {
            dataFile.cardData = cardData.name;
            return dataFile;
        }

        public static EyeData WithEyes(this EyeData dataFile, params EyeData.Eye[] eyes)
        {
            dataFile.eyes = eyes;
            return dataFile;
        }
    }
    public static class GameModeHelpers
    {
        public static GameMode WithSaveFileName(this GameMode dataFile, string saveFileName)
        {
            dataFile.saveFileName = saveFileName;
            return dataFile;
        }

        public static GameMode WithSeed(this GameMode dataFile, string seed)
        {
            dataFile.seed = seed;
            return dataFile;
        }

        public static GameMode WithClasses(this GameMode dataFile, params ClassData[] classes)
        {
            dataFile.classes = classes;
            return dataFile;
        }

        public static GameMode WithGenerator(this GameMode dataFile, CampaignGenerator generator)
        {
            dataFile.generator = generator;
            return dataFile;
        }

        public static GameMode WithPopulator(this GameMode dataFile, CampaignPopulator populator)
        {
            dataFile.populator = populator;
            return dataFile;
        }

        public static GameMode WithStartInNode(this GameMode dataFile, bool startInNode)
        {
            dataFile.startInNode = startInNode;
            return dataFile;
        }

        public static GameMode WithTakeStartingPet(this GameMode dataFile, bool takeStartingPet = true)
        {
            dataFile.takeStartingPet = takeStartingPet;
            return dataFile;
        }

        public static GameMode WithCountsAsWin(this GameMode dataFile, bool countsAsWin = true)
        {
            dataFile.countsAsWin = countsAsWin;
            return dataFile;
        }

        public static GameMode WithShowStats(this GameMode dataFile, bool showStats = true)
        {
            dataFile.showStats = showStats;
            return dataFile;
        }

        public static GameMode WithGainProgress(this GameMode dataFile, bool gainProgress = true)
        {
            dataFile.gainProgress = gainProgress;
            return dataFile;
        }

        public static GameMode WithDoSave(this GameMode dataFile, bool doSave = true)
        {
            dataFile.doSave = doSave;
            return dataFile;
        }

        public static GameMode WithCanRestart(this GameMode dataFile, bool canRestart = true)
        {
            dataFile.canRestart = canRestart;
            return dataFile;
        }

        public static GameMode WithCanGoBack(this GameMode dataFile, bool canGoBack = true)
        {
            dataFile.canGoBack = canGoBack;
            return dataFile;
        }

        public static GameMode WithSubmitScore(this GameMode dataFile, bool submitScore = false)
        {
            dataFile.submitScore = submitScore;
            return dataFile;
        }

        public static GameMode WithMainGameMode(this GameMode dataFile, bool mainGameMode = true)
        {
            dataFile.mainGameMode = mainGameMode;
            return dataFile;
        }

        public static GameMode WithDailyRun(this GameMode dataFile, bool dailyRun = false)
        {
            dataFile.dailyRun = dailyRun;
            return dataFile;
        }

        public static GameMode WithTutorialRun(this GameMode dataFile, bool tutorialRun = false)
        {
            dataFile.tutorialRun = tutorialRun;
            return dataFile;
        }

        public static GameMode WithLeaderboardType(this GameMode dataFile, Scores.Type leaderboardType)
        {
            dataFile.leaderboardType = leaderboardType;
            return dataFile;
        }

        public static GameMode WithStartScene(this GameMode dataFile, string startScene)
        {
            dataFile.startScene = startScene;
            return dataFile;
        }

        public static GameMode WithSceneAfterSelection(this GameMode dataFile, string sceneAfterSelection = "Campaign")
        {
            dataFile.sceneAfterSelection = sceneAfterSelection;
            return dataFile;
        }

        public static GameMode WithCampaignSystemNames(this GameMode dataFile, params string[] campaignSystemNames)
        {
            dataFile.campaignSystemNames = campaignSystemNames;
            return dataFile;
        }

        public static GameMode WithSystemsToDisable(this GameMode dataFile, params string[] systemsToDisable)
        {
            dataFile.systemsToDisable = systemsToDisable;
            return dataFile;
        }
    }
    public static class GameModifierDataHelpers
    {
        public static GameModifierData WithValue(this GameModifierData dataFile, int value = 100)
        {
            dataFile.value = value;
            return dataFile;
        }

        public static GameModifierData WithVisible(this GameModifierData dataFile, bool visible = true)
        {
            dataFile.visible = visible;
            return dataFile;
        }

        public static GameModifierData WithBellSprite(this GameModifierData dataFile, Sprite bellSprite)
        {
            dataFile.bellSprite = bellSprite;
            return dataFile;
        }

        public static GameModifierData WithBellSprite(this GameModifierData dataFile, string bellSprite)
        {
            dataFile.bellSprite = new InternalMod(null).GetImageSprite(bellSprite);
            return dataFile;
        }

        public static GameModifierData WithDingerSprite(this GameModifierData dataFile, Sprite dingerSprite)
        {
            dataFile.dingerSprite = dingerSprite;
            return dataFile;
        }

        public static GameModifierData WithDingerSprite(this GameModifierData dataFile, string dingerSprite)
        {
            dataFile.dingerSprite = new InternalMod(null).GetImageSprite(dingerSprite);
            return dataFile;
        }

        public static GameModifierData WithTitle(this GameModifierData dataFile, LocalizedString title)
        {
            dataFile.titleKey = title;
            return dataFile;
        }

        public static GameModifierData WithTitle(this GameModifierData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_modifier_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_modifier_title");
            return dataFile;
        }

        public static GameModifierData WithDescription(this GameModifierData dataFile, LocalizedString title)
        {
            dataFile.descriptionKey = title;
            return dataFile;
        }

        public static GameModifierData WithDescription(this GameModifierData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_modifier_desc", title);
            dataFile.descriptionKey = collection.GetString(dataFile.name + "_modifier_desc");
            return dataFile;
        }

        public static GameModifierData WithSystemsToAdd(this GameModifierData dataFile, params string[] systemsToAdd)
        {
            dataFile.systemsToAdd = systemsToAdd;
            return dataFile;
        }

        public static GameModifierData WithSetupScripts(this GameModifierData dataFile, params Script[] setupScripts)
        {
            dataFile.setupScripts = setupScripts;
            return dataFile;
        }

        public static GameModifierData WithStartScripts(this GameModifierData dataFile, params Script[] startScripts)
        {
            dataFile.startScripts = startScripts;
            return dataFile;
        }

        public static GameModifierData WithScriptPriority(this GameModifierData dataFile, int scriptPriority)
        {
            dataFile.scriptPriority = scriptPriority;
            return dataFile;
        }

        public static GameModifierData WithBlockedBy(this GameModifierData dataFile, params GameModifierData[] blockedBy)
        {
            dataFile.blockedBy = blockedBy;
            return dataFile;
        }

        public static GameModifierData WithLinkedStormBell(this GameModifierData dataFile, HardModeModifierData linkedStormBell)
        {
            dataFile.linkedStormBell = linkedStormBell;
            return dataFile;
        }

        public static GameModifierData WithRingSfxEvent(this GameModifierData dataFile, EventReference ringSfxEvent)
        {
            dataFile.ringSfxEvent = ringSfxEvent;
            return dataFile;
        }
        /// <summary>see vanilla references</summary>
        /// <param name="selectSfxEvent">format: "event:/..."</param>
        public static GameModifierData WithRingSfxEvent(this GameModifierData dataFile, string ringSfxEvent)
        {
            dataFile.ringSfxEvent = RuntimeManager.PathToEventReference(ringSfxEvent);
            return dataFile;
        }

            public static GameModifierData WithRingSfxPitch(this GameModifierData dataFile)
        {
            dataFile.ringSfxPitch = new Vector2(1f, 1f);
            return dataFile;
        }

        public static GameModifierData WithRingSfxPitch(this GameModifierData dataFile, Vector2 ringSfxPitch)
        {
            dataFile.ringSfxPitch = ringSfxPitch;
            return dataFile;
        }
    }
    public static class KeywordDataHelpers
    {
        public static KeywordData WithTitle(this KeywordData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Tooltips", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_title", title);
            dataFile.titleKey = collection.GetString(dataFile.name + "_title");
            return dataFile;
        }

        public static KeywordData WithDescription(this KeywordData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("Tooltips", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_desc", title);
            dataFile.descKey = collection.GetString(dataFile.name + "_desc");
            return dataFile;
        }

        public static KeywordData WithTitleColour(this KeywordData dataFile, Color? theColour = null)
        {
            if (!theColour.HasValue)
                theColour = new Color?(new Color(1f, 0.7921569f, 0.3411765f, 1f));
            dataFile.titleColour = theColour.Value;
            return dataFile;
        }

        public static KeywordData WithBodyColour(this KeywordData dataFile, Color? theColour = null)
        {
            if (!theColour.HasValue)
                theColour = new Color?(Color.white);
            dataFile.bodyColour = theColour.Value;
            return dataFile;
        }

        public static KeywordData WithNoteColour(this KeywordData dataFile, Color? theColour = null)
        {
            if (!theColour.HasValue)
                theColour = new Color?(Color.gray);
            dataFile.noteColour = theColour.Value;
            return dataFile;
        }

        public static KeywordData WithPanelColour(this KeywordData dataFile, Color theColour)
        {
            dataFile.panelColor = theColour;
            return dataFile;
        }

        public static KeywordData WithPanelSprite(this KeywordData dataFile, string image)
        {
            dataFile.panelSprite = new InternalMod(null).GetImageSprite(image);
            return dataFile;
        }

        public static KeywordData WithIconName(this KeywordData dataFile, string iconName)
        {
            dataFile.iconName = iconName;
            return dataFile;
        }

        public static KeywordData WithIconTint(this KeywordData dataFile, Color hexColor)
        {
            dataFile.iconTintHex = hexColor.ToHexRGB();
            return dataFile;
        }

        public static KeywordData WithShow(this KeywordData dataFile, bool show = true)
        {
            dataFile.show = show;
            return dataFile;
        }

        public static KeywordData WithShowName(this KeywordData dataFile, bool show)
        {
            dataFile.showName = show;
            return dataFile;
        }

        public static KeywordData WithShowIcon(this KeywordData dataFile, bool show = true)
        {
            dataFile.showIcon = show;
            return dataFile;
        }

        public static KeywordData WithCanStack(this KeywordData dataFile, bool show)
        {
            dataFile.canStack = show;
            return dataFile;
        }
    }
    public static class StatusEffectDataHelpers
    {
        public static StatusEffectImmuneToX WithImmunityType(this StatusEffectImmuneToX dataFile, string immunityType = "snow")
        {
            dataFile.immunityType = immunityType;
            return dataFile;
        }

        public static StatusEffectResistX WithResistType(this StatusEffectResistX dataFile, string resistType = "snow")
        {
            dataFile.resistType = resistType;
            return dataFile;
        }

        public static StatusEffectInjury WithHealthFactor(this StatusEffectInjury dataFile, float healthFactor = 0.5f)
        {
            dataFile.healthFactor = healthFactor;
            return dataFile;
        }

        public static StatusEffectInjury WithDamageFactor(this StatusEffectInjury dataFile, float damageFactor = 0.5f)
        {
            dataFile.damageFactor = damageFactor;
            return dataFile;
        }

        public static StatusEffectInjury WithCounterIncrease(this StatusEffectInjury dataFile, int counterIncrease)
        {
            dataFile.counterIncrease = counterIncrease;
            return dataFile;
        }

        public static StatusEffectInstantActivateSacrificeEffects WithForOtherTeam(this StatusEffectInstantActivateSacrificeEffects dataFile, bool forOtherTeam)
        {
            dataFile.forOtherTeam = forOtherTeam;
            return dataFile;
        }

        public static StatusEffectInstantApplyEffect WithEffectToApply(this StatusEffectInstantApplyEffect dataFile, StatusEffectData effectToApply)
        {
            dataFile.effectToApply = effectToApply;
            return dataFile;
        }

        public static StatusEffectInstantApplyEffect WithScriptableAmount(this StatusEffectInstantApplyEffect dataFile, ScriptableAmount scriptableAmount)
        {
            dataFile.scriptableAmount = scriptableAmount;
            return dataFile;
        }

        public static StatusEffectInstantCopyEffects WithReplaceAllEffects(this StatusEffectInstantCopyEffects dataFile, bool replaceAllEffects = true)
        {
            dataFile.replaceAllEffects = replaceAllEffects;
            return dataFile;
        }

        public static StatusEffectInstantCopyEffects WithReplaceEffectNumber(this StatusEffectInstantCopyEffects dataFile, int replaceEffectNumber)
        {
            dataFile.replaceEffectNumber = replaceEffectNumber;
            return dataFile;
        }

        public static StatusEffectInstantDestroyCardsInHandAndApplyXForEach WithDestroyConstraints(this StatusEffectInstantDestroyCardsInHandAndApplyXForEach dataFile, TargetConstraint[] destroyConstraints)
        {
            dataFile.destroyConstraints = destroyConstraints;
            return dataFile;
        }

        public static StatusEffectInstantDestroyCardsInHandAndApplyXForEach WithDestroyCardEffect(this StatusEffectInstantDestroyCardsInHandAndApplyXForEach dataFile, StatusEffectInstant destroyCardEffect)
        {
            dataFile.destroyCardEffect = destroyCardEffect;
            return dataFile;
        }

        public static StatusEffectInstantDestroyCardsInHandAndApplyXForEach WithEffectToApply(this StatusEffectInstantDestroyCardsInHandAndApplyXForEach dataFile, StatusEffectData effectToApply)
        {
            dataFile.effectToApply = effectToApply;
            return dataFile;
        }

        public static StatusEffectInstantDoubleX WithCountsAsHit(this StatusEffectInstantDoubleX dataFile, bool countsAsHit = true)
        {
            dataFile.countsAsHit = countsAsHit;
            return dataFile;
        }

        public static StatusEffectInstantEat WithGainHealth(this StatusEffectInstantEat dataFile, bool gainHealth = true)
        {
            dataFile.gainHealth = gainHealth;
            return dataFile;
        }

        public static StatusEffectInstantEat WithGainAttack(this StatusEffectInstantEat dataFile, bool gainAttack = true)
        {
            dataFile.gainAttack = gainAttack;
            return dataFile;
        }

        public static StatusEffectInstantEat WithGainEffects(this StatusEffectInstantEat dataFile, bool gainEffects = true)
        {
            dataFile.gainEffects = gainEffects;
            return dataFile;
        }

        public static StatusEffectInstantEat WithIllegalTraits(this StatusEffectInstantEat dataFile, TraitData[] illegalTraits)
        {
            dataFile.illegalTraits = illegalTraits;
            return dataFile;
        }

        public static StatusEffectInstantEat WithIllegalEffects(this StatusEffectInstantEat dataFile, StatusEffectData[] illegalEffects)
        {
            dataFile.illegalEffects = illegalEffects;
            return dataFile;
        }

        public static StatusEffectInstantEatSomething WithDelayAfter(this StatusEffectInstantEatSomething dataFile, float delayAfter = 0.25f)
        {
            dataFile.delayAfter = delayAfter;
            return dataFile;
        }

        public static StatusEffectInstantEatSomething WithEatEffect(this StatusEffectInstantEatSomething dataFile, StatusEffectData eatEffect)
        {
            dataFile.eatEffect = eatEffect;
            return dataFile;
        }

        public static StatusEffectInstantEatSomething WithTargetFlags(this StatusEffectInstantEatSomething dataFile, Targets.Flag targetFlags)
        {
            dataFile.targetFlags = targetFlags;
            return dataFile;
        }

        public static StatusEffectInstantFillBoard WithDoPing(this StatusEffectInstantFillBoard dataFile, bool doPing = true)
        {
            dataFile.doPing = doPing;
            return dataFile;
        }

        public static StatusEffectInstantFillBoard WithSfxEvent(this StatusEffectInstantFillBoard dataFile, FMODUnity.EventReference sfxEvent)
        {
            dataFile.sfxEvent = sfxEvent;
            return dataFile;
        }
        /// <summary>see vanilla references</summary>
        /// <param name="selectSfxEvent">format: "event:/..."</param>
        public static StatusEffectInstantFillBoard WithSfxEvent(this StatusEffectInstantFillBoard dataFile, string sfxEvent)
        {
            dataFile.sfxEvent = RuntimeManager.PathToEventReference(sfxEvent);
            return dataFile;
        }

        public static StatusEffectInstantFillBoard WithWithCards(this StatusEffectInstantFillBoard dataFile, CardData[] withCards)
        {
            dataFile.withCards = withCards;
            return dataFile;
        }

        public static StatusEffectInstantGainGold WithTake(this StatusEffectInstantGainGold dataFile, bool take)
        {
            dataFile.take = take;
            return dataFile;
        }

        public static StatusEffectInstantGainGoldRange WithRange(this StatusEffectInstantGainGoldRange dataFile, UnityEngine.Vector2Int range)
        {
            dataFile.range = range;
            return dataFile;
        }

        public static StatusEffectInstantHeal WithDoPing(this StatusEffectInstantHeal dataFile, bool doPing = true)
        {
            dataFile.doPing = doPing;
            return dataFile;
        }

        public static StatusEffectInstantHealFullGainEqualX WithEffectToGain(this StatusEffectInstantHealFullGainEqualX dataFile, StatusEffectData effectToGain)
        {
            dataFile.effectToGain = effectToGain;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseAttack WithScriptableAmount(this StatusEffectInstantIncreaseAttack dataFile, ScriptableAmount scriptableAmount)
        {
            dataFile.scriptableAmount = scriptableAmount;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseEffects WithAllEffects(this StatusEffectInstantIncreaseEffects dataFile, bool allEffects = true)
        {
            dataFile.allEffects = allEffects;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseEffects WithAllAttackEffects(this StatusEffectInstantIncreaseEffects dataFile, bool allAttackEffects)
        {
            dataFile.allAttackEffects = allAttackEffects;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseEffects WithAllPassiveEffects(this StatusEffectInstantIncreaseEffects dataFile, bool allPassiveEffects)
        {
            dataFile.allPassiveEffects = allPassiveEffects;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseEffects WithAttackEffectIndex(this StatusEffectInstantIncreaseEffects dataFile, int attackEffectIndex = -1)
        {
            dataFile.attackEffectIndex = attackEffectIndex;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseEffects WithPassiveEffectIndex(this StatusEffectInstantIncreaseEffects dataFile, int passiveEffectIndex = -1)
        {
            dataFile.passiveEffectIndex = passiveEffectIndex;
            return dataFile;
        }

        public static StatusEffectInstantIncreaseMaxHealth WithAlsoIncreaseCurrentHealth(this StatusEffectInstantIncreaseMaxHealth dataFile, bool alsoIncreaseCurrentHealth = true)
        {
            dataFile.alsoIncreaseCurrentHealth = alsoIncreaseCurrentHealth;
            return dataFile;
        }

        public static StatusEffectInstantKill WithKillConstraints(this StatusEffectInstantKill dataFile, TargetConstraint[] killConstraints)
        {
            dataFile.killConstraints = killConstraints;
            return dataFile;
        }

        public static StatusEffectInstantKill WithStatusesToClear(this StatusEffectInstantKill dataFile, string[] statusesToClear)
        {
            dataFile.statusesToClear = statusesToClear;
            return dataFile;
        }

        public static StatusEffectInstantLoseX WithStatusToLose(this StatusEffectInstantLoseX dataFile, StatusEffectData statusToLose)
        {
            dataFile.statusToLose = statusToLose;
            return dataFile;
        }

        public static StatusEffectInstantLoseX WithDoPing(this StatusEffectInstantLoseX dataFile, bool doPing)
        {
            dataFile.doPing = doPing;
            return dataFile;
        }

        public static StatusEffectInstantRandomizeStats WithMin(this StatusEffectInstantRandomizeStats dataFile, int min = 2)
        {
            dataFile.min = min;
            return dataFile;
        }

        public static StatusEffectInstantRandomizeStats WithMax(this StatusEffectInstantRandomizeStats dataFile, int max = 5)
        {
            dataFile.max = max;
            return dataFile;
        }

        public static StatusEffectInstantReduceEffects WithAllEffects(this StatusEffectInstantReduceEffects dataFile, bool allEffects = true)
        {
            dataFile.allEffects = allEffects;
            return dataFile;
        }

        public static StatusEffectInstantReduceEffects WithAttackEffectIndex(this StatusEffectInstantReduceEffects dataFile, int attackEffectIndex = -1)
        {
            dataFile.attackEffectIndex = attackEffectIndex;
            return dataFile;
        }

        public static StatusEffectInstantReduceEffects WithPassiveEffectIndex(this StatusEffectInstantReduceEffects dataFile, int passiveEffectIndex = -1)
        {
            dataFile.passiveEffectIndex = passiveEffectIndex;
            return dataFile;
        }

        public static StatusEffectInstantSetAttack WithMaxOnly(this StatusEffectInstantSetAttack dataFile, bool maxOnly)
        {
            dataFile.maxOnly = maxOnly;
            return dataFile;
        }

        public static StatusEffectInstantSetAttack WithEqualAmount(this StatusEffectInstantSetAttack dataFile, bool equalAmount = true)
        {
            dataFile.equalAmount = equalAmount;
            return dataFile;
        }

        public static StatusEffectInstantSetAttack WithSetMaxAttackEffect(this StatusEffectInstantSetAttack dataFile, StatusEffectInstantSetAttack setMaxAttackEffect)
        {
            dataFile.setMaxAttackEffect = setMaxAttackEffect;
            return dataFile;
        }

        public static StatusEffectInstantSetAttack WithFactor(this StatusEffectInstantSetAttack dataFile, float factor = 1f)
        {
            dataFile.factor = factor;
            return dataFile;
        }

        public static StatusEffectInstantSetHealth WithMaxOnly(this StatusEffectInstantSetHealth dataFile, bool maxOnly)
        {
            dataFile.maxOnly = maxOnly;
            return dataFile;
        }

        public static StatusEffectInstantSetHealth WithEqualAmount(this StatusEffectInstantSetHealth dataFile, bool equalAmount = true)
        {
            dataFile.equalAmount = equalAmount;
            return dataFile;
        }

        public static StatusEffectInstantSetHealth WithSetMaxHealthEffect(this StatusEffectInstantSetHealth dataFile, StatusEffectInstantSetHealth setMaxHealthEffect)
        {
            dataFile.setMaxHealthEffect = setMaxHealthEffect;
            return dataFile;
        }

        public static StatusEffectInstantSetHealth WithFactor(this StatusEffectInstantSetHealth dataFile, float factor = 1f)
        {
            dataFile.factor = factor;
            return dataFile;
        }

        public static StatusEffectInstantSplit WithProfiles(this StatusEffectInstantSplit dataFile, StatusEffectInstantSplit.Profile[] profiles)
        {
            dataFile.profiles = profiles;
            return dataFile;
        }

        public static StatusEffectInstantSummon WithCanSummonMultiple(this StatusEffectInstantSummon dataFile, bool canSummonMultiple)
        {
            dataFile.canSummonMultiple = canSummonMultiple;
            return dataFile;
        }

        public static StatusEffectInstantSummon WithSummonCopy(this StatusEffectInstantSummon dataFile, bool summonCopy)
        {
            dataFile.summonCopy = summonCopy;
            return dataFile;
        }

        public static StatusEffectInstantSummon WithSummonPosition(this StatusEffectInstantSummon dataFile, StatusEffectInstantSummon.Position summonPosition)
        {
            dataFile.summonPosition = summonPosition;
            return dataFile;
        }

        public static StatusEffectInstantSummon WithWithEffects(this StatusEffectInstantSummon dataFile, StatusEffectData[] withEffects)
        {
            dataFile.withEffects = withEffects;
            return dataFile;
        }

        public static StatusEffectInstantSummon WithQueue(this StatusEffectInstantSummon dataFile, bool queue = true)
        {
            dataFile.queue = queue;
            return dataFile;
        }

        public static StatusEffectInstantTakeAttack WithIncreaseAttackEffect(this StatusEffectInstantTakeAttack dataFile, StatusEffectData increaseAttackEffect)
        {
            dataFile.increaseAttackEffect = increaseAttackEffect;
            return dataFile;
        }

        public static StatusEffectInstantTakeHealth WithIncreaseHealthEffect(this StatusEffectInstantTakeHealth dataFile, StatusEffectData increaseHealthEffect)
        {
            dataFile.increaseHealthEffect = increaseHealthEffect;
            return dataFile;
        }

        public static StatusEffectInstantTrigger WithAgainstRandomEnemy(this StatusEffectInstantTrigger dataFile, bool againstRandomEnemy)
        {
            dataFile.againstRandomEnemy = againstRandomEnemy;
            return dataFile;
        }

        public static StatusEffectInstantTrigger WithReduceUses(this StatusEffectInstantTrigger dataFile, bool reduceUses)
        {
            dataFile.reduceUses = reduceUses;
            return dataFile;
        }

        public static StatusEffectInstantTrigger WithPriority(this StatusEffectInstantTrigger dataFile, int priority = -1)
        {
            dataFile.priority = priority;
            return dataFile;
        }

        public static StatusEffectInstantTriggerAgainst WithCountsAsTrigger(this StatusEffectInstantTriggerAgainst dataFile, bool countsAsTrigger = true)
        {
            dataFile.countsAsTrigger = countsAsTrigger;
            return dataFile;
        }

        public static StatusEffectInstantTriggerAgainst WithTriggerType(this StatusEffectInstantTriggerAgainst dataFile, string triggerType = "basic")
        {
            dataFile.triggerType = triggerType;
            return dataFile;
        }

        public static StatusEffectInstantTriggerAgainst WithReduceUses(this StatusEffectInstantTriggerAgainst dataFile, bool reduceUses)
        {
            dataFile.reduceUses = reduceUses;
            return dataFile;
        }

        public static StatusEffectNextPhase WithNextPhase(this StatusEffectNextPhase dataFile, CardData nextPhase)
        {
            dataFile.nextPhase = nextPhase;
            return dataFile;
        }

        public static StatusEffectNextPhase WithSplitOptions(this StatusEffectNextPhase dataFile, CardData[] splitOptions)
        {
            dataFile.splitOptions = splitOptions;
            return dataFile;
        }

        public static StatusEffectNextPhase WithSplitCount(this StatusEffectNextPhase dataFile, int splitCount)
        {
            dataFile.splitCount = splitCount;
            return dataFile;
        }

        public static StatusEffectNextPhase WithAnimation(this StatusEffectNextPhase dataFile, CardAnimation animation)
        {
            dataFile.animation = animation;
            return dataFile;
        }
        public static StatusEffectNextPhase WithAnimation(this StatusEffectNextPhase dataFile, string animation = "ClunkerBossPhaseChange")
        {
            dataFile.animation = AssetLoader.Lookup<CardAnimation>("CardAnimations", animation);
            return dataFile; 
        }

        public static StatusEffectOngoing WithReverse(this StatusEffectOngoing dataFile, bool reverse)
        {
            dataFile.reverse = reverse;
            return dataFile;
        }

        public static StatusEffectOngoingEffects WithAdd(this StatusEffectOngoingEffects dataFile, bool add = true)
        {
            dataFile.add = add;
            return dataFile;
        }

        public static StatusEffectOngoingEffects WithMultiply(this StatusEffectOngoingEffects dataFile, bool multiply)
        {
            dataFile.multiply = multiply;
            return dataFile;
        }

        public static StatusEffectTriggerWhenAllyAttacks WithAllyInRow(this StatusEffectTriggerWhenAllyAttacks dataFile, bool allyInRow = true)
        {
            dataFile.allyInRow = allyInRow;
            return dataFile;
        }

        public static StatusEffectTriggerWhenAllyAttacks WithAgainstTarget(this StatusEffectTriggerWhenAllyAttacks dataFile, bool againstTarget)
        {
            dataFile.againstTarget = againstTarget;
            return dataFile;
        }

        public static StatusEffectTriggerWhenCardTypeUsedOnAlly WithIncludeSelf(this StatusEffectTriggerWhenCardTypeUsedOnAlly dataFile, bool includeSelf)
        {
            dataFile.includeSelf = includeSelf;
            return dataFile;
        }

        public static StatusEffectTriggerWhenCardTypeUsedOnAlly WithCardTypeTriggers(this StatusEffectTriggerWhenCardTypeUsedOnAlly dataFile, string[] cardTypeTriggers)
        {
            dataFile.cardTypeTriggers = cardTypeTriggers;
            return dataFile;
        }

        public static StatusEffectTriggerWhenStatusApplied WithTargetStatus(this StatusEffectTriggerWhenStatusApplied dataFile, StatusEffectData targetStatus)
        {
            dataFile.targetStatus = targetStatus;
            return dataFile;
        }

        public static StatusEffectTriggerWhenStatusApplied WithFriendlyFire(this StatusEffectTriggerWhenStatusApplied dataFile, bool friendlyFire = true)
        {
            dataFile.friendlyFire = friendlyFire;
            return dataFile;
        }

        public static StatusEffectTriggerWhenStatusApplied WithSelfFire(this StatusEffectTriggerWhenStatusApplied dataFile, bool selfFire = true)
        {
            dataFile.selfFire = selfFire;
            return dataFile;
        }

        public static StatusEffectTriggerWhenStatusApplied WithTriggerType(this StatusEffectTriggerWhenStatusApplied dataFile, StatusEffectTriggerWhenStatusApplied.TriggerType triggerType)
        {
            dataFile.triggerType = triggerType;
            return dataFile;
        }

        public static StatusEffectWhileActiveApplyXToEachCardPlayed WithEffectToApply(this StatusEffectWhileActiveApplyXToEachCardPlayed dataFile, StatusEffectData effectToApply)
        {
            dataFile.effectToApply = effectToApply;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithEffectToAffect(this StatusEffectAffectAllXApplied dataFile, StatusEffectData effectToAffect)
        {
            dataFile.effectToAffect = effectToAffect;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithSetToSpecificValue(this StatusEffectAffectAllXApplied dataFile, bool setToSpecificValue)
        {
            dataFile.setToSpecificValue = setToSpecificValue;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithSpecificValue(this StatusEffectAffectAllXApplied dataFile, int specificValue)
        {
            dataFile.specificValue = specificValue;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithAdd(this StatusEffectAffectAllXApplied dataFile, int add)
        {
            dataFile.add = add;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithMultiplyBy(this StatusEffectAffectAllXApplied dataFile, float multiplyBy = 2f)
        {
            dataFile.multiplyBy = multiplyBy;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithTargetCanBeFriendly(this StatusEffectAffectAllXApplied dataFile, bool targetCanBeFriendly = true)
        {
            dataFile.targetCanBeFriendly = targetCanBeFriendly;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithTargetCanBeEnemy(this StatusEffectAffectAllXApplied dataFile, bool targetCanBeEnemy = true)
        {
            dataFile.targetCanBeEnemy = targetCanBeEnemy;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithApplierCanBeFriendly(this StatusEffectAffectAllXApplied dataFile, bool applierCanBeFriendly = true)
        {
            dataFile.applierCanBeFriendly = applierCanBeFriendly;
            return dataFile;
        }

        public static StatusEffectAffectAllXApplied WithApplierCanBeEnemy(this StatusEffectAffectAllXApplied dataFile, bool applierCanBeEnemy = true)
        {
            dataFile.applierCanBeEnemy = applierCanBeEnemy;
            return dataFile;
        }

        public static StatusEffectApplyX WithSelectScript(this StatusEffectApplyX dataFile, SelectScript<Entity> selectScript)
        {
            dataFile.selectScript = selectScript;
            return dataFile;
        }

        public static StatusEffectApplyX WithContextEqualAmount(this StatusEffectApplyX dataFile, ScriptableAmount contextEqualAmount)
        {
            dataFile.contextEqualAmount = contextEqualAmount;
            return dataFile;
        }

        public static StatusEffectApplyX WithEqualAmountBonusMult(this StatusEffectApplyX dataFile, float equalAmountBonusMult)
        {
            dataFile.equalAmountBonusMult = equalAmountBonusMult;
            return dataFile;
        }

        public static StatusEffectApplyX WithScriptableAmount(this StatusEffectApplyX dataFile, ScriptableAmount scriptableAmount)
        {
            dataFile.scriptableAmount = scriptableAmount;
            return dataFile;
        }

        public static StatusEffectApplyX WithNoTargetType(this StatusEffectApplyX dataFile, NoTargetType noTargetType)
        {
            dataFile.noTargetType = noTargetType;
            return dataFile;
        }

        public static StatusEffectApplyX WithNoTargetTypeArgs(this StatusEffectApplyX dataFile, string[] noTargetTypeArgs)
        {
            dataFile.noTargetTypeArgs = noTargetTypeArgs;
            return dataFile;
        }

        public static StatusEffectApplyXEveryTurn WithMode(this StatusEffectApplyXEveryTurn dataFile, StatusEffectApplyXEveryTurn.Mode mode)
        {
            dataFile.mode = mode;
            return dataFile;
        }

        public static StatusEffectApplyXOnHit WithPostHit(this StatusEffectApplyXOnHit dataFile, bool postHit)
        {
            dataFile.postHit = postHit;
            return dataFile;
        }

        public static StatusEffectApplyXOnHit WithAddDamageFactor(this StatusEffectApplyXOnHit dataFile, int addDamageFactor)
        {
            dataFile.addDamageFactor = addDamageFactor;
            return dataFile;
        }

        public static StatusEffectApplyXOnHit WithMultiplyDamageFactor(this StatusEffectApplyXOnHit dataFile, float multiplyDamageFactor = 1f)
        {
            dataFile.multiplyDamageFactor = multiplyDamageFactor;
            return dataFile;
        }

        public static StatusEffectApplyXOnTurn WithTrueOnTurn(this StatusEffectApplyXOnTurn dataFile, bool trueOnTurn)
        {
            dataFile.trueOnTurn = trueOnTurn;
            return dataFile;
        }

        public static StatusEffectApplyXPreTrigger WithMustHaveTarget(this StatusEffectApplyXPreTrigger dataFile, bool mustHaveTarget)
        {
            dataFile.mustHaveTarget = mustHaveTarget;
            return dataFile;
        }

        public static StatusEffectApplyXPreTrigger WithOncePerTurn(this StatusEffectApplyXPreTrigger dataFile, bool oncePerTurn = true)
        {
            dataFile.oncePerTurn = oncePerTurn;
            return dataFile;
        }

        public static StatusEffectApplyXPreTurn WithMustHaveTarget(this StatusEffectApplyXPreTurn dataFile, bool mustHaveTarget)
        {
            dataFile.mustHaveTarget = mustHaveTarget;
            return dataFile;
        }

        public static StatusEffectApplyXWhenAllyIsHit WithIncludeSelf(this StatusEffectApplyXWhenAllyIsHit dataFile, bool includeSelf)
        {
            dataFile.includeSelf = includeSelf;
            return dataFile;
        }

        public static StatusEffectApplyXWhenAllyIsKilled WithSacrificed(this StatusEffectApplyXWhenAllyIsKilled dataFile, bool sacrificed)
        {
            dataFile.sacrificed = sacrificed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenAnyoneTakesDamage WithTargetDamageType(this StatusEffectApplyXWhenAnyoneTakesDamage dataFile, string targetDamageType = "basic")
        {
            dataFile.targetDamageType = targetDamageType;
            return dataFile;
        }

        public static StatusEffectApplyXWhenCardDestroyed WithCanBeAlly(this StatusEffectApplyXWhenCardDestroyed dataFile, bool canBeAlly = true)
        {
            dataFile.canBeAlly = canBeAlly;
            return dataFile;
        }

        public static StatusEffectApplyXWhenCardDestroyed WithCanBeEnemy(this StatusEffectApplyXWhenCardDestroyed dataFile, bool canBeEnemy = true)
        {
            dataFile.canBeEnemy = canBeEnemy;
            return dataFile;
        }

        public static StatusEffectApplyXWhenCardDestroyed WithMustBeSacrificed(this StatusEffectApplyXWhenCardDestroyed dataFile, bool mustBeSacrificed)
        {
            dataFile.mustBeSacrificed = mustBeSacrificed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenCardDestroyed WithMustBeOnBoard(this StatusEffectApplyXWhenCardDestroyed dataFile, bool mustBeOnBoard = true)
        {
            dataFile.mustBeOnBoard = mustBeOnBoard;
            return dataFile;
        }

        public static StatusEffectApplyXWhenCardDestroyed WithConstraints(this StatusEffectApplyXWhenCardDestroyed dataFile, TargetConstraint[] constraints)
        {
            dataFile.constraints = constraints;
            return dataFile;
        }

        public static StatusEffectApplyXWhenDamageTaken WithTargetDamageType(this StatusEffectApplyXWhenDamageTaken dataFile, string targetDamageType = "basic")
        {
            dataFile.targetDamageType = targetDamageType;
            return dataFile;
        }

        public static StatusEffectApplyXWhenDeployed WithWhenSelfDeployed(this StatusEffectApplyXWhenDeployed dataFile, bool whenSelfDeployed = true)
        {
            dataFile.whenSelfDeployed = whenSelfDeployed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenDeployed WithWhenAllyDeployed(this StatusEffectApplyXWhenDeployed dataFile, bool whenAllyDeployed)
        {
            dataFile.whenAllyDeployed = whenAllyDeployed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenDeployed WithWhenEnemyDeployed(this StatusEffectApplyXWhenDeployed dataFile, bool whenEnemyDeployed)
        {
            dataFile.whenEnemyDeployed = whenEnemyDeployed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenDestroyed WithSacrificed(this StatusEffectApplyXWhenDestroyed dataFile, bool sacrificed)
        {
            dataFile.sacrificed = sacrificed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenDestroyed WithConsumed(this StatusEffectApplyXWhenDestroyed dataFile, bool consumed)
        {
            dataFile.consumed = consumed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenHealed WithAlsoWhenMaxHealthIncreased(this StatusEffectApplyXWhenHealed dataFile, bool alsoWhenMaxHealthIncreased = true)
        {
            dataFile.alsoWhenMaxHealthIncreased = alsoWhenMaxHealthIncreased;
            return dataFile;
        }

        public static StatusEffectApplyXWhenHealthLost WithHasThreshold(this StatusEffectApplyXWhenHealthLost dataFile, bool hasThreshold)
        {
            dataFile.hasThreshold = hasThreshold;
            return dataFile;
        }

        public static StatusEffectApplyXWhenHit WithAttackerConstraints(this StatusEffectApplyXWhenHit dataFile, TargetConstraint[] attackerConstraints)
        {
            dataFile.attackerConstraints = attackerConstraints;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsHit WithAlly(this StatusEffectApplyXWhenUnitIsHit dataFile, bool ally = true)
        {
            dataFile.ally = ally;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsHit WithEnemy(this StatusEffectApplyXWhenUnitIsHit dataFile, bool enemy)
        {
            dataFile.enemy = enemy;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsHit WithUnitConstraints(this StatusEffectApplyXWhenUnitIsHit dataFile, TargetConstraint[] unitConstraints)
        {
            dataFile.unitConstraints = unitConstraints;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsHit WithAttackerConstraints(this StatusEffectApplyXWhenUnitIsHit dataFile, TargetConstraint[] attackerConstraints)
        {
            dataFile.attackerConstraints = attackerConstraints;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsKilled WithAlly(this StatusEffectApplyXWhenUnitIsKilled dataFile, bool ally = true)
        {
            dataFile.ally = ally;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsKilled WithEnemy(this StatusEffectApplyXWhenUnitIsKilled dataFile, bool enemy)
        {
            dataFile.enemy = enemy;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsKilled WithSacrificed(this StatusEffectApplyXWhenUnitIsKilled dataFile, bool sacrificed)
        {
            dataFile.sacrificed = sacrificed;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitIsKilled WithUnitConstraints(this StatusEffectApplyXWhenUnitIsKilled dataFile, TargetConstraint[] unitConstraints)
        {
            dataFile.unitConstraints = unitConstraints;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitLosesY WithSelf(this StatusEffectApplyXWhenUnitLosesY dataFile, bool self = true)
        {
            dataFile.self = self;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitLosesY WithAllies(this StatusEffectApplyXWhenUnitLosesY dataFile, bool allies)
        {
            dataFile.allies = allies;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitLosesY WithEnemies(this StatusEffectApplyXWhenUnitLosesY dataFile, bool enemies)
        {
            dataFile.enemies = enemies;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitLosesY WithStatusType(this StatusEffectApplyXWhenUnitLosesY dataFile, string statusType = "block")
        {
            dataFile.statusType = statusType;
            return dataFile;
        }

        public static StatusEffectApplyXWhenUnitLosesY WithWhenAllLost(this StatusEffectApplyXWhenUnitLosesY dataFile, bool whenAllLost)
        {
            dataFile.whenAllLost = whenAllLost;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYAppliedTo WithInstead(this StatusEffectApplyXWhenYAppliedTo dataFile, bool instead)
        {
            dataFile.instead = instead;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYAppliedTo WithWhenAppliedToFlags(this StatusEffectApplyXWhenYAppliedTo dataFile, StatusEffectApplyX.ApplyToFlags whenAppliedToFlags)
        {
            dataFile.whenAppliedToFlags = whenAppliedToFlags;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYAppliedTo WithMustReachAmount(this StatusEffectApplyXWhenYAppliedTo dataFile, bool mustReachAmount)
        {
            dataFile.mustReachAmount = mustReachAmount;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYAppliedTo WithAdjustAmount(this StatusEffectApplyXWhenYAppliedTo dataFile, bool adjustAmount)
        {
            dataFile.adjustAmount = adjustAmount;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYAppliedTo WithAddAmount(this StatusEffectApplyXWhenYAppliedTo dataFile, int addAmount)
        {
            dataFile.addAmount = addAmount;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYAppliedTo WithMultiplyAmount(this StatusEffectApplyXWhenYAppliedTo dataFile, float multiplyAmount = 1f)
        {
            dataFile.multiplyAmount = multiplyAmount;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYLost WithStatusType(this StatusEffectApplyXWhenYLost dataFile, string statusType = "block")
        {
            dataFile.statusType = statusType;
            return dataFile;
        }

        public static StatusEffectApplyXWhenYLost WithWhenAllLost(this StatusEffectApplyXWhenYLost dataFile, bool whenAllLost)
        {
            dataFile.whenAllLost = whenAllLost;
            return dataFile;
        }

        public static StatusEffectBombard WithTargetCountRange(this StatusEffectBombard dataFile, UnityEngine.Vector2Int targetCountRange)
        {
            dataFile.targetCountRange = targetCountRange;
            return dataFile;
        }

        public static StatusEffectBombard WithHitFriendlyChance(this StatusEffectBombard dataFile, float hitFriendlyChance = 0.1f)
        {
            dataFile.hitFriendlyChance = hitFriendlyChance;
            return dataFile;
        }

        public static StatusEffectBombard WithDelayBetweenTargets(this StatusEffectBombard dataFile, float delayBetweenTargets = 0.1f)
        {
            dataFile.delayBetweenTargets = delayBetweenTargets;
            return dataFile;
        }

        public static StatusEffectBombard WithDelayAfter(this StatusEffectBombard dataFile, float delayAfter = 0.1f)
        {
            dataFile.delayAfter = delayAfter;
            return dataFile;
        }

        public static StatusEffectBombard WithMaxFrontTargets(this StatusEffectBombard dataFile, int maxFrontTargets)
        {
            dataFile.maxFrontTargets = maxFrontTargets;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToCards WithCardName(this StatusEffectBonusDamageEqualToCards dataFile, string cardName = "Dart")
        {
            dataFile.cardName = cardName;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToCards WithInHand(this StatusEffectBonusDamageEqualToCards dataFile, bool inHand = true)
        {
            dataFile.inHand = inHand;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToCards WithOnBoard(this StatusEffectBonusDamageEqualToCards dataFile, bool onBoard)
        {
            dataFile.onBoard = onBoard;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToCards WithIncludeSelf(this StatusEffectBonusDamageEqualToCards dataFile, bool includeSelf = true)
        {
            dataFile.includeSelf = includeSelf;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToCards WithPing(this StatusEffectBonusDamageEqualToCards dataFile, bool ping = true)
        {
            dataFile.ping = ping;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToEnemyStat WithSelectEnemy(this StatusEffectBonusDamageEqualToEnemyStat dataFile, SelectScript<Entity> selectEnemy)
        {
            dataFile.selectEnemy = selectEnemy;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToEnemyStat WithScriptableAmount(this StatusEffectBonusDamageEqualToEnemyStat dataFile, ScriptableAmount scriptableAmount)
        {
            dataFile.scriptableAmount = scriptableAmount;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToEnemyStat WithAdd(this StatusEffectBonusDamageEqualToEnemyStat dataFile, bool add = true)
        {
            dataFile.add = add;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToEnemyStat WithPing(this StatusEffectBonusDamageEqualToEnemyStat dataFile, bool ping = true)
        {
            dataFile.ping = ping;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToX WithOn(this StatusEffectBonusDamageEqualToX dataFile, StatusEffectBonusDamageEqualToX.On on)
        {
            dataFile.on = on;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToX WithScriptableAmount(this StatusEffectBonusDamageEqualToX dataFile, ScriptableAmount scriptableAmount)
        {
            dataFile.scriptableAmount = scriptableAmount;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToX WithAdd(this StatusEffectBonusDamageEqualToX dataFile, bool add = true)
        {
            dataFile.add = add;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToX WithHealth(this StatusEffectBonusDamageEqualToX dataFile, bool health)
        {
            dataFile.health = health;
            return dataFile;
        }

        public static StatusEffectBonusDamageEqualToX WithPing(this StatusEffectBonusDamageEqualToX dataFile, bool ping = true)
        {
            dataFile.ping = ping;
            return dataFile;
        }

        public static StatusEffectChangeRecycleRequirement WithLower(this StatusEffectChangeRecycleRequirement dataFile, bool lower = true)
        {
            dataFile.lower = lower;
            return dataFile;
        }

        public static StatusEffectDoubleAllXWhenDestroyed WithEffectToDouble(this StatusEffectDoubleAllXWhenDestroyed dataFile, StatusEffectData effectToDouble)
        {
            dataFile.effectToDouble = effectToDouble;
            return dataFile;
        }

        public static StatusEffectHaltX WithEffectToHalt(this StatusEffectHaltX dataFile, StatusEffectData effectToHalt)
        {
            dataFile.effectToHalt = effectToHalt;
            return dataFile;
        }

        public static StatusEffectHaltX WithIgnoreSilence(this StatusEffectHaltX dataFile, bool ignoreSilence = true)
        {
            dataFile.ignoreSilence = ignoreSilence;
            return dataFile;
        }

        public static StatusEffectIncreaseAttackWhileDamaged WithEffectToGain(this StatusEffectIncreaseAttackWhileDamaged dataFile, StatusEffectData effectToGain)
        {
            dataFile.effectToGain = effectToGain;
            return dataFile;
        }

        public static StatusEffectTemporaryTrait WithTrait(this StatusEffectTemporaryTrait dataFile, TraitData trait)
        {
            dataFile.trait = trait;
            return dataFile;
        }

        public static StatusEffectWhileActiveAlliesImmuneToX WithImmunityEffect(this StatusEffectWhileActiveAlliesImmuneToX dataFile, StatusEffectData immunityEffect)
        {
            dataFile.immunityEffect = immunityEffect;
            return dataFile;
        }

        public static StatusEffectWhileActiveX WithIfCloneAffectOriginal(this StatusEffectWhileActiveX dataFile, bool ifCloneAffectOriginal = true)
        {
            dataFile.ifCloneAffectOriginal = ifCloneAffectOriginal;
            return dataFile;
        }

        public static StatusEffectWhileActiveX WithAffectOthersWithSameEffect(this StatusEffectWhileActiveX dataFile, bool affectOthersWithSameEffect = true)
        {
            dataFile.affectOthersWithSameEffect = affectOthersWithSameEffect;
            return dataFile;
        }

        public static StatusEffectMultiHit WithClearAfter(this StatusEffectMultiHit dataFile, bool clearAfter)
        {
            dataFile.clearAfter = clearAfter;
            return dataFile;
        }

        public static StatusEffectOverload WithBuildupAnimation(this StatusEffectOverload dataFile, CardAnimation buildupAnimation)
        {
            dataFile.buildupAnimation = buildupAnimation;
            return dataFile;
        }
        public static StatusEffectOverload WithBuildupAnimation(this StatusEffectOverload dataFile, string buildupAnimation)
        {
            dataFile.buildupAnimation = AssetLoader.Lookup<CardAnimation>("CardAnimations", buildupAnimation);
            return dataFile; 
        }

        public static StatusEffectSnow WithCountDownType(this StatusEffectSnow dataFile, StatusEffectSnow.CountDownType countDownType)
        {
            dataFile.countDownType = countDownType;
            return dataFile;
        }

        public static StatusEffectSummon WithEffectPrefabRef(this StatusEffectSummon dataFile, UnityEngine.AddressableAssets.AssetReference effectPrefabRef)
        {
            dataFile.effectPrefabRef = effectPrefabRef;
            return dataFile;
        }

        public static StatusEffectApplyToSummon WithEffectToApply(this StatusEffectApplyToSummon dataFile, StatusEffectData effectToApply)
        {
            dataFile.effectToApply = effectToApply;
            return dataFile;
        }

        public static StatusEffectBuild WithRequires(this StatusEffectBuild dataFile, int requires = 3)
        {
            dataFile.requires = requires;
            return dataFile;
        }

        public static StatusEffectChangePriorityPosition WithPositionPriorityChange(this StatusEffectChangePriorityPosition dataFile, int positionPriorityChange = -1)
        {
            dataFile.positionPriorityChange = positionPriorityChange;
            return dataFile;
        }

        public static StatusEffectChangeTargetMode WithTargetMode(this StatusEffectChangeTargetMode dataFile, TargetMode targetMode)
        {
            dataFile.targetMode = targetMode;
            return dataFile;
        }

        public static StatusEffectFreeAction WithPetPrefab(this StatusEffectFreeAction dataFile, ItemHolderPet petPrefab)
        {
            dataFile.petPrefab = petPrefab;
            return dataFile;
        }

        public static StatusEffectIncreaseAttackWhileAlone WithActive(this StatusEffectIncreaseAttackWhileAlone dataFile, bool active)
        {
            dataFile.active = active;
            return dataFile;
        }

        public static StatusEffectIncreaseAttackWhileAlone WithCurrentBonus(this StatusEffectIncreaseAttackWhileAlone dataFile, int currentBonus)
        {
            dataFile.currentBonus = currentBonus;
            return dataFile;
        }
    }
    public static class TraitDataHelpers
    {
        public static TraitData WithKeyword(this TraitData dataFile, KeywordData data)
        {
            dataFile.keyword = data;
            return dataFile;
        }

        public static TraitData WithEffects(this TraitData dataFile, params StatusEffectData[] effects)
        {
            dataFile.effects = effects;
            return dataFile;
        }

        public static TraitData WithOverrides(this TraitData dataFile, params TraitData[] traits)
        {
            dataFile.overrides = traits;
            return dataFile;
        }

        public static TraitData WithIsReaction(this TraitData dataFile, bool isReaction)
        {
            dataFile.isReaction = isReaction;
            return dataFile;
        }
    }
    public static class UnlockDataHelpers
    {
        public static UnlockData WithUnlockDescription(this UnlockData dataFile, LocalizedString str)
        {
            dataFile.unlockDesc = str;
            return dataFile;
        }

        public static UnlockData WithUnlockTitle(this UnlockData dataFile, LocalizedString str)
        {
            dataFile.unlockTitle = str;
            return dataFile;
        }

        public static UnlockData WithUnlockDescription(this UnlockData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_unlockDesc", title);
            dataFile.unlockDesc = collection.GetString(dataFile.name + "_unlockDesc");
            return dataFile;
        }

        public static UnlockData WithUnlockTitle(this UnlockData dataFile, string title, SystemLanguage lang = SystemLanguage.English)
        {
            StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
            collection.SetString(dataFile.name + "_unlockTitle", title);
            dataFile.unlockTitle = collection.GetString(dataFile.name + "_unlockTitle");
            return dataFile;
        }

        public static UnlockData WithRequires(this UnlockData dataFile, params UnlockData[] requires)
        {
            dataFile.requires = requires;
            return dataFile;
        }

        public static UnlockData WithRequires(this UnlockData dataFile, params string[] requires)
        {
            dataFile.requires = ((IEnumerable<string>)requires).Select<string, UnlockData>(new Func<string, UnlockData>(new InternalMod(null).Get<UnlockData>)).ToArray<UnlockData>();
            return dataFile;
        }

        public static UnlockData WithLowPriority(this UnlockData dataFile, float priority)
        {
            dataFile.lowPriority = priority;
            return dataFile;
        }

        public static UnlockData WithBuilding(this UnlockData dataFile, BuildingType relatedBuilding)
        {
            dataFile.relatedBuilding = relatedBuilding;
            relatedBuilding.unlocks = relatedBuilding.unlocks.AddToArray<UnlockData>(dataFile);
            return dataFile;
        }

        public static UnlockData WithBuilding(this UnlockData dataFile, string relatedBuilding)
        {
            return dataFile.WithBuilding(new InternalMod(null).Get<BuildingType>(relatedBuilding));
        }

        public static UnlockData WithType(this UnlockData dataFile, UnlockData.Type type)
        {
            dataFile.type = type;
            return dataFile;
        }
    }
}