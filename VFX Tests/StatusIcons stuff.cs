using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using LibAPNG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.UI;
using WildfrostHopeMod.SFX;
using WildfrostHopeMod.Utils;

using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;

namespace WildfrostHopeMod.VFX
{
    public class _StatusIconData : DataFile
    {
        public static Dictionary<string, GameObject> cardIcons => CardManager.cardIcons;
        public StatusIcon icon;


        public Sprite mainSprite;
        public Sprite textboxSprite;
        public string iconGroupName = "damage";
        public KeywordData[] iconKeywords = [];
        public KeywordData[] otherKeywords = [];

        internal string[] iconKeywordNames = [];

        public void OnDestroy()
        {
            if (icon)
            {
                Debug.LogWarning($"[VFX Tools] {icon.type} {(cardIcons.Remove(icon.type) ? "successfully" : "unsuccessfully")}" +
                    $" removed from {nameof(CardManager.cardIcons)}");
                //icon.Destroy();
            }
        }



        public void AddIconKeyword(KeywordData keyword)
        {
            if (!icon.gameObject.TryGetComponent<CardPopUpTarget>(out var cardPopUpTarget))
                return;

            KeywordData[] list = [.. iconKeywords, .. otherKeywords];
            list = list.Where(k => k).ToArray();
            if (keyword != null)
                list = list.With(keyword).Distinct().ToArray();

            iconKeywords = iconKeywords.With(keyword);
            keyword.iconName = textboxSprite.name;
            keyword.show = true;
            keyword.showIcon = true;
            keyword.showName = false;
            cardPopUpTarget.keywords = list;
        }
        public void AddKeyword(KeywordData keyword)
        {
            if (!icon.gameObject.TryGetComponent<CardPopUpTarget>(out var cardPopUpTarget))
                return;

            KeywordData[] list = [.. iconKeywords, .. otherKeywords];
            list = list.Where(k => k).ToArray();
            if (keyword != null)
                list = list.With(keyword).Distinct().ToArray();

            otherKeywords = otherKeywords.With(keyword);
            cardPopUpTarget.keywords = list;
        }
    }

    /// <summary>
    /// Added in through VFX Mod
    /// </summary>
    public partial class StatusIconBuilder : DataFileBuilder<_StatusIconData, StatusIconBuilder>
    {
        public StatusIcon actualIcon;

        public override _StatusIconData BuildInstance()
        {
            _StatusIconData icon = base.BuildInstance();
            icon.iconKeywordNames = _data.iconKeywordNames;
            icon.iconKeywords = _data.iconKeywords;
            icon.otherKeywords = _data.otherKeywords;

            CardManager.cardIcons[actualIcon.type] = actualIcon.gameObject;

            return icon;
        }
        public StatusIconBuilder() { }
        public StatusIconBuilder(WildfrostMod mod) => this.Mod = mod;

        /// <summary>
        /// NOTE: statusType doesn't automatically include your GUID. Make sure to name it something that won't cause conflicts.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="statusType">NOTE: statusType doesn't automatically include your GUID. Make sure to name it something that won't cause conflicts.</param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public virtual StatusIconBuilder Create(string name, string statusType, string filepath)
        {
            LibAPNG.APNG apng = default;
            try
            {
                if (Path.GetExtension(filepath) == ".png" && !filepath.IsSimplePNG(out apng))
                {
                    // Create with APNG
                    return this;
                }
            }
            catch { }
            Sprite sprite = filepath.ToSpriteFull();
            return Create(name, statusType, sprite);
        }
        /// <summary>
        /// NOTE: statusType doesn't automatically include your GUID. Make sure to name it something that won't cause conflicts.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="statusType">NOTE: statusType doesn't automatically include your GUID. Make sure to name it something that won't cause conflicts.</param>
        /// <param name="sprite"></param>
        /// <returns></returns>
        public virtual StatusIconBuilder Create(string name, string statusType, Sprite sprite)
        {
            actualIcon?.gameObject.DestroyImmediate();
            //name = Extensions.PrefixGUID(name, this.Mod);

            /// Become root in DontDestroyOnLoad
            /// Use the original Snow icon as a template if possible
            GameObject Icon = VFXMod.iconTemplate?.InstantiateKeepName() ?? new GameObject(name, typeof(RectTransform), typeof(Image), typeof(StatusIcon), typeof(CardPopUpTarget));
            Icon.transform.DestroyAllChildren();
            Icon.name = name;

            //GameObject Icon = new GameObject(name, typeof(RectTransform), typeof(Image), typeof(StatusIcon), typeof(CardPopUpTarget));
            GameObject.DontDestroyOnLoad(Icon);
            if (VFXMod.parent) Icon.transform.SetParent(VFXMod.parent);

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
            popup.keywords = []; // all keywords to popup
            cardHover.pop = popup; // assign popups to the hoverable object

            var icon = Icon.GetOrAdd<StatusIcon>();
            icon.type = statusType;
            icon.alterTextColours = false;
            icon.textElement = Text.GetOrAdd<TMP_Text>();
            icon.textElement.enabled = false;
            //icon.textElement.material = new(icon.textElement.materialForRendering) { name = statusType };

            actualIcon = icon;

            _data = Create(name);
            _data.mainSprite = sprite;
            //_data.textboxSprite = sprite.InstantiateKeepName();
            _data.textboxSprite = sprite.InstantiateKeepName();
            _data.textboxSprite.name = statusType;
            _data.icon = icon;
            _data.icon.type = statusType;

            /// Also not required
            //icon.fill = Fill.GetComponent<Image>();
            //icon.textElement = ActualText.GetComponent<TextMeshProUGUI>();

            return this;
        }

        #region textElement

        /// <summary>
        /// Enables the text element, and colours it
        /// </summary>
        /// <param name="textColour">Transparency here doesn't affect shadow</param>
        /// <returns></returns>
        public StatusIconBuilder WithTextColour(Color textColour)
        {
            actualIcon.textElement.enabled = true;
            //actualIcon.textElement.faceColor = textColour;
            actualIcon.textElement.color = textColour;
            actualIcon.textColour = textColour;
            return this;
        }

        /// <summary>
        /// Enables the text element, and colours it. NOTE: This doesn't actually work yet. Sorry
        /// </summary>
        /// <param name="textColour">Transparency here doesn't affect shadow</param>
        /// <param name="textColourAboveMax"></param>
        /// <param name="textColourBelowMax"></param>
        /// <returns></returns>
        public StatusIconBuilder WithTextColour(Color textColour, Color textColourAboveMax, Color textColourBelowMax)
        {
            actualIcon.textElement.enabled = true;
            actualIcon.textElement.faceColor = textColour;
            actualIcon.alterTextColours = true;
            actualIcon.textColour = textColour;
            actualIcon.textColourAboveMax = textColourAboveMax;
            actualIcon.textColourBelowMax = textColourBelowMax;

            Patches.subbedTypes.Add(actualIcon.type);
            return this;
        }
        /// <summary>
        /// Enables the text shadow. Requires also .WithTextColour
        /// </summary>
        /// <param name="textShadowColour"></param>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
        /// <returns></returns>
        public StatusIconBuilder WithTextShadow(Color textShadowColour, float offsetX = 0, float offsetY = -0.75f)
        {
            Material material = new(actualIcon.textElement.materialForRendering) { name = actualIcon.name };
            material.EnableKeyword("UNDERLAY_ON");
            material.SetColor("_UnderlayColor", textShadowColour);
            material.SetFloat("_UnderlayOffsetX", offsetX);
            material.SetFloat("_UnderlayOffsetY", offsetY);
            actualIcon.textElement.material = material;
            return this;
        }
        #endregion


        /// <summary>
        /// Sprite to use in effect descriptions
        /// </summary>
        /// <param name="spriteOrNull">Leave empty to reuse the main sprite</param>
        /// <returns></returns>
        public StatusIconBuilder WithTextboxSprite(Sprite? spriteOrNull = null)
        {
            if (spriteOrNull) _data.textboxSprite = spriteOrNull;
            else _data.textboxSprite = _data.mainSprite;

            if (_data.textboxSprite == null) return this;
            _data.textboxSprite.name = $"{actualIcon.type}";

            TMP_SpriteAsset spriteAsset = this.Mod?.SpriteAsset ?? VFXMod.instance?.SpriteAsset;
            if (!spriteAsset?.spriteCharacterTable.Select(c => c.name).ToHashSet().Contains(actualIcon.type) ?? false)
                spriteAsset?.AddSprites(sprites: [_data.textboxSprite]);
            return this;
        }
        /// <summary>
        /// Sprite to use in effect descriptions
        /// </summary>
        /// <returns></returns>
        public StatusIconBuilder WithTextboxSprite(string filepath)
        {
            _data.textboxSprite = filepath.ToSpriteFull();
            _data.textboxSprite.name = $"{actualIcon.type}";

            TMP_SpriteAsset spriteAsset = this.Mod?.SpriteAsset ?? VFXMod.instance?.SpriteAsset;
            if (!spriteAsset?.spriteCharacterTable.Select(c => c.name).ToHashSet().Contains(actualIcon.type) ?? false)
                spriteAsset?.AddSprites(sprites: [_data.textboxSprite]);
            return this;
        }

        #region iconGroup
        public enum IconGroups
        {
            crown,
            health,
            damage,
            counter
        }
        public StatusIconBuilder WithIconGroupName(IconGroups iconGroup = IconGroups.damage)
        {
            _data.iconGroupName = iconGroup.ToString();
            return this;
        }
        public StatusIconBuilder WithIconGroupName(string iconGroupName = "damage")
        {
            _data.iconGroupName = iconGroupName;
            return this;
        }
        #endregion



        /// <summary>
        /// TODO: This would add stats similar to health, attack, counter when hovered (like X/Y)
        /// </summary>
        /// <returns></returns>
        public StatusIconBuilder WithPopUpAddStats() => this;

        /*public StatusIconBuilder WithCardOrKeywords(params string[] cards)
        {
            //this.SubscribeToAfterAllBuildEvent(data => SubToCard(cards));
            return this;
        }*/

        #region keywords and cards (TODO)
        public StatusIconBuilder WithKeywords(string iconKeywordOrNull, params string[] otherKeywords)
        {
            return this.WithKeywords([iconKeywordOrNull], otherKeywords);
        }
        public StatusIconBuilder WithKeywords(KeywordData iconKeywordOrNull, params KeywordData[] otherKeywords)
        {
            if (!actualIcon.gameObject.TryGetComponent<CardPopUpTarget>(out var cardPopUpTarget))
                return this;

            _data.AddIconKeyword(iconKeywordOrNull);

            var list = new List<KeywordData>();
            var mainKeyword = _data.iconKeywords.FirstOrDefault(t => t);
            if (mainKeyword != null)
            {
                list.Add(mainKeyword);
                _data.AddIconKeyword(iconKeywordOrNull);
            }

            foreach (var otherKeyword in otherKeywords)
            {
                if (otherKeyword != null)
                {
                    list.Add(otherKeyword);
                    _data.AddKeyword(otherKeyword);
                }
            }

            cardPopUpTarget.keywords = list.Where(k => k).ToArray();
            return this;
        }
        public StatusIconBuilder WithKeywords(string[] iconKeywordsOrNull, params string[] otherKeywords)
        {
            _data.iconKeywordNames = iconKeywordsOrNull?.Select(k => k?.ToLowerInvariant() ?? "").ToArray() ?? [];
            this.SubscribeToAfterAllBuildEvent(icon =>
            {
                if (!actualIcon.gameObject.TryGetComponent<CardPopUpTarget>(out var cardPopUpTarget))
                    return;

                _data.iconKeywords = iconKeywordsOrNull?.Select(k => Mod.Get<KeywordData>(k?.ToLowerInvariant() ?? "")).Where(k => k).ToArray() ?? [];

                var list = new List<KeywordData>();
                foreach (var mainKeyword in _data.iconKeywords)
                {
                    list.Add(mainKeyword);
                    mainKeyword.iconName = icon.textboxSprite.name;
                    mainKeyword.show = true;
                    mainKeyword.showIcon = true;
                    mainKeyword.showName = false;
                }

                foreach (var keywordName in otherKeywords)
                {
                    var keyword = Mod.Get<KeywordData>(keywordName?.ToLowerInvariant());
                    if (keyword != null)
                        list.Add(keyword);
                }

                cardPopUpTarget.keywords = list.Where(k => k).ToArray();
            });
            return this;
        }


        #endregion

        //public StatusIconBuilder WithApplySFX()

        public StatusIconBuilder FreeModify(System.Action<StatusIcon> action)
        {
            action?.Invoke(actualIcon);
            return this;
        }


        /*/// <summary>
        /// 
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplyLog()
        {
            vfx ??= VFXMod.instance?.VFX;

            var animationPrefab = vfx?.TryGetPrefab(animationName);
            animationPrefab?.RegisterAsApplyEffect(actualIcon.type);
            return this;
        }*/
    }

    public static class StatusIconHelpers
    {
        public static bool IsSimplePNG(this string filepath, out LibAPNG.APNG apng)
        {
            try
            {
                apng = new LibAPNG.APNG(filepath);
                if (apng.IsSimplePNG)
                    return true;
            }
            catch { }
            apng = null;
            return false;
        }
        public static bool IsSimplePNG(this string filepath)
        {
            try
            {
                var apng = new LibAPNG.APNG(filepath);
                if (apng.IsSimplePNG)
                    return true;
            }
            catch { }
            return false;
        }


        public static KeywordDataBuilder Subscribe_WithStatusIcon(this KeywordDataBuilder builder, string statusIconName)
        {
            builder = builder.SubscribeToAfterAllBuildEvent(keyword =>
            {
                var statusIconData = builder.Mod.Get<_StatusIconData>(statusIconName);
                statusIconData.iconKeywords = statusIconData.iconKeywords.With(keyword);
                keyword.iconName = statusIconData.textboxSprite.name;
                keyword.show = true;
                keyword.showIcon = true;
                keyword.showName = false;
                statusIconData.AddKeyword(null);
            });
            return builder;
        }
        public static KeywordDataBuilder Subscribe_WithStatusIcon(this KeywordDataBuilder builder, _StatusIconData statusIconData)
        {
            builder = builder.SubscribeToAfterAllBuildEvent(keyword =>
            {
                statusIconData.AddKeyword(keyword);
            });
            return builder;
        }
        public static StatusEffectDataBuilder Subscribe_WithStatusIcon(this StatusEffectDataBuilder builder, string statusIconName)
        {
            builder = builder.SubscribeToAfterAllBuildEvent(status =>
            {
                if (status.applyFormatKey?.IsEmpty ?? true)
                    status.applyFormatKey = Deadpan.Enums.Engine.Components.Modding.Extensions.GetLocalizedString("Card Text", "Apply X");

                WildfrostMod mod = builder.Mod ?? new InternalMod("");
                var statusIconData = mod.Get<_StatusIconData>(statusIconName);

                if (statusIconData == null)
                {
                    Debug.LogError($"AAAAAA WE LOST THE ICON WHERE DID [{statusIconName}] GO");
                    return;
                }


                /*Debug.LogWarning($"""
                    [VFX Tools] 
                    Keywords: {statusIconData.iconKeywords?.Join(t => t ? t.name : "DESTROYED") ?? "NULL"}
                    Keyword names: {statusIconData.iconKeywordNames?.Join() ?? "NULL"}
                    Keyword from names: {builder.Mod.Get<KeywordData>(statusIconData.iconKeywordNames?.FirstOrDefault()?.ToLowerInvariant() ?? "")}
                    """);*/

                status.type = statusIconData.icon.type;
                status.keyword = statusIconData.iconKeywords?.FirstOrDefault(t => t)?.name.ToLowerInvariant() ??
                    builder.Mod.Get<KeywordData>(statusIconData.iconKeywordNames?.FirstOrDefault()?.ToLowerInvariant() ?? "")?.name.ToLowerInvariant() ?? "";
                status.isKeyword = false;
                status.isStatus = true;
                status.visible = true;
                status.iconGroupName = statusIconData.iconGroupName;

                var keyword = mod.Get<KeywordData>(status.keyword);
                if (keyword != null)
                {
                    keyword.iconName = statusIconData.textboxSprite.name;
                    keyword.show = true;
                    keyword.showIcon = true;
                    keyword.showName = false;
                }
                else
                    Debug.LogError($"AAAAAA WE LOST THE BOY WHERE DID [{status.keyword}] GO");
            });
            return builder;
        }

        /*/// <summary>
        /// Subscribes after all built: Configures this effect to use a statusIconData
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="statusIconName"></param>
        /// <param name="customGroup">If this effect should use the icon in a different place than previously defined</param>
        /// <returns></returns>
        public static StatusEffectDataBuilder Subscribe_WithStatusIcon(this StatusEffectDataBuilder builder, string statusIconName, string customGroup)
        {
            builder = builder.SubscribeToAfterAllBuildEvent(status =>
            {
                if (status is StatusEffectApplyX data)
                    data.applyFormatKey = Deadpan.Enums.Engine.Components.Modding.Extensions.GetLocalizedString("Card Text", "Apply X");

                WildfrostMod mod = builder.Mod ?? new InternalMod("");
                var statusIconData = mod.Get<StatusIconData>(statusIconName);

                if (statusIconData == null)
                {
                    Debug.LogError($"AAAAAA WE LOST THE ICON WHERE DID [{statusIconName}] GO");
                    return;
                }

                status.type = statusIconData.icon.type;
                status.keyword = statusIconData.iconKeywords.FirstOrDefault()?.name.ToLowerInvariant() ?? statusIconData.iconKeywordNames.FirstOrDefault() ?? "";
                status.isKeyword = false;
                status.visible = true;
                status.iconGroupName = customGroup;

                var keyword = mod.Get<KeywordData>(status.keyword);
                if (keyword != null)
                {
                    keyword.iconName = statusIconData.textboxSprite.name;
                    keyword.show = true;
                    keyword.showIcon = true;
                    keyword.showName = false;
                }
                else
                    Debug.LogError($"AAAAAA WE LOST THE BOY WHERE DID [{status.keyword}] GO");
            });
            return builder;
        }*/
    }
}
