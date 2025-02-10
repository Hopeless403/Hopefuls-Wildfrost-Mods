// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeGnomeShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeGnomeShop", menuName = "Campaign/Node Type/Gnome Shop")]
public class CampaignNodeTypeGnomeShop : CampaignNodeTypeEvent
{
  [SerializeField]
  public int poolSize = 10;
  [SerializeField]
  public int rerollPrice = 10;
  [SerializeField]
  public int rerollPriceAdd = 5;

  public override IEnumerator SetUp(CampaignNode node)
  {
    CardData[] fromOriginalList = References.Player.GetComponent<CharacterRewards>().GetFromOriginalList<CardData>((object) node, "Items", this.poolSize, false);
    EventRoutineGnomeShop.Data data = new EventRoutineGnomeShop.Data()
    {
      pool = ((IEnumerable<CardData>) fromOriginalList).Select<CardData, string>((Func<CardData, string>) (a => a.name)).ToArray<string>(),
      price = this.rerollPrice,
      priceAdd = this.rerollPriceAdd
    };
    node.data = new Dictionary<string, object>()
    {
      {
        "data",
        (object) data
      }
    };
    yield break;
  }

  public override bool HasMissingData(CampaignNode node) => false;

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineGnomeShop objectOfType = UnityEngine.Object.FindObjectOfType<EventRoutineGnomeShop>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
