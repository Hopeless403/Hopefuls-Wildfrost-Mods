// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.EyeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class EyeDataBuilder : DataFileBuilder<EyeData, EyeDataBuilder>
  {
    public EyeDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public EyeDataBuilder()
    {
    }

    public EyeDataBuilder WithCardData(string cardData)
    {
      this._data.cardData = cardData;
      return this;
    }

    public EyeDataBuilder WithCardData(CardData cardData)
    {
      this._data.cardData = cardData.name;
      return this;
    }

    public EyeDataBuilder WithEyes(params EyeData.Eye[] eyes)
    {
      this._data.eyes = eyes;
      return this;
    }
  }
}
