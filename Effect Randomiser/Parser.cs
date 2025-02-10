using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static WildfrostHopeMod.Effects.Randomiser;
using static StatusEffectApplyX;

namespace WildfrostHopeMod.Effects
{
    public static class EffectParser
    {
        public static Type ParseAsType(
            When when, 
            ContextEntity entity, 
            EventOnEntity isX, 
            EventOnEntity doY, 
            ContextEntity toTarget)
        {
            return when switch
            {
                When.None => typeof(void),
                When.Instant => throw new NotImplementedException(),
                When.When => throw new NotImplementedException(),
                When.While => throw new NotImplementedException(),
                When.Pre => throw new NotImplementedException(),
                When.On => throw new NotImplementedException(),
                When.Post => throw new NotImplementedException(),
                _ => throw new NotImplementedException()
            };
        }
        static Type ParseWhenInstant(
            ContextEntity entity,
            EventOnEntity isX,
            EventOnEntity doY,
            ContextEntity toTarget)
        {
            return doY switch
            {
                EventOnEntity.Heal => typeof(StatusEffectInstantHeal),
                EventOnEntity.Overheal => throw new NotImplementedException(),
                EventOnEntity.Hit => throw new NotImplementedException(),
                EventOnEntity.Damage => throw new NotImplementedException(),
                EventOnEntity.HealthChange => throw new NotImplementedException(),
                EventOnEntity.Kill => throw new NotImplementedException(),
                EventOnEntity.Deploy => throw new NotImplementedException(),
                EventOnEntity.Destroy => throw new NotImplementedException(),
                EventOnEntity.Discard => throw new NotImplementedException(),
                EventOnEntity.Draw => throw new NotImplementedException(),
                EventOnEntity.Attack => throw new NotImplementedException(),
                EventOnEntity.Apply => throw new NotImplementedException(),
                EventOnEntity.Eat => throw new NotImplementedException(),
                EventOnEntity.Consume => throw new NotImplementedException(),
                EventOnEntity.Sacrifice => throw new NotImplementedException(),
                EventOnEntity.Trigger => throw new NotImplementedException(),
                EventOnEntity.Summon => throw new NotImplementedException(),
                EventOnEntity.Turn => throw new NotImplementedException(),
                EventOnEntity.ShroomDamage => throw new NotImplementedException(),
                EventOnEntity.Charmed => throw new NotImplementedException(),
                _ => throw new NotImplementedException(),
            };
        }
    }




    public class StatusEffectApplyXWhenYIsZ : StatusEffectApplyX
    {
        [Header("Y = Context Flags")]
        public bool basedOnEntity = true;

        [ShowIf(nameof(basedOnEntity))]
        public ApplyToFlags contextEntity = ApplyToFlags.Self;
        [ShowIf(nameof(basedOnEntity))]
        public TargetConstraint[] contextEntityConstraints = [];
        [HideIf(nameof(basedOnEntity))]
        public string contextEffectType = "";
        [HideIf(nameof(basedOnEntity))]
        public ScriptableAmount contextEffectAmount = null;

        [Header("Z = Context Event")]
        public EventOnEntity contextEvent = EventOnEntity.None;


        [Header("X = Effect To Apply")]
        public new StatusEffectData effectToApply;


    }

    internal class SEGParser
    {
        public SEGParser(string input) => this.input = input;

        string input;
        Effect effect;

        /*static void ProcessTag(string tag)
        {
            string[] args = tag.Split('=');
            if (args.Length < 2) return;
            switch (args[0].Trim())
            {
                case "listener":

            }
        }*/

        public Effect Process(string input)
        {
            string text = input.Trim();
            int length = text.Length;
            for (int i = 0; i < length; ++i)
            {
                if (text[i] == '<')
                {
                    string tag = Text.FindTag(text, i);
                    if (tag.Length > 0)
                    {
                        text = text.Remove(i, tag.Length + 2);
                    }
                }
            }

            string[] args;
            if (input == null || (args = input.ToLowerInvariant().Split(' ')).Length == 0) return default;
            StatusEffectApplyX data = null;

            switch (args[0])
            {
                case "when":
                    StatusEffectApplyXWhenYIsZ effect = Activator.CreateInstance(typeof(StatusEffectApplyXWhenYIsZ)) as StatusEffectApplyXWhenYIsZ;
                    data = effect;
                    if ((args = args.RangeSubset(1, args.Length - 1)).Any())
                    {
                        if (typeof(ApplyToFlags).GetEnumNames().Select(s => s.ToLowerInvariant()).Contains(args[0]))
                        {
                            effect.basedOnEntity = true;

                        }
                    }
                    break;
            }
            return default;
        }

        /*public Effect Run(string input)
        {
            string[] args;
            if (input == null || (args = input.ToLowerInvariant().Split(' ')).Length == 0) return default;
            StatusEffectApplyX data = null;
            
            switch (args[0])
            {
                case "when":
                    StatusEffectApplyXWhenYIsZ effect = Activator.CreateInstance(typeof(StatusEffectApplyXWhenYIsZ)) as StatusEffectApplyXWhenYIsZ;
                    data = effect;
                    if ((args = args.RangeSubset(1, args.Length - 1)).Any())
                    {
                        if (typeof(ApplyToFlags).GetEnumNames().Select(s => s.ToLowerInvariant()).Contains(args[0]))
                        {
                            effect.basedOnEntity = true;
                            
                        }
                    }
                    break;
            }
            return default;
        }*/
    }
}
