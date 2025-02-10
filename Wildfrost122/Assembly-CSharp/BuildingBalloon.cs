// Decompiled with JetBrains decompiler
// Type: BuildingBalloon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (Building))]
public class BuildingBalloon : MonoBehaviour
{
  [SerializeField]
  private string gameModeName = "GameModeDaily";
  [SerializeField]
  private GameObject displayPrefab;
  private Building _building;

  private Building building => this._building ?? (this._building = this.GetComponent<Building>());

  public void Select()
  {
    GameMode gameMode = AddressableLoader.Get<GameMode>("GameMode", this.gameModeName);
    if (Campaign.CheckContinue(gameMode))
    {
      Campaign.Data = CampaignData.Load(gameMode);
      DailyFetcher.SetContinueDateTime();
      this.StartCoroutine(BuildingBalloon.ContinueRoutine());
    }
    else
      this.building.CreateDisplay(this.displayPrefab);
  }

  private static IEnumerator ContinueRoutine()
  {
    yield return (object) SceneManager.Load("ContinueRun", SceneType.Temporary);
    yield return (object) SceneManager.WaitUntilUnloaded("ContinueRun");
  }
}
