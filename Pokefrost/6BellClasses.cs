// Decompiled with JetBrains decompiler
// Type: Pokefrost.RecallToTopModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class RecallToTopModifierSystem : GameSystem
  {
    public RecallToTopModifierSystem.Container toContainer = RecallToTopModifierSystem.Container.Hand;

    public void OnEnable()
    {
      global::Events.OnActionQueued += new UnityAction<PlayAction>(this.EntityDiscard);
    }

    public void OnDisable()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.EntityDiscard);
    }

    public void EntityDiscard(PlayAction action)
    {
      if (!(action is ActionMove actionMove) || !actionMove.toContainers.Contains<CardContainer>(References.Player.discardContainer) || !Battle.IsOnBoard(actionMove.entity.containers))
        return;
      Debug.Log((object) ("[Pokefrost] " + actionMove.entity.containers.ToString()));
      this.StartCoroutine(this.PutOnTop(actionMove.entity));
    }

    private IEnumerator PutOnTop(Entity target)
    {
      Debug.Log((object) "[Pokefrost] Here!");
      yield return (object) new WaitUntil((Func<bool>) (() => ActionQueue.Empty));
      CardContainer cc = References.Player.drawContainer;
      int index1 = cc.Count;
      CardPocketSequence sequence = UnityEngine.Object.FindObjectOfType<CardPocketSequence>();
      CardPocketSequence.Card card = (CardPocketSequence.Card) null;
      if ((UnityEngine.Object) sequence != (UnityEngine.Object) null)
      {
        int i = 0;
        while (sequence.cards.Count > 0)
        {
          if ((UnityEngine.Object) sequence.cards[i].entity == (UnityEngine.Object) target)
          {
            card = sequence.cards[i];
            target.transform.SetParent(MonoBehaviourSingleton<References>.instance.transform, true);
            sequence.cards.RemoveAt(i);
            break;
          }
          ++i;
        }
        sequence.promptEnd = true;
        yield return (object) new WaitUntil((Func<bool>) (() => !sequence.isActiveAndEnabled));
        card.Reset();
        card.Return();
        yield return (object) new WaitForSeconds(0.25f);
      }
      if (cc.Contains(target))
        --index1;
      yield return (object) Sequences.CardMove(target, new CardContainer[1]
      {
        cc
      }, index1);
      CardContainer[] cardContainerArray = target.preContainers;
      for (int index2 = 0; index2 < cardContainerArray.Length; ++index2)
      {
        CardContainer c = cardContainerArray[index2];
        c.TweenChildPositions();
        c = (CardContainer) null;
      }
      cardContainerArray = (CardContainer[]) null;
      if (!target.preContainers.Contains<CardContainer>(cc))
        cc.TweenChildPositions();
    }

    public enum Container
    {
      DrawPile,
      Hand,
      DiscardPile,
    }
  }
}
