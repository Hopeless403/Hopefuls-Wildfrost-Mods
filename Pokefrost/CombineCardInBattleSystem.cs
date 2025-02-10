// Decompiled with JetBrains decompiler
// Type: Pokefrost.CombineCardInBattleSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
namespace Pokefrost
{
  public class CombineCardInBattleSystem : GameSystem
  {
    [SerializeField]
    public string combineSceneName;
    [SerializeField]
    public CombineCardInBattleSystem.Combo[] combos;

    public void OnEnable()
    {
      global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityEnterHand);
      this.combineSceneName = "CardCombine";
      this.combos = new CombineCardInBattleSystem.Combo[1]
      {
        new CombineCardInBattleSystem.Combo()
        {
          cardNames = new string[2]
          {
            "LuminSealant",
            "BrokenVase"
          },
          resultingCardName = "LuminVase"
        }
      };
    }

    public void OnDisable()
    {
      global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityEnterHand);
    }

    public void EntityEnterHand(Entity entity)
    {
      foreach (CombineCardInBattleSystem.Combo combo in this.combos)
      {
        List<Entity> deck = new List<Entity>();
        deck.Add(entity);
        deck.AddRange((IEnumerable<Entity>) References.Player.handContainer.ToList<Entity>());
        deck.AddRange((IEnumerable<Entity>) References.Player.drawContainer.ToList<Entity>());
        deck.AddRange((IEnumerable<Entity>) References.Player.discardContainer.ToList<Entity>());
        Debug.Log((object) ("[Pokefrost] " + deck[0].name));
        if (combo.cardNames.Contains<string>(entity.data.name) && combo.AllCardsInDeck(deck))
        {
          Debug.Log((object) "[Pokefrost] Found Lumin Parts");
          this.StopAllCoroutines();
          ActionQueue.Stack((PlayAction) new CombineCardInBattleSystem.CombineAction()
          {
            combineSceneName = this.combineSceneName,
            tooFuse = combo.FindCards(deck),
            combo = combo
          });
          break;
        }
      }
    }

    [Serializable]
    public struct Combo
    {
      public string[] cardNames;
      public string resultingCardName;

      public bool AllCardsInDeck(List<Entity> deck)
      {
        bool flag = true;
        foreach (string cardName in this.cardNames)
        {
          if (!this.HasCard(cardName, deck))
          {
            flag = false;
            break;
          }
        }
        return flag;
      }

      public List<Entity> FindCards(List<Entity> deck)
      {
        List<Entity> cards = new List<Entity>();
        foreach (string cardName in this.cardNames)
        {
          foreach (Entity entity in deck)
          {
            if (entity.data.name == cardName)
            {
              cards.Add(entity);
              break;
            }
          }
        }
        return cards;
      }

      public bool HasCard(string cardName, List<Entity> deck)
      {
        foreach (Entity entity in deck)
        {
          if (entity.data.name == cardName)
            return true;
        }
        return false;
      }
    }

    public class CombineAction : PlayAction
    {
      [SerializeField]
      public string combineSceneName;
      public CombineCardInBattleSystem.Combo combo;
      public List<Entity> tooFuse;

      public override IEnumerator Run() => this.CombineSequence(this.combo, this.tooFuse);

      public IEnumerator CombineSequence(
        CombineCardInBattleSystem.Combo combo,
        List<Entity> tooFuse)
      {
        CombineCardSequence combineSequence = (CombineCardSequence) null;
        yield return (object) SceneManager.Load(this.combineSceneName, SceneType.Temporary, (Action<Scene>) (scene => combineSequence = scene.FindObjectOfType<CombineCardSequence>()));
        if ((bool) (UnityEngine.Object) combineSequence)
          yield return (object) combineSequence.Run2(tooFuse, combo.resultingCardName);
        yield return (object) SceneManager.Unload(this.combineSceneName);
      }
    }
  }
}
