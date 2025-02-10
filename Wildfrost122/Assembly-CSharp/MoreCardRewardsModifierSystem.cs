// Decompiled with JetBrains decompiler
// Type: MoreCardRewardsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class MoreCardRewardsModifierSystem : MonoBehaviour
{
  private const int toAdd = 1;
  private readonly List<int> tiersToAddTo = new List<int>();

  private void OnEnable()
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

  private void OnDisable()
  {
    Events.OnPullRewards -= new Events.UnityActionRef<object, string, int, List<DataFile>>(this.PullRewards);
  }

  private void PullRewards(
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
