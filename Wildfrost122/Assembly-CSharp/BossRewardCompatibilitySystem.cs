// Decompiled with JetBrains decompiler
// Type: BossRewardCompatibilitySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BossRewardCompatibilitySystem : GameSystem
{
  private void OnEnable() => global::Events.OnCampaignLoaded += new UnityAction(this.CampaignLoaded);

  private void OnDisable() => global::Events.OnCampaignLoaded -= new UnityAction(this.CampaignLoaded);

  private void CampaignLoaded()
  {
    bool flag = false;
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      if (node.type.isBattle && node.type is CampaignNodeTypeBoss && !node.data.ContainsKey("rewards"))
      {
        if (!flag)
        {
          CharacterRewards component = References.Player.GetComponent<CharacterRewards>();
          if (component != null)
          {
            component.Populate(References.PlayerData.classData);
            component.RemoveLockedCards();
            flag = true;
          }
        }
        CampaignNodeTypeBoss.GetRewards(node);
        Debug.Log((object) string.Format("Boss Node [{0}][{1}] doesn't contain any boss reward data! Pulling new rewards!", (object) node.name, (object) node.id));
      }
    }
  }
}
