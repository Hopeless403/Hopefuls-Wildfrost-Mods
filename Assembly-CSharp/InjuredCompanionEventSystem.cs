// Decompiled with JetBrains decompiler
// Type: InjuredCompanionEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class InjuredCompanionEventSystem : GameSystem
{
  private void OnEnable() => Events.OnCampaignLoadPreset += new Events.UnityActionRef<string[]>(InjuredCompanionEventSystem.CampaignLoadPreset);

  private void OnDisable() => Events.OnCampaignLoadPreset -= new Events.UnityActionRef<string[]>(InjuredCompanionEventSystem.CampaignLoadPreset);

  private static int GetCampaignInsertPosition(RunHistory mostRecentRun)
  {
    CampaignStats stats = mostRecentRun.stats;
    int num = stats != null ? stats.Count("battlesWon") : 0;
    int campaignInsertPosition = num >= 6 ? 23 : (num >= 3 ? 11 : 2);
    Debug.Log((object) string.Format("InjuredCompanionEventSystem - Battles Won: {0} - Insert Pos: {1}", (object) num, (object) campaignInsertPosition));
    return campaignInsertPosition;
  }

  private static void CampaignLoadPreset(ref string[] lines)
  {
    if (!Campaign.Data.GameMode.mainGameMode || Campaign.Data.GameMode.tutorialRun)
      return;
    RunHistory mostRecentRun = InjuredCompanionEventSystem.GetMostRecentRun();
    if (mostRecentRun == null || mostRecentRun.result != Campaign.Result.Lose || !InjuredCompanionEventSystem.HasEligibleCompanion(mostRecentRun))
      return;
    int campaignInsertPosition = InjuredCompanionEventSystem.GetCampaignInsertPosition(mostRecentRun);
    lines[0] = lines[0].Insert(campaignInsertPosition, "#");
    lines[1] = lines[1].Insert(campaignInsertPosition, " ");
    lines[2] = lines[2].Insert(campaignInsertPosition, lines[2][campaignInsertPosition - 1].ToString());
    lines[3] = lines[3].Insert(campaignInsertPosition, lines[3][campaignInsertPosition - 1].ToString());
  }

  public static RunHistory GetMostRecentRun()
  {
    List<RunHistory> runHistoryList = SaveSystem.LoadHistoryData<List<RunHistory>>("list");
    if (runHistoryList != null && runHistoryList.Count > 0)
    {
      for (int index = runHistoryList.Count - 1; index >= 0; --index)
      {
        if (runHistoryList[index] != null)
        {
          string gameModeName = runHistoryList[index].gameModeName;
          if (gameModeName != null && AddressableLoader.Get<GameMode>("GameMode", gameModeName).mainGameMode)
            return runHistoryList[index];
        }
      }
    }
    return (RunHistory) null;
  }

  private static bool HasEligibleCompanion(RunHistory run)
  {
    string[] unlockedPets = MetaprogressionSystem.GetUnlockedPets();
    foreach (CardSaveData card in run.inventory.deck)
    {
      if (InjuredCompanionEventSystem.IsEligible(card, unlockedPets))
        return true;
    }
    foreach (CardSaveData card in run.inventory.reserve)
    {
      if (InjuredCompanionEventSystem.IsEligible(card, unlockedPets))
        return true;
    }
    return false;
  }

  private static bool IsEligible(CardSaveData card, string[] illegal) => !illegal.Contains<string>(card.name) && card.Peek().cardType.name == "Friendly";

  public static List<CardSaveData> GetEligibleCompanions(RunHistory run)
  {
    string[] unlockedPets = MetaprogressionSystem.GetUnlockedPets();
    List<CardSaveData> eligibleCompanions = new List<CardSaveData>();
    foreach (CardSaveData card in run.inventory.deck)
    {
      if (InjuredCompanionEventSystem.IsEligible(card, unlockedPets))
        eligibleCompanions.Add(card);
    }
    foreach (CardSaveData card in run.inventory.reserve)
    {
      if (InjuredCompanionEventSystem.IsEligible(card, unlockedPets))
        eligibleCompanions.Add(card);
    }
    return eligibleCompanions;
  }
}
