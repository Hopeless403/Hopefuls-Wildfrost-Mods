// Decompiled with JetBrains decompiler
// Type: SelectStartingPet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class SelectStartingPet : MonoBehaviour, IRerollable
{
  [SerializeField]
  public SelectLeader leaderSelect;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer leaderContainer;
  [SerializeField]
  public CardContainer group;
  [SerializeField]
  public InspectNewUnitSequence selectionSequence;
  [SerializeField]
  public GameObject text;
  [SerializeField]
  public Vector3 startPos = new Vector3(0.0f, -7f, 0.0f);
  [SerializeField]
  public GameObject winStreakDisplay;
  [SerializeField]
  public TitleSetter titleSetter;
  public string[] petData;
  public readonly List<Entity> pets = new List<Entity>();
  [CompilerGenerated]
  public bool \u003Crunning\u003Ek__BackingField;
  [CompilerGenerated]
  public int \u003CselectedPetIndex\u003Ek__BackingField = -1;
  public Entity leader;
  public CardContainer leaderPreContainer;
  public int leaderPreContainerIndex;

  public bool CanRun => this.petData != null && this.petData.Length > 1;

  public bool running
  {
    get => this.\u003Crunning\u003Ek__BackingField;
    set => this.\u003Crunning\u003Ek__BackingField = value;
  }

  public int selectedPetIndex
  {
    get => this.\u003CselectedPetIndex\u003Ek__BackingField;
    set => this.\u003CselectedPetIndex\u003Ek__BackingField = value;
  }

  public IEnumerator SetUp()
  {
    if (Campaign.Data.GameMode.takeStartingPet)
    {
      this.petData = MetaprogressionSystem.GetUnlockedPets();
      global::Routine.Clump clump = new global::Routine.Clump();
      foreach (string str in this.petData)
      {
        if (!str.IsNullOrWhitespace())
          clump.Add(this.CreateCard(str));
      }
      yield return (object) clump.WaitForEnd();
    }
  }

  public IEnumerator CreateCard(string cardDataName)
  {
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", cardDataName).Clone(), this.cardController, (Character) null, false, true);
    this.group.Insert(0, card.entity);
    this.pets.Add(card.entity);
    card.transform.localScale = this.group.GetChildScale(card.entity);
    card.transform.localPosition = this.startPos;
    card.hover.SetHoverable(false);
    yield return (object) card.UpdateData(false);
  }

  public void Run(Entity leader)
  {
    if (this.running)
      return;
    this.StartCoroutine(this.Routine(leader));
  }

  public void Stop() => this.running = false;

  public void Cancel()
  {
    this.Stop();
    this.selectedPetIndex = -1;
    this.leader.RemoveFromContainers();
    this.leader.wobbler.WobbleRandom();
    this.leaderPreContainer.Insert(this.leaderPreContainerIndex, this.leader);
    this.leaderPreContainer.TweenChildPositions();
    if ((bool) (UnityEngine.Object) this.text)
      this.text.SetActive(false);
    foreach (Entity entity in (IEnumerable<Entity>) this.pets.OrderBy<Entity, float>((Func<Entity, float>) (a => UnityEngine.Random.Range(0.0f, 1f))))
    {
      LeanTween.moveLocal(entity.gameObject, this.startPos, 0.1f).setEaseInQuad().setDelay(UnityEngine.Random.Range(0.0f, 0.1f));
      entity.display.hover.SetHoverable(false);
    }
    this.winStreakDisplay.SetActive(true);
  }

  public IEnumerator Routine(Entity leader)
  {
    SelectStartingPet selectStartingPet = this;
    if (!selectStartingPet.running)
    {
      selectStartingPet.running = true;
      selectStartingPet.leader = leader;
      selectStartingPet.titleSetter.Set();
      selectStartingPet.winStreakDisplay.SetActive(false);
      selectStartingPet.leaderPreContainer = leader.actualContainers[0];
      selectStartingPet.leaderPreContainerIndex = selectStartingPet.leaderPreContainer.IndexOf(leader);
      leader.RemoveFromContainers();
      leader.wobbler.WobbleRandom();
      selectStartingPet.leaderContainer.Add(leader);
      selectStartingPet.leaderContainer.TweenChildPositions();
      selectStartingPet.leaderSelect.Hide();
      foreach (Entity child in (IEnumerable<Entity>) selectStartingPet.pets.OrderBy<Entity, float>((Func<Entity, float>) (a => UnityEngine.Random.Range(0.0f, 1f))))
      {
        selectStartingPet.group.TweenChildPosition(child);
        child.display.hover.SetHoverable(true);
        yield return (object) new WaitForSeconds(UnityEngine.Random.Range(0.0f, 0.1f));
      }
      if ((bool) (UnityEngine.Object) selectStartingPet.text)
      {
        selectStartingPet.text.SetActive(true);
        selectStartingPet.text.transform.localScale = Vector3.zero;
        LeanTween.scale(selectStartingPet.text, Vector3.one, 1f).setEaseOutElastic();
      }
      yield return (object) new WaitUntil(new Func<bool>(selectStartingPet.\u003CRoutine\u003Eb__29_0));
    }
  }

  public bool Reroll() => throw new NotImplementedException();

  public void Select(Entity entity)
  {
    if (!this.running)
      return;
    int num = this.pets.IndexOf(entity);
    if (num < 0)
      return;
    this.selectedPetIndex = num;
    this.selectionSequence.SetUnit(entity);
    this.selectionSequence.Begin();
    this.cardController.enabled = false;
    this.cardController.UnHover();
  }

  public void Gain(PlayerData playerData)
  {
    if (this.selectedPetIndex < 0 && this.pets.Count > 0)
      this.selectedPetIndex = 0;
    Entity pet = this.selectedPetIndex >= 0 ? this.pets[this.selectedPetIndex] : (Entity) null;
    if (!(bool) (UnityEngine.Object) pet)
      return;
    Events.InvokeEntityChosen(pet);
    playerData.inventory.deck.Insert(0, pet.data);
    MetaprogressionSystem.Set<int>("selectedPet", this.selectedPetIndex);
  }

  [CompilerGenerated]
  public bool \u003CRoutine\u003Eb__29_0() => !this.running;
}
