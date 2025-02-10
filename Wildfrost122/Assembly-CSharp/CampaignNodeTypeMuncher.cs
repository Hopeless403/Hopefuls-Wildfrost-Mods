// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeMuncher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeMuncher", menuName = "Campaign/Node Type/Muncher")]
public class CampaignNodeTypeMuncher : CampaignNodeTypeEvent
{
  [SerializeField]
  private int canEat = 2;

  public override IEnumerator SetUp(CampaignNode node)
  {
    node.data = new Dictionary<string, object>()
    {
      {
        "canEat",
        (object) this.canEat
      },
      {
        "enterCount",
        (object) 0
      },
      {
        "openCount",
        (object) 0
      },
      {
        "thankCount",
        (object) 0
      }
    };
    yield return (object) null;
  }

  public override bool HasMissingData(CampaignNode node) => false;

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineMuncher objectOfType = Object.FindObjectOfType<EventRoutineMuncher>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
