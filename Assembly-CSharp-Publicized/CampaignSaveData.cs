// Decompiled with JetBrains decompiler
// Type: CampaignSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class CampaignSaveData
{
  public CharacterSaveData[] characters;
  public CampaignNodeSaveData[] nodes;
  public int playerId;
  public string[] modifiers;

  public CampaignSaveData()
  {
  }

  public CampaignSaveData(Campaign campaign)
  {
    this.characters = campaign.characters.SaveArray<Character, CharacterSaveData>();
    this.nodes = campaign.nodes.SaveArray<CampaignNode, CampaignNodeSaveData>();
    this.playerId = Campaign.GetCharacterId(References.Player);
    this.modifiers = Campaign.Data.Modifiers != null ? Campaign.Data.Modifiers.Select<GameModifierData, string>((Func<GameModifierData, string>) (a => a.name)).ToArray<string>() : (string[]) null;
  }

  public List<CampaignNode> LoadNodes()
  {
    List<CampaignNode> campaignNodeList = new List<CampaignNode>();
    foreach (CampaignNodeSaveData node in this.nodes)
      campaignNodeList.Add(node.Load());
    return campaignNodeList;
  }
}
