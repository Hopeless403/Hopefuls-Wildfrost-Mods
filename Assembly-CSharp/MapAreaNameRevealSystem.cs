// Decompiled with JetBrains decompiler
// Type: MapAreaNameRevealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.Events;

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

  private void OnDisable() => global::Events.OnMapNodeReveal -= new UnityAction<MapNode>(this.MapNodeReveal);

  private void MapNodeReveal(MapNode mapNode)
  {
    CampaignNode campaignNode;
    if (!this.areaNameNodes.TryGetValue(mapNode.campaignNode.areaIndex, out campaignNode))
      return;
    References.Map.FindNode(campaignNode).Reveal();
    this.areaNameNodes.Remove(campaignNode.areaIndex);
  }
}
