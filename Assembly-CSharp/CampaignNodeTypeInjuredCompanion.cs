// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeInjuredCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeInjuredCompanion", menuName = "Campaign/Node Type/Injured Companion")]
public class CampaignNodeTypeInjuredCompanion : CampaignNodeTypeEvent
{
  public override IEnumerator SetUp(CampaignNode node)
  {
    RunHistory mostRecentRun = InjuredCompanionEventSystem.GetMostRecentRun();
    if (mostRecentRun != null)
    {
      List<CardSaveData> eligibleCompanions = InjuredCompanionEventSystem.GetEligibleCompanions(mostRecentRun);
      if (eligibleCompanions.Count > 0)
      {
        CardSaveData cardSaveData = eligibleCompanions.RandomItem<CardSaveData>();
        References.Player.GetComponent<CharacterRewards>().PullOut("Units", (DataFile) AddressableLoader.Get<CardData>("CardData", cardSaveData.name));
        node.data = new Dictionary<string, object>()
        {
          {
            "cardSaveData",
            (object) cardSaveData
          }
        };
      }
    }
    yield return (object) null;
  }

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineInjuredCompanion objectOfType = Object.FindObjectOfType<EventRoutineInjuredCompanion>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
