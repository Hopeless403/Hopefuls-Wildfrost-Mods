// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenCardDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Card Destroyed", fileName = "Apply X When Card Destroyed")]
public class StatusEffectApplyXWhenCardDestroyed : StatusEffectApplyX
{
  [SerializeField]
  public bool canBeAlly = true;
  [SerializeField]
  public bool canBeEnemy = true;
  [SerializeField]
  public bool mustBeSacrificed;
  [SerializeField]
  public bool mustBeOnBoard = true;
  [SerializeField]
  public TargetConstraint[] constraints;

  public override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !this.CheckTeam(entity) || !Battle.IsOnBoard(this.target) || this.mustBeOnBoard && !Battle.IsOnBoard(entity) || !this.CheckConstraints(entity))
      return false;
    return !this.mustBeSacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  public IEnumerator Check(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenCardDestroyed xwhenCardDestroyed = this;
    if ((bool) (UnityEngine.Object) xwhenCardDestroyed.contextEqualAmount)
    {
      int amount = xwhenCardDestroyed.contextEqualAmount.Get(entity);
      yield return (object) xwhenCardDestroyed.Run(xwhenCardDestroyed.GetTargets(entity.lastHit), amount);
    }
    else
      yield return (object) xwhenCardDestroyed.Run(xwhenCardDestroyed.GetTargets(entity.lastHit));
  }

  public bool CheckTeam(Entity entity)
  {
    if ((UnityEngine.Object) this.target.owner == (UnityEngine.Object) entity.owner)
      return this.canBeAlly;
    return (UnityEngine.Object) this.target.owner != (UnityEngine.Object) entity.owner && this.canBeEnemy;
  }

  public new bool CheckConstraints(Entity entity) => this.constraints == null || ((IEnumerable<TargetConstraint>) this.constraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(entity)));
}
