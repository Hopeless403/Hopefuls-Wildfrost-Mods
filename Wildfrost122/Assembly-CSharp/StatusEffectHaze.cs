// Decompiled with JetBrains decompiler
// Type: StatusEffectHaze
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Haze", fileName = "Haze")]
public class StatusEffectHaze : StatusEffectData
{
  protected override void Init()
  {
    this.PreTrigger += new StatusEffectData.EffectTriggerEventHandler(this.EntityPreTrigger);
  }

  public override bool RunPreTriggerEvent(Trigger trigger)
  {
    return (Object) trigger.entity == (Object) this.target && trigger.type != "haze";
  }

  private IEnumerator EntityPreTrigger(Trigger trigger)
  {
    StatusEffectHaze statusEffectHaze = this;
    if (statusEffectHaze.TryTargetRandomAlly(trigger))
    {
      trigger.type = "haze";
    }
    else
    {
      trigger.nullified = true;
      if (NoTargetTextSystem.Exists())
        yield return (object) NoTargetTextSystem.Run(statusEffectHaze.target, NoTargetType.NoAllyToAttack);
    }
    yield return (object) statusEffectHaze.RemoveStacks(1, false);
  }

  private bool TryTargetRandomAlly(Trigger trigger)
  {
    bool flag = false;
    Entity randomAlly = this.GetRandomAlly();
    if ((bool) (Object) randomAlly)
    {
      CardContainer targetContainer = randomAlly.containers.RandomItem<CardContainer>();
      Entity[] subsequentTargets = this.target.targetMode.GetSubsequentTargets(trigger.entity, randomAlly, targetContainer);
      trigger.targets = subsequentTargets;
      flag = true;
    }
    return flag;
  }

  private Entity GetRandomAlly()
  {
    List<Entity> allAllies = this.target.GetAllAllies();
    return allAllies.Count > 0 ? allAllies.RandomItem<Entity>() : (Entity) null;
  }
}
