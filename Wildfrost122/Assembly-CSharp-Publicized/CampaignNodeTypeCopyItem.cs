// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCopyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeCopyItem", menuName = "Campaign/Node Type/Copy Item")]
public class CampaignNodeTypeCopyItem : CampaignNodeTypeEvent
{
  [SerializeField]
  public int canCopy = 1;

  public override IEnumerator SetUp(CampaignNode node)
  {
    node.data = new Dictionary<string, object>()
    {
      {
        "canCopy",
        (object) this.canCopy
      },
      {
        "enterCount",
        (object) 0
      }
    };
    yield return (object) null;
  }

  public override bool HasMissingData(CampaignNode node) => false;

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCopyItem objectOfType = Object.FindObjectOfType<EventRoutineCopyItem>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
