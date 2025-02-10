// Decompiled with JetBrains decompiler
// Type: CheckAchievements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks;
using Steamworks.Data;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchievements : MonoBehaviour
{
  public static readonly Dictionary<string, string> AchievementChallenge = new Dictionary<string, string>()
  {
    {
      "ACHIEVEMENT_0",
      "Challenge Charm 1"
    },
    {
      "ACHIEVEMENT_1",
      "Challenge Charm 2"
    },
    {
      "ACHIEVEMENT_2",
      "Challenge Charm 3"
    },
    {
      "ACHIEVEMENT_3",
      "Challenge Charm 4"
    },
    {
      "ACHIEVEMENT_4",
      "Challenge Charm 5"
    },
    {
      "ACHIEVEMENT_5",
      "Challenge Charm 6"
    },
    {
      "ACHIEVEMENT_6",
      "Challenge Charm 7"
    },
    {
      "ACHIEVEMENT_7",
      "Challenge Charm 8"
    },
    {
      "ACHIEVEMENT_8",
      "Challenge Charm 9"
    },
    {
      "ACHIEVEMENT_9",
      "Challenge Charm 10"
    },
    {
      "ACHIEVEMENT_10",
      "Challenge Charm 11"
    },
    {
      "ACHIEVEMENT_11",
      "Challenge Charm 12"
    },
    {
      "ACHIEVEMENT_12",
      "Challenge Charm 13"
    },
    {
      "ACHIEVEMENT_13",
      "Challenge Charm 14"
    },
    {
      "ACHIEVEMENT_14",
      "Challenge Charm 15"
    },
    {
      "ACHIEVEMENT_15",
      "Challenge Charm 16"
    }
  };

  private void Start()
  {
    if (!SteamManager.init)
      return;
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("completedChallenges");
    Debug.Log((object) "Steam Achievements:");
    foreach (Achievement achievement in SteamUserStats.Achievements)
    {
      Debug.Log((object) string.Format("→ {0} ({1})", (object) achievement.Name, (object) achievement.State));
      if (!achievement.State)
      {
        string str = CheckAchievements.AchievementChallenge[achievement.Identifier];
        Debug.Log((object) ("-→ Requires [" + str + "]"));
        if (stringList != null && stringList.Contains(str))
          AchievementsSystem.Achieve(achievement.Identifier);
      }
    }
  }
}
