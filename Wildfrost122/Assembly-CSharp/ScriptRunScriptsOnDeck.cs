// Decompiled with JetBrains decompiler
// Type: ScriptRunScriptsOnDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
[CreateAssetMenu(fileName = "Run Scripts On Deck", menuName = "Scripts/Run Scripts On Deck")]
public class ScriptRunScriptsOnDeck : Script
{
  [SerializeField]
  private AssetReferenceT<CardScript>[] scriptRefs;
  [SerializeField]
  private TargetConstraint[] constraints;
  [SerializeField]
  private Vector2Int countRange;
  [SerializeField]
  private bool includeReserve;

  public override IEnumerator Run()
  {
    List<CardData> cardDataList = new List<CardData>();
    ScriptRunScriptsOnDeck.AddRangeIfConstraints((ICollection<CardData>) cardDataList, References.PlayerData.inventory.deck, this.constraints);
    if (this.includeReserve)
      ScriptRunScriptsOnDeck.AddRangeIfConstraints((ICollection<CardData>) cardDataList, References.PlayerData.inventory.reserve, this.constraints);
    if (cardDataList.Count > 0)
    {
      this.Affect((IReadOnlyCollection<CardData>) cardDataList);
      yield break;
    }
  }

  private static void AddRangeIfConstraints(
    ICollection<CardData> collection,
    CardDataList toAdd,
    TargetConstraint[] constraints)
  {
    foreach (CardData cardData in toAdd)
      ScriptRunScriptsOnDeck.AddIfConstraints(collection, cardData, constraints);
  }

  private static void AddIfConstraints(
    ICollection<CardData> collection,
    CardData item,
    TargetConstraint[] constraints)
  {
    if (((IEnumerable<TargetConstraint>) constraints).Any<TargetConstraint>((Func<TargetConstraint, bool>) (c => !c.Check(item))))
      return;
    collection.Add(item);
  }

  private void Affect(IReadOnlyCollection<CardData> cards)
  {
    int num = this.countRange.Random();
    Debug.Log((object) ("[" + this.name + "] Affecting [" + string.Join<CardData>(", ", (IEnumerable<CardData>) cards) + "]"));
    using (AddressableGroup<CardScript> addressableGroup = new AddressableGroup<CardScript>(this.scriptRefs))
    {
      foreach (CardData target in (IEnumerable<CardData>) cards.InRandomOrder<CardData>())
      {
        foreach (CardScript cardScript in addressableGroup)
          cardScript.Run(target);
        --num;
        if (num <= 0)
          break;
      }
    }
  }
}
