// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;

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
