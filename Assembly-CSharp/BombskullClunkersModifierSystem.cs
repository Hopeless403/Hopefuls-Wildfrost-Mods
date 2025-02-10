// Decompiled with JetBrains decompiler
// Type: BombskullClunkersModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombskullClunkersModifierSystem : GameSystem
{
  private static CardUpgradeData _upgradeData;
  private readonly List<ulong> ids = new List<ulong>();

  private static CardUpgradeData upgradeData => BombskullClunkersModifierSystem._upgradeData ?? (BombskullClunkersModifierSystem._upgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", "CardUpgradeBombskull"));

  private void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityCreated);
  }

  private void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityCreated);
  }

  private void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Clunker"))
      return;
    this.ids.Add(cardData.id);
  }

  private void EntityCreated(Entity entity)
  {
    if (!this.ids.Contains(entity.data.id))
      return;
    this.ids.Remove(entity.data.id);
    if (!(bool) (Object) entity.owner || entity.owner.team != References.Player.team)
      return;
    BombskullClunkersModifierSystem.upgradeData.Clone().Assign(entity.data);
  }
}
