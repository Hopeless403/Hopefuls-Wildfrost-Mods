// Decompiled with JetBrains decompiler
// Type: Snowfall2.SnowfallMod
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using Snowfall2.Data;
using Snowfall2.Data.Encounters;
using Snowfall2.Data.Tribes;
using Snowfall2.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

namespace Snowfall2
{
  public class SnowfallMod : WildfrostMod
  {
    public static List<ClassData> AddedClasses = new List<ClassData>();
    public static Dictionary<string, List<DataFile>> Registered = new Dictionary<string, List<DataFile>>();
    public static SnowfallMod Instance;
    private static readonly Dictionary<string, bool> AddedObjectsActiveInitial = new Dictionary<string, bool>();
    private static readonly List<GameObject> AddedObjects = new List<GameObject>();
    private static string OriginalProfile = SaveSystem.GetProfile();
    public static readonly Dictionary<string, string[]> MinibossCharms = new Dictionary<string, string[]>()
    {
      {
        "Wildfrost.Jacorb.Snowfall.OverburnMiniboss",
        new string[1]{ "CardUpgradeBoost" }
      },
      {
        "Wildfrost.Jacorb.Snowfall.DevicroMiniboss",
        new string[1]{ "CardUpgradeSun" }
      },
      {
        "Wildfrost.Jacorb.Snowfall.InkMiniboss",
        new string[1]{ "CardUpgradeBarrage" }
      },
      {
        "Wildfrost.Jacorb.Snowfall.Biji",
        new string[1]{ "CardUpgradeAttackAndHealth" }
      }
    };
    private static Dictionary<string, string[]> JournalTabs = new Dictionary<string, string[]>()
    {
      {
        "Cards",
        new string[3]{ "Friendly", "Item", "Clunker" }
      },
      {
        "Enemy Cards",
        new string[3]{ "Enemy", "Miniboss", "Boss" }
      }
    };

    public static GameMode GameMode => SFUtils.GetGameMode("GameModeNormal");

    public static BattleGenerationScriptFinalBoss FinalBossGenerator => BattleTools.GetBattle(7, 0).generationScript as BattleGenerationScriptFinalBoss;

    public static void Log(string value) => System.Console.WriteLine("[Snowfall]: " + value);

    public SnowfallMod(string modDirectory)
      : base(modDirectory)
    {
      SnowfallMod.Instance = this;
      this.HarmonyInstance.PatchAll(this.GetType().Assembly);
      Application.quitting += (System.Action) (() => SFUtils.SwitchToSaveProfile("Default"));
    }

    public override void Load()
    {
      this.HasLoaded = true;
      this.UpdateSave();
      SnowfallMod.Log("Snowfall mod loaded!");
      SnowfallMod.AddedClasses = new List<ClassData>();
      SnowfallMod.Registered = new Dictionary<string, List<DataFile>>();
      List<CardData> cardDataList1 = new List<CardData>();
      List<CardData> cardDataList2 = new List<CardData>();
      CardModifications.Load((WildfrostMod) this);
      GenModifications.Load((WildfrostMod) this);
      GeneralAllyData.Load(cardDataList1, cardDataList2, (WildfrostMod) this);
      BeastTribeData.Load((WildfrostMod) this, cardDataList1, cardDataList2);
      BomEncounterData.Load(this);
      InkEncounterData.Load(this);
      OverburnEncounterData.Load(this);
      CrowerEncounterData.Load(this);
      CustomBellData.Load((WildfrostMod) this);
      SnowfallMod.GameMode.classes = SnowfallMod.GameMode.classes.AddRangeToArray<ClassData>(SnowfallMod.AddedClasses.ToArray());
      MonoBehaviourSingleton<References>.instance.classes = SnowfallMod.GameMode.classes;
      foreach (GameObject addedObject in SnowfallMod.AddedObjects)
        addedObject.SetActive(!SnowfallMod.AddedObjectsActiveInitial.ContainsKey(addedObject.name) || SnowfallMod.AddedObjectsActiveInitial[addedObject.name]);
      SnowfallMod.OriginalProfile = SaveSystem.GetProfile();
      SFUtils.SwitchToSaveProfile("Snowfall", true);
      CardDiscoverSystem.instance.OnEnable();
    }

    public override void Unload()
    {
      if (!this.HasLoaded)
        return;
      foreach (ClassData addedClass in SnowfallMod.AddedClasses)
        SnowfallMod.GameMode.classes = SnowfallMod.GameMode.classes.RemoveFromArray<ClassData>(addedClass);
      MonoBehaviourSingleton<References>.instance.classes = SnowfallMod.GameMode.classes;
      foreach (KeyValuePair<string, List<DataFile>> keyValuePair in SnowfallMod.Registered)
      {
        foreach (DataFile dataFile in keyValuePair.Value)
          AddressableLoader.RemoveFromGroup<DataFile>(keyValuePair.Key, dataFile);
      }
      foreach (GameObject addedObject in SnowfallMod.AddedObjects)
      {
        SnowfallMod.AddedObjectsActiveInitial[addedObject.name] = addedObject.activeSelf;
        addedObject.SetActive(false);
      }
      BeastTribeData.Unload();
      CustomBellData.Unload((WildfrostMod) this);
      CardModifications.Unload((WildfrostMod) this);
      GenModifications.Unload((WildfrostMod) this);
      SFUtils.SwitchToSaveProfile(SnowfallMod.OriginalProfile);
      CardDiscoverSystem.instance.OnEnable();
      SnowfallMod.Log("Snowfall mod unloaded!");
      this.HasLoaded = false;
    }

    public override string GUID => "Wildfrost.Jacorb.Snowfall";

    public override string[] Depends => new string[1]
    {
      "kopie.wildfrost.console"
    };

    public override string Title => "Snowfall";

    public override string Description => "Adds new tribes, encounters, bells, and more!";

    public override string ImagesDirectory => Path.Combine(this.ModDirectory, "Images");

    [HarmonyPatch(typeof (TownHallFlagSetter), "SetupFlags")]
    private class SetupTownHallFlags
    {
      private static void Prefix(TownHallFlagSetter __instance)
      {
        if (!SnowfallMod.Instance.HasLoaded || __instance.flags.Length >= SnowfallMod.GameMode.classes.Length)
          return;
        __instance.flags = __instance.flags.AddRangeToArray<GameObject>(SnowfallMod.AddedClasses.Select<ClassData, GameObject>((Func<ClassData, GameObject>) (cl =>
        {
          GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(__instance.flags[0]);
          gameObject.name = "Flag:" + cl.name;
          gameObject.transform.SetParent(__instance.flags[0].transform.parent);
          gameObject.GetComponent<SpriteRenderer>().sprite = (Sprite) null;
          return gameObject;
        })).ToArray<GameObject>());
      }
    }

    [HarmonyPatch(typeof (CharacterSelectScreen), "Start")]
    private class StartCharacterSelectScreen
    {
      private static void Postfix(CharacterSelectScreen __instance)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        __instance.options = SnowfallMod.GameMode.classes.Length;
        __instance.differentTribes = SnowfallMod.GameMode.classes.Length;
        SnowfallMod.GameMode.takeStartingPet = true;
      }
    }

    [HarmonyPatch(typeof (CharacterSelectScreen), "Continue")]
    private class ContinueCharacterSelect
    {
      private static void Postfix(CharacterSelectScreen __instance)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        if (SnowfallMod.AddedClasses.Any<ClassData>((Func<ClassData, bool>) (cla => cla.name == __instance.leaderSelection.current.data.classData.name)))
        {
          if (SnowfallMod.GameMode.takeStartingPet)
          {
            SnowfallMod.GameMode.takeStartingPet = false;
            __instance.petSelection.Gain(__instance.leaderSelection.current.data);
            __instance.petSelection.gameObject.SetActive(false);
            __instance.Continue();
          }
          else
          {
            for (int index = 0; index < 2; ++index)
              __instance.leaderSelection.current.data.inventory.deck.Remove(__instance.petSelection.pets[__instance.petSelection.selectedPetIndex].data);
          }
        }
        else
          SnowfallMod.GameMode.takeStartingPet = true;
      }
    }

    [HarmonyPatch(typeof (CampaignPopulator), "Populate")]
    private class Populate
    {
      private static void Prefix()
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        foreach (ClassData addedClass in SnowfallMod.AddedClasses)
        {
          addedClass.characterPrefab = UnityEngine.Object.Instantiate<Character>(SnowfallMod.GameMode.classes[0].characterPrefab);
          addedClass.characterPrefab.data = new PlayerData(addedClass, addedClass.startingInventory);
          addedClass.characterPrefab.title = SnowfallMod.GameMode.classes[0].characterPrefab.title;
          addedClass.characterPrefab.team = SnowfallMod.GameMode.classes[0].characterPrefab.team;
        }
      }
    }

    [HarmonyPatch(typeof (CampaignPopulator), "LoadCharacters")]
    private class LoadChars
    {
      private static void Prefix()
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        foreach (ClassData addedClass in SnowfallMod.AddedClasses)
        {
          addedClass.characterPrefab = UnityEngine.Object.Instantiate<Character>(SnowfallMod.GameMode.classes[0].characterPrefab);
          addedClass.characterPrefab.data = new PlayerData(addedClass, addedClass.startingInventory);
          addedClass.characterPrefab.title = SnowfallMod.GameMode.classes[0].characterPrefab.title;
          addedClass.characterPrefab.team = SnowfallMod.GameMode.classes[0].characterPrefab.team;
        }
      }
    }

    [HarmonyPatch(typeof (CardManager), "Get")]
    private class CardManagerGet
    {
      private static void Postfix(CardData data, ref Card __result)
      {
        if (!SnowfallMod.Instance.HasLoaded || !(data.cardType.name == "Leader"))
          return;
        __result.hasScriptableImage = true;
        __result.scriptableImage = new ScriptableCardImage();
      }
    }

    [HarmonyPatch(typeof (StormBellManager), "Awake")]
    private class AwakenStormBellManager
    {
      private static void Postfix(StormBellManager __instance)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        __instance.active = __instance.activeNames.Select<string, HardModeModifierData>((Func<string, HardModeModifierData>) (name => ((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).First<HardModeModifierData>((Func<HardModeModifierData, bool>) (hm => hm.name == name)))).ToList<HardModeModifierData>();
        if (!__instance.overcrank || __instance.overcranker.activeSelf)
          return;
        __instance.ToggleOvercrank();
        __instance.UpdateAnimator();
      }
    }

    [HarmonyPatch(typeof (Text), "GetEffectText", new System.Type[] {typeof (IEnumerable<LocalizedString>), typeof (string), typeof (int), typeof (bool)})]
    [HarmonyPatch(typeof (Text), "GetEffectText", new System.Type[] {typeof (LocalizedString), typeof (string), typeof (int), typeof (bool)})]
    private class GetEffectTextNorm
    {
      private static void Postfix(int amount, ref string __result)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        __result = TextTools.ReplaceEffectText(__result, amount);
      }
    }

    [HarmonyPatch(typeof (ScriptUpgradeMinibosses), "Run")]
    private class ScriptUpgradeMinibossesAddUpg
    {
      private static void Postfix(ref ScriptUpgradeMinibosses __instance)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        foreach (KeyValuePair<string, string[]> minibossCharm in SnowfallMod.MinibossCharms)
        {
          CardUpgradeData[] cardUpgradeDataArray = new CardUpgradeData[minibossCharm.Value.Length];
          for (int index = 0; index < minibossCharm.Value.Length; ++index)
            cardUpgradeDataArray[index] = Extensions.GetModFromGuid("Wildfrost.Jacorb.Snowfall").Get<CardUpgradeData>(minibossCharm.Value[index]);
          __instance.profiles = ((IEnumerable<ScriptUpgradeMinibosses.Profile>) __instance.profiles).AddItem<ScriptUpgradeMinibosses.Profile>(new ScriptUpgradeMinibosses.Profile()
          {
            cardDataNames = new string[1]
            {
              minibossCharm.Key
            },
            possibleUpgrades = cardUpgradeDataArray
          }).ToArray<ScriptUpgradeMinibosses.Profile>();
        }
      }
    }

    [HarmonyPatch(typeof (Extensions), "GetCategoryCardData")]
    private class GetCategoryCards
    {
      private static void Prefix(ref string category, out bool __state)
      {
        __state = false;
        if (!SnowfallMod.Instance.HasLoaded || !category.StartsWith("Snowfall."))
          return;
        category = string.Join(".", ((IEnumerable<string>) category.Split('.')).Skip<string>(1));
        __state = true;
      }

      private static void Postfix(ref CardData[] __result, bool __state)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        __result = ((IEnumerable<CardData>) __result).Where<CardData>((Func<CardData, bool>) (card => card.name.StartsWith("Wildfrost.Jacorb.Snowfall.") == __state)).ToArray<CardData>();
        if (!__state)
          return;
        foreach (CardData cardData in __result)
        {
          Rect rect = cardData.mainSprite.rect;
          int num;
          if ((double) rect.width == 1000.0)
          {
            rect = cardData.mainSprite.rect;
            num = (double) rect.height == 1150.0 ? 1 : 0;
          }
          else
            num = 0;
          if (num != 0)
            JournalCardManager.scaleOverride[cardData.name] = 1.4f;
        }
      }
    }

    [HarmonyPatch(typeof (Journal), "OnEnable")]
    private class JournalOnEnable
    {
      private static void Postfix(Journal __instance)
      {
        if (!SnowfallMod.Instance.HasLoaded)
          return;
        Transform transform1 = __instance.transform.Find("Positioner").Find("Tabs");
        foreach (KeyValuePair<string, string[]> journalTab in SnowfallMod.JournalTabs)
        {
          KeyValuePair<string, string[]> kvp = journalTab;
          if ((UnityEngine.Object) __instance.leftPageGroup.Find("Snowfall " + kvp.Key) == (UnityEngine.Object) null)
          {
            Transform original = __instance.leftPageGroup.Find(kvp.Key);
            Transform transform2 = UnityEngine.Object.Instantiate<Transform>(original, original.parent);
            transform2.name = "Snowfall " + kvp.Key;
            JournalCardManager component = transform2.GetComponent<JournalCardManager>();
            if (!SnowfallMod.AddedObjects.Contains(transform2.gameObject))
              SnowfallMod.AddedObjects.Add(transform2.gameObject);
            for (int index = 0; index < component.categories.Length; ++index)
              component.categories[index] = new JournalCardManager.Category()
              {
                name = "Snowfall." + kvp.Value[index]
              };
          }
          string str = kvp.Key.Replace(" ", "");
          if ((UnityEngine.Object) transform1.Find("SnowfallTab" + str) == (UnityEngine.Object) null)
          {
            Transform original = transform1.Find("Tab" + str);
            Transform transform3 = UnityEngine.Object.Instantiate<Transform>(original, original.parent);
            transform3.name = "Snowfall" + original.name;
            transform3.SetAsFirstSibling();
            if (!SnowfallMod.AddedObjects.Contains(transform3.gameObject))
              SnowfallMod.AddedObjects.Add(transform3.gameObject);
            JournalTab component1 = transform3.GetComponent<JournalTab>();
            JournalTab component2 = original.GetComponent<JournalTab>();
            JournalCardManager cardManager = __instance.leftPageGroup.Find(kvp.Key).GetComponent<JournalCardManager>();
            component1.onSelect.AddListener((UnityAction) (() =>
            {
              for (int index = 0; index < cardManager.categories.Length; ++index)
                cardManager.categories[index] = new JournalCardManager.Category()
                {
                  name = "Snowfall." + kvp.Value[index]
                };
              cardManager.SelectTab(0);
            }));
            component2.onSelect.AddListener((UnityAction) (() =>
            {
              for (int index = 0; index < cardManager.categories.Length; ++index)
                cardManager.categories[index] = new JournalCardManager.Category()
                {
                  name = kvp.Value[index]
                };
              cardManager.SelectTab(0);
            }));
          }
        }
      }
    }
  }
}
