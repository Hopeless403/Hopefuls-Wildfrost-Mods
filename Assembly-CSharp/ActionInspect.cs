// Decompiled with JetBrains decompiler
// Type: ActionInspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
