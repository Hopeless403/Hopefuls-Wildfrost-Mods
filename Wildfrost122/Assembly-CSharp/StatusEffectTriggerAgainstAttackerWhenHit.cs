// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerAgainstAttackerWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Reactions/Trigger Against Attacker When Hit", fileName = "Trigger Against Attacker When Hit")]
public class StatusEffectTriggerAgainstAttackerWhenHit : StatusEffectReaction
{
  private Entity attacker;
  private Entity previousTarget;
  private int? effectiveHealthState;

  public override bool RunTurnEndEvent(Entity entity)
  {
    if (this.effectiveHealthState.HasValue && (Object) entity == (Object) this.target)
    {
      this.previousTarget = (Entity) null;
      this.effectiveHealthState = new int?();
    }
    return false;
  }

  public override bool RunHitEvent(Hit hit)
  {
    if ((Object) hit.target == (Object) this.target && hit.canRetaliate && !(bool) (Object) this.attacker && hit.Offensive && hit.BasicHit && (bool) (Object) hit.target && (bool) (Object) hit.attacker)
    {
      Trigger trigger = hit.trigger;
      if (trigger != null && trigger.countsAsTrigger)
        this.attacker = hit.attacker;
    }
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if ((bool) (Object) this.attacker && (Object) entity == (Object) this.attacker)
    {
      this.attacker = (Entity) null;
      if (Battle.IsOnBoard(this.target) && this.CanTrigger())
        this.Run(entity);
    }
    return false;
  }

  private void Run(Entity entity)
  {
    if (!(bool) (Object) entity.data || !entity.data.cardType.unit)
    {
      Entity entity1 = entity.owner?.entity;
      if ((bool) (Object) entity1 && entity1.canBeHit)
      {
        entity = entity.owner?.entity;
        if ((Object) entity == (Object) this.target.owner?.entity)
          entity = (Entity) null;
      }
    }
    if (!(bool) (Object) entity || !entity.canBeHit || !entity.IsAliveAndExists())
      return;
    int effectiveHealthState = StatusEffectTriggerAgainstAttackerWhenHit.CalculateEffectiveHealthState();
    if (this.effectiveHealthState.HasValue && (bool) (Object) this.previousTarget && (Object) this.previousTarget == (Object) entity && effectiveHealthState == this.effectiveHealthState.Value)
    {
      Debug.LogWarning((object) "Smackback infinite loop detected!");
    }
    else
    {
      this.previousTarget = entity;
      this.effectiveHealthState = new int?(effectiveHealthState);
      CardContainer targetRow = Trigger.GetTargetRow(this.target, entity);
      ActionTriggerSubsequent action = new ActionTriggerSubsequent(this.target, entity, entity, targetRow);
      action.triggerType = "smackback";
      ActionQueue.Stack((PlayAction) action, true);
    }
  }

  private static int CalculateEffectiveHealthState()
  {
    int effectiveHealthState = 0;
    foreach (Entity entity in Battle.GetCardsOnBoard())
      effectiveHealthState += StatusEffectTriggerAgainstAttackerWhenHit.GetEffectiveHealth(entity);
    return effectiveHealthState;
  }

  private static int GetEffectiveHealth(Entity entity)
  {
    int current = entity.hp.current;
    foreach (StatusEffectData statusEffect in entity.statusEffects)
    {
      switch (statusEffect.type)
      {
        case "shell":
        case "scrap":
        case "block":
          current += statusEffect.count;
          continue;
        case "overload":
          current -= statusEffect.count;
          continue;
        case "shroom":
          current -= Mathf.Min(statusEffect.count, entity.hp.current);
          continue;
        default:
          continue;
      }
    }
    return current;
  }
}
