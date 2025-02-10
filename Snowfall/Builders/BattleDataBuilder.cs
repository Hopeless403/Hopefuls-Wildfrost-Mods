// Decompiled with JetBrains decompiler
// Type: Snowfall2.Builders.BattleDataBuilder
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Snowfall2.Builders
{
  public class BattleDataBuilder : DataFileBuilder<BattleData, BattleDataBuilder>
  {
    private BattleData Default => this.Mod.Get<BattleData>("Snowbos");

    private static bool WaveContainsEnemyLeader(BattleWavePoolData.Wave wave) => wave.units.Any<CardData>((Func<CardData, bool>) (unit => unit.cardType.miniboss));

    private static bool PoolAlwaysContainsEnemyLeader(BattleWavePoolData pool) => ((IEnumerable<BattleWavePoolData.Wave>) pool.waves).All<BattleWavePoolData.Wave>(BattleDataBuilder.\u003C\u003EO.\u003C0\u003E__WaveContainsEnemyLeader ?? (BattleDataBuilder.\u003C\u003EO.\u003C0\u003E__WaveContainsEnemyLeader = new Func<BattleWavePoolData.Wave, bool>(BattleDataBuilder.WaveContainsEnemyLeader)));

    public BattleDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BattleDataBuilder()
    {
    }

    public override BattleDataBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = ScriptableObject.CreateInstance<BattleData>();
      this._data.name = name;
      return this;
    }

    public BattleDataBuilder WithNodeName(string name, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_name", name);
      this._data.nameRef = collection.GetString(this._data.name + "_name");
      return this;
    }

    public BattleDataBuilder SetSprite(Sprite sprite)
    {
      this._data.sprite = sprite;
      return this;
    }

    public BattleDataBuilder SetPointFactor(float factor)
    {
      this._data.pointFactor = factor;
      return this;
    }

    public BattleDataBuilder SetWaveCounter(int counter)
    {
      this._data.waveCounter = counter;
      return this;
    }

    public BattleDataBuilder WithWavePools(params BattleWavePoolData[] pools)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this._data.pools = ((IEnumerable<BattleWavePoolData>) pools).Any<BattleWavePoolData>(BattleDataBuilder.\u003C\u003EO.\u003C1\u003E__PoolAlwaysContainsEnemyLeader ?? (BattleDataBuilder.\u003C\u003EO.\u003C1\u003E__PoolAlwaysContainsEnemyLeader = new Func<BattleWavePoolData, bool>(BattleDataBuilder.PoolAlwaysContainsEnemyLeader))) ? ((IEnumerable<BattleWavePoolData>) pools).Reverse<BattleWavePoolData>().ToArray<BattleWavePoolData>() : throw new Exception("The given set of wave pools in battle " + this._data.name + " may not have an enemy miniboss/boss present!");
      return this;
    }

    public BattleDataBuilder SetGoldGivers(int count, params CardData[] pool)
    {
      this._data.goldGivers = count;
      this._data.goldGiverPool = pool;
      return this;
    }

    public BattleDataBuilder UseDefaultGoldGiverPool()
    {
      this._data.goldGiverPool = this.Default.goldGiverPool;
      return this;
    }

    public BattleDataBuilder SetBonusUnits(int minCount, int maxCount, params CardData[] pool)
    {
      this._data.bonusUnitRange = new Vector2Int(minCount, maxCount);
      this._data.bonusUnitPool = pool;
      return this;
    }

    public BattleDataBuilder SetScripts(Script setUpScript, BattleGenerationScript generationScript)
    {
      this._data.setUpScript = setUpScript;
      this._data.generationScript = generationScript;
      return this;
    }

    public BattleDataBuilder UseDefaultScripts()
    {
      this._data.setUpScript = this.Default.setUpScript;
      this._data.generationScript = this.Default.generationScript;
      return this;
    }

    public BattleDataBuilder CreateBattle(
      string name,
      string nodeName,
      Sprite nodeSprite,
      BattleWavePoolData[] pools,
      int goldGiverCount = 0)
    {
      return this.Create(name).WithNodeName(nodeName).SetSprite(nodeSprite).SetPointFactor(1f).SetWaveCounter(5).WithWavePools(pools).SetGoldGivers(goldGiverCount).SetBonusUnits(0, 0).UseDefaultScripts();
    }
  }
}
