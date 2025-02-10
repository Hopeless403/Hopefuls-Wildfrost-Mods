// Decompiled with JetBrains decompiler
// Type: ActionInspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
public class ActionInspect : PlayAction
{
  public Entity entity;
  public InspectSystem inspectSystem;

  public override bool IsRoutine => false;

  public ActionInspect(Entity entity, InspectSystem inspectSystem)
  {
    this.entity = entity;
    this.inspectSystem = inspectSystem;
  }

  public override void Process() => this.inspectSystem.Inspect(this.entity);
}
