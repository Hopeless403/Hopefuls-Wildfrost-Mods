// Decompiled with JetBrains decompiler
// Type: ActionShove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
public class ActionShove : PlayAction
{
  private readonly Dictionary<Entity, List<CardSlot>> shoveData;
  private readonly bool updatePositions;

  public ActionShove(Dictionary<Entity, List<CardSlot>> shoveData, bool updatePositions = false)
  {
    this.shoveData = shoveData;
    this.updatePositions = updatePositions;
  }

  public override IEnumerator Run() => ShoveSystem.DoShove(this.shoveData, this.updatePositions);
}
