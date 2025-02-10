// Decompiled with JetBrains decompiler
// Type: CampaignTier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Campaign Tier", menuName = "Campaign/Tier")]
public class CampaignTier : ScriptableObject
{
  public Vector2Int pointRange;
  public BattleData[] battlePool;
  public CampaignNodeType[] rewardPool;
}
