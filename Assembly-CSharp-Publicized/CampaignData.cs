// Decompiled with JetBrains decompiler
// Type: CampaignData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class CampaignData
{
  [CompilerGenerated]
  public GameMode \u003CGameMode\u003Ek__BackingField;
  [CompilerGenerated]
  public List<GameModifierData> \u003CModifiers\u003Ek__BackingField;
  [CompilerGenerated]
  public string \u003CGameVersion\u003Ek__BackingField;
  [CompilerGenerated]
  public int \u003CSeed\u003Ek__BackingField = -1;

  public GameMode GameMode
  {
    get => this.\u003CGameMode\u003Ek__BackingField;
    set => this.\u003CGameMode\u003Ek__BackingField = value;
  }

  public List<GameModifierData> Modifiers
  {
    get => this.\u003CModifiers\u003Ek__BackingField;
    set => this.\u003CModifiers\u003Ek__BackingField = value;
  }

  public string GameVersion
  {
    get => this.\u003CGameVersion\u003Ek__BackingField;
    set => this.\u003CGameVersion\u003Ek__BackingField = value;
  }

  public int Seed
  {
    get => this.\u003CSeed\u003Ek__BackingField;
    set => this.\u003CSeed\u003Ek__BackingField = value;
  }

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

  public void Init(GameMode gameMode, int seed = -1)
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
