// Decompiled with JetBrains decompiler
// Type: PermadeathModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class PermadeathModifierSystem : GameSystem
{
  public static readonly string[] LegalTypes = new string[1]
  {
    "Friendly"
  };

  public void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(PermadeathModifierSystem.EntityKilled);
  }

  public void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(PermadeathModifierSystem.EntityKilled);
  }

  public static void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!PermadeathModifierSystem.IsPlayerCard(entity) || !PermadeathModifierSystem.IsLegalCardType(entity))
      return;
    PermadeathModifierSystem.RemoveFromDeck(entity, References.PlayerData.inventory);
  }

  public static bool IsPlayerCard(Entity entity)
  {
    return (Object) entity.owner == (Object) References.Player && References.PlayerData.inventory.deck.Contains(entity.data);
  }

  public static bool IsLegalCardType(Entity entity)
  {
    return PermadeathModifierSystem.LegalTypes.Contains<string>(entity.data.cardType.name);
  }

  public static void RemoveFromDeck(Entity entity, Inventory inventory)
  {
    Debug.Log((object) string.Format("Permadeath System → deleting [{0}]", (object) entity.data));
    inventory.deck.Remove(entity.data);
  }
}
