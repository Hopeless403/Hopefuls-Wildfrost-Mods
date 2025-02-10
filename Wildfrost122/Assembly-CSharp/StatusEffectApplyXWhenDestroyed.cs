// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Destroyed", fileName = "Apply X When Destroyed")]
public class StatusEffectApplyXWhenDestroyed : StatusEffectApplyX
{
  [SerializeField]
  private bool sacrificed;
  [SerializeField]
  private bool consumed;

  protected override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return (Object) entity == (Object) this.target && this.CheckDeathType(deathType);
  }

  private IEnumerator CheckDestroy(Entity entity, DeathType deathType)
  {
    StatusEffectApplyXWhenDestroyed applyXwhenDestroyed = this;
    if (entity.LastHitStillProcessing())
      yield return (object) entity.WaitForLastHitToFinishProcessing();
    yield return (object) applyXwhenDestroyed.Run(applyXwhenDestroyed.GetTargets(wasInRows: applyXwhenDestroyed.GetTargetContainers(), wasInSlots: applyXwhenDestroyed.GetTargetActualContainers()));
  }

  private bool CheckDeathType(DeathType deathType)
  {
    return (!this.consumed || deathType == DeathType.Consume) && (!this.sacrificed || DeathSystem.KilledByOwnTeam(this.target));
  }
}
