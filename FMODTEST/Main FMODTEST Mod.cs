using Deadpan.Enums.Engine.Components.Modding;
using FMOD.Studio;
using FMODUnity;
using HarmonyLib;
using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

namespace FMODTEST
{
    public partial class FMODTESTMod : WildfrostMod
    {
        // it should be named this to show up as a Singleton in UnityExplorer
        public static FMODTESTMod instance;
        public FMODTESTMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.FMODTEST";
        public override string[] Depends => new string[] { };
        public override string Title => "FMODTEST";
        public override string Description => $"TODO: Need to move the patches for loading banks and the one for loading music save data";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static Transform prefabParent;

        public class PlatformMod : PlatformWindows
        {

            public WildfrostMod mod = new InternalMod(null);
            public PlatformMod WithMod(WildfrostMod mod)
            {
                this.mod = mod;
                this.Identifier = mod.GUID;
                return this;
            }
            public override string DisplayName => mod?.Title;
            public override string GetBankFolder()
            {
                if (mod != null)
                    return Path.Combine(mod.ModDirectory, "audio");
                return base.GetBankFolder();
            }
        }

        [HarmonyPatch]
        public class PatchWhyDoesBattleMusicSystemNotSaveStates
        {
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.BuildBattleState))]
            public static void BuildBattleState(BattleSaveSystem __instance)
            {
                Debug.LogWarning("Building battle state");
                BattleMusicSystem musicSystem = UnityEngine.Object.FindObjectOfType<BattleMusicSystem>();
                if (musicSystem) Debug.LogWarning("We should be saving music...");
                else Debug.LogError("Music system is gone?!?");
            }
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleMusicSystem), nameof(BattleMusicSystem.Save))]
            public static void SaveBattleMusicSystem(BattleMusicSystem __instance)
            {
                Debug.LogWarning("saving music state");
                Debug.Log($"intensity: {__instance.intensity}");
            }
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.LoadRoutine))]
            public static void LoadRoutine(BattleSaveSystem __instance)
            {
                Debug.LogWarning($"Loading battle state {__instance.state}");
                Debug.Log($"saved intensity: {__instance.state?.battleMusicState?.intensity}");
                BattleMusicSystem musicSystem = UnityEngine.Object.FindObjectOfType<BattleMusicSystem>();
                if (musicSystem) Debug.LogWarning("We should be loading music...");
                else Debug.LogError("Music system is gone?!?");
            }
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleMusicSystem), nameof(BattleMusicSystem.Load))]
            public static void LoadBattleMusicSystem(BattleMusicSystem __instance, BattleMusicSaveData state)
            {
                Debug.LogWarning("loading music state");
                Debug.LogWarning((
                    BattleMusicSystem.IsRunning(__instance.current), 
                    __instance.bossEntered == state.bossEntered, 
                    __instance.bossPhase == state.bossPhase));

                Debug.LogError($"intensity: {__instance.intensity} -> {state.intensity}");
            }
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleMusicSystem), nameof(BattleMusicSystem.IsBossBattle))]
            public static void IsBossBattle(BattleMusicSystem __instance)
            {
                Debug.LogWarning("passed the return");
            }
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleMusicSystem), nameof(BattleMusicSystem.IsRunning))]
            public static bool LoadProperly(BattleMusicSystem __instance, ref bool __result)
            {
                Debug.Log("Checking for running");
                var frames = new System.Diagnostics.StackTrace(fNeedFileInfo: true).GetFrames();
                if (frames.Length >= 3)
                {
                    MethodBase method = frames[2].GetMethod();
                    Debug.Log("Got method " + method.FullDescription());
                    if (method.DeclaringType == typeof(BattleMusicSystem) && method.GetParameters().All(p => p.ParameterType == typeof(BattleMusicSystem) || p.ParameterType == typeof(BattleMusicSaveData)))
                    {
                        return __result = false;
                    }
                }
                return true;
            }
            [HarmonyPrefix]
            [HarmonyPatch(typeof(BattleMusicSystem), nameof(BattleMusicSystem.SetIntensity))]
            public static void SetIntensity(BattleMusicSystem __instance, int amount)
            {
                Debug.LogWarning($"Setting intensity to: {amount}");
            }

        }
        public static readonly FieldInfo f_currentPlatform = AccessTools.Field(typeof(RuntimeManager), "currentPlatform");
        public static FMOD.RESULT LoadFMOD(WildfrostMod mod)
        {
            var ___instance = Resources.FindObjectsOfTypeAll<RuntimeManager>().First();
            var originalPlatform = f_currentPlatform.GetValue(___instance);
            var moddedPlatform = ScriptableObject.CreateInstance<PlatformMod>().WithMod(mod);

            f_currentPlatform.SetValue(___instance, moddedPlatform);
            try
            {
                string audioDirectory = mod.RelToAbsPath("audio");
                foreach (var file in Directory.GetFiles(audioDirectory, "*.bank").OrderBy(p => p.Contains("Master")))
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    Debug.LogWarning($"Loading bank: {fileName}");
                    RuntimeManager.LoadBank(fileName);
                }
            }
            finally
            {
                f_currentPlatform.SetValue(___instance, originalPlatform);
            }
            return FMOD.RESULT.OK;
        }
        public static FMOD.RESULT UnloadFMOD(WildfrostMod mod)
        {
            string audioDirectory = mod.RelToAbsPath("audio");
            foreach (var file in Directory.GetFiles(audioDirectory, "*.bank").OrderBy(p => p.Contains("Master")))
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                Debug.LogWarning($"Unloading bank: {mod.GUID}.{fileName}");
                RuntimeManager.UnloadBank($"{mod.GUID}.{fileName}");
            }
            return FMOD.RESULT.OK;
        }

        public EventReference GetEventReference(string path)
        {
            EventReference result = RuntimeManager.PathToEventReference(path);
            if (!result.IsNull) return result;

            result = RuntimeManager.PathToEventReference($"event:/{GUID}/{path}");
            if (!result.IsNull) return result;

            result = RuntimeManager.PathToEventReference($"event:/{path}");
            return result;
        }

        public override void Load()
        {
            base.Load();
            LoadFMOD(this);

            var e = GetEventReference("Music/Chaos Alpha");
            if (e.IsNull) e = GetEventReference("hope.wildfrost.vfx/Music/Chaos Alpha");
            var finalBattle = Get<CampaignNodeType>("CampaignNodeFinalBoss") as CampaignNodeTypeBattle;
            finalBattle.overrideMusic = e;
            Debug.LogWarning("Final boss music is now " + e.IsNull);

            var e2 = GetEventReference("Music/Tankers Dwelling");
            if (e2.IsNull) e2 = GetEventReference("hope.wildfrost.vfx/Music/Tankers Dwelling");
            foreach (var area in References.Areas)
            {
                Debug.Log("For area " + area);
                if (e.IsNull || e2.IsNull)
                    Debug.LogError("Something went wrong...");
                else
                {
                    area.battleMusicEvent = e;
                    area.minibossMusicEvent = default;
                }
            }

            var e3 = GetEventReference("UI/Bell Ring");
            foreach (var bell in AddressableLoader.GetGroup<GameModifierData>(nameof(GameModifierData)))
            {
                Debug.LogWarning(bell);
                bell.ringSfxEvent = e3;
            }

            var musicSystem = GameObject.FindObjectOfType<BattleMusicSystem>();
            musicSystem.winJingle = GetEventReference("SFX/Challenge Clear!");
        }

        public override void Unload()
        {
            base.Unload();
            UnloadFMOD(this);
        }




        public void LoadTest()
        {
            FMODUnity.RuntimeManager.StudioSystem.getBankList(out FMOD.Studio.Bank[] banks);
            Debug.LogWarning("Preload: " + banks.Join(b => { b.getID(out var id2); return id2.ToString(); }));
            base.Load();

            Debug.Log(FMODUnity.Settings.Instance);
            var manager = Resources.FindObjectsOfTypeAll<RuntimeManager>().First();

            FMODUnity.Settings.AddPlatformTemplate<PlatformMod>(this.GUID);
            var modPlatform = FMODUnity.Settings.PlatformTemplates.Find(p => p.Identifier == this.GUID).CreateInstance();


            foreach (var g in GameObject.FindObjectOfType<AudioSettingsSystem>().buses)
            {
                g.bus.getID(out var idd);
                Debug.Log((g.name, idd));
            }
            string path2 = Path.Combine(ModDirectory, "audio");
            /*foreach (var file in Directory.GetFiles(path, "*.bank").OrderBy(p => p.Contains("Master")))
            {
                
                RuntimeManager.StudioSystem.loadBankFile(file, LOAD_BANK_FLAGS.NORMAL, out var bank);
                AccessTools.Method(typeof(RuntimeManager), "loadedBankRegister")
                    .Invoke(manager, )
            }*/

            FMODUnity.RuntimeManager.StudioSystem.getBankList(out banks);
            /*var manager = Resources.FindObjectsOfTypeAll<RuntimeManager>().First();
            var dict = AccessTools.Field(typeof(RuntimeManager), "loadedBanks").GetValue(manager) as IDictionary;
            var lbank = dict.Values.Cast<ValueType>().Last();
            var bank = (FMOD.Studio.Bank)lbank.GetType().GetField("Bank").GetValue(lbank);*/

            for (int i = 0; i < banks.Length - 4; i++)
            {
                var bank = banks.ToList().Reverse<Bank>().ToList()[i];
                bank.getID(out var id);
                Debug.LogError(id);
                bank.getBusList(out var buses);
                Debug.LogWarning($"buses: {buses.Length}");

                bank.getEventList(out var eventList);
                var list = eventList.Select(desc => { desc.getLength(out int l); return l; });
                foreach (var e in eventList)
                {
                    e.getID(out id);
                    e.getPath(out var path);
                    e.getLength(out int ik);
                    Debug.LogWarning((path, id, ik));
                    RuntimeManager.PlayOneShot(id);
                    break;
                }
                Debug.LogWarning((buses.Join(), eventList.Join(), id));
                if (buses.Length > 0)
                {
                    buses[0].getID(out id);
                    Debug.Log(id);
                }
            }

            var result = RuntimeManager.StudioSystem.getBusByID(new FMOD.GUID(new Guid("d320eb98-3d4a-4cd9-a001-fdb4e071c58e")), out var bussy);
            Debug.LogError((result, bussy.isValid()));

            foreach (var g in GameObject.FindObjectOfType<AudioSettingsSystem>().buses)
            {
                g.bus.getID(out var idd);
                Debug.Log((g.name, idd));
            }
            GameObject.FindObjectOfType<AudioSettingsSystem>().busLookup["Master"].bus.getID(out var id3);
            Debug.LogError(id3);
            Debug.LogWarning(banks.Join(b => { b.getID(out var id2); return id2.ToString(); }));
        }







        public void Log(object message) => Debug.Log($"[{Title}] {message}");
        public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
        public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

        public static List<object> assets = new List<object>();
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }
    }
}