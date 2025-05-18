using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

namespace WildfrostHopeMod.Leader_Colour_Test
{
    public class Leader_Colour_TestMod : WildfrostMod
    {
        [ConfigItem(6, """
            Number of frames to wait before next colour (6 delay ~ 1s)
            //
            // Smaller delays = More swapping (but might slow down gameplay!)
            """, "Delay")]
        public int delayMax = 10;
        [ConfigItem(100, "Number of total colours to swap between", "Max offset")]
        public int offsetMax = 100;
        [ConfigItem(false, "", "Affect Clothing Colour")]
        public bool affectClothing = false;
        [ConfigItem(true, "", "Affect Hair Colour")]
        public bool affectHair = true;
        [ConfigItem(false, "", "Affect Eye Colour")]
        public bool affectEye = false;
        [ConfigItem(false, "", "Affect Skin Colour")]
        public bool affectSkin = false;
        //[ConfigItem(false, "", "Affect MarkingColour Colour")]
        public bool affectMarking = false;


        public static Sprite RecolourWeapon;


        public static bool IsLocal => Mod?.ModDirectory.Replace('/', '\\').Contains(Application.streamingAssetsPath.Replace('/', '\\')) ?? false;
        public static Leader_Colour_TestMod Mod;
        public Leader_Colour_TestMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
            RecolourWeapon = GetImageSprite("Weapons0006.png");
        }
        public override string GUID => "hope.wildfrost.Leader_Colour_Test";
        public override string[] Depends => new string[] { };
        public override string Title => "Rainbow Leaders";
        public override string Description => """
            Small mod that cycles leaders' clothes / hair / eyes through a rainbow (adjustable in configs with Config Manager).

            Mainly a proof of concept before working on more customisable leaders
            """;
        public static GameObject behaviour;

        public override void Load()
        {
            base.Load();

            var buttonGroup = GameObject.Find("Canvas/SafeArea/Buttons");
            Debug.LogWarning(buttonGroup);

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            if (!IsLocal)
                behaviour.AddComponent<Leader_Colour_TestModBehaviour>();
            else
            {
                behaviour.transform.SetParent(buttonGroup.transform);
                CoroutineManager.Start(Routine());

                IEnumerator Routine()
                {
                    Setup();
                    var icon = Resources.FindObjectsOfTypeAll<ModifierIcon>()
                        .FirstOrDefault(i => i.name == "BellModifierIcon")?.InstantiateKeepName();
                    if (!icon) yield break;
                    //icon.transform.SetParent(behaviour.transform);
                    icon.transform.position = Vector2.zero;
                    icon.transform.localScale *= 3
                            * Mathf.Max(275 / 238f)
                            ;
                    /*foreach (var mod in AddressableLoader.GetGroup<GameModifierData>(nameof(GameModifierData))
                        .Where(g => g.visible))
                    {
                        icon.Set(mod, Vector2.zero);
                        yield return ScreenshotRoutine(filename: mod.titleKey.GetLocalizedString());
                    }*/
                    yield return ScreenshotRoutine(Screen.width, Screen.height, filename: DateTime.Now.ToFileTimeUtc().ToString());
                    icon.Destroy();
                }
            }

            Events.OnEntityCreated += Subscribe;
        }
        public void Setup()
        {
            var rect = behaviour.GetOrAdd<RectTransform>();
            rect.sizeDelta = Vector2.one;

            behaviour.transform.position = Vector2.zero
                .WithZ(Camera.main.transform.position.z * 0.6299f)
                ;
            behaviour.GetOrAdd<LayoutElement>().ignoreLayout = true;
            behaviour.GetOrAdd<Canvas>().gameObject.layer = 8;
            var image = behaviour.GetOrAdd<Image>();

            int test = 512;
            rect.sizeDelta *= test / 256f;

            var t = new Texture2D(test, 1) { filterMode = FilterMode.Point };
            int y = 0;
            for (int x = 0; x < t.width; x++)
            {
                var f = (x % 256) / 255f;
                t.SetPixel(x, y, new Color(f, f, f));
            }
            t.Apply();
            image.sprite = Sprite.Create(t, new Rect(0, 0, t.width, t.height), Vector2.zero);

            image.color = Color.white.WithAlpha(0);
        }
        public IEnumerator ScreenshotRoutine(int width = 512, int height = 512, string filename = null)
        {
            GameObject newCameraObject = new GameObject("NewCamera");
            var camera = newCameraObject.AddComponent<Camera>();
            camera.CopyFrom(Camera.main);
            camera.cullingMask = (1 <<
                (behaviour.GetComponent<Canvas>()?.gameObject.layer
                ?? behaviour.GetComponentInParent<Canvas>()?.gameObject.layer
                ?? 5
                )
            ); //(1 << behaviour.layer);
            string layerMask = Convert.ToString(camera.cullingMask, 2);
            float cameraZ = behaviour.transform.position.z;

            

            Screenshot(camera, ModDirectory, $"{(!filename.IsNullOrEmpty() ? filename : DateTime.Now.ToFileTimeUtc())}.png",
                //Screen.width, Screen.height
                width, height
                );
            // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
            // exportCards.camera.cullingMask = -1; // this renders every layer
            newCameraObject.Destroy();
            yield return null;

        }
        public void Screenshot(Camera camera, string directory, string fileName, int width, int height)
        {
            Dictionary<Material, Shader> shaders = [];
            Dictionary<Image, bool> frameImages = [];
            Resources.FindObjectsOfTypeAll<Image>().Do(m =>
            {
                if (m.name == "FrameImage")
                {
                    frameImages[m] = m.maskable;
                    m.maskable = false;
                }
                if (shaders.ContainsKey(m.material)) return;
                shaders[m.material] = m.material.shader;
                m.material.shader = Shader.Find("UI/Default");
            });

            string text = directory + "/" + fileName;
            Texture2D texture2D = new Texture2D(width, height, TextureFormat.ARGB32, mipChain: false);
            RenderTexture renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
            camera.targetTexture = renderTexture;
            camera.Render();
            RenderTexture.active = renderTexture;
            texture2D.ReadPixels(new Rect((renderTexture.width - width) / 2, (Screen.height - height) / 2, width, height), 0, 0);
            texture2D.Apply();
            byte[] bytes = texture2D.EncodeToPNG();
            Directory.CreateDirectory(directory);
            File.WriteAllBytes(text, bytes);
            Debug.Log(text);

            shaders.Do(kvp => kvp.Key.shader = kvp.Value);
            frameImages.Do(kvp => kvp.Key.maskable = kvp.Value);

        }
        public override void Unload()
        {
            Events.OnEntityCreated -= Subscribe;

            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        internal void Subscribe(Entity entity)
        {
            if (entity.data.scriptableImagePrefab is Leader)
                Leader_Colour_TestModBehaviour.subscribed.Add(entity);
        }

        const ushort clothingMask   = 0b1111000000000000;
        const ushort hairMask       = 0b0000111100000000;
        const ushort eyeMask        = 0b0000000000001000;
        const ushort skinMask       = 0b0000000000000111;

        const string clothing = """
                            Clothing accent: {0}
                            Clothing shadow: {1}
                            Clothing colour: {2}
                            Weapon highlight: {3}
                            """;
        const string hair = """
                            Hair accent: {0}
                            Hair shadow: {1}
                            Hair colour: {2}
                            Hair highlight: {3}
                            """;
        const string skin = """
                            Ear accent: {0}
                            Skin shadow: {1}
                            Skin colour: {2}
                            """;
    }
}