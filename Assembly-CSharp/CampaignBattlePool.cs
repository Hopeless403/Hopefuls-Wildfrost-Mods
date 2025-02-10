// Decompiled with JetBrains decompiler
// Type: CampaignBattlePool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

public class CampaignBattlePool : MonoBehaviour
{
  [SerializeField]
  private int basePoints;
  [SerializeField]
  private CampaignBattlePool.Tier[] tiers;

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
