using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using Steamworks;
using Steamworks.Ugc;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using static WildfrostHopeMod.ModUploader.Localizers;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using System.Reflection;

namespace WildfrostHopeMod.ModUploader;
[HarmonyPatch]
public partial class ModUploader : WildfrostMod
{
    public ModUploader(string modDirectory) : base(modDirectory)
    {
        Events.OnGameStart += () => typeof(Localizers).GetFields().Update(field => _ = field.GetValue(null) as LocalizedString);

    }
    public override string GUID => "hope.wildfrost.moduploader";
    public override string[] Depends => [];
    public override string Title => "Mod Uploader";
    public override string Description => "Override the default publish button with nicer UI. Makes it a bit easier to set/reuse tags and visibility. Also fixes dependencies not being added"
        + "\n\nWhen you press \"Edit tags\", it automatically opens a file called tags.txt in your mod folder. Type your tags in there, with a new line for each tag, and don't forget to save.";

    static bool shouldPatch = true; 
    public static readonly string[] tagsAll = [
            "Cards",
            "Bosses",
            "Pets",
            "QoL",
            "Tools",
            "Leaders",
            "Tribes",
            "Expansion",
            "Battles",
            "Balance",
            "English",
            "Simplified Chinese",
            "Traditional Chinese",
            "Korean",
            "Japanese",
            "French",
            "German",
            "Russian",
            "Spanish",
            "Portuguese",
            "Public",
            "FriendsOnly",
            "Private",
            "Unlisted",
            "Hidden"
        ];
    public static readonly string[] visibilityTags = [
            "Public",
            "FriendsOnly",
            "Private",
            "Unlisted",
            "Hidden",
        ];

    public static List<Item> PublishedItems = [];
    public static List<Item> PossibleDependencies = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ModHolder), nameof(ModHolder.UpdateInfo))]
    public static void PatchPublishButtonsActive(ModHolder __instance)
    {
        __instance.PublishButton.SetActive(new DirectoryInfo(__instance.Mod.ModDirectory).FullName.Contains(new DirectoryInfo(Application.streamingAssetsPath).FullName));
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ModHolder), nameof(ModHolder.PublishMod))]
    public static bool PatchPublishButtons(ModHolder __instance)
    {
        if (shouldPatch)
            OnClick(__instance); 
        //Text.GetEffectText(LocalizationHelper.GetCollection("Card Text", SystemLanguage.English).GetString("Gain X"), "<keyword=wild>", 0);
        return false;
    }
    public static async void OnClick(ModHolder modHolder)
    {
        WildfrostMod mod = modHolder.Mod; 
        string path = Path.Combine(mod.ModDirectory, "tags.txt");
        string[] tagsProvided = await GetTags(mod);
        string[] tagsCustom = [.. tagsProvided.Where(t => !tagsAll.Contains(t))];
        string[] tagsPrevious = (await GetTags(mod, fromWorkshop: true)).Where(s => !visibilityTags.Select(t => t.ToLower()).Contains(s.ToLower())).ToArray();

        var visibility = visibilityTags.FirstOrDefault(tag => tagsProvided.Select(t => t.ToLower()).Contains(tag.ToLower()));
        tagsProvided = tagsProvided.Where(s => !visibilityTags.Select(t => t.ToLower()).Contains(s.ToLower())).ToArray();

        var newTags = tagsProvided.Where(tag => tagsPrevious.All(t => t.ToLower() != tag.ToLower()));
        var oldTags = tagsPrevious.Where(tag => tagsProvided.All(t => t.ToLower() != tag.ToLower()));

        List<string> bodyParts = [];
        if (tagsProvided.Any())
            bodyParts.Add(Localizers.Body_tags.Format(string.Join(", ", tagsProvided)));
        if (visibility != "Public")
            bodyParts.Add(Localizers.Body_visibility.Format(visibility));
        if (newTags.Any() && tagsPrevious.Any(t => t != "Mod"))
            bodyParts.Add(Localizers.Body_addsTags.Format(string.Join(", ", newTags)));
        if (oldTags.Any())
            bodyParts.Add(Localizers.Body_removesTags.Format(string.Join(", ", oldTags)));

        string desc = Localizers.Panel_Format.String.Format(
            mod.GUID,
            bodyParts.DefaultIfEmpty("").Join(delimiter:"\n"),
            tagsCustom.Any() ? Localizers.Note_hasCustomTags.Format(string.Join(", ", tagsCustom)) : Localizers.Note_noCustomTags.String
            );

        if (SceneManager.IsLoaded("Mods"))
            CoroutineManager.Start(SceneManager.Unload("Mods"));
        HelpPanelSystem.instance.OnDisable();
        Localizers.ShowPanel(desc);
        HelpPanelSystem.SetEmote(Prompt.Emote.Type.Basic);
        HelpPanelSystem.SetBackButtonActive(false);
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Negative, Localizers.Buttons_cancel, "Back", null);
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, Localizers.Buttons_editTags, "Options", () => 
            EditTags(path, tagsPrevious));
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, Localizers.GetString("UI Text", "confirm"), "Select", () =>
            UpdateOrPublishToWorkshop(mod, tagsProvided, visibility)
        );
    }

    const string explanation = "[Delete this later] Write new tags on new lines";


    public static void EditTags(string path, string[] tagsPrevious)
    {
        if (!File.Exists(path))
        {
            var file = File.CreateText(path);
            if (tagsPrevious.Length <= 1)
                file.WriteLine(explanation);
            foreach (var tag in tagsPrevious)
                file.WriteLine(tag);
            file.Close();
        }
        Application.OpenURL(path);
        CoroutineManager.Start(SceneManager.Load("Mods", SceneType.Temporary));
    }

    public static async Task<List<Item>> GetPublishedItems()
    {
        if ((PublishedItems ??= []).Count <= 0 && SteamManager.init)
        {
            int index = 1;
            while (true)
            {
                //Debug.LogError("NEW PAGE NEW PAGE NEW PAGE " + index);
                var ResultPage = await new Query(UgcType.Items, UserUGCList.Published, UserUGCListSortOrder.CreationOrderDesc, SteamClient.SteamId)
                    .WithMetadata(b: true).WithTag("Mod").GetPageAsync(index++);
                //Debug.LogError((ResultPage.Value.ResultCount, ResultPage.Value.Entries.Where(item => item.Result != Result.FileNotFound).Select(item => item.Title).Join()));
                if (ResultPage.HasValue && ResultPage.Value.ResultCount > 0)
                    PublishedItems.AddRange(ResultPage.Value.Entries.Where(item => item.Result != Result.FileNotFound));
                else break; //Debug.LogError((ResultPage.Value.TotalCount, ResultPage.Value.Entries.Where(item => item.Result != Result.FileNotFound).Select(item => item.Title).Join()));
            }

            PossibleDependencies = PublishedItems;
            index = 1;
            while (true)
            {
                //Debug.LogError("NEW PAGE NEW PAGE NEW PAGE " + index);
                var ResultPage = await new Query(UgcType.Items, UserUGCList.Subscribed, UserUGCListSortOrder.CreationOrderDesc, SteamClient.SteamId)
                    .WithMetadata(b: true).WithTag("Mod").GetPageAsync(index++);
                //Debug.LogError((ResultPage.Value.ResultCount, ResultPage.Value.Entries.Where(item => item.Result != Result.FileNotFound).Select(item => item.Title).Join()));
                if (ResultPage.HasValue && ResultPage.Value.ResultCount > 0)
                    PossibleDependencies.AddRange(ResultPage.Value.Entries.Where(item => item.Result != Result.FileNotFound));
                else break;

                //Debug.LogError((ResultPage.Value.TotalCount, ResultPage.Value.Entries.Where(item => item.Result != Result.FileNotFound).Select(item => item.Title).Join()));
            }
        }
        return PublishedItems;
    }
    public static async Task<string[]> GetTags(WildfrostMod mod, bool fromWorkshop = false)
    {
        var tagsPath = Path.Combine(mod.ModDirectory, "tags.txt");
        string[] tags = File.Exists(tagsPath) ? File.ReadAllLines(tagsPath) : [];
        if (!File.Exists(tagsPath) || fromWorkshop)
        {
            var workshopItem = (await GetPublishedItems()).Find(item => item.Metadata == mod.GUID);
            if (!workshopItem.Equals(default(Item)))
            {
                string visibility = "Public";
                if (workshopItem.IsPrivate) visibility = "Private";
                if (workshopItem.IsFriendsOnly) visibility = "FriendsOnly";
                tags = workshopItem.Tags.With(visibility);
            }

        };
        var result = tags.Select(tag =>
        {
            var newTag = tagsAll.FirstOrDefault(t => t.ToLower() == tag.ToLower());
            return newTag == default ? tag : newTag;
        });
        if (!result.Intersect(["Public", "Private", "Hidden", "FriendsOnly", "Unlisted"]).Any())
            result = result.AddItem("Public");
        return result.Except(["Mod", "mod", explanation]).Distinct().ToArray();
    }
    

}
