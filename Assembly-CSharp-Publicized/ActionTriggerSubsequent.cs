// Decompiled with JetBrains decompiler
// Type: ActionTriggerSubsequent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

  public override Entity[] GetTargets() => !(bool) (Object) this.entity.targetMode ? (Entity[]) null : this.entity.targetMode.GetSubsequentTargets(this.entity, this.target, this.targetContainer);
}
