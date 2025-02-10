// Decompiled with JetBrains decompiler
// Type: StatusEffectHaze
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Haze", fileName = "Haze")]
public class StatusEffectHaze : StatusEffectData
{
  protected override void Init() => this.PreTrigger += new StatusEffectData.EffectTriggerEventHandler(this.EntityPreTrigger);

  public override bool RunPreTriggerEvent(Trigger trigger) => (Object) trigger.entity == (Object) this.target && trigger.type != "haze";

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
