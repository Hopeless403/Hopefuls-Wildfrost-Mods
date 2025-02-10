// Decompiled with JetBrains decompiler
// Type: StatusEffectShuffleEnemiesAndAllies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Shuffle Enemies And Allies", fileName = "Shuffle Enemies And Allies")]
public class StatusEffectShuffleEnemiesAndAllies : StatusEffectData
{
  public override void Init() => this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Run);

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets) => (Object) entity == (Object) this.target;

  public IEnumerator Run(Entity entity, Entity[] targets)
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
