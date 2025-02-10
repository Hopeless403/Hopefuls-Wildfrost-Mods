// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BattleDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BattleDataBuilder : DataFileBuilder<BattleData, BattleDataBuilder>
  {
    public BattleDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BattleDataBuilder()
    {
    }

    public BattleDataBuilder WithTitle(string title)
    {
      this._data.title = title;
      return this;
    }

    public BattleDataBuilder WithPointFactor(float factor = 1f)
    {
      this._data.pointFactor = factor;
      return this;
    }

    public BattleDataBuilder WithWaveCounter(int waveCounter = 4)
    {
      this._data.waveCounter = waveCounter;
      return this;
    }

    public BattleDataBuilder WithPools(params BattleWavePoolData[] pools)
    {
      this._data.pools = pools;
      return this;
    }

    public BattleDataBuilder WithBonusUnitPool(params CardData[] pools)
    {
      this._data.bonusUnitPool = pools;
      return this;
    }

    public BattleDataBuilder WithBonusUnitRange(Vector2Int v)
    {
      this._data.bonusUnitRange = v;
      return this;
    }

    public BattleDataBuilder WithGoldGiverPool(params CardData[] pools)
    {
      this._data.goldGiverPool = pools;
      return this;
    }

    public BattleDataBuilder WithGoldGivers(int amount = 1)
    {
      this._data.goldGivers = amount;
      return this;
    }

    public BattleDataBuilder WithGenerationScript(BattleGenerationScript s)
    {
      this._data.generationScript = s;
      return this;
    }

    public BattleDataBuilder WithSetUpScript(Script s)
    {
      this._data.setUpScript = s;
      return this;
    }

    public BattleDataBuilder WithSprite(Sprite sprite)
    {
      this._data.sprite = sprite;
      return this;
    }

    public BattleDataBuilder WithSprite(string sprite)
    {
      this._data.sprite = this.Mod.GetImageSprite(sprite);
      return this;
    }

    public BattleDataBuilder WithName(string name, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_ref", name);
      this._data.nameRef = collection.GetString(this._data.name + "_ref");
      return this;
    }
  }
}
