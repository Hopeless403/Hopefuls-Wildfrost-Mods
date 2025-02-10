// Decompiled with JetBrains decompiler
// Type: Rewired.FlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
namespace Rewired
{
  public sealed class FlightPedalsTemplate : 
    ControllerTemplate,
    IFlightPedalsTemplate,
    IControllerTemplate
  {
    public static readonly Guid typeGuid = new Guid("f6fe76f8-be2a-4db2-b853-9e3652075913");
    public const int elementId_leftPedal = 0;
    public const int elementId_rightPedal = 1;
    public const int elementId_slide = 2;

    IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
    {
      get => this.GetElement<IControllerTemplateAxis>(0);
    }

    IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
    {
      get => this.GetElement<IControllerTemplateAxis>(1);
    }

    IControllerTemplateAxis IFlightPedalsTemplate.slide
    {
      get => this.GetElement<IControllerTemplateAxis>(2);
    }

    public FlightPedalsTemplate(object payload)
      : base(payload)
    {
    }
  }
}
