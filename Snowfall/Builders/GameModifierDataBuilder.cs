// Decompiled with JetBrains decompiler
// Type: Snowfall2.Builders.GameModifierDataBuilder
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Snowfall2.Builders
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

    public override GameModifierDataBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        Object.Destroy((Object) this._data);
      this._data = ScriptableObject.CreateInstance<GameModifierData>();
      this._data.name = name;
      return this;
    }

    public GameModifierDataBuilder WithValue(int value)
    {
      this._data.value = value;
      return this;
    }

    public GameModifierDataBuilder SetVisible(bool visible)
    {
      this._data.visible = visible;
      return this;
    }

    public GameModifierDataBuilder WithSprites(Sprite bellSprite, Sprite dingerSprite)
    {
      this._data.bellSprite = bellSprite;
      this._data.dingerSprite = dingerSprite;
      return this;
    }

    public GameModifierDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Modifiers", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public GameModifierDataBuilder WithText(string text, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Modifiers", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", text);
      this._data.descriptionKey = collection.GetString(this._data.name + "_text");
      return this;
    }

    public GameModifierDataBuilder SetSystemsToAdd(params string[] systems)
    {
      this._data.systemsToAdd = systems;
      return this;
    }

    public GameModifierDataBuilder SetupScripts(params Script[] scripts)
    {
      this._data.setupScripts = scripts;
      return this;
    }

    public GameModifierDataBuilder StartScripts(params Script[] scripts)
    {
      this._data.startScripts = scripts;
      return this;
    }

    public GameModifierDataBuilder WithPriority(int priority)
    {
      this._data.scriptPriority = priority;
      return this;
    }

    public GameModifierDataBuilder BlockedBy(GameModifierData[] blockedBy)
    {
      this._data.blockedBy = blockedBy;
      return this;
    }

    public GameModifierDataBuilder SetRingerSfx(EventReference eventRef, Vector2 pitch)
    {
      this._data.ringSfxEvent = eventRef;
      this._data.ringSfxPitch = pitch;
      return this;
    }

    public GameModifierDataBuilder LinkToStormBell(HardModeModifierData stormBell)
    {
      this._data.linkedStormBell = stormBell;
      return this;
    }

    public GameModifierDataBuilder CreateGameModifier(string name, string title, string text) => this.Create(name).WithTitle(title).WithText(text).SetSystemsToAdd().SetupScripts().StartScripts();
  }
}
