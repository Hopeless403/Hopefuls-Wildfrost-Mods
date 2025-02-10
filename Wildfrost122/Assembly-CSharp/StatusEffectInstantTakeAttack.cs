// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTakeAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Take Attack", fileName = "Take Attack")]
public class StatusEffectInstantTakeAttack : StatusEffectInstant
{
  [SerializeField]
  private StatusEffectData increaseAttackEffect;

  protected override IEnumerator Process()
  {
    StatusEffectInstantTakeAttack instantTakeAttack = this;
    int amount = instantTakeAttack.GetAmount();
    instantTakeAttack.target.damage.max -= amount;
    instantTakeAttack.target.damage.current -= amount;
    instantTakeAttack.target.PromptUpdate();
    Hit hit = new Hit(instantTakeAttack.target, instantTakeAttack.applier, 0)
    {
      canRetaliate = false,
      countsAsHit = false
    };
    hit.AddStatusEffect(instantTakeAttack.increaseAttackEffect, amount);
    yield return (object) hit.Process();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantTakeAttack.\u003C\u003En__0();
  }
}
