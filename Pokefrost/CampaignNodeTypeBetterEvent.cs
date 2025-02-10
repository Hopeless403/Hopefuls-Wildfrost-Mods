// Decompiled with JetBrains decompiler
// Type: Pokefrost.CampaignNodeTypeTrade
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class CampaignNodeTypeTrade : CampaignNodeTypeEvent
  {
    public string key = "Trade";
    public static Dictionary<string, GameObject> Prefabs = new Dictionary<string, GameObject>();
    public int choices = 3;
    public int valueCap = 499;
    public List<CardData> force;
    public List<CardUpgradeData> upgrades;
    public int baseUpgradeAmount = 1;
    public int BonusUpgradePerArea = 1;

    public override IEnumerator SetUp(CampaignNode node)
    {
      Debug.Log((object) "[Trade]");
      List<CardData> list = CampaignNodeTypeTrade.ObtainCards(this.choices, this.valueCap);
      int upgradeAmount = (this.baseUpgradeAmount + this.BonusUpgradePerArea * node.areaIndex) * this.choices;
      List<CardUpgradeData> listCharm = CampaignNodeTypeTrade.ObtainCharms(upgradeAmount);
      node.data = new Dictionary<string, object>()
      {
        {
          "cards",
          (object) list.ToSaveCollectionOfNames<CardData>()
        },
        {
          "charms",
          (object) listCharm.ToSaveCollectionOfNames<CardUpgradeData>()
        }
      };
      yield break;
    }

    public override bool HasMissingData(CampaignNode node)
    {
      object obj1;
      if (!node.data.TryGetValue("cards", out obj1) || !(obj1 is SaveCollection<string> saveCollection1))
        return true;
      foreach (string assetName in saveCollection1.collection)
      {
        if ((UnityEngine.Object) AddressableLoader.Get<CardData>("CardData", assetName) == (UnityEngine.Object) null)
          return true;
      }
      object obj2;
      if (!node.data.TryGetValue("charms", out obj2) || !(obj2 is SaveCollection<string> saveCollection2))
        return true;
      foreach (string assetName in saveCollection2.collection)
      {
        if ((UnityEngine.Object) AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", assetName) == (UnityEngine.Object) null)
          return true;
      }
      return false;
    }

    public static List<CardData> ObtainCards(int choices, int valueCap)
    {
      List<CardData> list1 = AddressableLoader.GetGroup<CardData>("CardData").Clone<CardData>();
      list1.RemoveAll((Predicate<CardData>) (card => card.cardType.name != "Friendly" || card.mainSprite?.name == "Nothing" || card.value > valueCap));
      List<CardData> list2 = list1.TakeRandom<CardData>(choices).ToList<CardData>();
      Debug.Log((object) list1.Count.ToString());
      return list2;
    }

    public static List<CardUpgradeData> ObtainCharms(int choices)
    {
      List<CardUpgradeData> list1 = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Clone<CardUpgradeData>();
      list1.RemoveAll((Predicate<CardUpgradeData>) (charm => charm.type != CardUpgradeData.Type.Charm || charm.tier < 0));
      List<CardUpgradeData> list2 = list1.TakeRandom<CardUpgradeData>(choices).ToList<CardUpgradeData>();
      Debug.Log((object) list1.Count.ToString());
      return list2;
    }

    public override IEnumerator Populate(CampaignNode node)
    {
      EventRoutineTrade eventRoutineCompanion = UnityEngine.Object.FindObjectOfType<EventRoutineTrade>();
      eventRoutineCompanion.node = node;
      yield return (object) eventRoutineCompanion.Populate();
    }

    public override IEnumerator Run(CampaignNode node)
    {
      yield return (object) Transition.To("Event");
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CampaignNodeTypeTrade.Prefabs[this.key], UnityEngine.Object.FindObjectOfType<EventManager>(true).transform);
      gameObject.SetActive(true);
      EventRoutine eventRoutine = gameObject.GetComponent<EventRoutine>();
      GameObject.Find("SnowfallFX").SetActive(false);
      Events.InvokeEventStart(node, eventRoutine);
      yield return (object) this.Populate(node);
      Events.InvokeEventPopulated(eventRoutine);
      Transition.End();
      yield return (object) eventRoutine.Run();
      yield return (object) Transition.To("MapNew");
      Transition.End();
      yield return (object) MapNew.CheckCompanionLimit();
    }
  }
}
