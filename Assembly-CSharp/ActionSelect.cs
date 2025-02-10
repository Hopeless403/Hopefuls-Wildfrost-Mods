// Decompiled with JetBrains decompiler
// Type: ActionSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

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
