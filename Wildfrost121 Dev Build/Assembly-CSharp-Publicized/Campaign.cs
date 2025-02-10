// Decompiled with JetBrains decompiler
// Type: Campaign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Campaign : MonoBehaviour, ISaveable<CampaignSaveData>
{
  public static Campaign instance;
  public Transform characterContainer;
  public List<Character> characters = new List<Character>();
  public List<CampaignNode> nodes = new List<CampaignNode>();
  public GameObject systems;
  [ReadOnly]
  public TextAsset preset;
  [ReadOnly]
  public string battleTiers;
  public static CampaignData Data;
  [CompilerGenerated]
  public Campaign.Result \u003Cresult\u003Ek__BackingField;

  public void Awake()
  {
    Campaign.instance = this;
    References.Campaign = this;
  }

  public Campaign.Result result
  {
    get => this.\u003Cresult\u003Ek__BackingField;
    set => this.\u003Cresult\u003Ek__BackingField = value;
  }

  public void OnEnable() => global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);

  public void OnDisable() => global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);

  public void BattleEnd()
  {
    if ((UnityEngine.Object) References.Battle.winner == (UnityEngine.Object) References.Battle.player)
    {
      if (!Campaign.CheckVictory())
        return;
      this.End(Campaign.Result.Win);
      JournalNameHistory.MostRecentNameMissing();
    }
    else
      this.End(Campaign.Result.Lose);
  }

  public static void Begin()
  {
    if (Campaign.Data.GameMode.doSave)
    {
      SaveSystem.DeleteCampaign(Campaign.Data.GameMode);
      SaveSystem.SaveCampaignData<int>(Campaign.Data.GameMode, "seed", Campaign.Data.Seed);
    }
    if (!Campaign.Data.GameMode.mainGameMode)
      return;
    SaveSystem.SaveProgressData<int>("nextSeed", Dead.Random.Seed());
  }

  public void End(Campaign.Result result)
  {
    this.result = result;
    Debug.Log((object) ">>>> CAMPAIGN END <<<<");
    global::Events.InvokeCampaignEnd(result, StatsSystem.Get(), References.PlayerData);
    Campaign.PromptSave();
  }

  public void Final()
  {
    this.StopAllCoroutines();
    ActionQueue.Restart();
    References.Campaign = (Campaign) null;
    global::Events.InvokeCampaignFinal();
  }

  public IEnumerator Start()
  {
    Campaign campaign = this;
    yield return (object) new WaitUntil((Func<bool>) (() => !GameManager.Busy));
    yield return (object) SceneManager.Load("UI", SceneType.Persistent);
    global::Events.InvokeCampaignStart();
    UnityEngine.Random.InitState(Campaign.Data.Seed);
    CampaignNode continueBattleNode = (CampaignNode) null;
    if (Campaign.CheckContinue(Campaign.Data.GameMode))
    {
      CampaignSaveData campaignSaveData = SaveSystem.LoadCampaignData<CampaignSaveData>(Campaign.Data.GameMode, "data");
      StatsSystem.Set(SaveSystem.LoadCampaignData<CampaignStats>(Campaign.Data.GameMode, "stats"));
      campaign.nodes = campaignSaveData.LoadNodes();
      Campaign.Data.GameMode.populator.LoadCharacters(campaign, campaignSaveData.characters);
      References.Player = campaign.characters[campaignSaveData.playerId];
      References.PlayerData = References.Player.data;
      CharacterDisplay.FindAndAssign(References.Player);
      BattleSaveData battleSaveData = SaveSystem.LoadCampaignData<BattleSaveData>(Campaign.Data.GameMode, "battleState", (BattleSaveData) null);
      if (battleSaveData != null)
      {
        CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
        if (characterNode != null && characterNode.id == battleSaveData.campaignNodeId)
        {
          if (battleSaveData.HasMissingCardData())
            SaveSystem.SaveCampaignData<BattleSaveData>(Campaign.Data.GameMode, "battleState", (BattleSaveData) null);
          else
            continueBattleNode = characterNode;
        }
      }
      if (campaignSaveData.modifiers != null)
      {
        foreach (string modifier1 in campaignSaveData.modifiers)
        {
          GameModifierData modifier2 = AddressableLoader.Get<GameModifierData>("GameModifierData", modifier1);
          if ((UnityEngine.Object) modifier2 != (UnityEngine.Object) null)
            ModifierSystem.AddModifier(Campaign.Data, modifier2);
        }
      }
      global::Events.InvokeCampaignLoaded();
    }
    else
    {
      yield return (object) Campaign.Data.GameMode.generator.Generate(campaign);
      global::Events.InvokePreCampaignPopulate();
      yield return (object) Campaign.Data.GameMode.populator.Populate(campaign);
      StatsSystem.Set(new CampaignStats());
      yield return (object) global::Events.InvokeCampaignGenerated();
      Campaign.FirstSave();
    }
    if (Campaign.Data.GameMode.campaignSystemNames != null)
    {
      foreach (string campaignSystemName in Campaign.Data.GameMode.campaignSystemNames)
        campaign.gameObject.AddComponentByName(campaignSystemName);
    }
    if (Campaign.Data.GameMode.systemsToDisable != null)
    {
      foreach (string typeName in Campaign.Data.GameMode.systemsToDisable)
      {
        System.Type type = System.Type.GetType(typeName);
        if ((object) type != null && UnityEngine.Object.FindObjectOfType(type, true) is GameSystem objectOfType)
        {
          Debug.Log((object) ("Disabling [" + typeName + "]"));
          objectOfType.Disable();
        }
      }
    }
    yield return (object) SceneManager.Load("MapNew", SceneType.Active);
    if (continueBattleNode == null || !Campaign.TryEnterNode(continueBattleNode, false))
      Transition.End();
  }

  public static CampaignNode GetNode(int id) => Campaign.instance.nodes[id];

  public static Character GetCharacter(int id) => Campaign.instance.characters[id];

  public static int GetCharacterId(Character character)
  {
    return Campaign.instance.characters.IndexOf(character);
  }

  public static void MoveCharacter(Character character, CampaignNode toNode)
  {
    Campaign.FindCharacterNode(character)?.characters?.Remove(Campaign.GetCharacterId(character));
    toNode.characters.Add(Campaign.GetCharacterId(character));
    Campaign.PromptSave();
  }

  public static CampaignNode FindCharacterNode(Character character)
  {
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      if (node.characters.Contains(Campaign.GetCharacterId(character)))
        return node;
    }
    return (CampaignNode) null;
  }

  public static bool TryEnterNode(CampaignNode node, bool delay = true)
  {
    if (node.cleared || !node.characters.Contains(Campaign.GetCharacterId(References.Player)))
      return false;
    Campaign.instance.StartCoroutine(Campaign.EnterNode(node, delay));
    return true;
  }

  public static IEnumerator EnterNode(CampaignNode node, bool delay = true)
  {
    if ((bool) (UnityEngine.Object) node?.type)
    {
      InputSystem.Disable();
      if (delay)
        yield return (object) Sequences.Wait(0.5f);
      InputSystem.Enable();
      UnityEngine.Random.InitState(node.seed);
      yield return (object) node.type.Run(node);
    }
  }

  public static void FirstSave()
  {
    if (!Campaign.Data.GameMode.doSave)
      return;
    SaveSystem.SaveCampaignData<string>(Campaign.Data.GameMode, "gameVersion", Campaign.Data.GameVersion);
    SaveSystem.SaveCampaignData<string>(Campaign.Data.GameMode, "gameMode", Campaign.Data.GameMode.name);
    string str = Campaign.Data.GameMode.dailyRun ? DailyFetcher.GetDateTime().ToString("dd/MM/yyyy") : DateTime.Now.ToString("dd/MM/yyyy");
    SaveSystem.SaveCampaignData<string>(Campaign.Data.GameMode, "startDate", str);
    Campaign.PromptSave();
  }

  public static void PromptSave()
  {
    if (Campaign.Data.GameMode.doSave)
    {
      SaveSystem.SaveCampaignData<CampaignSaveData>(Campaign.Data.GameMode, "data", Campaign.instance.Save());
      if (Campaign.instance.result != Campaign.Result.None)
        SaveSystem.SaveCampaignData<Campaign.Result>(Campaign.Data.GameMode, "result", Campaign.instance.result);
    }
    global::Events.InvokeCampaignSaved();
  }

  public static bool CheckVictory()
  {
    CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
    return characterNode.finalNode || characterNode.connections.Count <= 0;
  }

  public static bool CheckContinue(GameMode gameMode)
  {
    return gameMode.doSave && SaveSystem.CampaignExists(gameMode) && SaveSystem.LoadCampaignData<Campaign.Result>(gameMode, "result", Campaign.Result.None) == Campaign.Result.None && SaveSystem.CampaignDataExists(gameMode, "data");
  }

  public CampaignSaveData Save() => new CampaignSaveData(this);

  public enum Result
  {
    None,
    Win,
    Lose,
    Restart,
  }
}
