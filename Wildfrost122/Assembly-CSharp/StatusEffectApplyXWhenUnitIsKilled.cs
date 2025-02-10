// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenUnitIsKilled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Unit Is Killed", fileName = "Apply X When Unit Is Killed")]
public class StatusEffectApplyXWhenUnitIsKilled : StatusEffectApplyX
{
  [SerializeField]
  private bool ally = true;
  [SerializeField]
  private bool enemy;
  [SerializeField]
  private bool sacrificed;
  [SerializeField]
  private TargetConstraint[] unitConstraints;

  protected override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !this.CheckTeam(entity) || !Battle.IsOnBoard(entity) || !Battle.IsOnBoard(this.target) || !this.CheckUnitConstraints(entity))
      return false;
    return !this.sacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  private IEnumerator Check(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenUnitIsKilled xwhenUnitIsKilled = this;
    if (entity.LastHitStillProcessing())
      yield return (object) entity.WaitForLastHitToFinishProcessing();
    if (xwhenUnitIsKilled.CheckUnitConstraints(entity))
    {
      if ((bool) (UnityEngine.Object) xwhenUnitIsKilled.contextEqualAmount)
      {
        int amount = xwhenUnitIsKilled.contextEqualAmount.Get(entity);
        yield return (object) xwhenUnitIsKilled.Run(xwhenUnitIsKilled.GetTargets(entity.lastHit), amount);
      }
      else
        yield return (object) xwhenUnitIsKilled.Run(xwhenUnitIsKilled.GetTargets(entity.lastHit));
    }
  }

  private bool CheckTeam(Entity entity)
  {
    return !DeathSystem.CheckTeamIsAlly(entity, this.target) ? this.enemy : this.ally;
  }

  private bool CheckUnitConstraints(Entity entity)
  {
    return this.unitConstraints == null || ((IEnumerable<TargetConstraint>) this.unitConstraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(entity)));
  }
}
