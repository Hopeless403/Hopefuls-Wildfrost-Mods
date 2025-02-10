// Decompiled with JetBrains decompiler
// Type: ActionShove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;

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
