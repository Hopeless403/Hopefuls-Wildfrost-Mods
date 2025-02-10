// Decompiled with JetBrains decompiler
// Type: ShopPriceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class ShopPriceManager : MonoBehaviour
{
  [SerializeField]
  public ShopPrice pricePrefab;
  [SerializeField]
  public List<ShopPrice> targets = new List<ShopPrice>();
  [SerializeField]
  public ShopPriceManager.PositionProfile[] positionProfiles;

  public void LateUpdate()
  {
    for (int index = this.targets.Count - 1; index >= 0; --index)
    {
      ShopPrice target = this.targets[index];
      if (!(bool) (UnityEngine.Object) target)
        this.targets.RemoveAt(index);
      else
        target.UpdatePosition();
    }
  }

  public ShopPrice Add(ShopItem target, ShopPrice.Position position)
  {
    ShopPriceManager.PositionProfile positionProfile = ((IEnumerable<ShopPriceManager.PositionProfile>) this.positionProfiles).FirstOrDefault<ShopPriceManager.PositionProfile>((Func<ShopPriceManager.PositionProfile, bool>) (a => a.type == position));
    ShopPrice shopPrice = UnityEngine.Object.Instantiate<ShopPrice>(this.pricePrefab, this.transform, false);
    shopPrice.Set(target, positionProfile.offset);
    shopPrice.gameObject.SetActive(true);
    this.targets.Add(shopPrice);
    return shopPrice;
  }

  public ShopPrice Get(ShopItem target)
  {
    return this.targets.Find((Predicate<ShopPrice>) (a => (UnityEngine.Object) a.target == (UnityEngine.Object) target));
  }

  public void Remove(ShopItem target)
  {
    ShopPrice shopPrice = this.Get(target);
    shopPrice.gameObject.Destroy();
    this.targets.Remove(shopPrice);
  }

  public void Clear()
  {
    foreach (Component target in this.targets)
      target.Destroy();
    this.targets.Clear();
  }

  [Serializable]
  public struct PositionProfile
  {
    public ShopPrice.Position type;
    public Vector3 offset;
  }
}
