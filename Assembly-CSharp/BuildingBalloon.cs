// Decompiled with JetBrains decompiler
// Type: BuildingBalloon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
