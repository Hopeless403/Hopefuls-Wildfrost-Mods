// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXPostAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X Post Attack", fileName = "Apply X Post Attack")]
public class StatusEffectApplyXPostAttack : StatusEffectApplyX
{
  public override void Init()
  {
    this.PostAttack += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
  }

  public override bool RunPostAttackEvent(Hit hit)
  {
    return this.target.enabled && (Object) hit.attacker == (Object) this.target && this.target.alive && Battle.IsOnBoard(this.target);
  }

  public IEnumerator CheckHit(Hit hit)
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
