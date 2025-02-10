// Decompiled with JetBrains decompiler
// Type: StatusEffectShuffleEnemiesAndAllies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Shuffle Enemies And Allies", fileName = "Shuffle Enemies And Allies")]
public class StatusEffectShuffleEnemiesAndAllies : StatusEffectData
{
  protected override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Run);
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (Object) entity == (Object) this.target;
  }

  private IEnumerator Run(Entity entity, Entity[] targets)
  {
    StatusEffectShuffleEnemiesAndAllies enemiesAndAllies = this;
    Debug.Log((object) string.Format("{0} Running...", (object) enemiesAndAllies));
    List<CardContainer> rows = Battle.instance.GetRows(enemiesAndAllies.target.owner);
    rows.AddRange((IEnumerable<CardContainer>) Battle.instance.GetRows(Battle.GetOpponent(enemiesAndAllies.target.owner)));
    foreach (CardContainer cardContainer in rows)
    {
      List<Entity> list = new List<Entity>();
      foreach (Entity entity1 in cardContainer)
        list.Add(entity1);
      if (list.Count > 0)
        list.Shuffle<Entity>();
      foreach (Entity entity2 in list)
        cardContainer.Remove(entity2);
      foreach (Entity entity3 in list)
        cardContainer.Add(entity3);
      cardContainer.TweenChildPositions();
    }
    double num = (double) enemiesAndAllies.target.curveAnimator.Ping();
    yield return (object) Sequences.Wait(0.13f);
  }
}
