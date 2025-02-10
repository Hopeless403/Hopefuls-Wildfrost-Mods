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
public partial class ModUploader
{
    protected static async void UpdateOrPublishToWorkshop(WildfrostMod mod, string[] tagsProvided, string visbility = "Public")
    {
        string iconPath = mod.IconPath;
        if (File.Exists(Path.Combine(mod.ModDirectory, "icon.gif")))
            iconPath = Path.Combine(mod.ModDirectory, "icon.gif");

        if (!File.Exists(iconPath))
            File.WriteAllBytes(iconPath, new Texture2D(1, 1).EncodeToPNG());

        string configText = null;
        string configPath = Path.Combine(mod.ModDirectory, "config.cfg");
        if (File.Exists(configPath))
        {
            configText = File.ReadAllText(configPath);
            File.Delete(configPath);
        }

        string modDescription = mod.Description;
        if (File.Exists(Path.Combine(mod.ModDirectory, "desc.txt")))
            modDescription = File.ReadAllText(Path.Combine(mod.ModDirectory, "desc.txt"));

        Item curItem = (await GetPublishedItems()).Find((Item a) => a.Metadata == mod.GUID);

        Editor editor;
        if (PublishedItems.Count == 0 || curItem.Equals(default(Item)))
            editor = Editor.NewCommunityFile;
        else
            editor = new Editor(curItem.Id);

        editor = editor.WithTitle(mod.Title);
        editor = editor.WithDescription(modDescription);
        editor = editor.WithTag("Mod");
        foreach (var tag in tagsProvided)
            editor = editor.WithTag(tag);
        editor = editor.ForAppId(SteamClient.AppId);
        editor = visbility switch
        {
            "FriendsOnly" => editor.WithFriendsOnlyVisibility(),
            "Hidden" or "Private" => editor.WithPrivateVisibility(),
            "Unlisted" => editor.WithUnlistedVisibility(),
            _ => editor.WithPublicVisibility()
        };
        editor = editor.WithPreviewFile(iconPath);
        editor = editor.WithContent(mod.ModDirectory);
        editor = editor.WithMetaData(mod.GUID);
        var result = await editor.SubmitAsync();
        Steamworks.Ugc.Item? resultItem = await Steamworks.Ugc.Item.GetAsync(result.FileId);
        foreach (string depend in mod.Depends)
        {
            Steamworks.Ugc.Item obj = PossibleDependencies.Find(a => a.Metadata == depend);
            if (!curItem.Equals(new Steamworks.Ugc.Item()) && resultItem.HasValue)
            {
                Debug.LogWarning("Added dependency: " + depend);
                await resultItem.GetValueOrDefault().AddDependency(obj.Id);
            }
        }
        Debug.Log("Update result " + result.Result);
        if (result.Success)
        {
            PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Happy, Prompt.Emote.Position.Above);
            PromptSystem.instance.prompt.SetText(result.Result.ToString() + "!\n" + Localizers.Published_success);
        }
        else
        {
            PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Scared, Prompt.Emote.Position.Above);
            PromptSystem.instance.prompt.SetText(Localizers.Published_fail.Format(result.Result, FailedPublishResultText(result.Result)));
        }
        await Task.Delay(4000);
        PromptSystem.Hide();
        PublishedItems.Clear();

        if (configText != null)
            File.WriteAllText(configPath, configText);
    }

    public static string FailedPublishResultText(Result value)
        => value switch
        {
            Result.DuplicateName => "Name is not unique",
            Result.Timeout => "Operation timed out",
            Result.Banned => "You are VAC2 banned",
            Result.ServiceUnavailable => "The requested service is temporarily unavailable",
            Result.Pending => "Request is pending (may be in process, or waiting on third party)",
            Result.EncryptionFailure => "Encryption or Decryption failed",
            Result.Revoked => "Guest pass access has been revoked",
            Result.Expired => "Guest pass access has expired",
            Result.DuplicateRequest => "The request is a duplicate and the action has already occurred in the past, ignored this time",

            Result.Fail => Localizers.Result_Fail,
            Result.NoConnection => Localizers.Result_NoConnection,
            Result.FileNotFound => Localizers.Result_FileNotFound,
            Result.LimitExceeded => Localizers.Result_LimitExceeded,
            _ => "",
        };
}
