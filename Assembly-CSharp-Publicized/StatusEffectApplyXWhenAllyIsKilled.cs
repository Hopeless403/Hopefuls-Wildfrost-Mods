// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyIsKilled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Killed", fileName = "Apply X When Ally Is Killed")]
public class StatusEffectApplyXWhenAllyIsKilled : StatusEffectApplyX
{
  [SerializeField]
  public bool sacrificed;

  public override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !((Object) this.target.owner == (Object) entity.owner) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(entity))
      return false;
    return !this.sacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  public IEnumerator Check(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenAllyIsKilled xwhenAllyIsKilled = this;
    if ((bool) (Object) xwhenAllyIsKilled.contextEqualAmount)
    {
      int amount = xwhenAllyIsKilled.contextEqualAmount.Get(entity);
      yield return (object) xwhenAllyIsKilled.Run(xwhenAllyIsKilled.GetTargets(), amount);
    }
    else
      yield return (object) xwhenAllyIsKilled.Run(xwhenAllyIsKilled.GetTargets());
  }
}
