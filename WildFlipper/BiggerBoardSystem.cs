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
                //newFullRow.transform.localPosition = newFullRow.transform.localPosition.WithZ(1 - 0.5f * References.Battle.rowCount);
                newFullRow.transform.localPosition = newFullRow.transform.localPosition.WithZ(0);

                foreach (var newLane in newFullRow.GetComponentsInChildren<CardSlotLane>())
                {
                    newLane.name = newLane.name.Replace("Row 1", $"Row {References.Battle.rowCount}");
                    newLane.ClearAndDestroyAllImmediately();  // Destroy any cards that somehow start in the row
                    newLane.CreateSlots(newLane.slots.Count);
                    References.Battle.rows[newLane.owner].Add(newLane);
                }
            }
            
            for (int i = 0; i < References.Battle.rowCount; i++)
            {
                float z = (References.Battle.rowCount-i)/(2f*References.Battle.rowCount);
                References.Battle.rows[References.Battle.player][i].transform.parent.LeanSetLocalPosZ(z);
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

        float middleSpace = 1;
        float slotLength = 2;
        float slotSpacing = 0.6f;
        float rowHeight = 3f;
        float rowLength = 7.2f;

        if (!tryResizing) // Mainly for a nice "crowded" screenshot
        {
            // BoardHeight = RowHeight * RowCount + Spacing * (RowCount - 1);
            float spacing = 0;
            if (References.Battle.rowCount > 1)
                spacing = -rowHeight + (boardHeight - rowHeight) / (References.Battle.rowCount - 1);
            if (rows.TryGetComponent<VerticalLayoutGroup>(out var group1))
                group1.spacing = spacing;

            spacing = 0;
            if (targetSlotCount > 1)
                spacing = -slotLength + (rowLength - slotLength) / (targetSlotCount - 1);
            foreach (var row in Battle.instance.allRows) 
                if (row.TryGetComponent<CardSlotLane>(out var lane))
                {
                    //lane.slots.Do(slot => slot.rectTransform.sizeDelta = slot.rectTransform.sizeDelta.WithX(slotLength+spacing));
                    lane.layout.spacing = spacing;
                }
        }
        else if (rows.TryGetComponent<VerticalLayoutGroup>(out var layout))
        {
            // Assuming every row has the same slot count!
            // If some are different, rowLength needs to be calculated separately.
            rowLength = slotLength * targetSlotCount + slotSpacing * (targetSlotCount - 1);
            foreach (var row in Battle.instance.allRows)
                row.rectTransform.sizeDelta = new Vector3(rowLength, rowHeight);

            float targetSpacing = 0.7f;
            float targetScale = Mathf.Min(
                boardHeight / (rowHeight * References.Battle.rowCount + targetSpacing * (References.Battle.rowCount - 1)),
                boardLength / (2f * rowLength + middleSpace)
                );
            rows.localScale = targetScale * Vector3.one;
            layout.spacing = targetSpacing;
        }

        // Auto-adjust row positions and board bounds
        if (rows.TryGetComponent<VerticalLayoutGroup>(out var group)) group.enabled = true;
        if (rows.TryGetComponent<ContentSizeFitter>(out var fitter)) fitter.enabled = true;
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
        if (Campaign.instance && tryResizing)
        {
            if (PatchTargets.abilityTargetSystem)
                foreach (var target in PatchTargets.abilityTargetSystem.currentTargets)
                {
                    target.Value.transform.position = target.Key.transform.position;
                    target.Value.transform.localScale = target.Key.transform.lossyScale;
                }
            if (PatchTargets.unitTargetSystem)
            {
                var scale = References.Battle?.allSlots.FirstOrDefault()?.transform.lossyScale ?? Vector3.one;
                foreach (var target in PatchTargets.unitTargetSystem.targets)
                {
                    target.transform.localScale = scale.x * PatchTargets.unitTargetSystem.targetPrefab.transform.localScale;
                }
            }
            if (PatchTargets.targetingArrowSystem)
            {
                var scale = References.Battle?.allSlots.FirstOrDefault()?.transform.lossyScale ?? Vector3.one;
                var arrow = PatchTargets.targetingArrowSystem.currentArrow as TargetingArrow;
                if (arrow) arrow.head.transform.localScale = scale;
            }
        }
    }

    private void DebugColours()
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

                    var colour = new GameObject(new Color(1-c,1-m,1-y).ToHexRGBA(), typeof(Image), typeof(Canvas), typeof(CopyRectTransform));
                    colour.transform.SetParent(slot.transform);
                    colour.transform.localScale = Vector3.one;
                    colour.GetOrAdd<CopyRectTransform>().target = slot.rectTransform;
                    colour.GetOrAdd<CopyRectTransform>().copySize = true;
                    colour.GetOrAdd<CopyRectTransform>().copyScale = false;
                    colour.GetOrAdd<Canvas>().overrideSorting = true;
                    colour.GetOrAdd<Canvas>().sortingLayerName = "Shadows";
                    var image = colour.GetOrAdd<Image>();
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
    public static class PatchTargets
    {
        public static AbilityTargetSystem abilityTargetSystem;
        public static UnitTargetSystem unitTargetSystem;
        public static TargetingArrowSystem targetingArrowSystem;

        // Fix bombard
        [HarmonyPostfix]
        [HarmonyPatch(typeof(AbilityTargetSystem), nameof(AbilityTargetSystem.AddTarget))]
        public static void AddTarget(AbilityTargetSystem __instance)
        {
            abilityTargetSystem = __instance;
        }
        // Fix bombard
        [HarmonyPostfix]
        [HarmonyPatch(typeof(AbilityTargetSystem), nameof(AbilityTargetSystem.Clear))]
        public static void Clear(AbilityTargetSystem __instance)
        {
            if (__instance.currentTargets?.Count <= 0)
                abilityTargetSystem = null;
        }
        // Fix units
        [HarmonyPostfix]
        [HarmonyPatch(typeof(UnitTargetSystem), nameof(UnitTargetSystem.ShowTargets))]
        public static void ShowTargets(UnitTargetSystem __instance)
        {
            unitTargetSystem = __instance;
        }
        // Fix units
        [HarmonyPostfix]
        [HarmonyPatch(typeof(UnitTargetSystem), nameof(UnitTargetSystem.HideTargets))]
        public static void Clear(UnitTargetSystem __instance)
        {
            if (__instance.targets?.Count <= 0)
                unitTargetSystem = null;
        }

        // Fix units
        [HarmonyPostfix]
        [HarmonyPatch(typeof(TargetingArrowSystem), nameof(TargetingArrowSystem.Show))]
        public static void ShowTargets(TargetingArrowSystem __instance)
        {
            targetingArrowSystem = __instance;
        }
        // Fix units
        [HarmonyPostfix]
        [HarmonyPatch(typeof(TargetingArrowSystem), nameof(TargetingArrowSystem.Hide))]
        public static void Clear(TargetingArrowSystem __instance)
        {
            targetingArrowSystem = null;
        }
    }
}

