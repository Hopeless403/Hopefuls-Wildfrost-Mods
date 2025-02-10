using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.MapleFrost
{

    public class StatusEffectInstantProcessTrigger : StatusEffectInstantTrigger
    {
        public override IEnumerator Process()
        {
            if (againstRandomEnemy && target.NeedsTarget)
            {
                List<Entity> allEnemies = target.GetAllEnemies();
                if (allEnemies.Count > 0)
                {
                    Entity entity = allEnemies.RandomItem();
                    CardContainer targetContainer = entity.containers.RandomItem();
                    ActionTrigger trigger = new ActionTriggerAgainst(target, applier, entity, targetContainer);
                    Events.InvokePreProcessTrigger(target);
                    StackTop(new ActionProcessTrigger(trigger.GetTrigger), fixedPosition: true);
                }
            }
            else
            {
                ActionTrigger trigger = new(target, applier) { priority = priority };
                Events.InvokePreProcessTrigger(target);
                StackTop(new ActionProcessTrigger(trigger.GetTrigger), fixedPosition: true);
            }

            if (reduceUses)
            {
                ActionQueue.Add(new ActionReduceUses(target));
            }

            yield return base.Process();
        }
        public void StackTop(PlayAction action, bool fixedPosition = true)
        {
            ActionQueue.instance.queue.Insert(0, action);
            ActionQueue.instance.count++;
            Events.InvokeActionQueued(action);
        }
    }


    public class StatusEffectApplyXOnTurnAnywhere : StatusEffectApplyXOnTurn
    {
        public override void Init()
        {
            this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(base.CheckCardPlay);
            this.OnTurn += new StatusEffectData.EffectEntityEventHandler(base.CheckTurn);
        }
        public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
        {
            Debug.LogWarning("Cardplay " + entity);
            if (this.turnTaken || entity != this.target)
                return false;
            if (!this.trueOnTurn)
                return true;
            this.turnTaken = true;
            return false;
        }
        public override bool RunTurnEvent(Entity entity)
        {
            Debug.LogWarning("RUNNING TURN EVENT! " + (trueOnTurn, turnTaken, entity == this.target));
            return this.trueOnTurn && this.turnTaken && entity == this.target;
        }
    }
    public class StatusEffectApplyXAfterTurn : StatusEffectApplyX
    {
        public override void Init()
        {
            this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(CheckCardPlay);
        }
        /// <returns>true only if the target was played, and has no more queued triggers</returns>
        public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
        {
            if (entity != target)
                return false;

            return !ActionQueue.instance.queue.Any(a => a is ActionTrigger trigger && trigger.entity == entity);
        }
        private IEnumerator CheckCardPlay(Entity entity, Entity[] targets) => this.Run(this.GetTargets());
    }

    public class StatusEffectInstantReduceStacks : StatusEffectInstant
    {
        public string statusName;
        public override IEnumerator Process()
        {
            Debug.Log("[Test] Removing...");
            int num = target.statusEffects.Count;
            for (int i = num - 1; i >= 0; i--)
            {
                StatusEffectData statusEffectData = target.statusEffects[i];
                if (statusEffectData.name == statusName)
                {
                    int one = 1;
                    Events.InvokeStatusEffectCountDown(statusEffectData, ref one);
                    yield return statusEffectData.RemoveStacks(1, false);
                    // add wait here if preferred
                    Debug.Log($"[Test] Remove Successful");
                }
            }
            if (target.display is Card display)
                display.promptUpdateDescription = true;
            target.PromptUpdate();
            yield return base.Remove();
        }
    }
}
