// Decompiled with JetBrains decompiler
// Type: SaveFileChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class SaveFileChecker : MonoBehaviour
{
  private static bool saveRequired;

  private void Start()
  {
    Debug.Log((object) "~SAVE FILE CHECKER~");
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    SaveFileChecker.GainUnlocksFromCompletedChallenges(unlockedList);
    SaveFileChecker.CheckChallengeUnlocks(unlockedList);
    SaveFileChecker.CheckUnlockRequirements(unlockedList);
    SaveFileChecker.saveRequired = unlockedList.RemoveDuplicates<string>() || SaveFileChecker.saveRequired;
    if (!SaveFileChecker.saveRequired)
      return;
    SaveSystem.SaveProgressData<List<string>>("unlocked", unlockedList);
  }

  private static void GainUnlocksFromCompletedChallenges(List<string> unlocksList)
  {
    IEnumerable<ChallengeData> allChallenges = ChallengeSystem.GetAllChallenges();
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("completedChallenges", new List<string>());
    HashSet<string> stringSet = new HashSet<string>();
    foreach (string str in stringList)
    {
      string challengeName = str;
      ChallengeData challengeData = allChallenges.FirstOrDefault<ChallengeData>((Func<ChallengeData, bool>) (a => a.name == challengeName));
      if ((UnityEngine.Object) challengeData != (UnityEngine.Object) null)
      {
        UnlockData reward = challengeData.reward;
        if (reward != null)
          stringSet.AddRange<string>((IEnumerable<string>) SaveFileChecker.GetUnlockAndRequirements(reward));
      }
    }
    if (stringSet.Count <= 0)
      return;
    foreach (string str in stringSet.Where<string>((Func<string, bool>) (add => !unlocksList.Contains(add))))
      unlocksList.Add(str);
  }

  private static HashSet<string> GetUnlockAndRequirements(UnlockData unlockData)
  {
    HashSet<string> list = new HashSet<string>()
    {
      unlockData.name
    };
    foreach (UnlockData require in unlockData.requires)
      list.AddRange<string>((IEnumerable<string>) SaveFileChecker.GetUnlockAndRequirements(require));
    SaveFileChecker.saveRequired = true;
    return list;
  }

  private static void CheckChallengeUnlocks(List<string> unlocksList)
  {
    List<string> completedChallenges = SaveSystem.LoadProgressData<List<string>>("completedChallenges", new List<string>());
    ChallengeData[] array = ChallengeSystem.GetAllChallenges().Where<ChallengeData>((Func<ChallengeData, bool>) (a => !completedChallenges.Contains(a.name))).ToArray<ChallengeData>();
    List<string> removed = new List<string>();
    foreach (ChallengeData challengeData in array)
    {
      if (unlocksList.Remove(challengeData.reward.name))
      {
        removed.Add(challengeData.reward.name);
        Debug.Log((object) ("[" + challengeData.reward.name + "] removed from unlocks since [" + challengeData.name + "] is not completed"));
      }
    }
    if (removed.Count <= 0)
      return;
    SaveFileChecker.saveRequired = true;
    SaveSystem.SaveProgressData<List<string>>("inventorHutUnlocks", SaveSystem.LoadProgressData<List<string>>("inventorHutUnlocks", new List<string>()).Where<string>((Func<string, bool>) (a => !removed.Contains(a))).ToList<string>());
    SaveSystem.SaveProgressData<List<string>>("petHutUnlocks", SaveSystem.LoadProgressData<List<string>>("petHutUnlocks", new List<string>()).Where<string>((Func<string, bool>) (a => !removed.Contains(a))).ToList<string>());
  }

  private static void CheckUnlockRequirements(List<string> unlocksList)
  {
    bool flag = true;
    while (flag)
    {
      flag = false;
      for (int index = unlocksList.Count - 1; index >= 0; --index)
      {
        string unlocks = unlocksList[index];
        UnlockData unlockData = AddressableLoader.Get<UnlockData>("UnlockData", unlocks);
        if ((UnityEngine.Object) unlockData == (UnityEngine.Object) null)
        {
          Debug.Log((object) ("[" + unlocks + "] no longer exists. removing from save data"));
          unlocksList.RemoveAt(index);
          flag = true;
          SaveFileChecker.saveRequired = true;
        }
        else if (unlockData.requires != null && unlockData.requires.Length != 0)
        {
          foreach (UnlockData require in unlockData.requires)
          {
            if (!unlocksList.Contains(require.name))
            {
              Debug.Log((object) ("[" + unlocks + "] requirements are not met (requires [" + require.name + "]). removing from save data"));
              unlocksList.RemoveAt(index);
              flag = true;
              SaveFileChecker.saveRequired = true;
              break;
            }
          }
        }
      }
    }
  }
}
