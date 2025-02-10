using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Rendering;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using WildfrostHopeMod.Utils;
using WildfrostHopeMod.VFX;
using static Building;
using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;

namespace StatusIcons
{
    public class StatusIconsMod : WildfrostMod
    {
        public static StatusIconsMod instance;
        public static GameObject iconTemplate;
        public StatusIconsMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
            iconTemplate = Addressables.LoadAssetAsync<GameObject>("Card Icons/SnowIcon.prefab").WaitForCompletion().InstantiateKeepName();
            GameObject.DontDestroyOnLoad(iconTemplate);
        }
        public override string GUID => "hope.wildfrost.tutorial";
        public override string[] Depends => new string[] { };
        public override string Title => "Tutorial: Creating Status Icons";
        public override string Description => "Learn how to make a new status effect with a custom icon!";

        // usual stuff here
        private bool preLoaded = false; 
        public static List<object> assets = new List<object>();
        private CardData.StatusEffectStacks SStack(string name, int amount) => new CardData.StatusEffectStacks(Get<StatusEffectData>(name), amount);

        //this is here to allow our icon to appear in the text box of cards
        public override TMP_SpriteAsset SpriteAsset => spriteAsset;
        internal static TMP_SpriteAsset spriteAsset;

        public override void Load()
        {
            if (!preLoaded)
            {
                AllBuiledrs.Add(typeof(_StatusIconBuilder));
                AllDataTypes.Add(typeof(StatusIconData));

                preLoaded = true;
            }

            static Sprite GetCardSprite(CardData cardData, string name)
            {
                if (!instance.preLoaded) return null;
                Card card = CardManager.Get(cardData, null, null, false, false);
                card.gameObject.SetLayerRecursively(7);
                static void WaitCoroutine(IEnumerator func)
                {
                    while (func != null && func.MoveNext())
                    {
                        if (func.Current != null)
                        {
                            IEnumerator num;
                            try
                            {
                                num = (IEnumerator)func.Current;
                            }
                            catch (InvalidCastException)
                            {
                                if (func.Current.GetType() == typeof(WaitForSeconds))
                                    Debug.LogWarning("Skipped call to WaitForSeconds. Use WaitForSecondsRealtime instead.");
                                return;  // Skip WaitForSeconds, WaitForEndOfFrame and WaitForFixedUpdate
                            }
                            WaitCoroutine(num);
                        }
                    }
                }
                WaitCoroutine(card.UpdateData(false));
                card.transform.position = Vector3.zero;
                GameObject newCameraObject = new GameObject("NewCamera");
                ExportCards exportCards = new();
                exportCards._camera = newCameraObject.GetOrAdd<Camera>();
                exportCards._camera.CopyFrom(Camera.main);
                exportCards._camera.cullingMask = 1 << card.gameObject.layer;
                bool big = cardData.cardType.name == "Boss";
                Texture2D texture2D = new Texture2D(400, big ? 700 : 500, TextureFormat.ARGB32, mipChain: false);
                RenderTexture renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
                exportCards.camera.targetTexture = renderTexture;
                exportCards.camera.Render();
                RenderTexture.active = renderTexture;
                texture2D.ReadPixels(new Rect(renderTexture.width / 2 - 200, Screen.height / 2 - (big ? 350 : 250), 400, big ? 700 : 500), 0, 0);
                texture2D.Apply(); 

                CardManager.ReturnToPool(card);
                newCameraObject.Destroy();
                exportCards.Destroy();

                Sprite result = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), 0.5f * Vector2.one, 100, 0, SpriteMeshType.FullRect);
                result.name = name;
                return result;
            }
            var card = AddressableLoader.GetGroup<CardData>(nameof(CardData)).Where(c => c.mainSprite != null && c.mainSprite.name != "Nothing").ToList().RandomItem();
            Sprite sprite = null;
            try { sprite = GetCardSprite(card, "hope.cat"); } catch { };
            assets.AddRange([
                    new StatusIconBuilder(this)
                    .Create(name: "ehe",
                            statusType: "hope.cat",
                            sprite: sprite)
                    .WithTitle("Just a lil guy")
                    .WithTextColour(new Color(0.5f, 0, 0, 1f))
                    .WithTextShadow(new Color(0f, 1, 1, 1f))
                    .WithTextboxIcon(IconSprite)
                    .WithCardOrKeywords(card.name, "snow"),

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectSnow>("cat ehe")
                    .WithIcon_VFX("hope.cat", IconSprite.name, "", VFXMod_StatusEffectHelpers.LayoutGroup.damage),

                    ]);

            base.Load();

            // Allow our icons in card descriptions, scaled properly
            spriteAsset = HopeUtils.CreateSpriteAsset(Title, directoryWithPNGs: "", sprites: [sprite]);
            SpriteAsset.RegisterSpriteAsset();
            foreach (var textboxIcon in SpriteAsset.spriteCharacterTable)
                textboxIcon.scale = 1.3f;

            // TODO: Testing
            foreach (var c in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                if (!c) continue;
                c.startWithEffects = c.startWithEffects.Where(s => s.data != null).ToArray();
                var ss = (string name) => { var stack = SStack(name, c.name?.Length ?? 1); c.startWithEffects = c.startWithEffects.AddToArray(stack); return stack; };
                c.startWithEffects.Where(s => s?.data?.name.Split('.').Last() == "cat ehe").DefaultIfEmpty(ss("cat ehe")).Do(s => s.count = c.name?.Length ?? 1);
                c.startWithEffects.Where(s => s?.data?.name.Split('.').Last() == "Snow").DefaultIfEmpty(ss("Snow")).Do(s => s.count = c.name?.Length ?? 1);
            }
        }

        public override void Unload()
        {
            base.Unload();

            SpriteAsset.UnRegisterSpriteAsset();
            
            // TODO: Testing
            foreach (var c in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                if (!c) continue;

                c.startWithEffects = c.startWithEffects.Where(s => s.data != null).ToArray();
            }
        }


        public StatusIcon GetStatusIcon(string name)
        {
            GameObject iconObject = CardManager.cardIcons.GetValueSafe($"{GUID}.{name}") ?? CardManager.cardIcons.GetValueSafe(name);
            return iconObject?.GetComponent<StatusIcon>();
        }


        // Misc. methods from the tutorials
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}s: {assets.OfType<T>().Count()}");
            return assets.OfType<T>().ToList();
        }
    }

    public class StatusIconData : DataFile
    {
        public string type;
        public string iconGroupName = "damage";
        public KeywordData[] keywords;
        public StatusIcon statusIcon;
    }

    class _StatusIconBuilder : DataFileBuilder<StatusIconData, _StatusIconBuilder>
    {
    }

    public class StatusIconBuilder
    {
        public StatusIcon data;
        public WildfrostMod Mod;
        public Sprite mainSprite;
        public Sprite textboxIcon;
        public KeywordData mainKeyword;
        private KeywordData[] keywords = [];

        public StatusIconBuilder(WildfrostMod mod) => this.Mod = mod;

        public virtual StatusIconBuilder Create(string name, string statusType, Sprite sprite)
        {
            data?.gameObject.DestroyImmediate();
            //name = Extensions.PrefixGUID(name, this.Mod);

            /// Become root in DontDestroyOnLoad
            /// Use the original Snow icon as a template if possible
            GameObject Icon = StatusIconsMod.iconTemplate ?? new GameObject(name, typeof(RectTransform), typeof(Image), typeof(StatusIcon), typeof(CardPopUpTarget));
            Icon.transform.DestroyAllChildren();
            Icon.name = name;

            //GameObject Icon = new GameObject(name, typeof(RectTransform), typeof(Image), typeof(StatusIcon), typeof(CardPopUpTarget));
            GameObject.DontDestroyOnLoad(Icon);

            /// Required, not necessarily enabled
            GameObject Text = new GameObject("Text", typeof(RectTransform), typeof(TextMeshProUGUI)); 
            Text.transform.SetParent(Icon.transform);
            var text = Text.GetOrAdd<TextMeshProUGUI>();
            (text.rectTransform.anchorMin, text.rectTransform.anchorMax) = (Vector2.zero, Vector2.one);
            text.rectTransform.sizeDelta = 0.5f * Vector2.one;

            text.enableAutoSizing = true;
            (text.fontSizeMin, text.fontSizeMax) = (0, 0.425f);
            text.alignment = TextAlignmentOptions.Center;
            text.horizontalAlignment = HorizontalAlignmentOptions.Center;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;

            /// Not required
            //GameObject Fill = new("Fill", typeof(RectTransform), typeof(Image)); Fill.transform.SetParent(Icon.transform);
            //GameObject Outline = new("Outline", typeof(RectTransform), typeof(Image)); Outline.transform.SetParent(Icon.transform);
            //GameObject ActualText = new("ActualText", typeof(RectTransform), typeof(TextMeshProUGUI)); ActualText.transform.SetParent(Icon.transform);

            /// Indirect way of setting CardHover disabled without triggering OnEnable
            /// We have to set .IsMaster = false;
            Icon.SetActive(false);
            CardHover cardHover = Icon.GetOrAdd<CardHover>();
            cardHover.enabled = false;
            cardHover.IsMaster = false;
            Icon.SetActive(true);

            /// Set the image
            Icon.GetOrAdd<Image>().sprite = sprite ??= Sprite.Create(Texture2D.normalTexture, Rect.zero, Vector2.one);
            (float targetWidth, float targetHeight) = (1, 1);
            (float width, float height) = (sprite.rect.width, sprite.rect.height);
            if (width != 0 && height != 0)
            {
                if (width > height) targetWidth = width / height;
                else targetHeight = height / width;
            }
            Icon.transform.ToRectTransform().SetSize(targetWidth, targetHeight); // constrain the image size

            /// Only .keywords is required
            var popup = Icon.GetOrAdd<CardPopUpTarget>();
            /// TODO: Testing
            popup.keywords = new KeywordData[] { Mod.Get<KeywordData>("charmmachine") }; // all keywords to popup
            cardHover.pop = popup; // assign popups to the hoverable object

            var icon = Icon.GetOrAdd<StatusIcon>();
            icon.type = statusType;
            icon.alterTextColours = false;
            icon.textElement = Text.GetOrAdd<TMP_Text>();
            icon.textElement.enabled = false;
            icon.textElement.materialForRendering.name = statusType;

            data = icon;
            this.textboxIcon = sprite.InstantiateKeepName();
            this.textboxIcon.name = statusType;
            ///Mod.SpriteAsset.
            //_data = Create(name).FreeModify(i => i.statusIcon = icon);

            /// Also not required
            //icon.fill = Fill.GetComponent<Image>();
            //icon.textElement = ActualText.GetComponent<TextMeshProUGUI>();

            CardManager.cardIcons[statusType] = Icon;
            return this;
        }
        public StatusIconBuilder WithTitle(string title, SystemLanguage language = SystemLanguage.English) => WithTitle(title, new LocaleIdentifier(language));
        public StatusIconBuilder WithTitle(string title, LocaleIdentifier locale)
        {
            LocalizationHelper.GetCollection("Tooltips", locale).SetString(data.name, title);
            return this;
        }

        public StatusIconBuilder WithTextColour(Color textColour)
        {
            data.textElement.enabled = true;
            data.textElement.faceColor = textColour;
            data.textColour = textColour;
            return this;
        }
        public StatusIconBuilder WithTextColour(Color textColour, Color textColourAboveMax, Color textColourBelowMax)
        {
            data.textElement.enabled = true;
            data.textElement.faceColor = textColour;
            data.alterTextColours = true;
            data.textColour = textColour;
            data.textColourAboveMax = textColourAboveMax;
            data.textColourBelowMax = textColourBelowMax;
            return this;
        }
        public StatusIconBuilder WithTextShadow(Color textShadowColour, float offsetX = 0, float offsetY = -0.75f)
        {
            Material material = data.textElement.materialForRendering;
            material.EnableKeyword("UNDERLAY_ON");
            material.SetColor("_UnderlayColor", textShadowColour);
            material.SetFloat("_UnderlayOffsetX", offsetX);
            material.SetFloat("_UnderlayOffsetY", offsetY);
            return this;
        }


        public StatusIconBuilder WithApplyVFX(GIFLoader vfx, string animationName)
        {
            var animationPrefab = vfx.TryGetPrefab(animationName);
            if (animationPrefab)
                vfx.prefabs[Extensions.PrefixGUID(data.type, Mod)] = animationPrefab;
            return this;
        }

        /// <summary>
        /// Sprite to show when this 
        /// </summary>
        /// <param name="spriteOrNull">Leave empty to reuse the </param>
        /// <returns></returns>
        public StatusIconBuilder WithTextboxIcon(Sprite? spriteOrNull = null)
        {
            if (spriteOrNull) textboxIcon = spriteOrNull;
            return this;
        }

        public StatusIconBuilder WithIconGroupName(string iconGroupName = "damage")
        {
            //_data.iconGroupName = iconGroupName;
            return this;
        }

        public StatusIconBuilder WithPopUpAddStats() => this;

        public StatusIconBuilder WithCardOrKeywords(params string[] cards)
        {
            //this.SubscribeToAfterAllBuildEvent(data => SubToCard(cards));
            return this;
        }
        public StatusIconBuilder WithCardOrKeywords<T>(params string[] keywords) where T : KeywordData
        {
            //this.SubscribeToAfterAllBuildEvent(data => SubToKeywords(keywords));
            return this;
        }
        private void SubToCard(params string[] cards)
        {
            if (!data.gameObject.TryGetComponent<CardPopUpTarget>(out var cardPopUpTarget))
                return;

            Card card = new GameObject("owo").GetOrAdd<Card>();
            card.canvas = Console.instance.canvas;
            card.mentionedCards ??= [];
            cardPopUpTarget.card = card;
            foreach (var keywordName in cards)
            {
                var keyword = Mod.Get<CardData>(keywordName);
                if (keyword == null) continue;

                card.mentionedCards.Add(keyword);
            }
        }
        private void SubToKeywords(params string[] keywords)
        {
            if (!data.gameObject.TryGetComponent<CardPopUpTarget>(out var cardPopUpTarget))
                return;

            var list = new List<KeywordData>();
            foreach (var keywordName in keywords)
            {
                var keyword = Mod.Get<KeywordData>(keywordName);
                if (keyword != null)
                    list.Add(keyword);
            }

            cardPopUpTarget.keywords = list.ToArray();
        }

        //public StatusIconBuilder WithApplySFX()

        public StatusIconBuilder FreeModify(System.Action<StatusIcon> action)
        {
            action?.Invoke(data);
            return this;
        }
    }

    public static class Helpers
    {
    }
}