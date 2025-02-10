
using System;
using System.Collections;
using NaughtyAttributes;

namespace WildfrostHopeMod.Effects
{
    public abstract class Base : StatusEffectData
    {
        [InfoBox("Who can receive this effect?")]
        public System.Collections.Generic.List<TargetConstraint> receiverConstraints = new();

        [InfoBox("Reaction as in it is caused by another entity")]
        public bool _isReaction = false;
        [ShowIf("isReaction")]
        public StatusEffectApplyX.ApplyToFlags _reactTo = StatusEffectApplyX.ApplyToFlags.None;

        [InfoBox("Uses StatusEffectApplyX.ApplyToFlags enum")]
        public bool hasTargets = false;
        [ShowIf("hasTargets")]
        public StatusEffectApplyX.ApplyToFlags targets = StatusEffectApplyX.ApplyToFlags.None;

        [InfoBox("Enemies shouldn't have effects from hand")]
        public bool applyFromHand = false;

        [InfoBox("Enemies shouldn't have effects from hand")]
        public bool applyToHand = false;


    }

    public enum RandomisationModes : int
    {
        None,
        Vanilla_Only,
        Controlled_Randomisation,
        Anything_Goes,
    }

    public abstract class RandomEffect : StatusEffectApplyX
    {
        private IEnumerator Check(Entity entity, params object[] args)
        {
            yield return null;
        }
    }
}
