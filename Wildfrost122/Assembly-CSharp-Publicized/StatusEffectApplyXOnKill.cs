// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Kill", fileName = "Apply X On Kill")]
public class StatusEffectApplyXOnKill : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return entity.lastHit != null && (Object) entity.lastHit.attacker == (Object) this.target;
  }

  public IEnumerator CheckDestroy(Entity entity, DeathType deathType)
  {
    return this.Run(this.GetTargets(entity.lastHit));
  }
}
