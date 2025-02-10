// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeCompanion", menuName = "Campaign/Node Type/Companion")]
public class CampaignNodeTypeCompanion : CampaignNodeTypeEvent
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
      component.PullOut("Units", (IEnumerable<DataFile>) cardDataList);
    int itemCount = this.choices - cardDataList.Count;
    cardDataList.AddRange((IEnumerable<CardData>) component.Pull<CardData>((object) node, "Units", itemCount));
    node.data = new Dictionary<string, object>()
    {
      {
        "damage",
        (object) 0
      },
      {
        "cards",
        (object) cardDataList.ToSaveCollectionOfNames<CardData>()
      }
    };
  }

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCompanion objectOfType = Object.FindObjectOfType<EventRoutineCompanion>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
