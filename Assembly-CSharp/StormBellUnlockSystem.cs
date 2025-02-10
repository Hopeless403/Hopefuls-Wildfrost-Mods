// Decompiled with JetBrains decompiler
// Type: StormBellUnlockSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.Events;

public class StormBellUnlockSystem : GameSystem
{
  private void OnEnable() => global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);

  private void OnDisable() => global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);

  private void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
  {
    if (result != Campaign.Result.Win || !Campaign.Data.GameMode.mainGameMode)
      return;
    if (!SaveSystem.LoadProgressData<bool>("stormBellsUnlocked", false))
      SaveSystem.SaveProgressData<bool>("stormBellsUnlocked", true);
    List<string> active = SaveSystem.LoadProgressData<List<string>>("activeHardModeModifiers") ?? new List<string>();
    int currentStormPoints = StormBellManager.GetCurrentStormPoints(active);
    int num1 = SaveSystem.LoadProgressData<int>("maxStormPoints", 5);
    int num2 = num1;
    if (currentStormPoints == num2 && num1 + 1 <= 10)
    {
      SaveSystem.SaveProgressData<int>("maxStormPoints", num1 + 1);
      SaveSystem.SaveProgressData<int>("maxStormPointIncrease", 1);
    }
    if (!SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false))
      return;
    List<string> stringList1 = SaveSystem.LoadProgressData<List<string>>("goldHardModeModifiers") ?? new List<string>();
    List<string> stringList2 = SaveSystem.LoadProgressData<List<string>>("goldHardModeModifiersNew") ?? new List<string>();
    bool flag = false;
    foreach (string str in active)
    {
      if (!stringList1.Contains(str))
      {
        stringList1.Add(str);
        stringList2.Add(str);
        flag = true;
      }
    }
    if (!flag)
      return;
    SaveSystem.SaveProgressData<List<string>>("goldHardModeModifiers", stringList1);
    SaveSystem.SaveProgressData<List<string>>("goldHardModeModifiersNew", stringList2);
  }
}
