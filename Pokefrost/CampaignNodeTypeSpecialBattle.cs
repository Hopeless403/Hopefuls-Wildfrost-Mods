// Decompiled with JetBrains decompiler
// Type: Pokefrost.CampaignNodeTypeSpecialBattle
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class CampaignNodeTypeSpecialBattle : CampaignNodeTypeBattle
  {
    public override IEnumerator Run(CampaignNode node)
    {
      string failureText = "Conditions not met!";
      bool flag = false;
      QuestSystem theQuest = (QuestSystem) null;
      QuestSystem[] questSystemArray1 = Campaign.instance.systems.GetComponents<QuestSystem>();
      for (int index = 0; index < questSystemArray1.Length; ++index)
      {
        QuestSystem quest = questSystemArray1[index];
        if (quest.CheckConditions(out failureText))
        {
          flag = true;
          theQuest = quest;
          break;
        }
        quest = (QuestSystem) null;
      }
      questSystemArray1 = (QuestSystem[]) null;
      if (!flag)
      {
        QuestSystem[] questSystemArray2 = Campaign.instance.gameObject.GetComponents<QuestSystem>();
        for (int index = 0; index < questSystemArray2.Length; ++index)
        {
          QuestSystem quest = questSystemArray2[index];
          if (quest.CheckConditions(out failureText))
          {
            flag = true;
            theQuest = quest;
            break;
          }
          quest = (QuestSystem) null;
        }
        questSystemArray2 = (QuestSystem[]) null;
      }
      if (flag || (UnityEngine.Object) References.Map == (UnityEngine.Object) null)
      {
        Debug.Log((object) "[Pokefrost] Quest succeeded! Entering bonus battle...");
        theQuest?.QuestBattleStart();
        yield return (object) base.Run(node);
        theQuest?.QuestBattleFinish();
      }
      else
      {
        Debug.Log((object) "[Pokefrost] Quest failed. Skipping bonus battle...");
        Ext.PopupText(References.Map.FindNode(Campaign.FindCharacterNode(References.Player)).transform, failureText, false);
        yield return (object) Sequences.Wait(1f);
        node.SetCleared();
        References.Map.Continue();
      }
    }

    internal virtual BattleData SelectBattle()
    {
      if (EventBattleManager.battleList.ContainsKey(EventBattleManager.forceBattle))
      {
        EventBattleManager.battleChosen = EventBattleManager.forceBattle;
        return Pokefrost.Pokefrost.instance.Get<BattleData>(EventBattleManager.forceBattle);
      }
      foreach (string name in (IEnumerable<string>) EventBattleManager.battleList.Keys.InRandomOrder<string>())
      {
        BattleData battleData = Pokefrost.Pokefrost.instance.Get<BattleData>(name);
        if ((UnityEngine.Object) battleData != (UnityEngine.Object) null)
        {
          EventBattleManager.battleChosen = name;
          return battleData;
        }
      }
      throw new Exception("No Event Battle Found");
    }

    public override IEnumerator SetUp(CampaignNode node)
    {
      BattleData battle = this.SelectBattle();
      foreach (string str in (IEnumerable<string>) EventBattleManager.battleList.Keys.InRandomOrder<string>())
      {
        string battleName = str;
        battle = Pokefrost.Pokefrost.instance.Get<BattleData>(battleName);
        if ((UnityEngine.Object) battle != (UnityEngine.Object) null)
        {
          EventBattleManager.battleChosen = battleName;
          break;
        }
        battleName = (string) null;
      }
      node.data = new Dictionary<string, object>()
      {
        ["battle"] = (object) battle.name,
        ["waves"] = (object) battle.generationScript.Run(battle, 100)
      };
      if (battle is BattleDataWithRewards b)
        b.AddRewards(node);
      this.isBattle = true;
      yield break;
    }
  }
}
