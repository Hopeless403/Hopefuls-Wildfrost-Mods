// Decompiled with JetBrains decompiler
// Type: CharacterSelectScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class CharacterSelectScreen : MonoBehaviour
{
  [SerializeField]
  public int options = 3;
  [SerializeField]
  public int differentTribes = 3;
  public List<Character> characters;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer leaderCardContainer;
  [SerializeField]
  public GameObject backButton;
  [SerializeField]
  public SelectTribe tribeSelection;
  [SerializeField]
  public SelectLeader leaderSelection;
  [SerializeField]
  public SelectStartingPet petSelection;
  [SerializeField]
  public InspectNewUnitSequence selectionSequence;
  [Header("Title")]
  [SerializeField]
  public GameObject title;
  [SerializeField]
  public LocalizeStringEvent titleText;
  [SerializeField]
  public LocalizedString titleTribeKey;
  [SerializeField]
  public LocalizedString titleLeaderKey;
  [SerializeField]
  public LocalizedString titlePetKey;
  [SerializeField]
  public Image titleUnderline;
  [SerializeField]
  public Sprite underlineTribeSprite;
  [SerializeField]
  public Sprite underlineLeaderSprite;
  [SerializeField]
  public Sprite underlinePetSprite;
  [Header("Hard Mode Modifiers")]
  [SerializeField]
  public HardModeModifierDisplay modifierDisplay;
  [SerializeField]
  public UnlockModifierSequence modifierUnlockSequence;
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
  public int seed;
  public bool loadingToCampaign;
  public List<ClassData> unlockedClassesForThisGameMode;
  public const bool selectTribe = true;

  public void OnEnable() => this.loadingToCampaign = false;

  public IEnumerator Start()
  {
    this.leaderSelection.SetSeed(Campaign.Data.Seed);
    List<ClassData> lockedClasses = MetaprogressionSystem.GetLockedClasses();
    Debug.Log((object) ("Locked Classes: [" + string.Join<ClassData>(", ", (IEnumerable<ClassData>) lockedClasses) + "]"));
    this.unlockedClassesForThisGameMode = new List<ClassData>((IEnumerable<ClassData>) Campaign.Data.GameMode.classes);
    this.unlockedClassesForThisGameMode.RemoveMany<ClassData>((ICollection<ClassData>) lockedClasses);
    Debug.Log((object) ("Available Classes For [" + Campaign.Data.GameMode.name + "]: [" + string.Join<ClassData>(", ", (IEnumerable<ClassData>) this.unlockedClassesForThisGameMode) + "]"));
    if (this.unlockedClassesForThisGameMode.Count > 1)
    {
      this.tribeSelection.SetAvailableTribes(this.unlockedClassesForThisGameMode);
      this.tribeSelection.Run();
      this.title.SetActive(true);
      this.titleText.StringReference = this.titleTribeKey;
      this.titleUnderline.sprite = this.underlineTribeSprite;
    }
    else
    {
      this.leaderSelection.Run(this.unlockedClassesForThisGameMode);
      yield return (object) this.leaderSelection.GenerateLeaders(true);
      this.leaderSelection.FlipUpLeadersInstant();
      this.title.SetActive(true);
      this.titleText.StringReference = this.titleLeaderKey;
      this.titleUnderline.sprite = this.underlineLeaderSprite;
    }
    yield return (object) Sequences.Wait(0.1f);
    yield return (object) this.petSelection.SetUp();
    if (this.modifierDisplay.gameObject.activeSelf)
      this.modifierDisplay.Populate();
    this.backButton.gameObject.SetActive(Campaign.Data.GameMode.canGoBack);
    Transition.End();
    if (NewFinalBossChecker.Check())
    {
      this.cardController.Disable();
      yield return (object) NewFinalBossChecker.Run();
      this.cardController.Enable();
    }
  }

  public void Continue()
  {
    if (this.leaderSelection.current == null || this.loadingToCampaign)
      return;
    if (this.petSelection.running)
      this.petSelection.Stop();
    if (this.petSelection.selectedPetIndex < 0 && this.petSelection.CanRun)
    {
      if (this.selectionSequence.IsRunning)
      {
        this.selectionSequence.UnsetUnit();
        this.selectionSequence.End();
        this.cardController.Enable();
      }
      this.petSelection.Run(this.leaderSelection.current.entity);
      this.SetTitlePet();
    }
    else
      this.StartCoroutine(this.ContinueRoutine(this.leaderSelection.current));
  }

  public IEnumerator ContinueRoutine(SelectLeader.Character selected)
  {
    this.loadingToCampaign = true;
    this.petSelection.Gain(this.leaderSelection.current.data);
    this.leaderSelection.current.AddLeaderToInventory();
    References.PlayerData = selected.data;
    yield return (object) JournalAddNameSequence.LoadAndRun(this.leaderSelection.current.entity.data, false);
    yield return (object) Events.InvokeCampaignInit();
    Campaign.Begin();
    Routine routine = new Routine(Transition.To(Campaign.Data.GameMode.sceneAfterSelection));
  }

  public void SetTitleTribe()
  {
    this.title.SetActive(true);
    this.titleText.StringReference = this.titleTribeKey;
    this.titleUnderline.sprite = this.underlineTribeSprite;
  }

  public void SetTitleLeader()
  {
    this.title.SetActive(true);
    this.titleText.StringReference = this.titleLeaderKey;
    this.titleUnderline.sprite = this.underlineLeaderSprite;
  }

  public void SetTitlePet() => this.title.SetActive(false);

  public void Back()
  {
    if (this.leaderSelection.running)
    {
      if (this.unlockedClassesForThisGameMode.Count > 1)
      {
        this.leaderSelection.Cancel();
        this.tribeSelection.SetAvailableTribes(this.unlockedClassesForThisGameMode);
        this.tribeSelection.Run();
        this.tribeSelection.RevealAnimation();
        this.SetTitleTribe();
      }
      else
        this.ReturnToMenu();
    }
    else if (this.petSelection.running)
    {
      this.petSelection.Cancel();
      this.leaderSelection.Return();
      this.SetTitleLeader();
    }
    else
      this.ReturnToMenu();
  }

  public void ReturnToMenu()
  {
    Routine routine = new Routine(Transition.To(SaveSystem.LoadProgressData<int>("tutorialProgress", 0) == 0 ? "MainMenu" : "Town"));
  }
}
