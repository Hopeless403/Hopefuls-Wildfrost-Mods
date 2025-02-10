// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BuildingTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BuildingTypeBuilder : DataFileBuilder<BuildingType, BuildingTypeBuilder>
  {
    public BuildingTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BuildingTypeBuilder()
    {
    }

    public BuildingTypeBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public BuildingTypeBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_building_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_building_title");
      return this;
    }

    public BuildingTypeBuilder WithHelp(LocalizedString title)
    {
      this._data.helpKey = title;
      return this;
    }

    public BuildingTypeBuilder WithHelp(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_building_help", title);
      this._data.helpKey = collection.GetString(this._data.name + "_building_help");
      return this;
    }

    public BuildingTypeBuilder WithHelpEmoteType(Prompt.Emote.Type helpEmoteType = Prompt.Emote.Type.Explain)
    {
      this._data.helpEmoteType = helpEmoteType;
      return this;
    }

    public BuildingTypeBuilder WithStarted(UnlockData started)
    {
      this._data.started = started;
      return this;
    }

    public BuildingTypeBuilder WithFinished(UnlockData finished)
    {
      this._data.finished = finished;
      return this;
    }

    public BuildingTypeBuilder WithUnlocks(params UnlockData[] unlocks)
    {
      this._data.unlocks = unlocks;
      return this;
    }

    public BuildingTypeBuilder WithUnlockedCheckedKey(string unlockedCheckedKey)
    {
      this._data.unlockedCheckedKey = unlockedCheckedKey;
      return this;
    }
  }
}
