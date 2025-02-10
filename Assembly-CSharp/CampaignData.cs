// Decompiled with JetBrains decompiler
// Type: CampaignData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CampaignData
{
  public GameMode GameMode { get; set; }

  public List<GameModifierData> Modifiers { get; set; }

  public string GameVersion { get; set; }

  public int Seed { get; set; } = -1;

  public CampaignData()
  {
  }

  public CampaignData(string gameModeName, int seed = -1)
  {
    GameMode result;
    if (AddressableLoader.TryGet<GameMode>(nameof (GameMode), gameModeName, out result))
      this.Init(result, seed);
    else
      this.Init(AddressableLoader.Get<GameMode>(nameof (GameMode), "GameModeNormal"), seed);
  }

  public CampaignData(GameMode gameMode, int seed = -1) => this.Init(gameMode, seed);

  public static CampaignData Load(GameMode gameMode)
  {
    CampaignData message = new CampaignData();
    message.GameMode = gameMode;
    message.GameVersion = SaveSystem.LoadCampaignData<string>(gameMode, "gameVersion");
    message.Seed = SaveSystem.LoadCampaignData<int>(gameMode, "seed", 0);
    Debug.Log((object) message);
    return message;
  }

  private void Init(GameMode gameMode, int seed = -1)
  {
    this.GameMode = gameMode;
    this.GameVersion = Config.data.version;
    if (seed >= 0)
      this.Seed = seed;
    else if (!gameMode.seed.IsNullOrWhitespace())
    {
      this.Seed = gameMode.seed.ToSeed();
    }
    else
    {
      this.Seed = SaveSystem.LoadProgressData<int>("nextSeed", -1);
      if (this.Seed <= 0)
      {
        this.Seed = Dead.Random.Seed();
        SaveSystem.SaveProgressData<int>("nextSeed", this.Seed);
      }
    }
    Debug.Log((object) this);
    Events.InvokeCampaignDataCreated(this);
  }

  public override string ToString() => string.Format("CampaignData (GameMode: {0}, GameVersion: {1}, Seed: {2})", (object) this.GameMode.name, (object) this.GameVersion, (object) this.Seed);
}
