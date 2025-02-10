// Decompiled with JetBrains decompiler
// Type: ScriptChangeShopPrices
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Shop Prices", menuName = "Scripts/Change Shop Prices")]
public class ScriptChangeShopPrices : Script
{
  [SerializeField]
  public Vector2Int itemsToAffect = new Vector2Int(2, 3);
  [SerializeField]
  public Vector2 affectPriceRange = new Vector2(1f, 1.5f);
  [SerializeField]
  public Vector2 charmPriceRange = new Vector2(1f, 1.5f);
  [SerializeField]
  public Vector2 crownPriceRange = new Vector2(1f, 1.5f);
  [SerializeField]
  public float removeDiscountChance = 0.5f;

  public override IEnumerator Run()
  {
    using (IEnumerator<CampaignNode> enumerator = Campaign.instance.nodes.Where<CampaignNode>((Func<CampaignNode, bool>) (node => node.type is CampaignNodeTypeShop)).GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        object obj1;
        if (enumerator.Current.data.TryGetValue("shopData", out obj1) && obj1 is ShopRoutine.Data data)
        {
          int num1 = this.itemsToAffect.Random();
          foreach (ShopRoutine.Item obj2 in (IEnumerable<ShopRoutine.Item>) data.items.OrderBy<ShopRoutine.Item, float>((Func<ShopRoutine.Item, float>) (a => UnityEngine.Random.Range(0.0f, 1f))))
          {
            float num2 = this.affectPriceRange.Random();
            obj2.price = Mathf.RoundToInt((float) obj2.price * num2);
            if ((double) num2 < 1.0 && (double) UnityEngine.Random.Range(0.0f, 1f) < (double) this.removeDiscountChance)
              ;
            --num1;
            if (num1 <= 0)
              break;
          }
          data.charmPrice = Mathf.RoundToInt((float) data.charmPrice * this.charmPriceRange.Random());
          data.crownPrice = Mathf.RoundToInt((float) data.crownPrice * this.crownPriceRange.Random());
        }
      }
      yield break;
    }
  }
}
