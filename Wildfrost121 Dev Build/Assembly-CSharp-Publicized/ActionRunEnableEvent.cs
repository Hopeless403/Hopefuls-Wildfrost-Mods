// Decompiled with JetBrains decompiler
// Type: ActionRunEnableEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
public class ActionRunEnableEvent : PlayAction
{
  public readonly Entity entity;

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
