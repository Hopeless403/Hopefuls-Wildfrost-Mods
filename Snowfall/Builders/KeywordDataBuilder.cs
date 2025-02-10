// Decompiled with JetBrains decompiler
// Type: Snowfall2.Builders.KeywordDataBuilder
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Snowfall2.Builders
{
  public class KeywordDataBuilder : DataFileBuilder<KeywordData, KeywordDataBuilder>
  {
    public KeywordDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public KeywordDataBuilder()
    {
    }

    public override KeywordDataBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = ScriptableObject.CreateInstance<KeywordData>();
      this._data.name = name;
      return this;
    }

    public KeywordDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Card Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public KeywordDataBuilder WithDesc(string desc, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Card Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_desc", desc);
      this._data.descKey = collection.GetString(this._data.name + "_desc");
      return this;
    }

    public KeywordDataBuilder ShowName(bool showName)
    {
      this._data.showName = showName;
      return this;
    }

    public KeywordDataBuilder CanStack(bool canStack)
    {
      this._data.canStack = canStack;
      return this;
    }

    public KeywordDataBuilder CreateKeyword(
      string name,
      string title,
      string desc,
      bool canStack = false,
      bool showName = true)
    {
      KeywordData barrageBase = this.Mod.Get<KeywordData>("barrage");
      return this.Create(name).WithTitle(title).WithDesc(desc).ShowName(showName).CanStack(canStack).FreeModify((Action<KeywordData>) (kd =>
      {
        kd.show = true;
        kd.showIcon = false;
        kd.panelSprite = barrageBase.panelSprite;
        kd.panelColor = barrageBase.panelColor;
        kd.iconTintHex = "FFCA57";
      }));
    }
  }
}
