using System;
using System.Collections.Generic;
using System.Linq;
using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using UnityEngine.XR;

namespace Willfrost
{
    public class WillFrost : WildfrostMod
    {

        public override string GUID => "Potato.wildfrost.WillFrost";
        public override string[] Depends => new string[] { };
        public override string Title => "Willfrost";
        public override string Description => "Will is the programmer of Wildfrost. \nI somehow got permission from Will to make to this mod.\n(currently works for all companions other than Lil berry and Yuki)";


        public WillFrost(string modDirectory)
            : base(modDirectory)
        {
        }
        public static Sprite Will { get; private set; }
        public readonly static string Willholder = nameof(Willholder);

        public List<(string, Sprite)> sprites = new List<(string, Sprite)>();
        public ILookup<String, CardData> cards = null;

        public void Replace(params (string name1, string name2)[] data)
        {
            foreach (var card in cards)
            {
                foreach (var item in data)
                {
                    string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string Image = Path.Combine(location, "Images\\" + item.name2);
                    if (card.Key == item.name1)
                    {
                        sprites.Add((card.First().name, card.First().mainSprite));
                        card.First().mainSprite = this.ImagePath(Image).ToSprite();
                    }
                }

            }
        }
        public void Fix()
        {
            foreach (var to_fix in sprites)
            {
                this.Get<CardData>(to_fix.Item1).mainSprite = to_fix.Item2;
            }
        }

        public override void Load()
        {
            base.Load();
            cards = AddressableLoader.GetGroup<CardData>("CardData").Where(c => c.name != "NakedGnome").ToLookup(c => c.title);
            
            Will ??= GetImageSprite("Will.png");
            global::Events.OnEntityCreated += EntityCreated;
            global::Events.OnEntityDataUpdated += EntityDataUpdated;
            global::Events.OnCardPooled += CardPooled;

            /*Replace(
                ("Snoof", "WillSnoof.PNG"),
                ("Booshu", "WillBooshu.PNG"),
                ("Loki", "WillLoki.PNG"),
                ("Sneezle", "WillSneezle.PNG"),
                ("Spike", "WillSpike.PNG"),
                ("Binku", "WillBinku.PNG"),
                ("Lil' Gazi", "WillGazi.PNG"),
                ("Alloy", "WillAlloy.PNG"),
                ("Berry Sis", "WillBerrySis.PNG"),
                ("Big Berry", "WillBigBerry.PNG"),
                ("Biji", "WillBiji.PNG"),
                ("Blunky", "WillBlunky.PNG"),
                ("Bombom", "WillBombom.PNG"),
                ("Bonnie", "WillBonnie.PNG"),
                ("Chikichi", "WillChicken1.PNG"),
                ("Chikani", "WillChicken2.PNG"),
                ("Chikasan", "WillChicken3.PNG"),
                ("Chikashi", "WillChicken4.PNG"),
                ("Chikagoru", "WillChicken5.PNG"),
                ("Chompom", "WillChompom.PNG"),
                ("Devicro", "WillDevicro.PNG"),
                ("Dimona", "WillDimona.PNG"),
                ("Dregg", "WillDregg.PNG"),
                ("Fungun", "WillFungun.PNG"),
                ("Toaster", "WillToaster.PNG"),
                ("Firefist", "WillFirefist.PNG"),
                ("Fizzle", "WillFizzle.PNG"),
                ("Folby", "WillFolby.PNG"),
                ("Foxee", "WillFoxee.PNG"),
                ("Fulbert", "WillFulbert.PNG"),
                ("Gojiber", "WillGojiber.PNG"),
                ("Groff", "WillGroff.PNG"),
                ("Hazeblazer", "WillHazeblazer.PNG"),
                ("Jumbo", "WillJumbo.PNG"),
                ("Kernel", "WillKernel.PNG"),
                ("Knuckles", "WillKnuckles.PNG"),
                ("Kreggo", "WillKreggo.PNG"),
                ("Lupa", "WillLupa.PNG"),
                ("Mama Tinkerson", "WillMamaTinkerson.PNG"),
                ("Vesta", "WillVesta.PNG"),
                ("Mini Mika", "WillMiniMika.PNG"),
                ("Monch", "WillMonch.PNG"),
                ("Needle", "WillNeedle.PNG"),
                ("Nom & Stompy", "WillNomAndStompy.PNG"),
                ("Nova", "WillNova.PNG"),
                ("Pimento", "WillPimento.PNG"),
                ("Pootie", "WillPootie.PNG"),
                ("Pyra", "WillPyra.PNG"),
                ("Roibos", "WillRoibos.PNG"),
                ("Scaven", "WillScaven.PNG"),
                ("Shelly", "WillShelly.PNG"),
                ("Shen", "WillShen.PNG"),
                ("Snobble", "WillSnobble.PNG"),
                ("Snoffel", "WillSnoffel.PNG"),
                ("Splinter", "WillSplinter.PNG"),
                ("Spoof", "WillSpoof.PNG"),
                ("Taiga", "WillTaiga.PNG"),
                ("The Baker", "WillTheBaker.PNG"),
                ("Tinkerson Jr.", "WillTinkersonJr.PNG"),
                ("Tiny Tyko", "WillTinyTyko.PNG"),
                ("Tusk", "WillTusk.PNG"),
                ("Van Jun", "WillVanJun.PNG"),
                ("Wallop", "WillWallop.PNG"),
                ("Wort", "WillWort.PNG"),
                ("Yuki", "WillYuki.PNG"),
                ("Zula", "WillZula.PNG"),
                ("Lil' Berry", "WillLilBerry.PNG"),
                ("Naked Gnome", "WillNakedGnome.PNG")
                );*/


        }

        public override void Unload()
        {
            global::Events.OnEntityCreated -= EntityCreated;
            global::Events.OnEntityDataUpdated -= EntityDataUpdated;
            global::Events.OnCardPooled -= CardPooled;
            base.Unload();

            Fix();
        }

        private static readonly List<Entity> toProcess = new List<Entity>();
        private static readonly Dictionary<Card, List<UnityEngine.Object>> toFix = new Dictionary<Card, List<UnityEngine.Object>>();

        private static void EntityCreated(Entity entity)
        {
            toProcess.Add(entity);
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
            bool isLeader = card.scriptableImage is Leader;

            if (entity.name != "LilBerry" && entity.name != "Yuki" && !isLeader)
                return;

            Transform parent;
            Leader leader = card.scriptableImage as Leader;
            if (isLeader)
            {
                Transform body = leader.avatar.root.GetAnchor("body");
                Transform head = body?.GetComponentsInChildren<AvatarPart>()?.First(a => a?.GetAnchor("head")).GetAnchor("head");
                //Transform head = body?.GetComponentsInChildren<AvatarPart>()?.First(a => a?.GetAnchor("head")).GetAnchor("head");
                parent = head;
            }
            else parent = card.scriptableImage.transform;

            if (parent?.Find(Willholder)) return;

            toFix.Add(card, []);

            var willObj = new GameObject(Willholder, typeof(RectTransform), typeof(Image));
            willObj.transform.SetParent(parent);
            
            willObj.GetComponent<RectTransform>().sizeDelta = isLeader ? new Vector2(3, 3) : new Vector2(1.5f, 1.5f);
            if (isLeader)
            {
                float y = 1.3f;
                var eyepos = leader.GetComponentInChildren<AvatarEyePositions>();
                if (eyepos)
                {
                    y = eyepos?.eyes?.FirstOrDefault()?.pos.y ?? 1.3f;
                    y += eyepos.transform.parent.localPosition.y;
                }
                
                willObj.transform.localPosition = new Vector2(0.2f, y);
            }
                
            else
                willObj.transform.localPosition = entity.name == "LilBerry" ? new Vector2(-0.5f, 0.9f) : new Vector2(0.1f, 1f);

            // inserting new GameObjects to cards can mess things up if the card starts flipped or not
            willObj.transform.rotation = Quaternion.Euler(
                0, 
                entity.flipper.flipped  ? 180 : 0, 
                isLeader                ? 0   : 15);
            willObj.transform.SetScaleX(!entity.owner || entity.owner.team == 1 ? 1 : -1);
            willObj.transform.SetScaleY(1);
            if (entity.name == "Yuki") willObj.transform.localScale *= 0.8f;

            willObj.GetComponent<Image>().preserveAspect = true;
            willObj.GetComponent<Image>().raycastTarget = false;
            willObj.GetComponent<Image>().sprite = Will;
            toFix[card].Add(willObj);
        }

        private static void CardPooled(Card card)
        {
            if (!toFix.ContainsKey(card))
                return;
            foreach (UnityEngine.Object @object in toFix[card])
            {
                if (@object is GameObject novaObj)
                    UnityEngine.Object.Destroy(novaObj);
            }
            toFix.Remove(card);
        }
    }
}