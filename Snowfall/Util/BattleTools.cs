// Decompiled with JetBrains decompiler
// Type: Snowfall2.Util.BattleTools
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowfall2.Util
{
  public static class BattleTools
  {
    private static CampaignPopulator Pop => SnowfallMod.GameMode.populator;

    private static AddressableLoader.Group Battles => AddressableLoader.groups["BattleData"];

    public static BattleData LoadBattle(string name) => BattleTools.Battles.lookup[name] as BattleData;

    public static BattleData GetBattle(int tier, int battle) => BattleTools.Pop.tiers[tier].battlePool[battle];

    public static int Count(int tier) => ((IEnumerable<BattleData>) BattleTools.Pop.tiers[tier].battlePool).Count<BattleData>();

    public static void SetBattle(int tier, int battle, string name)
    {
      try
      {
        BattleTools.Pop.tiers[tier].battlePool[battle] = BattleTools.LoadBattle(name);
      }
      catch (Exception ex)
      {
        SnowfallMod.Log(ex.Message);
      }
    }

    public static void AddToTier(int tier, string name)
    {
      List<BattleData> list = BattleTools.Pop.tiers[tier].battlePool.ToList<BattleData>();
      list.Add(BattleTools.LoadBattle(name));
      BattleTools.Pop.tiers[tier].battlePool = list.ToArray();
    }

    public static void RemoveFromTier(int tier, int battle)
    {
      List<BattleData> list = BattleTools.Pop.tiers[tier].battlePool.ToList<BattleData>();
      list.RemoveAt(battle);
      BattleTools.Pop.tiers[tier].battlePool = list.ToArray();
    }

    public static void SetInTier(int tier, string name) => BattleTools.Pop.tiers[tier].battlePool = new BattleData[1]
    {
      BattleTools.LoadBattle(name)
    };

    public static void ClearTier(int tier) => BattleTools.Pop.tiers[tier].battlePool = new BattleData[0];
  }
}
