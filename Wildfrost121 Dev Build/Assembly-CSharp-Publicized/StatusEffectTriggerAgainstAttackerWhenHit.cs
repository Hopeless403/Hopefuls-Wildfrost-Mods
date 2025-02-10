// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerAgainstAttackerWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Reactions/Trigger Against Attacker When Hit", fileName = "Trigger Against Attacker When Hit")]
public class StatusEffectTriggerAgainstAttackerWhenHit : StatusEffectReaction
{
  public Entity attacker;
  public Entity previousTarget;
  public int? effectiveHealthState;

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

  public void Run(Entity entity)
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

  public static int CalculateEffectiveHealthState()
  {
    int effectiveHealthState = 0;
    foreach (Entity entity in Battle.GetCardsOnBoard())
      effectiveHealthState += StatusEffectTriggerAgainstAttackerWhenHit.GetEffectiveHealth(entity);
    return effectiveHealthState;
  }

  public static int GetEffectiveHealth(Entity entity)
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
