// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnOverheal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Overheal", fileName = "Apply X On Overheal")]
public class StatusEffectApplyXOnOverheal : StatusEffectApplyX
{
  protected override void Init() => this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);

  public override bool RunHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.damage < 0 && this.target.hp.current - hit.damage - this.target.hp.max > 0;

  private IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit), this.target.hp.current - hit.damage - this.target.hp.max);
}
