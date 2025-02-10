// Decompiled with JetBrains decompiler
// Type: BuildingIconSetterDaily
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class BuildingIconSetterDaily : BuildingIconSetter
{
  [SerializeField]
  public string gameModeName = "GameModeDaily";
  public GameMode _gameMode;

  public GameMode gameMode => this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", this.gameModeName));

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
