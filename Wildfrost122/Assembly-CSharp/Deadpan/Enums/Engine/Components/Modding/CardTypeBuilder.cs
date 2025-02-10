// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CardTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CardTypeBuilder : DataFileBuilder<CardType, CardTypeBuilder>
  {
    public CardTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CardTypeBuilder()
    {
    }

    public CardTypeBuilder WithSortPriority(int sortPriority)
    {
      this._data.sortPriority = sortPriority;
      return this;
    }

    public CardTypeBuilder WithIcon(Sprite icon)
    {
      this._data.icon = icon;
      return this;
    }

    public CardTypeBuilder WithIcon(string icon)
    {
      this._data.icon = this.Mod.GetImageSprite(icon);
      return this;
    }

    public CardTypeBuilder WithPrefabRef(AssetReference prefabRef)
    {
      this._data.prefabRef = prefabRef;
      return this;
    }

    public CardTypeBuilder WithTextBoxSprite(Sprite icon)
    {
      this._data.textBoxSprite = icon;
      return this;
    }

    public CardTypeBuilder WithTextBoxSprite(string icon)
    {
      this._data.textBoxSprite = this.Mod.GetImageSprite(icon);
      return this;
    }

    public CardTypeBuilder WithNameTagSprite(Sprite icon)
    {
      this._data.nameTagSprite = icon;
      return this;
    }

    public CardTypeBuilder WithNameTagSprite(string icon)
    {
      this._data.nameTagSprite = this.Mod.GetImageSprite(icon);
      return this;
    }

    public CardTypeBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Cards", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_type_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_type_title");
      return this;
    }

    public CardTypeBuilder WithTitle(LocalizedString str)
    {
      this._data.titleKey = str;
      return this;
    }

    public CardTypeBuilder WithCanDie(bool canDie)
    {
      this._data.canDie = canDie;
      return this;
    }

    public CardTypeBuilder WithCanTakeCrown(bool canTakeCrown)
    {
      this._data.canTakeCrown = canTakeCrown;
      return this;
    }

    public CardTypeBuilder WithCanRecall(bool canRecall)
    {
      this._data.canRecall = canRecall;
      return this;
    }

    public CardTypeBuilder WithCanReserve(bool canReserve)
    {
      this._data.canReserve = canReserve;
      return this;
    }

    public CardTypeBuilder WithItem(bool item)
    {
      this._data.item = item;
      return this;
    }

    public CardTypeBuilder WithUnit(bool unit)
    {
      this._data.unit = unit;
      return this;
    }

    public CardTypeBuilder WithTag(string tag)
    {
      this._data.tag = tag;
      return this;
    }

    public CardTypeBuilder WithMiniboss(bool miniboss)
    {
      this._data.miniboss = miniboss;
      return this;
    }

    public CardTypeBuilder WithDiscoverInJournal(bool discoverInJournal)
    {
      this._data.discoverInJournal = discoverInJournal;
      return this;
    }

    public CardTypeBuilder WithDescriptionColours(Text.ColourProfileHex descriptionColours)
    {
      this._data.descriptionColours = descriptionColours;
      return this;
    }
  }
}
