using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using WildfrostHopeMod.Text;
using WildfrostHopeMod.Utils;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using Dir = System.IO.Directory;
using WildfrostHopeMod.VFX;
using Deadpan.Enums.Engine.Components.Modding;
using System.Runtime.InteropServices.ComTypes;
using static SfxSystem;
using FMOD.Studio;

namespace WildfrostHopeMod.SFX
{
    

    public static class HopeSFXSystem
    {
        public static EventReference PathToEventReference(string path)
        {
            //FMODUnity.RuntimeManager.CreateInstance()
            FMODUnity.RuntimeManager.CoreSystem.createSoundGroup("test group", out var soundGroup);
            //soundGroup.
            FMODUnity.RuntimeManager.CoreSystem.getMasterSoundGroup(out var soundGroup1);
            Debug.LogWarning(soundGroup1.hasHandle());
            //soundGroup1.
            Debug.LogWarning(soundGroup1.getName(out string name, 5));
            Debug.LogWarning(name);

            EventReference e;
            EventInstance i;
            FMOD.Sound s;
            return VFXMod.testReference;
        }

        internal class PatchInterpretEventReference
        {

        }





        internal static readonly Dictionary<string, FMOD.Sound> sounds = new();
        internal static readonly Dictionary<string, FMOD.Sound> whenHitSounds = new();
        internal static readonly Dictionary<string, FMODUnity.EventReference> eventRefs = new();

        //[HarmonyPatch(typeof(Console), nameof(Console.Commands))]
        [HarmonyPatch(typeof(Console), nameof(Console.PopulateHelp))]
        internal class PatchAddCommandCreateSFX
        {
            public static void Prefix()
            {
                if (Console.commands == null)
                    return;

                foreach (var command in new List<Console.Command>{
                    new CommandCreateSFX(),
                    new CommandStopSFX(),
                
                })
                {
                    Console.commands.RemoveAllWhere(c => c.id == command.id);
                    MonoBehaviour.print(command.id);
                    Console.commands.Add(command);
                }
            }
        }
        internal class CommandCreateSFX : Console.Command
        {
            public override string id => "create sfx";
            public override string format => "create sfx <name>";
            public readonly List<string> events = new();
            public static FMOD.Sound running { get; internal set; }
            string[] GetOptions()
            {
                events.Clear();
                if (!events.Any())
                {
                    RuntimeManager.StudioSystem.getBankList(out FMOD.Studio.Bank[] banks);
                    foreach (var bank in banks)
                    {
                        bank.getEventList(out var events);
                        foreach (var e in events)
                        {
                            e.getPath(out string path);
                            if (path.IsNullOrEmpty()) continue;
                            this.events.Add(path.Replace("event:", ""));
                        }
                    }
                }
                return sounds.Keys.Concat(events).ToArray();
            }

            public override void Run(string args)
            {
                //Debug.LogWarning(GetOptions().Join());
                IEnumerable<string> source = GetOptions().Where(a => string.Equals(a, args, StringComparison.CurrentCultureIgnoreCase));
                if (source.Any())
                {
                    string str = source.First();
                    if (events.Contains(str))
                    {
                        RuntimeManager.PlayOneShot("event:" + str);
                    }
                    else
                    {
                        running = sounds[str];
                        SFXLoader.PlaySound(running);
                    }
                }
                else Fail("Sound [" + args + "] does not exist!");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                predictedArgs = default;
                yield return null;
                IEnumerable<string> source = GetOptions().Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                if (source.Any()) predictedArgs = source.ToArray();
            }
        }
        internal class CommandStopSFX : Console.Command
        {
            public override string id => "stop sfx";
            public override void Run(string args)
            {
                if (CommandCreateSFX.running.hasHandle())
                {
                    CommandCreateSFX.running.release();
                }
                else Fail("It's already stopped dumdum");
            }

        }
    }
    public class SFXLoader
    {
        public SFXLoader(string directory, bool lookThroughSubfolders = true, bool initialize = true)
        { 
            Directory = directory; 
            LookThroughSubfolders = lookThroughSubfolders; 
            if (initialize) Initialize();
            
        }

        internal static FMOD.System system = FMODUnity.RuntimeManager.CoreSystem;

        public static FMOD.ChannelGroup GetChannelGroup(PlayAs playAs = PlayAs.SFX) => 
            GameObject.FindObjectOfType<AudioSettingsSystem>().busLookup[playAs.ToString()].channelGroup;


        //public bool InitOnLoad { get; }
        // include logic for different (mod) directories + lookup? later
        public string Directory { get; }
        public bool LookThroughSubfolders { get; }
        /// <summary>
        /// Leave empty to load all files in .directory except subfolders
        /// </summary>
        public string[] extensionsToLoad = new string[] { "wav", "mp3", "ogg" };

        /// <summary>
        /// Automatically filled whenever any LoadSound..() is called
        /// </summary>
        public readonly Dictionary<string, FMOD.Sound> sounds = new();

        /*public void Initialize()
        {
            Debug.Log("[SFX Tools] SFX Init");
            SearchOption s = LookThroughSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            extensionsToLoad.Update(ext =>
                LoadSoundsFromPaths(Dir.GetFiles(Directory, "*." + ext, s))
            );
            RegisterAllSoundsToGlobal();
            Debug.LogWarning($"[SFX Tools] SFX Init result: {(sounds.Any() ? string.Join(", ", sounds.Keys) : "None loaded")}");
        }*/

        public async void Initialize()
        {
            Debug.Log("[SFX Tools] SFX Init");
            SearchOption s = LookThroughSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            LoadSoundsFromDir(Directory);
            /*foreach (var ext in extensionsToLoad)
            {
                Debug.LogError(ext);
                foreach (var path in Dir.GetFiles(Directory, "*." + ext, s))
                {
                    Debug.LogError(path);
                    if (!File.Exists(path))
                        throw new FileNotFoundException($"[SFX Tools] {path} doesn't exist!");
                    
                    LoadSoundFromPath()
                    system.createSound(path, true ? FMOD.MODE.LOOP_NORMAL : FMOD.MODE._2D, out FMOD.Sound sound);
                    RegisterSound(Path.GetFileNameWithoutExtension(path), sound);
                    //RegisterSoundToGlobal(Path.GetFileNameWithoutExtension(path), sound);
                }
            }*/
            /*List<Task> taskAll = new();
            foreach (var ext in extensionsToLoad)
            {
                foreach (var path in Dir.GetFiles(Directory, "*." + ext, s))
                {
                    if (!File.Exists(path))
                        throw new FileNotFoundException($"[SFX Tools] {path} doesn't exist!");
                    taskAll.Add(Task.Run(() => { RegisterSoundToGlobal(Path.GetFileNameWithoutExtension(path), LoadSoundFromPath(path)); }));
                }
            }
            await Task.WhenAll(taskAll);*/
            Debug.LogWarning($"[SFX Tools] SFX Init result: {(sounds.Any() ? string.Join(", ", sounds.Keys) : "None loaded")}");
        }

        //public void RegisterSounds(FMOD.Sound[] sounds) => sounds.Update(this.sounds[])
        public void RegisterSound(string name, FMOD.Sound sound) => sounds[name] = sound;

        public static void RegisterSoundToGlobal(string name, FMOD.Sound sound)
        {
            HopeSFXSystem.sounds[name] = sound;
            SfxSystem.cooldownTimers[name] = 0.05f;
            SfxSystem.cooldowns[name] = new SfxSystem.Cooldown(name, 0.05f);
        }
        public static void RegisterSoundToGlobal(string name, FMOD.Sound sound, float cooldown)
        {
            HopeSFXSystem.sounds[name] = sound;
            SfxSystem.cooldownTimers[name] = cooldown;
            SfxSystem.cooldowns[name] = new SfxSystem.Cooldown(name, cooldown);
        }
        public void RegisterAllSoundsToGlobal() => sounds.Update(s => RegisterSoundToGlobal(s.Key, s.Value));


        /// <summary>
        /// By default looks for wav, mp3 or ogg files
        /// </summary>
        /// <param name="dirPath"></param>
        /// <returns>Automatically goes into SFXLoader.sounds</returns>
        public List<FMOD.Sound> LoadSoundsFromDir(string dirPath) => LoadSoundsFromDir(dirPath, extensionsToLoad);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="extensions">without the dot, i.e. "wav"</param>
        /// <returns>Automatically goes into SFXLoader.sounds</returns>
        public List<FMOD.Sound> LoadSoundsFromDir(string dirPath, params string[] extensions) => extensions.SelectMany(ext =>
                    LoadSoundsFromPaths(Dir.GetFiles(dirPath, "*." + ext, SearchOption.TopDirectoryOnly))).ToList();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paths"></param>
        /// <returns>Automatically goes into SFXLoader.sounds</returns>
        public List<FMOD.Sound> LoadSoundsFromPaths(string[] paths) => paths.Select(path => LoadSoundFromPath(path)).ToList();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Automatically goes into SFXLoader.sounds</returns>
        /// <exception cref="Exception">The FMOD.Result of createSound</exception>
        public FMOD.Sound LoadSoundFromPath(string path, bool loop = false)
        {
            var sound = CreateSound(path, loop);
            sounds[Path.GetFileNameWithoutExtension(path)] = sound;
            Debug.Log($"[SFX Tools] Loaded {sound} from path {path}");
            return sound;
        }
        public FMOD.Sound LoadSound(string name, bool loop = false)
        {
            var path = Dir.GetFiles(Directory, $"{name}.*").First();
            return LoadSoundFromPath(path, loop);
        }


        public static FMOD.Sound CreateSound(string path, bool loop = false)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"[SFX Tools] {path} doesn't exist!");

            if (Path.GetExtension(path) == ".mid")
                Debug.LogError("[SFX Tools] Warning: Adding MIDIs doesn't work for all systems. If ERR_PLUGIN_RESOURCE is thrown, this is why.");

            var result = system.createSound(path, loop ? FMOD.MODE.LOOP_NORMAL : FMOD.MODE._2D, out FMOD.Sound sound);
            if (result != FMOD.RESULT.OK) throw new Exception(result.ToString());
            return sound;
        }
        public FMOD.Channel TryPlaySoundFromPath(string path, PlayAs playAs = PlayAs.SFX)
        {
            if (!sounds.ContainsKey(Path.GetFileNameWithoutExtension(path)))
                LoadSoundFromPath(path);
            return TryPlaySound(Path.GetFileNameWithoutExtension(path), playAs);
        }

        /// <summary>
        /// Plays the sound from SFXLoader.sounds if it exists
        /// </summary>
        /// <param name="key">The filename without extension</param>
        /// <returns>true if OK; otherwise false</returns>
        public FMOD.Channel TryPlaySound(string key, PlayAs playAs = PlayAs.SFX)
        {
            if (sounds.TryGetValue(key, out FMOD.Sound sound))
            {
                return PlaySound(sound, playAs);
            }
            else Debug.LogWarning($"[SFX Tools] Key [{key}] doesn't exist");
            return default;
        }
        public static FMOD.Channel PlaySound(FMOD.Sound sound, PlayAs playAs = PlayAs.SFX)
        {
            var channelGroup = GetChannelGroup(playAs);
            var result = system.playSound(sound, channelGroup, false, out FMOD.Channel channel);
            channel.setVolume(AudioSettingsSystem.GetVolume(playAs.ToString()) * AudioSettingsSystem.GetVolume("Master"));
            var handler = AudioChangeHandlerBuilder(channel, playAs);
            Events.OnSettingChanged += handler;
            CoroutineManager.Start(RemoveOnEnd(handler, channel));
            if (result == FMOD.RESULT.OK) return channel;
            Debug.LogError(result.ToString());
            return default;
        }

        static UnityAction<string, object> AudioChangeHandlerBuilder(FMOD.Channel channel, PlayAs playAs) =>
            new UnityAction<string, object>((name, val) =>
            {
                Debug.LogWarning($"Volume {playAs.ToString().ToTitleCase()} {val}");
                if (name == "Volume" + playAs.ToString().ToLowerInvariant().ToTitleCase() || name == "VolumeMaster")
                channel.setVolume((float)val * AudioSettingsSystem.GetVolume("Master"));
            });
        static IEnumerator RemoveOnEnd(UnityAction<string, object> handler, FMOD.Channel channel)
        {
            yield return new WaitUntil(() => !channel.hasHandle());
            Events.OnSettingChanged -= handler;
        }

        public static FMOD.Channel PlayRandomSound(IEnumerable<FMOD.Sound> sounds, PlayAs playAs = PlayAs.SFX)
        {
            if (!sounds.Any()) return default;
            FMOD.Sound sound = sounds.RandomItems(1).First();
            return PlaySound(sound, playAs);
        }

        public enum PlayAs
        {
            Master,
            Music,
            SFX,
            Ambience
        }
    }
    public static class SFXLoaderExt
    {
        public static void Pause(this FMOD.Channel soundChannel) => soundChannel.setPaused(true);
        public static void Pause(this FMOD.Channel soundChannel, float pauseTime) => CoroutineManager.Start(PauseRoutine(soundChannel, pauseTime));
        static IEnumerator PauseRoutine(FMOD.Channel soundChannel, float pauseTime)
        {
            soundChannel.Pause();
            yield return new WaitForSeconds(pauseTime);
            soundChannel.Unpause();
        }
        public static void Unpause(this FMOD.Channel soundChannel) => soundChannel.setPaused(false); 
        public static void Unpause(this FMOD.Channel soundChannel, float unpauseTime) => CoroutineManager.Start(UnpauseRoutine(soundChannel, unpauseTime));
        static IEnumerator UnpauseRoutine(FMOD.Channel soundChannel, float unpauseTime)
        {
            soundChannel.Unpause();
            yield return new WaitForSeconds(unpauseTime);
            soundChannel.Pause();
        }
    }
}
