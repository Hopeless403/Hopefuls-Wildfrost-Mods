using BepInEx;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityExplorer;
using static InjurySystem;

namespace WildfrostHopeMod.CommandsConsole
{
    [BepInPlugin("hope.wildfrost.demobeta", "Beta Console mod", "1.0.0.0")]
    public partial class ConsoleMod : BaseUnityPlugin
    {
        public class ExportCards : MonoBehaviour
        {
            public string folder = nameof(ExportCards);
            public Camera _camera;

            public Camera camera => this._camera ?? (this._camera = Camera.main);

            private IEnumerator Start()
            {
                ExportCards exportCards = this;
                foreach (CardData cardData1 in AddressableLoader.GetGroup<CardData>("CardData"))
                {
                    CardData cardData = cardData1;
                    if (!((UnityEngine.Object)cardData.mainSprite == (UnityEngine.Object)null) && !(cardData.mainSprite.name == "Nothing"))
                    {
                        Card card = null;
                        yield return CardManager.CreateCard(cardData, null, null, false, c => card = c);
                        yield return (object)card.UpdateData(false);
                        card.transform.position = Vector3.zero;
                        yield return (object)null;
                        exportCards.Screenshot(Application.dataPath + "/../" + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png");
                        yield return (object)null;
                        card.gameObject.SetActive(false);
                        card = (Card)null;
                        cardData = (CardData)null;
                    }
                }
            }

            private void Screenshot(string directory, string fileName)
            {
                string str = directory + "/" + fileName;
                Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.ARGB32, false);
                RenderTexture renderTexture = new RenderTexture(tex.width, tex.height, 24);
                this.camera.targetTexture = renderTexture;
                this.camera.Render();
                RenderTexture.active = renderTexture;
                tex.ReadPixels(new Rect(0.0f, 0.0f, (float)tex.width, (float)tex.height), 0, 0);
                tex.Apply();
                byte[] png = tex.EncodeToPNG();
                System.IO.Directory.CreateDirectory(directory);
                File.WriteAllBytes(str, png);
                Debug.Log(str);
            }
        }
        public class CommandExportCards
        {
            public IEnumerator Routine(string args)
            {
                CommandExportCards command = this;
                CardData cardData = null;
                Card temp = null;
                if (args.Length > 0)
                {
                    if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                    IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").ToArray().ToList().Where(a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase));
                    if (source.Any())
                        cardData = source.First();
                }
                if (cardData != null && !(cardData.mainSprite?.name == "Nothing"))
                {
                    Screen.SetResolution(1416, 900, false);
                    Card card = temp;
                    yield return CardManager.CreateCard(cardData, null, null, false, c => card = c);
                    card.gameObject.SetLayerRecursively(7);
                    yield return card.UpdateData(false);
                    card.transform.position = Vector3.zero;
                    yield return null;
                    GameObject newCameraObject = new GameObject("NewCamera");
                    ExportCards exportCards = new();
                    exportCards._camera = newCameraObject.AddComponent<Camera>();
                    exportCards._camera.CopyFrom(Camera.main);
                    exportCards._camera.cullingMask = 1 << card.gameObject.layer;
                    Screenshot(exportCards, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/" + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png", cardData.cardType.name == "Boss");
                    yield return null;

                    card.gameObject.SetActive(false);
                    cardData = null;
                    // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                    // exportCards.camera.cullingMask = -1; // this renders every layer
                    newCameraObject.Destroy();
                }
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
        }
        public class CommandExportAll
        {
            public IEnumerator Routine(string args)
            {
                Texture2D t = new Texture2D(4,4);
                Sprite nothing = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);

                PromptSystem.instance.prompt.SetText("This may take a while...");
                PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Scared, Prompt.Emote.Position.Above);
                var exporter = new CommandExportCards();
                foreach (var cardData in AddressableLoader.GetGroup<CardData>("CardData").ToArray().ToList().Where(c => c.name.Contains(args)))
                    if (cardData != null)// && !(cardData.mainSprite == null) && !(cardData.mainSprite.name == "Nothing"))
                    {
                        bool flag = (cardData.mainSprite == null) || (cardData.mainSprite.name == "Nothing");
                        if (flag)
                            cardData.mainSprite = nothing;
                        if (cardData.scriptableImagePrefab)
                        {
                            Debug.LogWarning("We found ourselves a dirty leader");
                            cardData.scriptableImagePrefab = null;
                        }
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
        public static ConsoleMod instance;
        public static Harmony HarmonyInstance;
        public void Start()
        {
            Debug.Log("WE STARTING");
            instance = this;
            HarmonyInstance = Harmony.CreateAndPatchAll(GetType().Assembly, "hope.wildfrost.console");
            Logger.LogInfo(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).Join());
            Events.OnGameStart += Enabler;
        }
        public static GameObject behaviour = null;

        public static DataFile hover = null;

        //[ConfigItem(true, "Pressing up or down keys when there are multiple autofill options will now scroll through them, instead of scrolling through the command log. Hold to scroll very fast!", "Scrollable commands")]
        public bool scrollConfig = true;
        //[ConfigItem(true, "", "Card/charm title autocomplete")]
        public bool autocompleteConfig = true;
        

        public static void HoverUpgrade(UpgradeDisplay display) => ConsoleMod.hover = display.data;
        public static void Hover(Entity entity) => Console.hover = entity;
        public static void UnHover(Entity entity) => Console.hover = null;

        public class HopeLoader : MonoBehaviour
        {
            UnityEngine.Object Get(string name)
            {
                UnityEngine.Object obj = AddressableLoader.Get<UnityEngine.Object>(name);
                if (obj != null)
                    InspectorManager.Inspect(obj);
                return obj;
            }
            void LoadAll()
            {
                List<string> names = [];
                foreach (var locator in Addressables.ResourceLocators)
                    if (locator is ResourceLocationMap map)
                        foreach (var location in map.Locations)
                            names.Add(location.Key.ToString());
                Debug.LogWarning(names.Join(delimiter: "\n"));
            }
            void Intro()
            {
                //new Routine(Sequences.TransitionTo(this.nextScene, this.transition));
                CoroutineManager.Start(SceneManager.Load("Intro", SceneType.Temporary, s => Debug.LogWarning(s)));
            }
        }

        public void Enabler()
        {
            Debug.LogWarning("ENABLED");
            var go = new GameObject("Hope's AddressableLoader", typeof(HopeLoader));

            foreach (System.Type allDataType in typeof(AddressableLoader).Assembly.GetTypes()
                .Where(t => t.BaseType == typeof(ScriptableObject) || t.BaseType == typeof(DataFile)))
            {
                try
                {
                    typeof(AddressableLoader).GetMethod("GetGroup", BindingFlags.Static | BindingFlags.Public).MakeGenericMethod(allDataType).Invoke((object)this, new object[1]
                    {
                    allDataType.ToString()
                    });
                }
                catch
                {
                    Debug.LogError($"{allDataType.Name} isn't a DataFile silly");
                }
            }

            //SfxSystem.instance.StartCoroutine(new CommandExportAll().Routine(""));


            //SfxSystem.instance.StartCoroutine(LoadConsole());

            // Fixes for inspect command
            Events.OnInspect += (Hover);
            Events.OnInspectEnd += (UnHover);
            Events.OnEntityUnHover += (UnHover);
            Events.OnUpgradeHover += (HoverUpgrade);

            // To show ActionQueue displayer
            Patches.PatchTrackFpsDrawer.active = Settings.Load<bool>("ShowFps", false);

            /*// Fixes for reroll command
            Events.OnCampaignGenerated += PatchCampaignDataWithEvents.SaveCampaignDatas;
            Events.OnCampaignLoaded += PatchCampaignDataWithEvents.LoadCampaignDatas;*/
        }
        internal static IEnumerator LoadConsole()
        {
            int i = 0;
            Debug.LogWarning("CONSOLE SHOULD LOAD");
            yield return SceneManager.Load("Console", SceneType.Persistent);
            Debug.LogWarning("CONSOLE SHOULD LOADED: " + SceneManager.IsLoaded("Console"));
            var consoleObj = new GameObject("MyConsole", typeof(Console), typeof(RectTransform));
            GameObject.DontDestroyOnLoad(consoleObj);
            Debug.LogWarning(MonoBehaviourSingleton<Console>.instance);
            yield return new WaitUntil(() => Console.instance != null);
            Debug.LogWarning("CONSOLE INSTANCE LOADED");
            Debug.LogWarning(i++);
            Console.instance.savedCommands = [.. Console.instance.savedCommands.Select(s => s = s.IsNullOrWhitespace() ? "" : s)];

            Canvas canvas = GameObject.Find("FPS Canvas").GetComponent<Canvas>();
            Console.instance.canvas = canvas;
            Console.instance.helpWindow = new GameObject("MyHelp");
            Console.instance.helpWindow.transform.SetParent(Console.instance.gameObject.transform);

            Debug.LogWarning(i++);
            Console.instance.Start();
            Console.instance.gameObject.SetActive(false);
            Console.instance.argsDisplay = consoleObj.GetOrAdd<ConsoleArgsDisplay>();
            Console.instance.argsDisplay.textPrefab = canvas.GetComponentInChildren<TextMeshProUGUI>();
            Console.instance.gameObject.SetActive(true);

            Debug.LogWarning(i++);
            Console.instance.argsDisplay.commands = [Console.commands.FirstOrDefault()];

            Debug.LogWarning(i++);
            Console.instance.argsDisplay.current = ["help"];
            Debug.LogWarning(i++);
            Console.instance.canvas.sortingOrder = 1;
            Debug.LogWarning(i++);

            Console.instance.toggle = Console.instance.toggle.Without(KeyCode.F12);
            Debug.LogWarning(i++);

            PatchTitleAsPrediction.Run();
            Debug.LogWarning(i++);

            //yield return AddHelpText();
        }



        static IEnumerator AddHelpText()
        {
            yield return new WaitUntil(() => SceneManager.IsLoaded("Console"));
            var otherHelpWindow = Console.instance.helpWindow.transform.FindRecursive("SavingCommands");
            //Debug.Log(otherHelpWindow.GetComponentInChildren<TextMeshProUGUI>().text);
            otherHelpWindow.GetComponentInChildren<TextMeshProUGUI>().text += '\n' + """
                    <#ff0><size=48>Combining Multiple Commands:</size></color>
                    Run multiple commands in one 
                    by separating them with a<#ff0> ; </color>(semicolon).

                    e.g. "gain blings 1; repeat 10" will give 1+10 blings.

                    <#ff0><size=48>Using Predicted Arguments:</size></color>
                    Press <#ff0>Tab</color> to autofill the predicted argument.

                    The <rotate=90><sprite name=knockback></rotate> <#ff0>Up</color> and <rotate=-90><sprite name=knockback></rotate> <#ff0>Down</color> arrow keys will
                    scroll the predictions if there's multiple.
                    
                    Otherwise, it will scroll the command log.
                    """;
        }

        

    }
}