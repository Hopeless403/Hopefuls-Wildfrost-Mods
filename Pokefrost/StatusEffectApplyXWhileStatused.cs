// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhileStatused
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhileStatused : StatusEffectData
  {
    [SerializeField]
    public StatusEffectData effectToGain;
    public int currentAmount;
    public bool active;

    public override bool HasEnableRoutine => true;

    public override bool HasDisableRoutine => true;

    public override bool HasPostHitRoutine => true;

    public override bool HasTurnEndRoutine => true;

    public override bool RunEnableEvent(Entity entity) => (Object) entity == (Object) this.target;

    public override IEnumerator EnableRoutine(Entity entity) => this.Check();

    public override bool RunDisableEvent(Entity entity)
    {
      return (Object) entity == (Object) this.target && this.currentAmount != 0;
    }

    public override IEnumerator DisableRoutine(Entity entity) => this.Deactivate();

    public override bool RunPostHitEvent(Hit hit) => (Object) hit.target == (Object) this.target;

    public override IEnumerator PostHitRoutine(Hit hit) => this.Check();

    public override IEnumerator TurnEndRoutine(Entity entity) => this.Check();

    public IEnumerator Check()
    {
      if (this.target.alive)
      {
        bool flag = false;
        for (int num = this.target.statusEffects.Count - 1; num >= 0; --num)
        {
          StatusEffectData statusEffectData = this.target.statusEffects[num];
          if (statusEffectData.isStatus && statusEffectData.offensive && statusEffectData.visible)
          {
            flag = true;
            if (!this.active)
            {
              yield return (object) this.Activate();
              break;
            }
            break;
          }
          statusEffectData = (StatusEffectData) null;
        }
        if (this.active && !flag)
          yield return (object) this.Deactivate();
      }
    }

    public IEnumerator Activate()
    {
      this.currentAmount = this.GetAmount();
      yield return (object) StatusEffectSystem.Apply(this.target, this.target, this.effectToGain, this.currentAmount, true);
      this.active = true;
    }

    public IEnumerator Deactivate()
    {
      for (int num = this.target.statusEffects.Count - 1; num >= 0; --num)
      {
        StatusEffectData statusEffectData = this.target.statusEffects[num];
        if ((bool) (Object) statusEffectData && statusEffectData.name == this.effectToGain.name)
        {
          yield return (object) statusEffectData.RemoveStacks(this.currentAmount, true);
          break;
        }
        statusEffectData = (StatusEffectData) null;
      }
      this.currentAmount = 0;
      this.active = false;
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
}
