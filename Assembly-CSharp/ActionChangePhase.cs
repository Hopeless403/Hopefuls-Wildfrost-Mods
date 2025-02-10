// Decompiled with JetBrains decompiler
// Type: ActionChangePhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionChangePhase : PlayAction
{
  private readonly Entity entity;
  private readonly CardData newPhase;
  private readonly CardData[] newPhases;
  private readonly CardAnimation animation;
  private List<Entity> newCards;
  private bool loadingNewCards;

  public ActionChangePhase(Entity entity, CardData newPhase, CardAnimation animation)
  {
    this.entity = entity;
    this.newPhase = newPhase;
    this.animation = animation;
  }

  public ActionChangePhase(Entity entity, CardData[] newPhases, CardAnimation animation)
  {
    this.entity = entity;
    this.newPhases = newPhases;
    this.animation = animation;
  }

  public override IEnumerator Run()
  {
    if (this.entity.IsAliveAndExists())
    {
      Events.InvokeEntityChangePhase(this.entity);
      CardData[] newPhases = this.newPhases;
      bool multipleNewPhases = newPhases != null && newPhases.Length > 0;
      if (multipleNewPhases)
      {
        Routine routine = new Routine(this.CreateNewCards());
      }
      PauseMenu.Block();
      DeckpackBlocker.Block();
      if (Deckpack.IsOpen && References.Player.entity.display is CharacterDisplay display)
        display.CloseInventory();
      ChangePhaseAnimationSystem animationSystem = Object.FindObjectOfType<ChangePhaseAnimationSystem>();
      if ((bool) (Object) animationSystem)
        yield return (object) animationSystem.Focus(this.entity);
      if ((bool) (Object) this.animation)
        yield return (object) this.animation.Routine((object) this.entity);
      foreach (PlayAction action in ActionQueue.GetActions())
      {
        switch (action)
        {
          case ActionTrigger actionTrigger:
            if ((Object) actionTrigger.entity == (Object) this.entity)
            {
              ActionQueue.Remove(action);
              break;
            }
            break;
          case ActionEffectApply actionEffectApply:
            actionEffectApply.TryRemoveEntity(this.entity);
            break;
        }
      }
      if (multipleNewPhases)
      {
        ActionSequence action = new ActionSequence(this.Split(this.entity, (IEnumerable<CardData>) this.newPhases));
        action.note = "Split boss";
        action.priority = 10;
        ActionQueue.Stack((PlayAction) action, true);
      }
      else
      {
        ActionSequence action = new ActionSequence(ActionChangePhase.Change(this.entity, this.newPhase));
        action.note = "Change boss phase";
        action.priority = 10;
        ActionQueue.Stack((PlayAction) action, true);
      }
      if ((bool) (Object) animationSystem)
      {
        ActionSequence action = new ActionSequence(animationSystem.UnFocus());
        action.note = "Unfocus boss";
        action.priority = 10;
        ActionQueue.Stack((PlayAction) action, true);
      }
    }
  }

  private static IEnumerator Change(Entity entity, CardData newData)
  {
    entity.alive = false;
    yield return (object) entity.ClearStatuses();
    entity.data = newData;
    yield return (object) entity.display.UpdateData(true);
    entity.alive = true;
    yield return (object) StatusEffectSystem.EntityEnableEvent(entity);
  }

  private IEnumerator Split(Entity entity, IEnumerable<CardData> split)
  {
    entity.alive = false;
    while (this.loadingNewCards)
      yield return (object) null;
    int num = 0;
    int count = entity.actualContainers.Count;
    Dictionary<CardContainer, List<Entity>> toMove = new Dictionary<CardContainer, List<Entity>>();
    foreach (Entity newCard in this.newCards)
    {
      int index = num % count;
      CardContainer actualContainer = entity.actualContainers[index];
      if (toMove.ContainsKey(actualContainer))
      {
        CardContainer container = entity.containers[index];
        if (toMove.ContainsKey(container))
          toMove[container].Add(newCard);
        else
          toMove[container] = new List<Entity>() { newCard };
      }
      else
        toMove[actualContainer] = new List<Entity>()
        {
          newCard
        };
      ++num;
    }
    Vector3 position = entity.transform.position;
    entity.RemoveFromContainers();
    CardManager.ReturnToPool(entity);
    foreach (KeyValuePair<CardContainer, List<Entity>> keyValuePair in toMove)
    {
      CardContainer cardContainer1;
      List<Entity> entityList1;
      keyValuePair.Deconstruct(ref cardContainer1, ref entityList1);
      CardContainer cardContainer2 = cardContainer1;
      List<Entity> entityList2 = entityList1;
      if (entityList2 != null)
      {
        foreach (Entity entity1 in entityList2)
        {
          cardContainer2.Add(entity1);
          Transform transform = entity1.transform;
          transform.localScale = entity1.GetContainerScale();
          Vector3 containerWorldPosition = entity1.GetContainerWorldPosition();
          transform.position = Vector3.Lerp(position, containerWorldPosition, 0.1f);
          LeanTween.move(entity1.gameObject, containerWorldPosition, PettyRandom.Range(0.8f, 1.2f)).setEaseOutElastic();
          entity1.wobbler.WobbleRandom();
        }
      }
    }
    ChangePhaseAnimationSystem objectOfType1 = Object.FindObjectOfType<ChangePhaseAnimationSystem>();
    MinibossIntroSystem objectOfType2 = Object.FindObjectOfType<MinibossIntroSystem>();
    foreach (Entity newCard in this.newCards)
    {
      if ((bool) (Object) objectOfType1)
      {
        objectOfType1.RemoveTarget(entity);
        objectOfType1.Assign(newCard);
      }
      if ((bool) (Object) objectOfType2)
        objectOfType2.Ignore(newCard);
    }
    ActionSequence action = new ActionSequence(ActionChangePhase.FinalSplit(toMove));
    action.note = "Final boss split";
    action.priority = 10;
    ActionQueue.Stack((PlayAction) action, true);
  }

  private static IEnumerator FinalSplit(Dictionary<CardContainer, List<Entity>> toMove)
  {
    foreach (KeyValuePair<CardContainer, List<Entity>> keyValuePair in toMove)
    {
      foreach (Entity entity in keyValuePair.Value)
      {
        entity.enabled = true;
        entity.RemoveFromContainers();
        entity.owner.reserveContainer.Add(entity);
        ActionMove action1 = new ActionMove(entity, new CardContainer[1]
        {
          keyValuePair.Key
        });
        action1.priority = 10;
        ActionQueue.Stack((PlayAction) action1, true);
        ActionRunEnableEvent action2 = new ActionRunEnableEvent(entity);
        action2.priority = 10;
        ActionQueue.Stack((PlayAction) action2, true);
      }
    }
    yield return (object) null;
  }

  private static IEnumerator EnableBehaviour(Behaviour system)
  {
    system.enabled = true;
    yield return (object) null;
  }

  private IEnumerator CreateNewCards()
  {
    this.loadingNewCards = true;
    this.newCards = new List<Entity>();
    CardController controller = this.entity.display.hover.controller;
    Character owner = this.entity.owner;
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData newPhase in this.newPhases)
    {
      Card card = CardManager.Get(newPhase, controller, owner, true, owner.team == References.Player.team);
      this.newCards.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    this.loadingNewCards = false;
  }
}
