using UnityEngine;
using System.Linq;
using System.Collections;
//using Effect_Randomiser
public class StatusEffectBonusDamageEqualToTargetConstraint : StatusEffectBonusDamageEqualToX
{
    public new bool health = false;
    public TargetConstraint[] unitConstraints;
    public override void Init()
    {
        this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);
    }

    public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
    {
        return (UnityEngine.Object)entity == (UnityEngine.Object)this.target && this.CanTrigger();
    }

    public new IEnumerator Gain(Entity entity, Entity[] targets)
    {
        int amount = this.Find();
        if (!this.toReset || amount != this.currentAmount)
        {
            if (this.toReset)
                this.LoseCurrentAmount();
            if (amount > 0)
                yield return this.GainAmount(amount);
        }
    }

    public new IEnumerator GainAmount(int amount)
    {
        StatusEffectBonusDamageEqualToX bonusDamageEqualToX = this;
        bonusDamageEqualToX.toReset = true;
        int num1 = bonusDamageEqualToX.target.tempDamage.Value;
        if (bonusDamageEqualToX.add)
            bonusDamageEqualToX.target.tempDamage += amount;
        else
            bonusDamageEqualToX.target.tempDamage.Value = amount;
        bonusDamageEqualToX.currentAmount = bonusDamageEqualToX.target.tempDamage.Value - num1;
        bonusDamageEqualToX.target.PromptUpdate();
        if (bonusDamageEqualToX.ping)
        {
            double num2 = (double)bonusDamageEqualToX.target.curveAnimator.Ping();
            yield return Sequences.Wait(0.5f);
        }
    }

    public override bool RunTurnEndEvent(Entity entity)
    {
        if ((UnityEngine.Object)entity == (UnityEngine.Object)this.target.owner.entity && this.toReset)
            this.LoseCurrentAmount();
        return false;
    }

    public new void LoseCurrentAmount()
    {
        this.toReset = false;
        if (this.currentAmount == 0)
            return;
        this.target.tempDamage -= this.currentAmount;
        this.currentAmount = 0;
        this.target.PromptUpdate();
    }
    public new int Find() => on switch
    {
        On.Self => FindOnSelf(),
        On.Board => FindOnBoard(),
        On.ScriptableAmount => scriptableAmount.Get(target),
        _ => 0
    };
    public new int FindOnBoard()
    {
        Debug.LogWarning(Battle.GetCardsOnBoard().Count(target => unitConstraints.All(t => t.Check(target))));
        return Battle.GetCardsOnBoard().Count(target => unitConstraints.All(t => t.Check(target)));
    }
}