using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using FMODUnity;
using HarmonyLib;
using Il2CppInterop.Generator.Extensions;
using Il2CppInterop.Runtime.Injection;
using Il2CppSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityExplorer;
using UnityExplorer
    ors;
using UnityExplorer.UI;
using static InjurySystem;
using Action = System.Action;
using WildfrostHopeMod.CommandsConsole;
using static WildfrostHopeMod.CommandsConsole.ConsoleCustom.CommandDataBuilderOf;
using UniverseLib;
using Il2CppInterop.Runtime.InteropTypes;

namespace BepInExv
{
    [BepInPlugin("hope.wildfrost.console", "Demo Console mod", "1.0.0.0")]
    public partial class ConsoleMod : BasePlugin
    {
        public static void StartCoroutine(IEnumerator ie) => SfxSystem.instance.StartCoroutine(ie);

        public static ConsoleMod instance;
        public static Harmony HarmonyInstance;
        public override void Load()
        {
            Debug.LogWarning("OWO!");
            instance = this;
            HarmonyInstance = Harmony.CreateAndPatchAll(GetType().Assembly, "hope.wildfrost.console");
            Log.LogInfo(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).Join());
            Events.OnGameStart += new Action(OnEnable);
        }
        void Start() => instance.Log.LogInfo("HELLO!");
        public static GameObject behaviour = null;

        public static DataFile hover = null;

        //[ConfigItem(true, "Pressing up or down keys when there are multiple autofill options will now scroll through them, instead of scrolling through the command log. Hold to scroll very fast!", "Scrollable commands")]
        public bool scrollConfig = true;
        //[ConfigItem(true, "", "Card/charm title autocomplete")]
        public bool autocompleteConfig = true;
        //[ConfigItem(nameof(KeyCode.F12), "(Besides Tilde (~) or BackQuote (`))\n//\n//Refer to docs.unity3d.com/ ScriptReference/ KeyCode.html", "Toggle KeyCode")]
        public string toggleConfig = "";
        public KeyCode toggleKey
        {
            get
            {
                return KeyCode.RightAlt;
                /*if (typeof(KeyCode).GetEnumNames().Any(n => string.Equals(n, toggleConfig, StringComparison.CurrentCultureIgnoreCase)))
                    return (KeyCode)System.ComponentModel.TypeDescriptor.GetConverter(typeof(KeyCode)).ConvertFromInvariantString(toggleConfig);
                return default;*/
            }
        }
        public static System.Type[] allTypes = typeof(DataFile).Assembly.GetTypes();
        public static bool instantiated = false;

        public unsafe void OnEnable()
        {
            Debug.LogWarning("ENABLED");
            //Resources.FindObjectsOfTypeAll<Sprite>().Do(SpriteHandler.ExportSprite);


            //ExplorerStandalone.CreateInstance();
            static List<Transform> GetAllChildren(Transform transform)
            {
                int childCount = transform.childCount;
                List<Transform> array = [];
                for (int i = 0; i < childCount; i++)
                {
                    array.Add(transform.GetChild(i));
                    //Debug.Log((transform.name, childCount, array[i].name).ToString());
                }

                return array;
            }
            static void Prefix(GameObject prefab)
            {
                Search(prefab.transform, "");
            }
            static bool Search(Transform t, string path)
            {
                string newPath = Path.Combine(path, t.name);
                Debug.LogWarning((newPath, t.GetComponents<Component>().Select(c => c.ToString()).Join()).ToString());
                if (t.childCount == 0)
                    return false;
                GetAllChildren(t).ForEach(tt => Search(tt, newPath));
                return true;
            }

            foreach (System.Type allDataType in typeof(AddressableLoader).Assembly.GetTypes()
                .Where(t => t.BaseType == typeof(ScriptableObject) || t.BaseType == typeof(DataFile)))
            {
                
                if (allDataType == typeof(CampaignNodeType) || allDataType == typeof(GameModifierData)) continue;
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

            SfxSystem.instance.StartCoroutine(LoadConsole());

            // Fixes for inspect command
            Events.OnInspect += new System.Action<Entity>(Hover);
            Events.OnInspectEnd += new System.Action<Entity>(UnHover);
            Events.OnEntityUnHover += new System.Action<Entity>(UnHover);
            Events.OnUpgradeHover += new System.Action<UpgradeDisplay>(HoverUpgrade);

            

            
            
            /*foreach (var s in Resources.FindObjectsOfTypeAll<Script>())
            {
                Debug.Log((s.GetType(), s.name).ToString());
                *//*Debug.LogWarning(s.TryCast<ScriptBattleSetUp>());
                Debug.Log(
                    typeof(Il2CppObjectBase)
                    .GetMethod(nameof(Il2CppObjectBase.TryCast))
                    .MakeGenericMethod(typeof(ScriptBattleSetUp))
                    .Invoke(s, null)
                    ?.ToString());*//*

                var possibleTypes = BepInExv.ConsoleMod.allTypes.Where(s.GetType().IsAssignableFrom);
                System.Type actualType = null;
                object actualObj = null;
                foreach (var type in possibleTypes)
                {
                    //Debug.Log("test type " + type.Name);
                    actualObj = typeof(Il2CppObjectBase)
                        .GetMethod(nameof(Il2CppObjectBase.TryCast))
                        .MakeGenericMethod(type)
                        .Invoke(s, null);
                    if (actualObj != null)
                    {
                        Debug.LogError("GOT type " + type.Name);
                        actualType = type;
                        break;
                    }
                }
            }*/

        }
        public static void HoverUpgrade(UpgradeDisplay display) => ConsoleMod.hover = display.data;
        public static void Hover(Entity entity) => Console.hover = entity;
        public static void UnHover(Entity entity) => Console.hover = null;


        internal static IEnumerator LoadConsole()
        {
            Debug.LogWarning("CONSOLE SHOULD LOAD");
            yield return SceneManager.Load("Console", SceneType.Persistent);
            Debug.LogWarning("CONSOLE SHOULD LOADED");
            yield return new WaitUntil((System.Func<bool>)(() => Console.instance != null));
            Console.instance.savedCommands = Console.instance.savedCommands.Select(s => s = s.IsNullOrWhitespace() ? "" : s).ToArray();
            Console.instance.argsDisplay.commands = new Console.Command[] { Console.commands.ToArray().ToArray().ToList().FirstOrDefault() };
            Console.instance.argsDisplay.current = new string[] { "help" };
            Console.instance.canvas.sortingOrder = 1;

            //PatchTitleAsPrediction.Run();
            yield return AddHelpText();

            instantiated = true;

            yield return new WaitUntil((System.Func<bool>)(() => AddressableLoader.IsGroupLoaded(nameof(GameModifierData))));
            foreach (var u in AddressableLoader.GetGroup<GameModifierData>(nameof(GameModifierData)))
            {
                //Debug.LogError("");
                var s = new GenericDataHandler().Info(u);
                Debug.LogWarning(s);
            }
        }

        static IEnumerator AddHelpText()
        {
            yield return new WaitUntil((System.Func<bool>)(() => SceneManager.IsLoaded("Console")));
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

        public class ExportCards : MonoBehaviour
        {
            public string folder = nameof(ExportCards);
            public Camera _camera;

            public Camera camera => this._camera ?? (this._camera = Camera.main);

            private IEnumerator Start()
            {
                /*ExportCards exportCards = this;
                foreach (CardData cardData1 in AddressableLoader.GetGroup<CardData>("CardData"))
                {
                    CardData cardData = cardData1;
                    if (!((UnityEngine.Object)cardData.mainSprite == (UnityEngine.Object)null) && !(cardData.mainSprite.name == "Nothing"))
                    {
                        Card card = CardManager.Get(cardData, (CardController)null, (Character)null, false);
                        yield return (object)card.UpdateData(false);
                        card.transform.position = Vector3.zero;
                        yield return (object)null;
                        exportCards.Screenshot(Application.dataPath + "/../" + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png");
                        yield return (object)null;
                        CardManager.ReturnToPool(card);
                        card = (Card)null;
                        cardData = (CardData)null;
                    }
                }*/
                yield break;
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
        /*public class CommandExportCards
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
                    Screenshot(exportCards, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/" + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png", cardData.cardType.name == "Boss");
                    yield return null;
                    CardManager.ReturnToPool(card);
                    card = null;
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
        }*/
        /*public class CommandExportAll
        {
            public IEnumerator Routine(string args)
            {
                Texture2D t = Addressables.LoadAssetAsync<Texture2D>("Assets/Content/Images/Cards/Images/Nothing.png").WaitForCompletion();
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
        }*/



    }
    
}
