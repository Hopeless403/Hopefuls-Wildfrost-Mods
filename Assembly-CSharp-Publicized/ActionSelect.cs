// Decompiled with JetBrains decompiler
// Type: ActionSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

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
