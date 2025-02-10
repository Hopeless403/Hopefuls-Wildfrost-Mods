// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeInjuredCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
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

  public override bool HasMissingData(CampaignNode node) => false;

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineInjuredCompanion objectOfType = Object.FindObjectOfType<EventRoutineInjuredCompanion>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
