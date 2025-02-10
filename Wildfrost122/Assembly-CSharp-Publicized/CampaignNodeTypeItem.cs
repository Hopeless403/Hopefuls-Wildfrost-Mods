// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeItem", menuName = "Campaign/Node Type/Item")]
public class CampaignNodeTypeItem : CampaignNodeTypeEvent
{
  [SerializeField]
  public int choices = 3;
  [SerializeField]
  public List<CardData> force;

  public override IEnumerator SetUp(CampaignNode node)
  {
    yield return (object) null;
    CharacterRewards component = References.Player.GetComponent<CharacterRewards>();
    List<CardData> cardDataList = this.force.Clone<CardData>();
    if (cardDataList.Count > 0)
      component.PullOut("Items", (IEnumerable<DataFile>) cardDataList);
    int itemCount = this.choices - cardDataList.Count;
    cardDataList.AddRange((IEnumerable<CardData>) component.Pull<CardData>((object) node, "Items", itemCount));
    node.data = new Dictionary<string, object>()
    {
      {
        "open",
        (object) false
      },
      {
        "cards",
        (object) cardDataList.ToSaveCollectionOfNames<CardData>()
      }
    };
  }

  public override bool HasMissingData(CampaignNode node)
  {
    return MissingCardSystem.HasMissingData((IEnumerable<string>) node.data.GetSaveCollection<string>("cards"));
  }

  public override IEnumerator Populate(CampaignNode node)
  {
    ItemEventRoutine objectOfType = Object.FindObjectOfType<ItemEventRoutine>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
