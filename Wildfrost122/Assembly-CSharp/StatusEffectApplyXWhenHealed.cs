// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHealed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Healed", fileName = "Apply X When Healed")]
public class StatusEffectApplyXWhenHealed : StatusEffectApplyX
{
  [SerializeField]
  private bool alsoWhenMaxHealthIncreased = true;

  protected override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    if (!this.alsoWhenMaxHealthIncreased)
      return;
    this.OnApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.CheckStatus);
  }

  public override bool RunHitEvent(Hit hit)
  {
    return (Object) hit.target == (Object) this.target && hit.damage < 0;
  }

  private IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit), -hit.damage);

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    return this.alsoWhenMaxHealthIncreased && (Object) apply.target == (Object) this.target && apply.effectData.type == "max health up";
  }

  private IEnumerator CheckStatus(StatusEffectApply apply)
  {
    return this.Run(this.GetTargets(targets: new Entity[1]
    {
      apply.target
    }), apply.count);
  }
}
