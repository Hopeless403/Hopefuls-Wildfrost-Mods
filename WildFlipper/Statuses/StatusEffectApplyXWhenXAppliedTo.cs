using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;

namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        // When a tracked status is applied, reuse the status as the effectToApply
        public class StatusEffectApplyXWhenXAppliedTo : StatusEffectApplyXWhenYAppliedTo
        {
            public bool ignoreSilenced = true;
            private StatusEffectData storedEffect;
            public override bool TargetSilenced()
            {
                return !ignoreSilenced && base.TargetSilenced();
            }
            public override IEnumerator PostApplyStatusRoutine(StatusEffectApply apply)
            {
                storedEffect = effectToApply;
                effectToApply = apply.effectData;
                yield return base.PostApplyStatusRoutine(apply);

                if (base.queue && base.action != null)
                {
                    ActionQueue.Stack(
                        new ActionSequence(Fix()) { note = $"Fix effectToApply: [{storedEffect}]"}
                        , true
                        );
                }
                else
                    effectToApply = storedEffect;
            }
            private IEnumerator Fix()
            {
                effectToApply = storedEffect;
                yield break;
            }
        }
    }
}
