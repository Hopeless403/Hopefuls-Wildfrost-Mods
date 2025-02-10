using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.ProfileManager;

public partial class ProfileManagerModBehaviour : MonoBehaviour
{

    /// <summary>
    /// This is safe from trying to be loaded,
    /// as this class is deeper, so the modloader always sees
    /// the actual mod first then continues to the next assembly
    /// </summary>
    class ProfileDisplay(string profileName) : WildfrostMod(Path.Combine(Path.GetFullPath(SaveSystem.settings.FullPath) + "/../", SaveSystem.profileFolder, profileName))
    {
        public override string Title => title;
        public override string Description => desc;
        public override string[] Depends => [];
        public override string GUID => "profile." + title;
        internal string title = profileName;
        internal string desc = "";
        readonly string folderName = Path.Combine(SaveSystem.profileFolder, profileName);
        public ModHolder holder;

        List<string> unlockedProgress = new();

        public ProfileDisplay(string profileName, ModHolder holder) : this(profileName)
        {
            Debug.LogWarning(ModDirectory);
            this.holder = holder;
            HasLoaded = SaveSystem.Profile == profileName;
            HarmonyInstance.UnpatchSelf();
        }

        public IEnumerable<UnlockData> GetUnlocked(Predicate<UnlockData> match)
        {
            return from n in unlockedProgress
                   select AddressableLoader.Get<UnlockData>("UnlockData", n) into unlock
                   where unlock != null && unlock.IsActive && match(unlock)
                   select unlock;
        }
        public void Duplicate()
        {
            string date = DateTime.Today.ToShortDateString().Replace('/', '.');
            string newFolderName = $"{folderName} - {date}";
            if (ES3.DirectoryExists(newFolderName))
            {
                int i = 1;
                while (ES3.DirectoryExists($"{newFolderName} #{i}"))
                    i++;
                newFolderName = $"{newFolderName} #{i}";
            }
            ES3.CopyDirectory(folderName, newFolderName);
            CoroutineManager.Start(ProfileManagerModBehaviour.OnClick());
        }
        public void QuestionDelete()
        {
            CoroutineManager.Start(SceneManager.Unload("Mods"));
            Localizers.ShowPanel(Localizers.Panel_Format.Format(title));
            HelpPanelSystem.SetEmote(Prompt.Emote.Type.Scared);
            HelpPanelSystem.SetBackButtonActive(true);
            HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, Localizers.Buttons_cancel, "Back", null);
            HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Negative, Localizers.GetString("UI Text", "confirm"), "Select", Delete);
        }
        public void Delete()
        {
            ES3.DeleteDirectory(folderName);
            CoroutineManager.Start(ProfileManagerModBehaviour.OnClick());
        }
        public override void Load()
        {
            if (holder)
            {
                holder.transform.Find("Editor Buttons/Duplicate/Animator/Button")?.GetComponent<Button>()
                    .onClick.AddListener(Duplicate);
                holder.transform.Find("Editor Buttons/Delete/Animator/Button")?.GetComponent<Button>()
                    .onClick.AddListener(QuestionDelete);
            }



            unlockedProgress = SaveSystem.progressSaver.LoadValue("unlocked", folderName, new List<string>());
            string[] lastSavedModGUIDs = SaveSystem.progressSaver.LoadValue("lastSavedMods", folderName, new string[1] {"oops"});
            string[] lastSavedMods = lastSavedModGUIDs.Select(s => Bootstrap.Mods.FirstOrDefault(mod => mod.GUID == s)?.Title ?? "")
                .Where(s => !s.IsNullOrWhitespace() && s != ProfileManagerMod.Mod.GUID).ToArray();
            
            //CampaignStats stats = OverallStatsSystem.Get().Clone();
            var allUnlocks = AddressableLoader.GetGroup<UnlockData>("UnlockData");
            // Playtime: {GameStatData.FromSeconds(OverallStatsSystem.instance.stats.time+3600* OverallStatsSystem.instance.stats.hours)}

            desc = $"""
                <sprite="{ProfileManagerMod.Mod.GUID}" name=Hot Spring>{
                GetUnlocked(u => u.type == UnlockData.Type.Companion).Count()}/{
                MetaprogressionSystem.GetLockedCompanions(allUnlocks).Count

                }  <sprite="{ProfileManagerMod.Mod.GUID}" name=Inventor's Hut> {
                GetUnlocked(u => u.type == UnlockData.Type.Item).Count()}/{
                MetaprogressionSystem.GetLockedItems(allUnlocks).Count

                    }  <sprite="{ProfileManagerMod.Mod.GUID}" name=Pet House> {
                1+GetUnlocked(u => u.type == UnlockData.Type.Pet).Count()}/{
                MetaprogressionSystem.GetAllPets().Length

                    } <sprite="{ProfileManagerMod.Mod.GUID}" name=Challenge>{
                SaveSystem.progressSaver.LoadValue("completedChallenges", folderName, new List<string>()).Count}/{
                ChallengeSystem.GetAllChallenges().Count()
                    }
                """;
            desc += "\n" + Localizers.Mods.Format(string.Join(", ", lastSavedMods));
            _iconSprite = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").RandomItem().image;
        }

        /// <summary>
        /// Swap between profiles
        /// </summary>
        public static void Select(ModHolder holder)
        {
            if (SaveSystem.Profile != holder.Mod.Title)
            {
                WildfrostMod[] prevMods = [.. WildfrostMod.GetLastMods()];
                SaveSystem.SetProfile(holder.Mod.Title);
                textAsset.text = Localizers.Profile.Format(SaveSystem.Profile);
                foreach (var profile in profileHolders)
                {
                    profile.Mod.HasLoaded = holder == profile;
                    profile.UpdateSprites();
                }
                WildfrostMod[] newMods = [.. WildfrostMod.GetLastMods()];
                foreach (var mod in prevMods.Except(newMods))
                    if (mod.GUID != ProfileManagerMod.Mod.GUID)
                        mod.ModUnload();
                foreach (var mod in newMods.Except(prevMods)) mod.ModLoad();
            }
            holder.bellRinger.Ring();
        }
    }
}
