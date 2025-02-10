// Decompiled with JetBrains decompiler
// Type: StatusEffectLastStand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Misc/Last Stand", fileName = "Last Stand")]
public class StatusEffectLastStand : StatusEffectData
{
  public bool activated;

  public override bool RunPostHitEvent(Hit hit)
  {
    if (!this.activated && (Object) hit.target == (Object) this.target && this.target.hp.current <= 0 && hit.attacker.owner.team != this.target.owner.team && Battle.IsOnBoard(hit.attacker))
      this.Activate(hit);
    return false;
  }

  public void Activate(Hit hit)
  {
    LastStandSystem.target = this;
    LastStandSystem.subject = this.target;
    LastStandSystem.attacker = hit.attacker;
    LastStandSystem.previousPhase = References.Battle.phase;
    this.Disable();
    References.Battle.phase = Battle.Phase.LastStand;
  }

  public void Disable() => this.activated = true;

  public void ReEnable()
  {
    this.target.hp.current = 1;
    this.target.PromptUpdate();
    this.activated = false;
    this.preventDeath = true;
  }
}
