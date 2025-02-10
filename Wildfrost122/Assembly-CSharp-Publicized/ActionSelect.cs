// Decompiled with JetBrains decompiler
// Type: ActionSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
public class ActionSelect : PlayAction
{
  public Entity entity;
  public Action<Entity> action;

  public override bool IsRoutine => false;

  public ActionSelect(Entity entity, Action<Entity> action)
  {
    this.entity = entity;
    this.action = action;
  }

  public override void Process() => this.action(this.entity);
}
