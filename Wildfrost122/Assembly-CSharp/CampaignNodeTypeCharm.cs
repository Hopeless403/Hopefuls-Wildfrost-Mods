// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
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

  public override bool HasMissingData(CampaignNode node)
  {
    object obj;
    return !node.data.TryGetValue("charm", out obj) || !(obj is string assetName) || (Object) AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", assetName) == (Object) null;
  }

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCharm objectOfType = Object.FindObjectOfType<EventRoutineCharm>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
