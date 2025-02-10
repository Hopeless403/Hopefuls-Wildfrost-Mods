// Decompiled with JetBrains decompiler
// Type: CampaignPopulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignPopulator", menuName = "Campaign/Populator")]
public class CampaignPopulator : ScriptableObject
{
  [SerializeField]
  public bool removeLockedCards = true;
  [SerializeField]
  public CampaignTier[] tiers;
  [SerializeField]
  public int playerStartNodeId;
  [SerializeField]
  public BattleLockData[] battleLockers;

  public void LoadCharacters(Campaign campaign, CharacterSaveData[] data)
  {
    foreach (CharacterSaveData characterSaveData in data)
    {
      Character character = characterSaveData.Load();
      character.transform.SetParent(campaign.characterContainer);
      campaign.characters.Add(character);
    }
  }

  public IEnumerator Populate(Campaign campaign)
  {
    CampaignPopulator campaignPopulator = this;
    Debug.Log((object) string.Format("[{0}] POPULATING", (object) campaignPopulator));
    StopWatch.Start();
    campaign.characterContainer.DestroyAllChildren();
    Character character = UnityEngine.Object.Instantiate<Character>(References.PlayerData.classData.characterPrefab, campaign.characterContainer);
    character.name = "Player (" + character.title + ")";
    campaign.characters.Add(character);
    campaign.nodes[campaignPopulator.playerStartNodeId].characters.Add(campaign.characters.Count - 1);
    for (int index = 0; index < campaignPopulator.playerStartNodeId; ++index)
    {
      CampaignNode node = campaign.nodes[index];
      if (node.type.interactable)
      {
        node.revealed = true;
        node.SetCleared();
      }
    }
    References.Player = character;
    character.Assign(References.PlayerData);
    CharacterRewards component = character.GetComponent<CharacterRewards>();
    if (component != null)
    {
      component.Populate(character.data.classData);
      if (campaignPopulator.removeLockedCards)
        component.RemoveLockedCards();
      component.RemoveCardsFromStartingDeck();
      if (Campaign.Data.GameMode.mainGameMode)
        component.RemoveCompanionsInFinalBossBattle();
    }
    CharacterDisplay.FindAndAssign(character);
    List<int> intList = new List<int>();
    foreach (char battleTier in campaign.battleTiers)
    {
      int num = int.Parse(battleTier.ToString());
      intList.Add(num);
    }
    List<CampaignPopulator.Tier> currentTiers = new List<CampaignPopulator.Tier>();
    foreach (CampaignNode node in campaign.nodes)
    {
      int tierNumber = intList[node.positionIndex];
      CampaignPopulator.Tier tier = currentTiers.Find((Predicate<CampaignPopulator.Tier>) (a => a.number == tierNumber));
      if (tier == null)
        currentTiers.Add(new CampaignPopulator.Tier(tierNumber, campaignPopulator.tiers[tierNumber])
        {
          nodes = {
            node
          }
        });
      else
        tier.nodes.Add(node);
    }
    foreach (CampaignPopulator.Tier tier in currentTiers)
    {
      foreach (CampaignNode node in tier.nodes)
      {
        if (node.type.isBattle)
        {
          BattleData battleData = tier.PullBattle(campaignPopulator);
          int battlePoints = tier.GetBattlePoints();
          node.data = new Dictionary<string, object>()
          {
            ["battle"] = (object) battleData.name,
            ["waves"] = (object) battleData.generationScript.Run(battleData, battlePoints)
          };
        }
        else if (node.type.name == "CampaignNodeReward")
          node.SetType(tier.PullReward());
      }
    }
    Dictionary<CampaignNode, CampaignNode> links = CampaignPopulator.LinkNodes(currentTiers);
    Routine.Clump clump = new Routine.Clump();
    foreach (CampaignNode node in campaign.nodes)
    {
      if (!links.ContainsKey(node))
        clump.Add(node.type.SetUp(node));
    }
    yield return (object) clump.WaitForEnd();
    foreach (KeyValuePair<CampaignNode, CampaignNode> keyValuePair in links)
      keyValuePair.Key.CopyData(keyValuePair.Value);
    Debug.Log((object) string.Format("DONE ({0}ms)", (object) StopWatch.Stop()));
    yield return (object) null;
  }

  public bool BattleIsLocked(string battleName)
  {
    BattleLockData battleLockData = ((IEnumerable<BattleLockData>) this.battleLockers).FirstOrDefault<BattleLockData>((Func<BattleLockData, bool>) (a => a.battleName == battleName));
    return battleLockData != null && battleLockData.IsLocked();
  }

  public static Dictionary<CampaignNode, CampaignNode> LinkNodes(
    List<CampaignPopulator.Tier> currentTiers)
  {
    Dictionary<CampaignNode, CampaignNode> links = new Dictionary<CampaignNode, CampaignNode>();
    foreach (CampaignPopulator.Tier currentTier in currentTiers)
    {
      foreach (CampaignNode node1 in currentTier.nodes)
      {
        CampaignNode node = node1;
        if (node.type.canLink && !links.ContainsKey(node) && !links.ContainsValue(node) && node.pathId >= 0)
        {
          CampaignNode campaignNode1 = currentTier.nodes.Where<CampaignNode>((Func<CampaignNode, bool>) (a => !links.ContainsKey(a) && !links.ContainsValue(a) && a.type.canLink && a.id != node.id && a.pathId != node.pathId && a.pathId >= 0 && a.type.name == node.type.name)).OrderBy<CampaignNode, int>((Func<CampaignNode, int>) (a => a.id)).FirstOrDefault<CampaignNode>();
          if (campaignNode1 != null)
          {
            node.dataLinkedTo = campaignNode1.id;
            CampaignNode campaignNode2 = campaignNode1;
            if (campaignNode2.linkedToThis == null)
              campaignNode2.linkedToThis = new List<int>();
            campaignNode1.linkedToThis.Add(node.id);
            links.Add(node, campaignNode1);
          }
        }
      }
    }
    return links;
  }

  public class Tier
  {
    public int number;
    public List<CampaignNode> nodes = new List<CampaignNode>();
    public List<BattleData> battles = new List<BattleData>();
    public List<CampaignNodeType> rewards = new List<CampaignNodeType>();
    public CampaignTier campaignTier;

    public Tier(int number, CampaignTier campaignTier)
    {
      this.number = number;
      this.campaignTier = campaignTier;
    }

    public BattleData PullBattle(CampaignPopulator campaignPopulator)
    {
      if (this.battles.Count <= 0)
      {
        foreach (BattleData battleData in this.campaignTier.battlePool)
        {
          if (!campaignPopulator.BattleIsLocked(battleData.name))
            this.battles.Add(battleData);
        }
      }
      BattleData battleData1 = this.battles.RandomItem<BattleData>();
      this.battles.Remove(battleData1);
      return battleData1;
    }

    public int GetBattlePoints() => this.campaignTier.pointRange.Random();

    public CampaignNodeType PullReward()
    {
      if (this.rewards.Count <= 0)
        this.rewards.AddRange((IEnumerable<CampaignNodeType>) this.campaignTier.rewardPool);
      CampaignNodeType campaignNodeType = this.rewards.RandomItem<CampaignNodeType>();
      this.rewards.Remove(campaignNodeType);
      return campaignNodeType;
    }
  }
}
