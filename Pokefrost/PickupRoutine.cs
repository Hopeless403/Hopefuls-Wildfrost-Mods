// Decompiled with JetBrains decompiler
// Type: Pokefrost.PickupRoutine
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal static class PickupRoutine
  {
    private static GameObject objectGroup;
    private static GameObject obj;
    private static ChooseNewCardSequence sequence;
    private static Transform deadCards;
    private static bool active = false;
    private static List<(string, int)> queue = new List<(string, int)>();

    public static bool Active => PickupRoutine.queue.Count != 0;

    public static void Queue(string name, int amount) => PickupRoutine.queue.Add((name, amount));

    public static void Debug1()
    {
      PickupRoutine.Create("<color=#8F0>Pizza Frog</color> Found A Card");
    }

    public static void Debug2(int amount = 4)
    {
      RewardPool rewardPool = Extensions.GetRewardPool("GeneralItemPool");
      MonoBehaviourSingleton<References>.instance.StartCoroutine(PickupRoutine.AddRandomCards(amount, new RewardPool[1]
      {
        rewardPool
      }));
    }

    public static async Task Debug3()
    {
      MonoBehaviourSingleton<References>.instance.StartCoroutine(PickupRoutine.Run());
    }

    public static void Debug4()
    {
      global::Events.PreBattleEnd += new global::Events.AsyncAction(PickupRoutine.Debug3);
    }

    public static void OnSceneChanged(Scene scene)
    {
      if (scene.name == "Battle" || scene.name == "Town" || scene.name == "CharacterSelect")
        PickupRoutine.queue.Clear();
      if (!(scene.name == "MapNew") || !PickupRoutine.Active)
        return;
      ActionQueue.Stack((PlayAction) new ActionSequence(PickupRoutine.RunMultiple()));
    }

    public static void Create(string text)
    {
      if ((UnityEngine.Object) PickupRoutine.objectGroup != (UnityEngine.Object) null)
      {
        PickupRoutine.objectGroup.GetComponentInChildren<FloatingText>().SetText(text);
      }
      else
      {
        PickupRoutine.objectGroup = new GameObject("SelectCardRoutine");
        PickupRoutine.objectGroup.SetActive(false);
        PickupRoutine.objectGroup.transform.SetParent(GameObject.Find("Canvas/Padding/HUD/DeckpackLayout").transform.parent.GetChild(0));
        PickupRoutine.objectGroup.transform.SetAsFirstSibling();
        GameObject gameObject1 = UICollector.PullPrefab("Box", "Background", PickupRoutine.objectGroup);
        gameObject1.GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 15f);
        gameObject1.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.8f);
        GameObject gameObject2 = UICollector.PullPrefab("Text", "Title", PickupRoutine.objectGroup);
        gameObject2.GetComponent<FloatingText>().SetText(text);
        gameObject2.transform.position = new Vector3(0.0f, 4.5f, 0.0f);
        PickupRoutine.obj = new GameObject("SelectCard");
        PickupRoutine.obj.transform.SetParent(PickupRoutine.objectGroup.transform);
        PickupRoutine.obj.transform.Translate(new Vector3(0.0f, 1f, 0.0f));
        PickupRoutine.obj.AddComponent<RectTransform>().sizeDelta = new Vector2(7f, 2f);
        CardControllerSelectCard controller = PickupRoutine.obj.AddComponent<CardControllerSelectCard>();
        controller.owner = References.Player;
        controller.unHoverEvent = new UnityEventEntity();
        controller.hoverEvent = new UnityEventEntity();
        controller.pressEvent = new UnityEventEntity();
        controller.pressEvent.AddListener(new UnityAction<Entity>(PickupRoutine.Select));
        CardHand cardHand = PickupRoutine.obj.AddComponent<CardHand>();
        cardHand.fanCircleAngleAddCurve = new AnimationCurve();
        cardHand.staticAngleAdd = true;
        cardHand.holder = PickupRoutine.obj.GetComponent<RectTransform>();
        cardHand.onAdd = new UnityEventEntity();
        cardHand.onRemove = new UnityEventEntity();
        cardHand.AssignController((CardController) controller);
        cardHand.SetSize(5, 0.889f);
        CardSelector cardSelector = PickupRoutine.obj.AddComponent<CardSelector>();
        cardSelector.character = References.Player;
        cardSelector.selectEvent = new UnityEventEntity();
        GameObject gameObject3 = new GameObject("DeadObject");
        PickupRoutine.deadCards = gameObject3.transform;
        gameObject3.SetActive(false);
        PickupRoutine.sequence = PickupRoutine.objectGroup.AddComponent<ChooseNewCardSequence>();
        PickupRoutine.sequence.cardContainer = (CardContainer) cardHand;
        PickupRoutine.sequence.cardSelector = cardSelector;
        PickupRoutine.sequence.cardController = (CardController) controller;
        PickupRoutine.sequence.background = gameObject1.GetComponent<RectTransform>();
        PickupRoutine.sequence.cardGroupLayout = PickupRoutine.obj;
      }
    }

    public static IEnumerator AddRandomCards(int amount, RewardPool[] rewards)
    {
      CardHand hand = PickupRoutine.obj.GetComponent<CardHand>();
      Debug.Log((object) "[Pokefrost] Cleared!");
      hand.Clear();
      List<DataFile> data = new List<DataFile>();
      RewardPool[] rewardPoolArray = rewards;
      for (int index = 0; index < rewardPoolArray.Length; ++index)
      {
        RewardPool r = rewardPoolArray[index];
        data = data.Concat<DataFile>((IEnumerable<DataFile>) r.list).ToList<DataFile>();
        r = (RewardPool) null;
      }
      rewardPoolArray = (RewardPool[]) null;
      List<CardData> cards = data.Where<DataFile>((Func<DataFile, bool>) (d => d is CardData)).Select<DataFile, CardData>((Func<DataFile, CardData>) (d => (CardData) d)).ToList<CardData>();
      Routine.Clump clump = new Routine.Clump();
      foreach (CardData card in (IEnumerable<CardData>) cards.InRandomOrder<CardData>())
      {
        if (card.cardType.name != "Friendly")
        {
          Card item = CardManager.Get(card.Clone(), PickupRoutine.obj.GetComponent<CardController>(), References.Player, false, true);
          clump.Add(item.UpdateData(false));
          PickupRoutine.obj.GetComponent<CardContainer>().Add(item.entity);
          --amount;
          if (amount > 0)
            item = (Card) null;
          else
            break;
        }
      }
      yield return (object) clump.WaitForEnd();
      PickupRoutine.obj.GetComponent<CardContainer>().TweenChildPositions();
    }

    public static IEnumerator RunMultiple()
    {
      for (int i = PickupRoutine.queue.Count - 1; i >= 0; --i)
      {
        PickupRoutine.Create(PickupRoutine.queue[i].Item1);
        yield return (object) PickupRoutine.AddRandomCards(PickupRoutine.queue[i].Item2, PickupRoutine.GetPools());
        yield return (object) PickupRoutine.Run();
      }
      PickupRoutine.obj.SetActive(false);
      PickupRoutine.queue.Clear();
    }

    public static IEnumerator Run()
    {
      PickupRoutine.obj.SetActive(true);
      PickupRoutine.sequence.cardController.Enable();
      PickupRoutine.sequence.promptEnd = PickupRoutine.obj.GetComponent<CardHand>().entities.Count == 0;
      Coroutine hide = Campaign.instance.StartCoroutine(PickupRoutine.HideInDeckView());
      yield return (object) PickupRoutine.objectGroup.GetComponent<ChooseNewCardSequence>().Run();
      CardHand hand = PickupRoutine.obj.GetComponent<CardHand>();
      Debug.Log((object) "[Pokefrost] Cleared!");
      hand.Clear();
      Campaign.instance.StopCoroutine(hide);
    }

    public static IEnumerator HideInDeckView()
    {
      GameObject obj = GameObject.Find("Canvas/Padding/PlayerDisplay/DeckDisplay");
      while (true)
      {
        yield return (object) new WaitUntil((Func<bool>) (() => obj.activeSelf));
        yield return (object) new WaitForSeconds(0.1f);
        PickupRoutine.objectGroup.SetActive(false);
        yield return (object) new WaitUntil((Func<bool>) (() => !obj.activeSelf));
        PickupRoutine.objectGroup.SetActive(true);
      }
    }

    public static RewardPool[] GetPools()
    {
      List<ClassData> group = AddressableLoader.GetGroup<ClassData>("ClassData");
      ClassData classData1 = group[0];
      string name = References.Player.name;
      Debug.Log((object) ("[Pokefrost] " + name));
      foreach (ClassData classData2 in group)
      {
        if (name.ToLower().Contains(classData2.name.ToLower()))
        {
          classData1 = classData2;
          break;
        }
      }
      return ((IEnumerable<RewardPool>) classData1.rewardPools).Where<RewardPool>((Func<RewardPool, bool>) (r => (UnityEngine.Object) r != (UnityEngine.Object) null && r.type == "Items" && !r.isGeneralPool)).ToArray<RewardPool>();
    }

    public static void Select(Entity entity)
    {
      References.PlayerData.inventory.deck.Add(entity.data);
      PickupRoutine.sequence.cardController.Disable();
      entity.RemoveFromContainers();
      PickupRoutine.sequence.cardSelector.MoveCardToDeck(entity);
      PickupRoutine.sequence.promptEnd = true;
      global::Events.InvokeEntityChosen(entity);
    }
  }
}
