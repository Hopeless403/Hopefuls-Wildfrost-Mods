// Decompiled with JetBrains decompiler
// Type: EventRoutineCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;

#nullable disable
public class EventRoutineCompanion : EventRoutine, IRerollable
{
  [SerializeField]
  public ChooseNewCardSequence sequence;
  [SerializeField]
  public InspectNewUnitSequence inspectSequence;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public CardContainer cardContainer;
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public ParticleSystem chunkParticles;
  [SerializeField]
  public ParticleSystem chunkBigParticles;
  [SerializeField]
  public ParticleSystem breakFx;
  [SerializeField]
  public LocalizedString breakKey;
  [SerializeField]
  public LocalizedString chooseKey;
  [SerializeField]
  public SfxLoop loop1;
  [SerializeField]
  public SfxLoop loop2;
  public bool analyticsEventSent;

  public bool broken => this.data.Get<int>("damage") > 3;

  public void Hit(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left || this.broken)
      return;
    this.data["damage"] = (object) (this.data.Get<int>("damage") + 1);
    this.UpdateAnimator();
    this.TakeHit();
  }

  public void UpdateAnimator()
  {
    this.animator.SetInteger("Damage", this.data.Get<int>("damage"));
    this.animator.SetBool("Broken", this.broken);
  }

  public void TakeHit()
  {
    this.animator.SetTrigger("Hit");
    if (this.broken)
    {
      Events.InvokeScreenShake(5f);
      if ((UnityEngine.Object) this.chunkParticles != (UnityEngine.Object) null)
        this.chunkParticles.Play();
      if ((UnityEngine.Object) this.chunkBigParticles != (UnityEngine.Object) null)
        this.chunkBigParticles.Play();
      if ((UnityEngine.Object) this.breakFx != (UnityEngine.Object) null)
        this.breakFx.Play();
      ScreenFlashSystem.SetDrawOrder("Transition", 0);
      ScreenFlashSystem.SetColour(Color.white.WithAlpha(0.45f));
      ScreenFlashSystem.Run(0.175f);
      CinemaBarSystem.Top.SetPrompt(this.chooseKey.GetLocalizedString(), "Select");
      SfxSystem.OneShot("event:/sfx/location/travelers/break");
    }
    else
    {
      Events.InvokeScreenShake();
      if ((UnityEngine.Object) this.chunkParticles != (UnityEngine.Object) null)
        this.chunkParticles.Play();
      SfxSystem.OneShot("event:/sfx/location/travelers/hit");
    }
  }

  public override IEnumerator Populate()
  {
    EventRoutineCompanion routineCompanion = this;
    string[] saveCollection = routineCompanion.data.GetSaveCollection<string>("cards");
    routineCompanion.cardContainer.SetSize(saveCollection.Length, 0.8f);
    Routine.Clump clump = new Routine.Clump();
    for (int cardIndex = 0; cardIndex < saveCollection.Length; ++cardIndex)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", saveCollection[cardIndex]).Clone();
      routineCompanion.CheckAddUpgrades(cardIndex, cardData);
      Card card = CardManager.Get(cardData, routineCompanion.cardController, routineCompanion.player, false, true);
      if (!routineCompanion.cardContainer.gameObject.activeInHierarchy)
        card.entity.flipper.FlipDownInstant();
      routineCompanion.cardContainer.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity child in routineCompanion.cardContainer)
    {
      Transform transform = child.transform;
      transform.localPosition = routineCompanion.cardContainer.GetChildPosition(child);
      transform.localScale = routineCompanion.cardContainer.GetChildScale(child);
      transform.localEulerAngles = routineCompanion.cardContainer.GetChildRotation(child);
    }
    routineCompanion.UpdateAnimator();
    if (routineCompanion.broken)
      CinemaBarSystem.Clear();
    else
      CinemaBarSystem.Top.SetPrompt(routineCompanion.breakKey.GetLocalizedString(), "Select");
  }

  public override IEnumerator Run()
  {
    EventRoutineCompanion routineCompanion = this;
    routineCompanion.cardController.owner = routineCompanion.player;
    routineCompanion.cardSelector.character = routineCompanion.player;
    routineCompanion.loop1.Play();
    bool loop2Started = false;
    while (!routineCompanion.broken)
    {
      if (!loop2Started && routineCompanion.data.Get<int>("damage") > 2)
      {
        routineCompanion.loop2.Play();
        loop2Started = true;
      }
      yield return (object) null;
    }
    routineCompanion.loop1.Stop();
    routineCompanion.loop2.Stop();
    if (!routineCompanion.analyticsEventSent)
    {
      foreach (Entity entity in routineCompanion.cardContainer)
        Events.InvokeEntityOffered(entity);
      routineCompanion.analyticsEventSent = true;
    }
    yield return (object) Sequences.Wait(0.3f);
    yield return (object) routineCompanion.sequence.Run();
    CinemaBarSystem.Clear();
    routineCompanion.node.SetCleared();
  }

  public void TrySelect(Entity entity)
  {
    ActionSelect action = new ActionSelect(entity, (Action<Entity>) (e =>
    {
      this.inspectSequence.SetUnit(entity);
      this.inspectSequence.Begin();
      this.cardController.enabled = false;
      this.cardController.UnHover(entity);
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

  public void CardSelected(Entity entity)
  {
    this.sequence.End();
    this.cardController.enabled = false;
    Events.InvokeEntityChosen(entity);
  }

  public bool Reroll()
  {
    if (!this.cardContainer.gameObject.activeInHierarchy || !this.cardSelector.enabled || InspectSystem.IsActive())
      return false;
    InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
    if (objectOfType != null && objectOfType.gameObject.activeSelf)
      return false;
    this.data["cards"] = (object) ((IList<CardData>) this.cardController.owner.GetComponent<CharacterRewards>().Pull<CardData>((object) this.node, "Units", this.data.GetSaveCollection<string>("cards").Length)).ToSaveCollectionOfNames<CardData>();
    foreach (Entity entity in this.cardContainer)
      CardManager.ReturnToPool(entity);
    this.cardContainer.Clear();
    this.StartCoroutine(this.Populate());
    CardPopUp.Clear();
    return true;
  }

  [CompilerGenerated]
  public void \u003CTrySkip\u003Eb__22_0(Entity e) => this.sequence.Skip();
}
