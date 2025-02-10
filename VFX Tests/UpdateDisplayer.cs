using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.IO;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Text.RegularExpressions;

namespace WildfrostHopeMod.VFX
{
    public partial class VFXMod : WildfrostMod
    {
        void UpdateDisplayer()
        {
            string mostRecentChangelog = "changelog-092024.txt";
            string title = "VFX Mod has updated!";
            string changelog = "This update notice only shows up if a local mod depends on VFX Mod. Thanks! See the <#ff0>Steam Workshop</color> page to see this again, or for any links mentioned here. The main changes are:\r\n\r\n<align=center><size=0.35><#ff0>Use APNGs or Sprites for status animations</size></align></color>\r\nYou can now use <#ff0>APNGs</color> (Animated PNGs) for partially transparent animations, or create one directly from <#ff0>Sprites</color>. Be careful if you use <#ff0>Ezgif.com</color>; it forces APNGs to get cropped weirdly...\r\n\r\nI find using <#ff0>apng-maker.NETLIFY.app</color> does better for this.\r\nPreview your APNGs' info here: <#ff0>davidmz.github.io/apng-js</color>\r\n\r\n<align=center><size=0.35><#ff0>Use addressable SpriteAtlases</size></align></color>\r\nThis is more of a suggestion. The entire Shrek movie gif loads in 1 sec this way (press the <#ff0>Credits</color> button!). For how to use addressables, check the <#ff0>Wildfrost Modding Documentation</color> on Using Addressables\r\n\r\n<align=center><size=0.35><#ff0>Status Icon helper</size></align></color>\r\nI wanted to fully make methods to create status icons, but I'm running out of free time... Instead, I only have the extension for StatusEffectDataBuilders called <#ff0>WithIcon_VFX()</color>. This assumes you've already made and registered the icon to CardManager.cardIcons!\r\n\r\n\r\n<size=0.35>Minor changes:</size>\r\n- Added a static event <#ff0>GIFLoader.OnEffectPlayed</color>\r\n- Added extensions <#ff0>spriteAsset.RegisterSpriteAsset()</color> and <#ff0>UnRegister</color>:\r\n     It gets registered to the fallbackSpriteAssets\r\n- New constructor for GIFLoader takes a mod:\r\n     Prefabs made with this GIFLoader will have the mod GUID prefixed.\r\n     Use a null mod for no prefix (as before)\r\n- Credited the Shrek movie";
            
            /// We detect whether to show the changelog by the existence of a txt file in the mod directory
            /// !! Make sure to delete the changelog locally before uploading !!
            /// Note that players resubscribing to the mod will see it again
            if (File.Exists(RelToAbsPath(mostRecentChangelog)))
                return;

            bool shouldShow = true; // set true by default

            /// Optionally set it false as needed
            DirectoryInfo modsDirectory = new DirectoryInfo(Path.Combine(Application.streamingAssetsPath, "Mods"));
            bool IsLocalAndDepends(WildfrostMod mod)
                => new DirectoryInfo(mod.ModDirectory).Parent.FullName == modsDirectory.FullName
                && mod.Depends.Contains(this.GUID);
            /// True only if there is some local mod depending on this
            shouldShow = Bootstrap.Mods.Any(IsLocalAndDepends);

            /// Everything below can be left unchanged

            GameUpdateDisplayer displayer = Resources.FindObjectsOfTypeAll<GameUpdateDisplayer>().FirstOrDefault();
            displayer.display.transform.FindRecursive("Title").GetComponent<TextMeshProUGUI>().text = title;
            displayer.display.transform.FindRecursive("Body").GetComponent<TextMeshProUGUI>().text = changelog;

            /// This doesn't run yet. We're just "naming" this code for later
            IEnumerator ShowRoutine()
            {
                displayer.gameObject.SetActive(true);
                displayer.display.SetActive(true);
                if (displayer.scrollRect.transform is RectTransform transform && displayer.updates.Any())
                    transform.sizeDelta = transform.sizeDelta.WithY(displayer.updates[0].panelHeight);
                yield return new WaitForSeconds(0.35f);
                displayer.scrollRect.ScrollToTop();
            }

            if (shouldShow)
            {
                /// If player manually loaded the mod, show after exiting mod menu
                if (SceneManager.IsLoaded("MainMenu")) CoroutineManager.Start(ShowRoutine());
                /// Else if the mod loaded automatically, show on entering main menu
                else Events.OnGameStart += () => CoroutineManager.Start(ShowRoutine());
            }

            /// This doesn't run yet. We're just "naming" this code for later
            /// Gets rid of all tags that look like <tag> or </tag>
            string Parse(string str)
            {
                Regex rich = new Regex(@"<[^>]*>");
                return !rich.IsMatch(str) ? str : rich.Replace(str, string.Empty);
            }
            string parsedText = Parse(changelog);
            File.WriteAllText(RelToAbsPath(mostRecentChangelog), parsedText);
        }
    }
}