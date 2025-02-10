// Decompiled with JetBrains decompiler
// Type: ScriptBattleSetUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "BattleSetUp", menuName = "Scripts/Battle Set Up")]
public class ScriptBattleSetUp : Script
{
  public override IEnumerator Run()
  {
    Character player = References.Player;
    Character enemy = References.Battle.enemy;
    CampaignNode node = Campaign.FindCharacterNode(player);
    Events.InvokePreBattleSetUp(node);
    ScriptBattleSetUp.SetUpEnemyWaves(enemy, node);
    UnityEngine.Random.InitState(node.seed);
    yield return (object) ScriptBattleSetUp.CreateCards(player, enemy);
    Events.InvokePostBattleSetUp(node);
  }

  private static void SetUpEnemyWaves(Character enemy, CampaignNode node)
  {
    BattleWaveManager component = enemy.GetComponent<BattleWaveManager>();
    component.list = new List<BattleWaveManager.Wave>();
    foreach (BattleWaveManager.WaveData save in node.data.GetSaveCollection<BattleWaveManager.WaveData>("waves"))
    {
      BattleWaveManager.Wave wave = new BattleWaveManager.Wave(save);
      component.list.Add(wave);
    }
  }

  private static IEnumerator CreateCards(Character player, Character enemy)
  {
    CardController objectOfType = UnityEngine.Object.FindObjectOfType<CardController>();
    Routine.Clump clump = new Routine.Clump();
    List<Entity> enemyCards = new List<Entity>();
    List<Entity> playerCards = new List<Entity>();
    clump.Add(ScriptBattleSetUp.CreateEnemyCards(enemy, objectOfType, (IList<Entity>) enemyCards));
    clump.Add(ScriptBattleSetUp.CreatePlayerCards(player, objectOfType, (IList<Entity>) playerCards));
    yield return (object) clump.WaitForEnd();
    Vector3 vector3_1 = Vector3.one * enemy.reserveContainer.CardScale;
    foreach (Entity entity in enemyCards)
    {
      enemy.reserveContainer.Add(entity);
      entity.transform.localScale = vector3_1;
    }
    enemy.reserveContainer.SetChildPositions();
    Vector3 vector3_2 = Vector3.one * player.drawContainer.CardScale;
    foreach (Entity entity in (IEnumerable<Entity>) playerCards.InRandomOrder<Entity>())
    {
      player.drawContainer.Add(entity);
      entity.transform.localScale = vector3_2;
    }
    player.drawContainer.SetChildPositions();
  }

  private static IEnumerator CreateEnemyCards(
    Character enemy,
    CardController cardController,
    IList<Entity> entities)
  {
    Routine.Clump clump = new Routine.Clump();
    BattleWaveManager waveManager = enemy.GetComponent<BattleWaveManager>();
    int num = waveManager.list.Sum<BattleWaveManager.Wave>((Func<BattleWaveManager.Wave, int>) (a => a.units.Count));
    while (entities.Count < num)
      entities.Add((Entity) null);
    int entityIndex = 0;
    for (int waveIndex = 0; waveIndex < waveManager.list.Count; ++waveIndex)
    {
      BattleWaveManager.Wave wave = waveManager.list[waveIndex];
      List<Entity> entitiesThisWave = new List<Entity>();
      while (entitiesThisWave.Count < wave.units.Count)
        entitiesThisWave.Add((Entity) null);
      for (int index = 0; index < wave.units.Count; ++index)
      {
        Card card = CardManager.Get(wave.units[index], cardController, enemy, true, false);
        entitiesThisWave[index] = card.entity;
        card.entity.flipper.FlipDownInstant();
        entities[entityIndex++] = card.entity;
        clump.Add(card.UpdateData(false));
      }
      yield return (object) clump.WaitForEnd();
      waveManager.AddEntities(entitiesThisWave.ToArray());
      Debug.Log((object) string.Format("{0} Created", (object) wave));
      wave = (BattleWaveManager.Wave) null;
      entitiesThisWave = (List<Entity>) null;
    }
  }

  private static IEnumerator CreatePlayerCards(
    Character player,
    CardController cardController,
    IList<Entity> entities)
  {
    Routine.Clump clump = new Routine.Clump();
    int count = player.data.inventory.deck.Count;
    while (entities.Count < count)
      entities.Add((Entity) null);
    for (int index = 0; index < count; ++index)
    {
      Card card = CardManager.Get(player.data.inventory.deck[index], cardController, player, true, true);
      entities[index] = card.entity;
      card.entity.flipper.FlipDownInstant();
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
  }
}
