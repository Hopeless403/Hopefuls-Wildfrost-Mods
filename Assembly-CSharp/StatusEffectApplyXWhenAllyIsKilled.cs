// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyIsKilled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Killed", fileName = "Apply X When Ally Is Killed")]
public class StatusEffectApplyXWhenAllyIsKilled : StatusEffectApplyX
{
  [SerializeField]
  private bool sacrificed;

  protected override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (!this.target.enabled || !this.target.alive || !((Object) this.target.owner == (Object) entity.owner) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(entity))
      return false;
    return !this.sacrificed || DeathSystem.KilledByOwnTeam(entity);
  }

  private IEnumerator Check(Entity entity, DeathType deathType)
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
