// Decompiled with JetBrains decompiler
// Type: ActionTriggerSubsequent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ActionTriggerSubsequent : ActionTriggerAgainst
{
  public ActionTriggerSubsequent(
    Entity entity,
    Entity triggeredBy,
    Entity target,
    CardContainer targetContainer)
    : base(entity, triggeredBy, target, targetContainer)
  {
  }

  protected override Entity[] GetTargets() => !(bool) (Object) this.entity.targetMode ? (Entity[]) null : this.entity.targetMode.GetSubsequentTargets(this.entity, this.target, this.targetContainer);
}
