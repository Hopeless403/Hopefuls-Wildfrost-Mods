// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeCharm", menuName = "Campaign/Node Type/Charm")]
public class CampaignNodeTypeCharm : CampaignNodeTypeEvent
{
  [SerializeField]
  private CardUpgradeData force;

  public override IEnumerator SetUp(CampaignNode node)
  {
    yield return (object) null;
    CharacterRewards component = References.Player.GetComponent<CharacterRewards>();
    CardUpgradeData cardUpgradeData;
    if ((bool) (Object) this.force)
    {
      cardUpgradeData = this.force;
      component.PullOut("Charms", (DataFile) cardUpgradeData);
    }
    else
      cardUpgradeData = component.Pull<CardUpgradeData>((object) node, "Charms");
    node.data = new Dictionary<string, object>()
    {
      {
        "open",
        (object) false
      },
      {
        "charm",
        (object) cardUpgradeData.name
      }
    };
  }

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCharm objectOfType = Object.FindObjectOfType<EventRoutineCharm>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
