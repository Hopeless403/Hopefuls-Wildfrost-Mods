// Decompiled with JetBrains decompiler
// Type: MetaprogressionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MetaprogressionSystem : GameSystem
{
  public static readonly Dictionary<string, object> data = new Dictionary<string, object>()
  {
    {
      "pets",
      (object) new List<string>()
      {
        "Wolfie",
        "BerryPet",
        "DemonPet",
        "DrawPet",
        "Jagzag",
        "BoostPet"
      }
    },
    {
      "items",
      (object) new List<string>()
      {
        "Slapcrackers",
        "Snowcracker",
        "Hooker",
        "ScrapPile",
        "MegaMimik",
        "Krono"
      }
    },
    {
      "companions",
      (object) new List<string>()
      {
        "Snobble",
        "Klutz",
        "TinyTyko",
        "Bombom",
        "BoBo",
        "Turmeep"
      }
    },
    {
      "events",
      (object) new List<string>()
      {
        "CampaignNodeCopyItem",
        "CampaignNodeCharmShop",
        "CampaignNodeCurseItems"
      }
    },
    {
      "buildings",
      (object) new List<string>()
      {
        "InventorHut",
        "IcebreakerHut",
        "HotSpring"
      }
    },
    {
      "charms",
      (object) new Dictionary<string, string>()
      {
        {
          "Charm 1",
          "CardUpgradeFury"
        },
        {
          "Charm 2",
          "CardUpgradeSnowImmune"
        },
        {
          "Charm 3",
          "CardUpgradeAttackIncreaseCounter"
        },
        {
          "Charm 4",
          "CardUpgradeAttackRemoveEffects"
        },
        {
          "Charm 5",
          "CardUpgradeShellBecomesSpice"
        },
        {
          "Charm 6",
          "CardUpgradeEffigy"
        },
        {
          "Charm 7",
          "CardUpgradeShroomReduceHealth"
        },
        {
          "Charm 8",
          "CardUpgradeAttackConsume"
        },
        {
          "Charm 9",
          "CardUpgradeBlock"
        },
        {
          "Charm 10",
          "CardUpgradeGreed"
        },
        {
          "Charm 11",
          "CardUpgradeRemoveCharmLimit"
        },
        {
          "Charm 12",
          "CardUpgradeFrenzyReduceAttack"
        },
        {
          "Charm 13",
          "CardUpgradeConsumeAddHealth"
        },
        {
          "Charm 14",
          "CardUpgradeAttackAndHealth"
        },
        {
          "Charm 15",
          "CardUpgradeCritical"
        },
        {
          "Charm 16",
          "CardUpgradeSpark"
        }
      }
    }
  };

  public static T Get<T>(string key) where T : class => MetaprogressionSystem.data[key] as T;

  public static void Add<T, Y>(string key, Y keyValue, T value)
    where T : class
    where Y : class
  {
    Dictionary<Y, T> dictionary = (Dictionary<Y, T>) MetaprogressionSystem.data[key];
    if (!dictionary.TryAdd(keyValue, value))
      dictionary[keyValue] = value;
    MetaprogressionSystem.data[key] = (object) dictionary;
  }

  public static bool Remove<T, Y>(string key, Y keyValue, T value)
    where T : class
    where Y : class
  {
    Dictionary<Y, T> dictionary = (Dictionary<Y, T>) MetaprogressionSystem.data[key];
    int num = dictionary.Remove(keyValue) ? 1 : 0;
    MetaprogressionSystem.data[key] = (object) dictionary;
    return num != 0;
  }

  public static void Add<T>(string key, T value) where T : class
  {
    List<T> objList = (List<T>) MetaprogressionSystem.data[key];
    objList.Add(value);
    MetaprogressionSystem.data[key] = (object) objList;
  }

  public static bool Remove<T>(string key, T value) where T : class
  {
    List<T> objList = (List<T>) MetaprogressionSystem.data[key];
    int num = objList.Remove(value) ? 1 : 0;
    MetaprogressionSystem.data[key] = (object) objList;
    return num != 0;
  }

  public static T Get<T>(string key, T defaultValue)
  {
    if (MetaprogressionSystem.data.ContainsKey(key) && MetaprogressionSystem.data[key] is T obj)
      return obj;
    return !SaveSystem.Enabled ? defaultValue : SaveSystem.LoadProgressData<T>(key, defaultValue);
  }

  public static void Set<T>(string key, T value)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.SaveProgressData<T>(key, value);
  }

  public static List<string> GetUnlockedList() => SaveSystem.LoadProgressData<List<string>>("unlocked", new List<string>());

  public static IEnumerable<UnlockData> GetUnlocked(Predicate<UnlockData> match) => MetaprogressionSystem.GetUnlockedList().Select<string, UnlockData>((Func<string, UnlockData>) (n => AddressableLoader.Get<UnlockData>("UnlockData", n))).Where<UnlockData>((Func<UnlockData, bool>) (unlock => (UnityEngine.Object) unlock != (UnityEngine.Object) null && unlock.IsActive && match(unlock)));

  public static List<UnlockData> GetRemainingUnlocks(List<string> alreadyUnlocked = null)
  {
    if (alreadyUnlocked == null)
      alreadyUnlocked = MetaprogressionSystem.GetUnlockedList();
    return AddressableLoader.GetGroup<UnlockData>("UnlockData").Where<UnlockData>((Func<UnlockData, bool>) (a => a.IsActive && !alreadyUnlocked.Contains(a.name) || !a.IsActive)).OrderBy<UnlockData, float>((Func<UnlockData, float>) (a => a.lowPriority)).ToList<UnlockData>();
  }

  public static bool IsUnlocked(UnlockData unlockData, List<string> alreadyUnlocked = null)
  {
    if ((UnityEngine.Object) unlockData == (UnityEngine.Object) null)
      return true;
    return unlockData.IsActive && MetaprogressionSystem.IsUnlocked(unlockData.name, alreadyUnlocked);
  }

  public static bool IsUnlocked(string unlockDataName, List<string> alreadyUnlocked = null)
  {
    if (alreadyUnlocked == null)
      alreadyUnlocked = MetaprogressionSystem.GetUnlockedList();
    return alreadyUnlocked.Contains(unlockDataName);
  }

  public static List<ClassData> GetLockedClasses()
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    return ((IEnumerable<ClassData>) References.Classes).Where<ClassData>((Func<ClassData, bool>) (c => (UnityEngine.Object) c.requiresUnlock != (UnityEngine.Object) null && !MetaprogressionSystem.IsUnlocked(c.requiresUnlock, unlockedList))).ToList<ClassData>();
  }

  public static List<string> GetLockedItems(List<UnlockData> remainingUnlocks)
  {
    int num1 = remainingUnlocks.Count<UnlockData>((Func<UnlockData, bool>) (a => a.type == UnlockData.Type.Item));
    List<string> stringList = MetaprogressionSystem.Get<List<string>>("items");
    int num2 = stringList.Count - num1;
    List<string> lockedItems = new List<string>();
    for (int index = num2; index < stringList.Count; ++index)
      lockedItems.Add(stringList[index]);
    return lockedItems;
  }

  public static List<string> GetLockedCompanions(List<UnlockData> remainingUnlocks)
  {
    int num1 = remainingUnlocks.Count<UnlockData>((Func<UnlockData, bool>) (a => a.type == UnlockData.Type.Companion));
    List<string> stringList = MetaprogressionSystem.Get<List<string>>("companions");
    int num2 = stringList.Count - num1;
    List<string> lockedCompanions = new List<string>();
    for (int index = num2; index < stringList.Count; ++index)
      lockedCompanions.Add(stringList[index]);
    return lockedCompanions;
  }

  public static List<string> GetLockedCharms(List<UnlockData> remainingUnlocks)
  {
    Dictionary<string, string> dictionary = MetaprogressionSystem.Get<Dictionary<string, string>>("charms");
    List<string> lockedCharms = new List<string>();
    foreach (UnlockData remainingUnlock in remainingUnlocks)
    {
      string str;
      if (remainingUnlock.type == UnlockData.Type.Charm && dictionary.TryGetValue(remainingUnlock.name, out str))
        lockedCharms.Add(str);
    }
    return lockedCharms;
  }

  public static string[] GetUnlockedPets()
  {
    List<string> stringList1 = MetaprogressionSystem.Get<List<string>>("pets");
    List<string> stringList2 = SaveSystem.LoadProgressData<List<string>>("petHutUnlocks", (List<string>) null);
    // ISSUE: explicit non-virtual call
    int length = Mathf.Min(stringList1.Count, 1 + (stringList2 != null ? __nonvirtual (stringList2.Count) : 0));
    string[] sequence = new string[length];
    for (int index = 0; index < length; ++index)
      sequence[index] = stringList1[index];
    string[] array = CardDataBuilder.AutoUnlockedPets.ToArray();
    return sequence.AddRangeToArray<string>(array);
  }

  public static void SetUnlocksReady(string unlockName)
  {
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("townNew", new List<string>());
    stringList.Add(unlockName);
    SaveSystem.SaveProgressData<List<string>>("townNew", stringList);
    foreach (UnlockReadyIcon unlockReadyIcon in UnityEngine.Object.FindObjectsOfType<UnlockReadyIcon>(true))
      unlockReadyIcon.Set(true);
  }

  public static bool CheckUnlockRequirements(UnlockData unlock, ICollection<string> alreadyUnlocked) => ((IEnumerable<UnlockData>) unlock.requires).All<UnlockData>((Func<UnlockData, bool>) (requirement => requirement.IsActive && alreadyUnlocked.Contains(requirement.name)));

  public static bool AnyUnlocksReady() => SaveSystem.LoadProgressData<List<string>>("townNew", new List<string>()).Count > 0;
}
