// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.UnlockDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class UnlockDataBuilder : DataFileBuilder<UnlockData, UnlockDataBuilder>
  {
    public UnlockDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public UnlockDataBuilder()
    {
    }

    public UnlockDataBuilder WithUnlockDescription(LocalizedString str)
    {
      this._data.unlockDesc = str;
      return this;
    }

    public UnlockDataBuilder WithUnlockTitle(LocalizedString str)
    {
      this._data.unlockTitle = str;
      return this;
    }

    public UnlockDataBuilder WithUnlockDescription(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_unlockDesc", title);
      this._data.unlockDesc = collection.GetString(this._data.name + "_unlockDesc");
      return this;
    }

    public UnlockDataBuilder WithUnlockTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_unlockTitle", title);
      this._data.unlockTitle = collection.GetString(this._data.name + "_unlockTitle");
      return this;
    }

    public UnlockDataBuilder WithRequires(params UnlockData[] requires)
    {
      this._data.requires = requires;
      return this;
    }

    public UnlockDataBuilder WithRequires(params string[] requires)
    {
      this._data.requires = ((IEnumerable<string>) requires).Select<string, UnlockData>(new Func<string, UnlockData>(this.Mod.Get<UnlockData>)).ToArray<UnlockData>();
      return this;
    }

    public UnlockDataBuilder WithLowPriority(float priority)
    {
      this._data.lowPriority = priority;
      return this;
    }

    public UnlockDataBuilder WithBuilding(BuildingType relatedBuilding)
    {
      this._data.relatedBuilding = relatedBuilding;
      this.SubscribeToBuildEvent((DataFileBuilder<UnlockData, UnlockDataBuilder>.AfterBuildDelegate) (data => relatedBuilding.unlocks = relatedBuilding.unlocks.AddToArray<UnlockData>(data)));
      return this;
    }

    public UnlockDataBuilder WithBuilding(string relatedBuilding) => this.WithBuilding(this.Mod.Get<BuildingType>(relatedBuilding));

    public UnlockDataBuilder WithType(UnlockData.Type type)
    {
      this._data.type = type;
      return this;
    }
  }
}
