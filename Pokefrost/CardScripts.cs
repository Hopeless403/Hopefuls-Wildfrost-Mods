// Decompiled with JetBrains decompiler
// Type: Pokefrost.CardScriptForsee
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class CardScriptForsee : CardScript
  {
    public static List<int> ids = new List<int>();

    public override void Run(CardData target)
    {
      if (!(target.name == "websiteofsites.wildfrost.pokefrost.natu") || !((Object) Campaign.instance != (Object) null))
        return;
      Debug.Log((object) "[Pokefrost] Forseeing...");
      int id = Campaign.FindCharacterNode(References.Player).id;
      foreach (CampaignNode node in Campaign.instance.nodes)
      {
        if (node.type.isBattle && node.id >= id)
        {
          id = node.id;
          break;
        }
      }
      foreach (CampaignNode campaignNode in (IEnumerable<CampaignNode>) Campaign.instance.nodes.InRandomOrder<CampaignNode>())
      {
        if (campaignNode.id > id)
        {
          if (campaignNode.type.name == "CampaignNodeItem" || campaignNode.type.name == "CampaignNodeCurseItems")
          {
            foreach (string name in (IEnumerable<string>) ((IEnumerable<string>) campaignNode.data.Get<SaveCollection<string>>("cards").collection).InRandomOrder<string>())
            {
              if (!Pokefrost.Pokefrost.rotomAppliances.Contains<string>(name) && !this.ConsumeOrClunker(name))
              {
                target.SetCustomData("Future Sight", (object) name);
                string str;
                target.TryGetCustomData<string>("Future Sight", out str, "");
                Debug.Log((object) string.Format("[Pokefrost] Foresaw {0}, {1}", (object) str, (object) campaignNode.id));
                target.SetCustomData("Future Sight ID", (object) campaignNode.id);
                return;
              }
            }
          }
          if (campaignNode.type.name == "CampaignNodeShop")
          {
            ShopRoutine.Data data = campaignNode.data.Get<ShopRoutine.Data>("shopData");
            foreach (int index in (IEnumerable<int>) data.items.GetIndices<ShopRoutine.Item>().InRandomOrder<int>())
            {
              if (data.items[index].category == "Items" && !this.ConsumeOrClunker(data.items[index].cardDataName))
              {
                target.SetCustomData("Future Sight ID", (object) campaignNode.id);
                target.SetCustomData("Future Sight", (object) data.items[index].cardDataName);
                string str;
                target.TryGetCustomData<string>("Future Sight", out str, "");
                Debug.Log((object) string.Format("[Pokefrost] Foresaw {0}, {1}", (object) str, (object) campaignNode.id));
                return;
              }
            }
          }
        }
      }
    }

    private bool ConsumeOrClunker(string name)
    {
      CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>(name);
      if (cardData?.cardType?.name != "Item" || cardData != null && cardData.playType == Card.PlayType.None)
        return true;
      if (cardData.traits != null)
      {
        foreach (CardData.TraitStacks trait in cardData.traits)
        {
          if ((Object) trait.data == (Object) null || trait.data.name == "Consume")
            return true;
        }
      }
      return false;
    }
  }
}
