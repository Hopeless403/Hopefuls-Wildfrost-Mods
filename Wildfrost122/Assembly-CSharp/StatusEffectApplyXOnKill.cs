// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Kill", fileName = "Apply X On Kill")]
public class StatusEffectApplyXOnKill : StatusEffectApplyX
{
  protected override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return entity.lastHit != null && (Object) entity.lastHit.attacker == (Object) this.target;
  }

  private IEnumerator CheckDestroy(Entity entity, DeathType deathType)
  {
    return this.Run(this.GetTargets(entity.lastHit));
  }
}
