// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenEnemiesAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Enemies Attack", fileName = "Apply X When Enemies Attack")]
public class StatusEffectApplyXWhenEnemiesAttack : StatusEffectApplyX
{
  private Entity attacker;

  protected override void Init() => this.PreAttack += new StatusEffectData.EffectHitEventHandler(this.HitCheck);

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (this.target.enabled && this.target.alive && (Object) entity.owner != (Object) this.target.owner && Battle.IsOnBoard(this.target))
      this.attacker = entity;
    return false;
  }

  public override bool RunPreAttackEvent(Hit hit) => (Object) this.attacker != (Object) null && (Object) hit.attacker == (Object) this.attacker && this.target.enabled && this.target.alive && hit.Offensive && Battle.IsOnBoard(this.target);

  private IEnumerator HitCheck(Hit hit)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectApplyXWhenEnemiesAttack xwhenEnemiesAttack = this;
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
    xwhenEnemiesAttack.attacker = (Entity) null;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) xwhenEnemiesAttack.Run(xwhenEnemiesAttack.GetTargets(hit));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
