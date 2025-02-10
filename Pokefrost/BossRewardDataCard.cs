// Decompiled with JetBrains decompiler
// Type: Pokefrost.BossRewardDataCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class BossRewardDataCard : BossRewardData
  {
    public static BossRewardDataCard.Data Example(string name = "spinda")
    {
      BossRewardDataCard.Data data = new BossRewardDataCard.Data();
      data.cardDataName = name;
      data.type = BossRewardData.Type.Crown;
      return data;
    }

    public override BossRewardData.Data Pull()
    {
      BossRewardDataCard.Data data = new BossRewardDataCard.Data();
      data.type = BossRewardData.Type.Crown;
      return (BossRewardData.Data) data;
    }

    public new class Data : BossRewardData.Data
    {
      public string cardDataName;
      public Entity card;

      public CardData GetCardData() => Pokefrost.Pokefrost.instance.Get<CardData>(this.cardDataName);

      public override void Select()
      {
        References.PlayerData.inventory.deck.Add(this.card.data);
        this.MoveCardToDeck(this.card);
      }

      private void MoveCardToDeck(Entity entity)
      {
        global::Events.InvokeEntityEnterBackpack(entity);
        entity.transform.parent = References.Player.entity.display.transform;
        entity.display?.hover?.Disable();
        Routine routine = new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) entity));
      }
    }

    [HarmonyPatch(typeof (BossRewardSelectCrown), "SetUp")]
    private class PatchBossRewardCard
    {
      private static void Postfix(
        BossRewardSelectCrown __instance,
        BossRewardData.Data rewardData,
        GainBlessingSequence2 gainBlessingSequence)
      {
        BossRewardDataCard.Data data = rewardData as BossRewardDataCard.Data;
        if (data == null)
          return;
        __instance.crownImage.color = new Color(1f, 1f, 1f, 0.0f);
        CardData cardData = data.GetCardData().Clone();
        GameObject gameObject = __instance.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
        CardLane lane = gameObject.AddComponent<CardLane>();
        lane.holder = gameObject.GetComponent<RectTransform>();
        lane.onAdd = new UnityEventEntity();
        lane.onRemove = new UnityEventEntity();
        lane.SetSize(1, 0.7f);
        CardControllerSelectCard controllerSelectCard = gameObject.AddComponent<CardControllerSelectCard>();
        controllerSelectCard.pressEvent = new UnityEventEntity();
        controllerSelectCard.hoverEvent = new UnityEventEntity();
        controllerSelectCard.unHoverEvent = new UnityEventEntity();
        lane.AssignController((CardController) controllerSelectCard);
        __instance.popUpName = "{popUpName}";
        __instance.title = cardData.title;
        __instance.body = "Spin-da to Win-da!!";
        controllerSelectCard.pressEvent.AddListener((UnityAction<Entity>) (d =>
        {
          gainBlessingSequence.Select((BossRewardData.Data) data);
          __instance.StartCoroutine(BossRewardDataCard.PatchBossRewardCard.DelayDestroy(__instance));
        }));
        __instance.StartCoroutine(BossRewardDataCard.PatchBossRewardCard.SetUpEntity(lane, data, cardData, controllerSelectCard));
      }

      private static IEnumerator DelayDestroy(BossRewardSelectCrown __instance)
      {
        yield return (object) new WaitForSeconds(0.05f);
        __instance.UnPop();
        __instance.gameObject.SetActive(false);
      }

      private static IEnumerator SetUpEntity(
        CardLane lane,
        BossRewardDataCard.Data data,
        CardData cardData,
        CardControllerSelectCard cc)
      {
        Card card = CardManager.Get(cardData, (CardController) cc, References.Player, false, true);
        yield return (object) card.UpdateData(false);
        lane.Add(card.entity);
        data.card = card.entity;
        global::Events.InvokeEntityOffered(card.entity);
        lane.SetChildPositions();
        card.FlipUp();
      }
    }
  }
}
