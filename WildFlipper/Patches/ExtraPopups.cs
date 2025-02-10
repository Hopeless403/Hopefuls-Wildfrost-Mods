using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Recommended to put `using static ExtraPopups.PopGroup;` at the top of the file that uses .Patch_ExtraPopups
/// </summary>
[HarmonyPatch]
public static class ExtraPopups
{
    const string credit = "Credit to Hopeless";
    public static readonly Dictionary<string, (string keyword, PopGroup group)[]> flavours = new Dictionary<string, (string keyword, PopGroup group)[]>();

    public static CardDataBuilder Patch_ExtraPopups(this CardDataBuilder builder, params (string keywordName, PopGroup group)[] flavours)
    {
        builder.SubscribeToAfterAllBuildEvent(c =>
            c.Patch_ExtraPopups(flavours.Select(tuple => (builder.Mod.Get<KeywordData>(tuple.keywordName.ToLower())?.name.ToLower(), tuple.group)).ToArray())
            );
        return builder;
    }
    public static void Patch_ExtraPopups(this CardData card, params (string keywordName, PopGroup group)[] flavours)
    {
        if (card == null) return;
        if (ExtraPopups.flavours.TryGetValue(card.name, out var keywordPairs))
            ExtraPopups.flavours[card.name] = keywordPairs.AddRangeToArray(flavours);
        else
            ExtraPopups.flavours[card.name] = flavours;
    }


    public enum PopGroup
    {
        Left,
        LeftOverflow,
        Right,
        RightOverflow,
        Bottom
    }
    static Transform GetGroup(CardInspector inspector, PopGroup popGroup) =>
        popGroup switch
        {
            PopGroup.Left => inspector.leftPopGroup,
            PopGroup.LeftOverflow => inspector.leftOverflowPopGroup,
            PopGroup.Right => inspector.rightPopGroup,
            PopGroup.RightOverflow => inspector.rightOverflowPopGroup,
            PopGroup.Bottom => inspector.bottomPopGroup
        };
    static Transform GetGroup(InspectSystem inspector, PopGroup popGroup) =>
        popGroup switch
        {
            PopGroup.Left => inspector.leftPopGroup,
            PopGroup.LeftOverflow => inspector.leftOverflowPopGroup,
            PopGroup.Right => inspector.rightPopGroup,
            PopGroup.RightOverflow => inspector.rightOverflowPopGroup,
            PopGroup.Bottom => inspector.bottomPopGroup
        };

    [HarmonyPatch(typeof(CardInspector), nameof(CardInspector.CreatePopups))]
    static void Postfix(CardInspector __instance, Entity inspect)
    {
        if (inspect.display is not Card) return;
        if (!flavours.TryGetValue(inspect.name, out var flavour)) return;

        foreach ((string keyword, PopGroup group) in flavour)
        {
            KeywordData data = AddressableLoader.Get<KeywordData>(nameof(KeywordData), keyword.ToLower()) 
                ?? throw new NullReferenceException($"No KeywordData found with name [{keyword}]");
            CardPopUpPanel panel = __instance.Popup(data, GetGroup(__instance, group));
            foreach (CardData card in Text.GetMentionedCards(data.body))
            {
                CardTooltip cardTooltip = __instance.Popup(card, GetGroup(__instance, group));
                panel.children.AddIfNotNull(cardTooltip);
            }
        }
    }

    [HarmonyPatch(typeof(InspectSystem), nameof(InspectSystem.CreatePopups))]
    static void Postfix(InspectSystem __instance)
    {
        Entity inspect = __instance.inspect;
        if (inspect.display is not Card) return;
        if (!flavours.TryGetValue(inspect.name, out var flavour)) return;

        foreach ((string keyword, PopGroup group) in flavour)
        {
            KeywordData data = AddressableLoader.Get<KeywordData>(nameof(KeywordData), keyword.ToLower()) 
                ?? throw new NullReferenceException($"No KeywordData found with name [{keyword}]");
            CardPopUpPanel panel = __instance.Popup(data, GetGroup(__instance, group));
            foreach (CardData card in Text.GetMentionedCards(data.body))
            {
                CardTooltip cardTooltip = __instance.Popup(card, GetGroup(__instance, group));
                panel.children.AddIfNotNull(cardTooltip);
            }
        }
    }
}
