// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantActivateSacrificeEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Activate Sacrifice Effects", fileName = "Activate Sacrifice Effects")]
public class StatusEffectInstantActivateSacrificeEffects : StatusEffectInstant
{
  [SerializeField]
  public bool forOtherTeam;

  public override IEnumerator Process()
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
    yield return (object) sacrificeEffects.\u003C\u003En__0();
  }

  public void MakeLastHitSacrifice()
  {
    this.target.lastHit = new Hit(this.target, this.target, 1)
    {
      attacker = (Entity) null
    };
  }

  public void TriggerSacrificeVFX()
  {
    Object.FindObjectOfType<VfxDeathSystem>()?.EntityKilled(this.target, DeathType.Normal);
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
