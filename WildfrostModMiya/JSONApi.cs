// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.JSONApi
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using TinyJson;

namespace WildfrostModMiya
{
  public static class JSONApi
  {
    internal static void AddJSONCards(int unused)
    {
      JSONApi.JSONCardData jsonCardData1 = new JSONApi.JSONCardData();
      jsonCardData1.portraitPath = "CardPortraits\\FALLBACKMAINSPRITE";
      jsonCardData1.backgroundPath = "CardPortraits\\FALLBACKBACKGROUNDSPRITE";
      jsonCardData1.name = "API.TemplateCard";
      jsonCardData1.title = "Template Card";
      jsonCardData1.hp = 1;
      jsonCardData1.hasHealth = true;
      jsonCardData1.damage = 1;
      jsonCardData1.hasAttack = true;
      jsonCardData1.counter = 1;
      jsonCardData1.upgrades = new JSONApi.JSONCardUpdateData[1]
      {
        new JSONApi.JSONCardUpdateData()
        {
          name = "Card Upgrade name"
        }
      };
      jsonCardData1.attackEffects = new JSONApi.JSONStatusEffectData[1]
      {
        new JSONApi.JSONStatusEffectData()
        {
          name = "Status effect name",
          count = 1
        }
      };
      jsonCardData1.startWithEffects = new JSONApi.JSONStatusEffectData[1]
      {
        new JSONApi.JSONStatusEffectData()
        {
          name = "Status effect name",
          count = 1
        }
      };
      jsonCardData1.traits = new JSONApi.JSONTraitData[1]
      {
        new JSONApi.JSONTraitData()
        {
          name = "Trait name",
          count = 1
        }
      };
      jsonCardData1.customData = new Dictionary<string, object>()
      {
        ["SomeData"] = (object) true
      };
      jsonCardData1.pools = new string[1]{ "BasicItemPool" };
      jsonCardData1.bloodProfile = "Blood Profile Normal";
      jsonCardData1.idleAnimation = "SwayAnimationProfile";
      jsonCardData1.CanPlayOnBoard = true;
      jsonCardData1.CanPlayOnEnemy = true;
      jsonCardData1.CanPlayOnFriendly = true;
      jsonCardData1.CanPlayOnHand = true;
      jsonCardData1.IsItem = true;
      jsonCardData1.CardType = "Item";
      string json = jsonCardData1.ToJson();
      File.WriteAllText(WildFrostAPIMod.ModsFolder + "Template.json", json);
      foreach (string enumerateFile in Directory.EnumerateFiles(WildFrostAPIMod.ModsFolder, "*.json", SearchOption.AllDirectories))
      {
        if (!enumerateFile.EndsWith("Template.json") && !enumerateFile.EndsWith("manifest.json"))
        {
          JSONApi.JSONCardData jsonCardData2 = File.ReadAllText(enumerateFile).FromJson<JSONApi.JSONCardData>();
          WildFrostAPIMod.Instance.Log.LogInfo((object) jsonCardData2.name);
          List<CardData.StatusEffectStacks> list1 = new List<CardData.StatusEffectStacks>();
          foreach (JSONApi.JSONStatusEffectData attackEffect in jsonCardData2.attackEffects)
          {
            CardData.StatusEffectStacks statusEffectStacks = new CardData.StatusEffectStacks()
            {
              count = attackEffect.count,
              data = ((Il2CppObjectBase) AddressableLoader.groups["StatusEffectData"].lookup[attackEffect.name]).Cast<StatusEffectData>()
            };
            WildFrostAPIMod.Instance.Log.LogInfo((object) (attackEffect.name + " " + attackEffect.count.ToString() + " added to json attack effects"));
            list1.Add(statusEffectStacks);
          }
          List<CardData.StatusEffectStacks> list2 = new List<CardData.StatusEffectStacks>();
          foreach (JSONApi.JSONStatusEffectData startWithEffect in jsonCardData2.startWithEffects)
          {
            CardData.StatusEffectStacks statusEffectStacks = new CardData.StatusEffectStacks()
            {
              count = startWithEffect.count,
              data = ((Il2CppObjectBase) AddressableLoader.groups["StatusEffectData"].lookup[startWithEffect.name]).Cast<StatusEffectData>()
            };
            list2.Add(statusEffectStacks);
          }
          List<CardUpgradeData> upgrade1 = new List<CardUpgradeData>();
          foreach (JSONApi.JSONCardUpdateData upgrade2 in jsonCardData2.upgrades)
          {
            CardUpgradeData cardUpgradeData = ((Il2CppObjectBase) AddressableLoader.groups["CardUpgradeData"].lookup[upgrade2.name]).Cast<CardUpgradeData>();
            upgrade1.Add(cardUpgradeData);
          }
          List<CardData.TraitStacks> list3 = new List<CardData.TraitStacks>();
          foreach (JSONApi.JSONTraitData trait in jsonCardData2.traits)
          {
            CardData.TraitStacks traitStacks = new CardData.TraitStacks()
            {
              count = trait.count,
              data = ((Il2CppObjectBase) AddressableLoader.groups["TraitData"].lookup[trait.name]).Cast<TraitData>()
            };
            list3.Add(traitStacks);
          }
          CardData t = CardAdder.CreateCardData("", jsonCardData2.name).SetStats(jsonCardData2.hasHealth ? new int?(jsonCardData2.hp) : new int?(), jsonCardData2.hasAttack ? new int?(jsonCardData2.damage) : new int?(), jsonCardData2.counter).SetSprites(jsonCardData2.portraitPath, jsonCardData2.backgroundPath).SetTitle(jsonCardData2.title).SetAttackEffects(Il2CppArrayBase<CardData.StatusEffectStacks>.op_Implicit(list1.ToArray())).SetStartWithEffects(Il2CppArrayBase<CardData.StatusEffectStacks>.op_Implicit(list2.ToArray())).SetUpgrades(upgrade1).SetTraits(Il2CppArrayBase<CardData.TraitStacks>.op_Implicit(list3.ToArray())).AddToPool(jsonCardData2.pools).SetBloodProfile(jsonCardData2.bloodProfile).SetIdleAnimationProfile(jsonCardData2.idleAnimation);
          foreach (KeyValuePair<string, object> keyValuePair in jsonCardData2.customData)
            t.SetCustomData(keyValuePair.Key, (Object) keyValuePair.Value);
          t.canPlayOnBoard = jsonCardData2.CanPlayOnBoard;
          t.canPlayOnEnemy = jsonCardData2.CanPlayOnEnemy;
          t.canPlayOnFriendly = jsonCardData2.CanPlayOnFriendly;
          t.canPlayOnHand = jsonCardData2.CanPlayOnHand;
          if (jsonCardData2.IsItem)
            t.SetIsItem();
          else
            t.SetIsUnit();
          t.SetCardType(jsonCardData2.CardType);
          t.RegisterCardInApi();
        }
      }
    }

    public class JSONCardUpdateData
    {
      public string name;
    }

    public class JSONStatusEffectData
    {
      public string name;
      public int count;
    }

    public class JSONTraitData
    {
      public string name;
      public int count;
    }

    public class JSONCardData
    {
      public string portraitPath;
      public string backgroundPath;
      public string name;
      public string title;
      public int hp;
      public bool hasHealth;
      public int damage;
      public bool hasAttack;
      public int counter;
      public JSONApi.JSONCardUpdateData[] upgrades;
      public JSONApi.JSONStatusEffectData[] attackEffects;
      public JSONApi.JSONStatusEffectData[] startWithEffects;
      public JSONApi.JSONTraitData[] traits;
      public Dictionary<string, object> customData;
      public string[] pools;
      public string bloodProfile;
      public string idleAnimation;
      public string CardType;
      public bool IsItem;
      public bool CanPlayOnBoard;
      public bool CanPlayOnEnemy;
      public bool CanPlayOnFriendly;
      public bool CanPlayOnHand;
    }
  }
}
