﻿// Decompiled with JetBrains decompiler
// Type: AchievementsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks.Data;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AchievementsSystem : MonoBehaviour
{
  public static readonly Dictionary<string, string> ChallengeAchievement = new Dictionary<string, string>()
  {
    {
      "Challenge Charm 1",
      "ACHIEVEMENT_0"
    },
    {
      "Challenge Charm 2",
      "ACHIEVEMENT_1"
    },
    {
      "Challenge Charm 3",
      "ACHIEVEMENT_2"
    },
    {
      "Challenge Charm 4",
      "ACHIEVEMENT_3"
    },
    {
      "Challenge Charm 5",
      "ACHIEVEMENT_4"
    },
    {
      "Challenge Charm 6",
      "ACHIEVEMENT_5"
    },
    {
      "Challenge Charm 7",
      "ACHIEVEMENT_6"
    },
    {
      "Challenge Charm 8",
      "ACHIEVEMENT_7"
    },
    {
      "Challenge Charm 9",
      "ACHIEVEMENT_8"
    },
    {
      "Challenge Charm 10",
      "ACHIEVEMENT_9"
    },
    {
      "Challenge Charm 11",
      "ACHIEVEMENT_10"
    },
    {
      "Challenge Charm 12",
      "ACHIEVEMENT_11"
    },
    {
      "Challenge Charm 13",
      "ACHIEVEMENT_12"
    },
    {
      "Challenge Charm 14",
      "ACHIEVEMENT_13"
    },
    {
      "Challenge Charm 15",
      "ACHIEVEMENT_14"
    },
    {
      "Challenge Charm 16",
      "ACHIEVEMENT_15"
    }
  };

  private void OnEnable() => global::Events.OnChallengeCompletedSaved += new UnityAction<ChallengeData>(AchievementsSystem.ChallengeCompleted);

  private void OnDisable() => global::Events.OnChallengeCompletedSaved -= new UnityAction<ChallengeData>(AchievementsSystem.ChallengeCompleted);

  private static void ChallengeCompleted(ChallengeData challengeData)
  {
    if (!SteamManager.init)
      return;
    AchievementsSystem.Check(challengeData.name);
  }

  public static void Check(string challengeName)
  {
    string achievementId;
    if (!AchievementsSystem.ChallengeAchievement.TryGetValue(challengeName, out achievementId))
      return;
    AchievementsSystem.Achieve(achievementId);
  }

  public static void Achieve(string achievementId)
  {
    Debug.Log((object) ("Steam Achievement [" + achievementId + "] Unlocked!"));
    new Achievement(achievementId).Trigger();
  }
}
