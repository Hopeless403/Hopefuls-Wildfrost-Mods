using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[HarmonyPatch]
public class BiggerBoardSystem : GameSystem
{
    public static BiggerBoardSystem instance;
    public int targetRowCount = 2;
    public int targetSlotCount = 3;

    // Make cards smaller so counters are visible
    // ...but makes card text impossible to read.
    public bool tryResizing = false;

    // Game defaults are (15.4f, 6.7f)
    public float boardLength = 15.4f;
    public float boardHeight = 6.7f;

    // Add coloured rectangles where slots can detect a card
    public bool debugColours;
    
    public void OnEnable()
    {
        instance = this;
        Events.OnBattlePhaseStart += BattlePhaseStart;
        Events.OnMinibossIntroDone += MinibossIntrod; // Fix miniboss scales
    }
    public void OnDisable()
    {
        Events.OnBattlePhaseStart -= BattlePhaseStart;
        Events.OnMinibossIntroDone -= MinibossIntrod;
    }

    public void BattlePhaseStart(Battle.Phase phase)
    {
        if (phase != Battle.Phase.Init)
            return;
        BattleStart();
    }

    public void BattleStart()
    {
        if (Battle.instance.allRows.Min(row => row.slots.Count) < targetSlotCount)
        {
            foreach (var row in Battle.instance.allRows)
            {
                row.CreateSlots(row.max = targetSlotCount);
            }

            FixTargetingArrows();
        }

        // For compatibility with other mods, we only add rows and not destroy.
        if (References.Battle.rowCount < targetRowCount)
        {
            CardContainer tempPlayerRow = References.Battle.rows[References.Battle.player][0];
            GameObject tempFullRow = tempPlayerRow.transform.parent.gameObject;

            for (int i = References.Battle.rowCount; i < targetRowCount; i++)
            {
                References.Battle.rowCount++;

                GameObject newFullRow = Transform.Instantiate(tempFullRow, tempFullRow.transform.parent);
                newFullRow.name = $"Row {References.Battle.rowCount}";
                newFullRow.transform.localPosition = newFullRow.transform.localPosition.WithZ(1 - 0.5f * References.Battle.rowCount);

                foreach (var newLane in newFullRow.GetComponentsInChildren<CardSlotLane>())
                {
                    newLane.name = newLane.name.Replace("Row 1", $"Row {References.Battle.rowCount}");
                    newLane.ClearAndDestroyAllImmediately();  // Destroy any cards that somehow start in the row
                    newLane.CreateSlots(newLane.slots.Count);
                    References.Battle.rows[newLane.owner].Add(newLane);
                }
            }
        }

        Resize();
        DebugColours();
    }

    public void FixTargetingArrows()
    {
        var arrowSystem = GameObject.FindObjectOfType<TargetingArrowSystem>();
        if (!arrowSystem)
            return;

        foreach (var display in new TargetingDisplay[] { arrowSystem.supportiveArrow, arrowSystem.offensiveArrow })
        {
            if (display is TargetingArrow arrow
            && arrow.headStyleLookup.TryGetValue("TargetRow", out var style)
            && style.gameObject.TryGetComponent(out TargetingArrowHeadRow arrowHead)
            && arrowHead.targets.Length < targetSlotCount
            && arrowHead.targets.Length > 0)
            {
                var tempTarget = arrowHead.targets.FirstOrDefault();
                for (int i = arrowHead.targets.Length; i < targetSlotCount; i++)
                {
                    var newTarget = Transform.Instantiate(tempTarget, tempTarget.transform.parent);
                    arrowHead.targets = arrowHead.targets.With(newTarget);
                    arrowHead.targetTransforms = arrowHead.targetTransforms.With(newTarget.transform);
                    newTarget.name = $"Target{arrowHead.targets.Length}";
                }
            }
        }
    }
    public void Resize()
    {
        Transform rows = References.Battle.rows[References.Battle.player][0].transform.parent.parent;
        int slotCount = Battle.instance.allRows.Min(row => row.slots.Count);

        // RowLength = SlotLength * SlotCount + Spacing * (SlotCount - 1);
        // Where: 2 * RowLength + MiddleSpace = BoardLength
        // And  : SlotLength = 2 * MiddleSpace
        float middleSpace = 1;
        float slotLength = 2;
        float slotSpacing = 0;
        if (slotCount > 1)
            slotSpacing = ((boardLength - middleSpace) / 2f - slotLength * slotCount) / (slotCount - 1);

        if (tryResizing)
        {
            // Ideally we want this ratio, so health/attack are visible:
            //  Spacing : SlotLength = 0.6f : 2f;
            // Substituting into the main identity gives these calculations
            middleSpace = 5f * boardLength / (26 * slotCount - 1);
            slotLength = 2 * middleSpace;
            slotSpacing = 0.6f * middleSpace;
            // The above calculation assumes slot sizeDeltas will be changed... below is undoing it visually
            float s = slotSpacing;
            float r = slotLength;
            float R = 2;
            float S = s - (R-r);
            slotSpacing = S;

            foreach (var slot in Battle.instance.allSlots)
            {
                slot.transform.localScale = slotLength / 2f * Vector3.one;
                //slot.rectTransform.sizeDelta = slot.rectTransform.sizeDelta.WithX(middleSpace * slot.rectTransform.sizeDelta.x);
            }

            foreach (var row in References.Battle.rows[References.Battle.player])
            {
                var rowGroup = row.GetComponentInParent<HorizontalLayoutGroup>(); // between each side (player vs enemy)
                if (rowGroup) rowGroup.spacing = middleSpace;
            }
        }
        else // Not required but this gives a nice "crowded" screenshot :3
        {
            // BoardHeight = RowHeight * RowCount + Spacing * (RowCount - 1);
            float rowHeight = 3f; // 3f is game's default
            float spacing = 0;
            if (References.Battle.rowCount > 1)
                spacing = -rowHeight + (boardHeight - rowHeight) / (References.Battle.rowCount - 1);
            // Adjust row positions vertically
            if (rows.TryGetComponent<VerticalLayoutGroup>(out var group1)) 
                group1.spacing = spacing;
        }

        foreach (var row in Battle.instance.allRows)
        {
            //row.rectTransform.sizeDelta = row.rectTransform.sizeDelta.WithX((boardLength - middleSpace) / 2f);
            row.rectTransform.sizeDelta = new Vector3((boardLength-middleSpace)/2f, middleSpace*3, 1);

            var slotGroup = row.GetComponentInChildren<HorizontalLayoutGroup>(); // between each slot on one side
            if (slotGroup != null) slotGroup.spacing = slotSpacing;
        }


        // Auto-adjust row positions and board bounds
        if (rows.TryGetComponent<VerticalLayoutGroup>(out var group)) group.enabled = true;
        if (rows.TryGetComponent<ContentSizeFitter>(out var fitter)) fitter.enabled = true;
        if (rows.transform.parent.TryGetComponent<ContentSizeFitter>(out fitter))
        {
            IEnumerator ResizeNextFrame()
            {
                fitter.enabled = false;
                yield return null;
                fitter.enabled = true;
                if (tryResizing && rows is RectTransform rowsRect)
                    rows.localScale = boardHeight / (rowsRect.sizeDelta.y * middleSpace) * Vector3.one;
            }
            CoroutineManager.Start(ResizeNextFrame());
        }
    }

    public void MinibossIntrod(Entity entity)
    {
        entity.StartCoroutine(FixMinibossScale(entity));
    }
    private IEnumerator FixMinibossScale(Entity entity)
    {
        yield return new WaitWhile(entity.gameObject.LeanIsTweening);
        yield return new WaitForSeconds(0.167f);
        for (int i = 0; i < entity.containers.Length; i++)
        {
            entity.containers[i].TweenChildPositions();
        }
    }

    public void LateUpdate()
    {
        if (Campaign.instance && PatchBombard.system)
        {
            foreach (var target in PatchBombard.system.currentTargets)
            {
                // this works for widescreen but not narrow screens
                float rowScale = boardHeight / (3.7f * References.Battle.rowCount - 0.7f);
                target.Value.transform.position = target.Key.transform.position;
                target.Value.transform.localScale = target.Key.transform.localScale * rowScale;
            }
        }
    }

    public void DebugColours()
    {
        if (!debugColours)
            return;

        foreach (var team in References.Battle.rows)
        {
            for (float Y = 0; Y < team.Value.Count; Y++)
            {
                CardContainer row = team.Value[(int)Y];
                if (row is not CardSlotLane lane) continue;
                for (float X = 0; X < lane.slots.Count; X++)
                {
                    CardSlot slot = lane.slots[(int)X];
                    float c = 0;
                    float m = 1 - X / lane.slots.Count;
                    float y = 1 - Y / team.Value.Count;

                    var image = slot.gameObject.GetOrAdd<Image>();
                    image.canvas.sortingLayerName = "Ground";
                    image.color = new Color(1 - c, 1 - m, 1 - y)
                        //.WithAlpha(0.8f)
                        ;
                    image.raycastTarget = false;
                }
            }
        }
    }
    

    // Fix loading into battle
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.LoadRoutine))]
    public static void BattleLoaded(BattleSaveSystem __instance)
    {
        instance?.BattleStart();

        CardSlotLane[] array1 = References.Battle.GetRows(References.Battle.player).Cast<CardSlotLane>().ToArray();
        WhyAreTheseNotLists(array1, ref __instance.state.playerRows.containers);
        CardSlotLane[] array2 = References.Battle.GetRows(References.Battle.enemy).Cast<CardSlotLane>().ToArray();
        WhyAreTheseNotLists(array2, ref __instance.state.enemyRows.containers);
    }

    //[HarmonyPrefix]
    //[HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.CreateCardsInRows))]
    public static void WhyAreTheseNotLists(CardSlotLane[] rows, ref BattleSaveData.Container[] rowSaveDatas)
    {
        if (rowSaveDatas.Length >= rows.Length) // We _should_ try to push these into the empty spaces if possible instead of deleting them...
            return;

        var newSaveDatas = new List<BattleSaveData.Container>();
        foreach (var row in rowSaveDatas) 
            newSaveDatas.Add(row);
        for (int i = rowSaveDatas.Length; i < rows.Length; i++)
        {
            newSaveDatas.Add(new BattleSaveData.Container() { cards = new BattleEntityData[0] });
        }

        rowSaveDatas = newSaveDatas.ToArray();
    }

    // Fix counter issues
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Battle), nameof(Battle.GetCardsOnBoard), typeof(Character))]
    public static bool GetCardsOnBoard(ref List<Entity> __result, Character character)
    {
        List<Entity> cardsOnBoard = new List<Entity>();
        int rowCount = Battle.instance.rowCount;
        int slotCount = Battle.instance.allRows.Min(row => row.slots.Count);
        for (int index = 0; index < slotCount; ++index)
        {
            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                if (Battle.instance.GetRow(character, rowIndex) is CardSlotLane row)
                {
                    Entity top = row.slots[index].GetTop();
                    if (top != null && !cardsOnBoard.Contains(top))
                        cardsOnBoard.Add(top);
                }
            }
        }
        __result = cardsOnBoard;
        return false; // this is bad practice to always return false...
    }

    // Fix tall cards deploying issue
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Battle), nameof(Battle.CanDeploy))]
    public static bool CanDeploy(ref bool __result, Battle __instance, Entity entity, int targetRow)
    {
        if (entity && targetRow + entity.height > __instance.rowCount)
        {
            //Debug.LogError($"[Bigger Board] {entity} tried to quantum-position itself on row {targetRow} loser");
            __result = false;
            return false;
        }

        return true;
    }


    [HarmonyPatch]
    public static class PatchBombard
    {
        public static AbilityTargetSystem system;

        // Fix bombard
        [HarmonyPostfix]
        [HarmonyPatch(typeof(AbilityTargetSystem), nameof(AbilityTargetSystem.AddTarget))]
        public static void AddTarget(AbilityTargetSystem __instance)
        {
            system = __instance;
        }
        // Fix bombard
        [HarmonyPostfix]
        [HarmonyPatch(typeof(AbilityTargetSystem), nameof(AbilityTargetSystem.Clear))]
        public static void Clear(AbilityTargetSystem __instance)
        {
            system = null;
        }
    }
}

