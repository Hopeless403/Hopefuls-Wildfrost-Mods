using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using HarmonyLib;
using System.Reflection;

namespace ExtendedUI
{
    public static partial class UIFactory
    {
        public static CardContainerGrid CreateCardGrid(Transform parent, RectTransform bounds = null)
        {
            return CreateCardGrid(parent, new Vector2(2.25f, 3.375f), 5, bounds);
        }

        public static CardContainerGrid CreateCardGrid(Transform parent, Vector2 cellSize, int columnCount, RectTransform bounds = null)
        {
            GameObject gridObj = new GameObject("CardGrid", typeof(RectTransform), typeof(CardContainerGrid));
            gridObj.transform.SetParent(parent);
            gridObj.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);

            var grid = gridObj.GetComponent<CardContainerGrid>();
            grid.holder = grid.GetComponent<RectTransform>(); // Do its thing when chest active
            grid.onAdd = new(); // Fix null reference
            grid.onAdd.AddListener(entity => entity.flipper.FlipUp()); // Flip up card when it's time (without waiting for others)
            grid.onRemove = new(); // Fix null reference

            grid.cellSize = cellSize;
            grid.columnCount = columnCount;

            gridObj.AddScrollers(); // No click-and-drag. That needs Scroll View
                                    // Change scroller.bounds here if it only scrolls partially

            return grid;
        }
        public static CardLane CreateCardLane(Transform parent, int direction = -1)
        {
            GameObject laneObj = new GameObject("CardLane", typeof(RectTransform), typeof(CardLane));
            laneObj.transform.SetParent(parent);
            laneObj.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);

            var lane = laneObj.GetComponent<CardLane>();
            lane.holder = lane.GetComponent<RectTransform>(); // Do its thing when chest active
            //lane.holder.sizeDelta = new Vector2(-8, 4); // WIPWIPWIP

            lane.onAdd = new(); // Fix null reference
            lane.onAdd.AddListener(entity => entity.flipper.FlipUp()); // Flip up card when it's time (without waiting for others)
            lane.onRemove = new(); // Fix null reference

            lane.SetDirection(direction);

            laneObj.AddScrollers(); // No click-and-drag. That needs Scroll View
                                    // Change scroller.bounds here if it only scrolls partially

            return lane;
        }

        /// <summary>
        /// Generic way to make scrollable. Click-and-drag uses ScrollView
        /// </summary>
        /// <param name="parentObject"></param>
        public static void AddScrollers(this GameObject parentObject)
        {
            Scroller scroller = parentObject.GetOrAdd<Scroller>();            // Scroll with mouse
            parentObject.GetOrAdd<ScrollToNavigation>().scroller = scroller;  // Scroll with controllers
            parentObject.GetOrAdd<TouchScroller>().scroller = scroller;       // Scroll with touchscreen
                                                                              // Change scroller.bounds here if it only scrolls partially
        }
        /*/// <summary>
        /// Generic way to make scrollable. Click-and-drag uses ScrollView
        /// </summary>
        /// <param name="parentObject"></param>
        public static void AddScrollers(this GameObject parentObject, float scrollToPercent, float scrollDelay, bool snapToPosition)
        {
            parentObject.AddScrollers();
            Scroller scroller = parentObject.GetOrAdd<Scroller>();

            parentObject.SetActive(false);
            ScrollerScrollTo scrollTo = parentObject.GetOrAdd<ScrollerScrollTo>();
            scrollTo.scroller = scroller;
            scrollTo.scrollTo = scrollToPercent;
            scrollTo.instant = snapToPosition;
            parentObject.SetActive(true);
        }*/
        /// <summary>
        /// Generic way to make scrollable. Click-and-drag uses ScrollView
        /// </summary>
        public static void AddScrollers(this RectTransform parent)
            => AddScrollers(parent.gameObject);

        [HarmonyPatch(typeof(ScrollerScrollTo), nameof(ScrollerScrollTo.OnEnable))]
        [HarmonyPatch(typeof(ScrollerScrollTo), nameof(ScrollerScrollTo.Awake))]
        public class scrollpatch
        {
            static bool Prefix(ScrollerScrollTo __instance, MethodBase __originalMethod)
            {
                bool flag = __originalMethod.Name switch
                {
                    "Awake" => __instance.onAwake,
                    "OnEnable" => __instance.onEnable,
                };

                Debug.LogWarning("STARTING " + __originalMethod.Name + ": " + flag);
                return flag;
            }
        }
    }
}

namespace ExtendedUI.Helpers
{
    public static class CardContainerHelpers
    {
        public static IEnumerator Populate(this CardContainer cardContainer, params string[] cardNames)
        {
            yield return Populate(cardContainer, cardNames.Select(AddressableLoader.GetCardDataClone).ToArray());
        }
        public static IEnumerator Populate(this CardContainer cardContainer, params CardData[] cardDatas)
        {
            yield return Populate(cardContainer, cardDatas.Select(cardData => CardManager.Get(cardData, null, null, false, true).entity).ToArray());
        }
        public static IEnumerator Populate(this CardContainer cardContainer, params Entity[] entities)
        {
            Routine.Clump clump = new Routine.Clump();
            for (int cardIndex = 0; cardIndex < entities.Length; ++cardIndex)
            {
                Entity entity = entities[cardIndex];
                if (!cardContainer.gameObject.activeInHierarchy)
                    entity.flipper.FlipDownInstant();
                cardContainer.Add(entity);
                clump.Add((entity.display as Card).UpdateData(false));
            }
            yield return (object)clump.WaitForEnd();
            cardContainer.SetSize(4, 0.67f);
            for (int index = 0; index < cardContainer.Count; ++index)
            {
                Entity entity = cardContainer[index];
                Transform entityTransform = entity.transform;
                entityTransform.localPosition = cardContainer.GetChildPosition(entity);
                entityTransform.localScale = cardContainer.GetChildScale(entity);
                entityTransform.localEulerAngles = cardContainer.GetChildRotation(entity);

                /*// to add cards behind the entity like Gnome Traveller
                Entity curse = curses[index];
                if ((bool)(UnityEngine.Object)curse)
                {
                    Transform curseTransform = curse.transform;
                    curseTransform.position = entityTransform.position;
                    curseTransform.localScale = Vector3.one * 0.85f;
                    curseTransform.localEulerAngles = new Vector3(0.0f, 0.0f, -UnityEngine.Random.Range(5f, 10f));
                }*/
            }
            cardContainer.SetChildPositions();
        }

        public static CardContainer WithOnAddAction(this CardContainer cardContainer, UnityAction<Entity> onAdd)
        {
            cardContainer.onAdd ??= new UnityEventEntity();
            cardContainer.onAdd.AddListener(onAdd);
            return cardContainer;
        }
        public static CardContainer WithOnRemoveAction(this CardContainer cardContainer, UnityAction<Entity> onRemove)
        {
            cardContainer.onRemove ??= new UnityEventEntity();
            cardContainer.onRemove.AddListener(onRemove);
            return cardContainer;
        }
    }
}