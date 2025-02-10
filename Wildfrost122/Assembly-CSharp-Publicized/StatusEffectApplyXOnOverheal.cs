// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnOverheal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Overheal", fileName = "Apply X On Overheal")]
public class StatusEffectApplyXOnOverheal : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
  }

  public override bool RunHitEvent(Hit hit)
  {
    return (Object) hit.target == (Object) this.target && hit.damage < 0 && this.target.hp.current - hit.damage - this.target.hp.max > 0;
  }

  public IEnumerator Check(Hit hit)
  {
    return this.Run(this.GetTargets(hit), this.target.hp.current - hit.damage - this.target.hp.max);
  }
}
