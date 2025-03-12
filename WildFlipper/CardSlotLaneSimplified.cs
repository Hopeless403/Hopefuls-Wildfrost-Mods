using System.Collections.Generic;
using UnityEngine;

namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class CardSlotLaneSimplified : CardSlotLane
        {
            /*public override void MoveChildrenForward()
            {
                // Handle non-backline units from front to back
                for (int columnFromFront = 1; columnFromFront < max; columnFromFront++)
                {
                    CardSlot cardSlot = slots[columnFromFront];
                    Entity cardSlotEntity = cardSlot.GetTop();
                    if (!cardSlotEntity || cardSlotEntity.positionPriority <= 0)
                    {
                        continue;
                    }

                    int num = 0;
                    List<CardSlot> list = new List<CardSlot> { cardSlot };
                    if (cardSlotEntity.height > 1)
                    {
                        CardContainer[] secondaryContainers = cardSlot.GetSecondaryContainers(cardSlotEntity);
                        foreach (CardContainer cardContainer in secondaryContainers)
                        {
                            if (cardContainer is CardSlot item && cardContainer.Group is CardSlotLane)
                            {
                                list.Add(item);
                            }
                        }
                    }

                    for (int num2 = columnFromFront - 1; num2 >= 0; num2--)
                    {
                        bool flag = true;
                        foreach (CardSlot item3 in list)
                        {
                            if (!(item3.Group as CardSlotLane).slots[num2].Empty)
                            {
                                flag = false;
                                break;
                            }
                        }

                        if (!flag)
                        {
                            break;
                        }

                        num++;
                    }

                    if (num <= 0)
                    {
                        continue;
                    }

                    if (list.Count > 1)
                    {
                        foreach (CardSlot item4 in list)
                        {
                            if (item4.IsPrimaryContainer(cardSlotEntity))
                            {
                                list.Remove(item4);
                                list.Insert(0, item4);
                                break;
                            }
                        }
                    }

                    for (int num3 = list.Count - 1; num3 >= 0; num3--)
                    {
                        CardSlot cardSlot2 = list[num3];
                        CardSlotLane obj = cardSlot2.Group as CardSlotLane;
                        int num4 = obj.slots.IndexOf(cardSlot2);
                        CardSlot cardSlot3 = obj.slots[num4 - num];
                        cardSlot2.Remove(cardSlotEntity);
                        cardSlot3.Add(cardSlotEntity);
                    }
                }


                // Handle backline units from back to front
                for (int columnFromFront = max - 2; columnFromFront >= 0; columnFromFront--)
                {
                    CardSlot cardSlot4 = slots[columnFromFront];
                    Entity top2 = cardSlot4.GetTop();
                    if (!(bool)top2 || top2.positionPriority >= 0)
                    {
                        continue;
                    }
                    int num6 = 0;
                    List<CardSlot> list2 = new List<CardSlot> { cardSlot4 };
                    if (top2.height > 1)
                    {
                        CardContainer[] secondaryContainers = cardSlot4.GetSecondaryContainers(top2);
                        foreach (CardContainer cardContainer2 in secondaryContainers)
                        {
                            if (cardContainer2 is CardSlot item2 && cardContainer2.Group is CardSlotLane)
                            {
                                list2.Add(item2);
                            }
                        }
                    }

                    for (int k = columnFromFront + 1; k < max; k++)
                    {
                        bool flag2 = true;
                        foreach (CardSlot item5 in list2)
                        {
                            if (!(item5.Group as CardSlotLane).slots[k].Empty)
                            {
                                flag2 = false;
                                break;
                            }
                        }

                        if (!flag2)
                        {
                            break;
                        }

                        num6++;
                    }

                    if (num6 <= 0)
                    {
                        continue;
                    }
                    if (list2.Count > 1)
                    {
                        foreach (CardSlot item6 in list2)
                        {
                            if (item6.IsPrimaryContainer(top2))
                            {
                                list2.Remove(item6);
                                list2.Insert(0, item6);
                                break;
                            }
                        }
                    }

                    for (int num7 = list2.Count - 1; num7 >= 0; num7--)
                    {
                        CardSlot cardSlot5 = list2[num7];
                        CardSlotLane obj2 = cardSlot5.Group as CardSlotLane;
                        int num8 = obj2.slots.IndexOf(cardSlot5);
                        CardSlot cardSlot6 = obj2.slots[num8 + num6];
                        cardSlot5.Remove(top2);
                        cardSlot6.Add(top2);
                    }
                }
            }*/

            // Positive priority = frontline
            // Negative priority = backline
            // Zero priority = move forward when possible
            public void MoveChildrenForward(in int priority = 0)
            {
                if (priority == 0)
                    return;

                System.Math.Sign(priority);
                if (priority > 0)
                {
                    /// Loop through possible frontline units from front to back
                    /// ...respectively backline units from back to front
                    // for (int columnFromFront = max - 2; columnFromFront >= 0; columnFromFront--)
                    for (int columnFromFront = 1; columnFromFront < max; columnFromFront++)
                    {
                        CardSlot cardSlot = slots[columnFromFront];
                        Entity cardSlotEntity = cardSlot.GetTop();
                        // if (!cardSlotEntity || cardSlotEntity.positionPriority >= 0)
                        if (!cardSlotEntity || cardSlotEntity.positionPriority <= 0)
                        {
                            continue;
                        }

                        List<CardSlot> entitySlots = new List<CardSlot> { cardSlot };
                        if (cardSlotEntity.height > 1)
                        {
                            CardContainer[] secondaryContainers = cardSlot.GetSecondaryContainers(cardSlotEntity);
                            foreach (CardContainer cardContainer in secondaryContainers)
                            {
                                if (cardContainer is CardSlot slot && cardContainer.Group is CardSlotLane)
                                {
                                    entitySlots.Add(slot);
                                }
                            }
                        }

                        int emptyColumnsForward = 0;

                        // for (int columnBackward = columnFromFront + 1; columnBackward < max; columnBackward++)
                        for (int columnForward = columnFromFront - 1; columnForward >= 0; columnForward--)
                        {
                            bool columnIsEmpty = true;
                            foreach (CardSlot entitySlot in entitySlots)
                            {
                                if (!(entitySlot.Group as CardSlotLane).slots[columnForward].Empty)
                                {
                                    columnIsEmpty = false;
                                    break;
                                }
                            }

                            if (!columnIsEmpty)
                            {
                                break;
                            }

                            emptyColumnsForward++;
                        }

                        if (emptyColumnsForward <= 0)
                        {
                            continue;
                        }

                        if (entitySlots.Count > 1)
                        {
                            foreach (CardSlot slotInColumn in entitySlots)
                            {
                                if (slotInColumn.IsPrimaryContainer(cardSlotEntity))
                                {
                                    entitySlots.Remove(slotInColumn);
                                    entitySlots.Insert(0, slotInColumn);
                                    break;
                                }
                            }
                        }

                        /// Move each entity slot forward in its row to its target position
                        // for (int num3 = slotsInColumn.Count - 1; num3 >= 0; num3--)
                        for (int num3 = entitySlots.Count - 1; num3 >= 0; num3--)
                        {
                            CardSlot fromColumn = entitySlots[num3];
                            CardSlotLane slotRow = fromColumn.Group as CardSlotLane;
                            int num4 = slotRow.slots.IndexOf(fromColumn);

                            /// Slot 0 is frontmost, so minus = move forward
                            // CardSlot toColumn = slotRow.slots[num4 + emptyColumnsForward];
                            CardSlot toColumn = slotRow.slots[num4 - emptyColumnsForward];
                            fromColumn.Remove(cardSlotEntity);
                            toColumn.Add(cardSlotEntity);
                        }
                    }
                }
            }
        }
    }
}
