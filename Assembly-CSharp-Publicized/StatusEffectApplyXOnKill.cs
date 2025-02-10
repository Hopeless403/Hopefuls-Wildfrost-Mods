// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Kill", fileName = "Apply X On Kill")]
public class StatusEffectApplyXOnKill : StatusEffectApplyX
{
  public override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.CheckDestroy);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => entity.lastHit != null && (Object) entity.lastHit.attacker == (Object) this.target;

  public IEnumerator CheckDestroy(Entity entity, DeathType deathType) => this.Run(this.GetTargets(entity.lastHit));
}
