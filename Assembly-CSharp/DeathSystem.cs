// Decompiled with JetBrains decompiler
// Type: DeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class DeathSystem : GameSystem
{
  private void OnEnable() => global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);

  private void OnDisable() => global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);

  private void EntityKilled(Entity entity, DeathType deathType)
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

  private void Destroy(Card card)
  {
    CardDestroyed cardDestroyed = card.gameObject.AddComponent<CardDestroyed>();
    cardDestroyed.canvasGroup = card.canvasGroup;
    cardDestroyed.Knockback(card.entity.lastHit);
    card.transform.parent = this.transform;
  }

  private void Sacrifice(Card card)
  {
    card.gameObject.AddComponent<CardDestroyedSacrifice>();
    card.transform.parent = this.transform;
  }

  private void Consume(Card card)
  {
    card.gameObject.AddComponent<CardDestroyedConsume>();
    card.transform.parent = this.transform;
  }

  public static bool KilledByOwnTeam(Entity entity) => entity.lastHit != null && (bool) (Object) entity.lastHit.owner && entity.lastHit.owner.team == entity.owner.team && (Object) entity.lastHit.attacker != (Object) entity;
}
