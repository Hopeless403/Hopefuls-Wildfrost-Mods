﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXPostAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X Post Attack", fileName = "Apply X Post Attack")]
public class StatusEffectApplyXPostAttack : StatusEffectApplyX
{
  protected override void Init() => this.PostAttack += new StatusEffectData.EffectHitEventHandler(this.CheckHit);

  public override bool RunPostAttackEvent(Hit hit) => this.target.enabled && (Object) hit.attacker == (Object) this.target && this.target.alive && Battle.IsOnBoard(this.target);

  private IEnumerator CheckHit(Hit hit)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectApplyXPostAttack applyXpostAttack = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) applyXpostAttack.Run(applyXpostAttack.GetTargets(hit));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
