// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerWhenAllyAttacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Reactions/Trigger When Ally In Row Attacks", fileName = "Trigger When Ally In Row Attacks")]
public class StatusEffectTriggerWhenAllyAttacks : StatusEffectReaction
{
  [SerializeField]
  private bool allyInRow = true;
  [SerializeField]
  private bool againstTarget;
  private readonly HashSet<Entity> prime = new HashSet<Entity>();

  public override bool RunHitEvent(Hit hit)
  {
    if (this.target.enabled && Battle.IsOnBoard(this.target) && hit.countsAsHit && hit.Offensive && (bool) (Object) hit.target && hit.trigger != null && this.CheckEntity(hit.attacker))
      this.prime.Add(hit.attacker);
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (this.prime.Count > 0 && this.prime.Contains(entity) && targets != null && targets.Length > 0)
    {
      this.prime.Remove(entity);
      if (Battle.IsOnBoard(this.target) && this.CanTrigger())
        this.Run(entity, targets);
    }
    return false;
  }

  private void Run(Entity attacker, Entity[] targets)
  {
    if (this.againstTarget)
    {
      foreach (Entity target in targets)
        ActionQueue.Stack((PlayAction) new ActionTriggerAgainst(this.target, attacker, target, (CardContainer) null), true);
    }
    else
      ActionQueue.Stack((PlayAction) new ActionTrigger(this.target, attacker), true);
  }

  private bool CheckEntity(Entity entity)
  {
    return (bool) (Object) entity && entity.owner.team == this.target.owner.team && (Object) entity != (Object) this.target && this.CheckRow(entity) && Battle.IsOnBoard(entity) && this.CheckDuplicate(entity) && this.CheckDuplicate(entity.triggeredBy);
  }

  private bool CheckRow(Entity entity)
  {
    return !this.allyInRow || ((IList<CardContainer>) entity.containers).ContainsAny<CardContainer>((IEnumerable<CardContainer>) this.target.containers);
  }

  private bool CheckDuplicate(Entity entity)
  {
    if (!entity.IsAliveAndExists())
      return true;
    foreach (Object statusEffect in entity.statusEffects)
    {
      if (statusEffect.name == this.name)
        return false;
    }
    return true;
  }
}
