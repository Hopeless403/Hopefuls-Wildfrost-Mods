﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.StatusEffectDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class StatusEffectDataBuilder : DataFileBuilder<StatusEffectData, StatusEffectDataBuilder>
  {
    public StatusEffectDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public StatusEffectDataBuilder()
    {
    }

    public StatusEffectDataBuilder WithIsStatus(bool value)
    {
      this._data.isStatus = value;
      return this;
    }

    public StatusEffectDataBuilder WithIsReaction(bool value)
    {
      this._data.isReaction = value;
      return this;
    }

    public StatusEffectDataBuilder WithIsKeyword(bool value)
    {
      this._data.isKeyword = value;
      return this;
    }

    public StatusEffectDataBuilder WithType(string type)
    {
      this._data.type = type;
      return this;
    }

    public StatusEffectDataBuilder WithKeyword(string type)
    {
      this._data.keyword = type;
      return this;
    }

    public StatusEffectDataBuilder WithIconGroupName(string type)
    {
      this._data.iconGroupName = type;
      return this;
    }

    public StatusEffectDataBuilder WithVisible(bool value)
    {
      this._data.visible = value;
      return this;
    }

    public StatusEffectDataBuilder WithStackable(bool value)
    {
      this._data.stackable = value;
      return this;
    }

    public StatusEffectDataBuilder WithOffensive(bool value)
    {
      this._data.offensive = value;
      return this;
    }

    public StatusEffectDataBuilder WithMakesOffensive(bool value)
    {
      this._data.makesOffensive = value;
      return this;
    }

    public StatusEffectDataBuilder WithDoesDamage(bool value)
    {
      this._data.doesDamage = value;
      return this;
    }

    public StatusEffectDataBuilder WithCanBeBoosted(bool value)
    {
      this._data.canBeBoosted = value;
      return this;
    }

    public StatusEffectDataBuilder WithText(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Card Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", title);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }

    public StatusEffectDataBuilder WithTextInsert(string value)
    {
      this._data.textInsert = value;
      return this;
    }

    public StatusEffectDataBuilder WithOrder(int order)
    {
      this._data.textOrder = order;
      return this;
    }
  }
}
