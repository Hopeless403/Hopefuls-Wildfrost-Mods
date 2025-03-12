using System.Collections;
using UnityEngine;

namespace WildFlipper
{
    public class StatusEffectRecycleX : StatusEffectRecycle
    {
        public override void Init()
        {
            Events.OnCheckAction += FixedCheckAction;
            this.PreTrigger += EntityPreTrigger;
        }
        public void OnDestroy()
        {
            Events.OnCheckAction -= FixedCheckAction;
        }
        public void FixedCheckAction(ref PlayAction action, ref bool allow)
        {
            if (this.running || !this.target.enabled || this.target.silenced || !allow || !(action is ActionTrigger actionTrigger) || !(actionTrigger.entity == this.target))
                return;
            int amount = this.GetAmount();
            Events.CheckRecycleAmount(this.target, ref amount);
            if (amount <= 0 || this.GetTargets(amount))
                return;
            allow = false;
            if (!NoTargetTextSystem.Exists())
                return;
            Routine routine = new Routine(NotEnoughToRecycle(amount));
        }
        public IEnumerator NotEnoughToRecycle(int amount)
        {
            NoTargetTextSystem targetTextSystem = NoTargetTextSystem.instance;
            if (targetTextSystem.enabled)
            {
                yield return Sequences.WaitForAnimationEnd(target);
                float shakeDuration = targetTextSystem.shakeDurationRange.Random();
                target.curveAnimator.Move(targetTextSystem.shakeAmount.WithX(targetTextSystem.shakeAmount.x.WithRandomSign()), targetTextSystem.shakeCurve, duration: shakeDuration);
                targetTextSystem.textElement.text = targetTextSystem.strings[NoTargetType.RequiresJunk].Format(amount);

                CardData card = null;
                if (card = AddressableLoader.Get<CardData>(nameof(CardData), cardToRecycle))
                    targetTextSystem.textElement.text = targetTextSystem.textElement.text
                        .Replace(AddressableLoader.Get<CardData>(nameof(CardData), "Junk").title,
                                 card.title
                        );

                targetTextSystem.PopText(target.transform.position);
                yield return new WaitForSeconds(shakeDuration);
            }
        }
    }
}
