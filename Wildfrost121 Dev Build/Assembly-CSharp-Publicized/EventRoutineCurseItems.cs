// Decompiled with JetBrains decompiler
// Type: EventRoutineCurseItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class EventRoutineCurseItems : EventRoutine
{
  [SerializeField]
  public ChooseNewCardSequence sequence;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public CardContainer cardContainer;
  [SerializeField]
  public Transform curseCardContainer;
  [SerializeField]
  public LocalizedString chooseKey;
  [SerializeField]
  public float cardScale = 0.8f;
  [SerializeField]
  public GameObject backButton;
  [SerializeField]
  public Talker talker;
  [SerializeField]
  public EventReference takeSfxEvent;
  public bool analyticsEventSent;
  public readonly List<Entity> cards = new List<Entity>();
  public readonly List<Entity> curses = new List<Entity>();

  public override IEnumerator Populate()
  {
    EventRoutineCurseItems routineCurseItems = this;
    Routine.Clump clump = new Routine.Clump();
    string[] saveCollection = routineCurseItems.data.GetSaveCollection<string>("cards");
    routineCurseItems.cardContainer.SetSize(saveCollection.Length, routineCurseItems.cardScale);
    for (int cardIndex = 0; cardIndex < saveCollection.Length; ++cardIndex)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", saveCollection[cardIndex]).Clone();
      routineCurseItems.CheckAddUpgrades(cardIndex, cardData);
      Card card = CardManager.Get(cardData, routineCurseItems.cardController, routineCurseItems.player, false, true);
      routineCurseItems.cards.Add(card.entity);
      card.entity.flipper.FlipDownInstant();
      routineCurseItems.cardContainer.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    foreach (string save in routineCurseItems.data.GetSaveCollection<string>("curses"))
    {
      if (save != null)
      {
        Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", save).Clone(), routineCurseItems.cardController, routineCurseItems.player, false, true);
        card.entity.uINavigationItem.enabled = false;
        routineCurseItems.curses.Add(card.entity);
        card.transform.SetParent(routineCurseItems.curseCardContainer);
        clump.Add(card.UpdateData(false));
        card.entity.flipper.FlipDownInstant();
      }
      else
        routineCurseItems.curses.Add((Entity) null);
    }
    yield return (object) clump.WaitForEnd();
    for (int index = 0; index < routineCurseItems.cardContainer.Count; ++index)
    {
      Entity child = routineCurseItems.cardContainer[index];
      Transform transform1 = child.transform;
      transform1.localPosition = routineCurseItems.cardContainer.GetChildPosition(child);
      transform1.localScale = routineCurseItems.cardContainer.GetChildScale(child);
      transform1.localEulerAngles = routineCurseItems.cardContainer.GetChildRotation(child);
      Entity curse = routineCurseItems.curses[index];
      if ((bool) (UnityEngine.Object) curse)
      {
        Transform transform2 = curse.transform;
        transform2.position = transform1.position;
        transform2.localScale = Vector3.one * 0.85f;
        transform2.localEulerAngles = new Vector3(0.0f, 0.0f, -UnityEngine.Random.Range(5f, 10f));
      }
    }
  }

  public override IEnumerator Run()
  {
    EventRoutineCurseItems routineCurseItems = this;
    int num = routineCurseItems.data.Get<int>("enterCount", 0) + 1;
    routineCurseItems.data["enterCount"] = (object) num;
    if (num == 1)
      routineCurseItems.talker.Say("greet", PettyRandom.Range(0.5f, 1f));
    routineCurseItems.sequence.owner = routineCurseItems.player;
    routineCurseItems.cardController.owner = routineCurseItems.player;
    routineCurseItems.cardSelector.character = routineCurseItems.player;
    CinemaBarSystem.Top.SetScript(routineCurseItems.chooseKey.GetLocalizedString());
    if (!routineCurseItems.data.Get<bool>("analyticsEventSent", false))
    {
      foreach (Entity entity in routineCurseItems.cardContainer)
        Events.InvokeEntityOffered(entity);
      routineCurseItems.data["analyticsEventSent"] = (object) true;
    }
    yield return (object) routineCurseItems.sequence.Run();
    CinemaBarSystem.Clear();
    if (routineCurseItems.data.Get<SaveCollection<string>>("cards").Count <= 0)
      routineCurseItems.node.SetCleared();
  }

  public void TrySelect(Entity entity)
  {
    ActionSelect action = new ActionSelect(entity, (Action<Entity>) (e => this.StartCoroutine(this.TakeCard(entity))));
    if (!Events.CheckAction((PlayAction) action))
      return;
    ActionQueue.Add((PlayAction) action);
  }

  public IEnumerator TakeCard(Entity entity)
  {
    EventRoutineCurseItems routineCurseItems = this;
    SfxSystem.OneShot(routineCurseItems.takeSfxEvent);
    routineCurseItems.cardController.Disable();
    routineCurseItems.backButton.SetActive(false);
    int index = routineCurseItems.cards.IndexOf(entity);
    Transform transform1 = entity.transform;
    Entity curse = routineCurseItems.curses[index];
    if ((bool) (UnityEngine.Object) curse)
    {
      Transform transform2 = curse.transform;
      transform2.position = transform1.position;
      transform2.localScale = Vector3.one * routineCurseItems.cardScale;
      transform2.localRotation = Quaternion.identity;
      curse.gameObject.SetActive(true);
      curse.flipper.FlipDownInstant();
    }
    routineCurseItems.cards.RemoveAt(index);
    SaveCollection<string> saveCollection1 = routineCurseItems.data.Get<SaveCollection<string>>("cards");
    saveCollection1.Remove(index);
    routineCurseItems.data["cards"] = (object) saveCollection1;
    routineCurseItems.curses.RemoveAt(index);
    SaveCollection<string> saveCollection2 = routineCurseItems.data.Get<SaveCollection<string>>("curses");
    saveCollection2.Remove(index);
    routineCurseItems.data["curses"] = (object) saveCollection2;
    routineCurseItems.cardSelector.TakeCard(entity);
    Events.InvokeEntityChosen(entity);
    routineCurseItems.talker.Say("thanks", 0.0f, (object) entity.data.title);
    if ((bool) (UnityEngine.Object) curse)
    {
      yield return (object) new WaitForSeconds(0.5f);
      curse.flipper.FlipUp();
      yield return (object) new WaitForSeconds(0.5f);
      routineCurseItems.cardSelector.TakeCard(curse);
      Events.InvokeEntityChosen(curse);
    }
    yield return (object) new WaitForSeconds(0.3f);
    routineCurseItems.cardController.Enable();
    routineCurseItems.backButton.SetActive(true);
  }

  public void Back()
  {
    this.cardContainer.DestroyAll();
    this.cardContainer.Clear();
    this.cards.Clear();
    foreach (Entity curse in this.curses)
    {
      if ((bool) (UnityEngine.Object) curse)
        CardManager.ReturnToPool(curse);
    }
    this.curses.Clear();
    this.sequence.End();
  }
}
