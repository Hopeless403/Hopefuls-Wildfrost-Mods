// Decompiled with JetBrains decompiler
// Type: SelectLeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class SelectLeader : MonoBehaviour, IRerollable
{
  [SerializeField]
  public int options = 3;
  [SerializeField]
  public int differentTribes = 3;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer leaderCardContainer;
  [SerializeField]
  public InspectNewUnitSequence selectionSequence;
  [SerializeField]
  public TitleSetter titleSetter;
  [Header("Tribe Flags")]
  [SerializeField]
  public Transform flagGroup;
  [SerializeField]
  public TribeFlagDisplay flagBase;
  [SerializeField]
  public Vector3 flagOffset = new Vector3(0.0f, -4f);
  [SerializeField]
  public TribeDisplaySequence tribeDisplay;
  public readonly List<GameObject> flags = new List<GameObject>();
  [CompilerGenerated]
  public SelectLeader.Character \u003Ccurrent\u003Ek__BackingField;
  public List<SelectLeader.Character> characters;
  public Dictionary<ClassData, SelectLeader.LeaderPool> leaderPools;
  [CompilerGenerated]
  public bool \u003Cgenerating\u003Ek__BackingField;
  [CompilerGenerated]
  public bool \u003Crunning\u003Ek__BackingField;
  public int seed;

  public SelectLeader.Character current
  {
    get => this.\u003Ccurrent\u003Ek__BackingField;
    set => this.\u003Ccurrent\u003Ek__BackingField = value;
  }

  public bool generating
  {
    get => this.\u003Cgenerating\u003Ek__BackingField;
    set => this.\u003Cgenerating\u003Ek__BackingField = value;
  }

  public bool running
  {
    get => this.\u003Crunning\u003Ek__BackingField;
    set => this.\u003Crunning\u003Ek__BackingField = value;
  }

  public void Run(List<ClassData> tribes)
  {
    this.running = true;
    this.titleSetter.Set();
    this.leaderPools = new Dictionary<ClassData, SelectLeader.LeaderPool>();
    foreach (ClassData tribe in tribes)
      this.leaderPools[tribe] = new SelectLeader.LeaderPool(tribe);
  }

  public void Hide()
  {
    this.gameObject.SetActive(false);
    this.running = false;
  }

  public void Return()
  {
    this.running = true;
    this.gameObject.SetActive(true);
    LeanTween.cancel(this.gameObject);
    LeanTween.moveLocal(this.gameObject, Vector3.zero, 0.3f).setEaseOutQuint();
  }

  public void SetSeed(int seed)
  {
    this.seed = seed;
    UnityEngine.Random.InitState(seed);
    Names.Reset();
  }

  public IEnumerator GenerateLeaders(bool useSeed)
  {
    SelectLeader selectLeader1 = this;
    if (useSeed)
    {
      UnityEngine.Random.InitState(selectLeader1.seed);
      Names.Reset();
    }
    selectLeader1.generating = true;
    selectLeader1.Clear();
    List<ClassData> availableTribes = selectLeader1.leaderPools.Keys.ToList<ClassData>();
    availableTribes.Shuffle<ClassData>();
    List<ClassData> list = new List<ClassData>();
    for (int index = 0; index < Mathf.Min(selectLeader1.options, selectLeader1.differentTribes); ++index)
      list.Add(availableTribes[index % availableTribes.Count]);
    while (list.Count < selectLeader1.options)
      list.Add(availableTribes.RandomItem<ClassData>());
    if (list.Count > 1)
      list.Shuffle<ClassData>();
    List<Card> cardList = new List<Card>();
    for (int index = 0; index < selectLeader1.options; ++index)
      cardList.Add(selectLeader1.CreateLeader(list[index]));
    selectLeader1.SetLeaderPositions();
    foreach (EntityDisplay entityDisplay in cardList)
      yield return (object) entityDisplay.UpdateData();
    if (availableTribes.Count > 1)
    {
      foreach (SelectLeader.Character character in selectLeader1.characters)
      {
        SelectLeader selectLeader = selectLeader1;
        SelectLeader.Character c = character;
        Vector3 position = c.entity.transform.position + selectLeader1.flagOffset;
        TribeFlagDisplay tribeFlagDisplay = UnityEngine.Object.Instantiate<TribeFlagDisplay>(selectLeader1.flagBase, position, Quaternion.identity, selectLeader1.flagGroup);
        tribeFlagDisplay.SetFlagSprite(c.data.classData.flag);
        tribeFlagDisplay.AddPressAction((UnityAction) (() => selectLeader.tribeDisplay.Run(c.data.classData.name)));
        tribeFlagDisplay.gameObject.SetActive(true);
        selectLeader1.flags.Add(tribeFlagDisplay.gameObject);
      }
    }
    selectLeader1.generating = false;
  }

  public Card CreateLeader(ClassData classData)
  {
    CardData data1 = this.leaderPools[classData].Pull().Clone();
    PlayerData data2 = new PlayerData(classData, classData.startingInventory.Clone());
    CardController cardController = this.cardController;
    Card leader = CardManager.Get(data1, cardController, (global::Character) null, false, true);
    this.leaderCardContainer.Add(leader.entity);
    leader.entity.flipper.FlipDownInstant();
    this.characters.Add(new SelectLeader.Character(data2, leader.entity));
    return leader;
  }

  public void Clear()
  {
    if (this.characters == null)
      this.characters = new List<SelectLeader.Character>();
    foreach (SelectLeader.Character character in this.characters)
      character.Clear();
    this.current = (SelectLeader.Character) null;
    this.characters.Clear();
    this.StopAllCoroutines();
    this.flags.DestroyAllAndClear();
  }

  public void SetLeaderPositions()
  {
    List<MonoBehaviour> monoBehaviourList = new List<MonoBehaviour>();
    foreach (SelectLeader.Character character in this.characters)
    {
      foreach (AngleWobbler componentsInChild in character.entity.GetComponentsInChildren<AngleWobbler>())
      {
        if (componentsInChild.enabled)
        {
          componentsInChild.enabled = false;
          monoBehaviourList.Add((MonoBehaviour) componentsInChild);
        }
      }
    }
    this.leaderCardContainer.SetChildPositions();
    foreach (Behaviour behaviour in monoBehaviourList)
      behaviour.enabled = true;
  }

  public void FlipUpLeaders() => this.StartCoroutine(this.FlipUpRoutine());

  public void FlipUpLeadersInstant()
  {
    foreach (Entity entity in this.leaderCardContainer)
      entity.flipper.FlipUpInstant();
  }

  public IEnumerator FlipUpRoutine()
  {
    foreach (Entity entity in this.leaderCardContainer)
    {
      entity.flipper.FlipUp(true);
      yield return (object) Sequences.Wait(PettyRandom.Range(0.0f, 0.1f));
    }
  }

  public bool Reroll()
  {
    if (!this.generating)
    {
      InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
      if (!InspectSystem.IsActive() && (!(bool) (UnityEngine.Object) objectOfType || !objectOfType.gameObject.activeSelf))
      {
        this.StartCoroutine(this.GenerateLeaders(false));
        CardPopUp.Clear();
        return true;
      }
    }
    return false;
  }

  public void Select(Entity entity)
  {
    if (!this.running)
      return;
    SelectLeader.Character character = this.characters.FirstOrDefault<SelectLeader.Character>((Func<SelectLeader.Character, bool>) (a => (UnityEngine.Object) a.entity == (UnityEngine.Object) entity));
    if (character == null)
      return;
    this.Select(character);
    this.selectionSequence.SetUnit(entity);
    this.selectionSequence.Begin();
    this.cardController.enabled = false;
    this.cardController.UnHover();
  }

  public void Select(SelectLeader.Character character) => this.current = character;

  public void Cancel()
  {
    this.current = (SelectLeader.Character) null;
    this.running = false;
    this.Clear();
  }

  public class Character
  {
    public PlayerData data;
    public Entity entity;

    public Character(PlayerData data, Entity entity)
    {
      this.data = data;
      this.entity = entity;
    }

    public void Clear()
    {
      if ((bool) (UnityEngine.Object) this.entity)
      {
        this.entity.RemoveFromContainers();
        CardManager.ReturnToPool(this.entity);
        UnityEngine.Object.Destroy((UnityEngine.Object) this.entity.data);
        UnityEngine.Object.Destroy((UnityEngine.Object) this.data.inventory);
      }
      this.data = (PlayerData) null;
    }

    public void AddLeaderToInventory()
    {
      global::Events.InvokeEntityChosen(this.entity);
      this.data.inventory.deck.Insert(0, this.entity.data);
    }
  }

  public class LeaderPool
  {
    public readonly ClassData classData;
    public readonly List<CardData> pool = new List<CardData>();

    public LeaderPool(ClassData classData) => this.classData = classData;

    public CardData Pull()
    {
      if (this.pool.Count <= 0)
      {
        this.pool.AddRange((IEnumerable<CardData>) this.classData.leaders);
        this.pool.Shuffle<CardData>();
      }
      CardData cardData = this.pool[0];
      this.pool.RemoveAt(0);
      return cardData;
    }
  }
}
