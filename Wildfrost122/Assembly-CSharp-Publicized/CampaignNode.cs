// Decompiled with JetBrains decompiler
// Type: CampaignNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[Serializable]
public class CampaignNode : ISaveable<CampaignNodeSaveData>
{
  public string name = "Salty Spicelands";
  public int id;
  [CompilerGenerated]
  public CampaignNodeType \u003Ctype\u003Ek__BackingField;
  public int seed;
  public Vector2 position;
  public int tier;
  public int positionIndex;
  public int areaIndex;
  public List<CampaignNode.Connection> connections;
  public List<int> characters;
  public bool revealed;
  public bool cleared;
  public float radius;
  public bool glow;
  public bool finalNode;
  public Dictionary<string, object> data;
  public int connectedTo;
  public int pathId = -1;
  public int dataLinkedTo = -1;
  public List<int> linkedToThis;

  public CampaignNodeType type
  {
    get => this.\u003Ctype\u003Ek__BackingField;
    set => this.\u003Ctype\u003Ek__BackingField = value;
  }

  public void CopyData(CampaignNode otherNode)
  {
    this.data = otherNode.data.ToDictionary<KeyValuePair<string, object>, string, object>((Func<KeyValuePair<string, object>, string>) (entry => entry.Key), new Func<KeyValuePair<string, object>, object>(this.CloneDataValue));
  }

  public object CloneDataValue(KeyValuePair<string, object> pair)
  {
    return !(pair.Value is ICloneable cloneable) ? pair.Value : cloneable.Clone();
  }

  public CampaignNode()
  {
  }

  public CampaignNode(
    CampaignNodeType type,
    float x,
    float y,
    int tier,
    int positionIndex,
    int areaIndex,
    float radius)
  {
    this.SetType(type);
    this.position = new Vector2(x, y);
    this.tier = tier;
    this.positionIndex = positionIndex;
    this.areaIndex = areaIndex;
    this.radius = radius;
    this.seed = Dead.Random.Seed();
    this.connections = new List<CampaignNode.Connection>();
    this.characters = new List<int>();
    this.finalNode = type.finalNode;
    if (type.canEnter)
      return;
    this.cleared = true;
  }

  public virtual IEnumerator SetUp() => (IEnumerator) null;

  public virtual IEnumerator Run() => (IEnumerator) null;

  public void ConnectTo(CampaignNode other)
  {
    ++other.connectedTo;
    CampaignNode.Connection connection = new CampaignNode.Connection()
    {
      otherId = other.id
    };
    if (this.connections.Count == 0)
    {
      connection.direction = 1f;
    }
    else
    {
      float direction = this.connections[0].direction;
      connection.direction = direction * -1f;
    }
    this.connections.Insert(0, connection);
  }

  public bool CanReceiveCharacter(Character character)
  {
    return character.GetCompanionCount() <= character.data.companionLimit;
  }

  public void SetType(CampaignNodeType type)
  {
    this.type = type;
    this.name = type.zoneName;
    this.revealed = type.startRevealed;
  }

  public string GetDesc()
  {
    string desc = "";
    List<string> stringList = new List<string>();
    foreach (int character in this.characters)
    {
      List<RewardData> rewards = Campaign.GetCharacter(character).GetComponent<BattleRewards>()?.rewards;
      if (rewards != null)
      {
        foreach (RewardData rewardData in rewards)
          stringList.Add(rewardData.title);
      }
    }
    if (stringList.Count > 0)
    {
      string str1 = "#BABABA";
      if (stringList.Count == 1)
      {
        desc = "<color=" + str1 + ">Reward:</color>\n" + stringList[0];
      }
      else
      {
        desc = "<color=" + str1 + ">Rewards:</color>";
        foreach (string str2 in stringList)
          desc = desc + "\n" + str2;
      }
    }
    return desc;
  }

  public void SetCleared()
  {
    if (this.cleared)
      return;
    this.cleared = true;
    Campaign.PromptSave();
  }

  public CampaignNodeSaveData Save() => new CampaignNodeSaveData(this);

  [Serializable]
  public class Connection
  {
    public int otherId;
    public float direction;
  }
}
