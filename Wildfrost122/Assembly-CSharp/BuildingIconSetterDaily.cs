// Decompiled with JetBrains decompiler
// Type: BuildingIconSetterDaily
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class BuildingIconSetterDaily : BuildingIconSetter
{
  [SerializeField]
  private string gameModeName = "GameModeDaily";
  private GameMode _gameMode;

  private GameMode gameMode
  {
    get
    {
      return this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", this.gameModeName));
    }
  }

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
