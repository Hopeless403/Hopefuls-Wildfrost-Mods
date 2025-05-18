using System.Collections;
using System.Linq;
using UnityEngine;
using System.Collections.Generic;
using System;
using static EventRoutineCharmShop;
using HarmonyLib;
using ICSharpCode.Decompiler.Documentation;
using System.Runtime.InteropServices.ComTypes;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public static List<ChallengeData> GetActiveChallenges()
        {
            List<string> completedChallenges = SaveSystem.LoadProgressData("completedChallenges", (List<string>)null) ?? new List<string>();
            var activeChallenges = new List<ChallengeData>();
            foreach (ChallengeData allChallenge in ChallengeSystem.GetAllChallenges())
            {
                if (!completedChallenges.Contains(allChallenge.name))
                {
                    bool requirementsCompleted = true;
                    foreach (ChallengeData require in allChallenge.requires)
                    {
                        if (!completedChallenges.Contains(require.name))
                        {
                            requirementsCompleted = false;
                            break;
                        }
                    }
                    if (requirementsCompleted)
                        activeChallenges.Add(allChallenge);
                }
            }
            return activeChallenges;
        }
        public class CommandProgressSet : Console.Command
        {
            public override string id => "progress set";
            public override string format => "progress set <challenge> <count>";
            public override string desc => "a challenge's value";

            public override void Run(string args)
            {
                if (!ChallengeProgressSystem.instance)
                {
                    Fail("Must be in a campaign to use this command");
                    return;
                }


                ChallengeData challenge = null;
                string[] strArray = Split(args);
                int count = 1;

                string challengeName = string.Join(" ", strArray);
                var source = GetActiveChallenges().Where(c => string.Equals(c.name, args, StringComparison.CurrentCultureIgnoreCase));

                if (source.Any())
                    challenge = source.First();
                else if (strArray.Length > 1 && int.TryParse(strArray.Last(), out count))
                {
                    challengeName = string.Join(" ", strArray.RangeSubset(0, strArray.Length - 1));
                    source = GetActiveChallenges().Where(c => string.Equals(c.name, challengeName, StringComparison.CurrentCultureIgnoreCase));

                    if (source.Any())
                        challenge = source.First();
                }
                
                if (challenge == null)
                {
                    Fail($"Challenge [{args}] does not exist!");
                    return;
                }

                challengeName = challenge.name;
                if (challenge.listener?.checkType != ChallengeListener.CheckType.MidRun)
                {
                    Fail("This ChallengeListener is not supported");
                    return;
                }

                challenge.listener.Set(challenge.name, ChallengeProgressSystem.GetProgress(challenge.name), count); 
                ChallengeProgressSystem.instance.saveRequired = true;
                ChallengeProgressSystem.instance.CheckSave();
                Events.InvokeOverallStatsSaved(OverallStatsSystem.Get());
                Campaign.PromptSave();
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                var source = GetActiveChallenges().Where(c => c.listener?.checkType == ChallengeListener.CheckType.MidRun && c.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source?.Select(challenge => challenge.name).ToArray() ?? [];
                yield break;
            }

            
        }

        public class CommandProgressReset : ConsoleCustom.Command
        {
            public override string id => "progress reset";
            public override string format => "progress reset <challenge>";

            public override void Run(string args)
            {
                if (!ChallengeProgressSystem.instance)
                {
                    Fail("Must be in a campaign to use this command");
                    return;
                }

                ChallengeData challenge = null;
                var source = GetActiveChallenges().Where(c => string.Equals(c.name, args, StringComparison.CurrentCultureIgnoreCase));

                if (source.Any())
                    challenge = source.First();

                if (challenge == null)
                {
                    Fail($"Challenge [{args}] does not exist!");
                    return;
                }

                if (challenge.listener?.checkType != ChallengeListener.CheckType.MidRun)
                {
                    Fail("This ChallengeListener is not supported");
                    return;
                }

                challenge.listener.Set(challenge.name, ChallengeProgressSystem.GetProgress(challenge.name), 0);
                ChallengeProgressSystem.instance.progress.RemoveWhere(p => p.challengeName == challenge.name);
                ChallengeProgressSystem.instance.saveRequired = true;
                ChallengeProgressSystem.instance.CheckSave();
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                var source = GetActiveChallenges().Where(c => c.listener?.checkType == ChallengeListener.CheckType.MidRun && c.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source?.Select(challenge => challenge.name).ToArray() ?? [];
                yield break;
            }

        }



        public class CommandProgressComplete : Console.Command
        {
            public override string id => "progress complete";
            public override string format => "progress complete <challenge>";

            public override void Run(string args)
            {
                //string challengeName = string.Join(" ", strArray);
                var source = GetActiveChallenges().Where(c => string.Equals(c.name, args, StringComparison.CurrentCultureIgnoreCase));

                if (!source.Any())
                {
                    Fail($"Uncompleted Challenge [{args}] does not exist!");
                    return;
                }
                ChallengeData challengeData = source.First();
                if (!challengeData.reward)
                {
                    Fail($"Challenge [{args}] has no unlockable reward!");
                    return;
                }

                List<string> completedChallenges = SaveSystem.LoadProgressData<List<string>>("completedChallenges", null) ?? new List<string>();
                List<string> townNew = SaveSystem.LoadProgressData<List<string>>("townNew", null) ?? new List<string>();
                List<string> unlocked = SaveSystem.LoadProgressData<List<string>>("unlocked", null) ?? new List<string>();

                completedChallenges.Add(challengeData.name);
                townNew.Add(challengeData.reward.name);
                unlocked.Add(challengeData.reward.name);
                Events.InvokeChallengeCompletedSaved(challengeData);

                SaveSystem.SaveProgressData<List<string>>("completedChallenges", completedChallenges);
                SaveSystem.SaveProgressData<List<string>>("townNew", townNew);
                SaveSystem.SaveProgressData<List<string>>("unlocked", unlocked);
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                var source = GetActiveChallenges().Where(c => c.listener?.checkType == ChallengeListener.CheckType.MidRun && c.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source?.Select(challenge => challenge.name).ToArray() ?? [];
                yield break;
            }

        }



        public class CommandProgressUncomplete : Console.Command
        {
            public override string id => "progress uncomplete";
            public override string format => "progress uncomplete <challenge>";

            public override void Run(string args)
            {
                var sourceUnlocked = SaveSystem.LoadProgressData<List<string>>("unlocked", []);
                if (!sourceUnlocked.Where(s => string.Equals(s, args, StringComparison.CurrentCultureIgnoreCase)).Any())
                {
                    Fail($"Completed Challenge [{args}] does not exist!");
                    return;
                }
                string unlockName = sourceUnlocked.Where(s => string.Equals(s, args, StringComparison.CurrentCultureIgnoreCase)).First();

                var sourceChallenge = SaveSystem.LoadProgressData<List<string>>("completedChallenges", []);
                ChallengeData challenge = sourceChallenge.Select(s => AddressableLoader.Get<ChallengeData>(nameof(ChallengeData), s)).FirstOrDefault(s => s?.reward.name == unlockName);

                if (!challenge)
                {
                    Fail($"Completed Challenge [{args}] does not exist!");
                    return;
                }
                
                if (sourceUnlocked.Remove(unlockName) && sourceChallenge.Remove(challenge.name))
                {
                    SaveSystem.SaveProgressData("unlocked", sourceUnlocked);
                    SaveSystem.SaveProgressData("completedChallenges", sourceChallenge);
                }
                else
                    Fail($"Could not uncomplete challenge [{args}]");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                //var source = SaveSystem.LoadProgressData<List<string>>("petHutUnlocks", null);
                var source = SaveSystem.LoadProgressData<List<string>>("unlocked", new List<string>())
                    .Where(c => c.ToLower().Contains(currentArgs.ToLower())); ;


                //var source = GetActiveChallenges().Where(c => c.listener?.checkType == ChallengeListener.CheckType.MidRun && c.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source?.ToArray() ?? [];
                yield break;
            }

        }

        public class CommandProgressUncheck : Console.Command
        {
            public override string id => "progress notification";
            public override string format => "progress notification <group> <key>";
            public override string desc => "re-view the unlock prompt";
            public readonly string[] defaultKeys = [
                        "challengeShrineUnlocks",
                        "hotSpringUnlocks",
                        "inventorHutUnlocks",
                        "petHutUnlocks",
                        "icebreakerUnlocks",
                        ];
            public override void Run(string args)
            {
                string[] strArray = Split(args);
                if (strArray.Length < 2)
                {
                    Fail("Invalid arguments");
                    return;
                }

                IEnumerable<string> source = Resources.FindObjectsOfTypeAll<BuildingType>()
                                    .Select(b => b.unlockedCheckedKey)
                                    .Where(s => !s.IsNullOrEmpty());
                if (!source.Any())
                    source = defaultKeys;

                string unlockedCheckedKey = source
                                    .Where(s => strArray[0].ToLower().StartsWith(s.ToLower()))
                                    .FirstOrDefault();

                args = args.Split([' '], 2).Last();

                List<string> unlockedChecked = SaveSystem.LoadProgressData<List<string>>(unlockedCheckedKey, []);
                var sourceKey = unlockedChecked.Where(u => !u.IsNullOrEmpty() && string.Equals(u, args, StringComparison.CurrentCultureIgnoreCase));
                
                if (!sourceKey.Where(s => string.Equals(s, args, StringComparison.CurrentCultureIgnoreCase)).Any())
                {
                    Fail($"Checked Unlock [{args}] does not exist!");
                    return;
                }

                string key = sourceKey.First();
                if (unlockedChecked.Remove(key))
                {
                    SaveSystem.SaveProgressData(unlockedCheckedKey, unlockedChecked);
                    MetaprogressionSystem.SetUnlocksReady(key);
                }
                else
                    Fail($"Could not notify unlock [{args}]");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<string> source = Resources.FindObjectsOfTypeAll<BuildingType>()
                                    .Select(b => b.unlockedCheckedKey)
                                    .Where(s => !s.IsNullOrEmpty());
                if (!source.Any())
                    source = defaultKeys;

                string[] strArray = Split(currentArgs);
                if (strArray.Length <= 0)
                    yield break;

                if (strArray.Length == 1 && !currentArgs.EndsWith(" "))
                {
                    predictedArgs = source
                                    .Where(s => s.ToLower().Contains(strArray[0].ToLower()))
                                    .Distinct().Select(s => s + ' ').ToArray();
                }
                else
                {
                    string unlockedCheckedKey = source
                                    .Where(s => strArray[0].ToLower().StartsWith(s.ToLower()))
                                    .FirstOrDefault();

                    if (unlockedCheckedKey.IsNullOrEmpty()) 
                        yield break;

                    currentArgs = currentArgs.Split([' '], 2).Last();

                    List<string> unlockedChecked = SaveSystem.LoadProgressData<List<string>>(unlockedCheckedKey, []);
                    predictedArgs = unlockedChecked
                                    .Where(u => !u.IsNullOrEmpty() && u.ToLower().Contains(currentArgs.ToLower()))
                                    .Select(u => $"{unlockedCheckedKey} {u}").Distinct().ToArray();
                }
            }

        }








        public class CommandProgressTownUnlockSequence : Console.Command
        {
            public override string id => "progress sequence";
            public override string format => "progress sequence <unlock>";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                args = args.Trim();
                if (args.Length == 0)
                {
                    Fail("You must provide a UnlockData name");
                    yield break;
                }

                var source = AddressableLoader.GetGroup<UnlockData>(nameof(UnlockData)).Where(a =>
                    a.relatedBuilding != null && !a.unlockTitle.IsEmpty && !a.unlockDesc.IsEmpty
                    && string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)
                    );
                if (!source.Any())
                {
                    Fail($"UnlockData [{args}] does not exist!");
                    yield break;
                }

                UnlockData data = source.First();
                MetaprogressionSystem.SetUnlocksReady(data.name);
                yield return SceneManager.Load("TownUnlocks", SceneType.Temporary);
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded(nameof(UnlockData))) yield return AddressableLoader.LoadGroup(nameof(UnlockData));
                IEnumerable<UnlockData> source = AddressableLoader.GetGroup<UnlockData>(nameof(UnlockData)).Where(a => 
                    a.relatedBuilding != null && !a.unlockTitle.IsEmpty && !a.unlockDesc.IsEmpty 
                    && a.name.ToLower().Contains(currentArgs.ToLower())
                    );
                predictedArgs = source.Select(data => data.name).ToArray();
            }
        }
    }
}