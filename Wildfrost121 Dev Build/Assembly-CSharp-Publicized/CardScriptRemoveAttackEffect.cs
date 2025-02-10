// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Remove Attack Effect", menuName = "Card Scripts/Remove Attack Effect")]
public class CardScriptRemoveAttackEffect : CardScript
{
  [SerializeField]
  public bool removeAll;
  [SerializeField]
  [HideIf("removeAll")]
  public StatusEffectData[] toRemove;

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

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__2_0(CardData.StatusEffectStacks a)
  {
    return this.toRemove.Contains<StatusEffectData>(a.data);
  }
}
