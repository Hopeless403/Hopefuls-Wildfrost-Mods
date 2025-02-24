using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using static Rewired.Utils.Classes.Data.TypeWrapper;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public static bool OutOfBattleAddEffect(ref CardData.StatusEffectStacks[] effectStacks, StatusEffectData statusData, int count)
        {
            Entity target = Console.hover;
            bool flag = false;
            if (Console.hover && !Console.hover.enabled && Campaign.instance && !Battle.instance)
            {
                var existingTrait = effectStacks.FirstOrDefault(t => t.data == statusData);
                if (existingTrait?.data)
                    existingTrait.count += count;
                else
                {
                    existingTrait = new CardData.StatusEffectStacks()
                    {
                        data = statusData,
                        count = count
                    };
                    effectStacks = effectStacks.With(existingTrait);
                }
                if (existingTrait.count <= 0)
                {
                    Debug.Log(("> [" + target.name + " " + existingTrait.data.name + "] Removed!"));
                    effectStacks = effectStacks.Without(existingTrait);
                }
                flag = true;
                SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "data", Campaign.instance.Save());
            }
            return flag;
        }
        public static bool OutOfBattleAddTrait(ref List<CardData.TraitStacks> traitStacks, TraitData traitData, int count)
        {
            bool flag = false;
            Entity target = Console.hover;
            if (Console.hover && !Console.hover.enabled && Campaign.instance && !Battle.instance)
            {
                var existingTrait = traitStacks.FirstOrDefault(t => t.data == traitData);
                if (existingTrait?.data)
                    existingTrait.count += count;
                else
                {
                    existingTrait = new CardData.TraitStacks()
                    {
                        data = traitData,
                        count = count
                    };
                    target.data.traits.Add(existingTrait);
                }
                if (existingTrait.count <= 0)
                {
                    Debug.Log(("> [" + target.name + " " + existingTrait.data.name + "] Removed! Removing effects [" + string.Join<StatusEffectData>(", ", (IEnumerable<StatusEffectData>)existingTrait.data.effects) + "]"));
                    target.data.traits.Remove(existingTrait);
                }
                flag = true;
                SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "data", Campaign.instance.Save());
            }
            return flag;
        }

        public class CommandAddTrait : Console.Command
        {
            public override string id => "add trait";

            public override string format => "add trait <name>";

            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                if (args.Length > 0)
                {
                    if (Console.hover != null)
                    {
                        if (References.Player == null)
                            this.Fail("Must be in a campaign to use this command");
                        else if (Console.hover.enabled || (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf))
                        {
                            TraitData traitData = null;
                            Entity target = Console.hover;
                            string[] strArray = Split(args);
                            string traitName = string.Join(" ", strArray);
                            int count = 1;
                            if (!AddressableLoader.IsGroupLoaded("TraitData")) yield return AddressableLoader.LoadGroup("TraitData");
                            IEnumerable<TraitData> source = AddressableLoader.GetGroup<TraitData>("TraitData").Where(a => string.Equals(a.name, traitName, StringComparison.CurrentCultureIgnoreCase));
                            if (source.Any())
                                traitData = source.First();
                            else if (strArray.Length > 1 && int.TryParse(strArray.Last(), out count))
                            {
                                traitName = string.Join(" ", strArray.RangeSubset(0, strArray.Length - 1));
                                source = AddressableLoader.GetGroup<TraitData>("TraitData").Where(a => string.Equals(a.name, traitName, StringComparison.CurrentCultureIgnoreCase));
                                if (source.Any())
                                    traitData = source.First();
                            }
                            if (traitData != null)
                            {
                                target.GainTrait(traitData, count);
                                yield return target.UpdateTraits();
                                target.display.promptUpdateDescription = true;
                                target.PromptUpdate();
                                if (OutOfBattleAddTrait(ref target.data.traits, traitData, count))
                                    yield return target.display.UpdateDisplay();
                            }
                            else Fail("Trait [" + traitName + "] does not exist!");
                        }
                        else Fail("Cannot use on that card");
                    }
                    else Fail("Please hover over a card to use this command");
                }
                else Fail("You must provide a Trait name");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("TraitData")) yield return AddressableLoader.LoadGroup("TraitData");
                IEnumerable<TraitData> source = AddressableLoader.GetGroup<TraitData>("TraitData").Where(data =>
                {
                    string title = data.keyword?.title;
                    return data.name.ToLower().Contains(currentArgs.ToLower()) || (title?.ToLower().Contains(currentArgs.ToLower()) ?? false);
                });

                predictedArgs = source.Select(data =>
                {
                    string title = data.keyword?.title;
                    if (!title.IsNullOrEmpty()) return $"{data.name} \t// {title}";
                    else return $"{data.name}";
                }).ToArray();
            }
        }
        public class CommandAddStatus : ConsoleCustom.Command
        {
            public override string id => "add status";
            public override string format => "add status <name>";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                args = args.Trim();
                if (args.Length > 0)
                {
                    if (Console.hover != null)
                    {
                        if (References.Player == null)
                            this.Fail("Must be in a campaign to use this command");
                        else if (Console.hover.enabled || (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf))
                        {
                            StatusEffectData statusData = null;
                            Entity applier = CardManager.Get(AddressableLoader.groups["CardData"].lookup["Junk"] as CardData, null, References.Player, false, false).entity;
                            Entity target = Console.hover;
                            string[] strArray = Split(args);
                            int count = 1;
                            string statusName = string.Join(" ", strArray);
                            if (!AddressableLoader.IsGroupLoaded("StatusEffectData")) yield return AddressableLoader.LoadGroup("StatusEffectData");
                            IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => a.visible && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase));
                            if (source.Any())
                                statusData = source.First();
                            else if (strArray.Length > 1 && int.TryParse(strArray.Last(), out count))
                            {
                                statusName = string.Join(" ", strArray.RangeSubset(0, strArray.Length - 1));
                                source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => a.visible && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase));
                                if (source.Any())
                                    statusData = source.First();
                            }
                            if (statusData != null)
                            {
                                yield return StatusEffectSystem.Apply(Console.hover, applier, statusData, count, applyEvenIfZero: true);
                                target.statusEffects.RemoveAllWhere(s => s.count <= 0);
                                target.display.promptUpdateDescription = true;
                                target.PromptUpdate();
                                if (OutOfBattleAddEffect(ref target.data.startWithEffects, statusData, count))
                                    yield return target.display.UpdateDisplay();
                            }
                            else Fail("StatusEffect [" + statusName + "] does not exist!");
                        }
                        else Fail("Cannot use on that card");
                    }
                    else Fail("Please hover over a card to use this command");
                }
                else Fail("You must provide a StatusEffect name");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("StatusEffectData")) yield return AddressableLoader.LoadGroup("StatusEffectData");
                IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => a.visible && a.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.Select(statusData => statusData.name).ToArray();
            }
        }
        public class CommandAddEffect : Console.Command
        {
            public override string id => "add effect";
            public override string format => "add effect <name>";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                args = args.Trim();
                if (args.Length > 0)
                {
                    if (Console.hover != null)
                    {
                        if (References.Player == null)
                            this.Fail("Must be in a campaign to use this command");
                        else if (Console.hover.enabled || (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf))
                        {
                            StatusEffectData statusData = null;
                            Entity applier = CardManager.Get(AddressableLoader.groups["CardData"].lookup["Junk"] as CardData, null, References.Player, false, false).entity;
                            Entity target = Console.hover;
                            string[] strArray = Split(args);
                            int count = 1;
                            string statusName = string.Join(" ", strArray);
                            if (!AddressableLoader.IsGroupLoaded("StatusEffectData")) yield return AddressableLoader.LoadGroup("StatusEffectData");
                            IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => !a.visible && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase));
                            if (source.Any())
                                statusData = source.First();
                            else if (strArray.Length > 1 && int.TryParse(strArray.Last(), out count))
                            {
                                statusName = string.Join(" ", strArray.RangeSubset(0, strArray.Length - 1)); 
                                source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => !a.visible && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase));
                                if (source.Any())
                                    statusData = source.First();
                            }
                            if (statusData != null)
                            {
                                yield return StatusEffectSystem.Apply(Console.hover, applier, statusData, count, applyEvenIfZero: true);
                                target.statusEffects.RemoveAllWhere(s => s.count <= 0);
                                target.display.promptUpdateDescription = true;
                                target.PromptUpdate();
                                if (OutOfBattleAddEffect(ref target.data.startWithEffects, statusData, count))
                                    yield return target.display.UpdateDisplay();
                            }
                            else Fail("StatusEffect [" + statusName + "] does not exist!");
                        }
                        else Fail("Cannot use on that card");
                    }
                    else Fail("Please hover over a card to use this command");
                }
                else Fail("You must provide a StatusEffect name");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("StatusEffectData")) yield return AddressableLoader.LoadGroup("StatusEffectData");
                IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => !a.visible && a.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.Select(traitData => traitData.name).ToArray();
            }
        }
        public class CommandAddAttackEffect : Console.Command
        {
            public override string id => "add attackeffect";
            public override string format => "add attackeffect <name>";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                if (args.Length > 0)
                {
                    if (Console.hover != null)
                    {
                        if (References.Player == null)
                            this.Fail("Must be in a campaign to use this command");
                        else if (Console.hover.enabled || (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf))
                        {
                            StatusEffectData statusData = null;
                            Entity applier = CardManager.Get(AddressableLoader.groups["CardData"].lookup["Junk"] as CardData, null, References.Player, false, false).entity;
                            Entity target = Console.hover;
                            string[] strArray = Split(args);
                            int count = 1;
                            string statusName = string.Join(" ", strArray);
                            if (!AddressableLoader.IsGroupLoaded("StatusEffectData")) yield return AddressableLoader.LoadGroup("StatusEffectData");
                            IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => (a is not StatusEffectApplyX || a is StatusEffectApplyXInstant || a.visible) && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase));
                            if (source.Any())
                                statusData = source.First();
                            else if (strArray.Length > 1 && int.TryParse(strArray.Last(), out count))
                            {
                                statusName = string.Join(" ", strArray.RangeSubset(0, strArray.Length - 1));
                                source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => (a is not StatusEffectApplyX || a is StatusEffectApplyXInstant || a.visible) && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase));
                                if (source.Any())
                                    statusData = source.First();
                            }
                            if (statusData != null)
                            {
                                target.attackEffects = CardData.StatusEffectStacks.Stack(target.attackEffects, [new CardData.StatusEffectStacks(statusData, count)]).Select(a => a.Clone()).ToList();
                                Debug.Log($"[{statusData.name} {count}] applied to [{target.name}]");
                                target.attackEffects.RemoveAllWhere(s => s.count <= 0);
                                target.display.promptUpdateDescription = true;
                                target.PromptUpdate();
                                if (OutOfBattleAddEffect(ref target.data.attackEffects, statusData, count))
                                    yield return target.display.UpdateDisplay();
                            }
                            else Fail("StatusEffect [" + statusName + "] does not exist!");
                        }
                        else Fail("Cannot use on that card");
                    }
                    else Fail("Please hover over a card to use this command");
                }
                else Fail("You must provide a StatusEffect name");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("StatusEffectData")) yield return AddressableLoader.LoadGroup("StatusEffectData"); // !a.visible && 
                IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where(a => (a is not StatusEffectApplyX || a is StatusEffectApplyXInstant || a.visible) && a.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.Select(traitData => traitData.name).ToArray();
            }
        }

        public class CommandAddModifier : Console.Command
        {
            public override string id => "add modifier";
            public override string format => "add modifier <name>";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                if (args.Length > 0)
                {
                    if (References.Player == null)
                        this.Fail("Must be in a campaign to use this command");
                    else
                    {
                        if (!AddressableLoader.IsGroupLoaded(nameof(GameModifierData))) yield return AddressableLoader.LoadGroup(nameof(GameModifierData));
                        IEnumerable<GameModifierData> source = AddressableLoader.GetGroup<GameModifierData>(nameof(GameModifierData)).Where(a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase));

                        GameModifierData modifier = null;

                        if (source.Any())
                            modifier = source.First();
                        
                        if (modifier != null)
                        {
                            ModifierSystem.AddModifier(Campaign.Data, modifier);
                            Routine.Clump clump = new Routine.Clump();
                            foreach (Script startScript in modifier.startScripts)
                                clump.Add(startScript.Run());
                            foreach (Script setupScript in modifier.setupScripts)
                                clump.Add(setupScript.Run());
                            foreach (string componentName in modifier.systemsToAdd)
                            {
                                Debug.Log($"[{modifier}] adding system: {componentName}");
                                Campaign.instance.gameObject.AddComponentByName(componentName);
                            }
                        }
                        else Fail($"GameModifierData [{args}] does not exist!");
                    }
                }
                else Fail("You must provide a GameModifier name");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded(nameof(GameModifierData))) yield return AddressableLoader.LoadGroup(nameof(GameModifierData));
                IEnumerable<GameModifierData> source = AddressableLoader.GetGroup<GameModifierData>(nameof(GameModifierData)).Where(a => a.name.ToLower().Contains(currentArgs.ToLower()) 
                || (
                        a.titleKey != null && !a.titleKey.IsEmpty && a.titleKey.GetLocalizedString().ToLower().Contains(currentArgs.ToLower())
                        ));
                predictedArgs = source.Select(data => (data.titleKey != null && !data.titleKey.IsEmpty) 
                ? $"{data.name} \t// {data.titleKey.GetLocalizedString()}" 
                : data.name).ToArray();
            }
        }
    }
}