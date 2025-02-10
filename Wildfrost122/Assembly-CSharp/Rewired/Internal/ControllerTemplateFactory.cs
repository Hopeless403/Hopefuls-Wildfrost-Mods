// Decompiled with JetBrains decompiler
// Type: Rewired.Internal.ControllerTemplateFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

#nullable disable
namespace Rewired.Internal
{
  public static class ControllerTemplateFactory
  {
    private static readonly System.Type[] _defaultTemplateTypes = new System.Type[6]
    {
      typeof (GamepadTemplate),
      typeof (RacingWheelTemplate),
      typeof (HOTASTemplate),
      typeof (FlightYokeTemplate),
      typeof (FlightPedalsTemplate),
      typeof (SixDofControllerTemplate)
    };
    private static readonly System.Type[] _defaultTemplateInterfaceTypes = new System.Type[6]
    {
      typeof (IGamepadTemplate),
      typeof (IRacingWheelTemplate),
      typeof (IHOTASTemplate),
      typeof (IFlightYokeTemplate),
      typeof (IFlightPedalsTemplate),
      typeof (ISixDofControllerTemplate)
    };

    public static System.Type[] templateTypes => ControllerTemplateFactory._defaultTemplateTypes;

    public static System.Type[] templateInterfaceTypes
    {
      get => ControllerTemplateFactory._defaultTemplateInterfaceTypes;
    }

    public static IControllerTemplate Create(Guid typeGuid, object payload)
    {
      if (typeGuid == GamepadTemplate.typeGuid)
        return (IControllerTemplate) new GamepadTemplate(payload);
      if (typeGuid == RacingWheelTemplate.typeGuid)
        return (IControllerTemplate) new RacingWheelTemplate(payload);
      if (typeGuid == HOTASTemplate.typeGuid)
        return (IControllerTemplate) new HOTASTemplate(payload);
      if (typeGuid == FlightYokeTemplate.typeGuid)
        return (IControllerTemplate) new FlightYokeTemplate(payload);
      if (typeGuid == FlightPedalsTemplate.typeGuid)
        return (IControllerTemplate) new FlightPedalsTemplate(payload);
      return typeGuid == SixDofControllerTemplate.typeGuid ? (IControllerTemplate) new SixDofControllerTemplate(payload) : (IControllerTemplate) null;
    }
  }
}
