// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.BuildingPlotTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class BuildingPlotTypeBuilder : DataFileBuilder<BuildingPlotType, BuildingPlotTypeBuilder>
  {
    public BuildingPlotTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public BuildingPlotTypeBuilder()
    {
    }

    public BuildingPlotTypeBuilder WithIllegalBuildings(params BuildingType[] illegalBuildings)
    {
      this._data.illegalBuildings = illegalBuildings;
      return this;
    }
  }
}
