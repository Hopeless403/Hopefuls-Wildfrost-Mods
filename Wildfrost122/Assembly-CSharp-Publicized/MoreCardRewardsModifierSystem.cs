// Decompiled with JetBrains decompiler
// Type: MoreCardRewardsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class MoreCardRewardsModifierSystem : MonoBehaviour
{
  public const int toAdd = 1;
  public readonly List<int> tiersToAddTo = new List<int>();

  public void OnEnable()
  {
    Events.OnPullRewards += new Events.UnityActionRef<object, string, int, List<DataFile>>(this.PullRewards);
    this.tiersToAddTo.Clear();
    List<int> list = new List<int>() { 0, 1, 2, 3, 4 };
    Random.State state = Random.state;
    Random.InitState(Campaign.Data.Seed);
    for (int index = 0; index < 2 && list.Count > 0; ++index)
      this.tiersToAddTo.Add(list.TakeRandom<int>());
    Random.state = state;
    Debug.Log((object) ("MoreCardRewardsModifierSystem → tiers to add to: [" + string.Join<int>(", ", (IEnumerable<int>) this.tiersToAddTo) + "]"));
  }

  public void OnDisable()
  {
    Events.OnPullRewards -= new Events.UnityActionRef<object, string, int, List<DataFile>>(this.PullRewards);
  }

  public void PullRewards(
    object pulledBy,
    ref string poolName,
    ref int itemCount,
    ref List<DataFile> result)
  {
    if (!(pulledBy is CampaignNode campaignNode) || !this.tiersToAddTo.Contains(campaignNode.tier) || !(campaignNode.type is CampaignNodeTypeItem))
      return;
    ++itemCount;
    Debug.Log((object) string.Format("MoreCardRewardsModifierSystem → adding +{0} to Reward Pool \"{1}\" Pull ({2} node index: {3})", (object) 1, (object) poolName, (object) campaignNode.type.name, (object) campaignNode.id));
  }
}
