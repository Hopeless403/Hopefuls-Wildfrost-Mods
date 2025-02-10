// Decompiled with JetBrains decompiler
// Type: CampaignBattlePool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

public class CampaignBattlePool : MonoBehaviour
{
  [SerializeField]
  public int basePoints;
  [SerializeField]
  public CampaignBattlePool.Tier[] tiers;

  public BattleData GetRandomBattle(int tier) => this.tiers[tier].battles.RandomItem<BattleData>();

  public BattleData GetRandomBossBattle(int tier) => this.tiers[tier].bosses.RandomItem<BattleData>();

  public int GetPoints(int tier, int battleLevel)
  {
    CampaignBattlePool.Tier tier1 = this.tiers[tier];
    return this.basePoints + tier1.pointRange.Random() + battleLevel * tier1.pointsAdd;
  }

  [Serializable]
  public struct Tier
  {
    public Vector2Int pointRange;
    public int pointsAdd;
    public BattleData[] battles;
    public BattleData[] bosses;
  }
}
