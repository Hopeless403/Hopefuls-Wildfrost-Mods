﻿// Decompiled with JetBrains decompiler
// Type: Rewired.IFlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Rewired
{
  public interface IFlightPedalsTemplate : IControllerTemplate
  {
    IControllerTemplateAxis leftPedal { get; }

    IControllerTemplateAxis rightPedal { get; }

    IControllerTemplateAxis slide { get; }
  }
}
