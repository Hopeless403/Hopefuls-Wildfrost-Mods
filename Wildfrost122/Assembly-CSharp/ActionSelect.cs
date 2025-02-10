// Decompiled with JetBrains decompiler
// Type: ActionSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

#nullable disable
public class ActionSelect : PlayAction
{
  public Entity entity;
  private Action<Entity> action;

  public override bool IsRoutine => false;

  public ActionSelect(Entity entity, Action<Entity> action)
  {
    this.entity = entity;
    this.action = action;
  }

  public override void Process() => this.action(this.entity);
}
