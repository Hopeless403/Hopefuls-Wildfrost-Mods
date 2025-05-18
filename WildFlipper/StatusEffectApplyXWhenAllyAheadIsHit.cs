namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class StatusEffectApplyXWhenAllyAheadIsHit : StatusEffectApplyXWhenAllyIsHit
        {
            public override bool RunPostHitEvent(Hit hit)
            {
                return base.RunPostHitEvent(hit) && IsInFrontOf(hit.target);
            }

            public bool IsInFrontOf(Entity entity)
            {
                foreach (CardContainer cardContainer in target.actualContainers)
                {
                    if (cardContainer is CardSlot cardSlot && cardContainer.Group is CardSlotLane lane)
                    {
                        for (int index = lane.slots.IndexOf(cardSlot) - 1; index >= 0; --index)
                        {
                            if (lane.slots[index].GetTop() == entity)
                                return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}


