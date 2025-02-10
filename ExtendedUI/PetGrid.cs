using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using HarmonyLib;
using Newtonsoft.Json.Utilities;

namespace ExtendedUI
{
    [HarmonyPatch]
    public class PetGrid
    {
        static GameObject go;

        public static void OnSceneChanged(Scene scene)
        {
            if (scene.name != "CharacterSelect") return;
            SelectStartingPet petRoutine = GameObject.FindObjectOfType<SelectStartingPet>();

            if (!petRoutine || !petRoutine.group) return;

            var length = MetaprogressionSystem.GetUnlockedPets().Length;
            Debug.LogWarning("IS IT GRIDDY? " + length);
            if (length <= 10)
            {
                Debug.LogWarning("NO");
                return;
            }
            Debug.LogWarning("YES");
            ReplaceContainerWithGrid(ref petRoutine.group);
        }
        [HarmonyPatch(typeof(SelectStartingPet), nameof(SelectStartingPet.Routine))]
        public static IEnumerator Postfix(IEnumerator __result, SelectStartingPet __instance, Entity leader)
        {
            if (go)
            {
                go?.SetActive(true);
                __instance.group.entities.Reverse();
                //Entity e = null;
                //__instance.group.entities.Sort((e,f) => e.data.title.CompareTo(f.data.title));
                (__instance.leader ?? leader).display.hover.SetHoverable(false);
            }

            yield return __result;
        }
        [HarmonyPatch(typeof(SelectStartingPet), nameof(SelectStartingPet.Cancel))]
        public static void Postfix(SelectStartingPet __instance)
        {
            if (go)
            {
                go?.SetActive(false);
                __instance.group.entities.Reverse();
            }

            __instance.leader?.display.hover.SetHoverable(true);
        }
        private CardContainer GetCardContainer()
        {
            var _objectGroup = new GameObject("SelectCardRoutine");
            _objectGroup.SetActive(false);
            _objectGroup.transform.SetParent(GameObject.Find("Canvas/Padding/HUD/DeckpackLayout").transform.parent.GetChild(0));
            _objectGroup.transform.SetAsFirstSibling();

            var _gameObject = new GameObject("SelectCard");
            // _gameObject.transform.Translate(new Vector3(0, 1f, 0));
            var rect = _gameObject.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(7, 2);

            /*var cardController = _gameObject.AddComponent<CardControllerSelectCard>();
            cardController.owner = References.Player;
            cardController.unHoverEvent = new UnityEventEntity();
            cardController.hoverEvent = new UnityEventEntity();
            cardController.pressEvent = new UnityEventEntity();
            cardController.pressEvent.AddListener(ChooseCard);*/

            var cardContainer = UIFactory.CreateCardGrid(_objectGroup.transform, rect);

            foreach (var cardData in AddressableLoader.GetGroup<CardData>("CardData").RandomItems(4))
            {
                Debug.Log(cardData.name);
                var card = CardManager.Get(cardData, cardController, References.Player, inPlay: false,
                    isPlayerCard: true);
                Debug.Log($"[{card.name}] [{card.entity.name}]");
                cardContainer.Add(card.entity);
            }
            cardContainer.AssignController(cardController);
            // var container = _gameObject.AddComponent<CardHand>();
            // container.fanCircleAngleAddCurve = new AnimationCurve();
            // container.staticAngleAdd = true;
            // container.holder = obj.GetComponent<RectTransform>();
            // container.onAdd = new UnityEventEntity();
            // container.onRemove = new UnityEventEntity();
            // container.AssignController(cardController);
            // container.SetSize(5, 0.889f);
            // CardSelector cs = obj.AddComponent<CardSelector>();
            // cs.character = References.Player;
            // cs.selectEvent = new UnityEventEntity();

            return cardContainer;
        }
        static void ReplaceContainerWithGrid(ref CardContainer containerToReplace)
        {
            Transform parent = containerToReplace.transform.parent;
            containerToReplace.gameObject.Destroy();

            var scrollBounds = new GameObject("ScrollBounds", typeof(RectTransform));
            scrollBounds.transform.SetParent(parent);
            scrollBounds.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
            (scrollBounds.transform as RectTransform).SetSize(parent.transform as RectTransform);

            go = new GameObject("CardGrid", typeof(RectTransform), typeof(CardContainerGrid));
            go.SetActive(false);
            go.transform.SetParent(scrollBounds.transform);
            go.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
            //((RectTransform)go.transform).SetSize(13.25f, 0);

            var grid = go.GetComponent<CardContainerGrid>();
            grid.holder = grid.GetComponent<RectTransform>(); // Do its thing when chest active
            grid.onAdd = new(); // Fix null reference
            grid.onAdd.AddListener(entity => entity.flipper.FlipUp()); // Flip up card when it's time (without waiting for others)
            grid.onRemove = new(); // Fix null reference

            /// These values are the defaults. Uncomment to use custom values
            // grid.cellSize = new Vector2(2.25f, 3.375f);
            // grid.columnCount = 5; 

            /// Generic way to make scrollable. No click-and-drag yet
            var scroller = go.GetOrAdd<Scroller>();                 // Scroll with mouse
            go.GetOrAdd<ScrollToNavigation>().scroller = scroller;  // Scroll with controllers
            go.GetOrAdd<TouchScroller>().scroller = scroller;       // Scroll with touchscreen?
                                                                    // No click-and-drag yet. Needs some work
                                                                    // Change scroller.bounds here if it only scrolls partially

            scroller.bounds = scrollBounds.transform as RectTransform;
            containerToReplace = grid;
        }
    }

    static class Extensions
    {
        public static Vector2 GetSize(this RectTransform source) => source.rect.size;
        public static float GetWidth(this RectTransform source) => source.rect.size.x;
        public static float GetHeight(this RectTransform source) => source.rect.size.y;

        /// <summary>
        /// Sets the sources RT size to the same as the toCopy's RT size.
        /// </summary>
        public static void SetSize(this RectTransform source, RectTransform toCopy)
        {
            source.SetSize(toCopy.GetSize());
        }

        /// <summary>
        /// Sets the sources RT size to the same as the newSize.
        /// </summary>
        public static void SetSize(this RectTransform source, Vector2 newSize)
        {
            source.SetSize(newSize.x, newSize.y);
        }

        /// <summary>
        /// Sets the sources RT size to the new width and height.
        /// </summary>
        public static void SetSize(this RectTransform source, float width, float height)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }

        public static void SetWidth(this RectTransform source, float width)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        }

        public static void SetHeight(this RectTransform source, float height)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
    }
}
