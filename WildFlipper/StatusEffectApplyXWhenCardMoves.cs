using UnityEngine;

namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class StatusEffectApplyXWhenCardMoves : StatusEffectApplyX
        {
            public bool whenSelfMoves;
            public bool whenAllyMoves;
            public bool whenEnemyMoves = true;

            private Hit hackyHit;

            public override void Init()
            {
                Events.OnEntityMove += CheckMove;
            }
            public void OnDestroy()
            {
                Events.OnEntityMove -= CheckMove;
            }

            public void CheckMove(Entity entity)
            {
                // Note the || bit has to all be in parentheses
                if (target.alive && (!this.target.enabled || !entity.enabled))
                    return;

                if (!Battle.IsOnBoard(entity) || StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
                    return;

                if (ShoveSystem.shovedFrom.Contains(entity))
                {
                    Debug.LogWarning("LMAO this guy got shoved L: " + entity);
                    return;
                }

                if (whenSelfMoves && entity == target && HasMoved(entity))
                {
                    this.hackyHit = (Hit)null;
                    Activate(entity);
                }
                if (whenAllyMoves && IsAlly(this.target, entity) && HasMoved(entity))
                {
                    this.hackyHit = new Hit(this.target, entity);
                    Activate(entity);
                }
                if (whenEnemyMoves && IsEnemy(this.target, entity) && HasMoved(entity))
                {
                    this.hackyHit = new Hit(this.target, entity);
                    Activate(entity);
                }
            }

            private void Activate(Entity entity)
            {
                if (!target.enabled)
                    return;

                if (contextEqualAmount)
                {
                    int amount = contextEqualAmount.Get(entity);
                    ActionQueue.Stack(new ActionSequence(this.Run(this.GetTargets(hackyHit), amount)) { note = $"[{entity.name} {name}] {amount}" }, true);
                }
                else
                    ActionQueue.Stack(new ActionSequence(this.Run(this.GetTargets(hackyHit))) { note = $"[{entity.name} {name}]" }, true);
            }


            private static bool HasMoved(Entity entity)
            {
                return entity.containers != entity.preContainers;
            }

            private static bool IsAlly(Entity a, Entity b)
            {
                return a != b && a.owner.team == b.owner.team;
            }

            private static bool IsEnemy(Entity a, Entity b) => a.owner.team != b.owner.team;
        }
    }
}
