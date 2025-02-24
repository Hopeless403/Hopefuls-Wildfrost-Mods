using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.IO;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using WildfrostHopeMod.Text;
using FMODUnity;
using WildfrostHopeMod.SFX;
using UnityEngine.TextCore.Text;
using TMPro;
using WildfrostHopeMod.Utils;
using System;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using JetBrains.Annotations;
using System.Collections;
using static Building;
using UnityEngine.UIElements;
using HarmonyLib.Public.Patching;
using System.Reflection;

namespace WildfrostHopeMod.VFX
{
    public partial class VFXMod : WildfrostMod
    {
        public static VFXMod instance;
        public static GameObject iconTemplate;
        
        public VFXMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
            HarmonyInstance.PatchAll(typeof(PatchHarmony));


            iconTemplate = Addressables.LoadAssetAsync<GameObject>("Card Icons/SnowIcon.prefab").WaitForCompletion().InstantiateKeepName();
            GameObject.DontDestroyOnLoad(iconTemplate);

            AllBuiledrs.RemoveAllWhere(t => t.Name == nameof(StatusIconBuilder));
            AllDataTypes.RemoveAllWhere(t => t.Name == nameof(_StatusIconData));
            AllBuiledrs.Add(typeof(StatusIconBuilder));
            AllDataTypes.Add(typeof(_StatusIconData));
        }

        public override string GUID => "hope.wildfrost.vfx";
        public override string[] Depends => new string[] { };
        public override string Title => "VFX/SFX Tools";
        public override string Description => "A collection of hopefully helpful VFX/SFX tools for mods.\r\nYou can also turn on a funny on-death animation in configs.\r\n\r\n\r\n\r\nThe main ones are:\r\n[list]\r\n[*][b]Typewriter[/b]: Using the CardScriptAddComponentTypewriter class to add a TypewriterController, you can make its description appear/disappear as if it were talking (think Inscryption or the Balatro guy)\r\n[*][b]GIF Loader[/b]: Import .gif files into the game to use as apply effects, or damage effects. The importing is somewhat slow so don't overuse it (DM me if you can find a way to use import async)\r\n[*][b]SFX Loader[/b]: Import and play music files in the game. You can use this with the Typewriter for talking sounds (like Sans Undertale!?!?)\r\n[*][b]Sprite Asset Generator[/b]: This was honestly a last minute addition just to help people make SpriteAssets and register them.\r\n[/list]\r\n\r\nEach of these come with a [url=https://steamcommunity.com/sharedfiles/filedetails/?id=3154932293]Console Command[/url] to test with, those being \"talk\", \"create vfx\" and \"create sfx\". These last two also show base game ones.\r\n\r\nI intended to add a way to replace the ScriptableCardImage but it's a bit dumb. Maybe a simple example implementation in the future?";
        public override TMP_SpriteAsset SpriteAsset => spriteAsset;

        public static Transform parent;

        public GIFLoader VFX;
        public SFXLoader SFX;
        public TMP_SpriteAsset spriteAsset;

        [ConfigItem(false, null, "peepovanish")]
        public bool PeepoVanish;


        public static string CatalogFolder => Path.Combine(instance.ModDirectory, "Catalog");
        public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");
        public static SpriteAtlas ShrekAtlas;
        public static Sprite[] ShrekSprites;

        public static EventReference testReference = new FMODUnity.EventReference()
        {
            Guid = new FMOD.GUID()
            {
                Data1 = "hope.wildfrost.vfx".GetHashCode(),
                Data2 = "other mod guid".GetHashCode(),
                Data3 = "test".GetHashCode(),
                Data4 = "sound name".GetHashCode()
            }
        };

        public override void Load()
        {
            /*FMODUnity.RuntimeManager.CoreSystem.getMasterSoundGroup(out var soundGroup1);
            Debug.LogWarning(soundGroup1.hasHandle());
            //soundGroup1.
            Debug.LogWarning(soundGroup1.getName(out string name, 100));
            Debug.LogWarning(name);
            if (soundGroup1.getNumSounds(out int numSounds) == FMOD.RESULT.OK)
            {
                for (int i = 0; i < numSounds; i++)
                {
                    soundGroup1.getSound(i, out var sound);
                    sound.getName(out string n, 100);
                    Debug.LogError(n);
                }
            }*/

            HopeSFXSystem.PatchAddCommandCreateSFX.Prefix();

            parent = new GameObject(Title).transform;
            GameObject.DontDestroyOnLoad(parent.gameObject);

            Events.OnEntityKilled += OnEntityKilled;
            Events.OnSceneLoaded += PlayShrekMovieOnCreditsScene;

            if (!Directory.Exists(ImagesDirectory))
                Directory.CreateDirectory(ImagesDirectory);

            VFX = new GIFLoader(this, ImagesDirectory, GIFLoader.PlayType.applyEffect, true, true);
            VFX.RegisterAllAsApplyEffect();
            GIFLoader.OnEffectPlayed += OnEffectPlayed;

            SFX = new SFXLoader(ImagesDirectory);
            SFX.RegisterAllSoundsToGlobal();
            Events.OnStatusEffectApplied += OnStatusAppliedCheckCooldown;
            Events.OnEntityHit += OnEntityHitEffectDamageSFXCheckCooldown;
            Events.OnEntityHit += OnEntityHitWhenHitSFXCheckCooldown;

            IconSprite.name = GUID;
            spriteAsset = HopeUtils.CreateSpriteAsset(GUID,
                ImagesDirectory, [], [IconSprite]
                );//<sprite name="hope.wildfrost.vfx">
            spriteAsset.RegisterSpriteAsset();

            base.Load();

            //UpdateDisplayer();
        }

        public void OnEntityKilled(Entity entity, DeathType death)
        {
            if (death == DeathType.Sacrifice) return;
            if (PeepoVanish)
            {
                var transform = entity.transform;
                VFX.TryPlayEffect("vanish", transform.position, transform.lossyScale);
            }
        }
        public void OnEffectPlayed(GameObject gameObject)
        {
            Debug.Log("[VFX Tools] PLAYED " + gameObject);
            if (gameObject.name == Deadpan.Enums.Engine.Components.Modding.Extensions.PrefixGUID("vanish", this))
                SFX.TryPlaySound("sansfx");
        }

        public void OnStatusAppliedCheckCooldown(StatusEffectApply apply)
        {
            if (!apply?.effectData || !apply.target.display.init || !apply.target.startingEffectsApplied || Transition.Running)
                return;

            if (apply.effectData.type.IsNullOrWhitespace())
                return;

            if (!SfxSystem.CheckCooldown(apply.effectData.type))
                return;


            Debug.Log("[SFX Tools] APPLIED " + apply.effectData.type);
            if (HopeSFXSystem.sounds.TryGetValue(apply.effectData.type, out FMOD.Sound sound))
            {
                SFXLoader.PlaySound(sound);
                SfxSystem.SetCooldown(apply.effectData.type);
            }
            else if (HopeSFXSystem.eventRefs.TryGetValue(apply.effectData.type, out var eventRef))
            {
                SfxSystem.OneShot(eventRef);
                SfxSystem.SetCooldown(apply.effectData.type);
            }
        }

        public void OnEntityHitEffectDamageSFXCheckCooldown(Hit hit)
        {
            if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit || !hit.target)
                return;

            if (SfxSystem.GetHitPower(hit) < 0)
                return;

            if (hit.damageType.IsNullOrWhitespace())
                return;

            if (!SfxSystem.CheckCooldown(hit.damageType))
                return;


            Debug.Log("[SFX Tools] EFFECT DAMAGE: " + hit.damageType); 
            if (HopeSFXSystem.sounds.TryGetValue("damage." + hit.damageType, out FMOD.Sound sound))
            {
                SFXLoader.PlaySound(sound);
                SfxSystem.SetCooldown("damage." + hit.damageType);
            }
            if (HopeSFXSystem.sounds.TryGetValue(hit.damageType, out sound))
            {
                SFXLoader.PlaySound(sound);
                SfxSystem.SetCooldown(hit.damageType);
            }
            else if (HopeSFXSystem.eventRefs.TryGetValue(hit.damageType, out var eventRef))
            {
                SfxSystem.OneShot(eventRef);
                SfxSystem.SetCooldown(hit.damageType);
            }
        }
        public void OnEntityHitWhenHitSFXCheckCooldown(Hit hit)
        {
            if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit || !hit.BasicHit || VfxHitSystem.GetHitPower(hit) <= 0 || !hit.target)
                return;

            foreach (var type in HopeSFXSystem.whenHitSounds.Keys)
                if (hit.target.FindStatus(type))
                {
                    SFXLoader.PlaySound(HopeSFXSystem.whenHitSounds[type]);
                    SfxSystem.SetCooldown("hit." + type);
                }
        }

        public void PlayShrekMovieOnCreditsScene(Scene scene)
        {
            if (scene.name != "Credits")
                return;

            if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
                Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();

            Debug.LogWarning("Get your popcorn!!");

            if (ShrekSprites == null)
            {
                ShrekAtlas = Addressables.LoadAssetAsync<SpriteAtlas>($"Assets/hope.wildfrost.mymod/Shrek.spriteatlas").WaitForCompletion();
                //string prefix = "86628d26a77841299f993b6cd7fe0068Mr8Fp7ofR1ATkYs7-";
                ShrekSprites = new Sprite[ShrekAtlas.spriteCount];
                ShrekAtlas.GetSprites(ShrekSprites);
                var ShrekSpritesList = ShrekSprites.Select(t => { t.name = t.name.Split('-')[1].Replace("(Clone)", ""); return t; }).ToList();
                ShrekSpritesList.Sort((x, y) => Convert.ToInt32(x.name).CompareTo(Convert.ToInt32(y.name)));
                ShrekSprites = ShrekSpritesList.ToArray();
            }

            GameObject shrekObj = VFX.TryGetPrefab("ShrekMovie") ?? VFX.LoadSprites("ShrekMovie", ShrekSprites, 0.05f);
            static IEnumerator playDelay(GameObject shrekObj)
            {
                yield return new WaitForSeconds(0.1f); ;

                var credits = GameObject.Find("Canvas/CreditsLayout(Clone)");
                if (credits)
                {
                    Debug.LogWarning("We're about to start");
                    var shrekInst = GIFLoader.PlayEffect(shrekObj, Vector3.zero, Vector3.one);
                    shrekInst.transform.SetParent(credits.transform, true);
                    shrekInst.transform.SetAsFirstSibling();
                    shrekInst.transform.SetLocalRotationY(0);
                    shrekInst.AddComponent<LayoutElement>();
                    shrekInst.transform.localScale = 2 * Vector3.one;
                }
            }
            CoroutineManager.Start(playDelay(shrekObj));

        }

        public override void Unload()
        {
            base.Unload();
            Events.OnEntityKilled -= OnEntityKilled;
            Events.OnSceneLoaded -= PlayShrekMovieOnCreditsScene;
            GIFLoader.OnEffectPlayed -= OnEffectPlayed;
            Events.OnStatusEffectApplied -= OnStatusAppliedCheckCooldown;
            Events.OnEntityHit -= OnEntityHitEffectDamageSFXCheckCooldown;
            Events.OnEntityHit -= OnEntityHitWhenHitSFXCheckCooldown;
        }
    }
}
