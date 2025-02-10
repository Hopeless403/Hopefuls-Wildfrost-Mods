// Decompiled with JetBrains decompiler
// Type: StatusEffectWeakness
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Weakness", fileName = "Weakness")]
public class StatusEffectWeakness : StatusEffectData
{
  protected override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Hit);
  }

  public override bool RunHitEvent(global::Hit hit)
  {
    return hit.Offensive && this.count > 0 && (Object) hit.target == (Object) this.target;
  }

  private IEnumerator Hit(global::Hit hit)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectWeakness statusEffectWeakness = this;
    if (num != 0)
      return false;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    hit.damage += statusEffectWeakness.count;
    return false;
  }
}
