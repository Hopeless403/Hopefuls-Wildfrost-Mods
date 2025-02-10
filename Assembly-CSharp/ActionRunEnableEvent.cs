// Decompiled with JetBrains decompiler
// Type: ActionRunEnableEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

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
