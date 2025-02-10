// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Destroyed", fileName = "Apply X When Destroyed")]
public class StatusEffectApplyXWhenDestroyed : StatusEffectApplyX
{
  [SerializeField]
  public bool sacrificed;
  [SerializeField]
  public bool consumed;

  public override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return (Object) entity == (Object) this.target && this.CheckDeathType(deathType);
  }

  public IEnumerator CheckDestroy(Entity entity, DeathType deathType)
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

  public bool CheckDeathType(DeathType deathType)
  {
    return (!this.consumed || deathType == DeathType.Consume) && (!this.sacrificed || DeathSystem.KilledByOwnTeam(this.target));
  }
}
