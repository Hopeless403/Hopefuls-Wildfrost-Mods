// Decompiled with JetBrains decompiler
// Type: BossRewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Boss Reward Pool", fileName = "Boss Reward Pool")]
public class BossRewardPool : ScriptableObject
{
  public int areaIndex;
  public int canTake = 2;
  public BossRewardData[] bossRewards;
}
