// Decompiled with JetBrains decompiler
// Type: BattleGenerationScriptFinalBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "FinalBossBattleGenerator", menuName = "Battle Generation Scripts/Final Boss")]
public class BattleGenerationScriptFinalBoss : BattleGenerationScript
{
  [SerializeField]
  public FinalBossGenerationSettings settings;
  [SerializeField]
  public CardType leaderCardType;
  [SerializeField]
  public CardType enemyCardType;
  [Header("Waves")]
  [SerializeField]
  public int waveCount = 3;
  [SerializeField]
  public int leaderWave;
  [SerializeField]
  public int bossWave = 3;
  [SerializeField]
  public int[] waveMaxSize = new int[3]{ 6, 6, 6 };
  [SerializeField]
  public bool insertBossAtFront;
  [SerializeField]
  public bool insertLeaderAtFront;
  [Header("Boss")]
  [SerializeField]
  public CardData[] bossOptions;
  [SerializeField]
  public StatusEffectData[] leaderNextPhase;
  [Header("Default Deck")]
  [SerializeField]
  public CardData[] defaultLeaderOptions;
  [SerializeField]
  public bool processDefaultLeader;
  [SerializeField]
  public CardData[] defaultDeck;

  public CardData[] LoadCards(GameMode gameMode)
  {
    if (!gameMode.mainGameMode)
      return (CardData[]) null;
    CardSaveData[] data = SaveSystem.LoadProgressData<CardSaveData[]>("finalBossDeck", (CardSaveData[]) null);
    if (data == null)
      return (CardData[]) null;
    CardData[] source = data.LoadArray<CardData, CardSaveData>();
    return source == null ? (CardData[]) null : ((IEnumerable<CardData>) source).Where<CardData>((Func<CardData, bool>) (a => !MissingCardSystem.IsMissing(a))).ToArray<CardData>();
  }

  public void GetBaseEnemies(
    CardData[] cardList,
    int seed,
    out List<CardData> enemiesCloned,
    out bool hasStoredCards,
    out bool hasLeader,
    out CardData leaderCloned,
    out bool hasBoss,
    out CardData bossCloned)
  {
    UnityEngine.Random.State state = UnityEngine.Random.state;
    UnityEngine.Random.InitState(seed);
    int num = ((IEnumerable<int>) this.waveMaxSize).Sum();
    leaderCloned = (CardData) null;
    hasLeader = false;
    hasStoredCards = cardList != null;
    if (!hasStoredCards)
    {
      enemiesCloned = new List<CardData>();
      foreach (CardData cardData in (IEnumerable<CardData>) ((IEnumerable<CardData>) this.defaultDeck).InRandomOrder<CardData>())
      {
        enemiesCloned.Add(cardData.Clone());
        if (enemiesCloned.Count >= num)
          break;
      }
    }
    else
    {
      List<CardData> list = ((IEnumerable<CardData>) cardList).Where<CardData>((Func<CardData, bool>) (a =>
      {
        string name = a.cardType.name;
        return (name == "Friendly" || name == "Enemy" ? 0 : (!(name == "Leader") ? 1 : 0)) == 0;
      })).ToList<CardData>();
      this.settings.ReplaceCards((IList<CardData>) list);
      enemiesCloned = new List<CardData>(list.Select<CardData, CardData>((Func<CardData, CardData>) (a => a.Clone(a.random3, false))));
      enemiesCloned.Shuffle<CardData>();
      leaderCloned = enemiesCloned.FirstOrDefault<CardData>((Func<CardData, bool>) (a => a.cardType.name == "Leader"));
      if ((bool) (UnityEngine.Object) leaderCloned)
      {
        hasLeader = true;
        leaderCloned.cardType = this.leaderCardType;
      }
      this.settings.Process(leaderCloned, (IList<CardData>) enemiesCloned);
      foreach (CardData cardData in enemiesCloned)
        cardData.SetCustomData("eyes", (object) "frost");
    }
    foreach (CardData cardData in enemiesCloned.Where<CardData>((Func<CardData, bool>) (a => a.cardType.name == "Friendly")))
      cardData.cardType = this.enemyCardType;
    if (!hasLeader && this.defaultLeaderOptions.Length != 0)
    {
      hasLeader = true;
      leaderCloned = this.defaultLeaderOptions.RandomItem<CardData>().Clone();
      leaderCloned.cardType = this.leaderCardType;
      enemiesCloned.Insert(0, leaderCloned);
      if (this.processDefaultLeader)
        this.settings.Process(leaderCloned, (IList<CardData>) new List<CardData>()
        {
          leaderCloned
        });
    }
    hasBoss = this.bossOptions.Length != 0;
    bossCloned = (CardData) null;
    if (hasBoss)
    {
      bossCloned = this.bossOptions.RandomItem<CardData>().Clone();
      enemiesCloned.Insert(0, bossCloned);
    }
    int count = num + (hasLeader ? 1 : 0) - enemiesCloned.Count;
    if (count > 0 & hasStoredCards)
      enemiesCloned.AddRange(this.settings.GenerateBonusEnemies(count, (IEnumerable<CardData>) cardList, this.defaultDeck));
    UnityEngine.Random.state = state;
  }

  public override SaveCollection<BattleWaveManager.WaveData> Run(BattleData battleData, int points)
  {
    Debug.Log((object) string.Format("Creating FINAL BOSS WAVES for [{0}]", (object) battleData));
    List<CardData> enemiesCloned;
    bool hasLeader;
    CardData leaderCloned;
    bool hasBoss;
    CardData bossCloned;
    this.GetBaseEnemies(this.LoadCards(Campaign.Data.GameMode), Campaign.Data.Seed, out enemiesCloned, out bool _, out hasLeader, out leaderCloned, out hasBoss, out bossCloned);
    if (hasLeader)
      enemiesCloned.Remove(leaderCloned);
    if (hasBoss)
      enemiesCloned.Remove(bossCloned);
    if (hasLeader && this.leaderNextPhase.Length != 0)
      leaderCloned.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) leaderCloned.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
      {
        new CardData.StatusEffectStacks(this.leaderNextPhase.RandomItem<StatusEffectData>(), 1)
      });
    BattleGenerationScript.WaveList waves = new BattleGenerationScript.WaveList(Mathf.RoundToInt((float) points * battleData.pointFactor));
    for (int index = 0; index < this.waveCount; ++index)
      waves.Add(new BattleWavePoolData.Wave()
      {
        units = new List<CardData>(),
        maxSize = this.waveMaxSize[index],
        positionPriority = index
      });
    int num = 0;
    foreach (CardData cardData in enemiesCloned)
    {
      bool flag = false;
      for (int index = 0; index < this.waveCount; ++index)
      {
        BattleWavePoolData.Wave wave = waves.GetWave(index % this.waveCount);
        if (wave.maxSize > 0 && wave.CanAddTo())
        {
          flag = true;
          wave.units.Add(cardData);
          break;
        }
        ++num;
      }
      ++num;
      if (!flag)
        break;
    }
    if (hasLeader)
    {
      List<CardData> units = waves.GetWave(this.leaderWave).units;
      if (this.insertLeaderAtFront)
        units.Insert(0, leaderCloned);
      else
        units.Add(leaderCloned);
    }
    if (hasBoss)
    {
      List<CardData> units = waves.GetWave(this.bossWave).units;
      if (this.insertBossAtFront)
        units.Insert(0, bossCloned);
      else
        units.Add(bossCloned);
    }
    for (int index = this.waveCount - 1; index >= 0; --index)
    {
      if (waves.GetWave(index).units.Count <= 0)
        waves.RemoveAt(index);
    }
    this.AddGoldGivers(waves, battleData);
    this.AddBonusUnits(waves, battleData);
    List<BattleWaveManager.WaveData> collection = new List<BattleWaveManager.WaveData>();
    int count = waves.Count;
    for (int waveIndex = 0; waveIndex < count; ++waveIndex)
    {
      BattleWaveManager.WaveDataFull waveDataFull1 = new BattleWaveManager.WaveDataFull();
      waveDataFull1.counter = battleData.waveCounter;
      BattleWaveManager.WaveDataFull waveDataFull2 = waveDataFull1;
      BattleWavePoolData.Wave wave = waves.GetWave(waveIndex);
      List<CardSaveData> cardSaveDataList = new List<CardSaveData>();
      foreach (CardData unit in wave.units)
      {
        cardSaveDataList.Add(unit.Save());
        if (!waveDataFull2.isBossWave && unit.cardType.miniboss)
          waveDataFull2.isBossWave = true;
      }
      waveDataFull2.cardDatas = cardSaveDataList.ToArray();
      collection.Add((BattleWaveManager.WaveData) waveDataFull2);
    }
    foreach (UnityEngine.Object @object in enemiesCloned)
      UnityEngine.Object.Destroy(@object);
    if ((bool) (UnityEngine.Object) leaderCloned)
      UnityEngine.Object.Destroy((UnityEngine.Object) leaderCloned);
    if ((bool) (UnityEngine.Object) bossCloned)
      UnityEngine.Object.Destroy((UnityEngine.Object) bossCloned);
    return new SaveCollection<BattleWaveManager.WaveData>(collection);
  }
}
