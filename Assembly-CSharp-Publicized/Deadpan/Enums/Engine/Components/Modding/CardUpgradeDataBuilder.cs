// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CardUpgradeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using MonoMod.Cil;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CardUpgradeDataBuilder : DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>
  {
    public ChallengeData UnlockChallenge;

    public CardUpgradeDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CardUpgradeDataBuilder()
    {
    }

    public CardUpgradeDataBuilder CreateCharm(string name) => this.Create(name).WithType(CardUpgradeData.Type.Charm).AddPool();

    public CardUpgradeDataBuilder WithPools(params RewardPool[] pools)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.WithPools(pools));
      return this;
    }

    public CardUpgradeDataBuilder WithPools(params string[] pools)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.WithPools(((IEnumerable<string>) pools).Select<string, RewardPool>(new System.Func<string, RewardPool>(Extensions.GetRewardPool)).ToArray<RewardPool>()));
      return this;
    }

    public CardUpgradeDataBuilder AddPool(RewardPool pool)
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.AddPool(pool));
      return this;
    }

    public CardUpgradeDataBuilder AddPool(string pool = "GeneralCharmPool")
    {
      this.AfterBuildEvent += (DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data => data.AddPool(Extensions.GetRewardPool(pool)));
      return this;
    }

    public CardUpgradeDataBuilder WithTier(int tier)
    {
      this._data.tier = tier;
      return this;
    }

    public CardUpgradeDataBuilder WithImage(Sprite img)
    {
      this._data.image = img;
      return this;
    }

    public CardUpgradeDataBuilder WithType(CardUpgradeData.Type type)
    {
      this._data.type = type;
      return this;
    }

    public CardUpgradeDataBuilder SetAttackEffects(params CardData.StatusEffectStacks[] efs)
    {
      this._data.attackEffects = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetEffects(params CardData.StatusEffectStacks[] efs)
    {
      this._data.effects = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetTraits(params CardData.TraitStacks[] efs)
    {
      this._data.giveTraits = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetScripts(params CardScript[] efs)
    {
      this._data.scripts = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetConstraints(params TargetConstraint[] efs)
    {
      this._data.targetConstraints = efs;
      return this;
    }

    public CardUpgradeDataBuilder SetBecomesTarget(bool val)
    {
      this._data.becomesTargetedCard = val;
      return this;
    }

    public CardUpgradeDataBuilder SetCanBeRemoved(bool val)
    {
      this._data.canBeRemoved = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeDamage(int val)
    {
      this._data.damage = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeHP(int val)
    {
      this._data.hp = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeCounter(int val)
    {
      this._data.counter = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeUses(int val)
    {
      this._data.uses = val;
      return this;
    }

    public CardUpgradeDataBuilder ChangeEffectBonus(int val)
    {
      this._data.effectBonus = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetDamage(bool val)
    {
      this._data.setDamage = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetHP(bool val)
    {
      this._data.setHp = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetCounter(bool val)
    {
      this._data.setCounter = val;
      return this;
    }

    public CardUpgradeDataBuilder WithSetUses(bool val)
    {
      this._data.setUses = val;
      return this;
    }

    public CardUpgradeDataBuilder IsCharm(ChallengeData challenge, bool value = true)
    {
      this.UnlockChallenge = challenge;
      if (value)
      {
        this._data.AddToCharms(challenge.reward);
        BuildingSequenceWithUnlocks<ChallengeShrineSequence>.OnStart += new RuntimeILReferenceBag.FastDelegateInvokers.Action<ChallengeShrineSequence>(this.UnlockSequenceOnOnStart<ChallengeShrineSequence>);
      }
      else
      {
        this._data.RemoveFromCharms(challenge.reward);
        BuildingSequenceWithUnlocks<ChallengeShrineSequence>.OnStart -= new RuntimeILReferenceBag.FastDelegateInvokers.Action<ChallengeShrineSequence>(this.UnlockSequenceOnOnStart<ChallengeShrineSequence>);
      }
      return this;
    }

    public void UnlockSequenceOnOnStart<T>(BuildingSequenceWithUnlocks<T> obj) where T : BuildingSequenceWithUnlocks<T> => obj.AddChallengeStone(this.UnlockChallenge);

    public CardUpgradeDataBuilder WithImage(string img)
    {
      this._data.image = this.Mod.ImagePath(img).ToSprite();
      return this;
    }

    public CardUpgradeDataBuilder WithTitle(LocalizedString title)
    {
      this._data.titleKey = title;
      return this;
    }

    public CardUpgradeDataBuilder WithText(LocalizedString text)
    {
      this._data.textKey = text;
      return this;
    }

    public CardUpgradeDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Upgrades", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public CardUpgradeDataBuilder WithText(string text, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Upgrades", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_text", text);
      this._data.textKey = collection.GetString(this._data.name + "_text");
      return this;
    }
  }
}
