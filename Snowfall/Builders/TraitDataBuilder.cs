// Decompiled with JetBrains decompiler
// Type: Snowfall2.Builders.TraitDataBuilder
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;

namespace Snowfall2.Builders
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

    public override TraitDataBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        Object.Destroy((Object) this._data);
      this._data = ScriptableObject.CreateInstance<TraitData>();
      this._data.name = name;
      return this;
    }

    public TraitDataBuilder SetKeyword(KeywordData data)
    {
      this._data.keyword = data;
      return this;
    }

    public TraitDataBuilder SetEffects(params StatusEffectData[] effects)
    {
      this._data.effects = effects;
      return this;
    }

    public TraitDataBuilder SetOverrides(params TraitData[] overrides)
    {
      this._data.overrides = overrides;
      return this;
    }

    public TraitDataBuilder IsReaction(bool isReaction)
    {
      this._data.isReaction = isReaction;
      return this;
    }

    public TraitDataBuilder CreateTrait(string name, KeywordData keyword, bool isReaction = false) => this.Create(name).SetKeyword(keyword).SetEffects().SetOverrides().IsReaction(isReaction);
  }
}
