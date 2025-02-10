// Decompiled with JetBrains decompiler
// Type: CharacterSelectScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class CharacterSelectScreen : MonoBehaviour
{
  [SerializeField]
  private int options = 3;
  [SerializeField]
  private int differentTribes = 3;
  private List<Character> characters;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardContainer leaderCardContainer;
  [SerializeField]
  private GameObject backButton;
  [SerializeField]
  private SelectTribe tribeSelection;
  [SerializeField]
  private SelectLeader leaderSelection;
  [SerializeField]
  private SelectStartingPet petSelection;
  [SerializeField]
  private InspectNewUnitSequence selectionSequence;
  [Header("Title")]
  [SerializeField]
  private GameObject title;
  [SerializeField]
  private LocalizeStringEvent titleText;
  [SerializeField]
  private LocalizedString titleTribeKey;
  [SerializeField]
  private LocalizedString titleLeaderKey;
  [SerializeField]
  private LocalizedString titlePetKey;
  [SerializeField]
  private Image titleUnderline;
  [SerializeField]
  private Sprite underlineTribeSprite;
  [SerializeField]
  private Sprite underlineLeaderSprite;
  [SerializeField]
  private Sprite underlinePetSprite;
  [Header("Hard Mode Modifiers")]
  [SerializeField]
  private HardModeModifierDisplay modifierDisplay;
  [SerializeField]
  private UnlockModifierSequence modifierUnlockSequence;
  [Header("Tribe Flags")]
  [SerializeField]
  private Transform flagGroup;
  [SerializeField]
  private TribeFlagDisplay flagBase;
  [SerializeField]
  private Vector3 flagOffset = new Vector3(0.0f, -4f);
  [SerializeField]
  private TribeDisplaySequence tribeDisplay;
  private readonly List<GameObject> flags = new List<GameObject>();
  private int seed;
  private bool loadingToCampaign;
  private List<ClassData> unlockedClassesForThisGameMode;
  private const bool selectTribe = true;

  private void OnEnable() => this.loadingToCampaign = false;

  private IEnumerator Start()
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

  private IEnumerator ContinueRoutine(SelectLeader.Character selected)
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

  private void SetTitleTribe()
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

  private void SetTitlePet() => this.title.SetActive(false);

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
