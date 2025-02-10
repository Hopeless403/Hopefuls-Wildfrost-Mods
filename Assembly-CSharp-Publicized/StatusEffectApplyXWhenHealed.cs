// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHealed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Healed", fileName = "Apply X When Healed")]
public class StatusEffectApplyXWhenHealed : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
    this.OnApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.CheckStatus);
  }

  public override bool RunHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.damage < 0;

  public IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit), -hit.damage);

  public override bool RunApplyStatusEvent(StatusEffectApply apply) => (Object) apply.target == (Object) this.target && apply.effectData.type == "max health up";

  public IEnumerator CheckStatus(StatusEffectApply apply) => this.Run(this.GetTargets(targets: new Entity[1]
  {
    apply.target
  }), apply.count);
}
