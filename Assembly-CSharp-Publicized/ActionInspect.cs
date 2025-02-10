// Decompiled with JetBrains decompiler
// Type: ActionInspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
