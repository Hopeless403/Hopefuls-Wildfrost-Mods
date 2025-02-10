// Decompiled with JetBrains decompiler
// Type: StatusEffectHitAlliesInRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Hit Allies In Row", fileName = "Hit Allies In Row")]
public class StatusEffectHitAlliesInRow : StatusEffectData
{
  protected override void Init() => this.PostAttack += new StatusEffectData.EffectHitEventHandler(this.CheckHit);

  public override bool RunPostAttackEvent(Hit hit) => (Object) hit.attacker == (Object) this.target && (Object) hit.target != (Object) null;

  private IEnumerator CheckHit(Hit hit)
  {
    StatusEffectHitAlliesInRow effectHitAlliesInRow = this;
    foreach (Entity target in hit.target.GetAlliesInRow())
      yield return (object) new Hit(effectHitAlliesInRow.target, target, effectHitAlliesInRow.GetAmount()).Process();
  }
}
