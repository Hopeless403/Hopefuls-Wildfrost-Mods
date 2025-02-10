using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WildfrostHopeMod.SFX;
using WildfrostHopeMod.Utils;
using UnityEngine.AddressableAssets;
using HarmonyLib;
using Modding = Deadpan.Enums.Engine.Components.Modding.Extensions;
using UnityEngine.ResourceManagement.AsyncOperations;
using FMOD;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;
using WildfrostHopeMod.VFX;
using Dead;
using UnityEngine.Events;
using UnityEngine.Localization;

namespace WildfrostHopeMod.EventTest
{
    /*[HarmonyPatch(typeof(AssetReferenceGameObject), nameof(AssetReferenceGameObject.InstantiateAsync), typeof(Transform))]
    public class PatchInstantiateRoutine
    {
        static bool Prefix(AssetReferenceGameObject __instance)
        {
            if (__instance.AssetGUID != "Hope.EventRoutineTest") return true;
            Debug.LogWarning("trying to instantiate this thing");
            return false;
        }
    }*/
    [HarmonyPatch(typeof(CampaignNodeTypeEvent), nameof(CampaignNodeTypeEvent.Run), typeof(CampaignNode))]
    internal class PatchIEnumerator
    {
        static public IEnumerator Result(CampaignNodeTypeEvent __instance, CampaignNode node)
        {
            var temp = AddressableLoader.Get<CampaignNodeTypeItem>("CampaignNodeType", "CampaignNodeItem").routinePrefabRef;
            yield return Transition.To("Event");
            AsyncOperationHandle<GameObject> task = temp.InstantiateAsync(EventManager.EventRoutineHolder);
            yield return new WaitUntil(() => task.IsDone);

            EventRoutine eventRoutine = task.Result.GetComponent<EventRoutine>();
            var node1 = eventRoutine.node;
            eventRoutine.Destroy();
            eventRoutine = task.Result.AddComponent<EventRoutineTest>();
            eventRoutine.node = node1;

            task.Result.AddComponent<AddressableReleaser>().Add((AsyncOperationHandle)task);
            Events.InvokeEventStart(node, eventRoutine);
            yield return __instance.Populate(node);
            Events.InvokeEventPopulated(eventRoutine);
            Transition.End();
            yield return eventRoutine.Run();
            yield return Transition.To("MapNew");
            Transition.End();
            yield return MapNew.CheckCompanionLimit();
        }
        static bool Prefix(CampaignNodeTypeEvent __instance, CampaignNode node, ref IEnumerator __result)
        {
            if (__instance is not CampaignNodeTypeItem) return true;
            __result = Result(__instance, node);
            return false;
        }
    }

    public class CampaignNodeTypeCustomEvent : CampaignNodeTypeEvent
    {
        public GameObject routinePrefab;
        public override IEnumerator Run(CampaignNode node)
        {
            yield return Transition.To("Event");
            EventRoutine eventRoutine = routinePrefab.GetComponent<EventRoutine>();
            Events.InvokeEventStart(node, eventRoutine);
            yield return Populate(node);
            Events.InvokeEventPopulated(eventRoutine);
            Transition.End();
            yield return eventRoutine.Run();
            yield return Transition.To("MapNew");
            Transition.End();
            yield return MapNew.CheckCompanionLimit();
        }
    }
    public class CampaignNodeTypeTest : CampaignNodeTypeCustomEvent
    {
        MapNode template = Resources.FindObjectsOfTypeAll<MapNode>().First();

        public CampaignNodeTypeTest()
        {
            template.label.tag = "TITLE";

            letter = "က";
            zoneName = "Title to display";
            mustClear = false;
            canSkip = true;
            canEnter = true;
            isBattle = false;
            isBoss = false;
            modifierReward = false;
            interactable = true;
            startRevealed = false;
            finalNode = false;
            mapNodePrefab = template;
            mapNodeSprite = EventMod.Mod.IconSprite;
            size = 1;
            canLink = true;

            /// specific to CampaignNodeTypeEvent (overridden with routinePrefab in CustomEvent)
            //routinePrefabRef = new AssetReferenceGameObject(Modding.PrefixGUID(mod:EventMod.Mod, name:letter));
            //routinePrefab = 

            // extra params specific to this CampaignNodeType
        }
        
        static void Register()
        {
            var instance = new CampaignNodeTypeTest();
            AddressableLoader.AddToGroup("CampaignNodeType", instance);
        }

        public override IEnumerator SetUp(CampaignNode node)
        {
            Debug.LogWarning("SETUP CNODE HERE");
            yield return null;
        }
        public override IEnumerator Populate(CampaignNode node)
        {
            Debug.LogWarning("POPULATE CNODE HERE");
            yield return null;
        }
    }
    public class EventRoutineTest : EventRoutine
    {
        internal static SFXLoader loader = new SFXLoader(EventMod.Paths.MusicDirectory);
        internal static GIFLoader gifloader = new GIFLoader(EventMod.Paths.ImagesPath, initialize: false);
        public static FMOD.Sound music;
        public static FMOD.Sound sfx;
        public static GameObject campfire;
        public bool promptEnd = false;

        /*public static void Initialise()
        {
            music = loader.LoadSound("Sound From Leaves.mp3", true);
            sfx = loader.LoadSound("campfire-crackling-fireplace-sound-119594.mp3", true);
            campfire = gifloader.LoadGIF("campfire", GIFLoader.PlayType.loopingAnimation);
        }*/
        public override IEnumerator Populate()
        {
            return base.Populate();
        }
        public static void CreateEvent<T>(ref UnityEvent<T> unityEvent, params Action<T>[] actions)
        {
            unityEvent = new();
            foreach (var action in actions)
                unityEvent.AddListener(arg => action.Invoke(arg));
        }
        public override IEnumerator Run()
        {
            var title = PettyRandom.Choose("Take a break", "Get enough rest", "Sharpen your mind", "Don't lose yourself", "You can do it!", "You are filled with warmth <3");
            CinemaBarSystem.Top.SetPrompt(title, "Select");

            GameObject back;
            if ((back = gameObject.transform.Find("Back Button")?.gameObject) != null)
            {
                back.SetActive(true);
                back.GetComponentInChildren<Button>().onClick.AddListener(new UnityEngine.Events.UnityAction(() => promptEnd = true));
            }
            GameObject chest;
            GameObject effect = null;
            if ((chest = gameObject.transform.FindRecursive("Chest")?.gameObject) != null)
            {
                Debug.LogError(campfire);
                //effect = GIFLoader.PlayEffect(campfire, chest.transform.position, new Vector2(2.8f, 1.7f), GIFLoader.PlayType.loopingAnimation);
                //effect.transform.SetParent(chest.transform.parent, true);
                chest.SetActive(false);
            }/*
            var players = new List<FMOD.Channel>()
            {
                SFXLoader.PlaySound(music, SFXLoader.PlayAs.Music),
                SFXLoader.PlaySound(sfx, SFXLoader.PlayAs.SFX)
            };*/

            Transform parent = EventManager.EventRoutineHolder;

            var go = new GameObject("CardGrid", typeof(RectTransform), typeof(CardContainerGrid), typeof(CardControllerSelectCard), typeof(UINavigationLayer));
            go.transform.SetParent(parent);
            go.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);

            var grid = go.GetComponent<CardContainerGrid>();
            grid.holder = grid.GetComponent<RectTransform>();
            grid.onAdd = new();
            grid.onAdd.AddListener(entity => entity.flipper.FlipUp());
            grid.onRemove = new();

            /// These values are the defaults. Uncomment to use custom values
            // grid.cellSize = new Vector2(2.25f, 3.375f);
            // grid.columnCount = 5; 

            /// Generic way to make scrollable. No click-and-drag yet
            var scroller = go.GetOrAdd<Scroller>();                 // Scroll with mouse
            
            if (grid.GetRowCount() > 2)
                go.GetOrAdd<ScrollToNavigation>().scroller = scroller;  // Scroll with controllers
            go.GetOrAdd<TouchScroller>().scroller = scroller;       // Scroll with touchscreen?
                                                                    // No click-and-drag yet. Needs some work
                                                                    // Change scroller.bounds here if it only scrolls partially

            var cc = go.GetComponent<CardControllerSelectCard>();
            cc.hoverEvent = new();
            cc.unHoverEvent = new();
            cc.pressEvent = new();
            cc.pressEvent.AddListener(e => promptEnd = true);

            Routine.Clump clump = new Routine.Clump();
            for (int cardIndex = 0; cardIndex < 10; ++cardIndex)
            {
                CardData cardData = AddressableLoader.GetGroup<CardData>("CardData").Where(c => c.mainSprite?.name != "Nothing").RandomItems(1)[0].Clone();
                Card card = CardManager.Get(cardData, go.GetComponent<CardController>(), References.Player, false, true);
                if (!grid.gameObject.activeInHierarchy)
                    card.entity.flipper.FlipDownInstant();
                grid.Add(card.entity);
                clump.Add(card.UpdateData(false));
            }
            yield return clump.WaitForEnd();
            foreach (Entity child in grid)
            {
                Transform transform = child.transform;
                transform.localPosition = grid.GetChildPosition(child);
                transform.localScale = grid.GetChildScale(child);
                transform.localEulerAngles = grid.GetChildRotation(child);
            }







            new LocalizedString().GetLocalizedString(1);






            yield return new WaitUntil(() => promptEnd);
            node?.SetCleared();
            DeckpackBlocker.Unblock();
            //players.ForEach(c => { c.stop(); c.clearHandle(); });
            CinemaBarSystem.Clear();
            effect?.Destroy();
            //var vfxer = FindObjectOfType<VfxStatusSystem>();
            //vfxer.CreateEffect(vfxer.profileLookup["heal"].applyEffectPrefab, chest.transform.position, Vector3.one);
/*
            List<CardData> heal = new();
            heal.AddRange(References.PlayerData.inventory.deck.Where(c => c.cardType.canReserve));
            heal.AddRange(References.PlayerData.inventory.reserve.Where(c => c.cardType.canReserve));*/
            //CompanionRecoverSequence.RemoveInjuries(heal);
            //yield return GameObject.FindObjectOfType<CompanionRecoverSequence>()?.Run();
        }
        public void Overheal()
        {

        }
    }
}
