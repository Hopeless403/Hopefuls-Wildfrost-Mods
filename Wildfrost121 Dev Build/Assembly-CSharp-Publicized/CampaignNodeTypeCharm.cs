// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeCharm", menuName = "Campaign/Node Type/Charm")]
public class CampaignNodeTypeCharm : CampaignNodeTypeEvent
{
  [SerializeField]
  public CardUpgradeData force;

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

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCharm objectOfType = Object.FindObjectOfType<EventRoutineCharm>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
