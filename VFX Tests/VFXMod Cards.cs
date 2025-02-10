using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.IO;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using WildfrostHopeMod.Text;
using FMODUnity;
using WildfrostHopeMod.SFX;
using UnityEngine.TextCore.Text;
using TMPro;
using WildfrostHopeMod.Utils;
using System;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using JetBrains.Annotations;
using System.Collections;
using _ = FMOD;
using Rewired;

namespace WildfrostHopeMod.VFX
{
    public static class VFXMod_StatusEffectHelpers
    {
        public enum LayoutGroup
        {
            crown,
            damage,
            health,
            counter
        }
        /// <summary>
        /// Defined by VFX Mod. Fills in the required parameters for a status icon
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="statusType">Gets the status icon at CardManager.cardIcons[statusType]</param>
        /// <param name="iconSpriteName">Shows sprite in text via <sprite name=iconSpriteName></param>
        /// <param name="keywordName">The Keyword to popup</param>
        /// <param name="group">Where to show the icon</param>
        /// <returns></returns>
        public static StatusEffectDataBuilder WithIcon_VFX(this StatusEffectDataBuilder builder, string statusType, string iconSpriteName, string keywordName, LayoutGroup group)
        {
            return builder.WithType(statusType)
                .WithKeyword(keywordName.ToLowerInvariant())
                .WithIsKeyword(false) // only for temporary traits
                .WithIsStatus(true)
                .WithVisible(true)
                .WithIconGroupName(typeof(LayoutGroup).GetEnumNames()[(int)group])
                .SubscribeToAfterAllBuildEvent(d =>
                {
                    if (builder.Mod != null)
                    {
                        var keyword = builder.Mod.Get<KeywordData>(keywordName.ToLowerInvariant()) ?? builder.Mod.Get<KeywordData>(keywordName);
                        if (keyword != null)
                        {
                            keyword.iconName = iconSpriteName;
                            keyword.show = true;
                            keyword.showIcon = true;
                            keyword.showName = false;
                        }
                        else
                            Debug.LogError($"AAAAAA WE LOST THE BOY WHERE DID [{keywordName}] GO");
                    }
                    if (d is StatusEffectApplyX data)
                        data.applyFormatKey = Deadpan.Enums.Engine.Components.Modding.Extensions.GetLocalizedString("Card Text", "Apply X");
                });
        }
    }
    /*public partial class VFXMod : WildfrostMod
    {
        public override List<T> AddAssets<T, Y>() => assets.OfType<T>().ToList();
        
        public static List<object> _assets;
        public List<object> assets => _assets ??= [
            new StatusEffectDataBuilder(this).Create<StatusEffectSnow>("0")
            .WithIcon_VFX(
                statusType:CreateIcon("yelanjoyType", "charmmachine").name,
                iconSpriteName:"yelanjoy",
                keywordName:"charmmachine",
                group:VFXMod_StatusEffectHelpers.LayoutGroup.crown
                )
            ,
        ];


        internal GameObject CreateIcon(string statusType, string keyword)
        {
            /// Set icons as VFX Mod's children if possible, otherwise become root in DontDestroyOnLoad
            GameObject Icon = new GameObject(statusType, typeof(RectTransform), typeof(Image), typeof(StatusIcon), typeof(CardPopUpTarget));//, typeof(CardHover));
            if (parent) Icon.transform.SetParent(parent);
            else GameObject.DontDestroyOnLoad(Icon);

            /// Required, not necessarily enabled
            GameObject Text = new GameObject("Text", typeof(RectTransform), typeof(TextMeshProUGUI)); Text.transform.SetParent(Icon.transform);
            
            /// Not required
            //GameObject Fill = new("Fill", typeof(RectTransform), typeof(Image)); Fill.transform.SetParent(Icon.transform);
            //GameObject Outline = new("Outline", typeof(RectTransform), typeof(Image)); Outline.transform.SetParent(Icon.transform);
            //GameObject ActualText = new("ActualText", typeof(RectTransform), typeof(TextMeshProUGUI)); ActualText.transform.SetParent(Icon.transform);

            /// Indirect way of setting CardHover disabled without triggering OnEnable
            /// We have to set .IsMaster = false;
            Icon.SetActive(false);
            CardHover cardHover = Icon.GetOrAdd<CardHover>();
            cardHover.enabled = false; // re-enabled in entityDisplay.SetStatusIcon()
            cardHover.IsMaster = false; // this is always false
            Icon.SetActive(true);

            /// Set the image
            (Icon.transform as RectTransform).SetSize(1, 1); // constrain the image size
            Icon.GetOrAdd<Image>().sprite = ImagePath("5484557.png").ToSpriteFull();

            /// Only .keywords is required
            var popup = Icon.GetOrAdd<CardPopUpTarget>();
            popup.keywords = [Get<KeywordData>("crown")]; // all keywords to popup
            cardHover.pop = popup; // assign popups to the hoverable object

            var icon = Icon.GetOrAdd<StatusIcon>();
            icon.type = statusType;
            icon.textElement = Text.GetOrAdd<TMP_Text>();

            icon.onCreate = icon.onDestroy = icon.afterUpdate = new();
            icon.onValueUp = icon.onValueDown = new();

            icon.onCreate.AddListener(icon.Ping);
            icon.onValueUp.AddListener((_, _) => icon.Ping());
            icon.onValueDown.AddListener((_, _) => icon.Ping());
            icon.onValueDown.AddListener(icon.CheckDestroy);
            icon.afterUpdate.AddListener(icon.SetText);

            /// Also not required
            //icon.fill = Fill.GetComponent<Image>();
            //icon.textElement = ActualText.GetComponent<TextMeshProUGUI>();

            icon.alterTextColours = false;

            CardManager.cardIcons[statusType] = Icon;
            return Icon;
        }
    }*/
    
}