// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeItem", menuName = "Campaign/Node Type/Item")]
public class CampaignNodeTypeItem : CampaignNodeTypeEvent
{
  [SerializeField]
  private int choices = 3;
  [SerializeField]
  private List<CardData> force;

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

  protected override IEnumerator Populate(CampaignNode node)
  {
    ItemEventRoutine objectOfType = Object.FindObjectOfType<ItemEventRoutine>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
