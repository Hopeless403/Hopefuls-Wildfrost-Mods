// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTakeHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Take Health", fileName = "Take Health")]
public class StatusEffectInstantTakeHealth : StatusEffectInstant
{
  [SerializeField]
  private StatusEffectData increaseHealthEffect;

  protected override IEnumerator Process()
  {
    StatusEffectInstantTakeHealth instantTakeHealth = this;
    int amount = instantTakeHealth.GetAmount();
    int count = Mathf.Min(instantTakeHealth.target.hp.current, amount);
    instantTakeHealth.target.hp.max -= amount;
    instantTakeHealth.target.hp.current -= amount;
    instantTakeHealth.target.PromptUpdate();
    Hit hit = new Hit(instantTakeHealth.target, instantTakeHealth.applier, 0)
    {
      canRetaliate = false,
      countsAsHit = false
    };
    hit.AddStatusEffect(instantTakeHealth.increaseHealthEffect, count);
    yield return (object) hit.Process();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantTakeHealth.\u003C\u003En__0();
  }
}
