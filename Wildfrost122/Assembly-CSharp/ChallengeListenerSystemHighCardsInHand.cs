// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystemHighCardsInHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
public class ChallengeListenerSystemHighCardsInHand : ChallengeListenerSystem
{
  private const int required = 12;
  private readonly List<Entity> summonedToCheck = new List<Entity>();

  private void OnEnable()
  {
    global::Events.OnCardDrawEnd += new UnityAction(this.CardDrawEnd);
    global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
  }

  private void OnDisable()
  {
    global::Events.OnCardDrawEnd -= new UnityAction(this.CardDrawEnd);
    global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
  }

  private void CardDrawEnd() => this.CheckRequirement();

  private void EntitySummoned(Entity entity, Entity summonedBy) => this.summonedToCheck.Add(entity);

  private void EntityMove(Entity entity)
  {
    int index = this.summonedToCheck.IndexOf(entity);
    if (index < 0)
      return;
    this.summonedToCheck.RemoveAt(index);
    this.CheckRequirement();
  }

  private void CheckRequirement()
  {
    if (References.Player.handContainer.Count < 12)
      return;
    this.Complete();
  }
}
