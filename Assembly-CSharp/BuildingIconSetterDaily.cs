// Decompiled with JetBrains decompiler
// Type: BuildingIconSetterDaily
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class BuildingIconSetterDaily : BuildingIconSetter
{
  [SerializeField]
  private string gameModeName = "GameModeDaily";
  private GameMode _gameMode;

  private GameMode gameMode => this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", this.gameModeName));

  public override string Get(Building building)
  {
    string str = "";
    if (DailyFetcher.CanPlay())
      str = "Unlock";
    else if (Campaign.CheckContinue(this.gameMode))
      str = "Unlock";
    return str;
  }
}
