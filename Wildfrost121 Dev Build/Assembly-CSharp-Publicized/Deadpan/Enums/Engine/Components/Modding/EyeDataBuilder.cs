// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.EyeDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
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
