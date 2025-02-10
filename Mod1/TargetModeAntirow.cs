using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod.Mod1
{
    public class TargetModeColumn : TargetMode
    {
        public override bool TargetRow => true;
        public int ignoreColumn = 0;
        public Entity[] AntiGetTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            HashSet<Entity> list = new HashSet<Entity>();
            list.AddRange(entity.GetAllEnemies().Where(e => e && e.enabled && e.alive && e.canBeHit && CheckSlot(e, ignoreColumn)));
            return list.Count <= 0 ? null : list.ToArray();
        }
        public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            return GetTargets(entity, target, targetContainer);
        }
        public override Entity[] GetSubsequentTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            return GetTargets(entity, target, targetContainer);
        }
        public bool CheckSlot(Entity entity, int index = 0)
        {
            foreach (CardContainer row in References.Battle.GetRows(entity.owner))
            {
                if (row is not CardSlotLane lane)
                    continue;
                // the row is a proper lane of cards

                if (lane.slots.Count <= index)
                    continue;

                CardSlot rowSlot = lane.slots[index];
                if (entity.actualContainers.Contains(rowSlot))
                    return true;
            }
            return false;
        }
    }
    public class TargetModeAnticol : TargetModeRow
    {
        /// <summary>
        /// zero-indexed, so 3rd column is #2
        /// </summary>
        public int ignoreColumn = 2;

        public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
            => base.GetTargets(entity, target, targetContainer)
            .Except(AntiGetTargets(entity, target, targetContainer))
            .ToArray();

        public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
            => base.GetPotentialTargets(entity, target, targetContainer)
            .Except(AntiGetTargets(entity, target, targetContainer))
            .ToArray();

        public Entity[] AntiGetTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            HashSet<Entity> list = new HashSet<Entity>();
            list.AddRange(entity.GetAllEnemies().Where(e => e && e.enabled && e.alive && e.canBeHit && CheckSlot(e, ignoreColumn)));
            return list.Count <= 0 ? new Entity[0] : list.ToArray();
        }
        public bool CheckSlot(Entity entity, int index = 0)
        {
            foreach (CardContainer row in References.Battle.GetRows(entity.owner))
            {
                if (row is not CardSlotLane lane)
                    continue;
                // the row is a proper lane of cards

                if (lane.slots.Count <= index)
                    continue;

                CardSlot rowSlot = lane.slots[index];
                if (entity.actualContainers.Contains(rowSlot))
                    return true;
            }
            return false;
        }
    }
}
