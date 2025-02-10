using System.Collections;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using Object = System.Object;
using Random = UnityEngine.Random;

namespace WildFrostEndlessMode;

public static class Extensions
{
    public static T Find<T>(this Il2CppSystem.Collections.Generic.List<T> l, Predicate<T> p)
    {
        for (int i = 0; i < l.Count; i++)
        {
            T item = l.ToArray()[i];
            EndlessModeMod.Instance.Log.LogInfo(item+" "+i);
            if (p(item))
            {
                return item;
            }
        }

        return default;
    }
}

[BepInPlugin("WildFrost.Miya.EndlessMode", "EndlessMode", "0.1.0.0")]
public class EndlessModeMod  : BasePlugin
{
    internal static EndlessModeMod Instance;

    public override bool Unload()
    {
        Instance = null;
        return base.Unload();
    }

    

    

  
    public static IEnumerator StartIE()
    {
    
        yield return new WaitUntil((Func<bool>) (() =>
            UnityEngine.Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<CampaignGenerator>()).Length>0));
        var allCapmaings = UnityEngine.Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<CampaignGenerator>());
        Instance.Log.LogInfo(allCapmaings+" with length of "+allCapmaings.Length);
        CampaignGenerator fullGen=allCapmaings.ToList()
            .Find<UnityEngine.Object>((delegate(UnityEngine.Object a)
            {
                return a.name == "CampaignGeneratorFull";
            })).Cast<CampaignGenerator>();
        var firstPreset = fullGen.presets[0];
        var oldPresetName = firstPreset.name;
        string[] presetArray = new[]
        {
            "brrcbrrsBrrsbirrbgrsBrbrr", " rr  rr  rrr  rr  r  r rr", "0000111122223333444455666",
            "0000000001111111111112222"
        }; ;
        string finalText = "S";
        for (int i = 0; i < Instance.AmountOfLoops.Value+1; i++)
        {
            finalText += presetArray[0];
        }
        finalText += "FT";
        finalText += "\n";
        finalText += " ";
        for (int i = 0; i < Instance.AmountOfLoops.Value+1; i++)
        {
            finalText += presetArray[1];
        }
        finalText += "  ";
        finalText += "\n";
        finalText += "0";
        for (int i = 0; i < Instance.AmountOfLoops.Value+1; i++)
        {
            finalText += presetArray[2];
        }
        finalText += "78";
        finalText += "\n";
        finalText += "0";
        for (int i = 0; i < Instance.AmountOfLoops.Value+1; i++)
        {
            finalText += presetArray[3];
        }
        finalText += "22";
        firstPreset=new TextAsset(finalText
            );
        firstPreset.name =oldPresetName;
        fullGen.presets = new Il2CppReferenceArray<TextAsset>(1)
        {
            [0] = firstPreset
        };
    }

    public static IEnumerator AddArea0Node()
    {
        yield return new WaitUntil((Func<bool>) (() =>
            SceneManager.IsLoaded("Town")));
        yield return AddressableLoader.LoadGroup("CampaignNodeType");
        CampaignNodeType t =UnityEngine.Object.Instantiate( AddressableLoader.groups["CampaignNodeType"].list.ToArray()[0].Cast<CampaignNodeType>());
        t.name = "CampaignNodeAreaName0";
        t.letter = "area0";
        t.zoneName = "Loop";
        AddressableLoader.groups["CampaignNodeType"].lookup.Add(t.name,t);
        AddressableLoader.groups["CampaignNodeType"].list.Add(t);
        Instance.Log.LogInfo("Added "+t+" "+t.letter);

    }
    public class Behaviour : MonoBehaviour
    {
        private void Start()
        {
            this.StartCoroutine(StartIE());
            this.StartCoroutine(AddArea0Node());
        }
    }
    private ConfigEntry<int> AmountOfLoops;
    public override void Load()
    {
        AmountOfLoops = Config.Bind("",
            "AmountOfLoops",
            0,
            "Amount of times the game will loop, be aware that the more the number, the more the game might/will lag.");

        ClassInjector.RegisterTypeInIl2Cpp<Behaviour>();
        Instance = this;
        /// area1 = area 2
        /// area2 = area 3
        /// b = battle
        /// B = boss battle
        /// u = charm
        /// @ = charm shop
        /// 6 = charm tutorial
        /// k = clunk shop
        /// c = companion
        /// 9 = companion tutorial
        /// + = copy item
        /// j = curse items
        /// 0 = detail1
        /// 1 = detail2
        /// 2 = detail3
        /// F = final boss
        /// T = final final boss (true final boss)
        /// g = gold
        /// i = item
        /// 8 = tutorial1
        /// 7 = tutorial2
        /// Ⅰ = journal page one
        /// Ⅱ = journal page two
        /// Ⅲ = journal page three
        /// Ⅳ = journal page four
        /// Ⅴ = journal page five
        /// Ⅵ = journal page six
        /// m = muncher
        /// r = reward
        /// s = shop
        /// S = start
        Harmony.CreateAndPatchAll(System.Reflection.Assembly.GetExecutingAssembly(), "WildFrost.Miya.EndlessMode");
        AddComponent<Behaviour>();
        LeanTween.maxTweens *= AmountOfLoops.Value + 1;


    }
}