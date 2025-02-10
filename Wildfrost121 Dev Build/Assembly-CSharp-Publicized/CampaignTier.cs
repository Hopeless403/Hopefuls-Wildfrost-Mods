// Decompiled with JetBrains decompiler
// Type: CampaignTier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Campaign Tier", menuName = "Campaign/Tier")]
public class CampaignTier : ScriptableObject
{
  public Vector2Int pointRange;
  public BattleData[] battlePool;
  public CampaignNodeType[] rewardPool;
}
