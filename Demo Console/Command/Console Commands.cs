using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using Rewired;
using ES3Types;
using System.Threading.Tasks;
using UniverseLib;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        static bool debug = false;
        static ConsoleCustom() => RegisterCommands();
        public static List<Console.Command> commands = new List<Console.Command>();
        public static void RegisterCommands()
        {
            commands = new List<Console.Command>();
            Type consoleType = typeof(ConsoleCustom);
            Type commandType = typeof(Console.Command);
            Assembly assembly = consoleType.Assembly;
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.IsSubclassOf(commandType) && !type.IsAbstract && commands.All(c => c.GetType() != type) && type != typeof(ConsoleCustom))
                {
                    if (Activator.CreateInstance(type) is not Console.Command command)
                        return;
                    if (debug || (command != null && !command.desc.Contains("(WIP)")))
                        commands = commands.Append(command).ToList();
                }
            }
        }
        public static void StartCoroutine(IEnumerator ie) => ConsoleMod.StartCoroutine(ie);
        public class CommandDebug : Console.Command
        {
            public override string id => "debug";
            public override bool hidden => true;
            public override void Run(string args)
            {
                debug = !debug;
                Debug.LogWarning("debug = " + debug);
                RegisterCommands();
                Console.Commands();
                Console.instance.PopulateHelp();
                Additional();
            }

            static void Additional()
            {/*
                if (Bootstrap.Mods.Any(mod => mod.GUID == "kopie.wildfrost.unityexplorer" && mod.HasLoaded))
                {
                    //UnityExplorer.InspectorManager.
                    UnityExplorer.InspectorManager.Inspect(typeof(AddressableLoader));
                    Debug.LogWarning(typeof(AddressableLoader).GetField("groups", BindingFlags.Static)?.GetValue(null));
                    Debug.LogWarning(typeof(AddressableLoader).GetField("groups", BindingFlags.Static | BindingFlags.Public)?.GetValue(null));
                    Debug.LogWarning(typeof(AddressableLoader).GetField("groups", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null));
                    UnityExplorer.InspectorManager.Inspect(AddressableLoader.groups);
                    UnityExplorer.InspectorManager.Inspect(AddressableLoader.groups.RandomItems(1).First().Value);
                    UnityExplorer.InspectorManager.Inspect(AddressableLoader.groups.RandomItems(1).First().Value.lookup);
                    UnityExplorer.InspectorManager.Inspect(AddressableLoader.groups.RandomItems(1).First().Value.lookup.Values.RandomItems(1).First());
                }*/


                /*foreach (var card in AddressableLoader.GetGroup<CardData>("CardData"))
                {
                    if (!card.mainSprite) continue;
                    Debug.LogWarning(card.title);
                    Debug.Log(card.mainSprite.bounds);
                    Debug.Log(card.mainSprite.rect);
                    Debug.Log(card.mainSprite.textureRect);
                    card.mainSprite.rect.Set(0, 0, card.mainSprite.textureRect.width, card.mainSprite.textureRect.height);
                    
                    Debug.Log(card.mainSprite.bounds);
                    Debug.Log(card.mainSprite.rect);
                    Debug.Log(card.mainSprite.textureRect);
                }*/
            }
        }
        /*public class CommandExportCards : Console.Command
        {
            public override string id => "export card";
            public override string format => "export card (<name>)";
            public override string desc => "don't specify a name to export the hovered card instead";
            public override bool IsRoutine => true;
            public override Il2CppSystem.Collections.IEnumerator Routine(string args)
            {
                StartCoroutine(_Routine(args));
                return default;
            }
            public IEnumerator _Routine(string args)
            {
                CommandExportCards command = this;
                CardData cardData = null;
                Card temp = null;
                if (args.Length == 0)
                {
                    if (Console.hover == null) Fail("Please hover over a card or provide a card name to use this command");
                    else
                    {
                        cardData = Console.hover.data;
                        temp = GameObject.Instantiate(Console.hover.display as Card);
                    }
                }
                else
                {
                    if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                    IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase));
                    if (source.Any())
                        cardData = source.First();
                    else command.Fail("Card [" + args + "] does not exist!");
                }
                if (cardData != null && !(cardData.mainSprite?.name == "Nothing"))
                {
                    Screen.SetResolution(1416, 900, false);
                    Card card = temp ?? CardManager.Get(cardData, null, null, false);
                    card.gameObject.SetLayerRecursively(7);
                    yield return card.UpdateData(false);
                    card.transform.position = Vector3.zero;
                    yield return null;
                    GameObject newCameraObject = new GameObject("NewCamera");
                    ExportCards exportCards = new();
                    exportCards._camera = newCameraObject.AddComponent<Camera>();
                    exportCards._camera.CopyFrom(Camera.main);
                    exportCards._camera.cullingMask = 1 << card.gameObject.layer;
                    Screenshot(exportCards, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png", cardData.cardType.name == "Boss");
                    yield return null;
                    CardManager.ReturnToPool(card);
                    card = null;
                    cardData = null;
                    // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                    // exportCards.camera.cullingMask = -1; // this renders every layer
                    newCameraObject.Destroy();
                }
                else Fail("Card is not valid");
                temp.Destroy();
            }

            public void Screenshot(ExportCards exporter, string directory, string fileName, bool big = false)
            {
                string text = directory + "/" + fileName;
                Texture2D texture2D = new Texture2D(400, big ? 700 : 500, TextureFormat.ARGB32, mipChain: false);
                RenderTexture renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
                exporter.camera.targetTexture = renderTexture;
                exporter.camera.Render();
                RenderTexture.active = renderTexture;
                texture2D.ReadPixels(new Rect(renderTexture.width / 2 - 200, Screen.height / 2 - (big ? 350 : 250), 400, big ? 700 : 500), 0, 0);
                texture2D.Apply();
                byte[] bytes = texture2D.EncodeToPNG();
                Directory.CreateDirectory(directory);
                File.WriteAllBytes(text, bytes);
                Debug.Log(text);
            }
            public IEnumerator _GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(a => a.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.Select(cardData => cardData.name).ToArray();
            }
        }
        public class CommandExportAll : Console.Command
        {
            public override string id => "export all";
            public override string format => "export all <GUID>";
            public override bool IsRoutine => true;
            public IEnumerator _Routine(string args)
            {
                PromptSystem.instance.prompt.SetText("This may take a while...");
                PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Scared, Prompt.Emote.Position.Above);
                var exporter = new CommandExportCards();
                foreach (var cardData in AddressableLoader.GetGroup<CardData>("CardData").Where(c => c.name.Contains(args)))
                    if (cardData != null && !(cardData.mainSprite == null) && !(cardData.mainSprite.name == "Nothing"))
                    {
                        yield return new CommandExportCards().Routine(cardData.name);
                        // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                        // exportCards.camera.cullingMask = -1; // this renders every layer
                    }
                PromptSystem.Hide();
                PromptSystem.instance.prompt.SetText("Thank you for your patience!");
                PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Happy, Prompt.Emote.Position.Above);
                yield return new WaitForSeconds(4);
                PromptSystem.Hide();
            }
        }

        public class CommandTrigger : Console.Command
        {
            public override string id => "trigger";
            public override bool IsRoutine => true;

            public IEnumerator _Routine(string args)
            {
                if (!Console.hover)
                    this.Fail("Please hover over a card to use this command");
                else if (!Console.hover.enabled)
                {
                    this.Fail("Cannot trigger this card");
                }
                else
                {
                    yield return StatusEffectSystem.Apply(Console.hover, null, ConsoleMod.Mod.Get<StatusEffectData>("Trigger"), 1);
                }
            }
        }
        public class CommandTriggerAll : Console.Command
        {
            public override string id => "trigger all";
            public override bool IsRoutine => true;

            public IEnumerator _Routine(string args)
            {
                if ((UnityEngine.Object)Battle.instance == (UnityEngine.Object)null)
                {
                    this.Fail("Must be in battle to use this command");
                }
                else
                {
                    var trigger = ConsoleMod.Mod.Get<StatusEffectData>("Trigger");

                    Battle.instance.playerCardController.Disable();
                    //Battle.instance.phase = Battle.Phase.Battle;
                    foreach (Entity entity in Battle.GetCardsOnBoard(Battle.instance.enemy))
                        yield return StatusEffectSystem.Apply(entity, null, trigger, 1);

                    foreach (Entity entity in Battle.GetCardsOnBoard(Battle.instance.player))
                        yield return StatusEffectSystem.Apply(entity, null, trigger, 1);

                    yield return ActionQueue.Wait();
                    //Battle.instance.phase = Battle.Phase.Play;
                    Battle.instance.playerCardController.Enable();
                };
            }
        }



        public class CommandGoTo : Console.Command
        {
            public override string id => "goto";
            public override string format => "goto <scene>";

            public override void Run(string args)
            {
                if (args.Length <= 0) Fail("You must provide a scene name");
                else
                {
                    IEnumerable<string> source = new string[] { "Town", "MainMenu" }.Where(a => a.ToLower().Contains(args.ToLower()));
                    if (source.Any())
                    {
                        string sceneName = source.First();
                        if (SceneManager.ActiveSceneName == sceneName || SceneManager.IsLoaded(sceneName))
                            Fail("Scene is already active");
                        else new Menu().GoTo(sceneName);
                    }
                    else Fail("Scene [" + args + "] does not exist!");
                }
            }
            public override Il2CppSystem.Collections.IEnumerator GetArgOptions(string currentArgs)
            {
                return base.GetArgOptions(currentArgs);
            }
            public IEnumerator _GetArgOptions(string currentArgs)
            {
                predictedArgs = [];
                IEnumerable<string> source = new string[] { "Town", "MainMenu" }.Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                if (source.Any()) predictedArgs = source.ToArray();
                yield return null;
            }
        }
        public class CommandQuickRestart : Console.Command
        {
            public override string id => "quick restart";
            public override string desc => "starts a new campaign";
            public override void Run(string args)
            {
                try
                {
                    new PauseMenu().QuickRestart();
                }
                catch (Exception)
                {
                    Fail("Can't do that now");
                }
            }
        }*/

        /*public class CommandCreateVFX : Console.Command
        {
            public override string id => "create vfx";
            public override string format => "create vfx <prefab>";
            private VfxStatusSystem VfxSystem;

            public override void Run(string args)
            {
                var transform = Cursor3d.instance.transform;
                Dictionary<string, object> dic = new();
                IEnumerable<VfxStatusSystem.Profile> source = VfxSystem.profileLookup.Where(a => string.Equals(a.Key, args, StringComparison.CurrentCultureIgnoreCase)).Select(t => t.Value);
                if (source.Any())
                {
                    VfxSystem.CreateEffect(source.First().applyEffectPrefab, Cursor3d.instance.transform.position, Cursor3d.instance.transform.lossyScale);
                }
                else Fail($"VFX [{args}] does not exist!");
            }

            public IEnumerator _GetArgOptions(string currentArgs)
            {
                VfxSystem = GameObject.FindObjectOfType<VfxStatusSystem>();
                yield return null;
                IEnumerable<string> source = VfxSystem.profileLookup.Keys.Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.ToArray();
            }
        }

        public class CommandCreateSFX : Console.Command
        {
            public override string id => "create sfx";
            public override string format => "create sfx <name>";
            public List<string> events = new();
            string[] options = null;
            List<string> GetOptions()
            {
                if (!events.Any())
                {
                    FMODUnity.RuntimeManager.StudioSystem.getBankList(out var banks);
                    foreach (var bank in banks)
                    {
                        bank.getEventList(out var events);
                        foreach (var e in events)
                        {
                            e.getPath(out string path);
                            this.events.Add(path.Replace("event:", ""));
                        }
                    }
                }
                return events;
            }

            public override void Run(string args)
            {
                IEnumerable<string> source = GetOptions().Where(a => string.Equals(a, args, StringComparison.CurrentCultureIgnoreCase));
                if (source.Any())
                {
                    string str = source.First();
                    if (events.Contains(str))
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:" + str);
                    }
                }
                else Fail("Sound [" + args + "] does not exist!");
            }

            public IEnumerator _GetArgOptions(string currentArgs)
            {
                predictedArgs = default;
                yield return null;
                IEnumerable<string> source = GetOptions().Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                if (source.Any()) predictedArgs = source.ToArray();
            }
        }*/

    }
}