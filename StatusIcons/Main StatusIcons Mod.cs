using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using WildfrostHopeMod.Utils;
using WildfrostHopeMod.VFX;
using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;

namespace StatusIcons
{
    public class StatusIconsMod : WildfrostMod
    {
        public override string GUID => "hope.wildfrost.tutorial";
        public override string[] Depends => new string[] { "hope.wildfrost.vfx" };
        public override string Title => "Tutorial: Creating Status Icons";
        public override string Description => "Learn how to make a new status effect with a custom icon!";

        private bool preLoaded = false; 


        public static List<object> assets = [];
        private CardData.StatusEffectStacks SStack(string name, int amount) => new CardData.StatusEffectStacks(Get<StatusEffectData>(name), amount);


        // REQUIRED: this is here to allow our icon to appear in the text box of cards
        public override TMP_SpriteAsset SpriteAsset => spriteAsset;
        internal static TMP_SpriteAsset spriteAsset;

        public override void Load()
        {
            if (!preLoaded)
            {
                // IMPORTANT: SpriteAsset has to be defined before all icons are made
                // Allow our icons in card descriptions
                spriteAsset = HopeUtils.CreateSpriteAsset(Title
                    //, directoryWithPNGs: ImagePath("Icons")
                    );
                

                CreateModAssets();

                preLoaded = true;
            }
            SpriteAsset.RegisterSpriteAsset();
            base.Load();

            // TEMPORARY: This tests our icons by giving every companion card their status, when the mod loads
            foreach (var c in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                if (!c) continue;
                //if (c.cardType.name != "Friendly") continue;
                if (!c.cardType.canDie) continue;

                // Remove nulls if any
                c.startWithEffects = c.startWithEffects.Where(s => s.data != null).ToArray();
                c.attackEffects = c.attackEffects.Where(s => s.data != null).ToArray();

                if (SStack("amber effect", 1).data)
                {
                    c.startWithEffects = c.startWithEffects.With(SStack("amber effect", 4));
                    // To test that "Apply X" description automatically shows up
                    c.attackEffects = c.attackEffects.With(SStack("amber effect", 1));
                }

                if (SStack("a random card's effect", 1).data)
                    c.startWithEffects = c.startWithEffects.With(SStack("a random card's effect", 1));
            }
        }

        public override void Unload()
        {
            base.Unload();

            // Prevent our icons from accidentally showing up in descriptions when not loaded
            SpriteAsset.UnRegisterSpriteAsset(); 
            

            // Not necessary: this is to undo the test
            foreach (var c in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                if (!c) continue;

                c.startWithEffects = c.startWithEffects.Where(s => s.data?.ModAdded != this).ToArray();
                c.attackEffects = c.attackEffects.Where(s => s.data?.ModAdded != this).ToArray();
            }
        }



        public void CreateModAssets()
        {
            AssetExampleInDetail();
            AssetExampleShort();
        }
        public void AssetExampleInDetail()
        {
            assets.AddRange(new object[] {
                    new KeywordDataBuilder(this)    // Nothing different is necessary for Keywords
                    .Create("amber")                // Make them as you usually would, without icons
                    .WithTitle("Amber")
                    .WithDescription("""
                         |Fossilised tree sap, which we call amber, waited for millions of years with the mosquito inside. 
                        
                        Using sophisticated techniques, they extract the preserved blood from the mosquito, and bingo: Dino DNA!
                        """)
                    ,

                    new StatusIconBuilder(this)
                    .Create(name: "amber icon",     // Used in StatusEffectDataBuilder.Subscribe_WithStatusIcon()
                            statusType: "hope.amber",   // Ideally your statusType should be more than one word to avoid mod conflict
                            ImagePath("Icons/hope.amber.png"))  // Ideally the filename == status type, but VFX mod will try to adjust it
                                                                // Avoid manually using .ToSprite() if possible,
                                                                // ...or use .ToSpriteFull()
                    .WithIconGroupName(StatusIconBuilder.IconGroups.counter) // To show up under health icons

                    // Icons without text can skip these two altogether
                    .WithTextColour(new Color(0.2f, 0f, 0f, 0.8f), 
                    textColourAboveMax:new Color(0, 1f, 0f, 0.8f), 
                    textColourBelowMax:new Color(0f, 0f, 1f, 0.8f))          // 80% opacity, very dark red
                    .WithTextShadow(new Color(1f, 1f, 0f, 1f), offsetY:-1f) // Opaque yellow shadow, moved further down (default y offset: -0.75f)

                    .WithTextboxSprite()                                    // This version reuses the main sprite for the textbox
                    //.WithTextboxSprite(ImagePath("Icons/amber.png"))      // This version is slightly slower, but lets you use other (lower-res) textbox sprites
                    
                    .WithApplyVFX(VFXMod.instance?.ImagePath("../icon.gif"))         // Replace with your own GIF or APNG filepath
                    .WithApplySFX(VFXMod.instance?.ImagePath("42 - Eyecatch 2.mp3")) // Replace with your own MP3/WAV/OGG etc filepath
                    .WithKeywords(iconKeywordOrNull:"amber") // the "icon keyword" will be adjusted to show the icon's textbox sprite
                    ,

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectSnow>("amber effect")
                    // Make your effect as usual, except...
                    .Subscribe_WithStatusIcon("amber icon") // All-in-one handler for setting up a status.
                                                     // ONLY ONE ICON PER STATUS!
                    ,

            });
            assets.AddRange(new object[] {
                    new KeywordDataBuilder(this)    // Nothing different is necessary for Keywords
                    .Create("amber2")                // Make them as you usually would, without icons
                    .WithTitle("Amber2")
                    .WithDescription("""
                         |Fossilised tree sap, which we call amber, waited for millions of years with the mosquito inside. 
                        
                        Using sophisticated techniques, they extract the preserved blood from the mosquito, and bingo: Dino DNA!
                        """)
                    ,

                    new StatusIconBuilder(this)
                    .Create(name: "amber icon2",     // Used in StatusEffectDataBuilder.Subscribe_WithStatusIcon()
                            statusType: "hope.test2",   // Ideally your statusType should be more than one word to avoid mod conflict
                            ImagePath("Icons/tall.png"))  // Ideally the filename == status type, but VFX mod will try to adjust it
                                                                // Avoid manually using .ToSprite() if possible,
                                                                // ...or use .ToSpriteFull()
                    .WithIconGroupName(StatusIconBuilder.IconGroups.health) // To show up under health icons

                    // Icons without text can skip these two altogether
                    //.WithTextColour(new Color(0.2f, 0f, 0f, 0.8f))          // 80% opacity, very dark red
                    .WithTextShadow(new Color(1f, 1f, 0f, 1f), offsetY:-1f) // Opaque yellow shadow, moved further down (default y offset: -0.75f)

                    .WithTextboxSprite()                                    // This version reuses the main sprite for the textbox
                    //.WithTextboxSprite(ImagePath("Icons/amber.png"))      // This version is slightly slower, but lets you use other (lower-res) textbox sprites
                    
                    .WithApplyVFX(VFXMod.instance?.ImagePath("../icon.gif"))         // Replace with your own GIF or APNG filepath
                    .WithApplySFX(VFXMod.instance?.ImagePath("42 - Eyecatch 2.mp3")) // Replace with your own MP3/WAV/OGG etc filepath
                    .WithKeywords(iconKeywordOrNull:"amber2") // the "icon keyword" will be adjusted to show the icon's textbox sprite
                    ,

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectSnow>("amber effect2")
                    // Make your effect as usual, except...
                    .Subscribe_WithStatusIcon("amber icon2") // All-in-one handler for setting up a status.
                                                     // ONLY ONE ICON PER STATUS!
                    ,

            });
        }

        public void AssetExampleShort()
        {
            var funnycard = AddressableLoader.GetGroup<CardData>(nameof(CardData)).Where(c => c.mainSprite != null && c.mainSprite.name != "Nothing").ToList().RandomItem();
            Sprite sprite = null;
            try { sprite = HopeUtils.GetCardSprite(funnycard, rename: "funny card sprite"); } catch (Exception e) { Debug.LogError("FUCK"); Debug.LogException(e); }

            assets.AddRange(new object[] {
                    new KeywordDataBuilder(this)
                    .Create("the random card keyword")
                    .WithTitle("Some Guy")
                    .WithDescription("""
                         |...

                        Hey, how'd you get there?
                        """)
                    ,

                    new StatusIconBuilder(this)
                    .Create(name: "a random card's icon",
                            statusType: "hope.card",
                            sprite: sprite)
                    .WithIconGroupName(StatusIconBuilder.IconGroups.counter)

                    /*.WithTextColour(new Color(0.2f, 0f, 0f, 0.8f))      // This icon won't have any text
                    .WithTextShadow(new Color(1f, 1f, 0f, 1f), offsetY:-1f)*/
                    //.WithTextboxSprite()                                // This version reuses the main sprite for the textbox
                    .WithTextboxSprite(ImagePath("Icons/crown.png"))      // This version is slightly slower, but lets you use other textbox sprites
                    .WithApplyVFX(VFXMod.instance?.ImagePath("../icon.gif"))
                    .WithApplySFX(VFXMod.instance?.ImagePath("42 - Eyecatch 2.mp3"))
                    .WithKeywords(iconKeywordOrNull: "the random card keyword")
                    ,

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectSnow>("a random card's effect")
                    .Subscribe_WithStatusIcon("a random card's icon")
                    ,

             });
            _ = nameof(LocalizationHelper);
        }


        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}s: {assets.OfType<T>().Join(a => Path.GetExtension(a._data.name))}");
            return assets.OfType<T>().ToList();
        }
    }
}