// Decompiled with JetBrains decompiler
// Type: ActionInspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public class ActionInspect : PlayAction
{
  public Entity entity;
  private InspectSystem inspectSystem;

  public override bool IsRoutine => false;

  public ActionInspect(Entity entity, InspectSystem inspectSystem)
  {
    this.entity = entity;
    this.inspectSystem = inspectSystem;
  }

  public override void Process() => this.inspectSystem.Inspect(this.entity);
}
