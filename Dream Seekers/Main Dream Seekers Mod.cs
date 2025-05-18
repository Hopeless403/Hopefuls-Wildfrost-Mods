using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

namespace DreamSeekers
{
    public class DreamSeekersMod : WildfrostMod
    {
        public DreamSeekersMod(string modDirectory) : base(modDirectory) => instance = this;
        public static DreamSeekersMod instance;
        public override string GUID => "hope.wildfrost.dreamseekers";
        public override string[] Depends => new string[] { };
        public override string Title => "Dream Seekers";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {
            foreach (var card in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                card.cardType = Get<CardType>("Leader");
            }
            Debug.LogWarning(GetAsset<GameObject>("CardPrefabLeader"));
            GetAsset<GameObject>("CardPrefabLeader").GetComponent<Card>()?
                .mainImage?.gameObject.SetActive(true);
            /*foreach (var card in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                Debug.Log(card.name);
                Debug.LogWarning(PrintLstring(card.titleKey));
            }*/
            //LocalizationSettings.AssetDatabase;



            /*foreach (var data in AddressableLoader.GetGroup<StatusEffectData>(nameof(StatusEffectData)))
            {
                Debug.Log(data.name);
                Debug.LogWarning(PrintLstring(data.textKey));
                Debug.LogWarning(data.textInsert);
            }*/
            base.Load();

            /*foreach (var table in Resources.FindObjectsOfTypeAll<LocalizationTable>())
            {
                Debug.Log(table);
                
            }*/

            StringBuilder builder = new StringBuilder();
            List<string> locations = """
                CardIcons
                CardPrefab
                CardPrefabBoss
                CardPrefabClunker
                CardPrefabEnemy
                CardPrefabItem
                CardPrefabLeader
                CardPrefabMiniboss
                CardPrefabSummoned
                """.Split(['\n']).Select(s => s.Trim()).ToList();
            foreach (var locale in locations)
            {
                new List<string> { }.Sort();
                Debug.Log($"({locale})");
                //var localeLabel = "Locale-" + locale.Formatter;
                var tables = Addressables.LoadResourceLocationsAsync(locale, typeof(GameObject)).WaitForCompletion();
                foreach (var tableLocation in tables)
                {
                    var table = Addressables.LoadAssetAsync<GameObject>(tableLocation.PrimaryKey).WaitForCompletion();
                    Debug.LogWarning(table);
                    /*if (table.name.Contains("Card Text"))
                    foreach (var entry in table.SharedData.Entries)
                    {
                        if (table.GetEntry(entry.Key) == null) continue;
                        //Debug.LogWarning((locale, entry.Key));
                        Debug.Log(table.GetEntry(entry.Key).GetLocalizedString());
                        builder.AppendLine(table.GetEntry(entry.Key).GetLocalizedString());
                        
                    }*/
                }
            }

            var allSprites = Resources.FindObjectsOfTypeAll<Sprite>();
            foreach (var m in addresses.Split(["\r\n"], StringSplitOptions.None))
            {
                string name = Path.GetFileNameWithoutExtension(m.Trim());
                Sprite s = allSprites.FirstOrDefault(ss => ss.name == name);
                builder.AppendLine($"{m.Trim()}\t{s?.texture.name}");
            }
            GUIUtility.systemCopyBuffer = builder.ToString();

        }

        public const string addresses = """
            Assets/ability counter.asset	
            Assets/amber.asset	
            Assets/attack.asset	
            Assets/barrage.asset	
            Assets/bling.asset	
            Assets/blitz.asset	
            Assets/block.asset	
            Assets/CardShadow.asset	
            Assets/Charm Knot 2.asset	
            Assets/CharmSheet_0.asset	
            Assets/CharmSheet_1.asset	
            Assets/CharmSheet_2.asset	
            Assets/CharmSheet_3.asset	
            Assets/CharmSheet_4.asset	
            Assets/CharmSheet_5.asset	
            Assets/CharmSheet_6.asset	
            Assets/CharmSheet_7.asset	
            Assets/CharmSheet_8.asset	
            Assets/CharmSheet_9.asset	
            Assets/CharmSheet_10.asset	
            Assets/CharmSheet_11.asset	
            Assets/CharmSheet_12.asset	
            Assets/CharmSheet_13.asset	
            Assets/CharmSheet_14.asset	
            Assets/CharmSheet_15.asset	
            Assets/CharmSheet_16.asset	
            Assets/CharmSheet_17.asset	
            Assets/CharmSheet_18.asset	
            Assets/CharmSheet_19.asset	
            Assets/CharmSheet_20.asset	
            Assets/CharmSheet_21.asset	
            Assets/CharmSheet_22.asset	
            Assets/CharmSheet_23.asset	
            Assets/CharmSheet_24.asset	
            Assets/CharmSheet_25.asset	
            Assets/CharmSheet_26.asset	
            Assets/CharmSheet_27.asset	
            Assets/CharmSheet_28.asset	
            Assets/CharmSheet_29.asset	
            Assets/CharmSheet_30.asset	
            Assets/CharmSheet_31.asset	
            Assets/CharmSheet_32.asset	
            Assets/CharmSheet_33.asset	
            Assets/CharmSheet_34.asset	
            Assets/CharmSheet_35.asset	
            Assets/CharmSheet_36.asset	
            Assets/CharmSheet_37.asset	
            Assets/CharmSheet_38.asset	
            Assets/CharmSheet_39.asset	
            Assets/CharmSheet_40.asset	
            Assets/CharmSheet_41.asset	
            Assets/CharmSheet_42.asset	
            Assets/CharmSheet_43.asset	
            Assets/CharmSheet_44.asset	
            Assets/CharmSheet_45.asset	
            Assets/CharmSheet_46.asset	
            Assets/CharmSheet_47.asset	
            Assets/CharmSheet_48.asset	
            Assets/CharmSheet_49.asset	
            Assets/CharmSheet_50.asset	
            Assets/CharmSheet_51.asset	
            Assets/CharmSheet_52.asset	
            Assets/CharmSheet_53.asset	
            Assets/CharmSheet_54.asset	
            Assets/CharmSheet_55.asset	
            Assets/CharmSheet_56.asset	
            Assets/CharmSheet_57.asset	
            Assets/CharmSheet_58.asset	
            Assets/CharmSheet_59.asset	
            Assets/CharmSheet_60.asset	
            Assets/CharmSheet_61.asset	
            Assets/CharmSheet_62.asset	
            Assets/CharmSheet_63.asset	
            Assets/CharmSheet_64.asset	
            Assets/CharmSheet_65.asset	
            Assets/CharmSheet_66.asset	
            Assets/CharmSheet_67.asset	
            Assets/CharmSheet_68.asset	
            Assets/CharmSheet_69.asset	
            Assets/CharmSheet_70.asset	
            Assets/CharmSheet_71.asset	
            Assets/CharmSheet_72.asset	
            Assets/CharmSheet_73.asset	
            Assets/CharmSheet_74.asset	
            Assets/CharmSheet_75.asset	
            Assets/CharmSheet_76.asset	
            Assets/CharmSheet_77.asset	
            Assets/CharmSheet_78.asset	
            Assets/CharmSheet_79.asset	
            Assets/CharmSheet_80.asset	
            Assets/Content/Images/Bosses/ClunkBomber/GoatBomber BG_0.asset	
            Assets/Content/Images/Bosses/ClunkBomber/GoatBomber BG_0_0.asset	
            Assets/Content/Images/Bosses/ClunkBomber/Rocket.asset	
            Assets/Content/Images/Bosses/ClunkBomber/Rocket_0.asset	
            Assets/Content/Images/Bosses/Snoctus/Boozle BG.asset	
            Assets/Content/Images/Bosses/Snoctus/Boozle BG_0.asset	
            Assets/Content/Images/Bosses/Snoctus/Boozle.asset	
            Assets/Content/Images/Bosses/Snoctus/Boozle_0.asset	
            Assets/Content/Images/Bosses/Snoctus/Snoctus_BG.asset	
            Assets/Content/Images/Bosses/Snoctus/Snoctus_BG_0.asset	
            Assets/Content/Images/Bosses/Snoctus/Snoozle BG.asset	
            Assets/Content/Images/Bosses/Snoctus/Snoozle BG_0.asset	
            Assets/Content/Images/Bosses/Snoctus/Snoozle.asset	
            Assets/Content/Images/Bosses/Snoctus/Snoozle_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Clunkers/Woodhead.asset	
            Assets/Content/Images/Cards/Backgrounds/Clunkers/Woodhead_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Enemies/Snoolf.asset	
            Assets/Content/Images/Cards/Backgrounds/Enemies/Snoolf_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Berry Queen BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Berry Queen BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Big Peng BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Big Peng BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Bigloo BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Bigloo BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Bolgo BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Bolgo BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Bombear BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Bombear BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Frost Guardian BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Frost Guardian BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Guka-Guka BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Guka-Guka BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The monkey king BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The monkey king BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The Ringer Bg.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The Ringer Bg_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The Snow Knight_BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The Snow Knight_BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The vailed lady BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/The vailed lady BG_0.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Toothless BG.asset	
            Assets/Content/Images/Cards/Backgrounds/Minibosses/Toothless BG_0.asset	
            Assets/Content/Images/Cards/BossInteraction.asset	
            Assets/Content/Images/Cards/BossInteraction_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Boss Frame Outline.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Boss Frame Outline_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Boss Frame.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Boss Frame_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Companion Frame.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Companion Frame_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Enemy Frame.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Enemy Frame_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Item Frame.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Item Frame_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Leader Frame.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/Leader Frame_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/MiniBoss Frame Outline.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/MiniBoss Frame Outline_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/MiniBoss Frame.asset	
            Assets/Content/Images/Cards/Frames 2.0/Frames/MiniBoss Frame_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/NameTags/Boss Nametag.asset	
            Assets/Content/Images/Cards/Frames 2.0/NameTags/Boss Nametag_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/NameTags/MiniBoss Nametag.asset	
            Assets/Content/Images/Cards/Frames 2.0/NameTags/MiniBoss Nametag_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/NameTags/Summon Nametag.asset	
            Assets/Content/Images/Cards/Frames 2.0/NameTags/Summon Nametag_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Boss Textbox.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Boss Textbox_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Companion Textbox.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Companion Textbox_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Enemy Textbox.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Enemy Textbox_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Item Textbox.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Item Textbox_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Leader Textbox.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/Leader Textbox_0.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/MiniBoss Textbox.asset	
            Assets/Content/Images/Cards/Frames 2.0/TextBoxes/MiniBoss Textbox_0.asset	
            Assets/Content/Images/Cards/Images/Clunkers/Woodhead.asset	
            Assets/Content/Images/Cards/Images/Clunkers/Woodhead_0.asset	
            Assets/Content/Images/Cards/Images/Enemies/Snoolf.asset	
            Assets/Content/Images/Cards/Images/Enemies/Snoolf_0.asset	
            Assets/Content/Images/Cards/Images/Items/Sun rattle rod.asset	
            Assets/Content/Images/Cards/Images/Items/Sun rattle rod_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Berry Queen.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Berry Queen_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Big Peng.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Big Peng_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bigloo.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bigloo_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_01.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_01_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_02.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_02_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_03.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_03_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_04.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_04_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_05.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bolgo_05_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bombear.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Bombear_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Frost Guardian.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Frost Guardian_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Frost Wizard.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Frost Wizard_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Guka-Guka.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Guka-Guka_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The monkey king.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The monkey king_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The Ringer.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The Ringer_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The Snow Knight.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The Snow Knight_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The vailed lady.asset	
            Assets/Content/Images/Cards/Images/Minibosses/The vailed lady_0.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Toothless.asset	
            Assets/Content/Images/Cards/Images/Minibosses/Toothless_0.asset	
            Assets/Content/Images/UI/Layered Icons/Boss_Heart_Frame.asset	
            Assets/Content/Images/UI/Layered Icons/Boss_Heart_Frame_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_attack_layers_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_attack_layers_0_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_attack_layers_1.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_attack_layers_1_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_attack_layers_2.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_attack_layers_2_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_Heart_Backlayer.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_Heart_Backlayer_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_Heart_Frame.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_Heart_Frame_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_immune_back.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_immune_back_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_immune_front.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_immune_front_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_resistance_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_resistance_0_0.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_resistance_1.asset	
            Assets/Content/Images/UI/Layered Icons/Icon_resistance_1_0.asset	
            Assets/Content/Images/UI/Layered Icons/Leader_Heart_Back.asset	
            Assets/Content/Images/UI/Layered Icons/Leader_Heart_Back_0.asset	
            Assets/Content/Images/UI/Layered Icons/Leader_Heart_Fill.asset	
            Assets/Content/Images/UI/Layered Icons/Leader_Heart_Fill_0.asset	
            Assets/Content/Images/UI/Layered Icons/Leader_Heart_Frame.asset	
            Assets/Content/Images/UI/Layered Icons/Leader_Heart_Frame_0.asset	
            Assets/Content/Images/VFX/Splat sprites_0.asset	
            Assets/Content/Images/VFX/Splat sprites_0_0.asset	
            Assets/Content/Images/VFX/Splat sprites_1.asset	
            Assets/Content/Images/VFX/Splat sprites_1_0.asset	
            Assets/Content/Images/VFX/Splat sprites_2.asset	
            Assets/Content/Images/VFX/Splat sprites_2_0.asset	
            Assets/Content/Images/VFX/Splat sprites_3.asset	
            Assets/Content/Images/VFX/Splat sprites_3_0.asset	
            Assets/Content/Images/VFX/Splat sprites_4.asset	
            Assets/Content/Images/VFX/Splat sprites_4_0.asset	
            Assets/Content/Images/VFX/Splat sprites_5.asset	
            Assets/Content/Images/VFX/Splat sprites_5_0.asset	
            Assets/Content/Images/VFX/Splat sprites_6.asset	
            Assets/Content/Images/VFX/Splat sprites_6_0.asset	
            Assets/Content/Images/VFX/Splat sprites_7.asset	
            Assets/Content/Images/VFX/Splat sprites_7_0.asset	
            Assets/counter red.asset	
            Assets/counter.asset	
            Assets/counter_snow.asset	
            Assets/crown.asset	
            Assets/demonize.asset	
            Assets/enemy crown.asset	
            Assets/Flag_BerryPet.asset	
            Assets/Flag_BoostPet.asset	
            Assets/Flag_DemonPet.asset	
            Assets/Flag_DrawPet.asset	
            Assets/Flag_SnowPet.asset	
            Assets/Flag_TeethPet.asset	
            Assets/Flag_Tribe1.asset	
            Assets/Flag_Tribe2.asset	
            Assets/Flag_Tribe3.asset	
            Assets/Flags_InkPet.asset	
            Assets/frenzy.asset	
            Assets/frenzy2.asset	
            Assets/frost.asset	
            Assets/health.asset	
            Assets/Ice Breakers Hut.asset	
            Assets/icon_sheet_23.asset	
            Assets/icon_sheet_27.asset	
            Assets/icon_sheet_35.asset	
            Assets/icon_sheet_38.asset	
            Assets/icon_sheet_39.asset	
            Assets/icon_sheet_40.asset	
            Assets/icon_sheet_41.asset	
            Assets/icon_sheet_42.asset	
            Assets/icon_sheet_43.asset	
            Assets/icon_sheet_44.asset	
            Assets/icon_sheet_45.asset	
            Assets/icon_sheet_46.asset	
            Assets/icon_sheet_47.asset	
            Assets/icon_sheet_48.asset	
            Assets/icon_sheet_49.asset	
            Assets/icon_sheet_50.asset	
            Assets/icon_sheet_51.asset	
            Assets/icon_sheet_52.asset	
            Assets/icon_sheet_53.asset	
            Assets/icon_sheet_54.asset	
            Assets/icon_sheet_55.asset	
            Assets/icon_sheet_56.asset	
            Assets/icon_sheet_57.asset	
            Assets/icon_sheet_58.asset	
            Assets/icon_sheet_59.asset	
            Assets/icon_sheet_60.asset	
            Assets/icon_sheet_61.asset	
            Assets/icon_sheet_62.asset	
            Assets/icon_sheet_63.asset	
            Assets/icon_sheet_64.asset	
            Assets/icon_sheet_65.asset	
            Assets/icon_sheet_66.asset	
            Assets/icon_sheet_67.asset	
            Assets/icon_sheet_68.asset	
            Assets/icon_sheet_69.asset	
            Assets/icon_sheet_70.asset	
            Assets/icon_sheet_71.asset	
            Assets/icon_sheet_72.asset	
            Assets/icon_sheet_73.asset	
            Assets/icon_sheet_74.asset	
            Assets/icon_sheet_75.asset	
            Assets/icon_sheet_76.asset	
            Assets/icon_sheet_77.asset	
            Assets/icon_sheet_78.asset	
            Assets/icon_sheet_79.asset	
            Assets/icon_sheet_80.asset	
            Assets/icon_sheet_81.asset	
            Assets/icon_sheet_82.asset	
            Assets/icon_sheet_83.asset	
            Assets/icon_sheet_89.asset	
            Assets/icon_sheet_90.asset	
            Assets/icon_sheet_91.asset	
            Assets/icon_sheet_92.asset	
            Assets/icon_sheet_93.asset	
            Assets/icon_sheet_94.asset	
            Assets/icon_sheet_95.asset	
            Assets/icon_sheet_96.asset	
            Assets/icon_sheet_97.asset	
            Assets/icon_sheet_98.asset	
            Assets/icon_sheet_99.asset	
            Assets/icon_sheet_100.asset	
            Assets/icon_sheet_101.asset	
            Assets/icon_sheet_102.asset	
            Assets/icon_sheet_103.asset	
            Assets/icon_sheet_104.asset	
            Assets/icon_sheet_105.asset	
            Assets/icon_sheet_106.asset	
            Assets/icon_sheet_107.asset	
            Assets/icon_sheet_108.asset	
            Assets/icon_sheet_109.asset	
            Assets/icon_sheet_110.asset	
            Assets/icon_sheet_111.asset	
            Assets/icon_sheet_112.asset	
            Assets/icon_sheet_113.asset	
            Assets/icon_sheet_114.asset	
            Assets/icon_sheet_115.asset	
            Assets/icon_sheet_116.asset	
            Assets/icon_sheet_117.asset	
            Assets/icon_sheet_118.asset	
            Assets/icon_sheet_119.asset	
            Assets/icon_sheet_120.asset	
            Assets/icon_sheet_121.asset	
            Assets/icon_sheet_122.asset	
            Assets/icon_sheet_123.asset	
            Assets/icon_sheet_124.asset	
            Assets/icon_sheet_125.asset	
            Assets/icon_sheet_126.asset	
            Assets/icon_sheet_127.asset	
            Assets/icon_sheet_128.asset	
            Assets/icon_sheet_129.asset	
            Assets/icon_sheet_130.asset	
            Assets/icon_sheet_131.asset	
            Assets/icon_sheet_132.asset	
            Assets/icon_sheet_133.asset	
            Assets/icon_sheet_134.asset	
            Assets/icon_sheet_135.asset	
            Assets/icon_sheet_136.asset	
            Assets/icon_sheet_137.asset	
            Assets/icon_sheet_138.asset	
            Assets/icon_sheet_139.asset	
            Assets/icon_sheet_140.asset	
            Assets/icon_sheet_141.asset	
            Assets/icon_sheet_142.asset	
            Assets/icon_sheet_143.asset	
            Assets/ink.asset	
            Assets/Inventor Hut.asset	
            Assets/juice.asset	
            Assets/knockback.asset	
            Assets/lumin.asset	
            Assets/magma.asset	
            Assets/overload.asset	
            Assets/Pet House.asset	
            Assets/reaction.asset	
            Assets/reaction_snow.asset	
            Assets/recolour.asset	
            Assets/redraw.asset	
            Assets/resist.asset	
            Assets/scrap.asset	
            Assets/shell.asset	
            Assets/shroom.asset	
            Assets/smackback.asset	
            Assets/snow.asset	
            Assets/spice.asset	
            Assets/spikes.asset	
            Assets/Sprite/B.I.N.K BG.asset	
            Assets/Sprite/Balloon Dock.asset	
            Assets/Sprite/Balloon.asset	
            Assets/Sprite/Balloon_Outline.asset	
            Assets/Sprite/Basic 1.asset	
            Assets/Sprite/Basic 2.asset	
            Assets/Sprite/Basic 3.asset	
            Assets/Sprite/Basic 4.asset	
            Assets/Sprite/Bat Summon.asset	
            Assets/Sprite/Bat SummonBG.asset	
            Assets/Sprite/Beard 1.asset	
            Assets/Sprite/Beard 2.asset	
            Assets/Sprite/Beard 3.asset	
            Assets/Sprite/Beard 4.asset	
            Assets/Sprite/Beard 5.asset	
            Assets/Sprite/Beepop BG.asset	
            Assets/Sprite/Beepop.asset	
            Assets/Sprite/Bitebox BG.asset	
            Assets/Sprite/Bitebox.asset	
            Assets/Sprite/Black Candle BG.asset	
            Assets/Sprite/Black Candle.asset	
            Assets/Sprite/Blaze Bom BG.asset	
            Assets/Sprite/Bling Bank.asset	
            Assets/Sprite/Block 1.asset	
            Assets/Sprite/Block 2.asset	
            Assets/Sprite/BlunderTank BG.asset	
            Assets/Sprite/BlunderTank.asset	
            Assets/Sprite/Body Clunkmaster buff Weapon Mask.asset	
            Assets/Sprite/Body Clunkmaster buff.asset	
            Assets/Sprite/Body Clunkmaster jacket Weapon Mask.asset	
            Assets/Sprite/Body Clunkmaster jacket.asset	
            Assets/Sprite/Body Clunkmaster normal Weapon Mask.asset	
            Assets/Sprite/Body Clunkmaster normal.asset	
            Assets/Sprite/Body Shademancer Buff Weapon Mask.asset	
            Assets/Sprite/Body Shademancer Buff.asset	
            Assets/Sprite/Body Shademancer normal Weapon Mask.asset	
            Assets/Sprite/Body Shademancer normal.asset	
            Assets/Sprite/Body Shademancer short Weapon Mask.asset	
            Assets/Sprite/Body Shademancer short.asset	
            Assets/Sprite/Body Shademancer Tall Weapon Mask.asset	
            Assets/Sprite/Body Shademancer Tall.asset	
            Assets/Sprite/Body snowdwellers Buff Weapon Mask.asset	
            Assets/Sprite/Body snowdwellers Buff.asset	
            Assets/Sprite/Body snowdwellers Normal Weapon Mask.asset	
            Assets/Sprite/Body snowdwellers Normal.asset	
            Assets/Sprite/Body snowdwellers Short Weapon Mask.asset	
            Assets/Sprite/Body snowdwellers Short.asset	
            Assets/Sprite/Body snowdwellers Tall Weapon Mask.asset	
            Assets/Sprite/Body snowdwellers Tall.asset	
            Assets/Sprite/Bogberry BG.asset	
            Assets/Sprite/Bogberry.asset	
            Assets/Sprite/Bom Barrel BG.asset	
            Assets/Sprite/Bombarder BG.asset	
            Assets/Sprite/Bombarder.asset	
            Assets/Sprite/Boss_Heart_Back.asset	
            Assets/Sprite/Boss_Heart_Fill.asset	
            Assets/Sprite/Challenge Stone Shrine.asset	
            Assets/Sprite/Challenge Stone Shrine_Outline.asset	
            Assets/Sprite/Chikaboru BG.asset	
            Assets/Sprite/Chikaboru_1.asset	
            Assets/Sprite/Chikaboru_2.asset	
            Assets/Sprite/Chikaboru_3.asset	
            Assets/Sprite/Chikaboru_4.asset	
            Assets/Sprite/Chikaboru_5.asset	
            Assets/Sprite/Clockwork Bom BG.asset	
            Assets/Sprite/ClunkBomber phase1 full.asset	
            Assets/Sprite/ClunkBomber phase2 full.asset	
            Assets/Sprite/Clunker Frame Chiseled Outline.asset	
            Assets/Sprite/Clunker Frame Chiseled.asset	
            Assets/Sprite/Clunker Frame Golden.asset	
            Assets/Sprite/Clunker Frame Outline.asset	
            Assets/Sprite/Clunker Frame.asset	
            Assets/Sprite/Clunker Nametag Chiseled.asset	
            Assets/Sprite/Clunker Nametag.asset	
            Assets/Sprite/Clunker Textbox.asset	
            Assets/Sprite/ClunkerInteraction.asset	
            Assets/Sprite/Cursed_CharmSheet_0.asset	
            Assets/Sprite/Cursed_CharmSheet_1.asset	
            Assets/Sprite/Cursed_CharmSheet_2.asset	
            Assets/Sprite/Cursed_CharmSheet_3.asset	
            Assets/Sprite/Cursed_CharmSheet_4.asset	
            Assets/Sprite/Cursed_CharmSheet_5.asset	
            Assets/Sprite/Cursed_CharmSheet_6.asset	
            Assets/Sprite/Cursed_CharmSheet_7.asset	
            Assets/Sprite/Cursed_CharmSheet_8.asset	
            Assets/Sprite/Cursed_CharmSheet_9.asset	
            Assets/Sprite/Cursed_CharmSheet_10.asset	
            Assets/Sprite/Cursed_CharmSheet_11.asset	
            Assets/Sprite/Cursed_CharmSheet_12.asset	
            Assets/Sprite/Demonize 1.asset	
            Assets/Sprite/Demonize 2.asset	
            Assets/Sprite/Dregg BG.asset	
            Assets/Sprite/Dregg.asset	
            Assets/Sprite/Ear_01.asset	
            Assets/Sprite/Ear_02.asset	
            Assets/Sprite/Ear_03.asset	
            Assets/Sprite/Ear_04.asset	
            Assets/Sprite/Ear_05.asset	
            Assets/Sprite/Ear_06.asset	
            Assets/Sprite/Ear_07.asset	
            Assets/Sprite/Ear_08.asset	
            Assets/Sprite/Ears 1.asset	
            Assets/Sprite/Ears 2.asset	
            Assets/Sprite/Eyebrows_01.asset	
            Assets/Sprite/Eyebrows_02.asset	
            Assets/Sprite/Eyebrows_03.asset	
            Assets/Sprite/Eyebrows_04.asset	
            Assets/Sprite/Eyebrows_05.asset	
            Assets/Sprite/Eyes_01.asset	
            Assets/Sprite/Eyes_02.asset	
            Assets/Sprite/Eyes_03.asset	
            Assets/Sprite/Eyes_04.asset	
            Assets/Sprite/Eyes_05.asset	
            Assets/Sprite/Eyes_06.asset	
            Assets/Sprite/Eyes_07.asset	
            Assets/Sprite/Eyes_08.asset	
            Assets/Sprite/Eyes_09.asset	
            Assets/Sprite/Eyes_10.asset	
            Assets/Sprite/Eyes_11.asset	
            Assets/Sprite/Eyes_12.asset	
            Assets/Sprite/Eyes_13.asset	
            Assets/Sprite/Eyes_14.asset	
            Assets/Sprite/Eyes_Blinking.asset	
            Assets/Sprite/Face_Mask_01.asset	
            Assets/Sprite/Face_Mask_02.asset	
            Assets/Sprite/Final Boss Frame Outline.asset	
            Assets/Sprite/Final Boss Frame.asset	
            Assets/Sprite/Final Boss nametag.asset	
            Assets/Sprite/Final Boss Textbox.asset	
            Assets/Sprite/Frost 1.asset	
            Assets/Sprite/Frost 2.asset	
            Assets/Sprite/Frost Bomber BG.asset	
            Assets/Sprite/Frost Bomber.asset	
            Assets/Sprite/Frost Crusher BG.asset	
            Assets/Sprite/Frost Crusher.asset	
            Assets/Sprite/Frost forge BG.asset	
            Assets/Sprite/Frost forge.asset	
            Assets/Sprite/Frost Jailer BG.asset	
            Assets/Sprite/Frost Jailer.asset	
            Assets/Sprite/Frost Junker BG.asset	
            Assets/Sprite/Frost Junker.asset	
            Assets/Sprite/Frost lancer BG.asset	
            Assets/Sprite/Frost lancer.asset	
            Assets/Sprite/Frost Muncher BG.asset	
            Assets/Sprite/Frost Muncher.asset	
            Assets/Sprite/Frostoscope Building.asset	
            Assets/Sprite/Frostoscope Building_Outline.asset	
            Assets/Sprite/Gachapomper BG.asset	
            Assets/Sprite/Gachapomper.asset	
            Assets/Sprite/Gate 2_0.asset	
            Assets/Sprite/Gate 2_1.asset	
            Assets/Sprite/Gate.asset	
            Assets/Sprite/Gate_Outline.asset	
            Assets/Sprite/Gigi's Gizmo BG.asset	
            Assets/Sprite/Gnomehat 1.asset	
            Assets/Sprite/Gnomehat 2.asset	
            Assets/Sprite/Gnomehat 2_mask.asset	
            Assets/Sprite/Gnomehat 3.asset	
            Assets/Sprite/Gnomehat 3_mask.asset	
            Assets/Sprite/Gnomehat 4.asset	
            Assets/Sprite/Gnomehat 4_mask.asset	
            Assets/Sprite/Gnomehat 5.asset	
            Assets/Sprite/Gnomehat 5_mask.asset	
            Assets/Sprite/Goat totem BG.asset	
            Assets/Sprite/Goat totem.asset	
            Assets/Sprite/Hat_Bear_01.asset	
            Assets/Sprite/Hat_Bear_01_mask.asset	
            Assets/Sprite/Hat_Bear_02.asset	
            Assets/Sprite/Hat_Bear_02_mask.asset	
            Assets/Sprite/Hat_Bear_03.asset	
            Assets/Sprite/Hat_Bear_03_mask.asset	
            Assets/Sprite/Hat_Bunny_01.asset	
            Assets/Sprite/Hat_Bunny_01_mask.asset	
            Assets/Sprite/Hat_Bunny_02.asset	
            Assets/Sprite/Hat_Bunny_02_mask.asset	
            Assets/Sprite/Hat_Bunny_03.asset	
            Assets/Sprite/Hat_Bunny_03_mask.asset	
            Assets/Sprite/Hat_Cat_01.asset	
            Assets/Sprite/Hat_Cat_01_mask.asset	
            Assets/Sprite/Hat_Cat_02.asset	
            Assets/Sprite/Hat_Cat_02_mask.asset	
            Assets/Sprite/Hat_Cat_03.asset	
            Assets/Sprite/Hat_Cat_03_mask.asset	
            Assets/Sprite/Hat_Wolf_01.asset	
            Assets/Sprite/Hat_Wolf_01_mask.asset	
            Assets/Sprite/Hat_Wolf_02.asset	
            Assets/Sprite/Hat_Wolf_02_mask.asset	
            Assets/Sprite/Hat_Wolf_03.asset	
            Assets/Sprite/Hat_Wolf_03_mask.asset	
            Assets/Sprite/Haze Balloon BG.asset	
            Assets/Sprite/Haze Balloon.asset	
            Assets/Sprite/Heal 1.asset	
            Assets/Sprite/Heal 2.asset	
            Assets/Sprite/Heartforge BG.asset	
            Assets/Sprite/Heartforge.asset	
            Assets/Sprite/heartmist station BG.asset	
            Assets/Sprite/heartmist station.asset	
            Assets/Sprite/Hotsprings.asset	
            Assets/Sprite/Hotsprings_Outline.asset	
            Assets/Sprite/Ice Breakers Hut_outline.asset	
            Assets/Sprite/ICGM BG.asset	
            Assets/Sprite/ICGM.asset	
            Assets/Sprite/Icon_Heart_Fill.asset	
            Assets/Sprite/icon_hp_bubbled_BackLayer.asset	
            Assets/Sprite/icon_hp_bubbled_Fill.asset	
            Assets/Sprite/icon_hp_bubbled_Frame.asset	
            Assets/Sprite/Icon_ShadeHeart_Backlayer.asset	
            Assets/Sprite/Icon_ShadeHeart_Fill.asset	
            Assets/Sprite/Icon_ShadeHeart_Frame.asset	
            Assets/Sprite/Infernoko Phase 1 BG.asset	
            Assets/Sprite/Infernoko Phase 1.asset	
            Assets/Sprite/Infernoko Phase 2 BG.asset	
            Assets/Sprite/Infernoko Phase 2.asset	
            Assets/Sprite/Inventor Hut blades.asset	
            Assets/Sprite/Inventor Hut crystal mini 1.asset	
            Assets/Sprite/Inventor Hut crystal mini 2.asset	
            Assets/Sprite/Inventor Hut crystal.asset	
            Assets/Sprite/Inventor Hut prop back.asset	
            Assets/Sprite/Inventor Hut prop front.asset	
            Assets/Sprite/Inventor Hut_Outline.asset	
            Assets/Sprite/Junjun BG.asset	
            Assets/Sprite/Junjun.asset	
            Assets/Sprite/Kobonker BG.asset	
            Assets/Sprite/Kobonker.asset	
            Assets/Sprite/Krono BG.asset	
            Assets/Sprite/Krono.asset	
            Assets/Sprite/Leader Frame Outline.asset	
            Assets/Sprite/Leader Nametag.asset	
            Assets/Sprite/Leader Weapon Frost Sword.asset	
            Assets/Sprite/Leader Weapon Overburn Axe.asset	
            Assets/Sprite/Leader Weapon Spade.asset	
            Assets/Sprite/Leader Weapon Spear.asset	
            Assets/Sprite/LeaderInteraction.asset	
            Assets/Sprite/Lumako BG.asset	
            Assets/Sprite/Lumako.asset	
            Assets/Sprite/Mask_bunny_01.asset	
            Assets/Sprite/Mask_bunny_01_mask.asset	
            Assets/Sprite/Mask_bunny_02.asset	
            Assets/Sprite/Mask_bunny_02_mask.asset	
            Assets/Sprite/Mask_bunny_03.asset	
            Assets/Sprite/Mask_bunny_03_mask.asset	
            Assets/Sprite/Mask_Deer_01.asset	
            Assets/Sprite/Mask_Deer_01_mask.asset	
            Assets/Sprite/Mask_Deer_02.asset	
            Assets/Sprite/Mask_Deer_02_mask.asset	
            Assets/Sprite/Mask_Deer_03.asset	
            Assets/Sprite/Mask_Deer_03_mask.asset	
            Assets/Sprite/Mask_Goat_01.asset	
            Assets/Sprite/Mask_Goat_01_mask.asset	
            Assets/Sprite/Mask_Goat_02.asset	
            Assets/Sprite/Mask_Goat_02_mask.asset	
            Assets/Sprite/Mask_Goat_03.asset	
            Assets/Sprite/Mask_Goat_03_mask.asset	
            Assets/Sprite/Mask_Wolf_01.asset	
            Assets/Sprite/Mask_Wolf_01_mask.asset	
            Assets/Sprite/Mask_Wolf_02.asset	
            Assets/Sprite/Mask_Wolf_02_mask.asset	
            Assets/Sprite/Mask_Wolf_03.asset	
            Assets/Sprite/Mask_Wolf_03_mask.asset	
            Assets/Sprite/Mega mimik BG.asset	
            Assets/Sprite/Mega mimik.asset	
            Assets/Sprite/Mimik.asset	
            Assets/Sprite/Mimik_0.asset	
            Assets/Sprite/MobileCampfire.asset	
            Assets/Sprite/MobileCampfire1.asset	
            Assets/Sprite/Moko Totem BG.asset	
            Assets/Sprite/Moko Totem.asset	
            Assets/Sprite/Monkey spirit totem BG.asset	
            Assets/Sprite/Monkey spirit totem.asset	
            Assets/Sprite/Mouth_01.asset	
            Assets/Sprite/Mouth_02.asset	
            Assets/Sprite/Mouth_03.asset	
            Assets/Sprite/Mouth_04.asset	
            Assets/Sprite/Mouth_05.asset	
            Assets/Sprite/Mouth_06.asset	
            Assets/Sprite/Mouth_07.asset	
            Assets/Sprite/Mouth_08.asset	
            Assets/Sprite/Nimbus BG.asset	
            Assets/Sprite/Nimbus.asset	
            Assets/Sprite/Nose_01.asset	
            Assets/Sprite/Nose_02.asset	
            Assets/Sprite/Nose_03.asset	
            Assets/Sprite/Nose_04.asset	
            Assets/Sprite/Nose_05.asset	
            Assets/Sprite/Nose_06.asset	
            Assets/Sprite/Nose_07.asset	
            Assets/Sprite/Nose_08.asset	
            Assets/Sprite/numbers_0.asset	
            Assets/Sprite/numbers_1.asset	
            Assets/Sprite/numbers_2.asset	
            Assets/Sprite/numbers_3.asset	
            Assets/Sprite/numbers_4.asset	
            Assets/Sprite/numbers_5.asset	
            Assets/Sprite/numbers_6.asset	
            Assets/Sprite/numbers_7.asset	
            Assets/Sprite/numbers_8.asset	
            Assets/Sprite/numbers_9.asset	
            Assets/Sprite/numbers_x.asset	
            Assets/Sprite/numbers_X_0.asset	
            Assets/Sprite/palette.asset	
            Assets/Sprite/Pattern_01.asset	
            Assets/Sprite/Pattern_02.asset	
            Assets/Sprite/Pattern_03.asset	
            Assets/Sprite/Pepper Flag.asset	
            Assets/Sprite/Pepper Flag_0.asset	
            Assets/Sprite/Pet House Eyes.asset	
            Assets/Sprite/Pet House_Outline.asset	
            Assets/Sprite/Plinker BG.asset	
            Assets/Sprite/Plinker.asset	
            Assets/Sprite/Pom summon BG.asset	
            Assets/Sprite/Pom summon.asset	
            Assets/Sprite/Ponytail_01.asset	
            Assets/Sprite/Ponytail_02.asset	
            Assets/Sprite/Ponytail_03.asset	
            Assets/Sprite/Ponytail_04.asset	
            Assets/Sprite/Ponytail_05.asset	
            Assets/Sprite/Ponytail_06.asset	
            Assets/Sprite/Portable Workbench BG.asset	
            Assets/Sprite/Portable Workbench.asset	
            Assets/Sprite/Rookrab BG.asset	
            Assets/Sprite/Rookrab.asset	
            Assets/Sprite/Scraphead BG.asset	
            Assets/Sprite/Scraphead.asset	
            Assets/Sprite/Sheepopper Summon BG.asset	
            Assets/Sprite/Sheepopper Summon.asset	
            Assets/Sprite/Shell 1.asset	
            Assets/Sprite/Shikashu BG.asset	
            Assets/Sprite/Shikashu.asset	
            Assets/Sprite/Shroom 1.asset	
            Assets/Sprite/Shroom 2.asset	
            Assets/Sprite/Shroominator BG.asset	
            Assets/Sprite/Shroominator.asset	
            Assets/Sprite/Shroomine.asset	
            Assets/Sprite/Shroomine_0.asset	
            Assets/Sprite/Shroomlauncher BG.asset	
            Assets/Sprite/Shroomlauncher.asset	
            Assets/Sprite/Snoctus_Full.asset	
            Assets/Sprite/Snow 1.asset	
            Assets/Sprite/Snow 2.asset	
            Assets/Sprite/Spice 1.asset	
            Assets/Sprite/Spice 2.asset	
            Assets/Sprite/Spice sparklers BG.asset	
            Assets/Sprite/Spice sparklers.asset	
            Assets/Sprite/Spikehog BG.asset	
            Assets/Sprite/Spikehog.asset	
            Assets/Sprite/Spikewall BG.asset	
            Assets/Sprite/Spikewall.asset	
            Assets/Sprite/Summon Frame 2.asset	
            Assets/Sprite/Summon Frame Outline.asset	
            Assets/Sprite/Summon Textbox 2.asset	
            Assets/Sprite/SummonedInteraction.asset	
            Assets/Sprite/Sunglass Chime BG.asset	
            Assets/Sprite/Sunglass Chime.asset	
            Assets/Sprite/Tigris BG.asset	
            Assets/Sprite/Tigris.asset	
            Assets/Sprite/Tootordion BG.asset	
            Assets/Sprite/Tootordion.asset	
            Assets/Sprite/Town Front Layer.asset	
            Assets/Sprite/Town Middle Layer.asset	
            Assets/Sprite/Tribe Cabin_Outline.asset	
            Assets/Sprite/Truffle Big BG.asset	
            Assets/Sprite/Truffle Big.asset	
            Assets/Sprite/Truffle Medium.asset	
            Assets/Sprite/Truffle Small BG.asset	
            Assets/Sprite/Truffle Small.asset	
            Assets/Sprite/Under Construction_Outline.asset	
            Assets/Sprite/Weapons0001.asset	
            Assets/Sprite/Weapons0002.asset	
            Assets/Sprite/Weapons0003.asset	
            Assets/Sprite/Weapons0004.asset	
            Assets/Sprite/Weapons0005.asset	
            Assets/Sprite/Weapons0006.asset	
            Assets/Sprite/Weapons0007.asset	
            Assets/Sprite/Weapons0008.asset	
            Assets/Sprite/Weapons0009.asset	
            Assets/Sprite/Weapons0010.asset	
            Assets/Sprite/Weapons0011.asset	
            Assets/Sprite/Weapons0012.asset	
            Assets/Sprite/Weevle BG.asset	
            Assets/Sprite/Weevle.asset	
            Assets/Sprite/Zoomlin Nest BG.asset	
            Assets/Sprite/Zoomlin Nest.asset	
            Assets/stealth.asset	
            Assets/target.asset	
            Assets/teeth.asset	
            Assets/Tribe Cabin.asset	
            Assets/Under Construction.asset	
            Assets/vim.asset	
            Assets/void.asset	
            Assets/wildcard.asset	
            """;

        public static string PrintLstring(LocalizedString locStr)
        {
            if (locStr == null || locStr.IsEmpty)
                return "";

            if (locStr.TableReference.TableCollectionName.IsNullOrEmpty())
            {
                Debug.LogError("MISSING TABLE AT " + locStr);
                return "";
            }


            string tableEntryKey = LocalizationHelper.GetCollection(locStr.TableReference.TableCollectionName, SystemLanguage.English).GetEntry(locStr.TableEntryReference.KeyId)?.Key
                ?? locStr.TableEntryReference.Key;
            return ($"Extensions.GetLocalizedString(\"{locStr.TableReference.TableCollectionName}\", \"{tableEntryKey}\")");
        }

        public override void Unload()
        {
            base.Unload();
        }

        public static readonly List<object> assets = [];
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}: {assets.OfType<T>().Join(d => Path.GetExtension(d._data.name))}");
            return assets.OfType<T>().ToList();
        }
    }
}