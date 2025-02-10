// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCurseItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeCurseItems", menuName = "Campaign/Node Type/Curse Items")]
public class CampaignNodeTypeCurseItems : CampaignNodeTypeEvent
{
  [SerializeField]
  private int choices = 3;
  [SerializeField]
  private int curseCards = 2;
  [SerializeField]
  private List<CardData> force;
  [SerializeField]
  private CardData[] cursePool;
  [SerializeField]
  private CardData[] extraCards;
  [SerializeField]
  private CardData[] illegalCards;

  public override IEnumerator SetUp(CampaignNode node)
  {
    yield return (object) null;
    Campaign objectOfType = UnityEngine.Object.FindObjectOfType<Campaign>();
    CharacterRewards characterRewards = objectOfType.GetComponent<CharacterRewards>();
    if (!(bool) (UnityEngine.Object) characterRewards)
    {
      characterRewards = objectOfType.gameObject.AddComponent<CharacterRewards>();
      List<ClassData> group = AddressableLoader.GetGroup<ClassData>("ClassData");
      HashSet<RewardPool> rewardPoolSet = new HashSet<RewardPool>();
      foreach (ClassData classData in group)
      {
        foreach (RewardPool rewardPool in classData.rewardPools)
        {
          if (rewardPool.type == "Items")
            rewardPoolSet.Add(rewardPool);
        }
      }
      foreach (RewardPool rewardPool in rewardPoolSet)
        characterRewards.Add(rewardPool);
      characterRewards.PullOut("Items", (IEnumerable<DataFile>) this.illegalCards);
      characterRewards.Add("Items", (IEnumerable<DataFile>) this.extraCards);
      characterRewards.RemoveLockedCards();
    }
    List<CardData> cardDataList = this.force.Clone<CardData>();
    if (cardDataList.Count > 0)
      characterRewards.PullOut("Items", (IEnumerable<DataFile>) cardDataList);
    int itemCount = this.choices - cardDataList.Count;
    cardDataList.AddRange((IEnumerable<CardData>) characterRewards.Pull<CardData>((object) node, "Items", itemCount));
    List<CardData> list = new List<CardData>();
    for (int index = 0; index < this.choices; ++index)
    {
      CardData cardData = index < this.curseCards ? this.cursePool.RandomItem<CardData>() : (CardData) null;
      list.Insert(list.RandomIndex<CardData>(), cardData);
    }
    node.data = new Dictionary<string, object>()
    {
      {
        "cards",
        (object) CampaignNodeTypeCurseItems.ToSaveCollectionOfNames((IEnumerable<UnityEngine.Object>) cardDataList)
      },
      {
        "curses",
        (object) CampaignNodeTypeCurseItems.ToSaveCollectionOfNames((IEnumerable<UnityEngine.Object>) list)
      },
      {
        "analyticsEventSent",
        (object) false
      }
    };
  }

  public override bool HasMissingData(CampaignNode node)
  {
    string[] saveCollection1 = node.data.GetSaveCollection<string>("cards");
    string[] saveCollection2 = node.data.GetSaveCollection<string>("curses");
    return MissingCardSystem.HasMissingData((IEnumerable<string>) saveCollection1) || MissingCardSystem.HasMissingData(((IEnumerable<string>) saveCollection2).Where<string>((Func<string, bool>) (a => a != null)));
  }

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCurseItems objectOfType = UnityEngine.Object.FindObjectOfType<EventRoutineCurseItems>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }

  private static SaveCollection<string> ToSaveCollectionOfNames(IEnumerable<UnityEngine.Object> list)
  {
    return new SaveCollection<string>(list.Select<UnityEngine.Object, string>((Func<UnityEngine.Object, string>) (a => !(bool) a ? (string) null : a.name)).ToArray<string>());
  }
}
