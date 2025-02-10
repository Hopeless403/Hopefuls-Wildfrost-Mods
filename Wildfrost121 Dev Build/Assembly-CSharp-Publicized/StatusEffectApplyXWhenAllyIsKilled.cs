// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyIsKilled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Killed", fileName = "Apply X When Ally Is Killed")]
public class StatusEffectApplyXWhenAllyIsKilled : StatusEffectApplyX
{
  [SerializeField]
  public bool sacrificed;

  public override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !DeathSystem.CheckTeamIsAlly(entity, this.target) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(entity))
      return false;
    return !this.sacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  public IEnumerator Check(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenAllyIsKilled xwhenAllyIsKilled = this;
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
