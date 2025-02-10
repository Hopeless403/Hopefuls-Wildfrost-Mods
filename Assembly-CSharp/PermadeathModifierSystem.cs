// Decompiled with JetBrains decompiler
// Type: PermadeathModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class PermadeathModifierSystem : GameSystem
{
  private static readonly string[] LegalTypes = new string[1]
  {
    "Friendly"
  };

  private void OnEnable() => global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(PermadeathModifierSystem.EntityKilled);

  private void OnDisable() => global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(PermadeathModifierSystem.EntityKilled);

  private static void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!PermadeathModifierSystem.IsPlayerCard(entity) || !PermadeathModifierSystem.IsLegalCardType(entity))
      return;
    PermadeathModifierSystem.RemoveFromDeck(entity, References.PlayerData.inventory);
  }

  private static bool IsPlayerCard(Entity entity) => (Object) entity.owner == (Object) References.Player && References.PlayerData.inventory.deck.Contains(entity.data);

  private static bool IsLegalCardType(Entity entity) => PermadeathModifierSystem.LegalTypes.Contains<string>(entity.data.cardType.name);

  private static void RemoveFromDeck(Entity entity, Inventory inventory)
  {
    Debug.Log((object) string.Format("Permadeath System → deleting [{0}]", (object) entity.data));
    inventory.deck.Remove(entity.data);
  }
}
