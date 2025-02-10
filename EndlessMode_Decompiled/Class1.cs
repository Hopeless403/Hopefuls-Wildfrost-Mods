using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

#nullable enable
namespace WildFrostEndlessMode
{
    [BepInPlugin("WildFrost.Miya.EndlessMode", "EndlessMode", "0.1.0.0")]
    public class EndlessModeMod : BasePlugin
    {
        internal static EndlessModeMod Instance;
        private ConfigEntry<int> AmountOfLoops;

        public virtual bool Unload()
        {
            EndlessModeMod.Instance = (EndlessModeMod)null;
            return base.Unload();
        }

        public static IEnumerator StartIE()
        {
            yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)(() => ((Il2CppArrayBase<Object>)Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<CampaignGenerator>())).Length > 0)));
            Il2CppReferenceArray<Object> allCapmaings = Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<CampaignGenerator>());
            ManualLogSource log = EndlessModeMod.Instance.Log;
            string str1 = allCapmaings?.ToString();
            int num = ((Il2CppArrayBase<Object>)allCapmaings).Length;
            string str2 = num.ToString();
            string str3 = str1 + " with length of " + str2;
            log.LogInfo((object)str3);
            CampaignGenerator fullGen = ((Il2CppObjectBase)IArrayExt.ToList<Object>((Il2CppArrayBase<Object>)allCapmaings).Find<Object>((Predicate<Object>)(a => a.name == "CampaignGeneratorFull"))).Cast<CampaignGenerator>();
            TextAsset firstPreset = ((Il2CppArrayBase<TextAsset>)fullGen.presets)[0];
            string oldPresetName = ((Object)firstPreset).name;
            string[] presetArray = new string[4]
            {
        "brrcbrrsBrrsbirrbgrsBrbrr",
        " rr  rr  rrr  rr  r  r rr",
        "0000111122223333444455666",
        "0000000001111111111112222"
            };
            string finalText = "S";
            for (int i = 0; i < EndlessModeMod.Instance.AmountOfLoops.Value + 1; num = i++)
                finalText += presetArray[0];
            finalText += "FT";
            finalText += "\n";
            finalText += " ";
            for (int i = 0; i < EndlessModeMod.Instance.AmountOfLoops.Value + 1; num = i++)
                finalText += presetArray[1];
            finalText += "  ";
            finalText += "\n";
            finalText += "0";
            for (int i = 0; i < EndlessModeMod.Instance.AmountOfLoops.Value + 1; num = i++)
                finalText += presetArray[2];
            finalText += "78";
            finalText += "\n";
            finalText += "0";
            for (int i = 0; i < EndlessModeMod.Instance.AmountOfLoops.Value + 1; num = i++)
                finalText += presetArray[3];
            finalText += "22";
            firstPreset = new TextAsset(finalText);
            ((Object)firstPreset).name = oldPresetName;
            CampaignGenerator campaignGenerator = fullGen;
            Il2CppReferenceArray<TextAsset> cppReferenceArray = new Il2CppReferenceArray<TextAsset>(1L);
            ((Il2CppArrayBase<TextAsset>)cppReferenceArray)[0] = firstPreset;
            campaignGenerator.presets = cppReferenceArray;
        }

        public static IEnumerator AddArea0Node()
        {
            yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)(() => AddressableLoader.IsGroupLoaded("TraitData"))));
            yield return (object)AddressableLoader.LoadGroup("CampaignNodeType");
            CampaignNodeType t = Object.Instantiate<CampaignNodeType>(((Il2CppObjectBase)AddressableLoader.groups["CampaignNodeType"].list.ToArray()[0]).Cast<CampaignNodeType>());
            ((Object)t).name = "CampaignNodeAreaName0";
            t.letter = "area0";
            t.zoneName = "Loop";
            AddressableLoader.groups["CampaignNodeType"].lookup.Add(((Object)t).name, (Object)t);
            AddressableLoader.groups["CampaignNodeType"].list.Add((Object)t);
            EndlessModeMod.Instance.Log.LogInfo((object)("Added " + t?.ToString() + " " + t.letter));
        }

        public virtual void Load()
        {
            this.AmountOfLoops = this.Config.Bind<int>("", "AmountOfLoops", 0, "Amount of times the game will loop, be aware that the more the number, the more the game might/will lag.");
            ClassInjector.RegisterTypeInIl2Cpp<EndlessModeMod.Behaviour>();
            EndlessModeMod.Instance = this;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "WildFrost.Miya.EndlessMode");
            this.AddComponent<EndlessModeMod.Behaviour>();
            LeanTween.maxTweens *= this.AmountOfLoops.Value + 1;
        }

        public class Behaviour : MonoBehaviour
        {
            private void Start()
            {
                MonoBehaviourExtensions.StartCoroutine((MonoBehaviour)this, EndlessModeMod.StartIE());
                MonoBehaviourExtensions.StartCoroutine((MonoBehaviour)this, EndlessModeMod.AddArea0Node());
            }
        }
    }
}
