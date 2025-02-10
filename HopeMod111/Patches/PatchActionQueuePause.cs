using HarmonyLib;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
using static LayoutFixer;
using static WildfrostHopeMod.CommandsConsole.ConsoleCustom;
using static WildfrostHopeMod.CommandsConsole.ConsoleMod.Patches;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        internal class CommandToggleBreakpoint : Console.CommandOptions
        {
            internal static bool active = false;
            //internal static bool promptStep = false;
            internal static bool paused = false;
            public override string id => "breakpoint";
            public override string[] options => ["on", "step", "off"];
            public override string desc => "(WIP) set gamespeed to 0 on ActionQueue changed";
            public override void Run(string args)
            {
                switch (args.ToLower())
                {
                    case "on":
                        active = true;
                        Settings.Save<bool>("ShowFps", true);
                        break;
                    case "off":
                        active = false;
                        break;
                    case "step":
                        paused = false;
                        break;
                    default:
                        this.Fail("You must enter either 'on', 'off', or 'step'");
                        break;
                }
            }

            [HarmonyPatch]
            internal class PatchActionQueuePause
            {
                [HarmonyPostfix]
                [HarmonyPatch(typeof(ActionQueue), nameof(ActionQueue.PerformAction))]
                static IEnumerator PerformAction(IEnumerator __result)
                {
                    if (active)
                    {
                        Events.InvokeTimeScaleChange(0);
                        paused = true;
                        Events.OnTimeScaleChange += OnTimeScaleChange;
                        yield return new WaitUntil(() => !paused || !active || !debug);
                        Events.InvokeTimeScaleChange(1);
                        Events.OnTimeScaleChange -= OnTimeScaleChange;
                    }
                    yield return __result;
                }
                static void OnTimeScaleChange(float f) => paused = false;

                [HarmonyPostfix]
                [HarmonyPatch(typeof(ActionQueue), nameof(ActionQueue.PostAction))]
                static IEnumerator PostAction(IEnumerator __result)
                {
                    yield return __result;
                    if (active)
                    {
                        Events.InvokeTimeScaleChange(0);
                        paused = true;
                        Events.OnTimeScaleChange += OnTimeScaleChange;
                        yield return new WaitUntil(() => !paused || !active || !debug);
                        Events.InvokeTimeScaleChange(1);
                        Events.OnTimeScaleChange -= OnTimeScaleChange;
                    }
                }
            }
        }
    }

    public partial class ConsoleMod
    {
        public partial class Patches
        {

            [HarmonyPatch(typeof(FpsDrawer), nameof(FpsDrawer.Update))]
            internal class PatchFpsDrawer
            {
                static void Postfix(FpsDrawer __instance)
                {
                    StringBuilder actionText = new("ActionQueue: ");
                    actionText.AppendLine("Length = " + ActionQueue.instance.queue.Count);
                    foreach (var action in ActionQueue.instance.queue)
                    {
                        if (action.note.IsEmpty())
                            action.note = NotePerType(action);
                        actionText.AppendLine(action.Name);
                    }

                    if (CommandToggleBreakpoint.paused)
                        __instance.fpsText.text += "\nRemember to use `breakpoint step` or `breakpoint off`\n" + actionText;
                    else
                        __instance.fpsText.text += "\nHide with `fps off`\n" + actionText;
                }

            }

            static string TextPerType(PlayAction action)
            {
                switch (action.GetType().Name)
                {
                    case nameof(ActionApplyStatus):
                        var actionApplyStatus = action as ActionApplyStatus;
                        return $"""
                            |   [{actionApplyStatus.applier?.name}] applies
                            |   {actionApplyStatus.stacks} [{actionApplyStatus.status}]
                            |   to: {actionApplyStatus.target?.name}
                            |   temporary? {actionApplyStatus.temporary}
                            """;
                    case nameof(ActionChangePhase):
                        var actionChangePhase = action as ActionChangePhase;
                        bool multipleNewPhases = actionChangePhase.newPhases?.Length > 0;
                        return $"""
                            |   {actionChangePhase.entity?.name} change to
                            |   {(multipleNewPhases ? "one of " + actionChangePhase.newPhases.Select(c => c.name).Join() : actionChangePhase.newPhase.name)}
                            """;
                    case nameof(ActionCombine):
                        var actionCombine = action as ActionCombine;
                        return $"""
                            |   [{actionCombine.entities.Select(e => e?.name).Join()}] combine into
                            |   {actionCombine.finalEntity.name}
                            """;
                    case nameof(ActionConsume):
                        var actionConsume = action as ActionConsume;
                        return $"""
                            |   {actionConsume.target.name}
                            """;
                    case nameof(ActionDiscardEffect):
                        var actionDiscardEffect = action as ActionDiscardEffect;
                        return $"""
                            |   {actionDiscardEffect.target.name}
                            |   heal: {actionDiscardEffect.healAmount}
                            """;
                    case nameof(ActionDraw):
                        var actionDraw = action as ActionDraw;
                        return $"""
                            |   [{actionDraw.character?.name}] draws
                            |   [{actionDraw.count}] cards
                            """;
                    case nameof(ActionDrawHand):
                        var actionDrawHand = action as ActionDrawHand;
                        return $"""
                            |   [{actionDrawHand.character.name}] draws
                            |   to full hand size ({actionDrawHand.character.handContainer.max - actionDrawHand.character.handContainer.Count})
                            """;
                    case nameof(ActionEarlyDeploy):
                        var actionEarlyDeploy = action as ActionEarlyDeploy;
                        return $"""
                            |   transform: [{actionEarlyDeploy.transform}]
                            |   routine: [{actionEarlyDeploy.earlyDeployRoutine}]
                            """;
                    case nameof(ActionEffectApply):
                        var actionEffectApply = action as ActionEffectApply;
                        return $"""
                            |   [{actionEffectApply.effect}] applies to
                            |   {actionEffectApply.sequences.Join(delimiter: "\n|   ")}
                            """;
                    case nameof(ActionEndTurn):
                        return $"""
                            |   {((ActionEndTurn)action).character}
                            """;
                    case nameof(ActionFlee):
                        return $"""
                            |   {((ActionFlee)action).entity?.name}
                            """;
                    case nameof(ActionInspect):
                        return $"""
                            |   {((ActionInspect)action).entity?.name}
                            """;
                    case nameof(ActionKill):
                        return $"""
                            |   {((ActionKill)action).entity?.name}
                            """;
                    case nameof(ActionMove):
                        var actionMove = action as ActionMove;
                        return $"""
                            |   {actionMove.entity?.name}
                            |   to: {actionMove.toContainers.Join()}
                            """;
                    case nameof(ActionProcessTrigger):
                        var actionProcessTrigger = action as ActionProcessTrigger;
                        var trigger = actionProcessTrigger.trigger ?? actionProcessTrigger.GetTriggerMethod();
                        if (trigger == null)
                            return "";
                        return $"""
                            |   {trigger.entity?.name}
                            """;
                    case nameof(ActionRedraw):
                        var actionRedraw = action as ActionRedraw;
                        return $"""
                            |   [{actionRedraw.character?.name}] redraws
                            |   [{(actionRedraw.drawCount < 0 ? "hand" : actionRedraw.drawCount + " cards")}]
                            """;
                    case nameof(ActionReduceUses):
                        var actionReduceUses = action as ActionReduceUses;
                        return $"""
                            |   {actionReduceUses.entity?.name}
                            |   will run? {actionReduceUses.entity.uses.max > 0 && actionReduceUses.entity.uses.current > 0}
                            """;
                    case nameof(ActionRefreshWhileActiveEffect):
                        var actionRefreshWhileActiveEffect = action as ActionRefreshWhileActiveEffect;
                        return $"""
                            |   {actionRefreshWhileActiveEffect.effect?.name}
                            |   ({actionRefreshWhileActiveEffect.effect?.applier.name})
                            """;
                    case nameof(ActionReveal):
                        var actionReveal = action as ActionReveal;
                        return $"""
                            |   {actionReveal.entity?.name}
                            |   pause: {actionReveal.pauseAfter}
                            """;
                    case nameof(ActionRunEnableEvent):
                        return $"""
                            |   {((ActionRunEnableEvent)action).entity?.name}
                            """;
                    case nameof(ActionSelect):
                        return $"""
                            |   {((ActionSelect)action).entity?.name}
                            |   action on select: {((ActionSelect)action).action}
                            """;
                    case nameof(ActionShove):
                        var actionShove = action as ActionShove;
                        return $"""
                            |   {actionShove.shoveData.Select(data => $"[{data.Key}] shoved to [{data.Value.Join()}]").Join(delimiter: "\n|   ")}
                            """;
                    case nameof(ActionTrigger):
                        var actionTrigger = action as ActionTrigger;
                        string result = $"""
                                |   {actionTrigger.entity?.name}
                                """;
                        if (actionTrigger.triggeredBy != null)
                            result += $"""
                                |   {actionTrigger.triggeredBy?.name}
                                """;
                        result += $"""
                            triggerType = {actionTrigger.triggerType}
                            """;
                        return result;
                    default:
                        return "";
                };
            }
            static string NotePerType(PlayAction action)
            {
                switch (action.GetType().Name)
                {
                    case nameof(ActionApplyStatus):
                        return $"{((ActionApplyStatus)action).applier?.name} → [{((ActionApplyStatus)action).status} {((ActionApplyStatus)action).stacks}] ({((ActionApplyStatus)action).target?.name})";
                    case nameof(ActionEarlyDeploy):
                        return ((ActionEarlyDeploy)action).transform.name;
                    case nameof(ActionEffectApply):
                        return $"{((ActionEffectApply)action).effect} → {((ActionEffectApply)action).sequences.Join()}";
                    case nameof(ActionChangePhase):
                        return $"{((ActionChangePhase)action).entity?.name} → {(
                            ((ActionChangePhase)action).newPhases?.Length > 0 
                            ? ((ActionChangePhase)action).newPhases.Select(c => c.name).Join()
                            : ((ActionChangePhase)action).newPhase.name
                            )}";
                    case nameof(ActionCombine):
                        return $"Combine: [{((ActionCombine)action).entities.Select(e => e?.name).Join()}] → {((ActionCombine)action).finalEntity.name}";
                    case nameof(ActionConsume):
                        return ((ActionConsume)action).target?.name ?? "NULL";
                    case nameof(ActionDiscardEffect):
                        return $"{((ActionDiscardEffect)action).target?.name ?? "NULL"} (heal {((ActionDiscardEffect)action).healAmount})";
                    case nameof(ActionDraw):
                        return $"{((ActionDraw)action).character.name} ({((ActionDraw)action).count} cards)";
                    case nameof(ActionDrawHand):
                        return $"{((ActionDrawHand)action).character.name} ({((ActionDrawHand)action).character.handContainer.max - ((ActionDrawHand)action).character.handContainer.Count})";
                    case nameof(ActionEndTurn):
                        return ((ActionEndTurn)action).character.name;
                    case nameof(ActionFlee):
                        return ((ActionFlee)action).entity?.name ?? "NULL";
                    case nameof(ActionInspect):
                        return ((ActionInspect)action).entity?.name ?? "NULL";
                    case nameof(ActionKill):
                        return ((ActionKill)action).entity?.name ?? "NULL"; 
                    case nameof(ActionRunEnableEvent):
                        return ((ActionRunEnableEvent)action).entity?.name ?? "NULL";
                    case nameof(ActionMove):
                        return $"{((ActionMove)action).entity?.name} → {((ActionMove)action).toContainers.Select(c => c.name).Join()}";
                    case nameof(ActionShove):
                        return $"{((ActionShove)action).shoveData.Select(data => $"{data.Key.name} → [{data.Value.Select(c => c.name).Join()}]").Join()}]";
                    case nameof(ActionRedraw):
                        return $"{((ActionRedraw)action).character.name} ({(((ActionRedraw)action).drawCount < 0 ? "hand"
                            : ((ActionRedraw)action).drawCount + " cards")})";
                    case nameof(ActionReduceUses):
                        return $"{((ActionReduceUses)action).entity?.name ?? "NULL"} (run? {((ActionReduceUses)action).entity.uses.max > 0 && ((ActionReduceUses)action).entity.uses.current > 0})";
                    case nameof(ActionResetOffset):
                        return ((ActionResetOffset)action).entity?.name ?? "NULL";
                    case nameof(ActionReveal):
                        return $"{((ActionReveal)action).entity?.name ?? "NULL"}";// ({((ActionReveal)action).pauseAfter}s)";
                    case nameof(ActionSelect):
                        return (((ActionSelect)action).entity?.name ?? "NULL") + (((ActionSelect)action).action == null ? "" : " (has action)");
                    case nameof(ActionProcessTrigger):
                        var actionProcessTrigger = action as ActionProcessTrigger;
                        var trigger = actionProcessTrigger.trigger ?? actionProcessTrigger.GetTriggerMethod();
                        return trigger.entity?.name ?? "NULL";
                    case nameof(ActionRefreshWhileActiveEffect):
                        return $"{((ActionRefreshWhileActiveEffect)action).effect?.name} ({((ActionRefreshWhileActiveEffect)action).effect?.applier?.name ?? "NULL"})";
                    case nameof(ActionTrigger):
                        return $"{((ActionTrigger)action).entity?.name ?? "NULL"} ({((ActionTrigger)action).triggerType})";
                    case nameof(ActionTriggerAgainst):
                        return $"{((ActionTriggerAgainst)action).entity?.name ?? "NULL"} vs {((ActionTriggerAgainst)action).target?.name ?? "NULL"}";
                    case nameof(ActionTriggerByCounter):
                        return ((ActionTriggerByCounter)action).entity?.name ?? "NULL";
                    case nameof(ActionTriggerSubsequent):
                        return $"{((ActionTriggerSubsequent)action).triggeredBy?.name ?? "NULL"} → [{((ActionTriggerSubsequent)action).entity?.name ?? "NULL"}] ({((ActionTriggerSubsequent)action).triggerType})";
                    default:
                        return "";
                };
            }

            [HarmonyPatch(typeof(FpsDrawer), nameof(FpsDrawer.Awake))]
            [HarmonyPatch(typeof(FpsDrawer), nameof(FpsDrawer.SettingChanged))]
            public class PatchTrackFpsDrawer
            {
                public static bool active = false;
                static void Postfix(FpsDrawer __instance)
                    => active = __instance.gameObject.activeSelf;
            }


            [HarmonyPatch(typeof(ActionQueue), nameof(ActionQueue.Insert))]
            internal class PatchActionQueueLogger
            {
                static void Postfix(PlayAction action)
                {
                    if (PatchTrackFpsDrawer.active)
                    {
                        var s = NotePerType(action);
                        if (action.note.IsEmpty())
                        {
                            action.note = s;
                            Debug.LogWarning(action.Name);
                        }
                        else
                            Debug.LogWarning(action.Name + (s.IsEmpty() ? "" : "\n" + s));
                    }
                }
            }
        }
    }
}