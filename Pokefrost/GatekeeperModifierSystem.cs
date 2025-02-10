// Decompiled with JetBrains decompiler
// Type: Pokefrost.GatekeeperModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public class GatekeeperModifierSystem : QuestSystem
  {
    public static string Key_Fled = "websiteofsites.wildfrost.pokefrost.gatekeeperFlee";
    public string[] gatekeepers = new string[3]
    {
      "quest_entei",
      "quest_suicune",
      "quest_raikou"
    };

    public override string ProgressName => "ThreeBeasts";

    [PokeLocalizer]
    public new static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(GatekeeperModifierSystem.Key_Fled, "Nobody is here...");
    }

    public void OnEnable()
    {
      global::Events.OnEntityFlee += new UnityAction<Entity>(this.CheckFlee);
      global::Events.PostBattle += new UnityAction<CampaignNode>(this.ConfirmSpawn);
      this.FindProgress();
      if (this.progress != 0)
        return;
      this.SpawnGatekeepers();
    }

    private void ConfirmSpawn(CampaignNode _)
    {
      if (this.progress != 0)
        return;
      this.UpdateProgress(1);
    }

    public void OnDisable()
    {
      global::Events.OnEntityFlee -= new UnityAction<Entity>(this.CheckFlee);
      global::Events.PostBattle -= new UnityAction<CampaignNode>(this.ConfirmSpawn);
    }

    public void SpawnGatekeepers()
    {
      string[] array = ((IEnumerable<string>) this.gatekeepers).InRandomOrder<string>().ToArray<string>();
      int id = Campaign.FindCharacterNode(References.Player).id;
      int index1 = 0;
      for (int index2 = 0; index2 < Campaign.instance.nodes.Count && index1 < array.Length; ++index2)
      {
        CampaignNode node = Campaign.instance.nodes[index2];
        if (node.id > id)
        {
          if (node.type is CampaignNodeTypeSpecialBattle)
            break;
          if (node.type.isBattle && this.TryAddCard(array[index1], node))
            ++index1;
        }
      }
    }

    private bool TryAddCard(string name, CampaignNode node)
    {
      object obj;
      if (node.data.TryGetValue("waves", out obj))
      {
        BattleWaveManager.WaveData[] collection = ((SaveCollection<BattleWaveManager.WaveData>) obj).collection;
        for (int index = 0; index < collection.Length; ++index)
        {
          if (collection[index].Count < 6)
          {
            collection[index].AddCard(Pokefrost.Pokefrost.instance.Get<CardData>(name));
            return true;
          }
        }
        if (collection.Length != 0)
        {
          collection[0].AddCard(Pokefrost.Pokefrost.instance.Get<CardData>(name));
          return true;
        }
      }
      return false;
    }

    private void CheckFlee(Entity entity)
    {
      if (entity?.data?.name == null || !((IEnumerable<string>) this.gatekeepers).Select<string, string>((Func<string, string>) (s => Pokefrost.Pokefrost.instance.GUID + "." + s)).Contains<string>(entity.data.name))
        return;
      this.UpdateProgress(2);
    }

    public override bool CheckConditions(out string failureText)
    {
      failureText = this.GetFailureText(GatekeeperModifierSystem.Key_Fled);
      return this.progress == 1;
    }

    public override void QuestBattleFinish() => this.UpdateProgress(2);
  }
}
