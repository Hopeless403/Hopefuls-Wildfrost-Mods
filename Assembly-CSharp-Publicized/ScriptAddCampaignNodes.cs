// Decompiled with JetBrains decompiler
// Type: ScriptAddCampaignNodes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Add Campaign Nodes", menuName = "Scripts/Add Campaign Nodes")]
public class ScriptAddCampaignNodes : Script
{
  [SerializeField]
  public ScriptAddCampaignNodes.Event[] events;

  public override IEnumerator Run()
  {
    Routine.Clump clump = new Routine.Clump();
    foreach (ScriptAddCampaignNodes.Event @event in this.events)
    {
      int tier = @event.tierRange.Random();
      List<CampaignNode> list = new List<CampaignNode>();
      foreach (CampaignNode node in References.Campaign.nodes)
      {
        if (node.tier == tier && node.type.interactable && node.connections.Count > 1)
          list.Add(node);
      }
      CampaignNode campaignNode1 = list.RandomItem<CampaignNode>();
      int num1 = References.Campaign.nodes.IndexOf(campaignNode1);
      CampaignNode campaignNode2 = new CampaignNode(@event.type, campaignNode1.position.x, campaignNode1.position.y, tier, campaignNode1.positionIndex, campaignNode1.areaIndex, campaignNode1.radius);
      References.Campaign.nodes.Insert(num1 + 1, campaignNode2);
      campaignNode2.id = num1;
      campaignNode2.connections = campaignNode1.connections.Clone<CampaignNode.Connection>();
      int count = References.Campaign.nodes.Count;
      for (int index = num1 + 1; index < count; ++index)
      {
        CampaignNode node = References.Campaign.nodes[index];
        ++node.id;
        foreach (CampaignNode.Connection connection in node.connections)
          ++connection.otherId;
      }
      List<int> intList = new List<int>()
      {
        campaignNode2.id
      };
      while (intList.Count > 0)
      {
        CampaignNode node = Campaign.GetNode(intList[0]);
        ++node.position.x;
        intList.RemoveAt(0);
        foreach (int num2 in node.connections.Select<CampaignNode.Connection, int>((Func<CampaignNode.Connection, int>) (a => a.otherId)))
        {
          if (!intList.Contains(num2))
            intList.Add(num2);
        }
      }
      campaignNode1.connections.Clear();
      campaignNode1.ConnectTo(campaignNode2);
      clump.Add(campaignNode2.type.SetUp(campaignNode2));
    }
    yield return (object) clump.WaitForEnd();
    CampaignGenerator.ShuffleNodes(References.Campaign.nodes);
  }

  [Serializable]
  public class Event
  {
    public CampaignNodeType type;
    public Vector2Int tierRange;
  }
}
