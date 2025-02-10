// Decompiled with JetBrains decompiler
// Type: ActionTriggerSubsequent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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

  protected override Entity[] GetTargets()
  {
    return !(bool) (Object) this.entity.targetMode ? (Entity[]) null : this.entity.targetMode.GetSubsequentTargets(this.entity, this.target, this.targetContainer);
  }
}
