// Decompiled with JetBrains decompiler
// Type: ActionRunEnableEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

#nullable disable
public class ActionRunEnableEvent : PlayAction
{
  private readonly Entity entity;

  public ActionRunEnableEvent(Entity entity) => this.entity = entity;

  public override IEnumerator Run()
  {
    if (this.entity.StillExists())
    {
      this.entity.enabled = true;
      Events.InvokeEntityEnabled(this.entity);
      yield return (object) StatusEffectSystem.EntityEnableEvent(this.entity);
    }
  }
}
