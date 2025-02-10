// Decompiled with JetBrains decompiler
// Type: ActionShove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
public class ActionShove : PlayAction
{
  public readonly Dictionary<Entity, List<CardSlot>> shoveData;
  public readonly bool updatePositions;

  public ActionShove(Dictionary<Entity, List<CardSlot>> shoveData, bool updatePositions = false)
  {
    this.shoveData = shoveData;
    this.updatePositions = updatePositions;
  }

  public override IEnumerator Run() => ShoveSystem.DoShove(this.shoveData, this.updatePositions);
}
