// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeGnomeShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeGnomeShop", menuName = "Campaign/Node Type/Gnome Shop")]
public class CampaignNodeTypeGnomeShop : CampaignNodeTypeEvent
{
  [SerializeField]
  private int poolSize = 10;
  [SerializeField]
  private int rerollPrice = 10;
  [SerializeField]
  private int rerollPriceAdd = 5;

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

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineGnomeShop objectOfType = UnityEngine.Object.FindObjectOfType<EventRoutineGnomeShop>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
