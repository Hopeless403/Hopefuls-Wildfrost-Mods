// Decompiled with JetBrains decompiler
// Type: BuildingBalloon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (Building))]
public class BuildingBalloon : MonoBehaviour
{
  [SerializeField]
  public string gameModeName = "GameModeDaily";
  [SerializeField]
  public GameObject displayPrefab;
  public Building _building;

  public Building building => this._building ?? (this._building = this.GetComponent<Building>());

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

  public static IEnumerator ContinueRoutine()
  {
    yield return (object) SceneManager.Load("ContinueRun", SceneType.Temporary);
    yield return (object) SceneManager.WaitUntilUnloaded("ContinueRun");
  }
}
