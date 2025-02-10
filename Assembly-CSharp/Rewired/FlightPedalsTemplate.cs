// Decompiled with JetBrains decompiler
// Type: Rewired.FlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
