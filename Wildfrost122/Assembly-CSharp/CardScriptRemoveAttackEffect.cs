// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Remove Attack Effect", menuName = "Card Scripts/Remove Attack Effect")]
public class CardScriptRemoveAttackEffect : CardScript
{
  [SerializeField]
  private bool removeAll;
  [SerializeField]
  [HideIf("removeAll")]
  private StatusEffectData[] toRemove;

  public override void Run(CardData target)
  {
    if (this.removeAll)
    {
      target.attackEffects = Array.Empty<CardData.StatusEffectStacks>();
    }
    else
    {
      List<CardData.StatusEffectStacks> list = target.attackEffects.ToList<CardData.StatusEffectStacks>();
      list.RemoveAll((Predicate<CardData.StatusEffectStacks>) (a => this.toRemove.Contains<StatusEffectData>(a.data)));
      target.attackEffects = list.ToArray();
    }
  }
}
