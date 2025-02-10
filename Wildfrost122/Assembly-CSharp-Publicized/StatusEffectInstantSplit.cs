// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSplit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Split", fileName = "Split")]
public class StatusEffectInstantSplit : StatusEffectInstant
{
  [SerializeField]
  public StatusEffectInstantSplit.Profile[] profiles;
  public readonly List<Entity> newCards = new List<Entity>();

  public bool CanSplit()
  {
    if (this.target.height > 1)
      return true;
    foreach (CardContainer cardContainer in References.Battle.rows[this.target.owner])
    {
      if (cardContainer.Count < cardContainer.max)
        return true;
    }
    return false;
  }

  public override IEnumerator Process()
  {
    StatusEffectInstantSplit effectInstantSplit = this;
    if (effectInstantSplit.CanSplit())
      yield return effectInstantSplit.target.height > 1 ? (object) effectInstantSplit.SplitDoubleHeight() : (object) effectInstantSplit.Split();
    else if (NoTargetTextSystem.Exists())
      yield return (object) NoTargetTextSystem.Run(effectInstantSplit.target, NoTargetType.CantSplit);
    yield return (object) effectInstantSplit.\u003C\u003En__0();
  }

  public IEnumerator Split()
  {
    StatusEffectInstantSplit effectInstantSplit = this;
    effectInstantSplit.target.hp.current = Mathf.CeilToInt((float) effectInstantSplit.target.hp.current * 0.5f);
    effectInstantSplit.target.hp.max = effectInstantSplit.target.hp.current;
    effectInstantSplit.target.data.value = Mathf.CeilToInt((float) effectInstantSplit.target.data.value * 0.5f);
    effectInstantSplit.target.ResetWhenHealthLostEffects();
    List<StatusEffectApply> statusesToApply = effectInstantSplit.target.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.count > e.temporary && e.isStatus)).Select<StatusEffectData, StatusEffectApply>((Func<StatusEffectData, StatusEffectApply>) (e => new StatusEffectApply(e.applier, (Entity) null, e.GetOriginal(), Mathf.CeilToInt((float) (e.count - e.temporary) * 0.5f)))).ToList<StatusEffectApply>();
    Routine.Clump clump = new Routine.Clump();
    foreach (StatusEffectData statusEffectData in effectInstantSplit.target.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.isStatus && e.count > e.temporary)))
    {
      int amount = statusEffectData.count - statusEffectData.temporary;
      if (amount > 0)
        clump.Add(statusEffectData.RemoveStacks(amount, false));
    }
    yield return (object) clump.WaitForEnd();
    yield return (object) effectInstantSplit.CreateNewCards(1);
    Entity newCard = effectInstantSplit.newCards[0];
    foreach (StatusEffectApply statusEffectApply in statusesToApply)
    {
      clump.Add(StatusEffectSystem.Apply(newCard, statusEffectApply.applier, statusEffectApply.effectData, statusEffectApply.count, fireEvents: false));
      clump.Add(StatusEffectSystem.Apply(effectInstantSplit.target, statusEffectApply.applier, statusEffectApply.effectData, statusEffectApply.count, fireEvents: false));
    }
    yield return (object) clump.WaitForEnd();
    Dictionary<Entity, List<CardSlot>> shoveData;
    if (ShoveSystem.CanShove(effectInstantSplit.target, effectInstantSplit.target.owner.entity, out shoveData))
    {
      CardContainer toContainer = effectInstantSplit.target.actualContainers[0];
      yield return (object) ShoveSystem.DoShove(shoveData, true);
      toContainer.Add(newCard);
      newCard.transform.position = newCard.GetContainerWorldPosition();
      newCard.wobbler.WobbleRandom();
      effectInstantSplit.target.wobbler.WobbleRandom();
      toContainer = (CardContainer) null;
    }
    yield return (object) effectInstantSplit.EnableCards((IEnumerable<Entity>) effectInstantSplit.newCards);
  }

  public IEnumerator SplitDoubleHeight()
  {
    StatusEffectInstantSplit effectInstantSplit = this;
    effectInstantSplit.target.hp.current = Mathf.CeilToInt((float) effectInstantSplit.target.hp.current * 0.5f);
    effectInstantSplit.target.hp.max = effectInstantSplit.target.hp.current;
    effectInstantSplit.target.data.value = Mathf.CeilToInt((float) effectInstantSplit.target.data.value * 0.5f);
    yield return (object) effectInstantSplit.CreateNewCards(2);
    List<StatusEffectData> list = effectInstantSplit.target.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => e.count > e.temporary && e.isStatus)).ToList<StatusEffectData>();
    Routine.Clump clump = new Routine.Clump();
    foreach (StatusEffectData effectData in list)
    {
      int count = Mathf.CeilToInt((float) (effectData.count - effectData.temporary) * 0.5f);
      foreach (Entity newCard in effectInstantSplit.newCards)
        clump.Add(StatusEffectSystem.Apply(newCard, effectData.applier, effectData, count, fireEvents: false));
    }
    yield return (object) clump.WaitForEnd();
    Vector3 position = effectInstantSplit.target.transform.position;
    for (int index = 0; index < effectInstantSplit.newCards.Count; ++index)
    {
      Entity newCard = effectInstantSplit.newCards[index];
      effectInstantSplit.target.actualContainers[index % effectInstantSplit.target.actualContainers.Count].Add(newCard);
      Transform transform = newCard.transform;
      Vector3 containerWorldPosition = newCard.GetContainerWorldPosition();
      Vector3 vector3 = Vector3.Lerp(position, containerWorldPosition, 0.1f);
      transform.position = vector3;
      LeanTween.move(newCard.gameObject, containerWorldPosition, PettyRandom.Range(0.8f, 1.2f)).setEaseOutElastic();
      newCard.wobbler.WobbleRandom();
    }
    foreach (PlayAction action in ActionQueue.GetActions())
    {
      if (action is ActionTriggerAgainst actionTriggerAgainst)
      {
        int[] rows = References.Battle.GetRowIndices(actionTriggerAgainst.entity);
        Entity[] array = effectInstantSplit.newCards.Where<Entity>((Func<Entity, bool>) (a => ((IList<int>) References.Battle.GetRowIndices(a)).ContainsAny<int>((IEnumerable<int>) rows))).ToArray<Entity>();
        actionTriggerAgainst.target = array.Length != 0 ? array.RandomItem<Entity>() : effectInstantSplit.newCards.RandomItem<Entity>();
      }
    }
    effectInstantSplit.target.RemoveFromContainers();
    CardManager.ReturnToPool(effectInstantSplit.target);
    yield return (object) effectInstantSplit.EnableCards((IEnumerable<Entity>) effectInstantSplit.newCards);
  }

  public IEnumerator EnableCards(IEnumerable<Entity> cards)
  {
    StatusEffectInstantSplit effectInstantSplit = this;
    MinibossIntroSystem minibossIntroSystem = UnityEngine.Object.FindObjectOfType<MinibossIntroSystem>();
    foreach (Entity card in cards)
    {
      if ((bool) (UnityEngine.Object) minibossIntroSystem)
        minibossIntroSystem.Ignore(card);
      CardContainer[] array = card.actualContainers.ToArray();
      card.enabled = true;
      card.RemoveFromContainers();
      card.owner.reserveContainer.Add(card);
      yield return (object) new ActionMove(card, array).Run();
      ActionRunEnableEvent action = new ActionRunEnableEvent(card);
      action.priority = effectInstantSplit.eventPriority;
      ActionQueue.Stack((PlayAction) action, true);
    }
  }

  public IEnumerator CreateNewCards(int count)
  {
    StatusEffectInstantSplit effectInstantSplit = this;
    CardController controller = effectInstantSplit.target.display.hover.controller;
    Character owner = effectInstantSplit.target.owner;
    Routine.Clump clump = new Routine.Clump();
    for (int index = 0; index < count; ++index)
    {
      CardData data = effectInstantSplit.target.data;
      foreach (StatusEffectInstantSplit.Profile profile in effectInstantSplit.profiles)
      {
        if (profile.cardName == data.name)
        {
          data = AddressableLoader.Get<CardData>("CardData", profile.changeToCardName);
          break;
        }
      }
      clump.Add(StatusEffectInstantSplit.CreateCard(effectInstantSplit.target.data, data, controller, owner, new UnityAction<Card>(effectInstantSplit.\u003CCreateNewCards\u003Eb__7_0)));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity newCard in effectInstantSplit.newCards)
      clump.Add(effectInstantSplit.CopyEntity(newCard, effectInstantSplit.target));
    yield return (object) clump.WaitForEnd();
  }

  public static IEnumerator CreateCard(
    CardData original,
    CardData cardData,
    CardController controller,
    Character owner,
    UnityAction<Card> onComplete)
  {
    CardData data = cardData.Clone();
    ulong num;
    original.TryGetCustomData<ulong>("splitOriginalId", out num, original.id);
    data.SetCustomData("splitOriginalId", (object) num);
    Card card = CardManager.Get(data, controller, owner, true, owner.team == References.Player.team);
    card.entity.startingEffectsApplied = true;
    UnityAction<Card> unityAction = onComplete;
    if (unityAction != null)
      unityAction(card);
    yield return (object) card.UpdateData(false);
  }

  public IEnumerator CopyEntity(Entity entity, Entity toCopy)
  {
    StatusEffectInstantSplit effectInstantSplit = this;
    foreach (StatusEffectData effectData in toCopy.statusEffects.Where<StatusEffectData>(new Func<StatusEffectData, bool>(effectInstantSplit.\u003CCopyEntity\u003Eb__9_0)).ToList<StatusEffectData>())
      yield return (object) StatusEffectSystem.Apply(entity, effectData.applier, effectData, effectData.count - effectData.temporary, fireEvents: false);
    foreach (Entity.TraitStacks trait in toCopy.traits)
    {
      int count = trait.count - trait.tempCount;
      if (count > 0)
        entity.GainTrait(trait.data, count);
    }
    entity.attackEffects = ((IEnumerable<CardData.StatusEffectStacks>) CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) entity.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) toCopy.attackEffects)).Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToList<CardData.StatusEffectStacks>();
    entity.hp = toCopy.hp;
    entity.damage = toCopy.damage;
    entity.counter = toCopy.counter;
    if (entity.counter.current <= 0)
      entity.counter.Max();
    entity.uses = toCopy.uses;
    entity.display.promptUpdateDescription = true;
    entity.ResetWhenHealthLostEffects();
    entity.PromptUpdate();
    yield return (object) entity.UpdateTraits();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();

  [CompilerGenerated]
  public void \u003CCreateNewCards\u003Eb__7_0(Card c) => this.newCards.Add(c.entity);

  [CompilerGenerated]
  public bool \u003CCopyEntity\u003Eb__9_0(StatusEffectData e)
  {
    return e.count > e.temporary && e.HasDescOrIsKeyword && (UnityEngine.Object) e != (UnityEngine.Object) this;
  }

  [Serializable]
  public struct Profile
  {
    public string cardName;
    public string changeToCardName;
  }
}
