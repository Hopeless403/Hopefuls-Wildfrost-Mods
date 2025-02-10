using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace WildfrostHopeMod.Novafrost
{
    public class NovafrostMod(string modDirectory) : WildfrostMod(modDirectory)
    {
        public override string GUID => "hope.wildfrost.novafrost";
        public override string[] Depends => new string[] { };
        public override string Title => "Novafrost";
        public override string Description => "Nova decides to hold everyone. Comfy\n\nCredit to @Moondial on Discord for the icon and inspiration!";
        public static Sprite Nova { get; private set; }
        public readonly static string Novaholder = "Novaholder";
        public readonly static float scale = 0.5f;
        public readonly static Vector3 position = new Vector3(0.9f, 0.7f, 0);
        public override void Load()
        {
            base.Load();
            Nova ??= GetImageSprite("Blue.png");
            global::Events.OnEntityCreated += EntityCreated;
            global::Events.OnEntityDataUpdated += EntityDataUpdated;
            global::Events.OnCardPooled += CardPooled;
        }
        private static readonly List<Entity> toProcess = new List<Entity>();
        private static readonly Dictionary<Card, List<UnityEngine.Object>> toFix = [];

        private static void EntityCreated(Entity entity)
        {
            Create(entity);
        }

        private static void EntityDataUpdated(Entity entity)
        {
            if (!toProcess.Contains(entity))
                return;
            toProcess.Remove(entity);
            Create(entity);
        }

        public static void Create(Entity entity)
        {
            Card card = entity.display as Card;
            Transform parent = card?.mainImage?.transform.parent;

            if (!parent || parent.parent.GetAllChildren().Any(t => t.name == Novaholder))
                return;

            toFix.Add(card, []);

            var novaObj = new GameObject(Novaholder, typeof(RectTransform), typeof(Image));
            novaObj.transform.SetParent(parent.parent);
            novaObj.transform.SetSiblingIndex(parent.GetSiblingIndex());
            novaObj.transform.localPosition = Vector3.zero;
            novaObj.GetComponent<RectTransform>().sizeDelta = new Vector2(3.8f, 5.7f);
            

            // The image will try to autofill to fit the RectTransform size
            novaObj.GetComponent<Image>().preserveAspect = true;
            // This fixes the card being hoverable
            novaObj.GetComponent<Image>().raycastTarget = false;
            novaObj.GetComponent<Image>().sprite = Nova;
            toFix[card].Add(novaObj);

            parent.localScale *= scale;
            parent.localPosition += position;
            toFix[card].Add(parent);

            if (parent.TryGetComponent(out CardIdleAnimation anim))
            {
                anim.baseScale *= scale;
                anim.basePosition += position;
                toFix[card].Add(anim);
            }
        }

        private static void CardPooled(Card card)
        {
            if (!toFix.ContainsKey(card))
                return;
            foreach (UnityEngine.Object @object in toFix[card])
            {
                if (@object is GameObject novaObj)
                    UnityEngine.Object.Destroy(novaObj);
                else if (@object is Transform parent)
                {
                    parent.localScale /= scale;
                    parent.localPosition -= position;
                }
                else if (@object is CardIdleAnimation anim)
                {
                    anim.baseScale /= scale;
                    anim.basePosition -= position;
                }
            }
            toFix.Remove(card);
        }
        public override void Unload()
        {
            global::Events.OnEntityCreated -= EntityCreated;
            global::Events.OnEntityDataUpdated -= EntityDataUpdated;
            global::Events.OnCardPooled -= CardPooled;
            base.Unload();
        }
    }
}