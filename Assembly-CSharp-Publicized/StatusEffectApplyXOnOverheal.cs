// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnOverheal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Overheal", fileName = "Apply X On Overheal")]
public class StatusEffectApplyXOnOverheal : StatusEffectApplyX
{
  public override void Init() => this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);

  public override bool RunHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.damage < 0 && this.target.hp.current - hit.damage - this.target.hp.max > 0;

  public IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit), this.target.hp.current - hit.damage - this.target.hp.max);
}
