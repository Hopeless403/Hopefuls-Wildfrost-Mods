using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod.Effects
{
    public enum When
    {
        None,
        Instant,
        When, // is Hit, Destroyed, is Killed
              // Used when another card enables the effect
        While, // Active, (Last) In Hand
        Pre, // Turn, Trigger
        On, // Card Played, Hit, Kill, Turn,
            // Used when this card enables the effect
        Post, // Not vanilla.
    }
    internal class WhenRandomiser
    {
        public class RandomEffectWhenX : StatusEffectApplyX
        {
            
        }

        public class RandomEffectWhileX : StatusEffectApplyX
        {

        }

        public class RandomEffectPreX : StatusEffectApplyX
        {

        }

        public class RandomEffectOnX : StatusEffectApplyX
        {

        }

        public class RandomEffectPostX : StatusEffectApplyX
        {

        }
    }
}
