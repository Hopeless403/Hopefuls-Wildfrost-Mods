// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenAllyIsHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Ally Is Hit", fileName = "Apply X When Ally Is Hit")]
public class StatusEffectApplyXWhenAllyIsHit : StatusEffectApplyX
{
  [SerializeField]
  public bool includeSelf;

  public override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && (this.includeSelf || (Object) hit.target != (Object) this.target) && hit.canRetaliate && (Object) hit.target.owner == (Object) this.target.owner && hit.Offensive && hit.BasicHit && Battle.IsOnBoard(this.target) && Battle.IsOnBoard(hit.target);
  }

  public IEnumerator Check(Hit hit) => this.Run(this.GetTargets(hit));
}
