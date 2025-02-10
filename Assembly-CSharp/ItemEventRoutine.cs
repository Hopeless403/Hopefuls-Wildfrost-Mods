// Decompiled with JetBrains decompiler
// Type: ItemEventRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.UI;

public class ItemEventRoutine : EventRoutine, IRerollable
{
  [SerializeField]
  private ChooseNewCardSequence sequence;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardSelector cardSelector;
  [SerializeField]
  private CardContainer cardContainer;
  [SerializeField]
  private SpriteRenderer backgroundImage;
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private ParticleSystem pulseParticleSystem;
  [SerializeField]
  private Button skipButton;
  [SerializeField]
  private LocalizedString openKey;
  [SerializeField]
  private LocalizedString chooseKey;
  [SerializeField]
  private SfxLoop loop;
  [SerializeField]
  private GameObject backButton;
  private bool cardTaken;
  private bool showCards;
  private bool promptOpen;
  private bool analyticsEventSent;

  public bool IsOpen => this.data.Get<bool>("open");

  public void RunOpenRoutine(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left)
      return;
    this.promptOpen = true;
  }

  private IEnumerator OpenRoutine()
  {
    ItemEventRoutine itemEventRoutine = this;
    DeckpackBlocker.Block();
    SfxSystem.OneShot("event:/sfx/location/item_chest/claim");
    itemEventRoutine.data["open"] = (object) true;
    itemEventRoutine.animator.SetBool("Open", true);
    Events.InvokeScreenRumble(0.0f, 1f, 0.05f, 0.7f, 0.2f, 0.05f);
    yield return (object) Sequences.Wait(1f);
    Events.InvokeScreenShake(5f);
    itemEventRoutine.animator.SetBool("Zoom", true);
    yield return (object) null;
    itemEventRoutine.Open();
    DeckpackBlocker.Unblock();
  }

  private void Open()
  {
    this.showCards = true;
    CinemaBarSystem.Top.SetPrompt(this.chooseKey.GetLocalizedString(), "");
    this.data["open"] = (object) true;
    Image component = this.backgroundImage.GetComponent<Image>();
    if (component != null)
      component.enabled = false;
    this.pulseParticleSystem?.Stop();
    UINavigationDefaultSystem.SetStartingItem();
    if (!(bool) (UnityEngine.Object) this.backButton)
      return;
    this.backButton.SetActive(true);
  }

  private void Close()
  {
    this.showCards = false;
    this.animator.SetBool("Open", false);
    CinemaBarSystem.Top.SetPrompt(this.openKey.GetLocalizedString(), "Select");
    Image component = this.backgroundImage.GetComponent<Image>();
    if (component != null)
      component.enabled = true;
    this.pulseParticleSystem?.Play();
  }

  public override IEnumerator Populate()
  {
    ItemEventRoutine itemEventRoutine = this;
    string[] saveCollection = itemEventRoutine.data.GetSaveCollection<string>("cards");
    itemEventRoutine.cardContainer.SetSize(saveCollection.Length, 0.8f);
    Routine.Clump clump = new Routine.Clump();
    for (int cardIndex = 0; cardIndex < saveCollection.Length; ++cardIndex)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", saveCollection[cardIndex]).Clone();
      itemEventRoutine.CheckAddUpgrades(cardIndex, cardData);
      Card card = CardManager.Get(cardData, itemEventRoutine.cardController, itemEventRoutine.player, false, true);
      if (!itemEventRoutine.cardContainer.gameObject.activeInHierarchy)
        card.entity.flipper.FlipDownInstant();
      itemEventRoutine.cardContainer.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity child in itemEventRoutine.cardContainer)
    {
      Transform transform = child.transform;
      transform.localPosition = itemEventRoutine.cardContainer.GetChildPosition(child);
      transform.localScale = itemEventRoutine.cardContainer.GetChildScale(child);
      transform.localEulerAngles = itemEventRoutine.cardContainer.GetChildRotation(child);
    }
    if (itemEventRoutine.data.Get<bool>("open"))
    {
      itemEventRoutine.Open();
      itemEventRoutine.animator.SetBool("Zoom", true);
    }
    else
      itemEventRoutine.Close();
  }

  public override IEnumerator Run()
  {
    ItemEventRoutine itemEventRoutine = this;
    itemEventRoutine.sequence.owner = itemEventRoutine.player;
    itemEventRoutine.cardController.owner = itemEventRoutine.player;
    itemEventRoutine.cardSelector.character = itemEventRoutine.player;
    if (!itemEventRoutine.data.Get<bool>("open"))
      itemEventRoutine.loop.Play();
    while (!itemEventRoutine.data.Get<bool>("open"))
    {
      if (itemEventRoutine.promptOpen)
      {
        itemEventRoutine.promptOpen = false;
        if (!itemEventRoutine.data.Get<bool>("open"))
        {
          itemEventRoutine.loop.Stop();
          yield return (object) itemEventRoutine.OpenRoutine();
        }
      }
      yield return (object) null;
    }
    if (!itemEventRoutine.analyticsEventSent)
    {
      foreach (Entity entity in itemEventRoutine.cardContainer)
        Events.InvokeEntityOffered(entity);
      itemEventRoutine.analyticsEventSent = true;
    }
    yield return (object) itemEventRoutine.sequence.Run();
    CinemaBarSystem.Clear();
    if (itemEventRoutine.cardTaken)
      itemEventRoutine.node.SetCleared();
  }

  public void TrySelect(Entity entity)
  {
    if (this.cardTaken)
      return;
    ActionSelect action = new ActionSelect(entity, (Action<Entity>) (e =>
    {
      this.cardSelector.TakeCard(entity);
      this.cardController.Disable();
      if ((bool) (UnityEngine.Object) this.skipButton)
        this.skipButton.interactable = false;
      if ((bool) (UnityEngine.Object) this.backButton)
        this.backButton.SetActive(false);
      this.cardTaken = true;
      Events.InvokeEntityChosen(entity);
    }));
    if (!Events.CheckAction((PlayAction) action))
      return;
    ActionQueue.Add((PlayAction) action);
  }

  public void TrySkip()
  {
    ActionSelect action = new ActionSelect((Entity) null, (Action<Entity>) (e => this.sequence.Skip()));
    if (!Events.CheckAction((PlayAction) action))
      return;
    ActionQueue.Add((PlayAction) action);
  }

  public bool Reroll()
  {
    if (!this.cardContainer.gameObject.activeInHierarchy || !this.cardSelector.enabled || InspectSystem.IsActive())
      return false;
    InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
    if (objectOfType != null && objectOfType.gameObject.activeSelf)
      return false;
    this.data["cards"] = (object) ((IList<CardData>) this.cardController.owner.GetComponent<CharacterRewards>().Pull<CardData>((object) this.node, "Items", this.data.GetSaveCollection<string>("cards").Length)).ToSaveCollectionOfNames<CardData>();
    foreach (Entity entity in this.cardContainer)
      CardManager.ReturnToPool(entity);
    this.cardContainer.Clear();
    this.StartCoroutine(this.Populate());
    CardPopUp.Clear();
    return true;
  }
}
