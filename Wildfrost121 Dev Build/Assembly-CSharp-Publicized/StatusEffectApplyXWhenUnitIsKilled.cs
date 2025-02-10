// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenUnitIsKilled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public bool ally = true;
  [SerializeField]
  public bool enemy;
  [SerializeField]
  public bool sacrificed;
  [SerializeField]
  public TargetConstraint[] unitConstraints;

  public override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !this.CheckTeam(entity) || !Battle.IsOnBoard(entity) || !Battle.IsOnBoard(this.target) || !this.CheckConstraints(entity))
      return false;
    return !this.sacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  public IEnumerator Check(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenUnitIsKilled xwhenUnitIsKilled = this;
    if ((bool) (UnityEngine.Object) xwhenUnitIsKilled.contextEqualAmount)
    {
      int amount = xwhenUnitIsKilled.contextEqualAmount.Get(entity);
      yield return (object) xwhenUnitIsKilled.Run(xwhenUnitIsKilled.GetTargets(entity.lastHit), amount);
    }
    else
      yield return (object) xwhenUnitIsKilled.Run(xwhenUnitIsKilled.GetTargets(entity.lastHit));
  }

  public bool CheckTeam(Entity entity)
  {
    return !DeathSystem.CheckTeamIsAlly(entity, this.target) ? this.enemy : this.ally;
  }

  public new bool CheckConstraints(Entity entity)
  {
    return this.unitConstraints == null || ((IEnumerable<TargetConstraint>) this.unitConstraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(entity)));
  }
}
