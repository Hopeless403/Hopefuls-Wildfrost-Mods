// Decompiled with JetBrains decompiler
// Type: ActionShove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;

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
