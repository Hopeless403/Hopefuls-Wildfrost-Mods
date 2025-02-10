using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        class UpdateDisplayer : MonoBehaviour
        {
            int num = 0;
            Dictionary<string, int> dict = new();
            public void OnEnable()
            {
                Events.OnSceneChanged += SceneChanged;
                Events.OnSceneUnload += SceneUnload;
            }
            public void OnDisable()
            {
                CreateUpdatePointForMods();
                Events.OnSceneChanged -= SceneChanged;
                Events.OnSceneUnload -= SceneUnload;
            }
            void SceneChanged(Scene scene)
            {
                if (scene.name != "MainMenu") return;
                dict = SaveSystem.LoadProgressData<Dictionary<string, int>>("hope.lastUpdate", new() { { Mod.GUID, lastUpdate } });
                if (!dict.TryGetValue(Mod.GUID, out int date) || date < lastUpdate)
                {
                    StartCoroutine(ShowRoutine("Another Console mod has updated!", changelog));
                }
            }
            void SceneUnload(Scene scene)
            {
                if (scene.name != "Mods") return;
                dict = SaveSystem.LoadProgressData<Dictionary<string, int>>("hope.lastUpdate", new() { { Mod.GUID, lastUpdate } });
                if (!dict.TryGetValue(Mod.GUID, out int date) || date < lastUpdate)
                {
                    StartCoroutine(ShowRoutine("Another Console mod has updated!", changelog));
                }
            }
            IEnumerator ShowRoutine(string title = "Another Console mod has updated!", string changelog = "")
            {
                if (num != 0) yield break;
                num++;
                //d.gameObject.SetActive(true);
                d.display.transform.FindRecursive("Title").GetComponent<TextMeshProUGUI>().text = title;
                d.display.transform.FindRecursive("Body").GetComponent<TextMeshProUGUI>().text = changelog;
                d.display.SetActive(true);
                if (d.scrollRect.transform is RectTransform transform && d.updates.Any())
                    transform.sizeDelta = transform.sizeDelta.WithY(d.updates[0].panelHeight);
                yield return new WaitForSeconds(0.35f);
                d.scrollRect.ScrollToTop();

                dict[Mod.GUID] = lastUpdate;
                SaveSystem.SaveProgressData("hope.lastUpdate", dict);
                enabled = false;
                gameObject.Destroy();
            }

            /// <summary>
            /// This will allow mods to check to show future updates
            /// </summary>
            static void CreateUpdatePointForMods()
            {
                var dict = SaveSystem.LoadProgressData<Dictionary<string, int>>("hope.lastUpdate", new() { { Mod.GUID, lastUpdate } });
                foreach (var mod in Bootstrap.Mods)
                {
                    if (!dict.TryGetValue(mod.GUID, out _))
                        dict[mod.GUID] = lastUpdate;
                }
                SaveSystem.SaveProgressData("hope.lastUpdate", dict);
            }
        }
    }
}