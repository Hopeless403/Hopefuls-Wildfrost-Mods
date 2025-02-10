// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Remove Trait", menuName = "Card Scripts/Remove Trait")]
public class CardScriptRemoveTrait : CardScript
{
  [SerializeField]
  private bool removeAll;
  [SerializeField]
  [HideIf("removeAll")]
  private TraitData[] toRemove;
  [SerializeField]
  [ShowIf("removeAll")]
  private TraitData[] excluding;

  public override void Run(CardData target)
  {
    if (this.removeAll)
    {
      target.traits = target.traits.Where<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (a => this.excluding.Contains<TraitData>(a.data))).ToList<CardData.TraitStacks>();
    }
    else
    {
      List<CardData.TraitStacks> list = target.traits.ToList<CardData.TraitStacks>();
      list.RemoveAll((Predicate<CardData.TraitStacks>) (a => this.toRemove.Contains<TraitData>(a.data)));
      target.traits = list.ToList<CardData.TraitStacks>();
    }
  }
}
