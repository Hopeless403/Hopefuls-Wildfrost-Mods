// Decompiled with JetBrains decompiler
// Type: CardScriptRemovePassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Remove Passive Effect", menuName = "Card Scripts/Remove Passive Effect")]
public class CardScriptRemovePassiveEffect : CardScript
{
  [SerializeField]
  private bool removeAll;
  [SerializeField]
  [HideIf("removeAll")]
  private StatusEffectData[] toRemove;
  [SerializeField]
  [ShowIf("removeAll")]
  private bool excludingStatusEffects;
  [SerializeField]
  [ShowIf("removeAll")]
  private StatusEffectData[] excluding;
  [SerializeField]
  [ShowIf("removeAll")]
  private string[] excludingTypes;
  [InfoBox("if set to ZERO it will remove all stacks", EInfoBoxType.Normal)]
  [SerializeField]
  private int reduceStacks;

  public override void Run(CardData target)
  {
    List<CardData.StatusEffectStacks> list = target.startWithEffects.ToList<CardData.StatusEffectStacks>();
    if (this.removeAll)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks statusEffectStacks = list[index];
        if (!this.Exclude(statusEffectStacks.data) && (!this.excludingStatusEffects || !statusEffectStacks.data.isStatus))
        {
          statusEffectStacks.count -= this.reduceStacks;
          if (this.reduceStacks <= 0 || statusEffectStacks.count <= 0)
            list.RemoveAt(index);
        }
      }
    }
    else if (this.reduceStacks <= 0)
    {
      list.RemoveAll((Predicate<CardData.StatusEffectStacks>) (a => this.toRemove.Contains<StatusEffectData>(a.data)));
    }
    else
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks statusEffectStacks = list[index];
        if (this.toRemove.Contains<StatusEffectData>(statusEffectStacks.data))
        {
          statusEffectStacks.count -= this.reduceStacks;
          if (statusEffectStacks.count <= 0)
            list.RemoveAt(index);
        }
      }
    }
    target.startWithEffects = list.ToArray();
  }

  private bool Exclude(StatusEffectData effectData)
  {
    if (this.excluding.Contains<StatusEffectData>(effectData))
      return true;
    return !effectData.type.IsNullOrEmpty() && this.excludingTypes.Contains<string>(effectData.type);
  }
}
