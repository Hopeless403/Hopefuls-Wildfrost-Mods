// Decompiled with JetBrains decompiler
// Type: MapAreaNameRevealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine.Events;

public class MapAreaNameRevealSystem : GameSystem
{
  public readonly Dictionary<int, CampaignNode> areaNameNodes = new Dictionary<int, CampaignNode>();

  public void OnEnable()
  {
    global::Events.OnMapNodeReveal += new UnityAction<MapNode>(this.MapNodeReveal);
    foreach (CampaignNode node in References.Campaign.nodes)
    {
      if (!node.revealed && !node.type.interactable && node.type.letter.StartsWith("area"))
        this.areaNameNodes[node.areaIndex] = node;
    }
  }

  public void OnDisable() => global::Events.OnMapNodeReveal -= new UnityAction<MapNode>(this.MapNodeReveal);

  public void MapNodeReveal(MapNode mapNode)
  {
    CampaignNode campaignNode;
    if (!this.areaNameNodes.TryGetValue(mapNode.campaignNode.areaIndex, out campaignNode))
      return;
    References.Map.FindNode(campaignNode).Reveal();
    this.areaNameNodes.Remove(campaignNode.areaIndex);
  }
}
