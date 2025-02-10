// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.UnlockDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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

    public override UnlockDataBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = ScriptableObject.CreateInstance<UnlockData>();
      this._data.name = name;
      return this;
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
      this._data.requires = ((IEnumerable<string>) requires).Select<string, UnlockData>(new Func<string, UnlockData>(Extensions.GetUnlockData)).ToArray<UnlockData>();
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

    public UnlockDataBuilder WithBuilding(string relatedBuilding) => this.WithBuilding(Extensions.GetBuildingType(relatedBuilding));

    public UnlockDataBuilder WithType(UnlockData.Type type)
    {
      this._data.type = type;
      return this;
    }
  }
}
