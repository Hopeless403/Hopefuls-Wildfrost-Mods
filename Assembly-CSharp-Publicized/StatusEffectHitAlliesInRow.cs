// Decompiled with JetBrains decompiler
// Type: StatusEffectHitAlliesInRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Hit Allies In Row", fileName = "Hit Allies In Row")]
public class StatusEffectHitAlliesInRow : StatusEffectData
{
  public override void Init() => this.PostAttack += new StatusEffectData.EffectHitEventHandler(this.CheckHit);

  public override bool RunPostAttackEvent(Hit hit) => (Object) hit.attacker == (Object) this.target && (Object) hit.target != (Object) null;

  public IEnumerator CheckHit(Hit hit)
  {
    StatusEffectHitAlliesInRow effectHitAlliesInRow = this;
    foreach (Entity target in hit.target.GetAlliesInRow())
      yield return (object) new Hit(effectHitAlliesInRow.target, target, effectHitAlliesInRow.GetAmount()).Process();
  }
}
