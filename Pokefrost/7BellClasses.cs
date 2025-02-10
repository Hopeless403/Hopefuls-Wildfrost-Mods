// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptRunScriptsOnDeckAlt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class ScriptRunScriptsOnDeckAlt : Script
  {
    [SerializeField]
    public CardScript[] scripts;
    [SerializeField]
    public TargetConstraint[] constraints;
    [SerializeField]
    public Vector2Int countRange;
    [SerializeField]
    public bool includeReserve;

    public override IEnumerator Run()
    {
      List<CardData> list = new List<CardData>();
      ScriptRunScriptsOnDeckAlt.AddRangeIfConstraints((ICollection<CardData>) list, References.PlayerData.inventory.deck, this.constraints);
      if (this.includeReserve)
        ScriptRunScriptsOnDeckAlt.AddRangeIfConstraints((ICollection<CardData>) list, References.PlayerData.inventory.reserve, this.constraints);
      if (list.Count > 0)
      {
        this.Affect((IReadOnlyCollection<CardData>) list);
        yield break;
      }
    }

    public static void AddRangeIfConstraints(
      ICollection<CardData> collection,
      CardDataList toAdd,
      TargetConstraint[] constraints)
    {
      foreach (CardData cardData in toAdd)
        ScriptRunScriptsOnDeckAlt.AddIfConstraints(collection, cardData, constraints);
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
      foreach (CardData target in (IEnumerable<CardData>) cards.InRandomOrder<CardData>())
      {
        foreach (CardScript script in this.scripts)
          script.Run(target);
        --num;
        if (num <= 0)
          break;
      }
    }
  }
}
