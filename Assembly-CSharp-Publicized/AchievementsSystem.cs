// Decompiled with JetBrains decompiler
// Type: AchievementsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

  public void OnEnable() => global::Events.OnChallengeCompletedSaved += new UnityAction<ChallengeData>(AchievementsSystem.ChallengeCompleted);

  public void OnDisable() => global::Events.OnChallengeCompletedSaved -= new UnityAction<ChallengeData>(AchievementsSystem.ChallengeCompleted);

  public static void ChallengeCompleted(ChallengeData challengeData)
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
