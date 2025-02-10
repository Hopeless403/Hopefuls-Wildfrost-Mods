// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.TraitDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class TraitDataBuilder : DataFileBuilder<TraitData, TraitDataBuilder>
  {
    public TraitDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public TraitDataBuilder()
    {
    }

    public TraitDataBuilder WithKeyword(KeywordData data)
    {
      this._data.keyword = data;
      return this;
    }

    public TraitDataBuilder WithEffects(params StatusEffectData[] effects)
    {
      this._data.effects = effects;
      return this;
    }

    public TraitDataBuilder WithOverrides(params TraitData[] traits)
    {
      this._data.overrides = traits;
      return this;
    }

    public TraitDataBuilder WithIsReaction(bool isReaction)
    {
      this._data.isReaction = isReaction;
      return this;
    }
  }
}
