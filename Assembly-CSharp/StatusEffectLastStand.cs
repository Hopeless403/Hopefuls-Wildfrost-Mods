// Decompiled with JetBrains decompiler
// Type: StatusEffectLastStand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Misc/Last Stand", fileName = "Last Stand")]
public class StatusEffectLastStand : StatusEffectData
{
  private bool activated;

  public override bool RunPostHitEvent(Hit hit)
  {
    if (!this.activated && (Object) hit.target == (Object) this.target && this.target.hp.current <= 0 && hit.attacker.owner.team != this.target.owner.team && Battle.IsOnBoard(hit.attacker))
      this.Activate(hit);
    return false;
  }

  private void Activate(Hit hit)
  {
    LastStandSystem.target = this;
    LastStandSystem.subject = this.target;
    LastStandSystem.attacker = hit.attacker;
    LastStandSystem.previousPhase = References.Battle.phase;
    this.Disable();
    References.Battle.phase = Battle.Phase.LastStand;
  }

  private void Disable() => this.activated = true;

  public void ReEnable()
  {
    this.target.hp.current = 1;
    this.target.PromptUpdate();
    this.activated = false;
    this.preventDeath = true;
  }
}
