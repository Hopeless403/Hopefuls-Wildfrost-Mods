// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Destroyed", fileName = "Apply X When Destroyed")]
public class StatusEffectApplyXWhenDestroyed : StatusEffectApplyX
{
  [SerializeField]
  private bool sacrificed;
  [SerializeField]
  private bool consumed;

  protected override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => (Object) entity == (Object) this.target && this.CheckDeathType(deathType);

  private IEnumerator CheckDestroy(Entity entity, DeathType deathType)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectApplyXWhenDestroyed applyXwhenDestroyed = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) applyXwhenDestroyed.Run(applyXwhenDestroyed.GetTargets(wasInRows: applyXwhenDestroyed.GetTargetContainers(), wasInSlots: applyXwhenDestroyed.GetTargetActualContainers()));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  private bool CheckDeathType(DeathType deathType) => (!this.consumed || deathType == DeathType.Consume) && (!this.sacrificed || DeathSystem.KilledByOwnTeam(this.target));
}
