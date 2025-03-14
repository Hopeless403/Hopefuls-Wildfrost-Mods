﻿// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeMuncher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeMuncher", menuName = "Campaign/Node Type/Muncher")]
public class CampaignNodeTypeMuncher : CampaignNodeTypeEvent
{
  [SerializeField]
  public int canEat = 2;

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

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineMuncher objectOfType = Object.FindObjectOfType<EventRoutineMuncher>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
