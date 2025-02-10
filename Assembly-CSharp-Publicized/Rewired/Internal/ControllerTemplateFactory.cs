// Decompiled with JetBrains decompiler
// Type: Rewired.Internal.ControllerTemplateFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

namespace Rewired.Internal
{
  public static class ControllerTemplateFactory
  {
    public static readonly System.Type[] _defaultTemplateTypes = new System.Type[6]
    {
      typeof (GamepadTemplate),
      typeof (RacingWheelTemplate),
      typeof (HOTASTemplate),
      typeof (FlightYokeTemplate),
      typeof (FlightPedalsTemplate),
      typeof (SixDofControllerTemplate)
    };
    public static readonly System.Type[] _defaultTemplateInterfaceTypes = new System.Type[6]
    {
      typeof (IGamepadTemplate),
      typeof (IRacingWheelTemplate),
      typeof (IHOTASTemplate),
      typeof (IFlightYokeTemplate),
      typeof (IFlightPedalsTemplate),
      typeof (ISixDofControllerTemplate)
    };

    public static System.Type[] templateTypes => ControllerTemplateFactory._defaultTemplateTypes;

    public static System.Type[] templateInterfaceTypes => ControllerTemplateFactory._defaultTemplateInterfaceTypes;

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
