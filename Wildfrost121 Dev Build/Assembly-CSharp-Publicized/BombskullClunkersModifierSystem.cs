// Decompiled with JetBrains decompiler
// Type: BombskullClunkersModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BombskullClunkersModifierSystem : GameSystem
{
  public static CardUpgradeData _upgradeData;
  public readonly List<ulong> ids = new List<ulong>();

  public static CardUpgradeData upgradeData
  {
    get
    {
      return BombskullClunkersModifierSystem._upgradeData ?? (BombskullClunkersModifierSystem._upgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", "CardUpgradeBombskull"));
    }
  }

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityCreated);
  }

  public void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Clunker"))
      return;
    this.ids.Add(cardData.id);
  }

  public void EntityCreated(Entity entity)
  {
    if (!this.ids.Contains(entity.data.id))
      return;
    this.ids.Remove(entity.data.id);
    if (!(bool) (Object) entity.owner || entity.owner.team != References.Player.team)
      return;
    BombskullClunkersModifierSystem.upgradeData.Clone().Assign(entity.data);
  }
}
