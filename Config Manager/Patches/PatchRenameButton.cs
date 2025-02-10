using HarmonyLib;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod
{
    public partial class ConfigManager
    {
        [HarmonyPatch(typeof(ModifierDisplayCurrent), nameof(ModifierDisplayCurrent.OnEnable))]
        internal class PatchRenameButton
        {
            public static bool initialising = false;
            public static bool initialised = false;
            static bool Prefix() => !initialising;

            internal static IEnumerator InitRenameSeq()
            {
                if (initialised) yield break;
                string sceneToCopyFrom = "UI" ?? "CharacterSelect";
                var isLoaded = SceneManager.IsLoaded(sceneToCopyFrom);
                initialising = true;

                if (!isLoaded) CoroutineManager.Start(SceneManager.Load(sceneToCopyFrom, SceneType.Temporary, false));
                yield return new WaitUntil(() => SceneManager.IsLoaded(sceneToCopyFrom));

                renameButton = Deckpack.instance.transform.root.FindRecursive("ButtonGroup").FindRecursive("Rename").gameObject.InstantiateKeepName();
                renameSeq = Deckpack.instance.transform.root.FindRecursive("Rename Card").gameObject.InstantiateKeepName();
                renameButton.SetActive(false);
                renameSeq.SetActive(false);
                GameObject.DontDestroyOnLoad(renameButton);
                GameObject.DontDestroyOnLoad(renameSeq);

                var t = renameButton.transform.ToRectTransform();
                {
                    t.localScale = 0.48f * Vector2.one;
                    t.anchoredPosition = t.anchoredPosition3D = new Vector2(0, 0);
                    t.anchorMin = t.anchorMax = new Vector2(1.25f, 1);
                    t.pivot = new Vector2(1, 0.5f);
                }

                renameSeq.transform.localScale = (0.5f) / (1.25f) * Vector3.one;
                renameSeq.GetComponentInChildren<TMP_InputField>().characterLimit = 0;
                renameSeq.GetComponentInChildren<RenameCompanionSequence>().Destroy();
                renameSeq.transform.Find("Background").gameObject.Destroy();

                renameButton.GetComponentsInChildren<Button>().Update(button => button.onClick = new());
                renameSeq.GetComponentsInChildren<Button>().Update(button => button.onClick = new());

                foreach (var i in renameSeq.transform.GetAllChildren())
                {
                    i.localScale *= 1.5f;
                    if (i.name != "CardHolder") i.localPosition += new Vector3(0.4f, 0);
                    if (i.name == "Cancel Button") i.localPosition += new Vector3(-0.5f, -0.2f);
                    if (i.name == "Confirm Button") i.localPosition += new Vector3(0.5f, -0.2f);
                }

                if (!isLoaded) CoroutineManager.Start(SceneManager.Unload(sceneToCopyFrom));
                initialising = false;
                initialised = true;
            }
        }
    }

}