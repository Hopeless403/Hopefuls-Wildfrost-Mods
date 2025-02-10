// Decompiled with JetBrains decompiler
// Type: CardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class CardManager : MonoBehaviourSingleton<CardManager>
{
  private static readonly Dictionary<string, GameObject> cardIcons = new Dictionary<string, GameObject>();
  private static readonly Vector3 startPos = new Vector3(-99f, -99f, 0.0f);
  private static readonly Dictionary<string, ObjectPool<Card>> cardPools = new Dictionary<string, ObjectPool<Card>>();
  public static bool init = false;
  private AsyncOperationHandle<IList<GameObject>> cardIconLoadHandle;
  public const float SCALE = 1f;
  public const float HOVER_SCALE = 1f;

  private IEnumerator Start()
  {
    CardManager cardManager = this;
    Transform t = cardManager.transform;
    foreach (CardType cardType in AddressableLoader.GetGroup<CardType>("CardType"))
    {
      AsyncOperationHandle<GameObject> handle = Addressables.LoadAssetAsync<GameObject>((object) cardType.prefabRef);
      yield return (object) handle;
      GameObject prefab = handle.Result;
      for (int index = 0; index < 3; ++index)
        CardManager.cardPools.Add(string.Format("{0}{1}", (object) cardType.name, (object) index), new ObjectPool<Card>((Func<Card>) (() => UnityEngine.Object.Instantiate<GameObject>(prefab, CardManager.startPos, (Quaternion) quaternion.identity, t).GetComponent<Card>()), (Action<Card>) (card =>
        {
          card.OnGetFromPool();
          card.entity.OnGetFromPool();
          card.transform.position = CardManager.startPos;
          card.transform.localRotation = Quaternion.identity;
          card.transform.localScale = Vector3.one;
          card.gameObject.SetActive(true);
        }), (Action<Card>) (card =>
        {
          card.transform.SetParent(t);
          card.OnReturnToPool();
          card.entity.OnReturnToPool();
          Events.InvokeCardPooled(card);
          card.gameObject.SetActive(false);
        }), (Action<Card>) (card => UnityEngine.Object.Destroy((UnityEngine.Object) card.gameObject)), false, 10, 20));
      handle = new AsyncOperationHandle<GameObject>();
    }
    cardManager.LoadCardIcons();
    CardManager.init = true;
  }

  private void LoadCardIcons()
  {
    if (this.cardIconLoadHandle.IsValid())
      Addressables.Release<IList<GameObject>>(this.cardIconLoadHandle);
    Debug.Log((object) "CardManager Loading Card Icon Prefabs");
    this.cardIconLoadHandle = Addressables.LoadAssetsAsync<GameObject>((object) "CardIcons", (Action<GameObject>) null);
    foreach (GameObject gameObject in (IEnumerable<GameObject>) this.cardIconLoadHandle.WaitForCompletion())
    {
      if ((UnityEngine.Object) gameObject != (UnityEngine.Object) null)
      {
        StatusIcon component = gameObject.GetComponent<StatusIcon>();
        if (component != null)
          CardManager.cardIcons[component.type] = gameObject;
      }
    }
    Debug.Log((object) string.Format("{0} icons loaded", (object) CardManager.cardIcons.Count));
  }

  public static Card Get(
    CardData data,
    CardController controller,
    Character owner,
    bool inPlay,
    bool isPlayerCard)
  {
    int frameLevel = isPlayerCard ? CardFramesSystem.GetFrameLevel(data.name) : 0;
    Card card = CardManager.cardPools[string.Format("{0}{1}", (object) data.cardType.name, (object) frameLevel)].Get();
    card.frameLevel = frameLevel;
    card.entity.data = data;
    card.entity.inPlay = inPlay;
    card.hover.controller = controller;
    card.entity.owner = owner;
    card.frameSetter.Load(frameLevel);
    Events.InvokeEntityCreated(card.entity);
    return card;
  }

  public static bool ReturnToPool(Entity entity)
  {
    if (entity.display is Card display)
      return CardManager.ReturnToPool(entity, display);
    UnityEngine.Object.Destroy((UnityEngine.Object) entity.gameObject);
    return false;
  }

  public static bool ReturnToPool(Card card) => CardManager.ReturnToPool(card.entity, card);

  public static bool ReturnToPool(Entity entity, Card card)
  {
    if (GameManager.End || entity.inCardPool)
      return false;
    if (!entity.returnToPool)
      UnityEngine.Object.Destroy((UnityEngine.Object) entity.gameObject);
    CardManager.cardPools[string.Format("{0}{1}", (object) entity.data.cardType.name, (object) card.frameLevel)].Release(card);
    return true;
  }

  public static StatusIcon NewStatusIcon(string type, Transform iconParent)
  {
    StatusIcon statusIcon = (StatusIcon) null;
    if (CardManager.cardIcons.ContainsKey(type))
      statusIcon = UnityEngine.Object.Instantiate<GameObject>(CardManager.cardIcons[type], iconParent).GetComponent<StatusIcon>();
    return statusIcon;
  }

  public static void ReturnToPoolNextFrame(Card card)
  {
    MonoBehaviourSingleton<CardManager>.instance.StartCoroutine(CardManager.ReturnToPoolNextFrameRoutine(card));
  }

  private static IEnumerator ReturnToPoolNextFrameRoutine(Card card)
  {
    yield return (object) null;
    CardManager.ReturnToPool(card);
  }
}
