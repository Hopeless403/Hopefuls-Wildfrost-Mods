// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystemHighCardsInHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
public class ChallengeListenerSystemHighCardsInHand : ChallengeListenerSystem
{
  public const int required = 12;
  public readonly List<Entity> summonedToCheck = new List<Entity>();

  public void OnEnable()
  {
    global::Events.OnCardDrawEnd += new UnityAction(this.CardDrawEnd);
    global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
  }

  public void OnDisable()
  {
    global::Events.OnCardDrawEnd -= new UnityAction(this.CardDrawEnd);
    global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
  }

  public void CardDrawEnd() => this.CheckRequirement();

  public void EntitySummoned(Entity entity, Entity summonedBy) => this.summonedToCheck.Add(entity);

  public void EntityMove(Entity entity)
  {
    int index = this.summonedToCheck.IndexOf(entity);
    if (index < 0)
      return;
    this.summonedToCheck.RemoveAt(index);
    this.CheckRequirement();
  }

  public void CheckRequirement()
  {
    if (References.Player.handContainer.Count < 12)
      return;
    this.Complete();
  }
}
