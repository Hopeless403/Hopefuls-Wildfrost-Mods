// Decompiled with JetBrains decompiler
// Type: ActionRunEnableEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

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
