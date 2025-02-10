// Decompiled with JetBrains decompiler
// Type: Rewired.FlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

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

    IControllerTemplateAxis IFlightPedalsTemplate.leftPedal => this.GetElement<IControllerTemplateAxis>(0);

    IControllerTemplateAxis IFlightPedalsTemplate.rightPedal => this.GetElement<IControllerTemplateAxis>(1);

    IControllerTemplateAxis IFlightPedalsTemplate.slide => this.GetElement<IControllerTemplateAxis>(2);

    public FlightPedalsTemplate(object payload)
      : base(payload)
    {
    }
  }
}
