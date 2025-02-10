// Decompiled with JetBrains decompiler
// Type: MapAreaNameRevealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
public class MapAreaNameRevealSystem : GameSystem
{
  private readonly Dictionary<int, CampaignNode> areaNameNodes = new Dictionary<int, CampaignNode>();

  private void OnEnable()
  {
    global::Events.OnMapNodeReveal += new UnityAction<MapNode>(this.MapNodeReveal);
    foreach (CampaignNode node in References.Campaign.nodes)
    {
      if (!node.revealed && !node.type.interactable && node.type.letter.StartsWith("area"))
        this.areaNameNodes[node.areaIndex] = node;
    }
  }

  private void OnDisable()
  {
    global::Events.OnMapNodeReveal -= new UnityAction<MapNode>(this.MapNodeReveal);
  }

  private void MapNodeReveal(MapNode mapNode)
  {
    CampaignNode campaignNode;
    if (!this.areaNameNodes.TryGetValue(mapNode.campaignNode.areaIndex, out campaignNode))
      return;
    References.Map.FindNode(campaignNode).Reveal();
    this.areaNameNodes.Remove(campaignNode.areaIndex);
  }
}
