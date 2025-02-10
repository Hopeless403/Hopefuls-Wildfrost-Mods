// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ChallengeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ChallengeDataBuilder : DataFileBuilder<ChallengeData, ChallengeDataBuilder>
  {
    public ChallengeDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public ChallengeDataBuilder WithTitle(LocalizedString str)
    {
      this._data.titleKey = str;
      return this;
    }

    public ChallengeDataBuilder WithText(LocalizedString str)
    {
      this._data.textKey = str;
      return this;
    }

    public ChallengeDataBuilder WithRewardText(LocalizedString str)
    {
      this._data.rewardKey = str;
      return this;
    }

    public ChallengeDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public ChallengeDataBuilder WithText(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", title);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }

    public ChallengeDataBuilder()
    {
    }

    public ChallengeDataBuilder WithRewardText(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Challenges", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_reward", title);
      this._data.rewardKey = collection.GetString(this._data.name + "_reward");
      return this;
    }

    public ChallengeDataBuilder WithGoal(int amountGoal)
    {
      this._data.goal = amountGoal;
      return this;
    }

    public ChallengeDataBuilder WithListener(ChallengeListener listener)
    {
      this._data.listener = listener;
      return this;
    }

    public ChallengeDataBuilder WithListener(string listener)
    {
      this._data.listener = this.Mod.Get<ChallengeListener>(listener);
      return this;
    }

    public ChallengeDataBuilder WithIcon(Sprite icon)
    {
      this._data.icon = icon;
      return this;
    }

    public ChallengeDataBuilder WithRequires(params ChallengeData[] requires)
    {
      this._data.requires = requires;
      return this;
    }

    public ChallengeDataBuilder WithRequires(params string[] requires)
    {
      this._data.requires = ((IEnumerable<string>) requires).Select<string, ChallengeData>(new Func<string, ChallengeData>(this.Mod.Get<ChallengeData>)).ToArray<ChallengeData>();
      return this;
    }

    public ChallengeDataBuilder WithReward(UnlockData reward)
    {
      this._data.reward = reward;
      return this;
    }

    public ChallengeDataBuilder WithReward(string reward)
    {
      this._data.reward = this.Mod.Get<UnlockData>(reward);
      return this;
    }
  }
}
