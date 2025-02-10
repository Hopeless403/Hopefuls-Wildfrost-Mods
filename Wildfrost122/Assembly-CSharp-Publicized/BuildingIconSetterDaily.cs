// Decompiled with JetBrains decompiler
// Type: BuildingIconSetterDaily
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class BuildingIconSetterDaily : BuildingIconSetter
{
  [SerializeField]
  public string gameModeName = "GameModeDaily";
  public GameMode _gameMode;

  public GameMode gameMode
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
