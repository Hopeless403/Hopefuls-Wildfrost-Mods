// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeCompanion", menuName = "Campaign/Node Type/Companion")]
public class CampaignNodeTypeCompanion : CampaignNodeTypeEvent
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

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCompanion objectOfType = Object.FindObjectOfType<EventRoutineCompanion>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }

  public override bool HasMissingData(CampaignNode node)
  {
    return MissingCardSystem.HasMissingData((IEnumerable<string>) node.data.GetSaveCollection<string>("cards"));
  }
}
