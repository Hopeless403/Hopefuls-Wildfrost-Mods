using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Steamworks;
using Steamworks.Ugc;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization.Settings;
using System.Text.RegularExpressions;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public class CommandCustomPublish : ConsoleCustom.Command
        {
            public override string id => "publish";
            public override string format => "publish <modguid> <Language/tag> <tag> ... <tag>";
            public override bool IsRoutine => false;
            public readonly string[] tagsAll = [
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
                "\"Simplified Chinese\"",
                "\"Traditional Chinese\"",
                "Korean",
                "Japanese",
            ];
            public static LocalizedString CreateString(string text)
            {
                StringTable collection = LocalizationHelper.GetCollection("UI Text", LocalizationSettings.Instance.GetSelectedLocale().Identifier);
                collection.SetString("hope." + text, text);
                return collection.GetString("hope." + text);
            }
            public override async void Run(string args)
            {
                string guid = Split(args.TrimStart())[0];
                foreach (WildfrostMod mod in Bootstrap.Mods)
                {
                    if (mod.GUID != guid)
                        continue;

                    /// Match either: Words between whitespace, Sentences in quotes, or Everything after last unmatched quote
                    string regexPattern = @"(?:[\w.]+|\"".+?\""|\"".+?$)";
                    string[] tagsProvided = [.. 
                        Regex.Matches(args, regexPattern)
                        .Cast<Match>().Select(m => m.Value.Replace("\"","")).Skip(1)
                        ];
                    string[] tagsCustom = [.. tagsProvided.Where(t => !tagsAll.Contains(t))];

                    HelpPanelSystem.instance.OnDisable();
                    string desc = $"Publish mod [{mod.GUID}]?"
                        + (tagsProvided.Any() ? $"|... with tag(s) [{string.Join(", ", tagsProvided)}]?" : "|")
                        + "|Note: You can use any custom tags too!"
                        + (tagsCustom.Any() ? $"\nLanguage/Custom tags: [{string.Join(", ", tagsCustom)}]" : "");

                    if (SceneManager.IsLoaded("Mods"))
                        CoroutineManager.Start(SceneManager.Unload("Mods"));
                    HelpPanelSystem.Show(CreateString(desc));
                    HelpPanelSystem.SetEmote(Prompt.Emote.Type.Basic);
                    HelpPanelSystem.SetBackButtonActive(false);
                    HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Negative, CreateString("Cancel"), "Back", null);
                    HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, CreateString("Confirm"), "Select", new UnityAction(async () => 
                        UpdateOrPublishToWorkshop(mod, tagsProvided)
                    ));
                    return;
                }
                Fail($"No local mod with GUID [{guid}] found!");
            }
            protected async void UpdateOrPublishToWorkshop(WildfrostMod mod, string[] tagsProvided)
            {
                WildfrostMod wildfrostMod = mod;
                List<Item> entries = (await new Query(UgcType.Items, UserUGCList.Published, UserUGCListSortOrder.CreationOrderDesc, SteamClient.SteamId).WithMetadata(b: true).WithTag("Mod").GetPageAsync(1)).Value.Entries.ToList().FindAll((Item a) => a.Result != Result.FileNotFound);
                Item curItem = entries.Find((Item a) => a.Metadata == mod.GUID);
                PublishResult result;
                if (entries.Count == 0 || curItem.Equals(new Steamworks.Ugc.Item()))
                {
                    Editor editor = Editor.NewCommunityFile;
                    editor = editor.WithTitle(wildfrostMod.Title);
                    editor = editor.WithDescription(wildfrostMod.Description);
                    editor = editor.WithTag("Mod");
                    foreach (var tag in tagsProvided)
                    {
                        editor = editor.WithTag(tag);
                    }
                    editor = editor.ForAppId(SteamClient.AppId);
                    editor = editor.WithPublicVisibility();
                    editor = editor.WithPreviewFile(wildfrostMod.IconPath);
                    editor = editor.WithContent(wildfrostMod.ModDirectory);
                    editor = editor.WithMetaData(wildfrostMod.GUID);
                    result = await editor.SubmitAsync();
                    Steamworks.Ugc.Item? async = await Steamworks.Ugc.Item.GetAsync(result.FileId);
                    foreach (string depend1 in wildfrostMod.Depends)
                    {
                        string depend = depend1;
                        Steamworks.Ugc.Item obj = entries.Find((Predicate<Steamworks.Ugc.Item>)(a => a.Metadata == depend));
                        if (!curItem.Equals(new Steamworks.Ugc.Item()) && async.HasValue)
                            async.GetValueOrDefault().AddDependency(obj.Id);
                    }
                    Debug.Log(("Upload result " + result.ToString()));
                    result = new PublishResult();
                    entries = (List<Steamworks.Ugc.Item>)null;
                    curItem = new Steamworks.Ugc.Item();
                }
                else
                {
                    Editor editor = new Editor(curItem.Id);
                    editor = editor.WithTitle(wildfrostMod.Title);
                    editor = editor.WithDescription(wildfrostMod.Description);
                    editor = editor.WithTag("Mod");
                    foreach (var tag in tagsProvided)
                        editor = editor.WithTag(tag);
                    editor = editor.ForAppId(SteamClient.AppId);
                    editor = editor.WithPublicVisibility();
                    editor = editor.WithPreviewFile(wildfrostMod.IconPath);
                    editor = editor.WithContent(wildfrostMod.ModDirectory);
                    editor = editor.WithMetaData(wildfrostMod.GUID);
                    result = await editor.SubmitAsync();
                    Steamworks.Ugc.Item? async = await Steamworks.Ugc.Item.GetAsync(result.FileId);
                    foreach (string depend2 in wildfrostMod.Depends)
                    {
                        string depend = depend2;
                        Steamworks.Ugc.Item obj = entries.Find((Predicate<Steamworks.Ugc.Item>)(a => a.Metadata == depend));
                        if (!curItem.Equals(new Steamworks.Ugc.Item()) && async.HasValue)
                            async.GetValueOrDefault().AddDependency(obj.Id);
                    }
                    Debug.Log(("Update result " + result.Result));
                    result = new PublishResult();
                    entries = (List<Steamworks.Ugc.Item>)null;
                    curItem = new Steamworks.Ugc.Item();
                }
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                /// Match either: Words between whitespace, Sentences in quotes, or Everything after last unmatched quote
                string regexPattern = @"(?:[\w.]+|\"".+?\""|\"".+?$)";
                string[] strArray = [..
                        Regex.Matches(currentArgs, regexPattern)
                        .Cast<Match>().Select(m => m.Value).DefaultIfEmpty("")
                    ];
                string typeName = strArray[0];
                bool autocomplete = currentArgs.LastOrDefault() == ' ';
                if (strArray.Length <= 1 && !autocomplete)
                {
                    IEnumerable<WildfrostMod> sourceMod = Bootstrap.Mods.Where(mod => mod.ModDirectory.Contains(Application.streamingAssetsPath) && mod.GUID.ToLower().Contains(typeName.ToLower()));
                    if (sourceMod.Any()) predictedArgs = sourceMod.Select(t => t.GUID).ToArray();
                    yield break;
                }
                else
                {
                    IEnumerable<WildfrostMod> sourceMod = Bootstrap.Mods.Where(mod => mod.ModDirectory.Contains(Application.streamingAssetsPath) && string.Equals(mod.GUID, strArray[0], StringComparison.CurrentCultureIgnoreCase));
                    if (sourceMod.Any())
                    {
                        WildfrostMod mod = sourceMod.First();
                        string lastTag = autocomplete ? "" : strArray.Last();
                        IEnumerable<string> source = tagsAll.Where(a => a.ToLower().Contains(lastTag.ToLower()));
                        var allArgs = autocomplete ? strArray.With(lastTag) : strArray;
                        predictedArgs = source.Select(tag => 
                            string.Join(" ", autocomplete ? strArray.With(tag) : strArray.RangeSubset(0, strArray.Length - 1).With(tag))
                        ).ToArray();
                    }
                }

            }

        }
    }
}