// Decompiled with JetBrains decompiler
// Type: Pokefrost.UICollector
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public static class UICollector
  {
    public static Dictionary<string, GameObject> Prefabs = new Dictionary<string, GameObject>();
    public static GameObject gameObject = (GameObject) null;

    public static IEnumerator CollectPrefabs()
    {
      if (!((UnityEngine.Object) UICollector.gameObject != (UnityEngine.Object) null))
      {
        UICollector.gameObject = new GameObject(nameof (UICollector));
        UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) UICollector.gameObject);
        UICollector.gameObject.SetActive(false);
        GameObject box = new GameObject("Box");
        box.AddComponent<Image>();
        UICollector.Prefabs.Add(box.name, box);
        box.transform.SetParent(UICollector.gameObject.transform, false);
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("Global")));
        GameObject floatingText = UnityEngine.Object.FindObjectOfType<FloatingTextManager>().CreatePrefab().gameObject;
        floatingText.name = "Text";
        UICollector.Prefabs.Add(floatingText.name, floatingText);
        floatingText.transform.SetParent(UICollector.gameObject.transform, false);
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("MainMenu")));
        GameObject button = GameObject.Find("ModsButton").InstantiateKeepName<GameObject>();
        button.name = "Button";
        UICollector.Prefabs.Add(button.name, button);
        button.transform.SetParent(UICollector.gameObject.transform, false);
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("Town")));
        GameObject backButton = GameObject.Find("Canvas/SafeArea/Back Button").InstantiateKeepName<GameObject>();
        backButton.name = "BackButton";
        UICollector.Prefabs.Add(backButton.name, backButton);
        backButton.transform.SetParent(UICollector.gameObject.transform, false);
        UICollector.PokemonTradeEvent();
      }
    }

    public static GameObject FindEx(string s) => GameObject.Find(s);

    public static GameObject PullPrefab(string key, string name, GameObject parent)
    {
      if (!UICollector.Prefabs.ContainsKey(key))
        Debug.Log((object) ("[UICollector] Could not find a prefab with key " + key));
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(UICollector.Prefabs[key], parent.transform);
      gameObject.name = name;
      return gameObject;
    }

    public static void PokemonTradeEvent()
    {
      GameObject gameObject1 = new GameObject("TradeEventManager");
      gameObject1.SetActive(false);
      CardControllerSelectCard controllerSelectCard = gameObject1.AddComponent<CardControllerSelectCard>();
      controllerSelectCard.pressEvent = new UnityEventEntity();
      controllerSelectCard.hoverEvent = new UnityEventEntity();
      controllerSelectCard.unHoverEvent = new UnityEventEntity();
      CardSelector cardSelector = gameObject1.AddComponent<CardSelector>();
      cardSelector.selectEvent = new UnityEventEntity();
      GameObject gameObject2 = new GameObject("Background");
      gameObject2.SetActive(false);
      gameObject2.transform.SetParent(gameObject1.transform, false);
      gameObject2.AddComponent<Image>().sprite = AddressableExtMethods.ASprite("trade_background");
      gameObject2.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 1f);
      gameObject2.transform.localScale = new Vector3(0.3f, 0.3f, 0.0f);
      GameObject gameObject3 = new GameObject("LineHolder");
      gameObject3.transform.SetParent(gameObject1.transform);
      gameObject3.transform.Translate(new Vector3(0.0f, -0.1f, 0.0f));
      GameObject gameObject4 = new GameObject("CardLane1");
      gameObject4.SetActive(false);
      gameObject4.AddComponent<Image>();
      gameObject4.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.0f);
      CardLane cardLane1 = gameObject4.AddComponent<CardLane>();
      cardLane1.holder = gameObject4.GetComponent<RectTransform>();
      cardLane1.onAdd = new UnityEventEntity();
      gameObject4.transform.SetParent(gameObject1.transform);
      gameObject4.transform.Translate(new Vector3(0.0f, 2.3f, 0.0f));
      cardLane1.gap = new Vector3(0.7f, 0.0f, 0.0f);
      GameObject gameObject5 = new GameObject("CardLane2");
      gameObject5.SetActive(false);
      gameObject5.AddComponent<Image>();
      gameObject5.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.0f);
      CardLane cardLane2 = gameObject5.AddComponent<CardLane>();
      cardLane2.holder = gameObject5.GetComponent<RectTransform>();
      cardLane2.onAdd = new UnityEventEntity();
      gameObject5.transform.SetParent(gameObject1.transform);
      gameObject5.transform.Translate(new Vector3(0.0f, -2.3f, 0.0f));
      cardLane2.gap = new Vector3(0.7f, 0.0f, 0.0f);
      GameObject gameObject6 = UICollector.PullPrefab("BackButton", "BackButton", gameObject1);
      gameObject6.transform.localPosition = new Vector3(-8f, 0.0f, 0.0f);
      GameObject parent = new GameObject("SelectBackground");
      parent.SetActive(false);
      parent.transform.SetParent(gameObject1.transform, false);
      parent.AddComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.6f);
      parent.GetComponent<RectTransform>().sizeDelta = new Vector2(100f, 100f);
      parent.AddComponent<UINavigationLayer>();
      GameObject gameObject7 = UICollector.PullPrefab("Button", "CancelButton", parent);
      gameObject7.GetComponent<RectTransform>().sizeDelta = new Vector2(4f, 1f);
      gameObject7.transform.localPosition = new Vector3(0.0f, -3.7f, 0.0f);
      GameObject gameObject8 = UICollector.PullPrefab("Button", "ConfirmButton", parent);
      gameObject8.GetComponent<RectTransform>().sizeDelta = new Vector2(4f, 1f);
      gameObject8.transform.localPosition = new Vector3(0.0f, -2.5f, 0.0f);
      GameObject gameObject9 = UICollector.PullPrefab("Text", "Title", gameObject1);
      gameObject9.GetComponentInChildren<TextMeshProUGUI>().text = "Trade Offers";
      gameObject9.transform.Translate(new Vector3(0.0f, 4.8f, 0.0f));
      EventRoutineTrade eventRoutineTrade = gameObject1.AddComponent<EventRoutineTrade>();
      eventRoutineTrade.cc = controllerSelectCard;
      eventRoutineTrade.cs = cardSelector;
      eventRoutineTrade.title = gameObject9.GetComponentInChildren<TextMeshProUGUI>();
      eventRoutineTrade.TradeLines = gameObject3;
      eventRoutineTrade.topRow = cardLane1;
      eventRoutineTrade.bottomRow = cardLane2;
      eventRoutineTrade.backButton = gameObject6;
      eventRoutineTrade.selectionBackground = parent;
      eventRoutineTrade.cancelObject = gameObject7;
      eventRoutineTrade.confirmObject = gameObject8;
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) gameObject1);
      gameObject2.SetActive(true);
      gameObject4.SetActive(true);
      gameObject5.SetActive(true);
      CampaignNodeTypeTrade.Prefabs.Add("Trade", gameObject1);
    }
  }
}
