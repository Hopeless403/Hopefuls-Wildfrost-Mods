using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod
{
    public class HopeQOL : WildfrostMod
    {
        public static HopeQOL Mod;
        public HopeQOL(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.qol";
        public override string[] Depends => new string[] { };
        public override string Title => "Hopeful QoLs";
        public override string Description => "A growing collection of QoL patches that (mostly) retain vanilla gameplay.\r\n\r\n\r\nSome of them are intended for ENGLISH only, but they shouldn't have major effects. There are currently 3 configurable items.\r\n\r\nConfig items:\r\n• The 'Esc' key goes back instead of pausing (when possible)\r\n• Mute the game when out of focus\r\n• Modify the enemy names based on its charms/upgrades\r\n\r\nOther patches:\r\n• Activates a quick restart button in the Pause menu\r\n• Removes crowns from reserved units\r\n• Removes crowns accidentally fed to Monchi\r\n• Sorts the inventory (with priority to renamed and upgraded cards)\r\n• Adds a back button to the Shop\r\n• Removes the character limit when renaming cards\r\n• [EN ONLY!] Renaming any Shademancer mask to \"XYZ Mask\" will cause its summon to be called \"XYZ\" etc.\r\n\r\n\r\nTell me what you think on the Discord server!\r\n- Hope(ful/less)";

        public static GameObject go;
        public static HopeModBehaviour behaviour;

        public override void Load()
        {

            base.Load();

            go = new GameObject("HopefulQOL");
            GameObject.DontDestroyOnLoad(go);
            go.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            behaviour = go.AddComponent<HopeModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            behaviour.OnDisable();
            GameObject.Destroy(go);
            go = null;
        }

        [ConfigItem(true, null, "Esc overrides PauseMenu")]
        public bool EscPauseMenu;
        [ConfigItem(true, null, "Mute game out of focus")]
        public bool MuteOOF;
        [ConfigItem(true, null, "Modify enemy names based on charms")]
        public bool Charmy;








        public class HopeModBehaviour : MonoBehaviour
        {
            internal void OnEnable()
            {
                Events.OnEventStart += ShopBackButton;
                Events.OnMuncherFeed += RemoveCrownOnMuncherFeed;
                /*Events.OnEntityDrag += HideBellWhileDrag;
                Events.OnEntityRelease += ShowBellOnRelease;*/
                Application.focusChanged += MuteOutOfFocus;
                Events.OnEntityDisplayUpdated += CharmyEnemies;
                Events.OnEntitySummoned += RenameSummons;
                /*Events.OnUpgradeAssign += UpgradeAssignSaveUpgrades;
                Events.OnUpgradePickup += UpgradePreview;*/
            }
            internal void OnDisable()
            {
                Events.OnEventStart -= ShopBackButton;
                Events.OnMuncherFeed -= RemoveCrownOnMuncherFeed;
                /*Events.OnEntityDrag -= HideBellWhileDrag;
                Events.OnEntityRelease -= ShowBellOnRelease;*/
                Application.focusChanged -= MuteOutOfFocus;
                Events.OnEntityDisplayUpdated -= CharmyEnemies;
                Events.OnEntitySummoned -= RenameSummons;
                /*Events.OnUpgradeAssign -= UpgradeAssignSaveUpgrades;
                Events.OnUpgradePickup -= UpgradePreview;*/
            }
            internal void Update()
            {
                /*foreach (var cooldown in cooldowns)
                {
                    if (cooldown.Value.current > 0.0)
                        cooldown.Value.current -= Time.deltaTime;
                }*/
                if (Input.GetKeyDown(KeyCode.Escape))
                    StartCoroutine(EscapePauseMenu());
            }

            static void UpgradeAssignSaveUpgrades(Entity entity, CardUpgradeData upgrade)
            {
                var data = entity.data;
                data.TryGetCustomData("hope.upgradeStates", out List<CardData> states, new List<CardData>());
                data.SetCustomData("hope.upgradeStates", states.Append(data).ToList());
            }
            static void UpgradePreview(UpgradeDisplay upgrade)
            {
                var navLayer = upgrade.navigationItem.navigationLayer;
                if (navLayer.name != "DeckDisplay")
                    return;
                var deck = FindObjectOfType<DeckDisplaySequence>();
                CardCharmDragHandler handler = deck.charmDragHandler;
                List<Entity> eligibleCards = new();
                var clump = new Routine.Clump();
                foreach (CardContainer assignmentContainer in handler.assignmentContainers)
                    foreach (Entity card in assignmentContainer)
                        if (upgrade.data.CanAssign(card))
                        {
                            eligibleCards.Add(card);
                            var data = card.data;
                            data.TryGetCustomData("hope.upgradeStates", out List<CardData> states, new List<CardData>());
                            data.SetCustomData("hope.upgradeStates", states.Append(data.Clone(false)).ToList());

                            clump.Add(upgrade.data.Assign(card));/*
                            upgrade.data.Assign(card.data);
                            card.GetComponent<Card>().promptUpdateDescription = true;

                            clump.Add(card.GetComponent<Card>().UpdateData());*/
                        }
                handler.StartCoroutine(clump.WaitForEnd());
                CoroutineManager.Start(UpgradePreviewReset(handler, eligibleCards));
            }
            static IEnumerator UpgradePreviewReset(CardCharmDragHandler handler, List<Entity> eligibleCards)
            {
                Debug.LogWarning("Waiting...");
                yield return new WaitUntil(() => !handler.dragHolder.list.Any());
                var clump = new Routine.Clump();
                foreach (var card in eligibleCards)
                {
                    if (card.data.TryGetCustomData("hope.upgradeStates", out List<CardData> states, new List<CardData>() { }))
                    {
                        card.data = states.First();
                        Debug.LogWarning("true" + states.First().upgrades.Count);
                        card.promptUpdate = true;
                        card.Update(); card.GetComponent<Card>().promptUpdateDescription = true;
                        //yield return card.GetComponent<Card>().UpdateData();
                        new CardUpgradeData().Assign(card);
                        yield return card.GetComponent<Card>().UpdateDisplay();
                        
                    }
                }
                yield return clump.WaitForEnd();
                Debug.LogWarning("done;");
            }

            static IEnumerator EscapePauseMenu()
            {
                if (!Mod.EscPauseMenu) yield break;
                /*Debug.LogError(cooldowns[nameof(EscapePauseMenu)].current);
                if (!CheckCooldown(nameof(EscapePauseMenu)))
                {
                    Debug.LogError(cooldowns[nameof(EscapePauseMenu)]);
                    yield break;
                }
                SetCooldown(nameof(EscapePauseMenu));*/
                var layer = UINavigationSystem.ActiveNavigationLayer;
                RectTransform back = null;
                if (!layer || layer.name == "Town") back = FindObjectsOfType<RectTransform>().LastOrDefault(i => i.name == "Back Button" || i.name == "Cancel Button");
                else back = layer.transform.root?.GetComponentsInChildren<RectTransform>().LastOrDefault(i => i.name == "Back Button" || i.name == "Cancel Button");
                if (back)
                {
                    PauseMenu.Block();
                    Debug.LogWarning("BLOCKED PAUSEMENU");
                    var button = back.GetComponentInChildren<Button>();
                    if (button.isActiveAndEnabled) button.onClick.Invoke();
                    yield return new WaitForSeconds(0.2f);
                    PauseMenu.Unblock();
                }
            }
            static void ShopBackButton(CampaignNode node, EventRoutine routine)
            {
                if (node.type.name != "CampaignNodeShop") return;
                var back = routine.GetComponentsInChildren<RectTransform>(true).LastOrDefault(i => i.name == "Back Button");
                var button = back.InstantiateKeepName();
                button.SetParent(routine.transform, true);
                button.position = back.position;
                button.gameObject.SetActive(true);
            }
            static void RemoveCrownOnMuncherFeed(Entity entity)
            {
                if (entity && DeckSelectSequence.EntityHasRemovableCrown(entity.data) && entity.data.cardType.canTakeCrown)
                {
                    References.PlayerData.inventory.upgrades.Add(entity.data.GetCrown());
                    var talker = FindObjectOfType<EventRoutineMuncher>().talker;
                    new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine(entity));
                    SpeechBubbleSystem.Create(new SpeechBubbleData(talker.talkFrom, talker.GetName(), "You should be more careful with that <crown> next time!"));
                }
            }
            /*static void HideBellWhileDrag(Entity entity) {}// FindObjectOfType<RedrawBellSystem>().Hide();
            static void ShowBellOnRelease(Entity entity)
            {
                var b = FindObjectOfType<RedrawBellSystem>();
                b.bell.SetActive(true);
                b.interactable = true;
                b.bellActive.SetActive(true);
            }*/
            static void MuteOutOfFocus(bool focused)
            {
                var master = FindObjectOfType<AudioSettingsSystem>()?.busLookup["Master"];
                if (!Mod.MuteOOF || master == null) return;
                if (focused) master.Init();
                else
                {
                    master.volume = 0;
                    master.UpdateVolume();
                }
            }
            static void CharmyEnemies(Entity entity)
            {
                if (!Mod.Charmy || References.Battle == null || entity.owner != References.Battle.enemy || entity.data.upgrades.Count == 0) return;
                var charmNames = string.Join(" ",
                    entity.data.upgrades.ToArray().Reverse()
                    .Select(charm => Adjectivise(charm.titleKey.GetLocalizedString().Replace(" Charm", "")))
                    );
                var name = entity.display.name;
                bool theFlag = name.Split(' ').FirstOrDefault() == "The";
                (entity.display as Card).SetName((theFlag ? "The " : "") + $"{charmNames} {entity.data.title.Remove(0, theFlag ? 4 : 0)}");
            }
            static void RenameSummons(Entity entity, Entity summonedBy)
            {
                if (!entity || !summonedBy || summonedBy.data.forceTitle.ToLower().Split(' ').LastOrDefault() != "mask") return;
                var name = summonedBy.data.forceTitle;
                (entity.display as Card).SetName(name.Remove(name.Length - 4).Trim());
            }



            [HarmonyPatch(typeof(CardControllerDeck), nameof(CardControllerDeck.MoveToReserve))] class PatchRemoveCrownOnReserve
            {
                static void Prefix(CardControllerDeck __instance, Entity entity) 
                {
                    if (__instance.selectSequence.takeCrownButton.activeSelf)
                        __instance.selectSequence.TakeCrown();
                }
            }
            [HarmonyPatch(typeof(DeckDisplaySequence), nameof(DeckDisplaySequence.Run))] class PatchTryToSort
            {
                static void Prefix(DeckDisplaySequence __instance)
                {
                    Debug.LogWarning("FIXING LAYOUT");
                    var deck = __instance.owner.data.inventory.deck;
                    deck.Sort((x, y) => DefaultOrder(x).CompareTo(DefaultOrder(y)));
                }
                static (bool, int, object, object, object) DefaultOrder(CardData data)
                {
                    return (!data.cardType.miniboss, -data.cardType.sortPriority, data.name, data.forceTitle, data.upgrades.Count);
                }
            }
            [HarmonyPatch(typeof(Journal), nameof(Journal.PagedOpened))] class PatchQuickRestartButton
            {
                static void Postfix(Journal __instance, JournalPage page)
                {
                    switch (page.name)
                    {
                        case "PauseMenu":
                            var menu = __instance.GetComponentInParent<PauseMenu>(); //PauseMenu not in Transform children, but there is a PauseMenu JournalPageMenu
                            if (menu)
                            {
                                var original = menu.quickRestartButton.transform.parent;
                                original.gameObject.SetActive(true);
                            }
                            break;
                        default: return;
                    }
                }
            }
            [HarmonyPatch(typeof(RenameCompanionSequence), nameof(RenameCompanionSequence.Run))]
            class PatchUnlimitedRename
            {
                static void Postfix(RenameCompanionSequence __instance)
                {
                    if (__instance.inputField) __instance.inputField.characterLimit = 0;
                }
            }




            public static string Adjectivise(string t)
            {

                Dictionary<string, string> nounToAdjective = new()
                {
                    { "Balance", "Balanced" },
                    { "Bom", "Bommy" },
                    { "Bombskull", "Bomber" },
                    { "Boonfire", "Boon" },
                    { "Broken", "Broken" },
                    { "Cloudberry", "Cloudy" },
                    { "Chuckle", "Chuckling" },
                    { "Critical", "Critical" },
                    { "Demon Eye", "Demonic" },
                    { "Durian", "Smelly" },
                    { "Flameblade", "Burner" },
                    { "Frosthand", "Frosty"},
                    { "Lazy", "Lazy" },
                    { "Hog", "Hoggy" },
                    { "Strawberry", "Celestial" },
                    { "Recycle", "Recycler" },
                    { "Frenzy", "Frenzied" },
                    { "Frog", "Froggy" },
                    { "Frozen Sun", "Frozen" },
                    { "Squid", "Squiddy" },
                    { "Weakness", "Weak" },
                    { "Squidskull", "Skully" },
                    { "Scrap", "Scrappy" },
                    { "Peppernut", "Nutty" },
                    { "Pengu", "Pengy" },
                    { "Lumin Ring", "Lumin'd" },
                    {  "Molten Egg", "Molten" },
                    { "Moko", "Moko-y" },
                    { "Ooba", "Oobie" },
                    { "Punchfist", "Punchy" },
                    { "Pomegranate", "Pommy" },
                    { "Sun", "Sunny" },
                    { "Raspberry", "Raspberry" },
                    { "Shield", "Shielder" },
                    { "Snowball", "Snowy" },
                    { "Spice", "Spicy" },
                };
                if (t.Split(' ').Last() == "Crown") return t + "ed";
                if (!nounToAdjective.ContainsKey(t)) return t + 'y';
                return nounToAdjective[t];
            }
/*
            public static readonly Dictionary<string, Cooldown> cooldowns = new()
            {
                { nameof(EscapePauseMenu), new Cooldown(EscapePauseMenu(), 0.5f) }
            };
            public class Cooldown
            {
                public IEnumerator ie;
                public float current;
                public readonly float max;

                public Cooldown(IEnumerator ie, float value)
                {
                    this.ie = ie;
                    this.current = 0;
                    this.max = value;
                }

                public void Max() => current = max;
            }
            public static void SetCooldown(string ie)
            {
                if (!cooldowns.ContainsKey(ie)) return;
                cooldowns[ie].Max();
            }
            public static bool CheckCooldown(string ie) => !cooldowns.ContainsKey(ie) || cooldowns[ie].current <= 0.0;
*/
        }



    }
}