using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class TargetConstraintInColumn : TargetConstraint
        {
            public int targetColumn = 2;
            public override bool Check(CardData targetData) => this.not;
            public override bool Check(Entity target)
            {
                List<CardContainer> rows = Battle.instance?.GetRows(target.owner);
                if (rows != null)
                    foreach (CardContainer cardContainer in rows)
                    {
                        if (cardContainer is CardSlotLane cardSlotLane)
                        {
                            if (targetColumn >= cardSlotLane.slots.Count)
                                continue;

                            CardSlot slot = cardSlotLane.slots[targetColumn];
                            if (target.InContainer(slot))
                                return !this.not;
                        }
                    }
                return this.not;
            }

            [ShowIf(nameof(Battle.CanDeploy))]
            public bool CanDeploy(Entity entity, int targetRow, out int targetColumn)
            {
                targetColumn = 0;
                bool canDeploy = false;
                List<CardContainer> ownedRows = Battle.instance.GetRows(entity.owner);


                int numberOfValidColumns = int.MaxValue;
                foreach (CardContainer ownedRow in ownedRows)
                {
                    numberOfValidColumns = Mathf.Min(numberOfValidColumns, ownedRow.max);
                }

                if (entity.positionPriority >= 0)
                {
                    for (int columnIndex = 0; columnIndex < numberOfValidColumns; columnIndex++)
                    {
                        bool canPlaceThisColumn = false;
                        for (int rowIndex = 0; rowIndex < entity.height; rowIndex++)
                        {
                            CardContainer cardContainer = ownedRows[(targetRow + rowIndex) % ownedRows.Count];
                            if (cardContainer is not CardSlotLane cardSlotLane || !cardContainer.canBePlacedOn)
                            {
                                continue;
                            }

                            CardSlot cardSlot = cardSlotLane.slots[columnIndex];
                            if (!cardSlot.canBePlacedOn)
                            {
                                continue;
                            }

                            Entity entityInCardSlot = cardSlot.GetTop();
                            if (!entityInCardSlot)
                            {
                                canPlaceThisColumn = true;
                            }
                            else
                            {
                                if (entityInCardSlot.positionPriority > entity.positionPriority 
                                ||  entityInCardSlot.positionPriority == entity.positionPriority && entity.positionPriority <= 1
                                ||  !Battle.CanPushBack(entityInCardSlot)
                                    )
                                {
                                    continue;
                                }

                                bool canPushBack = true;
                                for (int pushToIndex = columnIndex + 1; pushToIndex < cardSlotLane.max; pushToIndex++)
                                {
                                    Entity entityToPushBack = cardSlotLane.slots[pushToIndex].GetTop();
                                    if (entityToPushBack && entityToPushBack.positionPriority >= entity.positionPriority)
                                    {
                                        canPushBack = false;
                                        break;
                                    }
                                }

                                if (canPushBack)
                                {
                                    canPlaceThisColumn = true;
                                }
                            }
                        }

                        if (canPlaceThisColumn)
                        {
                            canDeploy = true;
                            targetColumn = columnIndex;
                            break;
                        }
                    }
                }
                else if (entity.positionPriority < 0)
                {
                    for (int columnIndex = numberOfValidColumns - 1; columnIndex >= 0; columnIndex--)
                    {
                        bool canPushForwards = true;
                        for (int rowIndex = 0; rowIndex < entity.height; rowIndex++)
                        {
                            if (ownedRows[(targetRow + rowIndex) % ownedRows.Count] is CardSlotLane cardSlotLane2)
                            {
                                Entity entityToPushForwards = cardSlotLane2.slots[columnIndex].GetTop();
                                if (entityToPushForwards && (entityToPushForwards.positionPriority > entity.positionPriority || !Battle.CanPushForwards(entityToPushForwards)))
                                {
                                    canPushForwards = false;
                                }
                            }
                        }

                        if (canPushForwards)
                        {
                            canDeploy = true;
                            targetColumn = columnIndex;
                            break;
                        }
                    }
                }
                return canDeploy;
            }
        }
    }
}
