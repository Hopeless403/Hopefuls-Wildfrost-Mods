// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAlliesAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Allies Attack", fileName = "Apply X When Allies Attack")]
public class StatusEffectApplyXWhenAlliesAttack : StatusEffectApplyX
{
  public override void Init()
  {
    this.PreAttack += new StatusEffectData.EffectHitEventHandler(this.HitCheck);
  }

  public override bool RunPreAttackEvent(Hit hit)
  {
    return this.target.enabled && this.target.alive && (Object) hit.attacker.owner == (Object) this.target.owner && (Object) hit.attacker != (Object) this.target && hit.Offensive;
  }

  public IEnumerator HitCheck(Hit hit) => this.Run(this.GetTargets(hit));
}
