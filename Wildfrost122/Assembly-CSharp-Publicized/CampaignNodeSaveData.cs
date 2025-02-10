// Decompiled with JetBrains decompiler
// Type: CampaignNodeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Serializable]
public class CampaignNodeSaveData : ILoadable<CampaignNode>
{
  public string name;
  public int id;
  public string typeName;
  public int seed;
  public Vector2 position;
  public int tier;
  public int positionIndex;
  public int areaIndex;
  public List<CampaignNode.Connection> connections;
  public List<int> characters;
  public bool revealed;
  public bool cleared;
  public bool glow;
  public bool finalNode;
  public Dictionary<string, object> data;

  public CampaignNodeSaveData()
  {
  }

  public CampaignNodeSaveData(CampaignNode node)
  {
    this.name = node.name;
    this.id = node.id;
    this.typeName = node.type.name;
    this.seed = node.seed;
    this.position = node.position;
    this.tier = node.tier;
    this.positionIndex = node.positionIndex;
    this.areaIndex = node.areaIndex;
    this.connections = node.connections;
    this.characters = node.characters;
    this.revealed = node.revealed;
    this.cleared = node.cleared;
    this.glow = node.glow;
    this.finalNode = node.finalNode;
    this.data = node.data;
  }

  public CampaignNode Load()
  {
    CampaignNodeType type = AddressableLoader.Get<CampaignNodeType>("CampaignNodeType", this.typeName);
    CampaignNode campaignNode = new CampaignNode();
    campaignNode.SetType(type);
    campaignNode.name = this.name;
    campaignNode.id = this.id;
    campaignNode.position = this.position;
    campaignNode.tier = this.tier;
    campaignNode.positionIndex = this.positionIndex;
    campaignNode.areaIndex = this.areaIndex;
    campaignNode.seed = this.seed;
    campaignNode.connections = this.connections;
    campaignNode.characters = this.characters;
    campaignNode.revealed = this.revealed;
    campaignNode.cleared = this.cleared;
    campaignNode.glow = this.glow;
    campaignNode.finalNode = this.finalNode;
    campaignNode.data = this.data;
    return campaignNode;
  }
}
