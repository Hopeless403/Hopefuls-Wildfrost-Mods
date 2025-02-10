// Decompiled with JetBrains decompiler
// Type: CardOrganizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CardOrganizer : MonoBehaviour
{
  [SerializeField]
  public Canvas canvas;
  [SerializeField]
  public CardContainer cardHolder;
  [SerializeField]
  public CardController cardController;
  [Header("Card Grid")]
  [SerializeField]
  public int gridColumns = 8;
  [SerializeField]
  public Vector2 gridSpacing;
  public Vector2 startPos;
  public bool inspecting;

  public static string filePath => Application.streamingAssetsPath + "/Cards.json";

  public Vector2 GetCellSize() => GameManager.CARD_SIZE + this.gridSpacing;

  public void OnEnable()
  {
    global::Events.OnInspect += new UnityAction<Entity>(this.InspectStart);
    global::Events.OnInspectEnd += new UnityAction<Entity>(this.InspectEnd);
  }

  public void OnDisable()
  {
    global::Events.OnInspect -= new UnityAction<Entity>(this.InspectStart);
    global::Events.OnInspectEnd -= new UnityAction<Entity>(this.InspectEnd);
  }

  public void InspectStart(Entity entity) => this.inspecting = true;

  public void InspectEnd(Entity entity) => this.inspecting = false;

  public IEnumerator Start()
  {
    if (GameManager.Ready)
    {
      yield return (object) AddressableLoader.LoadGroup("CardData");
      List<CardData> cardDataList = AddressableLoader.GetGroup<CardData>("CardData");
      int num1 = Mathf.RoundToInt((float) (cardDataList.Count / this.gridColumns));
      int num2 = Mathf.Min(this.gridColumns, cardDataList.Count);
      float num3 = (float) ((double) num2 * 3.0 + (double) (num2 - 1) * (double) this.gridSpacing.x);
      float num4 = (float) ((double) num1 * 4.5 + (double) (num1 - 1) * (double) this.gridSpacing.y);
      this.startPos.x = (float) (-(double) num3 / 2.0 + 1.5);
      this.startPos.y = (float) ((double) num4 / 2.0 - 2.25);
      yield return (object) this.Load();
      List<Entity> list = this.cardHolder.GetComponentsInChildren<Entity>().ToList<Entity>();
      Routine.Clump clump = new Routine.Clump();
      for (int index = 0; index < cardDataList.Count; ++index)
      {
        CardData cardData = cardDataList[index];
        if (!list.Exists((Predicate<Entity>) (a => a.data.name == cardData.name)))
        {
          Vector2 cardPos = this.GetCardPos(index);
          clump.Add(this.CreateCard(cardData, cardPos));
        }
      }
      yield return (object) clump.WaitForEnd();
      Transition.End();
      cardDataList = (List<CardData>) null;
    }
  }

  public Vector2 GetCardPos(int cardIndex)
  {
    int num = Mathf.FloorToInt((float) (cardIndex / this.gridColumns));
    return new Vector2(this.startPos.x + (float) (cardIndex % this.gridColumns) * (3f + this.gridSpacing.x), this.startPos.y - (float) num * (4.5f + this.gridSpacing.y));
  }

  public IEnumerator CreateCard(CardData cardData, Vector2 pos)
  {
    Card card = CardManager.Get(cardData.Clone(), this.cardController, (Character) null, false, true);
    card.entity.returnToPool = false;
    yield return (object) card.UpdateData(false);
    card.entity.transform.localPosition = pos.WithZ(0.0f);
    this.cardHolder.Add(card.entity);
  }

  public void OnDestroy()
  {
    if (!GameManager.Ready)
      return;
    this.Save();
  }

  public void Update()
  {
    if (this.inspecting)
      return;
    if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.LeftControl))
    {
      Entity hover = this.GetHover();
      if ((bool) (UnityEngine.Object) hover)
      {
        this.cardController.UnHover();
        Routine routine = new Routine(this.CreateCard(hover.data, (Vector2) (hover.transform.localPosition + new Vector3(0.25f, -0.25f))));
        Debug.Log((object) ("Duplicating [" + hover.name + "]"));
      }
      else
        Debug.Log((object) "Nothing to duplicate!");
    }
    if (!Input.GetKeyDown(KeyCode.Delete))
      return;
    Entity target = this.GetHover();
    if ((bool) (UnityEngine.Object) target)
    {
      if (((IEnumerable<Entity>) this.cardHolder.GetComponentsInChildren<Entity>(true)).Count<Entity>((Func<Entity, bool>) (a => a.data.name == target.data.name)) > 1)
      {
        Debug.Log((object) ("Deleting [" + target.name + "]"));
        this.cardController.UnHover();
        UnityEngine.Object.Destroy((UnityEngine.Object) target.gameObject);
      }
      else
      {
        Debug.Log((object) ("Cannot delete [" + target.name + "]"));
        target.wobbler?.WobbleRandom();
      }
    }
    else
      Debug.Log((object) "Nothing to delete!");
  }

  public Entity GetHover() => this.cardController.dragging ?? this.cardController.hoverEntity;

  public void Save()
  {
    Debug.Log((object) string.Format("[{0}] SAVING DATA", (object) this));
    File.WriteAllText(CardOrganizer.filePath, JsonUtility.ToJson((object) new CardOrganizer.Data(this.cardHolder.GetComponentsInChildren<Entity>(true))));
    Debug.Log((object) "Done!");
  }

  public IEnumerator Load()
  {
    CardOrganizer cardOrganizer = this;
    Debug.Log((object) string.Format("[{0}] LOADING DATA", (object) cardOrganizer));
    if (File.Exists(CardOrganizer.filePath))
    {
      CardOrganizer.Data data = JsonUtility.FromJson<CardOrganizer.Data>(File.ReadAllText(CardOrganizer.filePath));
      Routine.Clump clump = new Routine.Clump();
      foreach (CardOrganizer.Data.Card card in data.cards)
      {
        CardData result;
        if (AddressableLoader.TryGet<CardData>("CardData", card.cardDataName, out result))
          clump.Add(cardOrganizer.CreateCard(result, new Vector2(card.posX, card.posY)));
      }
      yield return (object) clump.WaitForEnd();
    }
    else
      Debug.Log((object) ("[" + CardOrganizer.filePath + "] does not exist..."));
  }

  [Serializable]
  public class Data
  {
    public CardOrganizer.Data.Card[] cards;

    public Data(params Entity[] entities)
    {
      List<CardOrganizer.Data.Card> cardList = new List<CardOrganizer.Data.Card>();
      foreach (Entity entity in entities)
        cardList.Add(new CardOrganizer.Data.Card(entity));
      this.cards = cardList.ToArray();
    }

    [Serializable]
    public class Card
    {
      public string cardDataName;
      public float posX;
      public float posY;

      public Card(Entity entity)
      {
        this.cardDataName = entity.data.name;
        this.posX = entity.transform.localPosition.x;
        this.posY = entity.transform.localPosition.y;
      }
    }
  }
}
