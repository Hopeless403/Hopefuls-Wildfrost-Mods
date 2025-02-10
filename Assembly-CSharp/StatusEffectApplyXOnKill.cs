// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Kill", fileName = "Apply X On Kill")]
public class StatusEffectApplyXOnKill : StatusEffectApplyX
{
  protected override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => entity.lastHit != null && (Object) entity.lastHit.attacker == (Object) this.target;

  private IEnumerator CheckDestroy(Entity entity, DeathType deathType) => this.Run(this.GetTargets(entity.lastHit));
}
