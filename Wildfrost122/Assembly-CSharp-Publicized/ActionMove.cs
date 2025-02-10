// Decompiled with JetBrains decompiler
// Type: ActionMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
public class ActionMove : PlayAction
{
  public readonly Entity entity;
  public CardContainer[] toContainers;
  public int insertPos = -1;
  public bool tweenAll = true;

  public ActionMove(Entity entity, params CardContainer[] toContainers)
  {
    this.entity = entity;
    this.toContainers = toContainers;
  }

  public ActionMove(Entity entity, CardContainer[] toContainers, int insertPos)
  {
    this.entity = entity;
    this.toContainers = toContainers;
    this.insertPos = insertPos;
  }

  public override IEnumerator Run()
  {
    if (this.entity.IsAliveAndExists() && this.toContainers != null)
      yield return (object) Sequences.CardMove(this.entity, this.toContainers, this.insertPos, this.tweenAll);
  }
}
