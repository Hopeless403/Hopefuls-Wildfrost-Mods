using System.Collections.Generic;
using System.Linq;

namespace WildfrostHopeMod.MapleFrost
{
    public class TargetModeColumn : TargetMode
    {
        public int index = 0;
        public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            HashSet<Entity> list = new HashSet<Entity>();
            list.AddRange(entity.GetAllEnemies().Where(e => e && e.enabled && e.alive && e.canBeHit && CheckSlot(e,index)));
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
    

    public class TargetModeAllRandom : TargetModeAll
    {
        public override bool Random => true;
        public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            Entity random = base.GetTargets(entity, target, targetContainer)?.RandomItem();
            return random ? new Entity[] { random } : null;
        }
        public override Entity[] GetSubsequentTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            Entity random = base.GetSubsequentTargets(entity, target, targetContainer)?.RandomItem();
            return random ? new Entity[] { random } : null;
        }
    }
}
