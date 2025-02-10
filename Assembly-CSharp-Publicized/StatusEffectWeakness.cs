// Decompiled with JetBrains decompiler
// Type: StatusEffectWeakness
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Weakness", fileName = "Weakness")]
public class StatusEffectWeakness : StatusEffectData
{
  public override void Init() => this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Hit);

  public override bool RunHitEvent(global::Hit hit) => hit.Offensive && this.count > 0 && (Object) hit.target == (Object) this.target;

  public IEnumerator Hit(global::Hit hit)
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
