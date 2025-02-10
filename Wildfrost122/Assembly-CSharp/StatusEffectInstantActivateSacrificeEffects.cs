// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantActivateSacrificeEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Activate Sacrifice Effects", fileName = "Activate Sacrifice Effects")]
public class StatusEffectInstantActivateSacrificeEffects : StatusEffectInstant
{
  [SerializeField]
  private bool forOtherTeam;

  protected override IEnumerator Process()
  {
    StatusEffectInstantActivateSacrificeEffects sacrificeEffects = this;
    if (!DeathSystem.KilledByOwnTeam(sacrificeEffects.target))
    {
      if (sacrificeEffects.forOtherTeam)
      {
        DeathSystem.TreatAsTeam(sacrificeEffects.target.data.id, Battle.GetOpponent(sacrificeEffects.target.owner).team);
        sacrificeEffects.target.lastHit.owner = Battle.GetOpponent(sacrificeEffects.target.lastHit.owner);
      }
      else
        sacrificeEffects.MakeLastHitSacrifice();
      sacrificeEffects.TriggerSacrificeVFX();
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) sacrificeEffects.\u003C\u003En__0();
  }

  private void MakeLastHitSacrifice()
  {
    this.target.lastHit = new Hit(this.target, this.target, 1)
    {
      attacker = (Entity) null
    };
  }

  private void TriggerSacrificeVFX()
  {
    Object.FindObjectOfType<VfxDeathSystem>()?.EntityKilled(this.target, DeathType.Normal);
  }
}
