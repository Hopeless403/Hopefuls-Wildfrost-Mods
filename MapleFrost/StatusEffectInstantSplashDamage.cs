using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

public class StatusEffectInstantSplashDamage : StatusEffectInstant
{
    public override IEnumerator Process()
    {
        target.lastHit = null;
        // set this up for later
        Routine.Clump clump = new();
        List<Entity> targets = new();

        if (TryGetVertical(this.target, out List<Entity> otherEntities))
            targets.AddRange(otherEntities);

        if (TryGetHorizontal(this.target, out otherEntities))
            targets.AddRange(otherEntities);

        foreach (Entity entity in targets)
        {
            // this.applier is needed to attribute the kill properly
            Hit hit = new Hit(this.applier, entity, count)
            {
                canRetaliate = false,       // is an indirect hit
                countsAsHit = true,         // is a damaging hit
            };
            clump.Add(hit.Process());       // process all the hits at once
        }

        Debug.LogWarning($"Hitting [{applier.name} vs {string.Join(", ", targets.ToArrayOfNames().DefaultIfEmpty(null))}] for {count}");
        yield return clump.WaitForEnd();

        Debug.LogWarning($"Done");
        yield return base.Process();        // calls this.Remove()
    }
    public List<int> GetColIndices(Entity entity)
    {
        List<int> indices = [-1];
        if (entity.owner)
        {
            foreach (CardContainer row in References.Battle.GetRows(entity.owner))
            {
                if (row is not CardSlotLane lane)
                    continue;
                // the row is a proper lane of cards

                foreach (var slot in lane.slots)
                {
                    // if the entity is alive, check where it is
                    if (entity.actualContainers.Contains(slot))
                        indices.Add(lane.slots.IndexOf(slot));

                    // if the entity died, check where it was
                    else if (entity.preActualContainers?.Contains(slot) ?? false)
                        indices.Add(lane.slots.IndexOf(slot));
                }
            }
        }
        indices = indices.Distinct().Where(index => index >= 0).ToList();

        return indices;
    }

    public bool TryGetVertical(Entity entity, out List<Entity> otherEntities)
    {
        otherEntities = [];

        List<int> indices = GetColIndices(entity);
        if (entity.owner)
        {
            foreach (CardContainer row in References.Battle.GetRows(entity.owner))
            {
                if (row is not CardSlotLane lane)
                    continue;
                // the row is a proper lane of cards

                foreach (int index in indices)
                {
                    Debug.LogWarning("Vertical " + index);
                    if (lane.ChildCount < index)
                        break;
                    // the lane has at least (index) many slots (variable due to mods)

                    otherEntities.Add(lane[index]);
                    // lane[index] = the entity in the indexed slot, null if empty
                }
            }
        }
        otherEntities = otherEntities.Distinct().Where(e => e != null && e != entity).ToList();

        Debug.LogWarning($"[{entity}] has column allies {string.Join(", ", otherEntities.DefaultIfEmpty(null))}");
        return otherEntities.Any();
    }
    public bool TryGetHorizontal(Entity entity, out List<Entity> otherEntities)
    {
        otherEntities = [];
        if (entity.owner)
        {
            foreach (CardContainer row in References.Battle.GetRows(entity.owner))
            {
                if (row is not CardSlotLane lane)
                    continue;
                // the row is a proper lane of cards

                if (!lane.Contains(entity) && !lane.slots.Intersect(entity.preActualContainers ?? []).Any())
                    continue;
                // the entity is in this row

                foreach (var slot in (entity.preActualContainers ?? entity.actualContainers.ToArray()).Intersect(lane.slots))
                {
                    int index = lane.slots.IndexOf(slot as CardSlot);
                    Debug.LogWarning("Horizontal " + index);
                    if (index - 1 >= 0)
                        otherEntities.Add(lane[index - 1]);

                    if (index + 1 < lane.ChildCount)
                        otherEntities.Add(lane[index + 1]);
                    // lane[index] = the entity in the indexed slot, null if empty
                }
            }
        }
        otherEntities = otherEntities.Distinct().Where(e => e != null && e != entity).ToList();

        Debug.LogWarning($"[{entity}] has adjacent allies {string.Join(", ", otherEntities.DefaultIfEmpty(null))}");
        return otherEntities.Any();
    }
}