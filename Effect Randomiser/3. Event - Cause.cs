using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WildfrostHopeMod;
using static WildfrostHopeMod.Effects.Randomiser;

namespace WildfrostHopeMod.Effects
{
    public enum EventOnEntity
    {
        None,
        Heal, // When X is Healed, or On X Heals
        Overheal,
        Hit, // When X is Hit, or On X Hits. ALSO: When Redraw Hit
        Damage, // When X Takes (Basic) Damage, or On X Damages
        HealthChange, // When Health Lost
        Kill, // When X is Killed, or On X Kills
        Deploy,
        Destroy,
        Discard,
        Draw,
        Attack,
        Apply, // When Y Applied To X
        Eat,
        Consume, // For items.
        Sacrifice,
        Trigger, // As in, Pre (Self) Trigger

        Summon,
        Turn, // As in, Pre (Self) Turn
        ShroomDamage, // Whenever anything takes Shroom Damage


        Charmed,
    }
    internal class EventRandomiserAsEffect
    {
        public class RandomEffect : StatusEffectApplyX
        {
            public RandomEffect(Effect effect) { this.effect = effect; }
            public Effect effect;
            public Dictionary<string, object> data = [];

            const string isAlreadyOnBoard = nameof(isAlreadyOnBoard);

            public override void Init()
            {
                switch (effect.eventOccurred)
                {
                    case EventOnEntity.Kill:
                    case EventOnEntity.Destroy:
                    case EventOnEntity.Eat:
                    case EventOnEntity.Sacrifice:
                        OnEntityDestroyed += new EffectEntityDeathEventHandler(CheckDestroy);
                        break;

                    case EventOnEntity.Hit:
                        if (effect.when == When.When)
                        {
                            PostHit += new EffectHitEventHandler(CheckHit);
                        }
                        else OnHit += new EffectHitEventHandler(CheckHit);
                        break;
                    case EventOnEntity.Overheal:
                        OnHit += new EffectHitEventHandler(CheckHit);
                        break;
                    case EventOnEntity.Heal:
                        OnHit += new EffectHitEventHandler(CheckHit);
                        OnApplyStatus += new EffectApplyEventHandler(CheckStatus);
                        break;
                    case EventOnEntity.Damage:
                        break;
                    case EventOnEntity.HealthChange:
                        break;
                    case EventOnEntity.Deploy:
                        data["isAlreadyOnBoard"] = false;
                        this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.CheckEnable);
                        this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CheckCardMove);
                        break;
                    case EventOnEntity.Discard:
                        data["isAlreadyOnBoard"] = false;
                        this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.CheckEnable);
                        this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CheckCardMove);
                        break;
                    case EventOnEntity.Draw:
                        data["isAlreadyOnBoard"] = false;
                        this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.CheckEnable);
                        this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CheckCardMove);
                        break;
                    case EventOnEntity.Attack:
                        break;
                    case EventOnEntity.Apply:
                        break;
                    case EventOnEntity.Consume:
                        break;
                    case EventOnEntity.Trigger:
                        break;
                    case EventOnEntity.Summon:
                        break;
                    case EventOnEntity.Turn:
                        break;
                    case EventOnEntity.ShroomDamage:
                        break;
                    case EventOnEntity.Charmed:
                        break;
                }
            }

            public override object GetMidBattleData()
            {
                data[isAlreadyOnBoard] = Battle.IsOnBoard(target);

                return data;
            }
            public override void RestoreMidBattleData(object data)
            {
                this.data = data as Dictionary<string, object>;
            }





            public override bool RunEnableEvent(Entity entity)
            {
                switch (effect.eventToOccur)
                {
                    case EventOnEntity.Deploy:
                        if (effect.contextEntity == ContextEntity.Self && entity == target && Battle.IsOnBoard(this.target))

                        break;
                }

                if (this.whenSelfDeployed && (Object)entity == (Object)this.target && Battle.IsOnBoard(this.target))
                {
                    if (this.isAlreadyOnBoard)
                    {
                        this.isAlreadyOnBoard = false;
                        return false;
                    }
                    this.hackyHit = (Hit)null;
                    return true;
                }
                if (this.whenAllyDeployed && this.target.enabled && StatusEffectApplyXWhenDeployed.IsAlly(this.target, entity) && Battle.IsOnBoard(this.target) && Battle.IsOnBoard(entity))
                {
                    this.hackyHit = new Hit(this.target, entity);
                    return true;
                }
                if (!this.whenEnemyDeployed || !this.target.enabled || !StatusEffectApplyXWhenDeployed.IsEnemy(this.target, entity) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(entity))
                    return false;
                this.hackyHit = new Hit(this.target, entity);
                return true;
            }

            public override bool RunCardMoveEvent(Entity entity)
            {
                if (!this.target.enabled || !entity.enabled)
                    return false;
                if (this.whenSelfDeployed && (Object)entity == (Object)this.target && StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
                {
                    this.hackyHit = (Hit)null;
                    return true;
                }
                if (this.whenAllyDeployed && StatusEffectApplyXWhenDeployed.IsAlly(this.target, entity) && StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
                {
                    this.hackyHit = new Hit(this.target, entity);
                    return true;
                }
                if (!this.whenEnemyDeployed || !StatusEffectApplyXWhenDeployed.IsEnemy(this.target, entity) || !StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
                    return false;
                this.hackyHit = new Hit(this.target, entity);
                return true;
            }





            public override bool RunApplyStatusEvent(StatusEffectApply apply)
            {
                switch (effect.eventOccurred)
                {
                    case EventOnEntity.Heal:
                        return apply.target == target && apply.effectData.type == "max health up";
                }
                return false;
            }



            public override bool RunPostHitEvent(Hit hit)
            {
                if (effect.eventOccurred == EventOnEntity.Hit && effect.when == When.When)
                    return target.enabled && hit.target == target && hit.canRetaliate && (!targetMustBeAlive || target.alive && Battle.IsOnBoard(this.target)) && hit.Offensive && hit.BasicHit && this.CheckAttackerConstraints(hit.attacker);
                return false;
            }

            public override bool RunHitEvent(Hit hit)
            {
                switch (effect.eventOccurred)
                {
                    case EventOnEntity.Heal:
                        return hit.target == target && hit.damage < 0;
                    case EventOnEntity.Overheal:
                        return hit.target == target && hit.damage < 0 && target.hp.current - hit.damage - target.hp.max > 0;
                    
                }
                return false;
            }

            public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
            {
                switch (effect.eventOccurred)
                {
                    case EventOnEntity.Kill:
                        if (effect.when == When.On && effect.contextEntity == ContextEntity.Self)
                            return entity.lastHit?.attacker == target;

                        // When Clunker Destroyed
                        if (effect.when == When.When && effect.contextEntity == ContextEntity.AnyClunker)
                            return target.enabled && entity.data.cardType.name == "Clunker" && Battle.IsOnBoard(target);
                        break;

                    case EventOnEntity.Eat:
                    case EventOnEntity.Sacrifice:
                    case EventOnEntity.Destroy:
                        // When (Self) Destroyed, When (Self) Eaten, When (Self) Sacrificed
                        if (effect.when == When.When && effect.contextEntity == ContextEntity.Self)
                            return entity == target && CheckDeathType(deathType);
                        break;
                }
                return false;
            }
            private IEnumerator CheckDestroy(Entity entity, DeathType deathType) => Run(GetTargets(entity.lastHit));
            // When destroyed
            private bool CheckDeathType(DeathType deathType) =>

                (!(effect.eventOccurred == EventOnEntity.Eat) || deathType == DeathType.Consume)
                && (!(effect.eventOccurred == EventOnEntity.Sacrifice) || DeathSystem.KilledByOwnTeam(target));

            private IEnumerator CheckHit(Hit hit)
            {
                switch (effect.eventOccurred)
                {
                    case EventOnEntity.Hit:
                        return Run(GetTargets(hit, GetTargetContainers(), GetTargetActualContainers()), hit.damage + hit.damageBlocked);
                    case EventOnEntity.Heal:
                        return Run(GetTargets(hit), -hit.damage);
                    case EventOnEntity.Overheal:
                        return Run(GetTargets(hit), target.hp.current - hit.damage - target.hp.max);
                }
                return null;
            }
            private bool CheckAttackerConstraints(Entity attacker)
            {
                /*if (this.attackerConstraints != null)
                {
                    foreach (TargetConstraint attackerConstraint in this.attackerConstraints)
                    {
                        if (!attackerConstraint.Check(attacker))
                            return false;
                    }
                }*/
                return true;
            }
            private IEnumerator CheckStatus(StatusEffectApply apply)
            {
                if (effect.eventOccurred == EventOnEntity.Heal)
                    return Run(GetTargets(targets: new Entity[1] { apply.target }), apply.count);
                return null;
            }
            // uses data["isAlreadyOnBoard"]
            private IEnumerator CheckEnable(Entity entity)
            {
                if (effect.eventOccurred == EventOnEntity.Deploy)
                {

                }
                return null;
            }
            private IEnumerator CheckCardMove(Entity entity)
            {
                return null;
            }


        }

    }
    internal class EventRandomiserAsActivator
    {

        public void Run(Effect effect, out StatusEffectApplyX data, Type type)
        {
            switch (effect.eventOccurred)
            {
                case EventOnEntity.Apply:
                    if (effect.contextEntity == ContextEntity.Allies)
                        type = typeof(StatusEffectApplyXWhenYAppliedToAlly);
                    else if (effect.contextEntityFlag == StatusEffectApplyX.ApplyToFlags.Self)
                        type = typeof(StatusEffectApplyXWhenYAppliedToSelf);
                    else type = typeof(StatusEffectApplyXWhenYAppliedTo);
                    break;

                case EventOnEntity.Kill:
                    type = typeof(StatusEffectApplyXWhenUnitIsKilled);
                    var tempData = Activator.CreateInstance(type) as StatusEffectApplyXWhenUnitIsKilled;
                    if (effect.contextEntity == ContextEntity.Allies)
                    {
                        tempData.ally = true;
                    }
                    data = tempData;
                    break;

                default:
                    type = typeof(StatusEffectApplyXOnCardPlayed);
                    break;
            }
            data = (StatusEffectApplyX)(AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Find(s => s.GetType() == type) ?? Activator.CreateInstance(type));
        }
    }
}
