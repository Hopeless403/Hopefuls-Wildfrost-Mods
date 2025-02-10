// Decompiled with JetBrains decompiler
// Type: DeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DeathSystem : GameSystem
{
  public static readonly Dictionary<ulong, int> treatAsTeam = new Dictionary<ulong, int>();

  public void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityCreated += new UnityAction<Entity>(DeathSystem.EntityCreated);
  }

  public void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityCreated -= new UnityAction<Entity>(DeathSystem.EntityCreated);
  }

  public static void EntityCreated(Entity entity) => DeathSystem.treatAsTeam.Remove(entity.data.id);

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!(bool) (Object) entity || !(entity.display is Card display) || display.GetComponent<ICardDestroyed>() != null)
      return;
    if (deathType != DeathType.Sacrifice)
    {
      if (deathType != DeathType.Consume)
        this.Destroy(display);
      else
        this.Consume(display);
    }
    else
      this.Sacrifice(display);
  }

  public void Destroy(Card card)
  {
    CardDestroyed cardDestroyed = card.gameObject.AddComponent<CardDestroyed>();
    cardDestroyed.canvasGroup = card.canvasGroup;
    cardDestroyed.Knockback(card.entity.lastHit);
    card.transform.parent = this.transform;
  }

  public void Sacrifice(Card card)
  {
    card.gameObject.AddComponent<CardDestroyedSacrifice>();
    card.transform.parent = this.transform;
  }

  public void Consume(Card card)
  {
    card.gameObject.AddComponent<CardDestroyedConsume>();
    card.transform.parent = this.transform;
  }

  public static bool KilledByOwnTeam(Entity entity)
  {
    return entity.lastHit != null && (bool) (Object) entity.lastHit.owner && entity.lastHit.owner.team == entity.owner.team && (Object) entity.lastHit.attacker != (Object) entity;
  }

  public static void TreatAsTeam(ulong cardDataId, int team)
  {
    DeathSystem.treatAsTeam.Add(cardDataId, team);
  }

  public static bool CheckTeamIsAlly(Entity entity, Entity checkAgainst)
  {
    int num;
    return DeathSystem.treatAsTeam.TryGetValue(entity.data.id, out num) ? checkAgainst.owner.team == num : checkAgainst.owner.team == entity.owner.team;
  }
}
