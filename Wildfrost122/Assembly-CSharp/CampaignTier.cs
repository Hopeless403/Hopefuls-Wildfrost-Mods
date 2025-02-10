// Decompiled with JetBrains decompiler
// Type: CampaignTier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Campaign Tier", menuName = "Campaign/Tier")]
public class CampaignTier : ScriptableObject
{
  public Vector2Int pointRange;
  public BattleData[] battlePool;
  public CampaignNodeType[] rewardPool;
}
