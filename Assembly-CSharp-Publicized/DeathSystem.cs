// Decompiled with JetBrains decompiler
// Type: DeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class DeathSystem : GameSystem
{
  public void OnEnable() => global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);

  public void OnDisable() => global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);

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

  public static bool KilledByOwnTeam(Entity entity) => entity.lastHit != null && (bool) (Object) entity.lastHit.owner && entity.lastHit.owner.team == entity.owner.team && (Object) entity.lastHit.attacker != (Object) entity;
}
