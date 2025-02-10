// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeInjuredCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineInjuredCompanion objectOfType = Object.FindObjectOfType<EventRoutineInjuredCompanion>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
