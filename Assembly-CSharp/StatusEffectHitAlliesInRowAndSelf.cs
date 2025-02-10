// Decompiled with JetBrains decompiler
// Type: StatusEffectHitAlliesInRowAndSelf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Hit Allies In Row And Self", fileName = "Hit Allies In Row And Self")]
public class StatusEffectHitAlliesInRowAndSelf : StatusEffectData
{
  protected override void Init() => this.PostAttack += new StatusEffectData.EffectHitEventHandler(this.CheckHit);

  public override bool RunPostAttackEvent(Hit hit) => (Object) hit.attacker == (Object) this.target;

  private IEnumerator CheckHit(Hit hit)
  {
    StatusEffectHitAlliesInRowAndSelf alliesInRowAndSelf = this;
    foreach (Entity target in alliesInRowAndSelf.target.GetAlliesInRow())
    {
      Hit hit1 = new Hit(alliesInRowAndSelf.target, target);
      hit1.AddAttackerStatuses();
      yield return (object) hit1.Process();
    }
    Hit hit2 = new Hit(alliesInRowAndSelf.target, alliesInRowAndSelf.target)
    {
      doAnimation = false
    };
    hit2.AddAttackerStatuses();
    yield return (object) hit2.Process();
  }
}
