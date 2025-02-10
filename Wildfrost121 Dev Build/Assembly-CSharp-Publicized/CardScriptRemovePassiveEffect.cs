// Decompiled with JetBrains decompiler
// Type: CardScriptRemovePassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Remove Passive Effect", menuName = "Card Scripts/Remove Passive Effect")]
public class CardScriptRemovePassiveEffect : CardScript
{
  [SerializeField]
  public bool removeAll;
  [SerializeField]
  [HideIf("removeAll")]
  public StatusEffectData[] toRemove;
  [SerializeField]
  [ShowIf("removeAll")]
  public bool excludingStatusEffects;
  [SerializeField]
  [ShowIf("removeAll")]
  public StatusEffectData[] excluding;
  [SerializeField]
  [ShowIf("removeAll")]
  public string[] excludingTypes;
  [InfoBox("if set to ZERO it will remove all stacks", EInfoBoxType.Normal)]
  [SerializeField]
  public int reduceStacks;

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

  public bool Exclude(StatusEffectData effectData)
  {
    if (this.excluding.Contains<StatusEffectData>(effectData))
      return true;
    return !effectData.type.IsNullOrEmpty() && this.excludingTypes.Contains<string>(effectData.type);
  }

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__6_0(CardData.StatusEffectStacks a)
  {
    return this.toRemove.Contains<StatusEffectData>(a.data);
  }
}
