// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyIsKilled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Killed", fileName = "Apply X When Ally Is Killed")]
public class StatusEffectApplyXWhenAllyIsKilled : StatusEffectApplyX
{
  [SerializeField]
  private bool sacrificed;

  protected override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !DeathSystem.CheckTeamIsAlly(entity, this.target) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(entity))
      return false;
    return !this.sacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  private IEnumerator Check(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenAllyIsKilled xwhenAllyIsKilled = this;
    if (entity.LastHitStillProcessing())
      yield return (object) entity.WaitForLastHitToFinishProcessing();
    if ((bool) (Object) xwhenAllyIsKilled.contextEqualAmount)
    {
      int amount = xwhenAllyIsKilled.contextEqualAmount.Get(entity);
      yield return (object) xwhenAllyIsKilled.Run(xwhenAllyIsKilled.GetTargets(targets: new Entity[1]
      {
        entity
      }), amount);
    }
    else
      yield return (object) xwhenAllyIsKilled.Run(xwhenAllyIsKilled.GetTargets(targets: new Entity[1]
      {
        entity
      }));
  }
}
