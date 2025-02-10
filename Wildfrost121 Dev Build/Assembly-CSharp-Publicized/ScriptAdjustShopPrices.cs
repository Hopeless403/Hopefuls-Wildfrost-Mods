// Decompiled with JetBrains decompiler
// Type: ScriptAdjustShopPrices
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Adjust Shop Prices", menuName = "Scripts/Adjust Shop Prices")]
public class ScriptAdjustShopPrices : Script
{
  [SerializeField]
  public Vector2Int cardPrices = new Vector2Int(5, 5);
  [SerializeField]
  public Vector2Int charmPrices = new Vector2Int(5, 5);
  [SerializeField]
  public Vector2Int charmMachinePrice = new Vector2Int(5, 5);
  [SerializeField]
  public Vector2Int charmMachineAddPrice = new Vector2Int(5, 5);
  [SerializeField]
  public Vector2Int crownPrice = new Vector2Int(5, 5);
  [SerializeField]
  public Vector2Int crownAddPrice = new Vector2Int(5, 5);

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        CampaignNodeType type = current.type;
        if (!(type is CampaignNodeTypeShop))
        {
          if (type is CampaignNodeTypeCharmShop)
          {
            EventRoutineCharmShop.Data data = current.data.Get<EventRoutineCharmShop.Data>("data");
            foreach (EventRoutineCharmShop.UpgradedCard card in data.cards)
              card.price += this.cardPrices.Random();
            foreach (EventRoutineCharmShop.CharmShopItemData charmShopItemData in data.items)
              charmShopItemData.price += this.charmPrices.Random();
          }
        }
        else
        {
          ShopRoutine.Data data = current.data.Get<ShopRoutine.Data>("shopData");
          data.charmPrice += this.charmMachinePrice.Random();
          data.charmPriceAdd += this.charmMachineAddPrice.Random();
          data.crownPrice += this.crownPrice.Random();
          data.crownPriceAdd += this.crownAddPrice.Random();
          foreach (ShopRoutine.Item obj in data.items)
            obj.price += this.cardPrices.Random();
        }
      }
      yield break;
    }
  }
}
