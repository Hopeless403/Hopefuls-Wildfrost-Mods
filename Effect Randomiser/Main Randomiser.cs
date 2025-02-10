using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using static StatusEffectApplyX;
using WildfrostHopeMod.Effects;

namespace WildfrostHopeMod.Effects
{
    public class Randomiser : WildfrostMod
    {
        public static Randomiser Instance;
        public Randomiser(string modDirectory) : base(modDirectory)
        {
            Instance = this;
        }
        public override string GUID => "hope.wildfrost.effectrandomiser";
        public override string[] Depends => new string[] { };
        public override string Title => "Effect Randomiser";
        public override string Description => "Gives every card random effects, even ones that don't exist! They may or may not be useless :p";

        public static GameObject behaviour;

        [ConfigItem(When.On, "", "Test enum")]
        public When when;

        public override void Load()
        {

            base.Load();

            behaviour = new GameObject(Title, typeof(HopeModBehaviour));
            GameObject.DontDestroyOnLoad(behaviour);
            
            
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        public struct Effect
        {
            public When when;
            public ApplyToFlags contextEntityFlag;
            public ContextEntity contextEntity;
            public EventOnEntity eventOccurred;
            public EventOnEntity eventToOccur;
            public StatusEffectData effectToApply;
            public ApplyToFlags targetEntityFlag;
            public ContextEntity targetEntity;

            public Effect(When when, ContextEntity contextEntity, EventOnEntity eventOccurred, EventOnEntity eventToOccur, ContextEntity targetEntity)
            {
                this.when = when;
                this.contextEntity = contextEntity;
                this.eventOccurred = eventOccurred;
                this.eventToOccur = eventToOccur;
                this.targetEntity = targetEntity;
            }
            public Effect(When when, ContextEntity contextEntity, EventOnEntity eventOccurred, StatusEffectData effectToApply, ContextEntity targetEntity)
            {
                this.when = when;
                this.contextEntity = contextEntity;
                this.eventOccurred = eventOccurred;
                this.effectToApply = effectToApply;
                this.targetEntity = targetEntity;
            }
            public Effect(When when, ApplyToFlags contextEntityFlag, EventOnEntity eventOccurred, EventOnEntity eventToOccur, ApplyToFlags targetEntityFlag)
            {
                this.when = when;
                this.contextEntityFlag = contextEntityFlag;
                this.eventOccurred = eventOccurred;
                this.eventToOccur = eventToOccur;
                this.targetEntityFlag = targetEntityFlag;
            }
            public Effect(When when, ApplyToFlags contextEntityFlag, EventOnEntity eventOccurred, StatusEffectData effectToApply, ApplyToFlags targetEntityFlag)
            {
                this.when = when;
                this.contextEntityFlag = contextEntityFlag;
                this.eventOccurred = eventOccurred;
                this.effectToApply = effectToApply;
                this.targetEntityFlag = targetEntityFlag;
            }

        }

        public class EffectBuilder
        {
            public StatusEffectApplyX effectData;
            public string effectName;
            public StatusEffectDataBuilder builder => new StatusEffectDataBuilder(Instance);

            //ContextEntity contextEntity
            private StatusEffectDataBuilder StatusCopy(string oldName, string newName)
            {
                StatusEffectData data = Instance.Get<StatusEffectData>(oldName).InstantiateKeepName();
                data.name = newName;
                StatusEffectDataBuilder builder = data.Edit<StatusEffectData, StatusEffectDataBuilder>();
                builder.Mod = Instance;
                return builder;
            }
            public EffectBuilder(Effect effect)
            {
                builder.Create(effectName)
                   .FreeModify(data => {
                       
                       });

            }
        }

        public class HopeModBehaviour : MonoBehaviour
        {
            internal void Start()
            {
                
            }
        }
    }
}