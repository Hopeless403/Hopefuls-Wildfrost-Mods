// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.KeywordDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
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

    public KeywordDataBuilder WithTitle(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_title", title);
      this._data.titleKey = collection.GetString(this._data.name + "_title");
      return this;
    }

    public KeywordDataBuilder WithDescription(string title, SystemLanguage lang = SystemLanguage.English)
    {
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", new LocaleIdentifier(lang));
      collection.SetString(this._data.name + "_desc", title);
      this._data.descKey = collection.GetString(this._data.name + "_desc");
      return this;
    }

    public KeywordDataBuilder WithTitleColour(Color? theColour = null)
    {
      if (!theColour.HasValue)
        theColour = new Color?(new Color(1f, 0.7921569f, 0.3411765f, 1f));
      this._data.titleColour = theColour.Value;
      return this;
    }

    public KeywordDataBuilder WithBodyColour(Color? theColour = null)
    {
      if (!theColour.HasValue)
        theColour = new Color?(Color.white);
      this._data.bodyColour = theColour.Value;
      return this;
    }

    public KeywordDataBuilder WithNoteColour(Color? theColour = null)
    {
      if (!theColour.HasValue)
        theColour = new Color?(Color.gray);
      this._data.noteColour = theColour.Value;
      return this;
    }

    public KeywordDataBuilder WithPanelColour(Color theColour)
    {
      this._data.panelColor = theColour;
      return this;
    }

    public KeywordDataBuilder WithPanelSprite(string image)
    {
      this._data.panelSprite = this.Mod.GetImageSprite(image);
      return this;
    }

    public KeywordDataBuilder WithIconName(string iconName)
    {
      this._data.iconName = iconName;
      return this;
    }

    public KeywordDataBuilder WithIconTint(Color hexColor)
    {
      this._data.iconTintHex = hexColor.ToHexRGB();
      return this;
    }

    public KeywordDataBuilder WithShow(bool show = true)
    {
      this._data.show = show;
      return this;
    }

    public KeywordDataBuilder WithShowName(bool show)
    {
      this._data.showName = show;
      return this;
    }

    public KeywordDataBuilder WithShowIcon(bool show = true)
    {
      this._data.showIcon = show;
      return this;
    }

    public KeywordDataBuilder WithCanStack(bool show)
    {
      this._data.canStack = show;
      return this;
    }
  }
}
