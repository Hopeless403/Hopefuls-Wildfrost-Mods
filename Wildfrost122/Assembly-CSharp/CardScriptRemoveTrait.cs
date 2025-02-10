// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
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
