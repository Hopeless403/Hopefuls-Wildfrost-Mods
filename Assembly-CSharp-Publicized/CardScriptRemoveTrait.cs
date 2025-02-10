// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "Remove Trait", menuName = "Card Scripts/Remove Trait")]
public class CardScriptRemoveTrait : CardScript
{
  [SerializeField]
  public bool removeAll;
  [SerializeField]
  [HideIf("removeAll")]
  public TraitData[] toRemove;
  [SerializeField]
  [ShowIf("removeAll")]
  public TraitData[] excluding;

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

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__3_0(CardData.TraitStacks a) => this.excluding.Contains<TraitData>(a.data);

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__3_1(CardData.TraitStacks a) => this.toRemove.Contains<TraitData>(a.data);
}
