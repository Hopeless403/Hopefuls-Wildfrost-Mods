// Decompiled with JetBrains decompiler
// Type: Pokefrost.EventBattleManager
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using BattleEditor;
using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class EventBattleManager
  {
    public static EventBattleManager instance;
    public static float minChance = 0.25f;
    public static float maxChance = 1f;
    public bool successfulRoll = false;
    public static Dictionary<string, string> battleList = new Dictionary<string, string>();
    public static string battleChosen = "";
    public static string forceBattle = "";

    public EventBattleManager() => EventBattleManager.instance = this;

    public void Enable(Pokefrost.Pokefrost mod)
    {
      this.CreateBattles(mod);
      global::Events.OnCampaignLoadPreset += new global::Events.UnityActionRef<string[]>(this.RollForEvent);
      global::Events.OnPreCampaignPopulate += new UnityAction(this.HideNode);
      MoreEvents.OnCampaignGenerated += new UnityAction(this.AddEventItems);
    }

    public void Disable(Pokefrost.Pokefrost mod)
    {
      EventBattleManager.battleList.Clear();
      global::Events.OnCampaignLoadPreset -= new global::Events.UnityActionRef<string[]>(this.RollForEvent);
      global::Events.OnPreCampaignPopulate -= new UnityAction(this.HideNode);
      MoreEvents.OnCampaignGenerated -= new UnityAction(this.AddEventItems);
    }

    private void CreateBattles(Pokefrost.Pokefrost mod)
    {
      new BattleDataEditor((WildfrostMod) mod).Create<BattleDataWithRewards>("Darkrai").SetASprite("MapDarkrai").SetNameRef("Dark Crater Pit").EnemyDictionary(('D', "enemy_darkrai"), ('H', "enemy_hypno"), ('M', "enemy_mismagius"), ('G', "enemy_magmortar"), ('S', "enemy_spiritomb")).StartWavePoolData(0, "Curses!").ConstructWaves(4, 0, "SMMS").StartWavePoolData(1, "More curses").ConstructWaves(4, 1, "HMMG", "GMMH", "HSMG", "SSHG").StartWavePoolData(2, "Darkrai is here!").ConstructWaves(3, 9, "DMH", "DGH").GiveMiniBossesCharms(new string[1]
      {
        "enemy_darkrai"
      }, "CardUpgradeDemonize", "CardUpgradeInk").FreeModify<BattleDataWithRewards>((Action<BattleDataWithRewards>) (b =>
      {
        b.dataGroups = new List<BossRewardData.Data>[3];
        b.dataGroups[0] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCard("darkrai"),
          (BossRewardData.Data) EventBattleManager.CreateCard("cresselia")
        };
        b.dataGroups[1] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeCurse"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeDuplicate")
        };
        b.dataGroups[2] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingDarkrai"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingCresselia")
        };
      })).AddBattleToLoader();
      new BattleDataEditor((WildfrostMod) mod).Create<BattleDataWithRewards>("Lati Twins").SetASprite("MapLati").SetNameRef("Southern Island").EnemyDictionary(('P', "enemy_plusle"), ('M', "enemy_minun"), ('V', "enemy_volbeat"), ('I', "enemy_illumise"), ('D', "enemy_dustox"), ('B', "enemy_beautifly"), ('G', "enemy_gorebyss"), ('H', "enemy_huntail"), ('S', "enemy_solrock"), ('L', "enemy_lunatone"), ('A', "enemy_latias"), ('O', "enemy_latios")).StartWavePoolData(0, "Charging up").ConstructWaves(4, 0, "PMDB").StartWavePoolData(1, "Scary").ConstructWaves(4, 1, "VIGH").StartWavePoolData(2, "Lati!").ConstructWaves(4, 9, "SLAO").GiveMiniBossesCharms(new string[1]
      {
        "enemy_latias"
      }, "CardUpgradeHeartmist", "CardUpgradeAcorn").GiveMiniBossesCharms(new string[1]
      {
        "enemy_latios"
      }, "CardUpgradeSpice", "CardUpgradeBattle").FreeModify<BattleDataWithRewards>((Action<BattleDataWithRewards>) (b =>
      {
        b.dataGroups = new List<BossRewardData.Data>[3];
        b.dataGroups[0] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCard("latias"),
          (BossRewardData.Data) EventBattleManager.CreateCard("latios")
        };
        b.dataGroups[1] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeResist"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeCharged")
        };
        b.dataGroups[2] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingLatias"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingLatios")
        };
      })).AddBattleToLoader();
      new BattleDataEditor((WildfrostMod) mod).Create<BattleDataWithRewards>("Ho-Oh").SetASprite("MapHooh").SetNameRef("Mt. Faraway").EnemyDictionary(('H', "enemy_hooh"), ('E', "enemy_entei"), ('R', "enemy_raikou"), ('S', "enemy_suicune"), ('V', "enemy_vaporeon"), ('J', "enemy_jolteon"), ('F', "enemy_flareon"), ('P', "enemy_espeon"), ('U', "enemy_umbreon"), ('L', "enemy_leafeon"), ('G', "enemy_glaceon"), ('Y', "enemy_sylveon")).StartWavePoolData(0, "Mystery").ConstructWaves(1, 0, "H").StartWavePoolData(1, "Beasts").ConstructWaves(2, 1, "EF", "RJ", "SV").StartWavePoolData(2, "Eeveeloutions").ConstructWaves(2, 9, "PU", "GL", "Y").GiveMiniBossesCharms(new string[1]
      {
        "enemy_hooh"
      }, "CardUpgradeCloudberry", "CardUpgradeBlock").GiveMiniBossesCharms(new string[1]
      {
        "enemy_suicune"
      }, "CardUpgradeBlock", "CardUpgradeBoost").GiveMiniBossesCharms(new string[1]
      {
        "enemy_raikou"
      }, "CardUpgradeSun", "CardUpgradeAimless").GiveMiniBossesCharms(new string[1]
      {
        "enemy_entei"
      }, "CardUpgradeAttackAndHealth", "CardUpgradeTrashBad").SetGenerationScript((BattleGenerationScript) ScriptableObject.CreateInstance<BattleGenerationScriptHooh>()).FreeModify<BattleDataWithRewards>((Action<BattleDataWithRewards>) (b =>
      {
        b.bonusPulls = 1;
        b.bonusProfile = new List<int>() { 0, 1, 1 };
        b.dataGroups = new List<BossRewardData.Data>[3];
        b.dataGroups[0] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCard("raikou"),
          (BossRewardData.Data) EventBattleManager.CreateCard("entei"),
          (BossRewardData.Data) EventBattleManager.CreateCard("suicune"),
          (BossRewardData.Data) EventBattleManager.CreateCard("hooh")
        };
        b.dataGroups[1] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeConduit"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeBackBurn"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeJuice"),
          (BossRewardData.Data) EventBattleManager.CreateCharm("CardUpgradeSacredAsh")
        };
        b.dataGroups[2] = new List<BossRewardData.Data>()
        {
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingSpicune"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingRaikou"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingEntei"),
          (BossRewardData.Data) EventBattleManager.CreateBell("BlessingHooh")
        };
      })).AddBattleToLoader();
      EventBattleManager.battleList["Darkrai"] = "darkraiEvent";
      EventBattleManager.battleList["Lati Twins"] = "latiEvent";
      EventBattleManager.battleList["Ho-Oh"] = "hoohEvent";
    }

    private void RollForEvent(ref string[] lines)
    {
      CampaignNodeTypeBattle campaignNodeTypeBattle = Pokefrost.Pokefrost.instance.Get<CampaignNodeType>("specialBattle") as CampaignNodeTypeBattle;
      if ((UnityEngine.Object) campaignNodeTypeBattle != (UnityEngine.Object) null)
        campaignNodeTypeBattle.isBattle = false;
      float num1 = Dead.Random.Range(0.0f, 1f);
      float num2 = EventBattleManager.minChance + (float) ((double) StormBellManager.GetCurrentStormPoints(StormBellManager.GetActiveStormBells()) / 10.0 * ((double) EventBattleManager.maxChance - (double) EventBattleManager.minChance));
      Debug.Log((object) string.Format("[Pokefrost] {0}", (object) num2));
      if ((double) num1 > (double) num2)
      {
        this.successfulRoll = false;
      }
      else
      {
        int length1 = lines.Length;
        int length2 = lines[0].Length;
        for (int index1 = 0; index1 < length2; ++index1)
        {
          if (lines[0][index1] == 'B' && lines[length1 - 1].Length > index1 && lines[length1 - 1][index1] == '1')
          {
            lines[0] = lines[0].Insert(index1 + 1, "e");
            lines[length1 - 2] = lines[length1 - 2].Insert(index1 + 1, "6");
            lines[length1 - 1] = lines[length1 - 1].Insert(index1 + 1, "2");
            for (int index2 = 1; index2 < length1 - 2; ++index2)
              lines[index2] = lines[index2].Insert(index1 + 1, " ");
            this.successfulRoll = true;
            break;
          }
        }
      }
    }

    private void HideNode()
    {
      if (!this.successfulRoll)
        return;
      for (int index = 0; index < Campaign.instance.nodes.Count; ++index)
      {
        CampaignNode node = Campaign.instance.nodes[index];
        if (node.type.letter == "e")
        {
          Debug.Log((object) "[Pokefrost] Hiding battle node");
          Campaign.instance.nodes[index - 1].connections = node.connections;
          node.connections = new List<CampaignNode.Connection>();
          break;
        }
      }
    }

    internal void ReturnNode()
    {
      for (int index = 0; index < Campaign.instance.nodes.Count; ++index)
      {
        CampaignNode node1 = Campaign.instance.nodes[index];
        if (node1.type.letter == "e")
        {
          Debug.Log((object) "[Pokefrost] Returning battle node");
          CampaignNode node2 = Campaign.instance.nodes[index - 1];
          if (node1.connections.Count > 0)
            break;
          node1.connections = node2.connections;
          node2.connections = new List<CampaignNode.Connection>()
          {
            new CampaignNode.Connection()
            {
              otherId = node1.id,
              direction = 1f
            }
          };
          break;
        }
      }
    }

    private void AddEventItems()
    {
      if (!this.successfulRoll)
        return;
      Debug.Log((object) "[Pokefrost] Starting...");
      for (int index = 0; index < References.Campaign.nodes.Count; ++index)
      {
        CampaignNode node = References.Campaign.nodes[index];
        if (node.type is CampaignNodeTypeBoss)
        {
          Debug.Log((object) "[Pokefrost] Found Act I Boss node");
          node.data.Get<CampaignNodeTypeBoss.RewardData>("rewards").rewards.Add((BossRewardData.Data) new BossRewardDataModifier.Data()
          {
            modifierName = (Pokefrost.Pokefrost.instance.GUID + "." + EventBattleManager.battleList[EventBattleManager.battleChosen])
          });
          Debug.Log((object) "[Pokefrost] Success!");
          break;
        }
      }
      this.successfulRoll = false;
    }

    public static BossRewardDataCard.Data CreateCard(string cardName)
    {
      BossRewardDataCard.Data card = new BossRewardDataCard.Data();
      card.type = BossRewardData.Type.Crown;
      card.cardDataName = cardName;
      return card;
    }

    public static BossRewardDataRandomCharm.Data CreateCharm(string upgradeName)
    {
      BossRewardDataRandomCharm.Data charm = new BossRewardDataRandomCharm.Data();
      charm.type = BossRewardData.Type.Charm;
      charm.upgradeName = Pokefrost.Pokefrost.instance.GUID + "." + upgradeName;
      return charm;
    }

    public static BossRewardDataModifier.Data CreateBell(string modifierName)
    {
      BossRewardDataModifier.Data bell = new BossRewardDataModifier.Data();
      bell.type = BossRewardData.Type.Modifier;
      bell.modifierName = Pokefrost.Pokefrost.instance.GUID + "." + modifierName;
      return bell;
    }
  }
}
