// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchNullCheckForRewards
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (CharacterRewards), "Add", new System.Type[] {typeof (RewardPool)})]
  internal class PatchNullCheckForRewards
  {
    public static bool queuedWarning = false;
    private static string key = "websiteofsites.wildfrost.pokefrost.unloadwarningkey";
    private static string yesKey = "websiteofsites.wildfrost.pokefrost.unloadwarningyeskey";
    private static string noKey = "websiteofsites.wildfrost.pokefrost.unloadwarningnokey";

    private static void Prefix(RewardPool rewardPool)
    {
      for (int index = rewardPool.list.Count - 1; index >= 0; --index)
      {
        if ((UnityEngine.Object) rewardPool.list[index] == (UnityEngine.Object) null)
        {
          rewardPool.list.RemoveAt(index);
          if (!PatchNullCheckForRewards.queuedWarning)
          {
            Debug.LogError((object) "[Pokefrost] Null Rewards!");
            MonoBehaviourSingleton<References>.instance.StartCoroutine(PatchNullCheckForRewards.PromptWarning());
            PatchNullCheckForRewards.queuedWarning = true;
          }
        }
      }
    }

    public static IEnumerator PromptWarning()
    {
      if (!PatchNullCheckForRewards.queuedWarning)
      {
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.IsLoaded("MapNew")));
        StringTable ui = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
        HelpPanelSystem.Show(ui.GetString(PatchNullCheckForRewards.key));
        HelpPanelSystem.SetEmote(Prompt.Emote.Type.Scared);
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, ui.GetString(PatchNullCheckForRewards.yesKey), "Select", (UnityAction) null);
        HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Negative, ui.GetString(PatchNullCheckForRewards.noKey), "Back", (UnityAction) null);
        PatchNullCheckForRewards.queuedWarning = false;
      }
    }

    [PokeLocalizer]
    public static void DefineStrings()
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(PatchNullCheckForRewards.key, "Unloading Anomolies Detected|Bugs may be appear during gameplay. For the best experience, please restart Wildfrost.|-[Pokefrost]");
      collection.SetString(PatchNullCheckForRewards.yesKey, "Of course!");
      collection.SetString(PatchNullCheckForRewards.noKey, "No way!");
    }
  }
}
