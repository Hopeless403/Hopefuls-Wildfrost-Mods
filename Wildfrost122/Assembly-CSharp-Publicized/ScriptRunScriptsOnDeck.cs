// Decompiled with JetBrains decompiler
// Type: ScriptRunScriptsOnDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public AssetReferenceT<CardScript>[] scriptRefs;
  [SerializeField]
  public TargetConstraint[] constraints;
  [SerializeField]
  public Vector2Int countRange;
  [SerializeField]
  public bool includeReserve;

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

  public static void AddRangeIfConstraints(
    ICollection<CardData> collection,
    CardDataList toAdd,
    TargetConstraint[] constraints)
  {
    foreach (CardData cardData in toAdd)
      ScriptRunScriptsOnDeck.AddIfConstraints(collection, cardData, constraints);
  }

  public static void AddIfConstraints(
    ICollection<CardData> collection,
    CardData item,
    TargetConstraint[] constraints)
  {
    if (((IEnumerable<TargetConstraint>) constraints).Any<TargetConstraint>((Func<TargetConstraint, bool>) (c => !c.Check(item))))
      return;
    collection.Add(item);
  }

  public void Affect(IReadOnlyCollection<CardData> cards)
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
