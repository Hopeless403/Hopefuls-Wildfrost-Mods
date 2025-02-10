// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.GameModifierDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class GameModifierDataBuilder : DataFileBuilder<GameModifierData, GameModifierDataBuilder>
  {
    public GameModifierDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public GameModifierDataBuilder()
    {
    }

    public GameModifierDataBuilder WithValue(int value = 100)
    {
      this._data.value = value;
      return this;
    }

    public GameModifierDataBuilder WithVisible(bool visible = true)
    {
      this._data.visible = visible;
      return this;
    }

    public GameModifierDataBuilder WithBellSprite(Sprite bellSprite)
    {
      this._data.bellSprite = bellSprite;
      return this;
    }

    public GameModifierDataBuilder WithBellSprite(string bellSprite)
    {
      this._data.bellSprite = this.Mod.GetImageSprite(bellSprite);
      return this;
    }

    public GameModifierDataBuilder WithDingerSprite(Sprite dingerSprite)
    {
      this._data.dingerSprite = dingerSprite;
      return this;
    }

    public GameModifierDataBuilder WithDingerSprite(string dingerSprite)
    {
      this._data.dingerSprite = this.Mod.GetImageSprite(dingerSprite);
      return this;
    }

    public GameModifierDataBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public GameModifierDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_modifier_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_modifier_title");
      return this;
    }

    public GameModifierDataBuilder WithDescription(LocalizedString title)
    {
      this._data.descriptionKey = title;
      return this;
    }

    public GameModifierDataBuilder WithDescription(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_modifier_desc", title);
      this._data.descriptionKey = collection.GetString(this._data.name + "_modifier_desc");
      return this;
    }

    public GameModifierDataBuilder WithSystemsToAdd(params string[] systemsToAdd)
    {
      this._data.systemsToAdd = systemsToAdd;
      return this;
    }

    public GameModifierDataBuilder WithSetupScripts(params Script[] setupScripts)
    {
      this._data.setupScripts = setupScripts;
      return this;
    }

    public GameModifierDataBuilder WithStartScripts(params Script[] startScripts)
    {
      this._data.startScripts = startScripts;
      return this;
    }

    public GameModifierDataBuilder WithScriptPriority(int scriptPriority)
    {
      this._data.scriptPriority = scriptPriority;
      return this;
    }

    public GameModifierDataBuilder WithBlockedBy(params GameModifierData[] blockedBy)
    {
      this._data.blockedBy = blockedBy;
      return this;
    }

    public GameModifierDataBuilder WithLinkedStormBell(HardModeModifierData linkedStormBell)
    {
      this._data.linkedStormBell = linkedStormBell;
      return this;
    }

    public GameModifierDataBuilder WithRingSfxEvent(EventReference ringSfxEvent)
    {
      this._data.ringSfxEvent = ringSfxEvent;
      return this;
    }

    public GameModifierDataBuilder WithRingSfxPitch()
    {
      this._data.ringSfxPitch = new Vector2(1f, 1f);
      return this;
    }

    public GameModifierDataBuilder WithRingSfxPitch(Vector2 ringSfxPitch)
    {
      this._data.ringSfxPitch = ringSfxPitch;
      return this;
    }
  }
}
