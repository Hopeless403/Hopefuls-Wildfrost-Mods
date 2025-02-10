// Decompiled with JetBrains decompiler
// Type: BossRewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Boss Reward Pool", fileName = "Boss Reward Pool")]
public class BossRewardPool : ScriptableObject
{
  public int areaIndex;
  public int canTake = 2;
  public BossRewardData[] bossRewards;
}
