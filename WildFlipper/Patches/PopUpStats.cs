using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using static SaveSystem;

[HarmonyPatch(typeof(PopUpAddStatsSystem), nameof(PopUpAddStatsSystem.PopupCreated))]
public static class PatchPopUpAddStats
{
    const string credit = "Credit to Hopeless";
    /// <summary>
    /// Key: Keyword name
    /// Value: Function with inputs
    ///         string: previous title, 
    ///         Entity: current hovered entity, 
    ///         KeywordData: keyword of the popup),
    ///        and outputs
    ///         string: new title to display
    /// </summary>
    public static Dictionary<string, Func<string, Entity, KeywordData, string>> titleActions = [];
    public static Dictionary<string, Func<string, Entity, KeywordData, string>> bodyActions = [];
    public static Dictionary<string, Func<string, Entity, KeywordData, string>> noteActions = [];

    public static KeywordDataBuilder Patch_PopUpAddStats(this KeywordDataBuilder builder, Func<string, Entity, KeywordData, string> titleAction)
    {
        builder.SubscribeToAfterAllBuildEvent(c => c.Patch_PopUpAddStats(titleAction));
        return builder;
    }
    public static void Patch_PopUpAddStats(this KeywordData keyword, Func<string, Entity, KeywordData, string> titleAction)
    {
        if (keyword == null) return;
        titleActions[keyword.name] = titleAction;
    }

    public static string GetStatText(object current, object max, string color = "#FFFFFF")
      => GetColoredText(current + "/" + max, color);
    public static string GetColoredText(object text, string color = "#FFFFFF")
      => $"<color={color}>{text}</color>";

    static void Postfix(PopUpAddStatsSystem __instance, Entity ___hover, KeywordData keyword, CardPopUpPanel panel)
    {
        // NOTE: ___hover is the entity that owns the StatusIcon this popup is for!
        if (!___hover)
            return;

        if (titleActions.TryGetValue(keyword.name, out var titleAction))
        {
            panel.titleText = titleAction(panel.titleText, ___hover, keyword);
            panel.BuildTextElement();
        }

        if (bodyActions.TryGetValue(keyword.name, out var bodyAction))
        {
            panel.bodyText = bodyAction(panel.bodyText, ___hover, keyword);
            panel.BuildTextElement();
        }

        if (noteActions.TryGetValue(keyword.name, out var noteAction))
        {
            panel.noteText = noteAction(panel.noteText, ___hover, keyword);
            panel.BuildTextElement();
        }
    }

    /*public static void AttackExample()
    {
        KeywordData attackKeyword = AddressableLoader.Get<KeywordData>(nameof(KeywordData), "attack");
        attackKeyword.Patch_PopUpAddStats((title, entity, keyword) =>
        {
            int currentAttack = entity.damage.current + entity.tempDamage.Value;
            string newTitle = title;
            ((num < hover.damage.max) ? (text2 + string.Format("<color={0}>{1}</color>", "#e8a0a0", num)) : ((num <= hover.damage.max) ? (text2 + $"{num}") : (text2 + string.Format("<color={0}>{1}</color>", "#5F5", num))));
            if (currentAttack < entity.damage.max)
                newTitle += GetColoredText(currentAttack, "#E8A0A0");
            else
                newTitle += GetColoredText(currentAttack,)
        }
    }*/






}