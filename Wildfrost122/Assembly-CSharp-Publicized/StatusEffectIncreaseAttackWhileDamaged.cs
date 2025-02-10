// Decompiled with JetBrains decompiler
// Type: StatusEffectIncreaseAttackWhileDamaged
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Increase Attack While Damaged", fileName = "Increase Attack While Damaged")]
public class StatusEffectIncreaseAttackWhileDamaged : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToGain;
  public int currentAmount;
  public bool active;

  public override bool RunEnableEvent(Entity entity) => (Object) entity == (Object) this.target;

  public override bool HasEnableRoutine => true;

  public override IEnumerator EnableRoutine(Entity entity) => this.Check();

  public override bool RunDisableEvent(Entity entity)
  {
    return (Object) entity == (Object) this.target && this.currentAmount != 0;
  }

  public override bool HasDisableRoutine => true;

  public override IEnumerator DisableRoutine(Entity entity) => this.Deactivate();

  public override bool RunPostHitEvent(Hit hit) => (Object) hit.target == (Object) this.target;

  public override bool HasPostHitRoutine => true;

  public override IEnumerator PostHitRoutine(Hit hit) => this.Check();

  public IEnumerator Check()
  {
    StatusEffectIncreaseAttackWhileDamaged attackWhileDamaged = this;
    if (attackWhileDamaged.target.alive)
    {
      if (!attackWhileDamaged.active)
      {
        if (attackWhileDamaged.target.hp.current < attackWhileDamaged.target.hp.max)
          yield return (object) attackWhileDamaged.Activate();
      }
      else if (attackWhileDamaged.target.hp.current >= attackWhileDamaged.target.hp.max)
        yield return (object) attackWhileDamaged.Deactivate();
    }
  }

  public IEnumerator Activate()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectIncreaseAttackWhileDamaged attackWhileDamaged = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      attackWhileDamaged.active = true;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    attackWhileDamaged.currentAmount = attackWhileDamaged.GetAmount();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) StatusEffectSystem.Apply(attackWhileDamaged.target, attackWhileDamaged.target, attackWhileDamaged.effectToGain, attackWhileDamaged.currentAmount, true);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public IEnumerator Deactivate()
  {
    StatusEffectIncreaseAttackWhileDamaged attackWhileDamaged = this;
    for (int index = attackWhileDamaged.target.statusEffects.Count - 1; index >= 0; --index)
    {
      StatusEffectData statusEffect = attackWhileDamaged.target.statusEffects[index];
      if ((bool) (Object) statusEffect && statusEffect.name == attackWhileDamaged.effectToGain.name)
      {
        yield return (object) statusEffect.RemoveStacks(attackWhileDamaged.currentAmount, true);
        break;
      }
    }
    attackWhileDamaged.currentAmount = 0;
    attackWhileDamaged.active = false;
  }

  public override bool RunEffectBonusChangedEvent()
  {
    if (this.target.enabled && this.active)
      ActionQueue.Add((PlayAction) new ActionSequence(this.ReAffect()));
    return false;
  }

  public IEnumerator ReAffect()
  {
    yield return (object) this.Deactivate();
    yield return (object) this.Activate();
  }
}
