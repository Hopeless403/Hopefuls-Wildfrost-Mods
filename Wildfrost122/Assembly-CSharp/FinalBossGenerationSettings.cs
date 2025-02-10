// Decompiled with JetBrains decompiler
// Type: FinalBossGenerationSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Campaign/Final Boss Generation Settings", fileName = "FinalBossGenerationSettings")]
public class FinalBossGenerationSettings : ScriptableObject
{
  [Header("Replace cards...")]
  [SerializeField]
  private FinalBossGenerationSettings.ReplaceCard[] replaceCards;
  [Header("Things to ignore...")]
  [SerializeField]
  private CardUpgradeData[] ignoreUpgrades;
  [SerializeField]
  private TraitData[] ignoreTraits;
  [Header("Effects to change...")]
  [SerializeField]
  private FinalBossEffectSwapper[] effectSwappers;
  [Header("Scripts to run on cards...")]
  [SerializeField]
  private CardScript[] runOnAll;
  [SerializeField]
  private FinalBossCardModifier[] cardModifiers;
  [SerializeField]
  private CardScript[] leaderScripts;
  [Header("New enemies to add")]
  [SerializeField]
  private FinalBossEnemyGenerator[] enemyOptions;

  public void ReplaceCards(IList<CardData> cards)
  {
    foreach (FinalBossGenerationSettings.ReplaceCard replaceCard in this.replaceCards)
    {
      FinalBossGenerationSettings.ReplaceCard replace = replaceCard;
      foreach (CardData cardData1 in cards.Where<CardData>((Func<CardData, bool>) (a => a.name == replace.card.name)).ToArray<CardData>())
      {
        int index = cards.IndexOf(cardData1);
        CardData cardData2 = replace.options.RandomItem<CardData>();
        cards.RemoveAt(index);
        cards.Insert(index, cardData2);
        Debug.Log((object) (replace.card.name + " Replaced With " + cardData2.name));
      }
    }
  }

  public void Process(CardData leader, IList<CardData> cards)
  {
    FinalBossGenerationSettings.RemoveInjuries((IEnumerable<CardData>) cards);
    this.RemoveUpgrades(cards);
    this.RemoveTraits(cards);
    this.ProcessEffects((IEnumerable<CardData>) cards);
    this.RunScripts(leader, cards);
  }

  public IEnumerable<CardData> GenerateBonusEnemies(
    int count,
    IEnumerable<CardData> basedOnDeck,
    CardData[] defaultEnemies)
  {
    WeightedRandomPool<CardData> weightedRandomPool = new WeightedRandomPool<CardData>();
    foreach (CardData cardData in basedOnDeck)
    {
      CardData card = cardData;
      FinalBossEnemyGenerator bossEnemyGenerator = ((IEnumerable<FinalBossEnemyGenerator>) this.enemyOptions).FirstOrDefault<FinalBossEnemyGenerator>((Func<FinalBossEnemyGenerator, bool>) (a => ((IEnumerable<CardData>) a.fromCards).Any<CardData>((Func<CardData, bool>) (b => b.name == card.name))));
      if ((bool) (UnityEngine.Object) bossEnemyGenerator)
      {
        weightedRandomPool.Add(bossEnemyGenerator.enemy);
        Debug.Log((object) string.Format("{0} added to weighted pool", (object) bossEnemyGenerator.enemy));
      }
    }
    List<CardData> bonusEnemies = new List<CardData>();
    int num = Mathf.Min(count, weightedRandomPool.Count);
    for (int index = 0; index < num; ++index)
    {
      CardData cardData = weightedRandomPool.Pull().Clone();
      bonusEnemies.Add(cardData);
    }
    if (bonusEnemies.Count < count)
    {
      foreach (CardData cardData in (IEnumerable<CardData>) ((IEnumerable<CardData>) defaultEnemies).InRandomOrder<CardData>())
      {
        bonusEnemies.Add(cardData.Clone());
        if (bonusEnemies.Count >= count)
          break;
      }
    }
    return (IEnumerable<CardData>) bonusEnemies;
  }

  private static void RemoveInjuries(IEnumerable<CardData> cards)
  {
    foreach (CardData card in cards)
    {
      if (card.injuries != null && card.injuries.Count > 0)
      {
        card.injuries.Clear();
        Debug.Log((object) ("Injuries removed from " + card.name));
      }
    }
  }

  private void RemoveUpgrades(IList<CardData> cards)
  {
    foreach (CardUpgradeData ignoreUpgrade in this.ignoreUpgrades)
    {
      foreach (CardData card in (IEnumerable<CardData>) cards)
      {
        if (card.upgrades.Contains(ignoreUpgrade))
        {
          ignoreUpgrade.UnAssign(card);
          Debug.Log((object) ("[" + ignoreUpgrade.name + "] Removed from " + card.name));
        }
      }
    }
  }

  private void ProcessEffects(IEnumerable<CardData> cards)
  {
    Dictionary<string, FinalBossEffectSwapper> dictionary = new Dictionary<string, FinalBossEffectSwapper>();
    foreach (FinalBossEffectSwapper effectSwapper in this.effectSwappers)
      dictionary[effectSwapper.effect.name] = effectSwapper;
    foreach (CardData card in cards)
    {
      for (int stackIndex = card.startWithEffects.Length - 1; stackIndex >= 0; --stackIndex)
      {
        CardData.StatusEffectStacks startWithEffect = card.startWithEffects[stackIndex];
        FinalBossEffectSwapper bossEffectSwapper;
        if ((bool) (UnityEngine.Object) startWithEffect.data && dictionary.TryGetValue(startWithEffect.data.name, out bossEffectSwapper))
          bossEffectSwapper.Process(card, startWithEffect, stackIndex);
      }
    }
  }

  private void RemoveTraits(IList<CardData> cards)
  {
    foreach (TraitData ignoreTrait in this.ignoreTraits)
    {
      TraitData trait = ignoreTrait;
      foreach (CardData card in (IEnumerable<CardData>) cards)
      {
        CardData.TraitStacks traitStacks = card.traits.FirstOrDefault<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (a => a.data.name == trait.name));
        if (traitStacks != null)
        {
          card.traits.Remove(traitStacks);
          Debug.Log((object) string.Format("[{0}] Removed from {1}", (object) trait, (object) card.name));
        }
      }
    }
  }

  private void RunScripts(CardData leader, IList<CardData> cards)
  {
    foreach (CardScript cardScript in this.runOnAll)
    {
      foreach (CardData card in (IEnumerable<CardData>) cards)
      {
        Debug.Log((object) ("Running [" + cardScript.name + "] on " + card.name));
        cardScript.Run(card);
      }
    }
    foreach (CardData card1 in (IEnumerable<CardData>) cards)
    {
      CardData card = card1;
      FinalBossCardModifier bossCardModifier = ((IEnumerable<FinalBossCardModifier>) this.cardModifiers).FirstOrDefault<FinalBossCardModifier>((Func<FinalBossCardModifier, bool>) (a => a.card.name == card.name));
      if ((bool) (UnityEngine.Object) bossCardModifier)
        bossCardModifier.Run(card);
    }
    if (!(bool) (UnityEngine.Object) leader)
      return;
    foreach (CardScript leaderScript in this.leaderScripts)
      leaderScript.Run(leader);
  }

  [Serializable]
  private struct ReplaceCard
  {
    public CardData card;
    public CardData[] options;
  }
}
